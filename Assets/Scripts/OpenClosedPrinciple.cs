using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        UseSkill();
    }

    public virtual void UseSkill()
    {

    }

}

public class FireballSkill : Player
{
    public override void UseSkill()
    {
        Debug.Log("Casting Fireball!");
    }
}

public class ThunderBoltSkill : Player
{
    public override void UseSkill()
    {
        Debug.Log("Casting ThunderBolt!");
    }
}
