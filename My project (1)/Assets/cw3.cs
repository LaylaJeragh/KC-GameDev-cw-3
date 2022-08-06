using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string heroname = "potato";
    int heropower = 10;
    string villanname = "tomato";
    int villanpower = 13;

    float playerspeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villanpower)
        {
            print(heroname + " he is stronger");
        }
        else if (heropower == villanpower)
        {
            print(heroname + "equals"+ villanname)
        }
        else
        {
            print(villanname + " is stronger");
        }

        setspeed = (2.5f);
    }

    // Update is called once per frame
    void setspeed (float speed)
    {
        print(playerspeed);
        playerspeed = speed;
        print(playerspeed);
    }
}
