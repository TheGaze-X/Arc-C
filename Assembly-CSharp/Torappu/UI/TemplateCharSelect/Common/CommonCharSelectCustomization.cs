using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C03 RID: 23555
	[Token(Token = "0x2005C03")]
	public struct CommonCharSelectCustomization : ITemplateCharSelectCustomization, IHotfixable
	{
		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x06022246 RID: 139846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FED")]
		public TemplateCharSelectCardView charCard
		{
			[Token(Token = "0x6022246")]
			[Address(RVA = "0x1C88440", Offset = "0x1C87040", VA = "0x181C88440", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x06022247 RID: 139847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FEE")]
		public TemplateCharSelectPoolView poolView
		{
			[Token(Token = "0x6022247")]
			[Address(RVA = "0x1C88620", Offset = "0x1C87220", VA = "0x181C88620", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x06022248 RID: 139848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FEF")]
		public TemplateCharSelectDetailView detailView
		{
			[Token(Token = "0x6022248")]
			[Address(RVA = "0x1C884E0", Offset = "0x1C870E0", VA = "0x181C884E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x06022249 RID: 139849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FF0")]
		public TemplateCharSelectShuffleView shuffleView
		{
			[Token(Token = "0x6022249")]
			[Address(RVA = "0x1C886C0", Offset = "0x1C872C0", VA = "0x181C886C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x0602224A RID: 139850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FF1")]
		public TemplateCharSelectEnsureView ensureView
		{
			[Token(Token = "0x602224A")]
			[Address(RVA = "0x1C88580", Offset = "0x1C87180", VA = "0x181C88580", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x0602224B RID: 139851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FF2")]
		public TemplateCharSelectTopMenuView topMenuView
		{
			[Token(Token = "0x602224B")]
			[Address(RVA = "0x1C88760", Offset = "0x1C87360", VA = "0x181C88760", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0402ECFB RID: 191739
		[Token(Token = "0x402ECFB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CommonCharSelectCustomization EMPTY;

		// Token: 0x0402ECFC RID: 191740
		[Token(Token = "0x402ECFC")]
		[FieldOffset(Offset = "0x0")]
		public TemplateCharSelectCardViewModelCreator cardCreator;

		// Token: 0x0402ECFD RID: 191741
		[Token(Token = "0x402ECFD")]
		[FieldOffset(Offset = "0x8")]
		public TemplateCharSelectCardView charCardPrefab;

		// Token: 0x0402ECFE RID: 191742
		[Token(Token = "0x402ECFE")]
		[FieldOffset(Offset = "0x10")]
		public TemplateCharSelectPoolView poolViewPrefab;

		// Token: 0x0402ECFF RID: 191743
		[Token(Token = "0x402ECFF")]
		[FieldOffset(Offset = "0x18")]
		public TemplateCharSelectDetailView detailViewPrefab;

		// Token: 0x0402ED00 RID: 191744
		[Token(Token = "0x402ED00")]
		[FieldOffset(Offset = "0x20")]
		public TemplateCharSelectShuffleView shuffleViewPrefab;

		// Token: 0x0402ED01 RID: 191745
		[Token(Token = "0x402ED01")]
		[FieldOffset(Offset = "0x28")]
		public TemplateCharSelectEnsureView ensureViewPrefab;

		// Token: 0x0402ED02 RID: 191746
		[Token(Token = "0x402ED02")]
		[FieldOffset(Offset = "0x30")]
		public TemplateCharSelectTopMenuView topMenuViewPrefab;

		// Token: 0x0402ED03 RID: 191747
		[Token(Token = "0x402ED03")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_charCard;

		// Token: 0x0402ED04 RID: 191748
		[Token(Token = "0x402ED04")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_poolView;

		// Token: 0x0402ED05 RID: 191749
		[Token(Token = "0x402ED05")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_detailView;

		// Token: 0x0402ED06 RID: 191750
		[Token(Token = "0x402ED06")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_shuffleView;

		// Token: 0x0402ED07 RID: 191751
		[Token(Token = "0x402ED07")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_ensureView;

		// Token: 0x0402ED08 RID: 191752
		[Token(Token = "0x402ED08")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_topMenuView;
	}
}
