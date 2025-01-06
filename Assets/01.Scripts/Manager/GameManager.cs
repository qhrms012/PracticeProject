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

        // �ʱ� ���� Ű ǥ��
        UpdateKeyText();
        // ��ư Ŭ�� ������ �߰�
        changeButton.onClick.AddListener(OnChangeButtonClicked);
    }
    // ���� Ű ������ Text�� ������Ʈ
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
    // ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    private void OnChangeButtonClicked()
    {
        text.text = "Press a key to change...";
        isWaitingForKey = true;
    }

    private void Update()
    {
        // Ű �Է� ��� ������ ��
        if (isWaitingForKey)
        {
            foreach (KeyControl key in Keyboard.current.allKeys)
            {
                if (key.wasPressedThisFrame)
                {
                    _inputHandler.ChangeAttackKey(key.keyCode);
                    text.text = $"Attack Key: {key.keyCode}";
                    isWaitingForKey = false;  // Ű ���� �� ���� �ʱ�ȭ
                    break;
                }
            }
            // ���콺 ����
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
