using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gol : MonoBehaviour
{
   
    public GameObject soccer1;
    public GameObject soccer2;
    public GameObject soccer3;
    public GameObject soccer4;
    public bool colision = false;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "\0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.name == "Soccer Ball" || collision.gameObject.name == "Soccer Ball (1)" || collision.gameObject.name == "Soccer Ball (2)" || collision.gameObject.name == "Soccer Ball (3)")
        {
            colision = true;
            text.text = "Ai dat gol!";
            yield return new WaitForSeconds(5);
            text.text = "\0";
        }
    }
}
