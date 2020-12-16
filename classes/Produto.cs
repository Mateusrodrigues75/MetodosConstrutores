namespace MetodosConstrutores.classes
{
    public class Produto
    {
        public int Code{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public int Stock{get;set;}

        public Produto (){
        }
        public Produto(int cod){
            Code = cod;
        }
        public Produto(int code,string name,string description,int stock){
            Code = code;
            Name = name;
            Description = description;
            Stock = stock;
        }
    }
}
