using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053C3 RID: 21443
	[Token(Token = "0x20053C3")]
	public class RoguelikeRewardCapsuleStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601F8ED RID: 129261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8ED")]
		[Address(RVA = "0x19382D0", Offset = "0x1936ED0", VA = "0x1819382D0")]
		public RoguelikeRewardCapsuleStateBean()
		{
		}

		// Token: 0x0402A7CF RID: 174031
		[Token(Token = "0x402A7CF")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402A7D0 RID: 174032
		[Token(Token = "0x402A7D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
