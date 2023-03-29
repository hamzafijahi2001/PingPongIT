using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement1 : MonoBehaviour
{
    public int speed = 5;
    [HideInInspector] public List<int> Keys1 = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Keys1.Add(0);
        if(transform.position.y < 3.4f && transform.position.y > -3.4f){
        if (Input.GetKey("up"))
           {Keys1.Add(1);
             transform.position = new Vector3(transform.position.x , transform.position.y + speed*Time.deltaTime,-1);}
        if (Input.GetKey("down"))
            {Keys1.Add(0);
                transform.position = new Vector3(transform.position.x , transform.position.y - speed*Time.deltaTime,-1);}
        }
        else if(transform.position.y > 3.4f){
         if (Input.GetKey("down"))
           {Keys1.Add(0);
            transform.position = new Vector3(transform.position.x , transform.position.y - speed*Time.deltaTime,-1);}}
        else if(transform.position.y < -3.4f){
             if (Input.GetKey("up"))
           {Keys1.Add(1);
            transform.position = new Vector3(transform.position.x , transform.position.y + speed*Time.deltaTime,-1);}
        }
                //Debug.Log(Keys);

    }
}
