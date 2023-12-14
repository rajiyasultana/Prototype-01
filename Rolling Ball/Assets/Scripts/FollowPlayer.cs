using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    public Vector3 offset = new Vector3(0f, 1.35f, -10.95f);
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
