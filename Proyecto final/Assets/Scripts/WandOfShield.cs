using UnityEngine;

public class WandOfShield : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.transform.gameObject.name == "Player"){
            Destroy(gameObject);
        }
    }



}
