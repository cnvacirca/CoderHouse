using UnityEngine;

public class Mage : MonoBehaviour
{
    private float X=0;
    public float speed = 50f;
    public float variable1 =1;
    public float variable2 = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        X += 0.01f;
        transform.position += new Vector3(Mathf.Sin(X/10),  Mathf.Sin(X/10), 0.0f)* Time.deltaTime * speed;
    }
}
