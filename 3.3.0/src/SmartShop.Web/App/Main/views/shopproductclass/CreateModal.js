(function () {
	angular.module('app').controller('app.views.shopproductclass.createModal', [
		'$scope', '$uibModalInstance', 'abp.services.app.shopProductClass',
		function ($scope, $uibModalInstance, shopProductClassService) {
			var vm = this;

			vm.shopProductClass = {
				className: '',
				description: '',
				displayOrder: ''
			};

			vm.save = function () {
				abp.ui.setBusy();
				shopProductClassService.create(vm.shopProductClass)
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