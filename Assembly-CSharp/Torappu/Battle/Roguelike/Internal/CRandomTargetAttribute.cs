using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002956 RID: 10582
	[Token(Token = "0x2002956")]
	public class CRandomTargetAttribute : BasicCharacterRelic
	{
		// Token: 0x06011893 RID: 71827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011893")]
		[Address(RVA = "0x950C50", Offset = "0x94F850", VA = "0x180950C50", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x06011894 RID: 71828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011894")]
		[Address(RVA = "0x950940", Offset = "0x94F540", VA = "0x180950940", Slot = "6")]
		protected override void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011895 RID: 71829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011895")]
		[Address(RVA = "0x94FA30", Offset = "0x94E630", VA = "0x18094FA30", Slot = "9")]
		protected virtual void DoApplyAttribute(AttributesData attributesData)
		{
		}

		// Token: 0x06011896 RID: 71830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011896")]
		[Address(RVA = "0x950550", Offset = "0x94F150", VA = "0x180950550")]
		protected void ApplyAttributeInternal(AttributesData attributes, int stackLayer = 1)
		{
		}

		// Token: 0x06011897 RID: 71831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011897")]
		[Address(RVA = "0x951010", Offset = "0x94FC10", VA = "0x180951010")]
		public CRandomTargetAttribute()
		{
		}

		// Token: 0x06011898 RID: 71832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011898")]
		[Address(RVA = "0x950440", Offset = "0x94F040", VA = "0x180950440")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06011899 RID: 71833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011899")]
		[Address(RVA = "0x94EA20", Offset = "0x94D620", VA = "0x18094EA20")]
		private void <>xLuaBaseProxy_DoPreProcess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x0401399F RID: 80287
		[Token(Token = "0x401399F")]
		protected const string EFFECT_DYNAMIC_ABILITY = "EmptyEffect";

		// Token: 0x040139A0 RID: 80288
		[Token(Token = "0x40139A0")]
		protected const string DYNAMIC_ABILITY_KEY = "DynamicAbility";

		// Token: 0x040139A1 RID: 80289
		[Token(Token = "0x40139A1")]
		[FieldOffset(Offset = "0x30")]
		protected List<BattleCharacterData> m_cachedCharacters;

		// Token: 0x040139A2 RID: 80290
		[Token(Token = "0x40139A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040139A3 RID: 80291
		[Token(Token = "0x40139A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x040139A4 RID: 80292
		[Token(Token = "0x40139A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoApplyAttribute;

		// Token: 0x040139A5 RID: 80293
		[Token(Token = "0x40139A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyAttributeInternal;

		// Token: 0x040139A6 RID: 80294
		[Token(Token = "0x40139A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
