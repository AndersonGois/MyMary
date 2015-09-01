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

    store.mAnfitriao = {
        singleSelect: null,
        multipleSelect: [],
    };

    store.mNome = "";
    store.mData = null;
    store.mEmail = "";
    store.mNascimento = "";
    store.mTelefone = "";
    store.mCelular = "";
    store.mHorario = "";
    store.mBairro = "";
    store.mCep = "";
    store.mLogradouro = "";
    store.mNumero = "";
    store.mComplemento = "";
    
    store.forceUnknownOption = function () {
        store.mPais.singleSelect = { "id": 2, "name": "Japão" };
    };

    $http.get("Cliente/Pais").success(function (data) {
        store.mPais.multipleSelect = data;
       
    });
    
   

    store.getEstados = function (id) {
        $http.get("Cliente/Estados/" + id).success(function (data) {
            store.mEstado.multipleSelect = data;
        });
    };

    store.getAnfitriao = function (id) {
        $http.get("Cliente/Anfitrioes/" + id).success(function (data) {
            store.mAnfitriao.multipleSelect = data;
        });
    };

    store.getCidades = function (id) {
        $http.get("Cliente/Cidades/" + id).success(function (data) {
            store.mCidade.multipleSelect = data;
        });
    };

    var salvar = {
        method: 'POST',
        url: 'Cliente/Salvar/',
        data: { Cliente: Cliente }
    };

    store.Salvar = function () {
        Cliente.Endereco.Pais.Id = store.mPais.singleSelect;
        Cliente.Endereco.Estado.Id = store.mEstado.singleSelect;
        Cliente.Endereco.Cidade.Id = store.mCidade.singleSelect;
        Cliente.Endereco.Bairro = store.mBairro;
        Cliente.Endereco.Cep = store.mCep;
        Cliente.Endereco.Numero = store.mNumero;
        Cliente.Endereco.Complemento = store.mComplemento;
        Cliente.Celular = store.mCelular;
        Cliente.Data = store.mData;
        Cliente.DataNascimento = store.mNascimento;
        Cliente.Email = store.mEmail;
        Cliente.Nome = store.mNome;
        Cliente.Telefone = store.mTelefone;
        Cliente.Anfitriao.Id = store.mAnfitriao.singleSelect;
        Cliente.Horario = store.mHorario;


        $http(salvar);
        limpar();
        console.log(Cliente);

    };

    function limpar() {
        store.mPais.singleSelect = null;
        store.mEstado.singleSelect = null;
        store.mCidade.singleSelect = null;
    }
}]);

var Cliente = {
    Id: null,
    Nome: null,
    Data: null,
    Email: null,
    Horario: null,
    DataNascimento: null,
    Endereco: null,
    Telefone: null,
    Celular: null,
    TipoPele: null,
    TomDePele: null,
    FormaContato: null,
    Anfitriao: null
 };

Cliente.Endereco = {
    Id: null,
    Pais: null,
    Estado: null,
    Cidade: null,
    Bairro: null,
    Cep: null,
    Logradouro: null,
    Numero: null,
    Complemento: null
   
};

Cliente.Anfitriao = {
    Id: null,
    Nome: null
};

Cliente.Endereco.Pais = {
    Id: null,
    Descricao: null
 };

Cliente.Endereco.Estado = {
    Id: null,
    Descricao: null,
    Sigla: null
 };

Cliente.Endereco.Cidade = {
    Id: null,
    Descricao: null
};



Cliente.TipoPele = {
    Id: null,
    Descricao: null
 };

Cliente.TomDePele = {
    Id: null,
    Descricao: null
 };