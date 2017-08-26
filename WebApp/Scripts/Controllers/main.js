// RequireJS - Modularidade, carregar o controle deposi de carregar susas dependências
// RequireJS - Identifica a extensão dos arquivos
// Angular AMD + RequireJs - 
// AMD - Asynchronous Module Definition - 
// Arquivo de configuração do require.js. Ele é o primeiro a rodar, então o próprio angualar está referenciado aqui.
// O segredo para o angular 1.3.x funcionar de forma modular (AMD) com requirejs, é o componente 'angularAMD'.
// Require.js carrega script sob demanda. É mais usual para projetos grandes, mas melhora a execução de qquer aplicação 
// Por opção, a maioria dos JSs estarão apontando para o aquivo não minificado. Alterar isto na publicação
//
require.config({
    baseUrl: "Scripts/Controllers/",
    waitSeconds: 30,
    //
    // Registre todos os módulos aqui. o 'paths' apenas registra arquivos para uso posterior com o método 'define' de cada módulo.
    //
    paths: {
        //
        // plugins aux do require.js -> //github.com/millermedeiros/requirejs-plugins
        //
        'async': '../Vendors/requirejs/plugins/async',
        'font': '../Vendors/requirejs/plugins/font',
        'goog': '../Vendors/requirejs/plugins/goog',
        'image': '../Vendors/requirejs/plugins/image',
        'json': '../Vendors/requirejs/plugins/json',
        'noext': '../Vendors/requirejs/plugins/noext',
        'mdown': '../Vendors/requirejs/plugins/mdown',
        'propertyParser': '../Vendors/requirejs/plugins/propertyParser',
        'markdownConverter': '../Vendors/requirejs/plugins/markdownConverter',

        //
        // jQuery e relacionados
        //
        'jquery': '../Vendors/jquery/jquery.min',


        //
        // Angularjs e adjacentes
        //1.3.12
        'angular': '../Vendors/angular/angular',
        'angular-animate': '../Vendors/angular/angular-animate.min',
        'angular-sanitize': '../Vendors/angular/angular-sanitize.min',
        'angular-ui-notification': '../Vendors/angular-ui-notification/angular-ui-notification',
        'angular-smooth-scroll': '../Vendors/angular-smooth-scroll/angular-smooth-scroll.min',
        'angular.util': '../Vendors/angular-ui-util/ui-utils.min',
        'angular-ui-select': '../Vendors/angular-ui-select/select.min',
        'ui-bootstrap': '../Vendors/angular-ui-bootstrap/ui-bootstrap-0.12.0.min',

        'bootstrap': '//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min',
        'angularAMD': '../Vendors/angularAMD/angularAMD',
        'ui-router': '../Vendors/angular-ui-router/angular-ui-router.min',
        'angular.filter': '../Vendors/angular-filter/angular-filter.min',
        'smart-table': '../Vendors/smart-table/smart-table.min',
        'angular-translate': '../Vendors/angular-translate/angular-translate.min',
        'angular-translate-loader-url': '../Vendors/angular-translate-loader-url/angular-translate-loader-url.min',
        'angular-dynamic-locale': '../Vendors/angular-dynamic-locale/tmhDynamicLocale',
        'ngMask': '../Vendors/angular-mask/ngMask',
        'ngStorage': '../Vendors/ngStorage/ngStorage.min',
        'angularAside': '../Vendors/angular-aside/js/angular-aside.min',
        'less': '../Vendors/less/less.min',
        'angular-chart': '../Vendors/angular-chart/angular-chart/dist/angular-chart.min',
        'chartjs': '../Vendors/angular-chart/chartjs/chart.min',
        'ng-Autocomplete': '../Vendors/ngAutocomplete/ngAutocomplete',
        'ng-stats': '../Vendors/ngStats/ng-stats',

        'angulartics': '../Vendors/angulartics/angulartics',
        'angulartics-ga': '../Vendors/angulartics/angulartics-ga',

        //'srvAcessoWebApi': '../Services/srvAcessoWebApi'

        ////
        //// Diretivas customizadas.
        ////
        //'dirMask': 'diretivas/dirMask',

        ////
        //// Insira seus controles que não forem ativados via ui-route aqui.
        ////
        //'ctrlModalTestes': 'controles/modais/ctrlModalTestes',


        ////
        //// Insira seus servicos aqui.
        ////
        ////'srvRegras': 'servicos/srvRegras',
        //'srvMaskCelular': 'servicos/srvMaskCelular',
        //'srvMaskInteiro': 'servicos/srvMaskInteiro',
    },

    //
    // Os itens do 'paths' acima que não forem modulares devem registrar suas dependencias abaixo.
    // Se algum modulo tem alguma dependencia, indicar aqui para os downloads serem feitos na ordem correta
    //
    shim: {
        'angular': {
            exports: 'angular',
            deps: ['jquery', 'bootstrap']
        },
        'bootstrap': ['jquery'],
        'angulartics-ga': ['angular'],
        'angulartics': ['angulartics-ga'],
        'angularAMD': ['angular'],
        'ui-router': ['angular'],
        'angular-animate': ['angular'],
        'angular-sanitize': ['angular'],
        'angular-smooth-scroll': ['angular'],
        'angular.filter': ['angular'],
        'ui-bootstrap': ['angular'],
        'angular.util': ['angular'],
        'ng-Autocomplete': ['angular'],
        'mapa': ['angular'],
        'angular-ui-select': ['angular'],
        'smart-table': ['angular'],
        'angular-translate': ['angular'],
        'angular-translate-loader-url': ['angular', 'angular-translate'],
        'angular-dynamic-locale': ['angular'],
        'angular-ui-notification': ['angular'],
        'ngMask': ['angular'],
        'perfect-scrollbar': ['angular', 'jquery'],
        'dirFecharCliqueExterno': ['angular'],
        'angularAside': ['angular'],
        'less': {
            exports: 'less',
            deps: ['angular']
        },
        'googleMaps': ['angular'],
        'ng-stats': ['angular'],
        'angular-chart': ['angular', 'chartjs'],
        'ngStorage': ['angular'],
        'diretivas/dirPagination': ['angular']
    },

    //
    // O que deve ser iniciado logo de cara
    //
    deps: ['app']
});