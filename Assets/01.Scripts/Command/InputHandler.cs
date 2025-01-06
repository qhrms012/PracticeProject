using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private ICommand _attackCommand;
    private Key _attackKey = Key.None;
    private MouseButton _attackMouseButton = MouseButton.Left;

    public void SetAttackCommand(ICommand command)
    {
        _attackCommand = command;
    }
    public Key GetAttackKey()
    {
        return _attackKey;
    }

    public MouseButton GetAttackMouseButton()
    {
        return _attackMouseButton;
    }

    void Update()
    {
        // Ű���� �Է� ����
        if (_attackKey != Key.None && Keyboard.current[_attackKey]?.wasPressedThisFrame == true)
        {
            _attackCommand?.Execute();
        }

        // ���콺 �Է� ����
        if (IsMouseButtonPressedThisFrame(_attackMouseButton))
        {
            _attackCommand?.Execute();
        }
    }

    // Ű���� Ű ���� �޼���
    public void ChangeAttackKey(Key newKey)
    {
        _attackKey = newKey;
        _attackMouseButton = MouseButton.Left;
        Debug.Log($"���� Ű(Ű����)�� {newKey}�� ����Ǿ����ϴ�!");
    }

    // ���콺 ��ư ���� �޼���
    public void ChangeAttackMouseButton(MouseButton newMouseButton)
    {
        _attackMouseButton = newMouseButton;
        _attackKey = Key.None;
        Debug.Log($"���� Ű(���콺)�� {newMouseButton}�� ����Ǿ����ϴ�!");
    }

    // ���콺 ��ư ���� Ȯ�� �޼���
    private bool IsMouseButtonPressedThisFrame(MouseButton button)
    {
        switch (button)
        {
            case MouseButton.Left:
                return Mouse.current.leftButton.wasPressedThisFrame;
            case MouseButton.Right:
                return Mouse.current.rightButton.wasPressedThisFrame;
            case MouseButton.Middle:
                return Mouse.current.middleButton.wasPressedThisFrame;
            default:
                return false;
        }
    }
}