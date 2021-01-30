using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //スコアオブジェクト取得
    private GameObject scoreText;
    public Text scoreLabel;
    //コンポーネントをいれる
    private Material myMaterial;
    private int Score = 0;



    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");

        //障害物にアタッチしているマテリアルを取得
        this.myMaterial = GetComponent<Renderer>().material;


        //void AddPoint(int point)
        //{
          //  Score += point;
        //}
        //if(hp < 0)
        //{
         //   FindObjectOfType<Score>().AddPoint();
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
       
  
    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {


        //SmallStarTagは10点
        //if (tag == "SmallStarTag")←これは自分のTagが””だったら
        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += 10;
        }
        //LargeStarTagは25点
        else if (other.gameObject.tag == "LargeStarTag")
        {
            Score += 25;
        }
        //SmallCloudTagは40点
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Score += 40;
        }
        //LargeCloudTagは50点
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 50;
        }

        //得点を表示
        this.scoreText.GetComponent<Text>().text = "Score:" + Score;
    }
   
}
