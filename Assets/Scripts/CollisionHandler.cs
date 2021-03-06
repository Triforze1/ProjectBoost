using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag)
        {
            case "Friendly": 
                Debug.Log("This thing is Friendly");
                break;
            case "Finish": 
                Debug.Log("Congrats, you finished");
                break;
            case "Fuel": 
                Debug.Log("You picked up Fuel");
                break;
            default: 
                Debug.Log("Sorry, you blew up");
                break;
        }
    }
}
