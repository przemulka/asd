$(document).ready(function($) {
  $(window).load(function() { // czekamy, aż załaduje się cała strona
	$('#status').delay(250).fadeOut(); // efekt zanikania animowanej grafiki
	$('#preloader').delay(350).fadeOut('slow'); // efekt zanikania warstwy zakrywającej stronę
	$('body').delay(350).css({'overflow':'visible'}); // dopóki nasz div#preloader jest widoczny nie ma możliwości przewijania strony
    });
});
