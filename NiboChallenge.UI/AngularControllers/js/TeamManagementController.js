var app = angular.module("app", []);
app.controller("TeamManagementController", function ($scope, $http) {

    $scope.FormAddTeam = {};

    $scope.Save = function () {
        $http.post('/api/Team', $scope.Team)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.Team = {};
            $scope.FormAddTeam.$setUntouched();
            $scope.FormAddTeam.$setPristine();
            $scope.LoadTeams();
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

    $scope.LoadTeams = function () {
        $http
        .get("/api/Team")
        .success(function (data) {
            console.log(data);
            $scope.TeamList = data;
        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    };

    $scope.DeleteTeam = function (Team) {

        $http.put('/api/Team', Team)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.LoadTeams();

        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });

    };

    $scope.LoadContenders = function () {
        $http
            .get("/api/Contender")
            .success(function (data) {
                console.log(data);
                $scope.dados = data;
                $scope.ContendersList = data;
            })
            .error(function () {
                alert("Não foi possível carregar os dados");
            });


    };


});