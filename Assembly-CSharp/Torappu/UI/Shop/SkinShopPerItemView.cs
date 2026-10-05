using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B63 RID: 23395
	[Token(Token = "0x2005B63")]
	public class SkinShopPerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06021F5F RID: 139103 RVA: 0x000BBEF0 File Offset: 0x000BA0F0
		[Token(Token = "0x17004F7B")]
		public bool isAvailable
		{
			[Token(Token = "0x6021F5F")]
			[Address(RVA = "0x1C7F750", Offset = "0x1C7E350", VA = "0x181C7F750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06021F60 RID: 139104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F60")]
		[Address(RVA = "0x1C7E2A0", Offset = "0x1C7CEA0", VA = "0x181C7E2A0")]
		public void EnterDetailEvent()
		{
		}

		// Token: 0x06021F61 RID: 139105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F61")]
		[Address(RVA = "0x1C7E300", Offset = "0x1C7CF00", VA = "0x181C7E300")]
		public void OnClick()
		{
		}

		// Token: 0x06021F62 RID: 139106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F62")]
		[Address(RVA = "0x1C7E380", Offset = "0x1C7CF80", VA = "0x181C7E380")]
		public void Render(ISkinShopItemViewModel viewModel)
		{
		}

		// Token: 0x06021F63 RID: 139107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F63")]
		[Address(RVA = "0x1C7F3E0", Offset = "0x1C7DFE0", VA = "0x181C7F3E0")]
		private void _RenderGift()
		{
		}

		// Token: 0x06021F64 RID: 139108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F64")]
		[Address(RVA = "0x1C7F5F0", Offset = "0x1C7E1F0", VA = "0x181C7F5F0")]
		private void _SendMessageToState()
		{
		}

		// Token: 0x06021F65 RID: 139109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F65")]
		[Address(RVA = "0x1C7F6F0", Offset = "0x1C7E2F0", VA = "0x181C7F6F0")]
		public SkinShopPerItemView()
		{
		}

		// Token: 0x0402E870 RID: 190576
		[Token(Token = "0x402E870")]
		private const float DYN_AVATAR_SCALE_FLOAT = 0.333f;

		// Token: 0x0402E871 RID: 190577
		[Token(Token = "0x402E871")]
		private const float DYN_AVATAR_SCALE_SIDE = 0.633f;

		// Token: 0x0402E872 RID: 190578
		[Token(Token = "0x402E872")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _portraitImage;

		// Token: 0x0402E873 RID: 190579
		[Token(Token = "0x402E873")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _dynContainer;

		// Token: 0x0402E874 RID: 190580
		[Token(Token = "0x402E874")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _groupImage;

		// Token: 0x0402E875 RID: 190581
		[Token(Token = "0x402E875")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _timeLimitText;

		// Token: 0x0402E876 RID: 190582
		[Token(Token = "0x402E876")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x0402E877 RID: 190583
		[Token(Token = "0x402E877")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _backImgDyn;

		// Token: 0x0402E878 RID: 190584
		[Token(Token = "0x402E878")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _backShadowDyn;

		// Token: 0x0402E879 RID: 190585
		[Token(Token = "0x402E879")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _timeLimitObj;

		// Token: 0x0402E87A RID: 190586
		[Token(Token = "0x402E87A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _offsetPart;

		// Token: 0x0402E87B RID: 190587
		[Token(Token = "0x402E87B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _offsetText;

		// Token: 0x0402E87C RID: 190588
		[Token(Token = "0x402E87C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _skinName;

		// Token: 0x0402E87D RID: 190589
		[Token(Token = "0x402E87D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402E87E RID: 190590
		[Token(Token = "0x402E87E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SkinShopPerItemView.GiftView _giftFloatView;

		// Token: 0x0402E87F RID: 190591
		[Token(Token = "0x402E87F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SkinShopPerItemView.GiftView _giftSideView;

		// Token: 0x0402E880 RID: 190592
		[Token(Token = "0x402E880")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _cashPart;

		// Token: 0x0402E881 RID: 190593
		[Token(Token = "0x402E881")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _offsetPriceCash;

		// Token: 0x0402E882 RID: 190594
		[Token(Token = "0x402E882")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _currentPriceCash;

		// Token: 0x0402E883 RID: 190595
		[Token(Token = "0x402E883")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _diamondPart;

		// Token: 0x0402E884 RID: 190596
		[Token(Token = "0x402E884")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _offsetPriceDiamond;

		// Token: 0x0402E885 RID: 190597
		[Token(Token = "0x402E885")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _currentPriceDiamond;

		// Token: 0x0402E886 RID: 190598
		[Token(Token = "0x402E886")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _soldOutPart;

		// Token: 0x0402E887 RID: 190599
		[Token(Token = "0x402E887")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _objVoucherPart;

		// Token: 0x0402E888 RID: 190600
		[Token(Token = "0x402E888")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402E889 RID: 190601
		[Token(Token = "0x402E889")]
		[FieldOffset(Offset = "0xD0")]
		private UICharacterDynPortrait m_dynPortrait;

		// Token: 0x0402E88A RID: 190602
		[Token(Token = "0x402E88A")]
		[FieldOffset(Offset = "0xD8")]
		private CharUISkinStruct m_cacheStruct;

		// Token: 0x0402E88B RID: 190603
		[Token(Token = "0x402E88B")]
		[FieldOffset(Offset = "0xF0")]
		private SkinShopViewModel m_cacheViewModel;

		// Token: 0x0402E88C RID: 190604
		[Token(Token = "0x402E88C")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E88D RID: 190605
		[Token(Token = "0x402E88D")]
		[FieldOffset(Offset = "0x108")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E88E RID: 190606
		[Token(Token = "0x402E88E")]
		[FieldOffset(Offset = "0x118")]
		private PlayerAvatarView m_giftFloatView;

		// Token: 0x0402E88F RID: 190607
		[Token(Token = "0x402E88F")]
		[FieldOffset(Offset = "0x120")]
		private PlayerAvatarView m_giftSideView;

		// Token: 0x0402E890 RID: 190608
		[Token(Token = "0x402E890")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAvailable;

		// Token: 0x0402E891 RID: 190609
		[Token(Token = "0x402E891")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnterDetailEvent;

		// Token: 0x0402E892 RID: 190610
		[Token(Token = "0x402E892")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E893 RID: 190611
		[Token(Token = "0x402E893")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E894 RID: 190612
		[Token(Token = "0x402E894")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderGift;

		// Token: 0x0402E895 RID: 190613
		[Token(Token = "0x402E895")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendMessageToState;

		// Token: 0x0402E896 RID: 190614
		[Token(Token = "0x402E896")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B64 RID: 23396
		[Token(Token = "0x2005B64")]
		[Serializable]
		private class GiftView : IHotfixable
		{
			// Token: 0x17004F7C RID: 20348
			// (get) Token: 0x06021F66 RID: 139110 RVA: 0x000BBF08 File Offset: 0x000BA108
			// (set) Token: 0x06021F67 RID: 139111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004F7C")]
			public float dynamicScale
			{
				[Token(Token = "0x6021F66")]
				[Address(RVA = "0x1C6F190", Offset = "0x1C6DD90", VA = "0x181C6F190")]
				[CompilerGenerated]
				private get
				{
					return 0f;
				}
				[Token(Token = "0x6021F67")]
				[Address(RVA = "0x1C6F1F0", Offset = "0x1C6DDF0", VA = "0x181C6F1F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06021F68 RID: 139112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021F68")]
			[Address(RVA = "0x1C6EC60", Offset = "0x1C6D860", VA = "0x181C6EC60")]
			public void SetViewActive(bool active)
			{
			}

			// Token: 0x06021F69 RID: 139113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021F69")]
			[Address(RVA = "0x1C6EA00", Offset = "0x1C6D600", VA = "0x181C6EA00")]
			public void RenderAvatar(ILoadAsset loader, string avatarId, string dynId, string avatarName)
			{
			}

			// Token: 0x06021F6A RID: 139114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021F6A")]
			[Address(RVA = "0x1C6ECE0", Offset = "0x1C6D8E0", VA = "0x181C6ECE0")]
			private void _RenderAsDynamic(ILoadAsset loader, string avatarId)
			{
			}

			// Token: 0x06021F6B RID: 139115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021F6B")]
			[Address(RVA = "0x1C6F060", Offset = "0x1C6DC60", VA = "0x181C6F060")]
			private void _RenderAsStatic(ILoadAsset loader, string avatarId)
			{
			}

			// Token: 0x06021F6C RID: 139116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021F6C")]
			[Address(RVA = "0x1C6F130", Offset = "0x1C6DD30", VA = "0x181C6F130")]
			public GiftView()
			{
			}

			// Token: 0x0402E897 RID: 190615
			[Token(Token = "0x402E897")]
			[FieldOffset(Offset = "0x10")]
			public Transform root;

			// Token: 0x0402E898 RID: 190616
			[Token(Token = "0x402E898")]
			[FieldOffset(Offset = "0x18")]
			public Image staticImage;

			// Token: 0x0402E899 RID: 190617
			[Token(Token = "0x402E899")]
			[FieldOffset(Offset = "0x20")]
			public Transform dynamicContainer;

			// Token: 0x0402E89A RID: 190618
			[Token(Token = "0x402E89A")]
			[FieldOffset(Offset = "0x28")]
			public Text nameText;

			// Token: 0x0402E89B RID: 190619
			[Token(Token = "0x402E89B")]
			[FieldOffset(Offset = "0x30")]
			private string m_cachedId;

			// Token: 0x0402E89C RID: 190620
			[Token(Token = "0x402E89C")]
			[FieldOffset(Offset = "0x38")]
			private PlayerDynAvatarView m_dynAvatarInstance;

			// Token: 0x0402E89E RID: 190622
			[Token(Token = "0x402E89E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dynamicScale;

			// Token: 0x0402E89F RID: 190623
			[Token(Token = "0x402E89F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dynamicScale;

			// Token: 0x0402E8A0 RID: 190624
			[Token(Token = "0x402E8A0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetViewActive;

			// Token: 0x0402E8A1 RID: 190625
			[Token(Token = "0x402E8A1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderAvatar;

			// Token: 0x0402E8A2 RID: 190626
			[Token(Token = "0x402E8A2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RenderAsDynamic;

			// Token: 0x0402E8A3 RID: 190627
			[Token(Token = "0x402E8A3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__RenderAsStatic;

			// Token: 0x0402E8A4 RID: 190628
			[Token(Token = "0x402E8A4")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
