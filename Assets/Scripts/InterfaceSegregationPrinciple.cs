using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICombat
{
    void Attack();
    void Defend();
}

public interface IAttacker
{
    public void Attack();
}

public interface IDefender
{
    public void Defend();
}

public class WizardControl : MonoBehaviour, ICombat
{
    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void Defend()
    {
        throw new System.NotImplementedException();
    }
}
