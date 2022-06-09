var viewmodal = function () {
    self = this;
    self.convertToKoObject = function (data) {
        var newObj = ko.mapping.fromJS(data);
        newObj.Selected = ko.observable(false);
        return newObj;
    }
    self.showtoastError = function (msg, title) {
        toastr.options = {
            "closeButton": true,
            "debug": false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "showDuration": "3000",
            "hideDuration": "3000",
            "timeOut": "3000",
            "extendedTimeOut": "3000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
        toastr['error'](title, msg);
    };
    self.showtoastState = function (msg, title) {
        toastr.options = {
            "closeButton": true,
            "debug": false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "showDuration": "3000",
            "hideDuration": "3000",
            "timeOut": "3000",
            "extendedTimeOut": "3000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
        toastr['success'](title, msg);
    };

    self.loadproduct = function (item) {
        $.ajax({
            type: "GET",
            url: "https://localhost:44346/api/Manager/product",
            contentType: "application/json",
            success: function (data) {
                self.arrayproduct([]);
                $.each(data, function (ex, item) {
/*                    console.log("aa", self.convertToKoObject(item));
*/                    self.arrayproduct.push(self.convertToKoObject(item));

                });


            },
            error: function (err) {
                alert(err);
            },
        });
    }
    self.loadCustomer = function (item) {
        $.ajax({
            type: "GET",
            url: "https://localhost:44346/api/Manager/customer",
            contentType: "application/json",
            success: function (data) {
                self.arrayCustomer([]);
                $.each(data, function (ex, item) {
/*                    console.log("aa", self.convertToKoObject(item));
*/                    self.arrayCustomer.push(self.convertToKoObject(item));

                });


            },
            error: function (err) {
                alert(err);
            },
        });
    }
    self.search = function () {
        
        var stringinput = {
            stringrequest: $('#myInput').val(),
        };
        $.ajax({
            type: "put",
            url: "https://localhost:44346/api/Manager/search",
            contentType: "application/json",
            data: JSON.stringify(stringinput),
            success: function (data) {
                self.arrays([]);
                $.each(data, function (ex, item) {
/*                    console.log("aa", self.convertToKoObject(item));
*/                    self.arrays.push(self.convertToKoObject(item));

                });


            },
            error: function (err) {
                alert(err);
            },
        });
    }
    self.create = function () {
        self.loadproduct(null);
        self.loadCustomer(null);
        $('#modal').modal('show');
        self.save = function () {
            var stringinput = {
                Id: 0,
                ApplicationUserId: ($('#Customer').val()),
                ProductId: parseInt($('#Product').val()),
                Amount: parseInt($('#Amount').val()),
                OrderDate: ($('#orderdate').val()),

            };
            $.ajax({
                type: "post",
                url: "https://localhost:44346/api/Manager/add",
                contentType: "application/json",
                data: JSON.stringify(stringinput),
                success: function (data) {
                    self.load();
                    $('#modal').modal('hide');


                },
                error: function (err) {
                    alert(err);
                },
            });
        }
        
    }

    self.arrays =ko.observableArray();
    self.load = function () {
        
        $.ajax({
            type: "GET",
            url: "https://localhost:44346/api/Manager",
            contentType: "application/json",
            success: function (data) {
                self.arrays([]);
                $.each(data, function (ex, item) {
/*                    console.log("aa", self.convertToKoObject(item));
*/                    self.arrays.push(self.convertToKoObject(item));
                    
                });
               
                
            },
            error: function (err) {
                alert(err);
            },
        });
    }
    self.arrayproduct = ko.observableArray();
    self.arrayCustomer = ko.observableArray();
}
$(function () {
    var a = new viewmodal();
    a.load();
    ko.applyBindings(a);
})