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
          $scope.LoadPlayOffTeam();

      })
      .error(function (data, status, header, config) {
          $scope.ResponseDetails = "Data: " + data +
              "<hr />status: " + status;
      });
    }

    $scope.Play = {
        PlayOffId: "",
        FirstTeamName: "",
        SecondTeamName: "",
        ThirdTeamName: "",
        FourthTeamName: "",
        TournamentId: ""
    }

    $scope.LoadPlayOffTeam = function () {
        $http
        .get("/api/PlayOff")
        .success(function (data) {
            console.log(data);
            $scope.PlayOffTeam = data;
            $scope.Play.FirstTeamName = data[0].FirstTeamName;
            $scope.Play.SecondTeamName = data[0].SecondTeamName;
            $scope.Play.ThirdTeamName = data[0].ThirdTeamName;
            $scope.Play.FourthTeamName = data[0].FourthTeamName;
            $scope.Play.TournamentId = data[0].TournamentId;
            $scope.Play.PlayOffId = data[0].Id;

        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    };


    $scope.SaveFinalTournament = function () {
        $http.post('/api/TournamentFinal', $scope.Play)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.LoadPlayOffTeam();
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };


    $scope.FinalTeam = {
        TournamentFinalId: "",
        FirstTeamName: "",
        SecondTeamName: "",
        TournamentId: ""

    }

    $scope.LoadFinalTournamentTeam = function () {
        $http
        .get("/api/TournamentFinal")
        .success(function (data) {
            console.log(data);
            $scope.FinalTeam.FirstTeamName = data[0].FirstTeamName;
            $scope.FinalTeam.SecondTeamName = data[0].SecondTeamName;
            $scope.FinalTeam.TournamentId = data[0].TournamentId;
            $scope.FinalTeam.TournamentFinalId = data[0].Id;

        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    };

    $scope.SaveWinner = function () {
        $http.post('/api/Winner', $scope.FinalTeam)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.LoadFinalTournamentTeam();
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };


    $scope.Winner = {
        WinnerName: ""
    }

    $scope.LoadWinners = function () {
        $http
        .get("/api/Winner")
        .success(function (data) {
            console.log(data);
            $scope.Winner.WinnerName = data[0].WinnerName;
          
        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    };
});