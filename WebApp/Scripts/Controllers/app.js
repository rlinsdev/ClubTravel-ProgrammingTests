define([
    'angularAMD',
    'angulartics',
    'ui-router',
    'ui-bootstrap'],
    function (angularAMD) {
        var app = angular.module('app', ['ui.router',
            'ui.bootstrap']);

        app.config(['$urlRouterProvider', '$stateProvider',
            function ($urlRouterProvider, $stateProvider) {

                // UI-Router - Controle de estado e rotas. URL / HTML / Controller / Caminho do controler - https://github.com/angular-ui/ui-router/wiki
                //
                $stateProvider.state('root',
                    { abstract: true, })
                    .state('home', {
                        url: '/home',
                        parent: '',
                        views: {
                            'conteudo-view@': angularAMD.route({
                                templateUrl: 'Views/ClubTravel/ClubTravel.html',
                                controller: 'ctrlClubTravel',
                                controllerUrl: 'ClubTravel/ctrlClubTravel'
                            })
                        }
                    })
                $urlRouterProvider.otherwise('/home');
            }]);
        return angularAMD.bootstrap(app);
    });


String.prototype.padLeft = function (l, c) {
    return Array(l - this.length + 1).join(c || ' ') + this;
}