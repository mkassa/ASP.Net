(function () {
    'use strict';

    //getting existing module
    angular
        .module('taitu-app')
        .controller('reservationsController', ['$scope', '$http', function ($scope, $http) {

            /* jshint validthis:true */
            var vm = this;
            vm.title = 'Reservation';

            vm.reservations = []

            $http.get("/api/reservations")
                .then(function (response) {
                    angular.copy(response.data, vm.reservations);
                }
                , function () { });


            vm.selectedReservation = {};

            vm.getTemplate = function (reservation) {
                if (reservation.id = vm.selectedReservation.id)
                    return 'edit';
                else
                    return 'view';
            };

            vm.edit = function (reservation) {

                vm.selectedReservation = angular.copy(reservation);
            };

            vm.save = function (index) {

                vm.reservation[index] = angular.copy(vm.selectedReservation);
                vm.selectedReservation = {};
            };

            vm.cancel = function () {
                vm.selectedReservation = {};
            };
        }]);

})();