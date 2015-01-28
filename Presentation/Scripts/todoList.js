(function ($) {
	"use strict";
	
	$("#btnCreateNew").click(function () {
		$("#content").load("create.html");
	});

	function refreshTable(data) {
		var body = $("<tbody />");
		for (var i = 0; i < data.length; ++i) {
			var row = $("<tr />");
			var descriptionCell = $("<td />");
			var activeCell = $("<td />");
			var buttonCell = $("<td><button class='btnDelete'><i class='icon-trash'></i></button><button class='btnToggleStatus'><i class='icon-check'></i></button></td>");

			descriptionCell.text(data[i].Description);
			activeCell.text(data[i].IsCompleted ? "yep" : "nope");
			buttonCell.find("button").data("id", data[i].Id);
			buttonCell.find(".btnToggleStatus").data("complete", !data[i].IsCompleted);

			row.append(descriptionCell).append(activeCell).append(buttonCell);
			body.append(row);
		}

		$("#tblTodos tbody").replaceWith(body);
		
		$(".btnDelete").click(function () {
			var source = $(this);
			var id = source.data("id");

			$.ajax({
				url: "/Todos/Delete",
				type: "POST",
				data: { "id": id },
				success: function () {
					source.closest("tr").remove();
				}
			});
		});
		
		$(".btnToggleStatus").click(function () {
			var source = $(this);
			var id = source.data("id");
			var isCompleted = source.data("complete");

			$.ajax({
				url: "/Todos/ToggleCompletionStatus",
				type: "POST",
				data: { id: id, isCompleted: isCompleted },
				success: doRefresh
			});
		});
	}

	function doRefresh() {
		$.ajax({
			url: "/Todos/All",
			type: "GET",
			success: refreshTable,
			error: console.log
		});
	}

	doRefresh();

}(jQuery));