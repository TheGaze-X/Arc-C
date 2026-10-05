using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E3F RID: 3647
	[Token(Token = "0x2000E3F")]
	public class ActMultiV3SquadEffectData
	{
		// Token: 0x06006B0D RID: 27405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SquadEffectData()
		{
		}

		// Token: 0x04004BF0 RID: 19440
		[Token(Token = "0x4004BF0")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004BF1 RID: 19441
		[Token(Token = "0x4004BF1")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x04004BF2 RID: 19442
		[Token(Token = "0x4004BF2")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04004BF3 RID: 19443
		[Token(Token = "0x4004BF3")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04004BF4 RID: 19444
		[Token(Token = "0x4004BF4")]
		[FieldOffset(Offset = "0x30")]
		public string themeColor;

		// Token: 0x04004BF5 RID: 19445
		[Token(Token = "0x4004BF5")]
		[FieldOffset(Offset = "0x38")]
		public string buffDesc;

		// Token: 0x04004BF6 RID: 19446
		[Token(Token = "0x4004BF6")]
		[FieldOffset(Offset = "0x40")]
		public string debuffDesc;

		// Token: 0x04004BF7 RID: 19447
		[Token(Token = "0x4004BF7")]
		[FieldOffset(Offset = "0x48")]
		public ActMultiV3SquadEffectData.Token token;

		// Token: 0x04004BF8 RID: 19448
		[Token(Token = "0x4004BF8")]
		[FieldOffset(Offset = "0x50")]
		public RuneTable.PackedRuneData runeData;

		// Token: 0x04004BF9 RID: 19449
		[Token(Token = "0x4004BF9")]
		[FieldOffset(Offset = "0x58")]
		public bool isInitial;

		// Token: 0x02000E40 RID: 3648
		[Token(Token = "0x2000E40")]
		public class Token
		{
			// Token: 0x06006B0E RID: 27406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B0E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Token()
			{
			}

			// Token: 0x04004BFA RID: 19450
			[Token(Token = "0x4004BFA")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04004BFB RID: 19451
			[Token(Token = "0x4004BFB")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04004BFC RID: 19452
			[Token(Token = "0x4004BFC")]
			[FieldOffset(Offset = "0x20")]
			public string iconId;
		}
	}
}
