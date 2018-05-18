(function () {
	angular.module('app').controller('app.views.shopproductclass.index', [
		'$scope', '$timeout', '$uibModal', 'abp.services.app.shopProductClass',
		function ($scope, $timeout, $uibModal, shopProductClassService) {

			$scope.shopProductClasses = [];
			$scope.currentPage = 1;//当前页面
			$scope.maxResultCount = 10;//每页显示数量
			$scope.totalCount = 0;//总数
			$scope.pages = 0;//总页数

			//配置参数
			$scope.conf = {
				skipCount: 0,
				maxResultCount: $scope.maxResultCount,
				filter: '',
				sorting: ''
			};

			//上一页  
			$scope.prevPage = function () {
				if ($scope.currentPage > 0) {
					$scope.currentPage--;
				}
			}
			//下一页  
			$scope.nextPage = function () {
				if ($scope.currentPage < $scope.pages - 1) {
					$scope.currentPage++;
				}
			}
			//监听搜索条件  
			$scope.$watch('search.c', function () {
				$scope.currentPage = 0;
				getPagedShopProductClasses();
			});

			//监听翻页  
			$scope.$watch('currentPage', function () {
				getPagedShopProductClasses();
			});  

			function getPagedShopProductClasses() {
				shopProductClassService.getPagedShopProductClasses($scope.conf).then(function (result) {
					$scope.shopProductClasses = result.data.items;
					$scope.totalCount = result.data.totalCount;
					$scope.pages = Math.ceil($scope.totalCount / $scope.maxResultCount); 
				});
			}

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
		}
	]);
})();