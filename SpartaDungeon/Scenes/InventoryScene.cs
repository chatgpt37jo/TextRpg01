﻿using SpartaDungeon.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon.Scenes
{
    public class InventoryScene : BaseScene
    {
        #region 새로운 생성자 만들기 금지
        // 생성자에서는 현재 씬의 이름만 설정한다. 씬에 있는 멤버들의 초기화는 Awake나 Start에서 한다
        public InventoryScene(string name) : base(name) { }
        #endregion
        //
        public override void Awake()
        {
            // 인벤토리의 멤버 초기화
        }
        public override void Start()
        {
            // 인벤토리의 멤버 초기화
        }
        public override void Update()
        {
            // 화면출력
            // 입력받기
            // 화면전환
        }



    }
}
