using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C18 RID: 23576
	[Token(Token = "0x2005C18")]
	public class CommonCharSelectResHolder : MonoBehaviour, ITemplateCharSelectCustomization, IHotfixable
	{
		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x060222EC RID: 140012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005029")]
		public TemplateCharSelectCardView charCard
		{
			[Token(Token = "0x60222EC")]
			[Address(RVA = "0x1CAEE90", Offset = "0x1CADA90", VA = "0x181CAEE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x060222ED RID: 140013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700502A")]
		public TemplateCharSelectPoolView poolView
		{
			[Token(Token = "0x60222ED")]
			[Address(RVA = "0x1CAF010", Offset = "0x1CADC10", VA = "0x181CAF010", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x060222EE RID: 140014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700502B")]
		public TemplateCharSelectDetailView detailView
		{
			[Token(Token = "0x60222EE")]
			[Address(RVA = "0x1CAEEF0", Offset = "0x1CADAF0", VA = "0x181CAEEF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x060222EF RID: 140015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700502C")]
		public TemplateCharSelectShuffleView shuffleView
		{
			[Token(Token = "0x60222EF")]
			[Address(RVA = "0x1CAF070", Offset = "0x1CADC70", VA = "0x181CAF070", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x060222F0 RID: 140016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700502D")]
		public TemplateCharSelectEnsureView ensureView
		{
			[Token(Token = "0x60222F0")]
			[Address(RVA = "0x1CAEF50", Offset = "0x1CADB50", VA = "0x181CAEF50", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x060222F1 RID: 140017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700502E")]
		public TemplateCharSelectTopMenuView topMenuView
		{
			[Token(Token = "0x60222F1")]
			[Address(RVA = "0x1CAF0D0", Offset = "0x1CADCD0", VA = "0x181CAF0D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x060222F2 RID: 140018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700502F")]
		public IList<TemplateCharSelectSubViewBase> extraViews
		{
			[Token(Token = "0x60222F2")]
			[Address(RVA = "0x1CAEFB0", Offset = "0x1CADBB0", VA = "0x181CAEFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060222F3 RID: 140019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222F3")]
		[Address(RVA = "0x1CAEE30", Offset = "0x1CADA30", VA = "0x181CAEE30")]
		public CommonCharSelectResHolder()
		{
		}

		// Token: 0x0402EE1D RID: 192029
		[Token(Token = "0x402EE1D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateCharSelectCardView _charCard;

		// Token: 0x0402EE1E RID: 192030
		[Token(Token = "0x402EE1E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateCharSelectPoolView _poolView;

		// Token: 0x0402EE1F RID: 192031
		[Token(Token = "0x402EE1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TemplateCharSelectDetailView _detailView;

		// Token: 0x0402EE20 RID: 192032
		[Token(Token = "0x402EE20")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TemplateCharSelectShuffleView _shuffleView;

		// Token: 0x0402EE21 RID: 192033
		[Token(Token = "0x402EE21")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TemplateCharSelectEnsureView _ensureView;

		// Token: 0x0402EE22 RID: 192034
		[Token(Token = "0x402EE22")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TemplateCharSelectTopMenuView _topMenuView;

		// Token: 0x0402EE23 RID: 192035
		[Token(Token = "0x402EE23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charCard;

		// Token: 0x0402EE24 RID: 192036
		[Token(Token = "0x402EE24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_poolView;

		// Token: 0x0402EE25 RID: 192037
		[Token(Token = "0x402EE25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_detailView;

		// Token: 0x0402EE26 RID: 192038
		[Token(Token = "0x402EE26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_shuffleView;

		// Token: 0x0402EE27 RID: 192039
		[Token(Token = "0x402EE27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ensureView;

		// Token: 0x0402EE28 RID: 192040
		[Token(Token = "0x402EE28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_topMenuView;

		// Token: 0x0402EE29 RID: 192041
		[Token(Token = "0x402EE29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_extraViews;

		// Token: 0x0402EE2A RID: 192042
		[Token(Token = "0x402EE2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
