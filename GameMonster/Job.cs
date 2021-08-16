namespace GameMonster 
{
    
    class Thief : Player 
    {
       

      public Thief() {   

        Job = "Thief" ;
        Attack = 20;
        Defense = 2;
        Hp = 40;
        Mana = 20;
        Dodge= 40;

      }
    }
        
    class Bowman : Player 
    {
   public Bowman()
        {

        Job = "Bowman";
        Attack =20;
        Defense = 7;
        Hp =60;
        Mana =25;
        Dodge = 30;


        }
        
    }
    class Warrior : Player 
    {
        
    
    
      public  Warrior() 
        {


         Job = "Warrior";
         Attack = 15;
         Defense = 20;
         Hp = 80 ;
         Mana = 20;
         Dodge = 15;


        }

    }
     class Mage : Player 
  
    {
       public Mage() 
        {


        
             Job = "Mage";
             Attack = 40;
             Defense = 4;
             Hp = 40 ;
             Mana = 80;
             Dodge = 15;



        }
        
    }
    class Pirate : Player
    {
         public Pirate()
        {
        

        Job = "Pirate";
        Attack = 30;
        Defense = 7;
        Hp = 60 ;
        Mana = 30;
        Dodge = 25;



        } 
        
    }
    
}