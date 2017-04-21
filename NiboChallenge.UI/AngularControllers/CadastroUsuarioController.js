var app = angular.module("app", []);
app.controller("HttpGetController", function ($scope, $http) {

    $scope.SendData = function () {

        $http.post('/api/Jogadores', $scope.Jogador)
        .success(function (data) {
            $scope.PostDataResponse = data;
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

});