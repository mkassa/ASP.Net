(function () {
    'use strict';

    var module = angular.module("taitu-app");

    function BuildReviewStars(value, max) {
        var starStyles = [];
        for (var i = 1; i <= max; i++) {
            var startStyle = i <= value ? "glyphicon-star" : "glyphicon-star-empty";
            starStyles.push(startStyle);
        }
        return starStyles;
    };

    function controller() {
        var vm = this;

        vm.$onInit = function () {
            vm.entries = BuildReviewStars(vm.value, vm.max);
        };

        vm.$onChanges = function () {
            vm.entries = BuildReviewStars(vm.value, vm.max);
        };
    };

    module.component("rating", {
        templateUrl: "/js/components/rating.component.html",
        controllerAs: "vm",
        controller: controller,
        bindings: {
            value: '<',
            max: '<',
            setRating: '&'
        }
    });

})();