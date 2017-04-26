var app = angular.module("app", []);
app.controller("TournamentManagementController", function ($scope, $http, $window) {

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

    $scope.ManagerTournament = function () {
        $http.post('/Home/TournamentControl')
      .success(function (data) {
          console.log(data);
          $window.location = "TournamentControl";
      })
      .error(function (data, status, header, config) {
          $scope.ResponseDetails = "Data: " + data +
              "<hr />status: " + status;
      });
    }

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

    $scope.AddTeamToPlayOffs = function (tournaments) {
        $http.post('/api/PlayOff', tournaments)
      .success(function (data) {
          console.log(data);
          $scope.UpdateTournamentStatus(tournaments);
      })
      .error(function (data, status, header, config) {
          $scope.ResponseDetails = "Data: " + data +
              "<hr />status: " + status;
      });
    }
  
    $scope.UpdateTournamentStatus = function (tournaments) {
        $http.post('api/Tournament/Update', tournaments)
      .success(function (data) {
          console.log(data);
          $scope.LoadTournaments();

      })
      .error(function (data, status, header, config) {
          $scope.ResponseDetails = "Data: " + data +
              "<hr />status: " + status;
      });
    }
});