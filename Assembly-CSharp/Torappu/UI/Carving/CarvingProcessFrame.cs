using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060B7 RID: 24759
	[Token(Token = "0x20060B7")]
	public class CarvingProcessFrame
	{
		// Token: 0x06023CC7 RID: 146631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarvingProcessFrame()
		{
		}

		// Token: 0x04031A2A RID: 203306
		[Token(Token = "0x4031A2A")]
		[FieldOffset(Offset = "0x10")]
		public string card;

		// Token: 0x04031A2B RID: 203307
		[Token(Token = "0x4031A2B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> product;

		// Token: 0x04031A2C RID: 203308
		[Token(Token = "0x4031A2C")]
		[FieldOffset(Offset = "0x20")]
		public int score;

		// Token: 0x04031A2D RID: 203309
		[Token(Token = "0x4031A2D")]
		[FieldOffset(Offset = "0x24")]
		public FrameType type;
	}
}
