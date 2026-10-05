using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062E6 RID: 25318
	[Token(Token = "0x20062E6")]
	public struct AutoChessPlayerInfo
	{
		// Token: 0x04032D84 RID: 208260
		[Token(Token = "0x4032D84")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04032D85 RID: 208261
		[Token(Token = "0x4032D85")]
		[FieldOffset(Offset = "0x8")]
		public string nameCode;

		// Token: 0x04032D86 RID: 208262
		[Token(Token = "0x4032D86")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x04032D87 RID: 208263
		[Token(Token = "0x4032D87")]
		[FieldOffset(Offset = "0x18")]
		public string noteName;

		// Token: 0x04032D88 RID: 208264
		[Token(Token = "0x4032D88")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04032D89 RID: 208265
		[Token(Token = "0x4032D89")]
		[FieldOffset(Offset = "0x38")]
		public string nameCardId;

		// Token: 0x04032D8A RID: 208266
		[Token(Token = "0x4032D8A")]
		[FieldOffset(Offset = "0x40")]
		public int nameCardTmpl;

		// Token: 0x04032D8B RID: 208267
		[Token(Token = "0x4032D8B")]
		[FieldOffset(Offset = "0x48")]
		public string medalIconId;
	}
}
