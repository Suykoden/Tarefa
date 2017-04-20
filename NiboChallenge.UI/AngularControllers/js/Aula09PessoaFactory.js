app.factory('pessoa',function(){
    var pessoa = function() {
        
        this.nome = "Rafael";
        this.idade = 29;
        
        this.cumprimentar = function(){
            return "Olá " + this.name + "!";
        }
    }
    
    return pessoa;
});