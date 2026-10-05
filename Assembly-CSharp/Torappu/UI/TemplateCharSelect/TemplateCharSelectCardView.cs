using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BD4 RID: 23508
	[Token(Token = "0x2005BD4")]
	public abstract class TemplateCharSelectCardView : MonoBehaviour, IHotfixable, IAsyncShowEffect, IAsyncDataView<TemplateCharSelectCardView.AsyncParam>
	{
		// Token: 0x17004FCA RID: 20426
		// (set) Token: 0x0602216A RID: 139626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FCA")]
		public Action<int> onClick
		{
			[Token(Token = "0x602216A")]
			[Address(RVA = "0x1C9AA30", Offset = "0x1C99630", VA = "0x181C9AA30")]
			set
			{
			}
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x0602216B RID: 139627 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602216C RID: 139628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FCB")]
		private protected string actId
		{
			[Token(Token = "0x602216B")]
			[Address(RVA = "0x1C9A8F0", Offset = "0x1C994F0", VA = "0x181C9A8F0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602216C")]
			[Address(RVA = "0x1C9A9B0", Offset = "0x1C995B0", VA = "0x181C9A9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x0602216D RID: 139629 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602216E RID: 139630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FCC")]
		private protected string pageName
		{
			[Token(Token = "0x602216D")]
			[Address(RVA = "0x1C9A950", Offset = "0x1C99550", VA = "0x181C9A950")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602216E")]
			[Address(RVA = "0x1C9AAB0", Offset = "0x1C996B0", VA = "0x181C9AAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602216F RID: 139631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602216F")]
		[Address(RVA = "0x1C9A7B0", Offset = "0x1C993B0", VA = "0x181C9A7B0")]
		public void RenderViewModel(TemplateCharSelectCardViewModel viewModel)
		{
		}

		// Token: 0x06022170 RID: 139632
		[Token(Token = "0x6022170")]
		protected abstract void DoRender(TemplateCharSelectCardViewModel viewModel);

		// Token: 0x06022171 RID: 139633 RVA: 0x000BC568 File Offset: 0x000BA768
		[Token(Token = "0x6022171")]
		[Address(RVA = "0x1C9A750", Offset = "0x1C99350", VA = "0x181C9A750", Slot = "7")]
		protected virtual bool OnCheckClick()
		{
			return default(bool);
		}

		// Token: 0x06022172 RID: 139634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022172")]
		[Address(RVA = "0x1C9A6B0", Offset = "0x1C992B0", VA = "0x181C9A6B0")]
		public void EventOnCardClick()
		{
		}

		// Token: 0x06022173 RID: 139635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022173")]
		[Address(RVA = "0x1C9A2E0", Offset = "0x1C98EE0", VA = "0x181C9A2E0", Slot = "5")]
		public void AsyncSetData(TemplateCharSelectCardView.AsyncParam data)
		{
		}

		// Token: 0x06022174 RID: 139636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022174")]
		[Address(RVA = "0x1C9A5E0", Offset = "0x1C991E0", VA = "0x181C9A5E0", Slot = "4")]
		public void AsyncShow()
		{
		}

		// Token: 0x06022175 RID: 139637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022175")]
		[Address(RVA = "0x1C9A880", Offset = "0x1C99480", VA = "0x181C9A880")]
		protected TemplateCharSelectCardView()
		{
		}

		// Token: 0x0402EC24 RID: 191524
		[Token(Token = "0x402EC24")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402EC25 RID: 191525
		[Token(Token = "0x402EC25")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("AsyncLoad")]
		private float _fadeInDur;

		// Token: 0x0402EC26 RID: 191526
		[Token(Token = "0x402EC26")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Group("AsyncLoad")]
		private int _showAnimThreshold;

		// Token: 0x0402EC27 RID: 191527
		[Token(Token = "0x402EC27")]
		[FieldOffset(Offset = "0x28")]
		private Action<int> m_clickListener;

		// Token: 0x0402EC28 RID: 191528
		[Token(Token = "0x402EC28")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedInstId;

		// Token: 0x0402EC29 RID: 191529
		[Token(Token = "0x402EC29")]
		[FieldOffset(Offset = "0x34")]
		private int m_position;

		// Token: 0x0402EC2C RID: 191532
		[Token(Token = "0x402EC2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0402EC2D RID: 191533
		[Token(Token = "0x402EC2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0402EC2E RID: 191534
		[Token(Token = "0x402EC2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0402EC2F RID: 191535
		[Token(Token = "0x402EC2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0402EC30 RID: 191536
		[Token(Token = "0x402EC30")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_pageName;

		// Token: 0x0402EC31 RID: 191537
		[Token(Token = "0x402EC31")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0402EC32 RID: 191538
		[Token(Token = "0x402EC32")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCheckClick;

		// Token: 0x0402EC33 RID: 191539
		[Token(Token = "0x402EC33")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnCardClick;

		// Token: 0x0402EC34 RID: 191540
		[Token(Token = "0x402EC34")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0402EC35 RID: 191541
		[Token(Token = "0x402EC35")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x0402EC36 RID: 191542
		[Token(Token = "0x402EC36")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BD5 RID: 23509
		[Token(Token = "0x2005BD5")]
		public struct AsyncParam
		{
			// Token: 0x0402EC37 RID: 191543
			[Token(Token = "0x402EC37")]
			[FieldOffset(Offset = "0x0")]
			public int position;

			// Token: 0x0402EC38 RID: 191544
			[Token(Token = "0x402EC38")]
			[FieldOffset(Offset = "0x8")]
			public TemplateCharSelectCardView prefab;

			// Token: 0x0402EC39 RID: 191545
			[Token(Token = "0x402EC39")]
			[FieldOffset(Offset = "0x10")]
			public TemplateCharSelectCardViewModel viewModel;

			// Token: 0x0402EC3A RID: 191546
			[Token(Token = "0x402EC3A")]
			[FieldOffset(Offset = "0x18")]
			public TemplateCharSelectMode mode;

			// Token: 0x0402EC3B RID: 191547
			[Token(Token = "0x402EC3B")]
			[FieldOffset(Offset = "0x1C")]
			public bool isSelect;

			// Token: 0x0402EC3C RID: 191548
			[Token(Token = "0x402EC3C")]
			[FieldOffset(Offset = "0x20")]
			public int selectIndex;

			// Token: 0x0402EC3D RID: 191549
			[Token(Token = "0x402EC3D")]
			[FieldOffset(Offset = "0x28")]
			public UIIntEvent charClick;

			// Token: 0x0402EC3E RID: 191550
			[Token(Token = "0x402EC3E")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x0402EC3F RID: 191551
			[Token(Token = "0x402EC3F")]
			[FieldOffset(Offset = "0x38")]
			public string pageName;
		}
	}
}
