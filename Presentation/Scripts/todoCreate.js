(function($) {
	"use strict";

	$("#btnList").click(function() {
		$("#content").load("list.html");
	});

	$("#btnSave").click(function() {
		var description = { "description": $("#txtDescription").val() };

		$.ajax({
			url: "/Todos/Create",
			type: "POST",
			data: description,
			success: function() {
				$("#content").load("list.html");
			},
		});
	});

}(jQuery));