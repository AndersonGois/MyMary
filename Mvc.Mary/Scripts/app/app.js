/// <reference path="app.js" />
var app = angular.module("mary", []);
app.controller('ClienteController', ['$http', function ($http) {
    var store = this;
   
    $http.get("Cliente/Teste/3").success(function (data) {
        store.pais = data;
     });


    store.teste = function(f) {
        console.log(f);
    };

    
    
}]);
   
   
