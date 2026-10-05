using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C87 RID: 15495
	[Token(Token = "0x2003C87")]
	public class TuningChatViewModel : IHotfixable
	{
		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x06018336 RID: 99126 RVA: 0x00099AB0 File Offset: 0x00097CB0
		// (set) Token: 0x06018337 RID: 99127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170039C6")]
		public bool showBag
		{
			[Token(Token = "0x6018336")]
			[Address(RVA = "0x10B1E20", Offset = "0x10B0A20", VA = "0x1810B1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018337")]
			[Address(RVA = "0x10B1E90", Offset = "0x10B0A90", VA = "0x1810B1E90")]
			set
			{
			}
		}

		// Token: 0x06018338 RID: 99128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018338")]
		[Address(RVA = "0x10B1050", Offset = "0x10AFC50", VA = "0x1810B1050")]
		public void LoadData(string actId, string investId)
		{
		}

		// Token: 0x06018339 RID: 99129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018339")]
		[Address(RVA = "0x10B1860", Offset = "0x10B0460", VA = "0x1810B1860")]
		public void UpdateHidden(string actId)
		{
		}

		// Token: 0x0601833A RID: 99130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601833A")]
		[Address(RVA = "0x10B0FC0", Offset = "0x10AFBC0", VA = "0x1810B0FC0")]
		public TuningChatItemViewModel GetSelectedViewModel()
		{
			return null;
		}

		// Token: 0x0601833B RID: 99131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601833B")]
		[Address(RVA = "0x10B0E70", Offset = "0x10AFA70", VA = "0x1810B0E70")]
		public TuningChatBagItemViewModel GetSelectedBagItemViewModel()
		{
			return null;
		}

		// Token: 0x0601833C RID: 99132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601833C")]
		[Address(RVA = "0x10B1D30", Offset = "0x10B0930", VA = "0x1810B1D30")]
		public TuningChatViewModel()
		{
		}

		// Token: 0x0401D781 RID: 120705
		[Token(Token = "0x401D781")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, TuningChatItemViewModel> invests;

		// Token: 0x0401D782 RID: 120706
		[Token(Token = "0x401D782")]
		[FieldOffset(Offset = "0x18")]
		public TuningProductBagViewModel bagViewModel;

		// Token: 0x0401D783 RID: 120707
		[Token(Token = "0x401D783")]
		[FieldOffset(Offset = "0x20")]
		public string selectedInvestId;

		// Token: 0x0401D784 RID: 120708
		[Token(Token = "0x401D784")]
		[FieldOffset(Offset = "0x28")]
		public int tryTimesMax;

		// Token: 0x0401D785 RID: 120709
		[Token(Token = "0x401D785")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x0401D786 RID: 120710
		[Token(Token = "0x401D786")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showBag;

		// Token: 0x0401D787 RID: 120711
		[Token(Token = "0x401D787")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showBag;

		// Token: 0x0401D788 RID: 120712
		[Token(Token = "0x401D788")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D789 RID: 120713
		[Token(Token = "0x401D789")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateHidden;

		// Token: 0x0401D78A RID: 120714
		[Token(Token = "0x401D78A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSelectedViewModel;

		// Token: 0x0401D78B RID: 120715
		[Token(Token = "0x401D78B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSelectedBagItemViewModel;

		// Token: 0x0401D78C RID: 120716
		[Token(Token = "0x401D78C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
