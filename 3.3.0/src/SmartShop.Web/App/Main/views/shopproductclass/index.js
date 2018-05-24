(function () {
	angular.module('app').controller('app.views.shopproductclass.index', [
		'$scope', '$location', '$timeout', '$uibModal', 'abp.services.app.shopProductClass',
		function ($scope, $location, $timeout, $uibModal, shopProductClassService) {

			//商品分类列表数据
			$scope.shopProductClasses = [];

			//配置分页基本参数
			$scope.paginationConf = {
				currentPage: $location.search().currentPage ? $location.search().currentPage : 1,// 当前页数
				totalItems: 0, // 一共多少条数据，和itemsPerPage决定一共会有几页
				itemsPerPage: 10, // 每页几条数据，和totalItems决定一共会有几页
				pagesLength: 10,
				perPageOptions: [10, 20, 30, 40, 50],
				onChange: function () {
					console.log($scope.paginationConf.currentPage);
					$location.search('currentPage', $scope.paginationConf.currentPage);
				}
			};

			//获取商品分类分页列表
			function getPagedShopProductClasses() {

				//请求参数
				var requestParams = {
					skipCount: $scope.paginationConf.currentPage == 1 ? 0 : ($scope.paginationConf.currentPage - 1) * $scope.paginationConf.itemsPerPage,
					maxResultCount: $scope.paginationConf.itemsPerPage,
					filter: '',
					sorting: ''
				};

				//请求应用服务接口
				shopProductClassService.getPagedShopProductClasses(requestParams).then(function (result) {
					$scope.shopProductClasses = result.data.items;
					$scope.paginationConf.totalItems = result.data.totalCount;
				});
			}

			//打开添加窗口
			$scope.openShopProductClassCreationModal = function () {
				var modalInstance = $uibModal.open({
					templateUrl: '/App/Main/views/shopproductclass/createModal.cshtml',
					controller: 'app.views.shopproductclass.createModal as vm',
					backdrop: 'static'
				});

				modalInstance.rendered.then(function () {
					$.AdminBSB.input.activate();
				});

				modalInstance.result.then(function () {
					getPagedShopProductClasses();
				});
			};

			//打开编辑窗口
			$scope.openShopProductClassEditModal = function (shopProductClass) {
				var modalInstance = $uibModal.open({
					templateUrl: '/App/Main/views/shopproductclass/editModal.cshtml',
					controller: 'app.views.shopproductclass.editModal as vm',
					backdrop: 'static',
					resolve: {
						id: function () {
							return user.id;
						}
					}
				});

				modalInstance.rendered.then(function () {
					$timeout(function () {
						$.AdminBSB.input.activate();
					}, 0);
				});

				modalInstance.result.then(function () {
					getPagedShopProductClasses();
				});
			};

			//删除商品分类
			$scope.delete = function (shopProductClass) {
				abp.message.confirm(
					"Delete shopProductClass '" + shopProductClass.className + "'?",
					function (result) {
						if (result) {
							shopProductClassService.deleteShopProductClass({ id: shopProductClass.id })
								.then(function () {
									abp.notify.info("Deleted shopProductClass: " + shopProductClass.className);
									getPagedShopProductClasses();
								});
						}
					});
			}

			$scope.refresh = function () {
				getPagedShopProductClasses();
			};

			getPagedShopProductClasses();

			/***************************************************************
			当页码和页面记录数发生变化时监控后台查询
			如果把currentPage和itemsPerPage分开监控的话则会触发两次后台事件。
			***************************************************************/
			$scope.$watch('paginationConf.currentPage + paginationConf.itemsPerPage', getPagedShopProductClasses);
		}
	]);
})();