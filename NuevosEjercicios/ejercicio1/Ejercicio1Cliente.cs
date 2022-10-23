// Refactoriza para implementar el patron de diseño mas adecuado
public class Ejercicio1Cliente : IConsumer{
    public void runClient(){
       GameUtils utils = GameUtils.getInstance();
       utils.calcDamage();
       utils.calcDistance();
       utils.calcDefence();

       Console.WriteLine("Ejecucion de calculos de Damage/Distance/Defense");

    }
}

//=== ORIGINAL ===//
//public class Ejercicio1Cliente : IConsumer
//{
//   public void runClient()
//    {
//       GameUtils utils = new GameUtils();
//       utils.calcDamage();
//       utils.calcDistance();
//       utils.calcDefence();
//    }
//}