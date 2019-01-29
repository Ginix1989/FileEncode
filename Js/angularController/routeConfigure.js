//路由设置
//注意路径加载 是当前页面的相对位置
var actionApp = angular.module('actionApp', ['ngRoute', 'ui.bootstrap']);
actionApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/fileUpLoad', {//文件上传
            controller: 'fileUpLoadController',
            templateUrl: '../views/fileUpLoad/fileUpload.html',
        })
            .when('/fileUpLoadManager', {//文件上传管理
                controller: 'fileUpLoadManagerController',
                templateUrl: '../views/fileUpLoad/fileUploadManager..html',
            })
    ;//#!/OrderQuery /logout
}]);
//控制器 文件上传
actionApp.controller('fileUpLoadController', ['$rootScope', '$scope', '$http', '$uibModal', '$log',
    function ($rootScope, $scope, $http, $uibModal, $log) {
        $scope.$on('$viewContentLoaded', function () {

            // 获取权限
            //$http.get("../../getAuthor")
            //    .then(function (responsedata) {
            //        console.log(responsedata.data);
            //        $scope.parentAuthor = responsedata.data;
            //    })
            //    .catch(function (response) {
            //        console.log(response);
            //    }
            //    );

            console.log('页面加载完成 serveInfoController');
        });


        //function getallServeInfo() {

        //    // 动态请求服务信息内容
        //    $http.get("getAllServeInfo")
        //        .then(function (responsedata) {
        //            console.log(responsedata);
        //            $rootScope.serveInfoList = responsedata.data;
        //        })
        //        .catch(function (response) {
        //            console.log(response);
        //        }
        //        );
        //}

        //getallServeInfo();


        //$scope.getServeInfoByServeType = (function () {

        //    if ($scope.serveType == undefined | $scope.serveType == null) {
        //        getallServeInfo();
        //        return;
        //    }
        //    else {
        //        console.log($scope.serveType);
        //        $http({
        //            url: 'getAllServeInfoByType',
        //            method: 'Get',
        //            params: { itemInfo: $scope.serveType }
        //        })
        //            .then(function (responsedata) {
        //                console.log(responsedata);
        //                $rootScope.serveInfoList = responsedata.data;
        //            })
        //            .catch(function (response) {
        //                console.log(response);
        //            }
        //            );
        //    }

        //});

        ////预约服务
        //$scope.orderServe = (function (serverId) {
        //    //预约服务信息
        //    serveData = {
        //        serveInfoId: serverId,
        //        parentId: "",
        //        grade: -1,
        //        note: ""
        //    };

        //    var ordermodalInstance = $uibModal.open({
        //        templateUrl: '../views/addInfo/addOrderServeInfo.html',
        //        controller: orderModalInstanceCtrl,
        //        size: 'lg',
        //        backdrop: 'true',
        //    });
        //    // 模态窗口打开之后执行的函数
        //    ordermodalInstance.opened.then(function () {

        //        console.log('modal is opened');
        //        console.log();
        //    });
        //    ordermodalInstance.result.then(function (result) {
        //        console.log('returnValue:');
        //        console.log(result);
        //        serveData['orderdateTime'] = result;
        //        $http({
        //            method: 'POST',
        //            url: 'saveParentOrderInfo',

        //            data: serveData,//作为消息体参数
        //        }).then(function (value) {
        //            alert("保存成功");
        //            //  $scope.villageStaffList = value.data;
        //        }, function (reason) {
        //        }).catch(function (reason) {
        //        });
        //    }, function (reason) {
        //        console.log(reason);// 点击空白区域，总会输出backdrop
        //        // click，点击取消，则会暑促cancel
        //        console.log('Modal dismissed at: ' + new Date());
        //    });

        //});
        //// 删除服务信息
        //$scope.deleteServeInfoItem = (function (serverId) {
        //    $scope.data = {
        //        id: serverId
        //    };
        //    $http({
        //        url: 'deleteServeInfoById',
        //        method: 'Get',
        //        data: $scope.data,//作为消息体参数
        //        params: {
        //            id: serverId,
        //            serveType: 0
        //        }//为url的参数
        //    }).then(function (value) {
        //        alert("删除成功");
        //        $rootScope.serveInfoList = value.data;
        //    }, function (reason) {
        //    }).catch(function (reason) {
        //    });
        //});

        //$scope.items = ['item1', 'item2', 'item3'];
        ////弹出新增窗口
        //$scope.addServeInfo = function () {

        //    $scope.serveAddInfo = null;
        //    var modalInstance = $uibModal.open({
        //        templateUrl: '../views/addInfo/addServeInfo.html',
        //        controller: ModalInstanceCtrl,
        //        size: 'lg',
        //        backdrop: 'true',
        //        //  windowClass: {},
        //        resolve: {
        //            items: function () {
        //                return $scope.items;
        //            }
        //        }
        //    });
        //    // 模态窗口打开之后执行的函数
        //    modalInstance.opened.then(function () {
        //        console.log('modal is opened');
        //    });
        //    modalInstance.result.then(function (result) {
        //        console.log('returnValue:');
        //        console.log(result);

        //        //renturnValue and  saveValeu to ServeinfoTable
        //        $http({
        //            url: 'saveServeInfo',
        //            method: 'Get',
        //            //data: $scope.data,//作为消息体参数
        //            params: {
        //                serveInfo: result,
        //                serveType: 0
        //            }//为url的参数
        //        }).then(function (value) {
        //            alert("保存成功");
        //            $rootScope.serveInfoList = value.data;
        //        }, function (reason) {
        //        }).catch(function (reason) {
        //        });
        //    }, function (reason) {
        //        console.log(reason);// 点击空白区域，总会输出backdrop
        //        // click，点击取消，则会暑促cancel
        //        $log.info('Modal dismissed at: ' + new Date());
        //    });
        //}
    }]);

//弹出框控制器
var ModalInstanceCtrl = function ($scope, $uibModalInstance) {
    $scope.ok = function () {
        console.log($scope.serveAddInfo);
        $uibModalInstance.close($scope.serveAddInfo);////关闭并返回当前选项
    };
    $scope.cancel = function () {
        console.log("取消");
        $uibModalInstance.dismiss('cancel');
    };
};


//预约服务弹出框控制器
var orderModalInstanceCtrl = function ($scope, $uibModalInstance) {
    $scope.ok = function () {
        console.log($scope.serveTimeInfo);
        $uibModalInstance.close($scope.serveTimeInfo);////关闭并返回当前选项
    };
    $scope.cancel = function () {
        console.log("取消");
        $uibModalInstance.dismiss('cancel');
    };
};


//控制器 文件上传管理
actionApp.controller('fileUpLoadManagerController', ['$rootScope', '$scope', '$http', '$uibModal', '$log',
    function ($rootScope, $scope, $http, $uibModal, $log) {
        $scope.$on('$viewContentLoaded', function () {

            // 获取权限
            //$http.get("../../getAuthor")
            //    .then(function (responsedata) {
            //        console.log(responsedata.data);
            //        $scope.parentAuthor = responsedata.data;
            //    })
            //    .catch(function (response) {
            //        console.log(response);
            //    }
            //    );

            console.log('页面加载完成 serveInfoController');
        });
    }]);
