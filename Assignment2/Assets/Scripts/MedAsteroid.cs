using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * MedAsteroid.cs
 * Assignment 2
 * This is the class that activates the behavior for the medium asteroid
 */

public class MedAsteroid : Asteroid
{
    public void Awake()
    {
        ChangeExplodeBehavior = gameObject.AddComponent<BlowUpMed>();
    }
}

