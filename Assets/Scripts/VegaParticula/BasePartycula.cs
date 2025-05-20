using System.Collections.Generic;
using UnityEngine;

public abstract class BasePartycula : MonoBehaviour
{
    [Header("Particula")]
    [SerializeField] protected int cant = 50;

    protected List<Particula> particulas=new List<Particula>();

}
public class Particula
{
    public GameObject objecto;
    public Sprite sprite;
    public Color color;
    public Particula()
    {

    }
    public void SetSprite(Sprite sprite)
    {
       this.sprite = sprite;


    }
    public void SetObject(GameObject objecto)
    {

        this.objecto = objecto;
    }
 
    
}