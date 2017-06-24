(function () {
    'use strict';

    var module = angular.module("taitu-app");

    function controller() {
        var vm = this;
    };

    module.component("spinner", {
        templateUrl: "/js/components/spinner.component.html",
        controllerAs: "vm",
        controller: controller,
        bindings: {
            isBusy: '<'
        }
    });

})();