﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PWGame : Game {

    public List<GameObject> SpawnPool;
    
    public virtual void Start()
    {

    }

    public virtual GameObject GetCar()
    {
        return null; 
    }

    public virtual void ReturnCar(GameObject c)
    {

    }
}
