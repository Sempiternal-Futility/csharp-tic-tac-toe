using System;

class ArtificialDumbness : ExtraMethods
{

    //This byte is here to fix a stackoverflow exception in the "DrawRandomPosition()" method
    static byte loopRandomDraw = 9;



 


    public static void DefenseAI()
    {

      Console.ForegroundColor = ConsoleColor.Red;
      bool patternFound = false;


      //HORIZONTAL PATTERNS:
      
      //POS 1
      if ( posTwoPlayed && posThreePlayed )
      { 

          if ( !posOnePlayed && !AIposOnePlayed )
	  { 
        
             DrawEnemy( (int)PosX.Left, (int)PosY.Top );

             AIposOnePlayed = true;
	     patternFound = true;

	     //THIS RETURN IS HERE TO "EXIT" OUT OF THE METHOD, SO IT WILL CHECK NO FURTHER
	     return;

	  }

      }

      //POS 2
      if ( posOnePlayed && posThreePlayed )
      { 

          if ( !posTwoPlayed && !AIposTwoPlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

	     AIposTwoPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 3
      if ( posOnePlayed && posTwoPlayed )
      { 

          if ( !posThreePlayed && !AIposThreePlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	     AIposThreePlayed = true;
	     patternFound = true;
	     return;

	  } 

      }

      //POS 4
      if ( posFivePlayed && posSixPlayed )
      { 

          if ( !posFourPlayed && !AIposFourPlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

	     AIposFourPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 5
      if ( posFourPlayed && posSixPlayed )
      { 

          if ( !posFivePlayed && !AIposFivePlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	     AIposFivePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 6
      if ( posFourPlayed && posFivePlayed )
      { 

          if ( !posSixPlayed && !AIposSixPlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

	     AIposSixPlayed = true;
	     patternFound = true;
	     return;

	  }
      
      }

      //POS 7
      if ( posEightPlayed && posNinePlayed )
      { 

          if ( !posSevenPlayed && !AIposSevenPlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );
	     
	     AIposSevenPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 8
      if ( posSevenPlayed && posNinePlayed )
      { 

          if ( !posEightPlayed && !AIposEightPlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

	     AIposEightPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 9
      if ( posSevenPlayed && posEightPlayed )
      { 

          if ( !posNinePlayed && !AIposNinePlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	     AIposNinePlayed = true;
	     patternFound = true;
	     return;

	  }

      }



      //VERTICAL PATTERNS:
      
      //POS 1
      if ( posFourPlayed && posSevenPlayed )
      { 

          if ( !posOnePlayed && !AIposOnePlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	     AIposOnePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 2
      if ( posFivePlayed && posEightPlayed )
      { 

          if ( !posTwoPlayed && !AIposTwoPlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

	     AIposTwoPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 3
      if ( posSixPlayed && posNinePlayed )
      { 

          if ( !posThreePlayed && !AIposThreePlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	     AIposThreePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 4
      if ( posOnePlayed && posSevenPlayed )
      { 

          if ( !posFourPlayed && !AIposFourPlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

	     AIposFourPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 5
      if ( posTwoPlayed && posEightPlayed )
      { 

          if ( !posFivePlayed && !AIposFivePlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	     AIposFivePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 6
      if ( posThreePlayed && posNinePlayed )
      { 

          if ( !posSixPlayed && !AIposSixPlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

	     AIposSixPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 7
      if ( posOnePlayed && posFourPlayed )
      { 

          if ( !posSevenPlayed && !AIposSevenPlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

	     AIposSevenPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 8
      if ( posTwoPlayed && posFivePlayed )
      { 

          if ( !posEightPlayed && !AIposEightPlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

	     AIposEightPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 9
      if ( posThreePlayed && posSixPlayed )
      { 

          if ( !posNinePlayed && !AIposNinePlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	     AIposNinePlayed = true;
	     patternFound = true;
	     return;

	  }

      }



      //DIAGONAL PATTERNS:
      
      //POS 1
      if ( posFivePlayed && posNinePlayed )
      { 

          if ( !posOnePlayed && !AIposOnePlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	     AIposOnePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 3
      if ( posFivePlayed && posSevenPlayed )
      { 

          if ( !posThreePlayed && !AIposThreePlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	     AIposThreePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 7
      if ( posFivePlayed && posThreePlayed )
      { 

          if ( !posSevenPlayed && !AIposSevenPlayed )
	  { 

	     DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );
	     
	     AIposSevenPlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 9
      if ( posFivePlayed && posOnePlayed )
      { 

          if ( !posNinePlayed && !AIposNinePlayed )
	  { 

	     DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	     AIposNinePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 5.1
      if ( posOnePlayed && posNinePlayed )
      { 

          if ( !posFivePlayed && !AIposFivePlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	     AIposFivePlayed = true;
	     patternFound = true;
	     return;

	  }

      }

      //POS 5.2
      if ( posThreePlayed && posSevenPlayed )
      { 

          if ( !posFivePlayed && !AIposFivePlayed )
	  {

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	     AIposFivePlayed = true;
	     patternFound = true;
	     return;

	  }

      }




      //IF THERE'S NO DEFENSE PATTERNS FOUND, ( LIKE ON THE FIRST TURN, OR SPECIFIC SITUATIONS ), THEN IT PLAYS RANDOMLY
      if ( patternFound == false )
      { DrawRandomPosition(); } 


    }






    public static bool AttackAI()
    { 

        Console.ForegroundColor = ConsoleColor.Red;


        //HORIZONTAL PATTERNS:
	
	//POS 1
	if ( AIposTwoPlayed && AIposThreePlayed )
	{ 

	    if ( !posOnePlayed && !AIposOnePlayed )
	    { 

	       DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	       AIposOnePlayed = true; 

	       //THE METHOD RETURNS TRUE IF IT FINDS AN ATTACK PATTERN
	       return true;

	    }

	}


	//POS 2
	if ( AIposOnePlayed && AIposThreePlayed )
	{ 

	   if ( !posTwoPlayed && !AIposTwoPlayed )
	   { 

	       DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

	       AIposTwoPlayed = true;
	       return true;

	   }

	}

	//POS 3
	if ( AIposOnePlayed && AIposTwoPlayed )
	{ 

	   if ( !posThreePlayed && !AIposThreePlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	      AIposThreePlayed = true;
	      return true;

	   }

	}

	//POS 4
	if ( AIposFivePlayed && AIposSixPlayed )
	{ 

	   if ( !posFourPlayed && !AIposFourPlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

	      AIposFourPlayed = true;
	      return true;

	   }

	}

	//POS 5
	if ( AIposFourPlayed && AIposSixPlayed )
	{ 

	   if ( !posFivePlayed && !AIposFivePlayed )
	   { 

	      DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	      AIposFivePlayed = true;
	      return true;

	   }

	}

	//POS 6
	if ( AIposFourPlayed && AIposFivePlayed )
	{ 

	   if ( !posSixPlayed && !AIposSixPlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

	      AIposSixPlayed = true;
	      return true;

	   }

	}

	//POS 7
	if ( AIposEightPlayed && AIposNinePlayed )
	{ 

	   if ( !posSevenPlayed && !AIposSevenPlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

	      AIposSevenPlayed = true;
	      return true;

	   }

	}

	//POS 8
	if ( AIposSevenPlayed && AIposNinePlayed )
	{ 

	   if ( !posEightPlayed && !AIposEightPlayed )
	   { 

	      DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

	      AIposEightPlayed = true;
	      return true;

	   }

	}

	//POS 9
	if ( AIposSevenPlayed && AIposEightPlayed )
	{ 

	   if ( !posNinePlayed && !AIposNinePlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

              AIposNinePlayed = true;
	      return true;

	   }

	}


	
	//VERTICAL PATTERNS:
	
	//POS 1
	if ( AIposFourPlayed && AIposSevenPlayed )
	{ 

	   if ( !posOnePlayed && !AIposOnePlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	      AIposOnePlayed = true;
	      return true;

	   }

	}

	//POS 2
	if (AIposFivePlayed && AIposEightPlayed )
	{ 

	   if ( !posTwoPlayed && !AIposTwoPlayed )
	   { 

	      DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

	      AIposTwoPlayed = true;
	      return true;

	   }

	}

	//POS 3
	if ( AIposSixPlayed && AIposNinePlayed )
	{ 

	   if ( !posThreePlayed && !AIposThreePlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	      AIposThreePlayed = true;
	      return true;

	   }

	}

	//POS 4
	if ( AIposOnePlayed && AIposSevenPlayed )
	{ 

	   if ( !posFourPlayed && !AIposFourPlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

	      AIposFourPlayed = true;
	      return true;

	   }

	}

	//POS 5
	if ( AIposTwoPlayed && AIposEightPlayed )
	{ 

	   if ( !posFivePlayed && !AIposFivePlayed )
	   { 

	      DrawEnemy ( (int)PosX.Middle, (int)PosY.Middle );

	      AIposFivePlayed = true;
	      return true;

	   }

	}

	//POS 6
	if ( AIposThreePlayed && AIposNinePlayed )
	{ 

	   if ( !posSixPlayed && !AIposSixPlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

	      AIposSixPlayed = true;
	      return true;

	   }

	}

	//POS 7
	if ( AIposOnePlayed && AIposFourPlayed )
	{ 

	   if ( !posSevenPlayed && !AIposSevenPlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

              AIposSevenPlayed = true;
	      return true;

	   }

	}

	//POS 8
	if ( AIposTwoPlayed && AIposFivePlayed )
	{ 

	   if ( !posEightPlayed && !AIposEightPlayed )
	   { 

	      DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

	      AIposEightPlayed = true;
	      return true;

	   }

	}

	//POS 9
	if ( AIposThreePlayed && AIposSixPlayed )
	{ 

	   if ( !posNinePlayed && !AIposNinePlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	      AIposNinePlayed = true;
	      return true;

	   }

	}

	

	//DIAGONAL PATTERNS:

	//POS 1
	if ( AIposFivePlayed && AIposNinePlayed )
	{ 

	   if ( !posOnePlayed && !AIposOnePlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	      AIposOnePlayed = true;
	      return true;

	   }

	}

	//POS 3
	if ( AIposFivePlayed && AIposSevenPlayed )
	{ 

	   if ( !posThreePlayed && !AIposThreePlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	      AIposThreePlayed = true;
	      return true;

	   }

	}

	//POS 7
	if ( AIposFivePlayed && AIposThreePlayed )
	{ 

	   if ( !posSevenPlayed && !AIposSevenPlayed )
	   { 

	      DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

	      AIposSevenPlayed = true;
	      return true;

	   }

	}

	//POS 9
	if ( AIposFivePlayed && AIposOnePlayed )
	{ 

	   if ( !posNinePlayed && !AIposNinePlayed )
	   { 

	      DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	      AIposNinePlayed = true;
	      return true;

	   }

	}

      //POS 5.1
      if ( AIposOnePlayed && AIposNinePlayed )
      { 

          if ( !posFivePlayed && !AIposFivePlayed )
	  { 

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	     AIposFivePlayed = true;
	     return true;

	  }

      }

      //POS 5.2
      if ( AIposThreePlayed && AIposSevenPlayed )
      { 

          if ( !posFivePlayed && !AIposFivePlayed )
	  {

	     DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	     AIposFivePlayed = true;
	     return true;

	  }

      }


	//THE METHOD RETURNS FALSE IF IT DOESN'T FIND AN ATTACK PATTERN
	return false;
    }






    //Draws the enemy at a random position of the tic-tac-toe board
    static void DrawRandomPosition()
    {

      int randomNum = new Random().Next(1, 10);
      
      //POS 1
      if ( (randomNum == 1) )
      {

         //Checks if the position hasn't been taken
         if ( !posOnePlayed && !AIposOnePlayed )
         {

          DrawEnemy( (int)PosX.Left, (int)PosY.Top );
          AIposOnePlayed = true;
          loopRandomDraw = 9;

         }

         //If the position is already taken, it resets the method
         else
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }


      //POS 2
      if ( (randomNum == 2) )
      {
         if ( !posTwoPlayed && !AIposTwoPlayed )
         {

          DrawEnemy( (int)PosX.Middle, (int)PosY.Top );
          AIposTwoPlayed = true;
          loopRandomDraw = 9;

         }

         else
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }


      //POS 3
      if ( (randomNum == 3) )
      {
         if ( !posThreePlayed && !AIposThreePlayed )
         {

             DrawEnemy( (int)PosX.Right, (int)PosY.Top );
             AIposThreePlayed = true;
             loopRandomDraw = 9;

         }

         else 
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }
         
      }

      //POS 4
      if ( (randomNum == 4 ) )
      {
         if ( !posFourPlayed && !AIposFourPlayed )
         {

             DrawEnemy( (int)PosX.Left, (int)PosY.Middle );
             AIposFourPlayed = true;
             loopRandomDraw = 9;

         }

         else 
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 5
      if ( (randomNum == 5) )
      {
         if ( !posFivePlayed && !AIposFivePlayed )
         {

             DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );
             AIposFivePlayed = true;
             loopRandomDraw = 9;

         }

         else 
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 6
      if ( (randomNum == 6) )
      {
          if ( !posSixPlayed && !AIposSixPlayed )
          {

             DrawEnemy( (int)PosX.Right, (int)PosY.Middle );
             AIposSixPlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 7
      if ( (randomNum == 7) )
      {
          if ( !posSevenPlayed && !AIposSevenPlayed )
          {

             DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );
             AIposSevenPlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 8
      if ( (randomNum == 8) )
      {
          if ( !posEightPlayed && !AIposEightPlayed )
          {

             DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );
             AIposEightPlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 9
      if ( (randomNum == 9) )
      {
          if ( !posNinePlayed && !AIposNinePlayed )
          {

             DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );
             AIposNinePlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

    }


    static void DrawEnemy( int PosX, int PosY )
    {

          Console.SetCursorPosition(PosX, PosY);

          if ( !DrawingPlayer.circle )
          { DrawCircle(); }

          else 
          { DrawX(); }
    }
}
