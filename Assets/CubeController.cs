using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    AudioSource audioSource;

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
　　　private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
         this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
           //キューブを移動させる
　　　　　　　transform.Translate (this.speed * Time.deltaTime,0,0);
　　　　　　　
　　　　　　　//画面外に出たら破壊する
　　　　　　　if (transform.position.x < this.deadLine)
            {
                   Destroy (gameObject);
            }    
    }
      
    void OnCollisionEnter2D(Collision2D other)
    {
          if (other.gameObject.tag == "block")  
　　　　　　{     
              this.audioSource.Play();
         }
         if (other.gameObject.name == "ground")
         {
              this.audioSource.Play();
         }
    }    

}
