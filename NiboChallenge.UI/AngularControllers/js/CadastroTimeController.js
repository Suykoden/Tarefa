var app = angular.module("app", []);
app.controller("CadastroTimeController", function ($scope, $http) {

    $scope.GravaDados = function () {

        $http.post('/api/Times', $scope.Competidor)
        .success(function (data) {
            $scope.PostDataResponse = data;
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

});