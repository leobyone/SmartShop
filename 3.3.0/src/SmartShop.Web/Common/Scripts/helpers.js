var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('SmartShop');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);