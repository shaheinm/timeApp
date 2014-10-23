angular.module('timeApp.controllers', [])
  .controller('TimeCreateController', function ($scope, $stateParams, Time) {
      $scope.Time = new Time();

      $scope.addTime = function () {
          $scope.time.$save(function () {
              $state.go('time');
          });
      };
  });