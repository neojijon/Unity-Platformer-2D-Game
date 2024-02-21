using UnityEngine;
using TMPro;

public class TopMenu_Gold : MonoBehaviour
{    
    public TMP_Text tmptext;
    public DataResource dataresource;//�ӽ÷�
    int ngold;
    void Start()
    {                
        dataresource = GetComponent<DataResource>();
        ngold = dataresource.nGold;
        tmptext.text = ngold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (ngold != dataresource.nGold)
        {
            ngold = dataresource.nGold;
            tmptext.text = ngold.ToString();
        }
    }
}
