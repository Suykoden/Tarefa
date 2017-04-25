var app = angular.module("app", []);
app.controller("TournamentManagementController", function ($scope, $http) {

    $scope.FormAddTournament = {};

    $scope.SaveTournament = function () {
        $http.post('/api/Tournament', $scope.Tournament)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.Tournament = {};
            $scope.FormAddTournament.$setUntouched();
            $scope.FormAddTournament.$setPristine();
            $scope.LoadTournaments();
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

    $scope.LoadTournaments = function () {
        $http
        .get("/api/Tournament")
        .success(function (data) {
            console.log(data);
            $scope.tournamentList = data;
        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    };

    $scope.DeleteTournament = function (Tournament) {

        $http.put('/api/Tournament', Tournament)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.LoadTournaments();

        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });

    };
});