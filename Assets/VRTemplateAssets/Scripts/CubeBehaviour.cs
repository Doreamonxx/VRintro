using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    
    //These are public functions so they can be accessed outside the script
    public void hoverEnter()
    {
        Debug.Log("hover entered");
    }
    
    public void selected()
    {
        Debug.Log("selected");
    }
}
