using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    public float limitMax;
    public float limitMin;
    
    void Update()
    {
        if (transform.position.y > limitMax)
        {
            transform.position = new Vector3(transform.position.x, limitMax);
        }
        if (transform.position.y < limitMin)
        {
            transform.position = new Vector3(transform.position.x, limitMin); ;
        }
    }
}
