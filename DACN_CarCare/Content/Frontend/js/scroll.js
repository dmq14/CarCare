var detail-link = "#10e88a",
	description = "#7f3995",
	going = "#0d78e7",
	portfolio = "#f88f18",

$(window).on("scroll touchmove", function () {
	if ($(document).scrollTop() >= $("#detail-link").position().top) {
		$('body').css('background', $("#detail-link").attr("data-color"));

	};
	if ($(document).scrollTop() > $("#description").position().top) {
		$('body').css('background', $("#description").attr("data-color"))
	};
	if ($(document).scrollTop() > $("#going").position().top) {

		$('body').css('background', $("#going").attr("data-color"))
	};
	if ($(document).scrollTop() > $("#portfolio").position().top) {

		$('body').css('background', $("#portfolio").attr("data-color"))
	};
});
jackHarnerSig()