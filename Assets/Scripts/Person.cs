using Unity.VisualScripting;
using UnityEngine;

// INHERITANCE
public abstract class Person : MonoBehaviour
{
    // ENCAPSULATION
    public string Name { get; set; }

    void Start()
    {
        Debug.Log("Person Start");
    }
}
