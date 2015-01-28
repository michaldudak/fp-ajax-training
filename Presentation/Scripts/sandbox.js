(function($) {
	$("#btnLoadStaticContent").click(function() {
		$("#staticContentContainer").load("staticContent.html");
	});

	$("#btnLoadAspx").click(function() {
		$("#aspxContentContainer").load("dynamicContent.aspx");
	});

	$("#btnLoadTextFile").click(function() {
		$("#textContentContainer").load("textFile.txt");
	});
}(jQuery));