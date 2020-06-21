using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Realtime;
using JetBrains.Annotations;

public class PhotonConnection : MonoBehaviourPunCallbacks
{
    public string gameVersion = "0.0.1";
    public string nickname = "player";
    public string roomName = "JOD061";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Conectando ao servidor...", this);
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.NickName = nickName + Random.Range(0, 9999);
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado!", this);
        if (PhotonNetwork.CountOfRooms == 0)
        {
            RoomOptions options = new RoomOptions();
            options.MaxPlayers = 4;
        }
        else
        {
            PhotonNetwork.JoinOrCreateRoom(roomName, options, TypedLobby.Default);
        }
    }
    public override void PhotonNetwork.JoinOrCreateRoom()
    {
        PhotonNetwork.JoinOrCreateRoom(roomName, options, TypedLobby.Default);
    }
    public override void PhotonNetwork.JoinRoom()
    {
        PhotonNetwork.JoinRoom(roomName);
    }
    public override void OnCreatedRoom()
    {
        Debug.Log("Criada a sala " + roomName);
        Debug.Log("Jogador " + PhotonNetwork.LocalPlayer.NickName + " entrou na sala " + roomName + " (" + PhotonNetwork.CurrentRoom.PlayerCount + ")");
    }


public override void OnDisconnected(Photon.Realtime.DisconnectCause cause)
    {
        Debug.Log("Desconectado!");
    }
    public override void OnPlayerEnteredRoom()
    {
        Debug.Log("Jogador N entrou na sala X (numero de jogadores na sala)"..);
    }
    public override void OnPlayerLeftRoom()
    {
        Debug.Log("Jogador N saiu da sala X (numero de jogadores na sala)"..);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
