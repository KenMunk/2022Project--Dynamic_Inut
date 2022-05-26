using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TestBallManager : MonoBehaviour
{
    public List<GameObject> testBalls;
    public List<GameObject> testButtons;

    // Start is called before the first frame update
    void Start()
    {
        if(testBalls.Count == testButtons.Count && testBalls.Count == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                UnityAction activate = testBalls[i].GetComponent<BallColorTest>().getActivate();
                UnityAction deactivate = testBalls[i].GetComponent<BallColorTest>().getDeactivate();

                for (int j = 0; j < 4; j++)
                {
                    if (j != i)
                    {
                        testBalls[j].GetComponent<BallColorTest>().addInvokable(deactivate);
                    }
                }

                testButtons[i].GetComponent<Button>().onClick.AddListener(activate);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
