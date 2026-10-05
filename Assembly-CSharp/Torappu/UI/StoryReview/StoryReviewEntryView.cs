using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004910 RID: 18704
	[Token(Token = "0x2004910")]
	public class StoryReviewEntryView : DataBinder<StoryReviewProperty>
	{
		// Token: 0x0601C343 RID: 115523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C343")]
		[Address(RVA = "0x15B3D20", Offset = "0x15B2920", VA = "0x1815B3D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C344 RID: 115524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C344")]
		[Address(RVA = "0x15B3C50", Offset = "0x15B2850", VA = "0x1815B3C50", Slot = "7")]
		public override void OnValueChanged(StoryReviewProperty property)
		{
		}

		// Token: 0x0601C345 RID: 115525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C345")]
		[Address(RVA = "0x15B3D80", Offset = "0x15B2980", VA = "0x1815B3D80")]
		public StoryReviewEntryView()
		{
		}

		// Token: 0x04024DFE RID: 151038
		[Token(Token = "0x4024DFE")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x04024DFF RID: 151039
		[Token(Token = "0x4024DFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024E00 RID: 151040
		[Token(Token = "0x4024E00")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024E01 RID: 151041
		[Token(Token = "0x4024E01")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
