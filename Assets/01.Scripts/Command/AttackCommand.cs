using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommand : ICommand
{
    private Player _player;

    public AttackCommand(Player player)
    {
        _player = player;
    }
    public void Execute()
    {
        _player.Attack();

    }
}
