using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player01HP : MonoBehaviour
{
    [SerializeField]
    Image image1;

    [SerializeField]
    Image image2;



    // Start is called before the first frame update
    private void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (image2.fillAmount > -0.1f)
        {
            //�W���C�R�����͂ɂ���ꍇ��
            //Input.GetKeyDown(KeyCode.Joystick1Button2
            //�W���C�R���iB�{�^���Ə\���L�[��
            if (Input.GetKey(KeyCode.B))
            {
                image2.fillAmount -= Time.deltaTime;
            }
            else
            {
                image2.fillAmount += Time.deltaTime;
            }

        }

        if (image1.fillAmount > -0.1f)
        {
            if (Input.GetKey(KeyCode.A))
            {
                image1.fillAmount -= Time.deltaTime;
            }
            else
            {
                image1.fillAmount += Time.deltaTime;
            }

        }


    }

}
