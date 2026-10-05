using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F77 RID: 28535
	[Token(Token = "0x2006F77")]
	public class ActMultiV3ManualTitleListModel : IHotfixable
	{
		// Token: 0x17005F77 RID: 24439
		// (get) Token: 0x0602881F RID: 165919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F77")]
		public string selectedTitleId
		{
			[Token(Token = "0x602881F")]
			[Address(RVA = "0x23C7D90", Offset = "0x23C6990", VA = "0x1823C7D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x06028820 RID: 165920 RVA: 0x000D1E80 File Offset: 0x000D0080
		[Token(Token = "0x17005F78")]
		public int pagerSelectedPage
		{
			[Token(Token = "0x6028820")]
			[Address(RVA = "0x23C7D30", Offset = "0x23C6930", VA = "0x1823C7D30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06028821 RID: 165921 RVA: 0x000D1E98 File Offset: 0x000D0098
		[Token(Token = "0x6028821")]
		[Address(RVA = "0x23C7B20", Offset = "0x23C6720", VA = "0x1823C7B20")]
		public int SwitchPagerIndex(int index)
		{
			return 0;
		}

		// Token: 0x06028822 RID: 165922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028822")]
		[Address(RVA = "0x23C7970", Offset = "0x23C6570", VA = "0x1823C7970")]
		public void LoadData(string selectedTitleId, bool isBack)
		{
		}

		// Token: 0x06028823 RID: 165923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028823")]
		[Address(RVA = "0x23C7BC0", Offset = "0x23C67C0", VA = "0x1823C7BC0")]
		public void UpdateSelection(int pageIdx)
		{
		}

		// Token: 0x06028824 RID: 165924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028824")]
		[Address(RVA = "0x23C7C80", Offset = "0x23C6880", VA = "0x1823C7C80")]
		public ActMultiV3ManualTitleListModel()
		{
		}

		// Token: 0x04039AAD RID: 236205
		[Token(Token = "0x4039AAD")]
		[FieldOffset(Offset = "0x10")]
		public int selectedItemIdx;

		// Token: 0x04039AAE RID: 236206
		[Token(Token = "0x4039AAE")]
		[FieldOffset(Offset = "0x18")]
		public List<ActMultiV3TitleViewModel> titleList;

		// Token: 0x04039AAF RID: 236207
		[Token(Token = "0x4039AAF")]
		[FieldOffset(Offset = "0x20")]
		public int loadSeqNum;

		// Token: 0x04039AB0 RID: 236208
		[Token(Token = "0x4039AB0")]
		[FieldOffset(Offset = "0x28")]
		public long dragContextID;

		// Token: 0x04039AB1 RID: 236209
		[Token(Token = "0x4039AB1")]
		[FieldOffset(Offset = "0x30")]
		public bool isBack;

		// Token: 0x04039AB2 RID: 236210
		[Token(Token = "0x4039AB2")]
		[FieldOffset(Offset = "0x31")]
		public bool isValid;

		// Token: 0x04039AB3 RID: 236211
		[Token(Token = "0x4039AB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTitleId;

		// Token: 0x04039AB4 RID: 236212
		[Token(Token = "0x4039AB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pagerSelectedPage;

		// Token: 0x04039AB5 RID: 236213
		[Token(Token = "0x4039AB5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SwitchPagerIndex;

		// Token: 0x04039AB6 RID: 236214
		[Token(Token = "0x4039AB6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039AB7 RID: 236215
		[Token(Token = "0x4039AB7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateSelection;

		// Token: 0x04039AB8 RID: 236216
		[Token(Token = "0x4039AB8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
