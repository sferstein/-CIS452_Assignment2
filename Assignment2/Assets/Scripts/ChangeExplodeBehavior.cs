using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * ChangeExplodeBehavior.cs
 * Assignment 2
 * This is the part of the Strategy Design Pattern that overrides the main method for each type of asteroid.
 */

public class BlowUpBig : ChangeExplodeBehavior
{
    public override void BlowUp()
    {
        Destroy(gameObject);
    }
}

public class BlowUpMed : ChangeExplodeBehavior
{
    public override void BlowUp()
    {
        Destroy(gameObject);
    }
}

public class BlowUpSml : ChangeExplodeBehavior
{
    public override void BlowUp()
    {
        Destroy(gameObject);
    }
}