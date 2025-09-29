// Unity 6.2 LTS Multiplayer PlayerController
using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour {
    void Update() {
        if (!IsOwner) return;
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(moveH, 0, moveV) * Time.deltaTime * 5f);
    }
}