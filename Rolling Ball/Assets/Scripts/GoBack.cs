using UnityEngine;

public class GoBack : MonoBehaviour
{
    private float speed = 15f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
