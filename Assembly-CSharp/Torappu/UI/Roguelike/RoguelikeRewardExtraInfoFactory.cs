using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053C6 RID: 21446
	[Token(Token = "0x20053C6")]
	public class RoguelikeRewardExtraInfoFactory : IHotfixable
	{
		// Token: 0x0601F8F5 RID: 129269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8F5")]
		[Address(RVA = "0x193CE40", Offset = "0x193BA40", VA = "0x18193CE40", Slot = "4")]
		public virtual string CreateExtraInfo(RoguelikeSortItemViewStruct viewStruct)
		{
			return null;
		}

		// Token: 0x0601F8F6 RID: 129270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8F6")]
		[Address(RVA = "0x193D1B0", Offset = "0x193BDB0", VA = "0x18193D1B0")]
		public RoguelikeRewardExtraInfoFactory()
		{
		}

		// Token: 0x0402A7DA RID: 174042
		[Token(Token = "0x402A7DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateExtraInfo;

		// Token: 0x0402A7DB RID: 174043
		[Token(Token = "0x402A7DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
