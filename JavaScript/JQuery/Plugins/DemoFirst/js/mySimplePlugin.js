(function( $ ){

  //значение по умолчанию ǁ ЗЕЛЁНЫЙ 
  var defaults = {color:'green'};
  //актуальные настройки, глобальные 
  var options;
  
  $.fn.mySimplePlugin = function(params){
    options = $.extend({}, defaults, options, params);

    console.log(this);// it's jQuery object
    console.log(this.length); //numbers of elements in selector
    this.click(function(){
        $(this).css('color',options.color);
    });

    return this;
  }
})( jQuery );