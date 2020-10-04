using UnityEngine;

public class SprayTarjet_Script : MonoBehaviour
{
    public float paint = 50f;
    public void paintOnWall(float amount){
        paint -= amount;
        if(paint <= 0f)
        {
          Appear(); 
        }
    }

    void Appear(){
        Destroy(gameObject);
    }
}


