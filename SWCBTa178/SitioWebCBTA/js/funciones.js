//con esta función de jQueryUI damos un estilo bastante elegante
//al botón de nuestro formulario
$(function() {
		$( "input:submit", ".demo" ).button();
		$( ".demo" ).click(function() { return false; });
	});
//*******************************************************************
//Aquí comenzamos creando un plugin, podríamos haber realizado estás 
//funciones de otra forma, pero así comprendemos como se crean los plugins 
//con jQuery, que aunque no soy experto en el tema como ya dije, mirando la 
//documentación se aprende bastante
jQuery.fn.LlenarLimpiarCampos = function(){
	this.each(function(){
		$(".nom").attr("value","Introduzca su nombre");
		$(".nom").focus(function(){
			if($(".nom").attr("value")=="Introduzca su nombre"){
			$(".nom").attr("value","");		
			}
		});
		$(".nom").blur(function(){
			if($(".nom").attr("value")==""){
		   $(".nom").attr("value","Introduzca su nombre");		
			}
		});
	
		$(".email").attr("value","Introduzca su email");
		$(".email").focus(function(){
			if($(".email").attr("value")=="Introduzca su email"){
			$(".email").attr("value","");		
			}
		});
		$(".email").blur(function(){
			if($(".email").attr("value")==""){
		   $(".email").attr("value","Introduzca su email");		
			}
		});
		$(".asunto").attr("value","Introduzca su asunto");
		$(".asunto").focus(function(){
			if($(".asunto").attr("value")=="Introduzca su asunto"){
			$(".asunto").attr("value","");		
			}
		});
		$(".asunto").blur(function(){
			if($(".asunto").attr("value")==""){
		   $(".asunto").attr("value","Introduzca su asunto");		
			}
		});
			$(".mensaje").attr("value","Introduzca su mensaje");
		$(".mensaje").focus(function(){
			if($(".mensaje").attr("value")=="Introduzca su mensaje"){
			$(".mensaje").attr("value","");		
			}
		});
		$(".mensaje").blur(function(){
			if($(".mensaje").attr("value")==""){
		   $(".mensaje").attr("value","Introduzca su mensaje");		
			}
		});
	});
	return this;
};
//siempre que creemos un plugin debemos llamarlo, sino no funcionará
$(document).ready(function(){
	$(this).LlenarLimpiarCampos();
});
//*************************************************************************
//realizamos las validaciones de nuestro formulario con jQuery
$(document).ready(function () {
    var emailreg = /^[a-zA-Z0-9_\.\-]+@[a-zA-Z0-9\-]+\.[a-zA-Z0-9\-\.]+$/;
    $(".boton").click(function(){
    	$(".error").remove();
		if( $(".nom").val() == "" || $(".nom").val() == "Introduzca su nombre"){
			$(".nom").focus().after("<span class='error'>Ingrese su nombre</span>");
			return false;
		}else if($(".nom").val().length < 2){
			$(".nom").focus().after("<span class='error'>Mínimo 2 carácteres para el nombre</span>");
			return false;
		}else if( $(".email").val() == "" ||  !emailreg.test($(".email").val()) || $(".email").val() == "Introduzca su email"){
			$(".email").focus().after("<span class='error'>Ingrese un email correcto</span>");
			return false;
		}else if( $(".asunto").val() == "" || $(".asunto").val() == "Introduzca su asunto"){
			$(".asunto").focus().after("<span class='error'>Ingrese un asunto</span>");
			return false;
		}else if( $(".mensaje").val() == "" || $(".mensaje").val() == "Introduzca su mensaje"){
			$(".mensaje").focus().after("<span class='error'>Ingrese un mensaje</span>");
			return false;
		}else if($(".mensaje").val().length < 20){
			$(".mensaje").focus().after("<span class='error'>Mínimo 20 carácteres para el mensaje</span>");
			return false;
		}
	});
	//******************************************************************************************************
	//realizamos funciones para que sea más práctico nuestro formulario
	$(".nom, .asunto, .mensaje").keyup(function(){
		if ( $(this).val() != "" ){
			$(".error").fadeOut();
			return false;
		}
	});
	
	$(".nom").keyup(function(){
		if ($(this).val().length >= 2){
			$(".error").fadeOut();
			return false;
		}
	});
	
	$(".email").keyup(function(){
		if ( $(this).val() != "" && emailreg.test($(this).val())){
			$(".error").fadeOut();
			return false;
		}
	});

	$(".mensaje").keyup(function(){
		if ($(this).val().length >= 20){
			$(".error").fadeOut();
			return false;
		}
	});
});
