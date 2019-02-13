using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAPawn : PWPawn
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Horizontal(float value)
    {

    }

    public override void Vertical(float value)
    {

    }

    public override void Fire1(bool value)
    {
        
        LOG("#" + controller.PlayerNumber + " goes BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!BANG!");
    }

    public override void Fire2(bool value)
    {

    }

    public override void Fire3(bool value)
    {

    }

    public override void Fire4(bool value)
    {

    }
}
