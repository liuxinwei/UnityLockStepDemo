using System;
using UnityEngine;

//FlyDataGenerate类
//该类自动生成请勿修改，以避免不必要的损失
public class FlyDataGenerate : DataGenerateBase 
{
	public string m_key;
	public string m_ModelName;
	public HardPointEnum m_HitFXCreatPoint;
	public string m_HitEffect;
	public float m_Speed; //飞行速度
	public float m_Radius; //碰撞半径
	public float m_LiveTime; //存活时间
	public bool m_CollisionTrigger; //是否进行碰撞检测
	public string m_TriggerSkill; //碰撞后释放技能
	public bool m_AcrossEnemy; //穿透敌人
	public string m_HitSFX;

	public override void LoadData(string key) 
	{
		DataTable table =  DataManager.GetData("FlyData");

		if (!table.ContainsKey(key))
		{
			throw new Exception("FlyDataGenerate LoadData Exception Not Fond key ->" + key + "<-");
		}

		SingleData data = table[key];

		m_key = key;
		m_ModelName = data.GetString("ModelName");
		m_HitFXCreatPoint = data.GetEnum<HardPointEnum>("HitFXCreatPoint");
		m_HitEffect = data.GetString("HitEffect");
		m_Speed = data.GetFloat("Speed");
		m_Radius = data.GetFloat("Radius");
		m_LiveTime = data.GetFloat("LiveTime");
		m_CollisionTrigger = data.GetBool("CollisionTrigger");
		m_TriggerSkill = data.GetString("TriggerSkill");
		m_AcrossEnemy = data.GetBool("AcrossEnemy");
		m_HitSFX = data.GetString("HitSFX");
	}
}
