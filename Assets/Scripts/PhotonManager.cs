using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    private int random;
    private string player;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        random = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        switch (random)
        {
            case 1:
                player = "Player";
                break;
            case 2:
                player = "Player 1";
                break;
            case 3:
                player = "Player 2";
                break;
            case 4:
                player = "Player 3";
                break;
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room",new RoomOptions { MaxPlayers = 4 },TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(player, new Vector2(Random.Range(-6f,6f),transform.position.y), Quaternion.identity);
    }
}
 