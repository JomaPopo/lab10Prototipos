using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FliParticula : BasePartycula
{
    [SerializeField] private GameObject game;
    [SerializeField] private Sprite spri;
    [SerializeField] private GameObject targe;
    [SerializeField] private Color color;
    void Start()
    {

        for (int i = 0; i < cant; i++)
        {
            Particula particula=new Particula();
            particula.sprite = spri;
            particula.color = color;
            particula.objecto = game;
          
            particulas.Add(particula);
            
            GameObject newparty=Instantiate(particula.objecto,transform.position,Quaternion.identity);
        }
      
    }


}
