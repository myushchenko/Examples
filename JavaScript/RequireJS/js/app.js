define("app",["jquery","shop"], function($, shop){


    console.log({
    	id : 1,
    	name : "test",
    	run : function(){
    		return name;
    	}
    });

	shop.addProduct("product 1",10);
	shop.addProduct("product 2",40);
	shop.addProduct("product 3",30);

	shop.displayProducts($("#divProducts"));

	$("#btnAddProduct").click(function(){

		var name = $("#txtName").val();
		var model = $("#txtModel").val();

		if (name != "" && model != ""){
			shop.addProduct(name,model);
			shop.displayProducts($("#divProducts"));
			$("#txtName").val("");
			$("#txtModel").val("");
		}else{
			alert("Please, enter data!");
		}

	});

});