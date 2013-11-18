(function($){

  //значение по умолчанию ǁ ЗЕЛЁНЫЙ 
  var defaults = 
    {
      defColor:"white", //цвет элемента над которым нет курсора
      hoverColor:"red" //цвет элемента на который наведен курсор
    };

  jQuery.fn.responsiveBlock = function(options){
    // Зададим список свойств и укажем для них значения по умолчанию.
    // Если при вызове метода будут указаны пользовательские
    // варианты некоторых из них, то они автоматически перепишут
    // соответствующие значения по умолчанию
    options = $.extend(defaults, options);
 
    var make = function(){
      // здесь переменная this будет содержать отдельный
      // DOM-элемент, к которому и нужно будет применить
      // воздействия плагина
      $(this).css("background-color",options.defColor)
      .mouseenter( function(){
        $(this).css("background-color",options.hoverColor);
      })
      .mouseleave( function(){
        $(this).css("background-color",options.defColor);
      });
    };
 
    return this.each(make); 
    // в итоге, метод responsiveBlock вернет текущий объект jQuery обратно
  };
})(jQuery);