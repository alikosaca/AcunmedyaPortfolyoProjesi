(function($) {

	"use strict";

	var fullHeight = function() {

		$('.js-fullheight').css('height', $(window).height());
		$(window).resize(function(){
			$('.js-fullheight').css('height', $(window).height());
		});

	};
	fullHeight();
	$('#sidebar').removeClass('active');

    // Sadece butona tıklandığında durumu değiştir
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });


})(jQuery);
