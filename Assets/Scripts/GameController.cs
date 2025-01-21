using UnityEngine;

public class GameController : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //if button clicked on animal
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var animal = hit.collider.GetComponentInParent<Animal>();
                if(animal!=null)
                {
                    animal.GoToOwner();
                }
            }
        }
    }
}
