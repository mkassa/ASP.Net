(function () {
    'use strict';

    //getting existing module
    angular
        .module('taitu-app')
        .controller('galleryController', ['$scope', '$http', function ($scope, $http) {

            /* jshint validthis:true */
            var vm = this;
            vm.title = 'Gallery';

            vm.galleries = []

            $http.get("/api/gallery")
                .then(function (response) {
                    angular.copy(response.data, vm.galleries);
                }
                , function () { });

        
        }]);

})();