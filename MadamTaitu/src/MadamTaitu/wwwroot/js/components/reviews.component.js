(function () {
    'use strict';

    var module = angular.module("taitu-app");

    function fetchReviews($http) {
        return $http.get("/api/reviews").then(function (response) { return response.data; });
    };

    function addReview($http, newReview, successFunction, errorFunction) {
        return $http.post("/api/reviews/add", JSON.stringify(newReview))
            .then(function (response) { successFunction(response.data) }, function () { errorFunction() });
    };

    function  getNewRevew() {
        return {
            reviewerName: ''
            , email: ''
            , comment: ''
            , rating: 0
        };
    };


     function controller ($http) {

        var vm = this;
      
        vm.reviews = [];
        vm.newReview = getNewRevew();
        vm.isWriteReviewActive = false;

        vm.$onInit = function () {
            $http.get("/api/reviews")
                     .then(function (response) {
                         angular.copy(response.data, vm.reviews);
                     }
                     , function () { })
        };

        vm.addReviewClicked = function () {
            vm.isWriteReviewActive = true;
        };

        vm.setRating = function (review, value) {
            review.rating = value;
        };

        vm.cancelReview = function (frmAddReview) {
            vm.newReview = getNewRevew();
            vm.isWriteReviewActive = false;
            frmAddReview.$setPristine();
            frmAddReview.$setUntouched();;
        };

        function newReviewAdded(review) {
            vm.reviews.unshift(review);
        };
        
        vm.addReview = function () {
            if (vm.newReview) {
                addReview($http, vm.newReview, newReviewAdded);
                vm.newReview = getNewRevew();
                vm.isWriteReviewActive = false;
            }
        };
    };

    module.component("reviews", {
        templateUrl: "/js/components/reviews.component.html",
        controllerAs: "vm",
        controller: ["$http", controller]
    });

})();