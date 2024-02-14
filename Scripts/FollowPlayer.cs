using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3 (0, 5, -11);
    // Start is called before the first frame update
    
    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the Camera behind the player
        transform.position = player.transform.position + offset;
    }
}
