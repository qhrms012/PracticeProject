using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.InputSystem.Controls;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    private InputHandler _inputHandler;
    public Button changeButton;
    public TextMeshProUGUI text;
    private bool isWaitingForKey = false;

    void Start()
    {
        Player player = new Player();
        ICommand attackCommand = new AttackCommand(player);

        _inputHandler = FindObjectOfType<InputHandler>();
        _inputHandler.SetAttackCommand(attackCommand);

        // 초기 공격 키 표시
        UpdateKeyText();
        // 버튼 클릭 리스너 추가
        changeButton.onClick.AddListener(OnChangeButtonClicked);
    }
    // 공격 키 정보를 Text로 업데이트
    private void UpdateKeyText()
    {
        Key attackKey = _inputHandler.GetAttackKey();
        MouseButton attackMouseButton = _inputHandler.GetAttackMouseButton();

        if (attackKey != Key.None)
        {
            text.text = $"Attack Key: {attackKey}";
        }
        else
        {
            text.text = $"Attack Key: {attackMouseButton}";
        }
    }
    // 버튼 클릭 시 호출되는 메서드
    private void OnChangeButtonClicked()
    {
        text.text = "Press a key to change...";
        isWaitingForKey = true;
    }

    private void Update()
    {
        // 키 입력 대기 상태일 때
        if (isWaitingForKey)
        {
            foreach (KeyControl key in Keyboard.current.allKeys)
            {
                if (key.wasPressedThisFrame)
                {
                    _inputHandler.ChangeAttackKey(key.keyCode);
                    text.text = $"Attack Key: {key.keyCode}";
                    isWaitingForKey = false;  // 키 변경 후 상태 초기화
                    break;
                }
            }
            // 마우스 감지
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                _inputHandler.ChangeAttackMouseButton(MouseButton.Left);
                text.text = "Attack Key: Left Mouse Button";
                isWaitingForKey = false;
            }
            else if (Mouse.current.rightButton.wasPressedThisFrame)
            {
                _inputHandler.ChangeAttackMouseButton(MouseButton.Right);
                text.text = "Attack Key: Right Mouse Button";
                isWaitingForKey = false;
            }
        }

    }
}
