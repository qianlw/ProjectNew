var ComingSoon = function () {

    return {
        //main function to initiate the module
        init: function () {

            $.backstretch([
    		        "/Assets/img/bg/1.jpg",
    		        "/Assets/img/bg/2.jpg",
    		        "/Assets/img/bg/3.jpg",
    		        "/Assets/img/bg/4.jpg"
    		        ], {
    		          fade: 1000,
    		          duration: 10000
    		        });
            var str = $("#hidTime").val();
            var austDay = new Date(str);            
            austDay = new Date(austDay.getFullYear(), austDay.getMonth(), austDay.getDate());
            $('#defaultCountdown').countdown({until: austDay});
            $('#year').text(austDay.getFullYear());
        }

    };

}();