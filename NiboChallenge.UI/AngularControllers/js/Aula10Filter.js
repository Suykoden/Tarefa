app.filter('saudacao',function(){
    return function(nome){
        return "Olá " +nome+ "!";
    }
    
});