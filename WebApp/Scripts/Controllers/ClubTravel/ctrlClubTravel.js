define(['angularAMD'],
    function (angularAMD) {
        angularAMD.controller('ctrlClubTravel',
            function ($scope, $http, $filter) {
            var ng = $scope;

            ///
            /// Initialize function
            ///
            ng.init = function () {
                ng.stillEmployed = true;
                initializeVariables();

                // Get employee by company
                $http.get("../api/allcompanies/")
                    .success(function (resultado) {
                        // Get the resulto of companies
                        ng.resultInit = resultado;
                        // Set default value to companyName
                        ng.companyName = ng.resultInit[0].Name;
                    }).error(function (error) {
                        alert('erro');
                    }).finally(function () {

                    });
            };


            ///
            /// Initialize variables
            ///
            initializeVariables = function () {
                ng.noResult = false;
                ng.sumCompanies = ng.sumAges = ng.employees = ng.companies = undefined;
            };

            ///
            /// Find Employ By Company Name
            ///
            ng.findEmployByCompany = function () {
                ng.paineEmployee = true;
                initializeVariables();

                if (ng.resultInit.length > 0 && ng.resultInit[0] != null) {
                    // select the node in dropDown with yours employers
                    var item = ($filter('filter')(ng.resultInit, { 'Name': ng.companyName }))[0];
                    // Fill By employmens
                    ng.employees = item.Employments;

                    startButtons();

                    //Verify if this company has employees
                    if (ng.employees == null) {
                        ng.noResult = true;
                    }
                } else {
                    ng.noResult = true;
                }    
            };

            ///
            /// Inicialize buttons
            ///
            startButtons = function () {
                // Show/hide buttons
                ng.showAddNewEmployee = true;
                ng.showCancelNewEmployee = false;
                ng.showSaveNewEmployee = false;
            };

            ///
            /// Return all companies
            ///
            ng.findAllCompanies = function () {
                initializeVariables();
                ng.paineEmployee = false; 
                if (ng.resultInit.length > 0 && ng.resultInit[0] != null) {
                    ng.companies = ng.resultInit;
                } else {
                    ng.noResult = true;
                }
            };

            ///
            /// Return the sum of ages of all employees
            ///
            ng.getSumAges = function () {
                ng.paineEmployee = false;
                initializeVariables();
                // Get sum of ages
                $http.get("../api/sumemployeeage/")
                    .success(function (resultado) {
                        ng.sumAges = resultado;
                    }).error(function (error) {
                        alert('erro');
                    }).finally(function () {

                    });
            };

            ///
            /// Return the sum of companies
            ///
            ng.getSumCompanies = function () {
                initializeVariables();
                ng.sumCompanies = ng.resultInit.length;
            };

            ///
            /// Add new Employee
            ///
            ng.addNewEmployee = function () {
                ng.newReg = {};
                ng.newReg.Employee = {};

                ng.newReg.EmploymentStartDate = new Date();

                // control visiblity of Buttons
                ng.showAddNewEmployee = false;
                ng.showCancelNewEmployee = true;
                ng.showSaveNewEmployee = true;
            };

            ///
            /// Cancel add of new employee
            ///
            ng.cancelNewEmployee = function () {
                ng.newReg = undefined;

                // control visiblity of Buttons
                startButtons();
            };

            ///
            /// Save reg employee
            ///
            ng.saveNewEmployee = function () {
                ng.newReg.NumberOfYearsEmployed = 0;
                ng.newReg.EmploymentEndDate = null;
                ng.employees.push(ng.newReg);
                // Inicialize buttons
                startButtons();

                ng.newReg = undefined;
            };

            ///
            ///Initialize controller
            ///
            ng.init();
        });
    });

