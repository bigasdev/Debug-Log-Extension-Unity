# Debug-Log-Extension-Unity

This script creates the Log namespace, ill be using it to make some debugs easier (position, missed component/reference, boolean checks, etc) so i can have a nice and easy to read template to debug stuff.

Example of use:

using Log;

public class Player : MonoBehaviour {

   public Controller controller;
   
   public void Move(){
      if(controller == null){
           Debugger.MissReference();
           return;
       }
   }
}
          
It's a simple project for my own use, feel free to add more stuff to it! 

