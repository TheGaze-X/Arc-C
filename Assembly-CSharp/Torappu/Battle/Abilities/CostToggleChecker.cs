using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B59 RID: 11097
	[Token(Token = "0x2002B59")]
	public class CostToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A0F RID: 76303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A0F")]
		[Address(RVA = "0xA9F9E0", Offset = "0xA9E5E0", VA = "0x180A9F9E0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A10 RID: 76304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A10")]
		[Address(RVA = "0xA9FAA0", Offset = "0xA9E6A0", VA = "0x180A9FAA0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A11 RID: 76305 RVA: 0x000721C8 File Offset: 0x000703C8
		[Token(Token = "0x6012A11")]
		[Address(RVA = "0xA9F980", Offset = "0xA9E580", VA = "0x180A9F980", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A12 RID: 76306 RVA: 0x000721E0 File Offset: 0x000703E0
		[Token(Token = "0x6012A12")]
		[Address(RVA = "0xA9FB20", Offset = "0xA9E720", VA = "0x180A9FB20")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A13 RID: 76307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A13")]
		[Address(RVA = "0xA9FBF0", Offset = "0xA9E7F0", VA = "0x180A9FBF0")]
		public CostToggleChecker()
		{
		}

		// Token: 0x06012A14 RID: 76308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A14")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040150D6 RID: 86230
		[Token(Token = "0x40150D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _minCost;

		// Token: 0x040150D7 RID: 86231
		[Token(Token = "0x40150D7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _maxCost;

		// Token: 0x040150D8 RID: 86232
		[Token(Token = "0x40150D8")]
		[FieldOffset(Offset = "0x28")]
		private int m_minCost;

		// Token: 0x040150D9 RID: 86233
		[Token(Token = "0x40150D9")]
		[FieldOffset(Offset = "0x2C")]
		private int m_maxCost;

		// Token: 0x040150DA RID: 86234
		[Token(Token = "0x40150DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150DB RID: 86235
		[Token(Token = "0x40150DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040150DC RID: 86236
		[Token(Token = "0x40150DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150DD RID: 86237
		[Token(Token = "0x40150DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x040150DE RID: 86238
		[Token(Token = "0x40150DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
