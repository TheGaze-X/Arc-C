using System;
using Il2CppDummyDll;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C3B RID: 15419
	[Token(Token = "0x2003C3B")]
	public struct UniEquipSubProfessionViewModel : IHotfixable
	{
		// Token: 0x0401D47E RID: 119934
		[Token(Token = "0x401D47E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UniEquipSubProfessionViewModel EMPTY;

		// Token: 0x0401D47F RID: 119935
		[Token(Token = "0x401D47F")]
		[FieldOffset(Offset = "0x0")]
		public string title;

		// Token: 0x0401D480 RID: 119936
		[Token(Token = "0x401D480")]
		[FieldOffset(Offset = "0x8")]
		public string content;

		// Token: 0x0401D481 RID: 119937
		[Token(Token = "0x401D481")]
		[FieldOffset(Offset = "0x10")]
		public float contentHeight;

		// Token: 0x0401D482 RID: 119938
		[Token(Token = "0x401D482")]
		[FieldOffset(Offset = "0x18")]
		public AttackRangeDescModel rangeModelOld;

		// Token: 0x0401D483 RID: 119939
		[Token(Token = "0x401D483")]
		[FieldOffset(Offset = "0x28")]
		public AttackRangeDescModel rangeModelNew;
	}
}
