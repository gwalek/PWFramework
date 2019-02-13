using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAPlayerController : PlayerController
{
    public GameObject PawninSceneAtStart; 


    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        IsHuman = true;
        LogInputStateInfo = false;

        if (!PossesPawn(PawninSceneAtStart))
        {
            LOG_ERROR("Where's the pawn, dude?"); 
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void Horizontal(float value)
    {
        if (value != 0)
        {
            LOG("Del-Horizontal (" + value + ")");
        }
    }

    public override void Vertical(float value)
    {
        if (value != 0)
        {
            LOG("Del-Vertical (" + value + ")");
        }
    }

    public override void Fire1(bool value)
    {
        if (value)
        {
            //doing this in two lines
            PWPawn p = (PWPawn)PossesedPawn;
            p.Fire1(value);

            // doing this in one line. 
            // ((PWPawn)PossesedPawn).Fire1(value); 
        }
    }

    public override void Fire2(bool value)
    {
        if (value)
        {
            LOG("Del-Fire2");
        }
    }

    public override void Fire3(bool value)
    {
        if (value)
        {
            LOG("Del-Fire3");
        }
    }

    public override void Fire4(bool value)
    {
        if (value)
        {
            LOG("Del-Fire4");
        }
    }
}
