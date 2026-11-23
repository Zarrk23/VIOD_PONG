using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPala : MonoBehaviour
{
    public float speed = 10;
    public enum JUGADOR { A, B };
    public JUGADOR jugador;

    void Update()
    {
        Vector3 dir = new Vector2(0, 0);

        if (jugador == JUGADOR.A)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }

        }
        else
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }
        }



        transform.position += dir * speed * Time.deltaTime;
    }
}
