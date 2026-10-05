using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F4A RID: 16202
	[Token(Token = "0x2003F4A")]
	public struct SiracusaOperaCommentItemViewModel : IHotfixable, IComparable<SiracusaOperaCommentItemViewModel>
	{
		// Token: 0x06019274 RID: 103028 RVA: 0x0009D1B8 File Offset: 0x0009B3B8
		[Token(Token = "0x6019274")]
		[Address(RVA = "0x11D86A0", Offset = "0x11D72A0", VA = "0x1811D86A0", Slot = "4")]
		public int CompareTo(SiracusaOperaCommentItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0401F2CA RID: 127690
		[Token(Token = "0x401F2CA")]
		[FieldOffset(Offset = "0x0")]
		public string commentId;

		// Token: 0x0401F2CB RID: 127691
		[Token(Token = "0x401F2CB")]
		[FieldOffset(Offset = "0x8")]
		public string commentTitle;

		// Token: 0x0401F2CC RID: 127692
		[Token(Token = "0x401F2CC")]
		[FieldOffset(Offset = "0x10")]
		public string charCardId;

		// Token: 0x0401F2CD RID: 127693
		[Token(Token = "0x401F2CD")]
		[FieldOffset(Offset = "0x18")]
		public string charName;

		// Token: 0x0401F2CE RID: 127694
		[Token(Token = "0x401F2CE")]
		[FieldOffset(Offset = "0x20")]
		public int column;

		// Token: 0x0401F2CF RID: 127695
		[Token(Token = "0x401F2CF")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x0401F2D0 RID: 127696
		[Token(Token = "0x401F2D0")]
		[FieldOffset(Offset = "0x28")]
		public float cardHeight;

		// Token: 0x0401F2D1 RID: 127697
		[Token(Token = "0x401F2D1")]
		[FieldOffset(Offset = "0x2C")]
		public bool liked;

		// Token: 0x0401F2D2 RID: 127698
		[Token(Token = "0x401F2D2")]
		[FieldOffset(Offset = "0x2D")]
		public bool isCurrOperaLiked;

		// Token: 0x0401F2D3 RID: 127699
		[Token(Token = "0x401F2D3")]
		[FieldOffset(Offset = "0x30")]
		public string content;

		// Token: 0x0401F2D4 RID: 127700
		[Token(Token = "0x401F2D4")]
		[FieldOffset(Offset = "0x38")]
		public string score;

		// Token: 0x0401F2D5 RID: 127701
		[Token(Token = "0x401F2D5")]
		[FieldOffset(Offset = "0x40")]
		public Color charThemeColor;

		// Token: 0x0401F2D6 RID: 127702
		[Token(Token = "0x401F2D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
