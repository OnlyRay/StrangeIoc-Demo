using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCommand : Command {
    //开始命令
    //当命令被执行的时候，默认调用execute方法
    public override void Execute()
    {
        Debug.Log("start command execute");
    }

}
