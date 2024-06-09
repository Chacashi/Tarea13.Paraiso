using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubickControl : MonoBehaviour
{
  public float speed;
  public float horizontal;
  public float vertical; 
  Rigidbody2D _compRigidbody2D;
  public AudioSource _compAudioSource;
  public GameObject bulletPrefab;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
	vertical = Input.GetAxisRaw("Vertical");
	if(Input.GetButtonDown("Fire1") == true)
	{
	  _compAudioSource.Play();
	  Instantiate(bulletPrefab, transform.position, transform.rotation);
	}

    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed*horizontal,speed*vertical);

    }
    
}
