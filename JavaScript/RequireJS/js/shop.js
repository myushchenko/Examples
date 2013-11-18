define("shop",["product"], function (product) {

	var products = [];

	return{
		getProducts : function(){
			return products;
		},

		addProduct : function(name, model){

			var newProduct = product.Create(name, model);
			products.push(newProduct);
			console.log(newProduct);
			return newProduct;
		},

		displayProducts : function(divProducts){

			divProducts.empty();

			for (var p in products){
				divProducts.append("<p>"+p+" - "+products[p].getDescription() + "</p>");
			}

		}
		
	} 
});