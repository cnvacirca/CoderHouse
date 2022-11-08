using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20;
    float movX, movY;
    public Rigidbody rb; 
    public GameObject shield, player; 
    private float contadorSegundos = 0.0f;

    private void Start() {
        

    }
    void Update()
    {

        ActivarEscudo();


    }



    private void FixedUpdate() {
        MovimientoJugador();
    }

    void MovimientoJugador(){
        movX= Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector3 inputJugador = new Vector3 (movX, 0, movY); 
        
        rb.AddForce(inputJugador * speed);
    }

    private void OnTriggerEnter(Collider enemyCollider) {
        if (enemyCollider.transform.gameObject.name == "Enemy"){

            if(shield.activeInHierarchy){
                shield.SetActive(false);
            }else{
                Respawn();
            }           
            
        }
    }

    void ActivarEscudo(){
        if(! shield.activeInHierarchy){
            contadorSegundos += Time.deltaTime;
            if (contadorSegundos >= 10){
                shield.SetActive(true);
                contadorSegundos = 0.0f;
            }
        }
    }

    void Respawn(){
        transform.position = new Vector3 (0.0f, 0.2f, 5.0f);

    }

}
