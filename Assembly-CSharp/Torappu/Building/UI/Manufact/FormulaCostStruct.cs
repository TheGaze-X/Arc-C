using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D89 RID: 7561
	[Token(Token = "0x2001D89")]
	public struct FormulaCostStruct
	{
		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x00045C60 File Offset: 0x00043E60
		[Token(Token = "0x1700169D")]
		public bool isEmpty
		{
			[Token(Token = "0x600BA8B")]
			[Address(RVA = "0x334C4A0", Offset = "0x334B0A0", VA = "0x18334C4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B9C9 RID: 47561
		[Token(Token = "0x400B9C9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FormulaCostStruct EMPTY;

		// Token: 0x0400B9CA RID: 47562
		[Token(Token = "0x400B9CA")]
		[FieldOffset(Offset = "0x0")]
		public string itemId;

		// Token: 0x0400B9CB RID: 47563
		[Token(Token = "0x400B9CB")]
		[FieldOffset(Offset = "0x8")]
		public ItemType itemType;

		// Token: 0x0400B9CC RID: 47564
		[Token(Token = "0x400B9CC")]
		[FieldOffset(Offset = "0xC")]
		public int costCount;

		// Token: 0x0400B9CD RID: 47565
		[Token(Token = "0x400B9CD")]
		[FieldOffset(Offset = "0x10")]
		public int reserveCount;
	}
}
