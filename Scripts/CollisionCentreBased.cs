using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCentreBased : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;

    private float dist;

    [SerializeField] private AudioSource voice;
    [SerializeField] private GameObject Character1;
    [SerializeField] private GameObject Character2;
    // Start is called before the first frame update
    void Start()
    {
        dist = 0;
    }

    // Update is called once per frame
    void Update()
    {
       pos1= transform.position;
       pos2 = GameObject.Find("ImageTarget 2").transform.position ;
       float dx = pos1.x - pos2.x;
       float dy = pos1.y - pos2.y;
       float dz = pos1.z - pos2.z;

       dist = Mathf.Sqrt(dx*dx + dy*dy + dz*dz);
       if(dist < 2.5f )
        {
            voice.Play();
            Character1.SetActive(false);
            Character2.SetActive(false);
            Debug.LogError("Clash");
        }
       else
        {
            Character1.SetActive(true);
            Character2.SetActive(true);
        }


    }
}
