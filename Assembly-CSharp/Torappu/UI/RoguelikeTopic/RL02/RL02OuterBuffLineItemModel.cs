using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200462A RID: 17962
	[Token(Token = "0x200462A")]
	public class RL02OuterBuffLineItemModel : IHotfixable
	{
		// Token: 0x0601B4AC RID: 111788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4AC")]
		[Address(RVA = "0x149D380", Offset = "0x149BF80", VA = "0x18149D380")]
		public RL02OuterBuffLineItemModel()
		{
		}

		// Token: 0x040233CC RID: 144332
		[Token(Token = "0x40233CC")]
		[FieldOffset(Offset = "0x10")]
		public string fromNode;

		// Token: 0x040233CD RID: 144333
		[Token(Token = "0x40233CD")]
		[FieldOffset(Offset = "0x18")]
		public string toNode;

		// Token: 0x040233CE RID: 144334
		[Token(Token = "0x40233CE")]
		[FieldOffset(Offset = "0x20")]
		public PolarPoint fromNodePos;

		// Token: 0x040233CF RID: 144335
		[Token(Token = "0x40233CF")]
		[FieldOffset(Offset = "0x28")]
		public PolarPoint toNodePos;

		// Token: 0x040233D0 RID: 144336
		[Token(Token = "0x40233D0")]
		[FieldOffset(Offset = "0x30")]
		public bool isUnlock;

		// Token: 0x040233D1 RID: 144337
		[Token(Token = "0x40233D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
