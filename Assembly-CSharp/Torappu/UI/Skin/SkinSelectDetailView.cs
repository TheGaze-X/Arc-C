using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EE1 RID: 16097
	[Token(Token = "0x2003EE1")]
	public class SkinSelectDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F8C RID: 102284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F8C")]
		[Address(RVA = "0x119E0D0", Offset = "0x119CCD0", VA = "0x18119E0D0")]
		public void OnClick()
		{
		}

		// Token: 0x06018F8D RID: 102285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F8D")]
		[Address(RVA = "0x119E1F0", Offset = "0x119CDF0", VA = "0x18119E1F0")]
		public void OnReleaseClick()
		{
		}

		// Token: 0x06018F8E RID: 102286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F8E")]
		[Address(RVA = "0x119E160", Offset = "0x119CD60", VA = "0x18119E160")]
		public void OnGiftInfoClick()
		{
		}

		// Token: 0x06018F8F RID: 102287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F8F")]
		[Address(RVA = "0x119DD00", Offset = "0x119C900", VA = "0x18119DD00")]
		public void Init(float state, SkinSelectViewModel viewModel)
		{
		}

		// Token: 0x06018F90 RID: 102288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F90")]
		[Address(RVA = "0x119E280", Offset = "0x119CE80", VA = "0x18119E280")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018F91 RID: 102289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F91")]
		[Address(RVA = "0x119E350", Offset = "0x119CF50", VA = "0x18119E350")]
		private void _RenderGift(SkinSelectViewModel viewModel)
		{
		}

		// Token: 0x06018F92 RID: 102290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F92")]
		[Address(RVA = "0x119E7D0", Offset = "0x119D3D0", VA = "0x18119E7D0")]
		public SkinSelectDetailView()
		{
		}

		// Token: 0x0401ED5E RID: 126302
		[Token(Token = "0x401ED5E")]
		private const float GIFT_DYN_AVATAR_SCALE = 0.294f;

		// Token: 0x0401ED5F RID: 126303
		[Token(Token = "0x401ED5F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _hostName;

		// Token: 0x0401ED60 RID: 126304
		[Token(Token = "0x401ED60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _buyState;

		// Token: 0x0401ED61 RID: 126305
		[Token(Token = "0x401ED61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _withGiftPart;

		// Token: 0x0401ED62 RID: 126306
		[Token(Token = "0x401ED62")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _withoutGiftPart;

		// Token: 0x0401ED63 RID: 126307
		[Token(Token = "0x401ED63")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _giftStaticImage;

		// Token: 0x0401ED64 RID: 126308
		[Token(Token = "0x401ED64")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _giftDynamicContainer;

		// Token: 0x0401ED65 RID: 126309
		[Token(Token = "0x401ED65")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _giftCard;

		// Token: 0x0401ED66 RID: 126310
		[Token(Token = "0x401ED66")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _giftCardGraphic;

		// Token: 0x0401ED67 RID: 126311
		[Token(Token = "0x401ED67")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _wearState;

		// Token: 0x0401ED68 RID: 126312
		[Token(Token = "0x401ED68")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _wearingState;

		// Token: 0x0401ED69 RID: 126313
		[Token(Token = "0x401ED69")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _noCharState;

		// Token: 0x0401ED6A RID: 126314
		[Token(Token = "0x401ED6A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _onlyShowState;

		// Token: 0x0401ED6B RID: 126315
		[Token(Token = "0x401ED6B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _diffTmplState;

		// Token: 0x0401ED6C RID: 126316
		[Token(Token = "0x401ED6C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _voucherExchangeState;

		// Token: 0x0401ED6D RID: 126317
		[Token(Token = "0x401ED6D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _hasGotState;

		// Token: 0x0401ED6E RID: 126318
		[Token(Token = "0x401ED6E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _notRedeemState;

		// Token: 0x0401ED6F RID: 126319
		[Token(Token = "0x401ED6F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textTmplNotMatch;

		// Token: 0x0401ED70 RID: 126320
		[Token(Token = "0x401ED70")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401ED71 RID: 126321
		[Token(Token = "0x401ED71")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SkinSelectDetailView.UISkinEvent _onClick;

		// Token: 0x0401ED72 RID: 126322
		[Token(Token = "0x401ED72")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SkinSelectDetailView.UISkinEvent _onReleaseClick;

		// Token: 0x0401ED73 RID: 126323
		[Token(Token = "0x401ED73")]
		[FieldOffset(Offset = "0xB8")]
		private SkinSelectViewModel m_cacheViewModel;

		// Token: 0x0401ED74 RID: 126324
		[Token(Token = "0x401ED74")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedGiftId;

		// Token: 0x0401ED75 RID: 126325
		[Token(Token = "0x401ED75")]
		[FieldOffset(Offset = "0xC8")]
		private UIItemViewModel m_giftModel;

		// Token: 0x0401ED76 RID: 126326
		[Token(Token = "0x401ED76")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401ED77 RID: 126327
		[Token(Token = "0x401ED77")]
		[FieldOffset(Offset = "0xE0")]
		private PlayerDynAvatarView m_giftViewInstance;

		// Token: 0x0401ED78 RID: 126328
		[Token(Token = "0x401ED78")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x0401ED79 RID: 126329
		[Token(Token = "0x401ED79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401ED7A RID: 126330
		[Token(Token = "0x401ED7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReleaseClick;

		// Token: 0x0401ED7B RID: 126331
		[Token(Token = "0x401ED7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGiftInfoClick;

		// Token: 0x0401ED7C RID: 126332
		[Token(Token = "0x401ED7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401ED7D RID: 126333
		[Token(Token = "0x401ED7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401ED7E RID: 126334
		[Token(Token = "0x401ED7E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderGift;

		// Token: 0x0401ED7F RID: 126335
		[Token(Token = "0x401ED7F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EE2 RID: 16098
		[Token(Token = "0x2003EE2")]
		[Serializable]
		public class UISkinEvent : UnityEvent<SkinSelectViewModel>
		{
			// Token: 0x06018F93 RID: 102291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F93")]
			[Address(RVA = "0x11AC190", Offset = "0x11AAD90", VA = "0x1811AC190")]
			public void Callback(SkinSelectViewModel param)
			{
			}

			// Token: 0x06018F94 RID: 102292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F94")]
			[Address(RVA = "0x11AC1E0", Offset = "0x11AADE0", VA = "0x1811AC1E0")]
			public UISkinEvent()
			{
			}
		}
	}
}
