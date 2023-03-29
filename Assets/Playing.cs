using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Playing : MonoBehaviour
{
    public Text scoreText1;
    public Text scoreText2;
    public static string winner;
    private bool randomBool;
    int speed=4;
    [SerializeField]public static int scr1;
    [SerializeField]public static int scr2;
    GameObject obj;
    GameObject obj1;
    private Mouvement mvt;
    private Mouvement1 mvt1;
    int cmpy=0;
    int cmpx=1;
    List<int> Keyscpy = new List<int>();
    List<int> Keyscpy1 = new List<int>();
    List<int> coll = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        randomBool = Random.value > 0.5;
        obj = GameObject.Find("Player1");
        Keyscpy.AddRange(obj.GetComponent<Mouvement>().Keys);
        obj1 = GameObject.Find("Player2");
        Keyscpy1.AddRange(obj1.GetComponent<Mouvement1>().Keys1);
        //randomNumber = Random.Range(1, 2);
        transform.position = new Vector3(0f ,0f ,-1f);
        scoreText1.text = scr1.ToString();
        scoreText2.text = scr2.ToString();
        

    }

    // Update is called once per frame
    void Update()
    {
        Keyscpy.Clear();
        Keyscpy.AddRange(obj.GetComponent<Mouvement>().Keys);
        

        if(randomBool==true){
                transform.position = new Vector3(transform.position.x - speed*Time.deltaTime*cmpx ,transform.position.y- speed*Time.deltaTime*cmpy ,-1f);
                }
        if(randomBool==false){
                transform.position = new Vector3(transform.position.x + speed*Time.deltaTime*cmpx ,transform.position.y + speed*Time.deltaTime*cmpy,-1f);
                }

        
    }
    void OnCollisionEnter2D(Collision2D  c){
        if(c.collider.name=="Player1"){
            if(Keyscpy[^1]==0){
                if(randomBool==true){
                    randomBool=!randomBool;
                    cmpx=1;
                    cmpy=-1;
                }
                else{
                    cmpx=1;
                    cmpy=-1;
                }}
            else{
                if(randomBool==true){
                    randomBool=!randomBool;
                    cmpx=1;
                    cmpy=1;
                }
                else{
                    cmpx=1;
                    cmpy=1;
                }            
                
            }
        }
        if(c.collider.name=="Player2"){
            if(Keyscpy1[^1]==0){
                if(randomBool==true){
                    randomBool=!randomBool;
                    cmpx=-1;
                    cmpy=-1;
                }
                else{
                    cmpx=-1;
                    cmpy=-1;
                }}
            else{
                if(randomBool==true){
                    randomBool=!randomBool;
                    cmpx=-1;
                    cmpy=1;
                }
                else{
                    cmpx=-1;
                    cmpy=1;
                }            
                
            }
        }
        if(c.collider.name=="Wall 1"){
            Debug.Log("A colision !!");
            if(randomBool==true){
                    //randomBool=!randomBool;
                    if(cmpx==-1 && cmpy==-1){

                        cmpx=-1;
                        cmpy=1;}
                    else if((cmpx==-1 && cmpy==1)||(cmpx==1 && cmpy==-1)){
                        cmpx=1;
                        cmpy=1;
                    }
                }
                else{
                    if(cmpx==1 && cmpy==1){

                        cmpx=1;
                        cmpy=-1;
                        coll.Add(0);}
                    else if((cmpx==-1 && cmpy==1)||(cmpx==1 && cmpy==-1)){
                        cmpx=-1;
                        cmpy=-1;
                    }
                }
        /*cmpy=1;
        if(coll[^1]==0)cmpx = -1;
        else cmpx=1;
        randomBool=!randomBool;
        coll.Add(1);*/
        }
        if(c.collider.name=="Wall 2"){
            Debug.Log("A colision !!");
                if(randomBool==true){
                    //randomBool=!randomBool;
                    if(cmpx==1 && cmpy==1){
                        cmpx=1;
                        cmpy=-1;}
                    else if((cmpx==-1 && cmpy==1)||(cmpx==1 && cmpy==-1)){
                        cmpx=-1;
                        cmpy=-1;
                    }
                }
                else{
                    if(cmpx==-1 && cmpy==-1){
                        cmpx=-1;
                        cmpy=1;}
                    else if((cmpx==-1 && cmpy==1)||(cmpx==1 && cmpy==-1)){
                        cmpx=1;
                        cmpy=1;
                    }
                }

        }
        if(c.collider.name=="Endgame1"){
            scr1++;
            scoreText1.text = scr1.ToString();
            if(scr1==10){
                winner = "PLAYER 1 WON" ;
                SceneManager.LoadScene(1);
            }
            else
            SceneManager.LoadScene(0);
        }
        if(c.collider.name=="Endgame2"){
            scr2++;
            scoreText2.text = scr2.ToString();
            if(scr2==10){
                winner = "PLAYER 2 WON" ;
                SceneManager.LoadScene(1);}
            else
            SceneManager.LoadScene(0);
        }




                   
        }
        
}
