using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D78 RID: 19832
	[Token(Token = "0x2004D78")]
	public class NameCardSkinTmplChangeViewModel : IHotfixable
	{
		// Token: 0x0601DAF2 RID: 121586 RVA: 0x000AC3F8 File Offset: 0x000AA5F8
		[Token(Token = "0x601DAF2")]
		[Address(RVA = "0x1745130", Offset = "0x1743D30", VA = "0x181745130")]
		public bool TryLoadSkinTmplData(string skinId)
		{
			return default(bool);
		}

		// Token: 0x0601DAF3 RID: 121587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF3")]
		[Address(RVA = "0x1745420", Offset = "0x1744020", VA = "0x181745420")]
		private void _LoadCurSelectSkinTmpl(string skinId)
		{
		}

		// Token: 0x0601DAF4 RID: 121588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF4")]
		[Address(RVA = "0x1745510", Offset = "0x1744110", VA = "0x181745510")]
		public NameCardSkinTmplChangeViewModel()
		{
		}

		// Token: 0x04027378 RID: 160632
		[Token(Token = "0x4027378")]
		[FieldOffset(Offset = "0x10")]
		public List<NameCardSkinListItemViewModel> skinTmplItemModels;

		// Token: 0x04027379 RID: 160633
		[Token(Token = "0x4027379")]
		[FieldOffset(Offset = "0x18")]
		public int selectSkinTmpl;

		// Token: 0x0402737A RID: 160634
		[Token(Token = "0x402737A")]
		[FieldOffset(Offset = "0x20")]
		public string skinId;

		// Token: 0x0402737B RID: 160635
		[Token(Token = "0x402737B")]
		[FieldOffset(Offset = "0x28")]
		public string skinName;

		// Token: 0x0402737C RID: 160636
		[Token(Token = "0x402737C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryLoadSkinTmplData;

		// Token: 0x0402737D RID: 160637
		[Token(Token = "0x402737D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadCurSelectSkinTmpl;

		// Token: 0x0402737E RID: 160638
		[Token(Token = "0x402737E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
