
public class ClaseBuilder{

    private Powerup item = new Powerup();

    public ClaseBuilder setId(int id){
        item.Id = id;
        return this;
    }

    public ClaseBuilder setName(string name){
        item.Name = name;
        return this;
    }
    public ClaseBuilder setDescription(string description){
        item.Description = description;
        return this;
    }

    public ClaseBuilder setTexture(string texture){
        item.Texture = texture;
        return this;
    }

    public ClaseBuilder setEffect(string effect){
        item.Effect = effect;
        return this;
    }

    public ClaseBuilder setDuration(int duration){
        item.Duration = duration;
        return this;
    }
    
    public ClaseBuilder setIncompatible(List<int> incompatible){
        item.Incompatible = incompatible;
        return this;
    }

    public Powerup build(){
        if(item.Id <0){
            Console.WriteLine("El Id no es valido");
        }
        return item;
    }


}