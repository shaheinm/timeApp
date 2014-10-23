angular.module('timeApp.services', []).factory('Time', function ($resource) {
    return $resource('http://localhost:12116/api/badges/', { id: '@_id' }, {
        update: {
            method: 'PUT'
        }
    });
}).service('popupService', function ($window) {
    this.showPopup = function (message) {
        return $window.confirm(message);
    }
});