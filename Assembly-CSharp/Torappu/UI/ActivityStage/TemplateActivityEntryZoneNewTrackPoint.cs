using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C88 RID: 27784
	[Token(Token = "0x2006C88")]
	public class TemplateActivityEntryZoneNewTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x06027A4A RID: 162378 RVA: 0x000CEF58 File Offset: 0x000CD158
		[Token(Token = "0x17005DAF")]
		public bool isShow
		{
			[Token(Token = "0x6027A4A")]
			[Address(RVA = "0x22DC790", Offset = "0x22DB390", VA = "0x1822DC790", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027A4B RID: 162379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A4B")]
		[Address(RVA = "0x22DC610", Offset = "0x22DB210", VA = "0x1822DC610", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06027A4C RID: 162380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A4C")]
		[Address(RVA = "0x22DC730", Offset = "0x22DB330", VA = "0x1822DC730")]
		public TemplateActivityEntryZoneNewTrackPoint()
		{
		}

		// Token: 0x040383AE RID: 230318
		[Token(Token = "0x40383AE")]
		[FieldOffset(Offset = "0x10")]
		private bool m_haveNewFlag;

		// Token: 0x040383AF RID: 230319
		[Token(Token = "0x40383AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040383B0 RID: 230320
		[Token(Token = "0x40383B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040383B1 RID: 230321
		[Token(Token = "0x40383B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C89 RID: 27785
		[Token(Token = "0x2006C89")]
		public class Param
		{
			// Token: 0x06027A4D RID: 162381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A4D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040383B2 RID: 230322
			[Token(Token = "0x40383B2")]
			[FieldOffset(Offset = "0x10")]
			public TemplateActivityZoneGroupViewModel.ZoneViewModel viewModel;
		}
	}
}
