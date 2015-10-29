/// <reference path="app.js" />
var app = angular.module("ClienteModule", []);
app.controller('ClienteController', function ($scope, $http) {

    $scope.regData = /^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$/;
    $scope.mPais = {
        singleSelect: null,
        multipleSelect: [],
    };
    
    $scope.mEstado = {
        singleSelect: null,
        multipleSelect: [],
    };
    
    $scope.mCidade = {
        singleSelect: null,
        multipleSelect: [],
    };
    
    $scope.mAnfitriao = {
        singleSelect: null,
        multipleSelect: [],
    };

    $scope.mTipoPele = {
        singleSelect: null,
        multipleSelect: [],
    };

    $scope.mTomPele = {
        singleSelect: null,
        multipleSelect: [],
    };

    $scope.mFormaContato = {
        singleSelect: null,
        multipleSelect: [],
    };
    
    $scope.mNome = "";
    $scope.mData = null;
    $scope.mEmail = "";
    $scope.mNascimento = "";
    $scope.mTelefone = "";
    $scope.mCelular = "";
    $scope.mHorario = "";
    $scope.mBairro = "";
    $scope.mCep = "";
    $scope.mLogradouro = "";
    $scope.mNumero = "";
    $scope.mComplemento = "";
    $scope.forceUnknownOption = function() {
        $scope.mPais.singleSelect = { "id": 2, "name": "Japão" };
    };

  
    $scope.getFormaContato = function() {
        $http.get(window.urlAbsoluteUri + "Cliente/FormaContato").success(function (data) {
            $scope.mFormaContato.multipleSelect = data;
        });
    };

    $scope.getTipoPele = function () {
        $http.get(window.urlAbsoluteUri + "Cliente/TipoPele").success(function (data) {
            $scope.mTipoPele.multipleSelect = data;
            $scope.getTomPele();
        });
    };
    
    $scope.getTomPele = function () {
        $http.get(window.urlAbsoluteUri + "Cliente/TomPele").success(function (data) {
            $scope.mTomPele.multipleSelect = data;
        });
    };
    
    $http.get(window.urlAbsoluteUri + "Cliente/Paiz").success(function(data) {
        $scope.mPais.multipleSelect = data;
        $scope.getTipoPele();
       
    });

    $scope.getEstados = function(id) {
        $http.get(window.urlAbsoluteUri + "Cliente/Estados/" + id).success(function(data) {
            $scope.mEstado.multipleSelect = data;
        });
    };

    $scope.getAnfitriao = function(id) {
        $http.get(window.urlAbsoluteUri + "Cliente/Anfitrioes/" + id).success(function(data) {
            $scope.mAnfitriao.multipleSelect = data;
        });
    };

    $scope.getCidades = function(id) {
        $http.get(window.urlAbsoluteUri + "Cliente/Cidades/" + id).success(function(data) {
            $scope.mCidade.multipleSelect = data;
        });
    };

    var salvar = {
        method: 'POST',
        url: window.urlAbsoluteUri + 'Cliente/Salvar/',
        data: { Cliente: Cliente }
    };

    $scope.Salvar = function() {
        Cliente.Endereco.Pais.Id = $scope.mPais.singleSelect;
        Cliente.Endereco.Estado.Id = $scope.mEstado.singleSelect;
        Cliente.Endereco.Cidade.Id = $scope.mCidade.singleSelect;
        Cliente.FormaContato.Id = $scope.mFormaContato.singleSelect;
        Cliente.Endereco.Bairro = $scope.mBairro;
        Cliente.Endereco.Logradouro = $scope.mLogradouro;
        Cliente.Endereco.Cep = $scope.mCep;
        Cliente.Endereco.Numero = $scope.mNumero;
        Cliente.Endereco.Complemento = $scope.mComplemento;
        Cliente.Celular = $scope.mCelular;
        Cliente.Data = $scope.mData;
        Cliente.DataNascimento = $scope.mNascimento;
        Cliente.Email = $scope.mEmail;
        Cliente.Nome = $scope.mNome;
        Cliente.Telefone = $scope.mTelefone;
        if ($scope.mAnfitriao.singleSelect != null) {
         Cliente.Anfitriao.Id = $scope.mAnfitriao.singleSelect;
        }
        Cliente.TomDePele.Id = $scope.mTomPele.singleSelect;
        Cliente.TipoPele.Id = $scope.mTipoPele.singleSelect;
        Cliente.Horario = $scope.mHorario;
        
        $http(salvar);
        limpar();
        console.log(Cliente);
       
    };

    function limpar() {
        $scope.mPais.singleSelect = null;
        $scope.mEstado.multipleSelect = [];
        $scope.mCidade.multipleSelect = [];
        $scope.mAnfitriao.multipleSelect = [];
        $scope.mAnfitriao.singleSelect = null;
        $scope.mTipoPele.singleSelect = null;
        $scope.mFormaContato.singleSelect = null;
        $scope.mTomPele.singleSelect = null;
        $scope.mNome = "";
        $scope.mData = null;
        $scope.mEmail = "";
        $scope.mNascimento = "";
        $scope.mTelefone = "";
        $scope.mCelular = "";
        $scope.mHorario = "";
        $scope.mBairro = "";
        $scope.mCep = "";
        $scope.mLogradouro = "";
        $scope.mNumero = "";
        $scope.mComplemento = "";
    }

});

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
    Anfitriao: null
};

Cliente.FormaContato = {
    Id: null,
    Descricao: null
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

