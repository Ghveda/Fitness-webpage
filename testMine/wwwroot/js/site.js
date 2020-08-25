$(document).ready(function(){
	$('#clearButton').click(function () {	
		$('#exampleModal input[type="text"]').val('');
		});
});
$(document).ready(function () {
	$('SignInButton').click(function () {
		$('#exampleModal input').val('');
	});
});


var one = $('SignInId').val();
$('SignInButton').click(function () {
	$('exampleModalLayout input').val('');
});