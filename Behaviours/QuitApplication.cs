using UnityEngine;

public class QuitApplication : MonoBehaviour
{
   public void CloseGame()
   {
      Application.Quit();
      Debug.Log("Quit");
   }
   
   //Close game
}