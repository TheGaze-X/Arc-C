using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007594 RID: 30100
	[Token(Token = "0x2007594")]
	public class Act24sideStageMeldingViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602A5E1 RID: 173537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5E1")]
		[Address(RVA = "0x26029A0", Offset = "0x26015A0", VA = "0x1826029A0")]
		public Act24sideStageMeldingViewModel(object param)
		{
		}

		// Token: 0x0602A5E2 RID: 173538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5E2")]
		[Address(RVA = "0x26024B0", Offset = "0x26010B0", VA = "0x1826024B0")]
		private void _ConstructorImpl(object param)
		{
		}

		// Token: 0x0602A5E3 RID: 173539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5E3")]
		[Address(RVA = "0x2602240", Offset = "0x2600E40", VA = "0x182602240")]
		public void RefreshData()
		{
		}

		// Token: 0x0403CF38 RID: 249656
		[Token(Token = "0x403CF38")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403CF39 RID: 249657
		[Token(Token = "0x403CF39")]
		[FieldOffset(Offset = "0x28")]
		public List<Act24sideMeldingSmallItemViewModel> meldingItemViewModels;

		// Token: 0x0403CF3A RID: 249658
		[Token(Token = "0x403CF3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403CF3B RID: 249659
		[Token(Token = "0x403CF3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ConstructorImpl;

		// Token: 0x0403CF3C RID: 249660
		[Token(Token = "0x403CF3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x02007595 RID: 30101
		[Token(Token = "0x2007595")]
		public class Input
		{
			// Token: 0x0602A5E4 RID: 173540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5E4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403CF3D RID: 249661
			[Token(Token = "0x403CF3D")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
