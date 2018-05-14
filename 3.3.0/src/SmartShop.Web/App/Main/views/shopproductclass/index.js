(function () {
	angular.module('app').controller('app.views.shopproductclass.index', [
		'$scope', '$timeout', '$uibModal', 'abp.services.app.shopProductClass',
		function ($scope, $timeout, $uibModal, shopProductClassService) {
			var vm = this;

			vm.shopProductClasses = [];

			function getShopProductClasses() {
				shopProductClassService.getAllShopProductClasses({}).then(function (result) {
					vm.shopProductClasses = result.data.shopProductClasses;
				});
			}

			vm.openShopProductClassCreationModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/shopproductclass/createModal.cshtml',
                    controller: 'app.views.shopproductclass.createModal as vm',
                    backdrop: 'static'
                });

                modalInstance.rendered.then(function () {
                    $.AdminBSB.input.activate();
                });

                modalInstance.result.then(function () {
                    getShopProductClasses();
                });
            };

            vm.openShopProductClassEditModal = function (shopProductClass) {
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
                    getShopProductClasses();
                });
            };

            vm.delete = function (shopProductClass) {
                abp.message.confirm(
                    "Delete shopProductClass '" + shopProductClass.className + "'?",
                    function (result) {
                        if (result) {
							shopProductClassService.deleteShopProductClass({ id: shopProductClass.id })
                                .then(function () {
                                    abp.notify.info("Deleted shopProductClass: " + shopProductClass.className);
                                    getShopProductClasses();
                                });
                        }
                    });
            }

			vm.refresh = function () {
				getShopProductClasses();
			};

			getShopProductClasses();
		}
	]);
})();