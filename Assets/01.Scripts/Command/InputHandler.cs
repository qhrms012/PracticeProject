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
        // 키보드 입력 감지
        if (_attackKey != Key.None && Keyboard.current[_attackKey]?.wasPressedThisFrame == true)
        {
            _attackCommand?.Execute();
        }

        // 마우스 입력 감지
        if (IsMouseButtonPressedThisFrame(_attackMouseButton))
        {
            _attackCommand?.Execute();
        }
    }

    // 키보드 키 변경 메서드
    public void ChangeAttackKey(Key newKey)
    {
        _attackKey = newKey;
        _attackMouseButton = MouseButton.Left;
        Debug.Log($"공격 키(키보드)가 {newKey}로 변경되었습니다!");
    }

    // 마우스 버튼 변경 메서드
    public void ChangeAttackMouseButton(MouseButton newMouseButton)
    {
        _attackMouseButton = newMouseButton;
        _attackKey = Key.None;
        Debug.Log($"공격 키(마우스)가 {newMouseButton}로 변경되었습니다!");
    }

    // 마우스 버튼 상태 확인 메서드
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