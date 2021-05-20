using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class playerController : MonoBehaviour
{

    public string escenaMuerto;

    Rigidbody rb;
    Animator anim;

    public bool isGround;
    public float movSpeed=7;
    public float jumpForce=15;

    public spawnManager spawnManager;

    public string horizontal;
    public string jump;

    public bool Vivo;


    void Start()
    { 
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        anim.Play("Movement");

        Vivo=true;
    }
    private void FixedUpdate()
    {
        float hMovement=Input.GetAxis(horizontal)*movSpeed;
        float vMovement=movSpeed*2;

        transform.Translate(new Vector3(hMovement, 0, vMovement)*Time.deltaTime);

        anim.SetFloat("MoveSpeed", vMovement);
    }   


    private void OnTriggerEnter(Collider other)
    {

        if(other.transform.CompareTag("finCarretera"))
        {
            spawnManager.SpwanTriggerEntered();
        }

        if (other.gameObject.CompareTag("obstaculo"))
        {
            Vivo=false;
            Invoke(nameof(HasMuerto),0f);
            Debug.Log("me he chocado");
        }
    }

    void HasMuerto()
    {
        SceneManager.LoadSceneAsync(escenaMuerto);
    }

    /*
    [Range(-1, 1)] public int pos; //defino 3 carriles fijos
    Vector3 destino;
    public bool toRight;
    public bool toLeft;

    void Update()
    {
        /*if(Input.GetButtonDown(jump) && isGround)
        {
            rb.AddForce (Vector3.up*jumpForce, ForceMode.Impulse);
            anim.Play("Jump");
        }
        if(isGround && hMovement==0 && vMovement==0)
        {
            anim.Play("idle");
        }else if(isGround && hMovement>0 && vMovement>0)
        {
            anim.Play("Movement");
        }
        else if(!isGround)
        {
            anim.Play("Jump");
        }
        if (Input.GetButtonDown("right")) //no necesito estar en uno de los 3 carriles para moverme si quiero moverme hacia la misma direcci�n
        {
            toRight = true;
            toLeft = false;
            CancelInvoke();
            Invoke(nameof(ToFalse), 0.3f);
        }

        if (Input.GetButtonDown("left"))
        {
            toRight = false;
            toLeft = true;
            CancelInvoke();
            Invoke(nameof(ToFalse), 0.3f);   
        }

        if (transform.position.x == destino.x)//me muevo SOLO si estoy en uno de los 3 carriles
        {
            if ((toRight==true) & (pos < 1))
            {
                destino.x = transform.position.x + 4;
                pos++;
                Debug.Log("me muevo hacia izq");
            }

            if ((toLeft==true) & (pos > -1))
            {
                destino.x = transform.position.x - 4;
                pos--;
                Debug.Log("me muevo hacia der");
            }
        }
        
        Vector3 xDestino = new Vector3(destino.x, transform.position.y, transform.position.z*movSpeed);

        transform.position = Vector3.MoveTowards(transform.position, xDestino, movSpeed * Time.deltaTime); //posicion= hacia donde me muevo * al velocidad
        /*if (Input.GetButtonDown("down"))
        {
            if (!isGround)//cancelo salto
            {
                rb.AddForce(Vector3.up * -jumpForce, ForceMode.Impulse);
            }
        }
    }
    void ToFalse()//vuelvo a poner en falso
    {
        toRight = false;
        toLeft = false;
    }
        */
}
