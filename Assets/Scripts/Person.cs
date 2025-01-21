using Unity.VisualScripting;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    public string Name { get; set; }

    void Start()
    {
        Debug.Log("Person Start");
    }
}
