using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    //プレイヤーの入力がされたらStageを回転させる
    private InputAction _playerInput;

    //回転させたい対象のobject
    [SerializeField]
    private GameObject _stage;

    void Start()
    {
        　　　　　　//↓InputSystemのアクションマップから"Move"をという名前のアクションを探して取得する
        _playerInput = InputSystem.actions.FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {
        // _playerInputの値によってステージを回転させる
        Debug.Log(_playerInput.ReadValue<Vector2>());
        //Stageを回転させる処理
        //水平入力の取得
        float horizontalInput = _playerInput.ReadValue<Vector2>().x;
        //垂直入力の取得
        float verticalInput = _playerInput.ReadValue<Vector2>().y;
        //オブジェクトを回転させる
        _stage.transform.Rotate(horizontalInput*0.1f, 0f, verticalInput*0.1f);
    }
}
