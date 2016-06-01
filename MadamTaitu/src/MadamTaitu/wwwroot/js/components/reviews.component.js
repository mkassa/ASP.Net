(function () {
    'use strict';

    var module = angular.module("taitu-app");

    function fetchReviews($http) {
        return $.get("/api/reviews").then(function (response) { return response.data;});
    }

     function controller ($http) {
        var vm = this;
      
        vm.reviews = [];
        vm.newReview = { reviewerName: '', reviewText: '', rating: 0 };

        vm.$onInit = function () {
            $http.get("/api/reviews")
                     .then(function (response) {
                         angular.copy(response.data, vm.reviews);
                     }
                     , function () { })
        };

        vm.setRating = function (review, value) {
            review.rating = value;
        };

        vm.addReview = function () {
            if (vm.newReview) {
                vm.reviews.push({ reviewerName: "Michael", reviewText: vm.newReview.reviewText, rating: vm.newReview.rating })
                vm.newReview = '';
                vm.isWrieRewviewActive = false;
            }
        };

        
    };

    module.component("reviews", {
        templateUrl: "/js/components/reviews.component.html",
        controllerAs: "vm",
        controller: ["$http", controller]
    });

})();