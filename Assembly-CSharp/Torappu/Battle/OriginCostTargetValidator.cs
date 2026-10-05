using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200258A RID: 9610
	[Token(Token = "0x200258A")]
	public class OriginCostTargetValidator : TargetValidator
	{
		// Token: 0x0600F7D0 RID: 63440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D0")]
		[Address(RVA = "0x7121E0", Offset = "0x710DE0", VA = "0x1807121E0", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7D1 RID: 63441 RVA: 0x0005CBF8 File Offset: 0x0005ADF8
		[Token(Token = "0x600F7D1")]
		[Address(RVA = "0x712350", Offset = "0x710F50", VA = "0x180712350", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7D2 RID: 63442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D2")]
		[Address(RVA = "0x712530", Offset = "0x711130", VA = "0x180712530")]
		public OriginCostTargetValidator()
		{
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D3")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x0005CC10 File Offset: 0x0005AE10
		[Token(Token = "0x600F7D4")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401135F RID: 70495
		[Token(Token = "0x401135F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _blackboardPrefix;

		// Token: 0x04011360 RID: 70496
		[Token(Token = "0x4011360")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x04011361 RID: 70497
		[Token(Token = "0x4011361")]
		[FieldOffset(Offset = "0x9C")]
		private int m_conditonCost;

		// Token: 0x04011362 RID: 70498
		[Token(Token = "0x4011362")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011363 RID: 70499
		[Token(Token = "0x4011363")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011364 RID: 70500
		[Token(Token = "0x4011364")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
