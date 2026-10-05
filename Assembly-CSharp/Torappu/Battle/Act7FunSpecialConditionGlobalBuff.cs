using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002276 RID: 8822
	[Token(Token = "0x2002276")]
	public class Act7FunSpecialConditionGlobalBuff : GlobalBuff
	{
		// Token: 0x0600DDE3 RID: 56803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE3")]
		[Address(RVA = "0x362B6B0", Offset = "0x362A2B0", VA = "0x18362B6B0", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDE4 RID: 56804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE4")]
		[Address(RVA = "0x362B8F0", Offset = "0x362A4F0", VA = "0x18362B8F0")]
		private void _CheckCondition(object obj)
		{
		}

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE5")]
		[Address(RVA = "0x362BCC0", Offset = "0x362A8C0", VA = "0x18362BCC0")]
		public Act7FunSpecialConditionGlobalBuff()
		{
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE6")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0400F09A RID: 61594
		[Token(Token = "0x400F09A")]
		private const string DEFAULT_COND_TYPE = "GE";

		// Token: 0x0400F09B RID: 61595
		[Token(Token = "0x400F09B")]
		private const string DEFAULT_LOG_FORMAT = "NONE,{0}";

		// Token: 0x0400F09C RID: 61596
		[Token(Token = "0x400F09C")]
		private const string SIMPLE_LOG_FORMAT = "SIMPLE,ACT7FUN_EGG,{0}";

		// Token: 0x0400F09D RID: 61597
		[Token(Token = "0x400F09D")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private string _easterId;

		// Token: 0x0400F09E RID: 61598
		[Token(Token = "0x400F09E")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _conditionKey;

		// Token: 0x0400F09F RID: 61599
		[Token(Token = "0x400F09F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private int _condValue;

		// Token: 0x0400F0A0 RID: 61600
		[Token(Token = "0x400F0A0")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private bool _checkWin;

		// Token: 0x0400F0A1 RID: 61601
		[Token(Token = "0x400F0A1")]
		[FieldOffset(Offset = "0x15D")]
		[SerializeField]
		private bool _checkPerfectWin;

		// Token: 0x0400F0A2 RID: 61602
		[Token(Token = "0x400F0A2")]
		[FieldOffset(Offset = "0x15E")]
		[SerializeField]
		private bool _checkRestCost;

		// Token: 0x0400F0A3 RID: 61603
		[Token(Token = "0x400F0A3")]
		[FieldOffset(Offset = "0x160")]
		private CompareType m_condType;

		// Token: 0x0400F0A4 RID: 61604
		[Token(Token = "0x400F0A4")]
		[FieldOffset(Offset = "0x164")]
		private int m_condValue;

		// Token: 0x0400F0A5 RID: 61605
		[Token(Token = "0x400F0A5")]
		[FieldOffset(Offset = "0x168")]
		private int m_costValue;

		// Token: 0x0400F0A6 RID: 61606
		[Token(Token = "0x400F0A6")]
		[FieldOffset(Offset = "0x170")]
		private string m_easterId;

		// Token: 0x0400F0A7 RID: 61607
		[Token(Token = "0x400F0A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F0A8 RID: 61608
		[Token(Token = "0x400F0A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x0400F0A9 RID: 61609
		[Token(Token = "0x400F0A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
