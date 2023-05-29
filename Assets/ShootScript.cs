using UnityEngine;

public class ShootScript : MonoBehaviour {

    public Transform Gun;
    Vector2 direction;
    private AudioScript audioScript;
    public int setMaxBulletAmount = 15;

    public GameObject Bullet;
    public float BulletSpeed;
    public Transform ShootPoint;

    public float fireRate;
    float ReadyForNextShot;

    // Start is called before the first frame update
    void Start()
    {
        audioScript = FindObjectOfType<AudioScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();

        if(Input.GetMouseButtonDown(0)){
            if(Time.time > ReadyForNextShot ){
                ReadyForNextShot = Time.time + (1/fireRate);
                if(setMaxBulletAmount > 0){
                    shoot();
                    audioScript.PlayShootSound();
                }
                setMaxBulletAmount--;
            }
        }
    }

    void FaceMouse() {
        Gun.transform.right = direction;
    }

    void shoot(){
       GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
       BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed); 
       Destroy(BulletIns, 1);    
    }
}