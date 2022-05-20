using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7); 
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Mantem a posição da câmera atrás do player
            transform.position = player.transform.position + offset;
    }
}
