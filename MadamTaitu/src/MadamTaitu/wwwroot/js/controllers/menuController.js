(function () {
    'use strict';

    //getting existing module
    angular
        .module('taitu-app')
        .controller('menuController', ['$scope', '$http', function ($scope, $http) {

            /* jshint validthis:true */
            var vm = this;
            vm.isLoadingMenu = true;
            vm.title = 'Menu';

            vm.menus = [];
            vm.groupedMenus = [];

            vm.menuGroupsByType = {};

            $http.get("/api/menu")
                .then(function (response) {
                    angular.copy(response.data, vm.menus);
                    
                    var groupLength = 3;
                    var groupedMenus = [];
                    var prevMenuCategory = '';


                    for (var i = 0; i < vm.menus.length; i++) {

                        if (i == 0) {
                            prevMenuCategory = vm.menus[i].menuCategory;
                        }

                        if (groupedMenus.length < groupLength && prevMenuCategory == vm.menus[i].menuCategory) {
                            groupedMenus.push(vm.menus[i]);
                        }

                        if (prevMenuCategory != vm.menus[i].menuCategory) {
                            vm.groupedMenus.push(groupedMenus);

                            vm.menuGroupsByType[prevMenuCategory].push(groupedMenus);

                            groupedMenus = [];
                            groupedMenus.push(vm.menus[i])
                        }
                        else if (i == vm.menus.length - 1 || groupedMenus.length == groupLength) {

                            vm.groupedMenus.push(groupedMenus);

                            if (vm.menuGroupsByType[vm.menus[i].menuCategory] == undefined)
                                vm.menuGroupsByType[vm.menus[i].menuCategory] = [groupedMenus];
                            else
                                vm.menuGroupsByType[vm.menus[i].menuCategory].push(groupedMenus);

                            groupedMenus = [];
                        }

                        prevMenuCategory = vm.menus[i].menuCategory;
                    }

                    vm.isLoadingMenu = false;
                }
                , function () { vm.isLoadingMenu = false; });

        }]);

})();
