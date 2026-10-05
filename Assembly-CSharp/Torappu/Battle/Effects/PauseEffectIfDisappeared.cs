using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003243 RID: 12867
	[Token(Token = "0x2003243")]
	public class PauseEffectIfDisappeared : Effect.Behaviour, IHotfixable
	{
		// Token: 0x06014696 RID: 83606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014696")]
		[Address(RVA = "0xCA7BF0", Offset = "0xCA67F0", VA = "0x180CA7BF0")]
		private void Update()
		{
		}

		// Token: 0x06014697 RID: 83607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014697")]
		[Address(RVA = "0xCA7D40", Offset = "0xCA6940", VA = "0x180CA7D40")]
		public PauseEffectIfDisappeared()
		{
		}

		// Token: 0x040181B0 RID: 98736
		[Token(Token = "0x40181B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181B1 RID: 98737
		[Token(Token = "0x40181B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
