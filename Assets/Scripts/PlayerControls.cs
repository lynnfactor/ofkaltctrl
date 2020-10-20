using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* created by Aubrey Isaacman
 * 
 * This script lets the player kiss and stop kissing their partner
 *      If their partner's lips are in the kiss position and the player presses the kiss button, kiss successful
 *      If their partner's lips are resting and the player presses the button, kiss is UNsuccessful
 *      If their partner's lips are in the kiss position and the player does NOT press the button, kiss is UNsuccessful
 * 
 */

public class PlayerControls : MonoBehaviour
{

    public Sprite[] liptype; // I need a way to change THIS VAR with whatever the array element is
    // need to reference this line from lipspawner script:         GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
    //public Sprite[] kissRef;

    public int arrayVal; // to reference "rand" from other script

    public lipspawner lipScript;

    void Awake()
    {
        // using this for referencing other script: https://answers.unity.com/questions/42843/referencing-non-static-variables-from-another-scri.html
        GameObject theLips = GameObject.Find("LipSpawner");
        lipScript = theLips.GetComponent<lipspawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //liptype = gameObject.GetComponent<lipspawner>().Sprite_Pic;
    }

    // Update is called once per frame
    void Update()
    {
        arrayVal = lipScript.rand;


        if (arrayVal == 0)
        {
            Debug.Log("partner is KISSING");
        }

        

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Player smooch");
        } else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Stop kiss");
        }

    }

    // look at the array of lips
    // look at this for help https://www.reddit.com/r/Unity3D/comments/8lseyt/accessing_an_object_from_2d_array_from_another/dzi8z0u/
    void DoSomething()
    {
        //Sprite[] lipsSprites = lipspawner.instance.Sprite_Pic(this);
    }
    
}
