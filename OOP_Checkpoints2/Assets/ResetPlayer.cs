using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetPlayer : MonoBehaviour
{
    public CharacterController player;
    public GameObject respawnPoint;
    public float defaultDelay = 5.0f;
    public float targetTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Player resetting");
            float currentX = player.transform.position.x;
            float currentY = player.transform.position.y;
            float currentZ = player.transform.position.z;

            float respawnX = respawnPoint.transform.position.x;
            float respawnY = respawnPoint.transform.position.y;
            float respawnZ = respawnPoint.transform.position.z;

            player.Move(new Vector3(respawnX-currentX,respawnY-currentY,respawnZ-currentZ));
        }
    }

    void timerEnded()
    {
        respawnPoint.transform.position = player.transform.position;
        Debug.Log("New recall point set");
        targetTime = defaultDelay;
    }
}
