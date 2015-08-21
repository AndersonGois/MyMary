/// <reference path="app.js" />
var app = angular.module("mary", []);
app.controller('ClienteController', ['$http', function ($http) {
    var store = this;

    $http.get("Cliente/Pais").success(function (data) {
        store.pais = data;
    });

    store.getEstados = function (id) {
        store.estados = [];
        store.cidades = [];
        $http.get("Cliente/Estados/" + id).success(function (data) {
            store.estados = data;
        });
    };

    
    store.getCidades = function (id) {
        store.cidades = [];
        $http.get("Cliente/Cidades/" + id).success(function (data) {
            store.cidades = data;
        });
     };
}]);


