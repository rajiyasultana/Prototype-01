using UnityEngine;

public class RepateBackground : MonoBehaviour
{
    private Vector3 startPositon;
    private float repeatWidth;
    void Start()
    {
        startPositon = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPositon.x - repeatWidth)
        {
            transform.position = startPositon;
        }
    }
}
