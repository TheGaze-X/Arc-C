using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200291D RID: 10525
	[Token(Token = "0x200291D")]
	public class RoguelikeOutput : IHotfixable
	{
		// Token: 0x06011734 RID: 71476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011734")]
		[Address(RVA = "0x94D580", Offset = "0x94C180", VA = "0x18094D580")]
		public RoguelikeOutput()
		{
		}

		// Token: 0x040137E4 RID: 79844
		[Token(Token = "0x40137E4")]
		[FieldOffset(Offset = "0x10")]
		public string battleSnapshot;

		// Token: 0x040137E5 RID: 79845
		[Token(Token = "0x40137E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
