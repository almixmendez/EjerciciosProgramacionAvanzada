using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IWeapon
{
    public void Equip()
    {
        throw new System.NotImplementedException();
        Debug.Log("Sword equipped!");
    }
}

public class InventoryManager : Weapon
{
    private IWeapon weapon;

    public void SetWeapon(IWeapon weapon)
    {

    }
}

public interface IWeapon
{
    void Equip();
}
