using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C0B RID: 11275
	[Token(Token = "0x2002C0B")]
	public class VigilWolfEffectEmitter : UberEffectEmitter
	{
		// Token: 0x060130BB RID: 78011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130BB")]
		[Address(RVA = "0xB2AFB0", Offset = "0xB29BB0", VA = "0x180B2AFB0", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x060130BC RID: 78012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130BC")]
		[Address(RVA = "0xB2AF10", Offset = "0xB29B10", VA = "0x180B2AF10", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060130BD RID: 78013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130BD")]
		[Address(RVA = "0xB2B0D0", Offset = "0xB29CD0", VA = "0x180B2B0D0")]
		public VigilWolfEffectEmitter()
		{
		}

		// Token: 0x060130BE RID: 78014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130BE")]
		[Address(RVA = "0xAE6DD0", Offset = "0xAE59D0", VA = "0x180AE6DD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x060130BF RID: 78015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130BF")]
		[Address(RVA = "0xAE6DC0", Offset = "0xAE59C0", VA = "0x180AE6DC0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0401581E RID: 88094
		[Token(Token = "0x401581E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VigilWolfEffectEmitter.VigilWolfCastEffectOptions[] _vigilWolfCastEffects;

		// Token: 0x0401581F RID: 88095
		[Token(Token = "0x401581F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04015820 RID: 88096
		[Token(Token = "0x4015820")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015821 RID: 88097
		[Token(Token = "0x4015821")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C0C RID: 11276
		[Token(Token = "0x2002C0C")]
		[Serializable]
		public class VigilWolfCastEffectOptions : UberEffectEmitter.CastEffectOptions
		{
			// Token: 0x060130C0 RID: 78016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130C0")]
			[Address(RVA = "0xB2AEC0", Offset = "0xB29AC0", VA = "0x180B2AEC0", Slot = "10")]
			protected override void PlayEffect()
			{
			}

			// Token: 0x060130C1 RID: 78017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130C1")]
			[Address(RVA = "0xB184F0", Offset = "0xB170F0", VA = "0x180B184F0")]
			public VigilWolfCastEffectOptions()
			{
			}

			// Token: 0x04015822 RID: 88098
			[Token(Token = "0x4015822")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private string _buffKey;
		}
	}
}
