
using System;
using System.Threading.Tasks;
using Fusion;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FusionSessionManager : MonoBehaviour
{
    [Header("Session Settings")]
    [SerializeField] private string sessionName = "HorrorPrototype";
    [SerializeField] private int maxPlayers = 4;

    private NetworkRunner runner;
    private bool isStarting;

    public async void StartHost()
    {
        if (isStarting || runner != null)
        {
            Debug.LogWarning("[Fusion] Session already starting or running.");
            return;
        }

        isStarting = true;

        try
        {
            runner = gameObject.AddComponent<NetworkRunner>();
            runner.ProvideInput = true;

            Debug.Log("[Fusion] Starting Host Mode session...");

            var result = await runner.StartGame(new StartGameArgs
            {
                GameMode = GameMode.Host,
                SessionName = sessionName,
                PlayerCount = maxPlayers,
                Scene = SceneRef.FromIndex(
                    SceneManager.GetActiveScene().buildIndex
                ),
                SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>()
            });

            if (result.Ok)
            {
                Debug.Log("[Fusion] Host session started successfully!");
            }
            else
            {
                Debug.LogError(
                    $"[Fusion] Host failed: {result.ShutdownReason}"
                );

                if (runner != null)
                {
                    Destroy(runner);
                    runner = null;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[Fusion] Exception: {ex}");

            if (runner != null)
            {
                Destroy(runner);
                runner = null;
            }
        }
        finally
        {
            isStarting = false;
        }
    }
}
