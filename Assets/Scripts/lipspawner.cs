using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* created by Aubrey Isaacman
 * 
 * This script will randomly change the lips image every random number of seconds
 * 
 * Following this YouTube tutorial: https://www.youtube.com/watch?v=HxyGY-xDKas&ab_channel=LemauDevTutorialChannel
 */

public class lipspawner : MonoBehaviour
{
    public int rand;

    public Sprite[] Sprite_Pic;

    // trying to give PlayerControls access to this script and the array of lips
    // https://www.reddit.com/r/Unity3D/comments/8lseyt/accessing_an_object_from_2d_array_from_another/dzi8z0u/
    // option 3
    public static LipScript instance;


    // for waiting random seconds before changing sprite
    public int min = 0;
    public int max = 10;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Change());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator Change()
    {
        //Debug.Log("entered coroutine");

        // wait a random amount of time before changing the sprite
        int wait_time = Random.Range(min, max);

        // change the sprite
        rand = Random.Range(0, Sprite_Pic.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];

        // return a new wait time
        yield return new WaitForSeconds(wait_time);

        // call itself again so it just keeps on going
        StartCoroutine(Change());

    }
}
