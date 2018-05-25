(function () {
    angular.module('app').controller('app.views.shopproductclass.editModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.shopProductClass', 'id',
        function ($scope, $uibModalInstance, shopProductClassService, id) {
			var vm = this;

            vm.shopProductClass = {};

            function init() {
				shopProductClassService.getShopProductClassById({
                    id: id
                }).then(function (result) {
                    vm.shopProductClass = result.data;
                });
            }

            init();

            vm.save = function () {
                abp.ui.setBusy();
				shopProductClassService.updateShopProductClass(vm.shopProductClass)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    }).finally(function () {
                        abp.ui.clearBusy();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss();
            };
        }
    ]);
})();