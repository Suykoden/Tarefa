var app = angular.module("app", []);
app.controller("RegisterTeamController", function ($scope, $http) {

    $scope.Save = function () {

        $http.post('/api/Team', $scope.Team)
        .success(function (data) {
            $scope.PostDataResponse = data;
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

});