using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B60 RID: 11104
	[Token(Token = "0x2002B60")]
	public class LifePointToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A42 RID: 76354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A42")]
		[Address(RVA = "0xAA1C80", Offset = "0xAA0880", VA = "0x180AA1C80", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A43 RID: 76355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A43")]
		[Address(RVA = "0xAA1D40", Offset = "0xAA0940", VA = "0x180AA1D40", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A44 RID: 76356 RVA: 0x00072378 File Offset: 0x00070578
		[Token(Token = "0x6012A44")]
		[Address(RVA = "0xAA1C20", Offset = "0xAA0820", VA = "0x180AA1C20", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x00072390 File Offset: 0x00070590
		[Token(Token = "0x6012A45")]
		[Address(RVA = "0xAA1DC0", Offset = "0xAA09C0", VA = "0x180AA1DC0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A46 RID: 76358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A46")]
		[Address(RVA = "0xAA1E70", Offset = "0xAA0A70", VA = "0x180AA1E70")]
		public LifePointToggleChecker()
		{
		}

		// Token: 0x06012A47 RID: 76359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A47")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015121 RID: 86305
		[Token(Token = "0x4015121")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _minLifePoint;

		// Token: 0x04015122 RID: 86306
		[Token(Token = "0x4015122")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _maxLifePoint;

		// Token: 0x04015123 RID: 86307
		[Token(Token = "0x4015123")]
		[FieldOffset(Offset = "0x28")]
		private int m_minLifePoint;

		// Token: 0x04015124 RID: 86308
		[Token(Token = "0x4015124")]
		[FieldOffset(Offset = "0x2C")]
		private int m_maxLifePoint;

		// Token: 0x04015125 RID: 86309
		[Token(Token = "0x4015125")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015126 RID: 86310
		[Token(Token = "0x4015126")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015127 RID: 86311
		[Token(Token = "0x4015127")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015128 RID: 86312
		[Token(Token = "0x4015128")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015129 RID: 86313
		[Token(Token = "0x4015129")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
