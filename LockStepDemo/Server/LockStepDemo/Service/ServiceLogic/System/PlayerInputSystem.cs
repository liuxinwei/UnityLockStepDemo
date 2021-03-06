﻿using System;
using System.Collections.Generic;


public class PlayerInputSystem<T> : ServiceSystem where T : PlayerCommandBase, new()
{
    public override Type[] GetFilter()
    {
        return new Type[] {
                typeof(T),
                typeof(ConnectionComponent),
            };
    }

    public override void NoRecalcBeforeFixedUpdate(int deltaTime)
    {
        List<EntityBase> list = GetEntityList();

        for (int i = 0; i < list.Count; i++)
        {
            ConnectionComponent comp = list[i].GetComp<ConnectionComponent>();

            T cmd = (T)comp.GetCommand(m_world.FrameCount);
            cmd.id = list[i].ID;
            cmd.frame = m_world.FrameCount;

            list[i].ChangeComp(cmd);
        }
    }
}
