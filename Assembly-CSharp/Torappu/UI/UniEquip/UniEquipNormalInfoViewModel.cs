using System;
using Il2CppDummyDll;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C3A RID: 15418
	[Token(Token = "0x2003C3A")]
	public struct UniEquipNormalInfoViewModel : IHotfixable
	{
		// Token: 0x0401D47A RID: 119930
		[Token(Token = "0x401D47A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UniEquipNormalInfoViewModel EMPTY;

		// Token: 0x0401D47B RID: 119931
		[Token(Token = "0x401D47B")]
		[FieldOffset(Offset = "0x0")]
		public string title;

		// Token: 0x0401D47C RID: 119932
		[Token(Token = "0x401D47C")]
		[FieldOffset(Offset = "0x8")]
		public string content;

		// Token: 0x0401D47D RID: 119933
		[Token(Token = "0x401D47D")]
		[FieldOffset(Offset = "0x10")]
		public float contentHeight;
	}
}
