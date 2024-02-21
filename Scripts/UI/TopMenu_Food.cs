using UnityEngine;
using TMPro;

public class TopMenu_Food : MonoBehaviour
{    
    public TMP_Text tmptext;
    public DataResource dataresource;//юс╫ц╥н
    int nfood;
    void Start()
    {                
        dataresource = GetComponent<DataResource>();
        nfood = dataresource.nFood;
        tmptext.text = nfood.ToString();       
    }

    // Update is called once per frame
    void Update()
    {
        if(nfood != dataresource.nFood)
        {
            nfood = dataresource.nFood;
            tmptext.text = nfood.ToString();
        }
    }
}
