using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C7E RID: 27774
	[Token(Token = "0x2006C7E")]
	public class TemplateActivityEntryMileStoneNewItemTrackModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x06027A2D RID: 162349 RVA: 0x000CEF28 File Offset: 0x000CD128
		// (set) Token: 0x06027A2E RID: 162350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DAC")]
		public bool isShow
		{
			[Token(Token = "0x6027A2D")]
			[Address(RVA = "0x22CCCB0", Offset = "0x22CB8B0", VA = "0x1822CCCB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6027A2E")]
			[Address(RVA = "0x22CCD10", Offset = "0x22CB910", VA = "0x1822CCD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027A2F RID: 162351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A2F")]
		[Address(RVA = "0x22CCB10", Offset = "0x22CB710", VA = "0x1822CCB10", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06027A30 RID: 162352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A30")]
		[Address(RVA = "0x22CCC50", Offset = "0x22CB850", VA = "0x1822CCC50")]
		public TemplateActivityEntryMileStoneNewItemTrackModel()
		{
		}

		// Token: 0x0403836E RID: 230254
		[Token(Token = "0x403836E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403836F RID: 230255
		[Token(Token = "0x403836F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04038370 RID: 230256
		[Token(Token = "0x4038370")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04038371 RID: 230257
		[Token(Token = "0x4038371")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C7F RID: 27775
		[Token(Token = "0x2006C7F")]
		public class Param
		{
			// Token: 0x06027A31 RID: 162353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A31")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04038372 RID: 230258
			[Token(Token = "0x4038372")]
			[FieldOffset(Offset = "0x10")]
			public TemplateActivityMilestoneGroupViewModel viewModel;
		}
	}
}
