public class Ejercicio2Cliente : IConsumer
{

    public void runClient()
    {
    // Refactoriza para implementar el patron de diseño mas adecuado
    //Tratemos con Builder :D
    Console.WriteLine("Ejecucion estilo builder");

       //Powerup powerup = new Powerup();
       //powerup.Id = 1;
       //powerup.Name = "Fire flower";
       //powerup.Description = "Descripcion de Fire flower: Florecita que te permite lanzar bolas";
       //powerup.Duration = 100;
       //powerup.Incompatible = new List<int>{1,4,6};
       //powerup.Texture = "FireFlower.png";
       //powerup.Effect = "fire.png";

       ClaseBuilder Elbuilder = Powerup.GetBuilder().setId(1).setName("Fire Flower")
       .setDescription("Descripcion de Fire flower: Florecita que te permite lanzar bolas de fuego")
       .setDuration(100).setIncompatible(new List<int>{1,4,6}).setTexture("FireFlower.png")
       .setEffect("fire.png");

       Powerup powerup = Elbuilder.build();

       Console.WriteLine($"Item creado = {powerup.Name}");

    }
}