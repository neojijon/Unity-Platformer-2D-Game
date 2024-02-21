using UnityEngine;
using TMPro;

public class TopMenu_Gem : MonoBehaviour
{    
    public TMP_Text tmptext;
    public DataResource dataresource;//юс╫ц╥н
    int ngem;
    void Start()
    {                
        dataresource = GetComponent<DataResource>();
        ngem = dataresource.nGem;
        tmptext.text = ngem.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (ngem != dataresource.nGem)
        {
            ngem = dataresource.nGem;
            tmptext.text = ngem.ToString();
        }
    }
}
