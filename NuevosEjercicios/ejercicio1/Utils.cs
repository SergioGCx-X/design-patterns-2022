// Refactoriza para implementar el patron de diseño mas adecuado
public class GameUtils{
    private static GameUtils u;

    private GameUtils (){}

    public static GameUtils getInstance(){
        if (u == null){
            u = new GameUtils();
        }
        return u;
    }

    public int calcDamage(){
        return 1;
    }

    public int calcDefence(){
        return 1;
    }

    public int calcDistance(){
        return 1;
    }

}

// Refactoriza para implementar el patron de diseño mas adecuado
//public class GameUtils{
//
//    public int calcDamage(){
//        return 1;
//    }
//
//    public int calcDefence(){
//        return 1;
//    }
//
//    public int calcDistance(){
//        return 1;
//    }
//
//}