// http://habrahabr.ru/post/158235/
(function($){

$.fn.maxHeight = function() {
  
  	// нет необходимости писать $(this), так как "this" - это уже объект jQuery
    // выражение $(this) будет эквивалентно $($('#element'));

    var max = 0;

    this.each(function() {

    	// тут "this" - это элемент дерева DOM
    	max = Math.max( max, $(this).height() );
    });

    return max;
  };

})(jQuery);