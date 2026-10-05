using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005456 RID: 21590
	[Token(Token = "0x2005456")]
	public class RoguelikeSacrificeModelParam
	{
		// Token: 0x0601FC8A RID: 130186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC8A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSacrificeModelParam()
		{
		}

		// Token: 0x0402AD34 RID: 175412
		[Token(Token = "0x402AD34")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, IRoguelikeSacrifice> items;

		// Token: 0x0402AD35 RID: 175413
		[Token(Token = "0x402AD35")]
		[FieldOffset(Offset = "0x18")]
		public string defaultNameText;

		// Token: 0x0402AD36 RID: 175414
		[Token(Token = "0x402AD36")]
		[FieldOffset(Offset = "0x20")]
		public string defaultUsageText;

		// Token: 0x0402AD37 RID: 175415
		[Token(Token = "0x402AD37")]
		[FieldOffset(Offset = "0x28")]
		public string emptyTip;
	}
}
