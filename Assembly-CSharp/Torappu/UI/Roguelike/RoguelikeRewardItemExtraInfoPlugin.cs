using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053C5 RID: 21445
	[Token(Token = "0x20053C5")]
	public class RoguelikeRewardItemExtraInfoPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F8F3 RID: 129267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8F3")]
		[Address(RVA = "0x193DDF0", Offset = "0x193C9F0", VA = "0x18193DDF0", Slot = "4")]
		public virtual RoguelikeRewardExtraInfoFactory GetExtraInfoFactory()
		{
			return null;
		}

		// Token: 0x0601F8F4 RID: 129268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8F4")]
		[Address(RVA = "0x193DEC0", Offset = "0x193CAC0", VA = "0x18193DEC0")]
		public RoguelikeRewardItemExtraInfoPlugin()
		{
		}

		// Token: 0x0402A7D8 RID: 174040
		[Token(Token = "0x402A7D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExtraInfoFactory;

		// Token: 0x0402A7D9 RID: 174041
		[Token(Token = "0x402A7D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
