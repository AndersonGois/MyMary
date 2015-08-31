/// <reference path="app.js" />
var app = angular.module("ClienteModule", []);
app.controller('ClienteController', ['$http', function ($http) {
    var store = this;
   
    
    store.mPais = {
        singleSelect: null,
        multipleSelect: [],
    };

    store.mEstado = {
        singleSelect: null,
        multipleSelect: [],
    };

    store.mCidade = {
        singleSelect: null,
        multipleSelect: [],
    };

    store.forceUnknownOption = function () {
        store.mPais.singleSelect = { "id": 2, "name": "Japão" };
    };

    $http.get("Cliente/Pais").success(function(data) {
        store.mPais.multipleSelect = data;
    });

    store.getEstados = function (id) {
       $http.get("Cliente/Estados/" + id).success(function (data) {
           store.mEstado.multipleSelect = data;
        });
    };
   
    store.teste = function () {
        console.log(store.mPais.singleSelect);
    };

    store.getCidades = function (id) {
       $http.get("Cliente/Cidades/" + id).success(function (data) {
           store.mCidade.multipleSelect = data;
        });
    };
}]);


