using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A2C RID: 23084
	[Token(Token = "0x2005A2C")]
	public class UIPortraitChooseCharViewModel : IHotfixable
	{
		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x060219DC RID: 137692 RVA: 0x000BADF8 File Offset: 0x000B8FF8
		[Token(Token = "0x17004EEB")]
		public bool isComplete
		{
			[Token(Token = "0x60219DC")]
			[Address(RVA = "0x1C162A0", Offset = "0x1C14EA0", VA = "0x181C162A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060219DD RID: 137693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219DD")]
		[Address(RVA = "0x1C16190", Offset = "0x1C14D90", VA = "0x181C16190")]
		public UIPortraitChooseCharViewModel()
		{
		}

		// Token: 0x0402DF68 RID: 188264
		[Token(Token = "0x402DF68")]
		public const int ENTER_SEQUENCE_DEFAULT = 1;

		// Token: 0x0402DF69 RID: 188265
		[Token(Token = "0x402DF69")]
		[FieldOffset(Offset = "0x10")]
		public string titleText;

		// Token: 0x0402DF6A RID: 188266
		[Token(Token = "0x402DF6A")]
		[FieldOffset(Offset = "0x18")]
		public List<UIPortraitChooseCharCardViewModel> charCardList;

		// Token: 0x0402DF6B RID: 188267
		[Token(Token = "0x402DF6B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> selectCharIdList;

		// Token: 0x0402DF6C RID: 188268
		[Token(Token = "0x402DF6C")]
		[FieldOffset(Offset = "0x28")]
		public int selectCount;

		// Token: 0x0402DF6D RID: 188269
		[Token(Token = "0x402DF6D")]
		[FieldOffset(Offset = "0x2C")]
		public int enterSequence;

		// Token: 0x0402DF6E RID: 188270
		[Token(Token = "0x402DF6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x0402DF6F RID: 188271
		[Token(Token = "0x402DF6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
