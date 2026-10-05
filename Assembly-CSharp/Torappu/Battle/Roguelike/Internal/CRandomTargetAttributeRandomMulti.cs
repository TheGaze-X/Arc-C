using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x0200295C RID: 10588
	[Token(Token = "0x200295C")]
	public class CRandomTargetAttributeRandomMulti : BasicCharacterRelic
	{
		// Token: 0x060118A6 RID: 71846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118A6")]
		[Address(RVA = "0x950080", Offset = "0x94EC80", VA = "0x180950080", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x060118A7 RID: 71847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118A7")]
		[Address(RVA = "0x94FFB0", Offset = "0x94EBB0", VA = "0x18094FFB0", Slot = "6")]
		protected override void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118A8 RID: 71848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118A8")]
		[Address(RVA = "0x94FF30", Offset = "0x94EB30", VA = "0x18094FF30", Slot = "9")]
		protected virtual void DoApplyAttribute(AttributesData attributesData)
		{
		}

		// Token: 0x060118A9 RID: 71849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118A9")]
		[Address(RVA = "0x94FB10", Offset = "0x94E710", VA = "0x18094FB10")]
		protected void ApplyAttributeInternal(AttributesData attributes, int stackLayer = 1)
		{
		}

		// Token: 0x060118AA RID: 71850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118AA")]
		[Address(RVA = "0x950450", Offset = "0x94F050", VA = "0x180950450")]
		public CRandomTargetAttributeRandomMulti()
		{
		}

		// Token: 0x060118AB RID: 71851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118AB")]
		[Address(RVA = "0x950440", Offset = "0x94F040", VA = "0x180950440")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x060118AC RID: 71852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118AC")]
		[Address(RVA = "0x94EA20", Offset = "0x94D620", VA = "0x18094EA20")]
		private void <>xLuaBaseProxy_DoPreProcess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139B5 RID: 80309
		[Token(Token = "0x40139B5")]
		private const string UPPER_BOUND_PREFIX = "upper_bound@";

		// Token: 0x040139B6 RID: 80310
		[Token(Token = "0x40139B6")]
		private const string LOWER_BOUND_PREFIX = "lower_bound@";

		// Token: 0x040139B7 RID: 80311
		[Token(Token = "0x40139B7")]
		[FieldOffset(Offset = "0x30")]
		private List<BattleCharacterData> m_cachedCharacters;

		// Token: 0x040139B8 RID: 80312
		[Token(Token = "0x40139B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040139B9 RID: 80313
		[Token(Token = "0x40139B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x040139BA RID: 80314
		[Token(Token = "0x40139BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoApplyAttribute;

		// Token: 0x040139BB RID: 80315
		[Token(Token = "0x40139BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyAttributeInternal;

		// Token: 0x040139BC RID: 80316
		[Token(Token = "0x40139BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
