using UnityEngine;

// INHERITANCE
public abstract class FarmerAnimal : Animal
{
    // POLYMORPHISM
    public override Vector3 FindOwner()
    {
        // find gameobject of Punk type
        GameObject punk = GameObject.FindFirstObjectByType<Farmer>().gameObject;
        return punk.transform.position;

    }
    void Start()
    {
        Debug.Log("FarmerAnimal Start");
    }
}
