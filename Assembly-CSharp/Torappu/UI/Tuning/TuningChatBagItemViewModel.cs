using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C86 RID: 15494
	[Token(Token = "0x2003C86")]
	public class TuningChatBagItemViewModel : IHotfixable
	{
		// Token: 0x06018334 RID: 99124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018334")]
		[Address(RVA = "0x10A51C0", Offset = "0x10A3DC0", VA = "0x1810A51C0")]
		public void LoadData(string actId, string product, TuningCommonCardModel model)
		{
		}

		// Token: 0x06018335 RID: 99125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018335")]
		[Address(RVA = "0x10A55B0", Offset = "0x10A41B0", VA = "0x1810A55B0")]
		public TuningChatBagItemViewModel()
		{
		}

		// Token: 0x0401D775 RID: 120693
		[Token(Token = "0x401D775")]
		[FieldOffset(Offset = "0x10")]
		public TuningCommonCardModel cardModel;

		// Token: 0x0401D776 RID: 120694
		[Token(Token = "0x401D776")]
		[FieldOffset(Offset = "0x18")]
		public string productId;

		// Token: 0x0401D777 RID: 120695
		[Token(Token = "0x401D777")]
		[FieldOffset(Offset = "0x20")]
		public bool isHidden;

		// Token: 0x0401D778 RID: 120696
		[Token(Token = "0x401D778")]
		[FieldOffset(Offset = "0x28")]
		public string titleDesc;

		// Token: 0x0401D779 RID: 120697
		[Token(Token = "0x401D779")]
		[FieldOffset(Offset = "0x30")]
		public string formColor;

		// Token: 0x0401D77A RID: 120698
		[Token(Token = "0x401D77A")]
		[FieldOffset(Offset = "0x38")]
		public string formDesc;

		// Token: 0x0401D77B RID: 120699
		[Token(Token = "0x401D77B")]
		[FieldOffset(Offset = "0x40")]
		public string orcheDesc;

		// Token: 0x0401D77C RID: 120700
		[Token(Token = "0x401D77C")]
		[FieldOffset(Offset = "0x48")]
		public string hiddenDesc;

		// Token: 0x0401D77D RID: 120701
		[Token(Token = "0x401D77D")]
		[FieldOffset(Offset = "0x50")]
		public string musicMainId;

		// Token: 0x0401D77E RID: 120702
		[Token(Token = "0x401D77E")]
		[FieldOffset(Offset = "0x58")]
		public string musicSubId;

		// Token: 0x0401D77F RID: 120703
		[Token(Token = "0x401D77F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D780 RID: 120704
		[Token(Token = "0x401D780")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
