using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004302 RID: 17154
	[Token(Token = "0x2004302")]
	public class SandboxV2GainItemDialog : UICustomDialog<SandboxV2GainItemDialog.Options>, IHotfixable
	{
		// Token: 0x0601A5B5 RID: 107957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5B5")]
		[Address(RVA = "0x134AA00", Offset = "0x1349600", VA = "0x18134AA00", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601A5B6 RID: 107958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5B6")]
		[Address(RVA = "0x134AB40", Offset = "0x1349740", VA = "0x18134AB40", Slot = "7")]
		protected override void OnRender(SandboxV2GainItemDialog.Options options)
		{
		}

		// Token: 0x0601A5B7 RID: 107959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5B7")]
		[Address(RVA = "0x134A940", Offset = "0x1349540", VA = "0x18134A940", Slot = "12")]
		protected override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601A5B8 RID: 107960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5B8")]
		[Address(RVA = "0x134AA60", Offset = "0x1349660", VA = "0x18134AA60")]
		public void OnClick()
		{
		}

		// Token: 0x0601A5B9 RID: 107961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5B9")]
		[Address(RVA = "0x134AE90", Offset = "0x1349A90", VA = "0x18134AE90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A5BA RID: 107962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5BA")]
		[Address(RVA = "0x134AFB0", Offset = "0x1349BB0", VA = "0x18134AFB0")]
		private void _OnItemCardClick(int index)
		{
		}

		// Token: 0x0601A5BB RID: 107963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5BB")]
		[Address(RVA = "0x134B0F0", Offset = "0x1349CF0", VA = "0x18134B0F0")]
		public SandboxV2GainItemDialog()
		{
		}

		// Token: 0x04021760 RID: 137056
		[Token(Token = "0x4021760")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x04021761 RID: 137057
		[Token(Token = "0x4021761")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _bactRt;

		// Token: 0x04021762 RID: 137058
		[Token(Token = "0x4021762")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRenderTextureImage _blurFloat;

		// Token: 0x04021763 RID: 137059
		[Token(Token = "0x4021763")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2GainItemView m_gainItemView;

		// Token: 0x04021764 RID: 137060
		[Token(Token = "0x4021764")]
		[FieldOffset(Offset = "0x70")]
		private IList<UIItemViewModel> m_cachedItemModels;

		// Token: 0x04021765 RID: 137061
		[Token(Token = "0x4021765")]
		[FieldOffset(Offset = "0x78")]
		private bool m_showItemDetail;

		// Token: 0x04021766 RID: 137062
		[Token(Token = "0x4021766")]
		[FieldOffset(Offset = "0x80")]
		private Action m_cachedCallback;

		// Token: 0x04021767 RID: 137063
		[Token(Token = "0x4021767")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04021768 RID: 137064
		[Token(Token = "0x4021768")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04021769 RID: 137065
		[Token(Token = "0x4021769")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402176A RID: 137066
		[Token(Token = "0x402176A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0402176B RID: 137067
		[Token(Token = "0x402176B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402176C RID: 137068
		[Token(Token = "0x402176C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402176D RID: 137069
		[Token(Token = "0x402176D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x0402176E RID: 137070
		[Token(Token = "0x402176E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004303 RID: 17155
		[Token(Token = "0x2004303")]
		public struct Options : IHotfixable
		{
			// Token: 0x17003E8A RID: 16010
			// (get) Token: 0x0601A5BC RID: 107964 RVA: 0x000A18E0 File Offset: 0x0009FAE0
			[Token(Token = "0x17003E8A")]
			public static SandboxV2GainItemDialog.Options DEFAULT
			{
				[Token(Token = "0x601A5BC")]
				[Address(RVA = "0x1340180", Offset = "0x133ED80", VA = "0x181340180")]
				get
				{
					return default(SandboxV2GainItemDialog.Options);
				}
			}

			// Token: 0x0402176F RID: 137071
			[Token(Token = "0x402176F")]
			[FieldOffset(Offset = "0x0")]
			public bool showItemDetail;

			// Token: 0x04021770 RID: 137072
			[Token(Token = "0x4021770")]
			[FieldOffset(Offset = "0x8")]
			public Action callback;

			// Token: 0x04021771 RID: 137073
			[Token(Token = "0x4021771")]
			[FieldOffset(Offset = "0x10")]
			public IList<UIItemViewModel> itemModels;

			// Token: 0x04021772 RID: 137074
			[Token(Token = "0x4021772")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_DEFAULT;
		}
	}
}
