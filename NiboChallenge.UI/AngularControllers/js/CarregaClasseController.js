var app = angular.module('app', []);

app.controller('CarregaClassesController', function ($scope, $http) {

    $scope.Time = {
        "id": "",
        "Nome": "",

    }

    $scope.CarregaClasses = function () {
        $http
        .get("/api/ClasseCampeao")
        .success(function (data) {
            console.log(data);
            $scope.dados = data;

            $scope.ClasseCampeao.id = data.id;
            $scope.ClasseCampeao.Nome = data.Nome;

        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    }
});