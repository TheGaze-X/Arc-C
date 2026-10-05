using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B68 RID: 11112
	[Token(Token = "0x2002B68")]
	public class SpRatioToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x06012A79 RID: 76409 RVA: 0x00072558 File Offset: 0x00070758
		[Token(Token = "0x1700290F")]
		public override float restoreDelay
		{
			[Token(Token = "0x6012A79")]
			[Address(RVA = "0xAA7030", Offset = "0xAA5C30", VA = "0x180AA7030", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06012A7A RID: 76410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A7A")]
		[Address(RVA = "0xAA6A80", Offset = "0xAA5680", VA = "0x180AA6A80", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A7B RID: 76411 RVA: 0x00072570 File Offset: 0x00070770
		[Token(Token = "0x6012A7B")]
		[Address(RVA = "0xAA6A20", Offset = "0xAA5620", VA = "0x180AA6A20", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A7C RID: 76412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A7C")]
		[Address(RVA = "0xAA6B60", Offset = "0xAA5760", VA = "0x180AA6B60", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A7D RID: 76413 RVA: 0x00072588 File Offset: 0x00070788
		[Token(Token = "0x6012A7D")]
		[Address(RVA = "0xAA6BE0", Offset = "0xAA57E0", VA = "0x180AA6BE0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A7E RID: 76414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A7E")]
		[Address(RVA = "0xAA6F80", Offset = "0xAA5B80", VA = "0x180AA6F80")]
		public SpRatioToggleChecker()
		{
		}

		// Token: 0x06012A7F RID: 76415 RVA: 0x000725A0 File Offset: 0x000707A0
		[Token(Token = "0x6012A7F")]
		[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660")]
		private float <>xLuaBaseProxy_get_restoreDelay()
		{
			return 0f;
		}

		// Token: 0x06012A80 RID: 76416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A80")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015167 RID: 86375
		[Token(Token = "0x4015167")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minSpRatio;

		// Token: 0x04015168 RID: 86376
		[Token(Token = "0x4015168")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxSpRatio;

		// Token: 0x04015169 RID: 86377
		[Token(Token = "0x4015169")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _restoreDelay;

		// Token: 0x0401516A RID: 86378
		[Token(Token = "0x401516A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _waitForAttackFinished;

		// Token: 0x0401516B RID: 86379
		[Token(Token = "0x401516B")]
		[FieldOffset(Offset = "0x30")]
		private float m_maxSpRatio;

		// Token: 0x0401516C RID: 86380
		[Token(Token = "0x401516C")]
		[FieldOffset(Offset = "0x34")]
		private float m_restoreDelay;

		// Token: 0x0401516D RID: 86381
		[Token(Token = "0x401516D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_restoreDelay;

		// Token: 0x0401516E RID: 86382
		[Token(Token = "0x401516E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401516F RID: 86383
		[Token(Token = "0x401516F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015170 RID: 86384
		[Token(Token = "0x4015170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015171 RID: 86385
		[Token(Token = "0x4015171")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015172 RID: 86386
		[Token(Token = "0x4015172")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
