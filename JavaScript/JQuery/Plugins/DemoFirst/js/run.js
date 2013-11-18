(function($){

    $(function(){

    	// теперь можно задавать плагин с настройками по умолчанию:
		$('div:first').responsiveBlock();
		$('div:first').responsiveBlock({defColor:"#aaaaaa", hoverColor:"green"});
 
		 

    	/*
    	//fisrt invoke
    	$('p:first, p:last').mySimplePlugin();
    	//second invoke
    	$('p:eq(1)').mySimplePlugin({ color: 'red'});
		*/
    	
       /* $('div').each(function() {
        	 $("#divResult").append("<p> Высота div:" + $(this).height() + "</p>");
    	});

    	var tallest = $('div').maxHeight(); // Возвращает высоту самого высокого div-а
  		console.log(tallest);

		$("#divResult").append("<p>------------------------------------------</p>");
  		$("#divResult").append("<p>Высота самого высокого div: "+tallest + "</p>");
			*/


      	
    });
      
})(jQuery);