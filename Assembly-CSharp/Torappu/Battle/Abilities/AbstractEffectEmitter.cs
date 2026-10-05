using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE9 RID: 11241
	[Token(Token = "0x2002BE9")]
	public abstract class AbstractEffectEmitter : AbilityStandard.Behaviour, IEffectSource
	{
		// Token: 0x06012FC0 RID: 77760
		[Token(Token = "0x6012FC0")]
		public abstract void GatherEffects(List<string> effects);

		// Token: 0x06012FC1 RID: 77761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC1")]
		[Address(RVA = "0xADAD10", Offset = "0xAD9910", VA = "0x180ADAD10")]
		protected AbstractEffectEmitter()
		{
		}

		// Token: 0x04015708 RID: 87816
		[Token(Token = "0x4015708")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
