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

    public int liptype; // I need a way to change THIS VAR with whatever the array element is
    // need to reference this line from lipspawner script:         GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
    public Sprite[] spriteRef;

    public LipScript lipspawner;


    // Start is called before the first frame update
    void Start()
    {
        liptype = gameObject.GetComponent<lipspawner>().rand;
        //spriteRef = gameObject.GetComponent<lipspawner>().Sprite_Pic[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(spriteRef[liptype] == spriteRef[0])
        {
            Debug.Log("partner is KISSING");
        } else if (liptype == 1)
        {
            Debug.Log("partner is RESTING");
        } else {
            Debug.Log("error");
        }


        // // check which sprite is active on the screen
        // --> you'll probably need to call the other script to do this
            // check if the Arduino button is being pressed
            // Then, play kiss sound and spawn hearts

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
