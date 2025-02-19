﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public struct SkillData
    {
        public int Id { get; set; }   // 스킬의 번호(1~2)
        public string Name { get; set; }
        public eClassType ClassType { get; set; }    // 배울 수 있는 직업
        public eSkillType SkillType { get; set; }
        public int Level { get; set; }  // 퀘스트 배우는 레벨
        public string Description { get; set; } // 설명
        public int Count { get; set; }  // 스킬 1번이 하는 행위의 횟수
        public float Attack { get; set; }  // 공격력 올려주는 스킬, 공격 스킬에 사용
        public float Defence { get; set; }  // 방어력 올려준다
        public float Hp { get; set; }   // 체력회복
        public float Mp { get; set; }   // 마나 소모량
    }

    public enum eSkillType
    {
        ATTACK,
        HEAL,
        BUFF,
        ALL
    }

    // 스킬이 가지고 있을 것은 스킬의 자료형밖에 없다
    // 스킬을 사용하는 메서드는 플레이어 또는 스킬매니저에 구현한다
    public class Skill
    {
        public SkillData skillData;
        // 구현 시도해볼 스킬
        // 공격
        // 공격력 상승
        // 방어력 상승
        // 체력 회복

        // 기본 생성자
        public Skill()
        {
            skillData.Id = 0;
            skillData.Name = "";
            skillData.ClassType = eClassType.NONE;
            skillData.SkillType = eSkillType.ALL;
            skillData.Level = 0;
            skillData.Description = "";
            skillData.Count = 0;
            skillData.Attack = 0f;
            skillData.Defence = 0f;
            skillData.Hp = 0f;
            skillData.Mp = 0f;
        }

        public Skill(int i, string n, eClassType t, eSkillType st, int l, string des, int c, float a, float d, float h, float m)
        {
            skillData.Id = i;
            skillData.Name = n;
            skillData.ClassType = t;
            skillData.SkillType = st;
            skillData.Level = l;
            skillData.Description = des;
            skillData.Count = c;
            skillData.Attack = a;
            skillData.Defence = d;
            skillData.Hp = h;
            skillData.Mp = m;
        }
    }
}
