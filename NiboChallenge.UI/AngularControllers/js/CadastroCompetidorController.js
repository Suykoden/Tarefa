var app = angular.module("app", []);
app.controller("CadastroCompetidorController", function ($scope, $http) {

    $scope.GravaDados = function () {

        $http.post('/api/Competidor', $scope.Competidor)
        .success(function (data) {
            $scope.PostDataResponse = data;
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

});