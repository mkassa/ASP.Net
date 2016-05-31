(function () {
    'use strict';

    var module = angular.module("taitu-app");

    function fetchReviews($http) {
        return $.get("/api/reviews").then(function (response) { return response.data;});
    }

     function controller ($http) {
        var vm = this;

        vm.message = "Message from a controller";
      
        vm.reviews = [];

        vm.addReview = function () {
            if (vm.newReview && vm.newRating) {
                //ReviewerName="Michael", ReviewText="Lovely atmospher, great food and service!", Rating=5
                vm.reviews.push({ reviewerName: "Michael", reviewText: vm.newReview, rating: vm.newRating })

                vm.newReview = '';
                vm.newRating = '';
                vm.isWrieRewviewActive = false;
            }
        };

        $http.get("/api/reviews")
                 .then(function (response) {
                     angular.copy(response.data, vm.reviews);
                 }
                 , function () { });

        
    };

    module.component("reviews", {
        templateUrl: "/js/components/reviews.component.html",
        controllerAs: "vm",
        controller: ["$http", controller]
    });

})();