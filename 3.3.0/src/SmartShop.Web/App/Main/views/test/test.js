
(function () {
	var controllerId = 'app.views.test';
	var app = angular.module('app');

	app.controller(controllerId, ['$scope', '$location', function ($scope, $location) {
		var vm = this;
		vm.paginationConf = {
			currentPage: $location.search().currentPage ? $location.search().currentPage : 1,
			totalItems: 8000,
			itemsPerPage: 15,
			pagesLength: 15,
			perPageOptions: [10, 20, 30, 40, 50],
			onChange: function () {
				console.log($scope.paginationConf.currentPage);
				$location.search('currentPage', $scope.paginationConf.currentPage);
			}
		};
	}])
})();