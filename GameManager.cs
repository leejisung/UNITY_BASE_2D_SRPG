using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[,] ARR = new int[30, 30];
    public int[,] BLUE_ARR = new int[30, 30];
    //  Singleton Instance 선언
    private static GameManager instance = null;

    // Singleton Instance에 접근하기 위한 프로퍼티
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    // GameManager 에서 사용 하는 데이터
    public bool isPause = false;
    public int score = 0;

    void Awake()
    {
        // Scene에 이미 인스턴스가 존재 하는지 확인 후 처리
        if (instance)
        {
            Destroy(this.gameObject);
            return;
        }

        // instance를 유일 오브젝트로 만든다
        instance = this;

        // Scene 이동 시 삭제 되지 않도록 처리
        DontDestroyOnLoad(this.gameObject);
    }


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {
 
    }
}
