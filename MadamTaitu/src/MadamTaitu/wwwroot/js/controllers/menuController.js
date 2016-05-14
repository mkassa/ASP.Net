(function () {
    'use strict';

    //getting existing module
    angular
        .module('taitu-app')
        .controller('menuController', ['$scope', '$http', function ($scope, $http) {

            /* jshint validthis:true */
            var vm = this;
            vm.title = 'Menu';

            vm.menus = []

            $http.get("/api/menu")
                .then(function (response) {
                    angular.copy(response.data, vm.menus);
                }
                , function () { });

            //activate();

            //function activate() { }
        }]);

})();
