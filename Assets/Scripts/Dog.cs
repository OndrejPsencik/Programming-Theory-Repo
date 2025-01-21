using UnityEngine;

public class Dog : Animal
{
    public override Vector3 FindOwner()
    {
        // find gameobject of Punk type
        GameObject punk = GameObject.FindFirstObjectByType<Punk>().gameObject;
        return punk.transform.position;
    }

    void Start()
    {
        Debug.Log("Dog Start");
    }
}
