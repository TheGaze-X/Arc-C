using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	[Serializable]
	public class GachaResult
	{
		// Token: 0x060063BD RID: 25533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaResult()
		{
		}

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0x20")]
		public bool isNew;

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle[] itemGet;

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0x30")]
		public GachaResult.PotentialInfo potent;

		// Token: 0x02000754 RID: 1876
		[Token(Token = "0x2000754")]
		public class PotentialInfo
		{
			// Token: 0x060063BE RID: 25534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PotentialInfo()
			{
			}

			// Token: 0x04002FCB RID: 12235
			[Token(Token = "0x4002FCB")]
			[FieldOffset(Offset = "0x10")]
			public int delta;

			// Token: 0x04002FCC RID: 12236
			[Token(Token = "0x4002FCC")]
			[FieldOffset(Offset = "0x14")]
			public int now;
		}
	}
}
