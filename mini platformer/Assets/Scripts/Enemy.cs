using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Health damage;
    public GameObject player;

    public float speed; 
    public bool left = true;
    public float distance; 

    // Start is called before the first frame update
    void Start()
    {
        damage = player.GetComponent<Health>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
