define("product", function(){

	function Product(_name, _model){
		this.name = _name;
		this.model = _model;
	}; 

	Product.prototype.getDescription = function() {
		return "Products is " + this.name + " and model is " + this.model;
	};


	return { 
		Create : function(name, model){

			var product = new Product(name,model);
			return product;
		}
	}
});