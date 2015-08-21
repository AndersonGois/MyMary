/// <reference path="app.js" />
var app = angular.module("mary", []);
app.controller('ExampleController', ['$scope', function ($scope) {
    $scope.data = {
        singleSelect: null,
        availableOptions: [
          { id: '1', name: 'Option A' },
          { id: '2', name: 'Option B' },
          { id: '3', name: 'Option C' }
        ],
    };


    $scope.gr = {
        put : pu()  
    };
    
    
}]);
    var pu = function() {
        $.ajax({
            url: "Cliente/Teste",
            data: { Id: 2 },
            success: function(data) {
                return data;
            }
        });
    };
