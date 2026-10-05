using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F76 RID: 28534
	[Token(Token = "0x2006F76")]
	public class ActMultiV3ManualTitleSelectViewModel : IHotfixable
	{
		// Token: 0x0602881B RID: 165915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602881B")]
		[Address(RVA = "0x23C9130", Offset = "0x23C7D30", VA = "0x1823C9130")]
		public void InitData(string actId)
		{
		}

		// Token: 0x0602881C RID: 165916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602881C")]
		[Address(RVA = "0x23C9680", Offset = "0x23C8280", VA = "0x1823C9680")]
		public void UpdateSelection(bool isBack, int pageIdx)
		{
		}

		// Token: 0x0602881D RID: 165917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602881D")]
		[Address(RVA = "0x23C95C0", Offset = "0x23C81C0", VA = "0x1823C95C0")]
		public void UpdatePage(bool isBack, int pageIdx)
		{
		}

		// Token: 0x0602881E RID: 165918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602881E")]
		[Address(RVA = "0x23C97E0", Offset = "0x23C83E0", VA = "0x1823C97E0")]
		public ActMultiV3ManualTitleSelectViewModel()
		{
		}

		// Token: 0x04039AA3 RID: 236195
		[Token(Token = "0x4039AA3")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039AA4 RID: 236196
		[Token(Token = "0x4039AA4")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3ManualTitleListModel prefixModel;

		// Token: 0x04039AA5 RID: 236197
		[Token(Token = "0x4039AA5")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3ManualTitleListModel suffixModel;

		// Token: 0x04039AA6 RID: 236198
		[Token(Token = "0x4039AA6")]
		[FieldOffset(Offset = "0x28")]
		public int initSeqNum;

		// Token: 0x04039AA7 RID: 236199
		[Token(Token = "0x4039AA7")]
		[FieldOffset(Offset = "0x2C")]
		public bool isItemValid;

		// Token: 0x04039AA8 RID: 236200
		[Token(Token = "0x4039AA8")]
		[FieldOffset(Offset = "0x2D")]
		public bool isScrolling;

		// Token: 0x04039AA9 RID: 236201
		[Token(Token = "0x4039AA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04039AAA RID: 236202
		[Token(Token = "0x4039AAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateSelection;

		// Token: 0x04039AAB RID: 236203
		[Token(Token = "0x4039AAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdatePage;

		// Token: 0x04039AAC RID: 236204
		[Token(Token = "0x4039AAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
