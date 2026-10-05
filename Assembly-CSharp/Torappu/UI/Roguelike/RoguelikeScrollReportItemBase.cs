using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005384 RID: 21380
	[Token(Token = "0x2005384")]
	public abstract class RoguelikeScrollReportItemBase : IRoguelikeScrollReportDisplayItemModel, IHotfixable
	{
		// Token: 0x0601F837 RID: 129079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F837")]
		[Address(RVA = "0x1932F20", Offset = "0x1931B20", VA = "0x181932F20", Slot = "5")]
		public virtual EndingReportDisplayItem CreateDisplayItem(RoguelikeScrollReportEndingFrameViewModel frameViewModel)
		{
			return null;
		}

		// Token: 0x0601F838 RID: 129080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F838")]
		[Address(RVA = "0x1933260", Offset = "0x1931E60", VA = "0x181933260")]
		protected static string _StripRichTextStyles(string richTextInData)
		{
			return null;
		}

		// Token: 0x0601F839 RID: 129081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F839")]
		[Address(RVA = "0x1932F90", Offset = "0x1931B90", VA = "0x181932F90")]
		protected static string _ExportGacha(RoguelikeScrollReportEndingFrameViewModel.Recruit recruit, RoguelikeScrollReportEndingFrameViewModel frameViewModel)
		{
			return null;
		}

		// Token: 0x0601F83A RID: 129082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F83A")]
		[Address(RVA = "0x1933120", Offset = "0x1931D20", VA = "0x181933120")]
		protected static string _ExportUpgrade(RoguelikeScrollReportEndingFrameViewModel.Upgrade recruit, RoguelikeScrollReportEndingFrameViewModel frameViewModel)
		{
			return null;
		}

		// Token: 0x0601F83B RID: 129083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F83B")]
		[Address(RVA = "0x19332E0", Offset = "0x1931EE0", VA = "0x1819332E0")]
		protected RoguelikeScrollReportItemBase()
		{
		}

		// Token: 0x0402A684 RID: 173700
		[Token(Token = "0x402A684")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateDisplayItem;

		// Token: 0x0402A685 RID: 173701
		[Token(Token = "0x402A685")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__StripRichTextStyles;

		// Token: 0x0402A686 RID: 173702
		[Token(Token = "0x402A686")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExportGacha;

		// Token: 0x0402A687 RID: 173703
		[Token(Token = "0x402A687")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExportUpgrade;

		// Token: 0x0402A688 RID: 173704
		[Token(Token = "0x402A688")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
