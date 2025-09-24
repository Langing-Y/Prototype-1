using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -8);

    // Update is called once per frame
    void LateUpdate()
    {
        //偏移相机
        transform.position = player.transform.position + offset;
    }


}
