using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C7C RID: 27772
	[Token(Token = "0x2006C7C")]
	public class TemplateActivityEntryMileStoneTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x06027A29 RID: 162345 RVA: 0x000CEF10 File Offset: 0x000CD110
		[Token(Token = "0x17005DAB")]
		public bool isShow
		{
			[Token(Token = "0x6027A29")]
			[Address(RVA = "0x22CCF10", Offset = "0x22CBB10", VA = "0x1822CCF10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027A2A RID: 162346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A2A")]
		[Address(RVA = "0x22CCD80", Offset = "0x22CB980", VA = "0x1822CCD80", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06027A2B RID: 162347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A2B")]
		[Address(RVA = "0x22CCEB0", Offset = "0x22CBAB0", VA = "0x1822CCEB0")]
		public TemplateActivityEntryMileStoneTrackPoint()
		{
		}

		// Token: 0x04038368 RID: 230248
		[Token(Token = "0x4038368")]
		[FieldOffset(Offset = "0x10")]
		private bool m_haveAvailFlag;

		// Token: 0x04038369 RID: 230249
		[Token(Token = "0x4038369")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403836A RID: 230250
		[Token(Token = "0x403836A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403836B RID: 230251
		[Token(Token = "0x403836B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C7D RID: 27773
		[Token(Token = "0x2006C7D")]
		public class Param
		{
			// Token: 0x06027A2C RID: 162348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A2C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403836C RID: 230252
			[Token(Token = "0x403836C")]
			[FieldOffset(Offset = "0x10")]
			public TemplateActivityMilestoneGroupViewModel viewModel;
		}
	}
}
