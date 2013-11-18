//Default configuration
require.config({
	baseUrl: "",
	paths: {
		"jquery"  : "lib/jquery-2.0.3",
		"app" : "js/app", 
		"shop" : "js/shop", 
		"product" : "js/product"
	}
});

//Start point
define(["app"], function(){ });