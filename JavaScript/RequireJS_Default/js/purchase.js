define(["credits","products"], function(credits,products) {
 
  console.log("Function : purchaseProduc init");
 
  return {
  	
    purchaseProduct: function() {
 
      console.log("Function : purchaseProduct");

      var credit = credits.getCredits();
      if(credit > 0){
        products.reserveProduct();
        return true;
      }
      return true;
    }
  }
});