using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteScript : MonoBehaviour
{
    public float vitesse = 30f;
    public string axe = "Horizontal";
   
    void Update()
    {
       Vector3 raquettePos = transform.position; // je récupère la position acutelle de la raquette
       raquettePos.x += Input.GetAxisRaw(axe) * vitesse * Time.deltaTime; 
       raquettePos.x = Mathf.Clamp(raquettePos.x, -23f, 23f); // on empêche la raquette de sortir de l'écran
       transform.position = raquettePos; // on applique la nouvelle position de la raquette
    }

   
    
} // Fin du script
