angular.module('timeApp', ['ui.router', 'ngResource', 'timeApp.controllers', 'timeApp.services']);

angular.module('timeApp').config(function ($stateProvider, $httpProvider) {
    $stateProvider.state('newTime', {
        url: '/api/badges/',
        templateUrl: 'partials/timesheet.html',
        controller: 'TimeCreateController'
    });
}).run(function ($state) {
    $state.go('time');
});