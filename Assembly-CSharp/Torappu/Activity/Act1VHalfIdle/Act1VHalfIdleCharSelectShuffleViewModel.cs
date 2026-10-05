using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007707 RID: 30471
	[Token(Token = "0x2007707")]
	public class Act1VHalfIdleCharSelectShuffleViewModel : CommonCharSelectShuffleDefaultViewModel
	{
		// Token: 0x0602ACF1 RID: 175345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF1")]
		[Address(RVA = "0x2699F50", Offset = "0x2698B50", VA = "0x182699F50", Slot = "7")]
		public override void OnReset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x0602ACF2 RID: 175346 RVA: 0x000DA208 File Offset: 0x000D8408
		[Token(Token = "0x602ACF2")]
		[Address(RVA = "0x269A0E0", Offset = "0x2698CE0", VA = "0x18269A0E0", Slot = "10")]
		protected override int OnSortChar(TemplateCharSelectCardViewModel a, TemplateCharSelectCardViewModel b)
		{
			return 0;
		}

		// Token: 0x0602ACF3 RID: 175347 RVA: 0x000DA220 File Offset: 0x000D8420
		[Token(Token = "0x602ACF3")]
		[Address(RVA = "0x2699E40", Offset = "0x2698A40", VA = "0x182699E40", Slot = "11")]
		protected override bool OnFilterChar(TemplateCharSelectCardViewModel charViewModel)
		{
			return default(bool);
		}

		// Token: 0x0602ACF4 RID: 175348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF4")]
		[Address(RVA = "0x269A470", Offset = "0x2699070", VA = "0x18269A470")]
		public Act1VHalfIdleCharSelectShuffleViewModel()
		{
		}

		// Token: 0x0602ACF5 RID: 175349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF5")]
		[Address(RVA = "0x269A430", Offset = "0x2699030", VA = "0x18269A430")]
		private void <>xLuaBaseProxy_OnReset(TemplateCharSelectModelResetData P0)
		{
		}

		// Token: 0x0602ACF6 RID: 175350 RVA: 0x000DA238 File Offset: 0x000D8438
		[Token(Token = "0x602ACF6")]
		[Address(RVA = "0x269A460", Offset = "0x2699060", VA = "0x18269A460")]
		private int <>xLuaBaseProxy_OnSortChar(TemplateCharSelectCardViewModel P0, TemplateCharSelectCardViewModel P1)
		{
			return 0;
		}

		// Token: 0x0403DB0B RID: 252683
		[Token(Token = "0x403DB0B")]
		[FieldOffset(Offset = "0x28")]
		public bool isNeedUpdateTopBar;

		// Token: 0x0403DB0C RID: 252684
		[Token(Token = "0x403DB0C")]
		[FieldOffset(Offset = "0x29")]
		public bool alwaysShowSelectedCharOnTop;

		// Token: 0x0403DB0D RID: 252685
		[Token(Token = "0x403DB0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0403DB0E RID: 252686
		[Token(Token = "0x403DB0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSortChar;

		// Token: 0x0403DB0F RID: 252687
		[Token(Token = "0x403DB0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFilterChar;

		// Token: 0x0403DB10 RID: 252688
		[Token(Token = "0x403DB10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
