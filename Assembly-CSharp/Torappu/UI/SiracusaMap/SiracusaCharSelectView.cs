using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F25 RID: 16165
	[Token(Token = "0x2003F25")]
	public class SiracusaCharSelectView : DataBinder<SiracusaCharSelectProperty>
	{
		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0601919D RID: 102813 RVA: 0x0009CF78 File Offset: 0x0009B178
		// (set) Token: 0x0601919E RID: 102814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C07")]
		public bool isRewardsDetailShowing
		{
			[Token(Token = "0x601919D")]
			[Address(RVA = "0x11CFB10", Offset = "0x11CE710", VA = "0x1811CFB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601919E")]
			[Address(RVA = "0x11CFD70", Offset = "0x11CE970", VA = "0x1811CFD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0601919F RID: 102815 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191A0 RID: 102816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C08")]
		public Action<string> eventCharCardSwitch
		{
			[Token(Token = "0x601919F")]
			[Address(RVA = "0x11CF990", Offset = "0x11CE590", VA = "0x1811CF990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191A0")]
			[Address(RVA = "0x11CFB70", Offset = "0x11CE770", VA = "0x1811CFB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x060191A1 RID: 102817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191A2 RID: 102818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C09")]
		public Action eventQuitCharCard
		{
			[Token(Token = "0x60191A1")]
			[Address(RVA = "0x11CF9F0", Offset = "0x11CE5F0", VA = "0x1811CF9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191A2")]
			[Address(RVA = "0x11CFBF0", Offset = "0x11CE7F0", VA = "0x1811CFBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x060191A3 RID: 102819 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191A4 RID: 102820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C0A")]
		public Action<string> eventReview
		{
			[Token(Token = "0x60191A3")]
			[Address(RVA = "0x11CFA50", Offset = "0x11CE650", VA = "0x1811CFA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191A4")]
			[Address(RVA = "0x11CFC70", Offset = "0x11CE870", VA = "0x1811CFC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x060191A5 RID: 102821 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191A6 RID: 102822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C0B")]
		public Action<string> eventSelectCharCard
		{
			[Token(Token = "0x60191A5")]
			[Address(RVA = "0x11CFAB0", Offset = "0x11CE6B0", VA = "0x1811CFAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191A6")]
			[Address(RVA = "0x11CFCF0", Offset = "0x11CE8F0", VA = "0x1811CFCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060191A7 RID: 102823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191A7")]
		[Address(RVA = "0x11CCF60", Offset = "0x11CBB60", VA = "0x1811CCF60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060191A8 RID: 102824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191A8")]
		[Address(RVA = "0x11CF290", Offset = "0x11CDE90", VA = "0x1811CF290")]
		private void _ResetAnims()
		{
		}

		// Token: 0x060191A9 RID: 102825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191A9")]
		[Address(RVA = "0x11CD2A0", Offset = "0x11CBEA0", VA = "0x1811CD2A0")]
		private void _InitSwitchAnim()
		{
		}

		// Token: 0x060191AA RID: 102826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191AA")]
		[Address(RVA = "0x11CD5A0", Offset = "0x11CC1A0", VA = "0x1811CD5A0")]
		private void _PlaySwitchAnim()
		{
		}

		// Token: 0x060191AB RID: 102827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191AB")]
		[Address(RVA = "0x11CD340", Offset = "0x11CBF40", VA = "0x1811CD340")]
		private void _InitUnloadAnim()
		{
		}

		// Token: 0x060191AC RID: 102828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191AC")]
		[Address(RVA = "0x11CD700", Offset = "0x11CC300", VA = "0x1811CD700")]
		private void _PlayUnloadAnim()
		{
		}

		// Token: 0x060191AD RID: 102829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191AD")]
		[Address(RVA = "0x11CD200", Offset = "0x11CBE00", VA = "0x1811CD200")]
		private void _InitSelectCharCardAnim()
		{
		}

		// Token: 0x060191AE RID: 102830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191AE")]
		[Address(RVA = "0x11CD500", Offset = "0x11CC100", VA = "0x1811CD500")]
		private void _PlaySelectCharCardAnim()
		{
		}

		// Token: 0x060191AF RID: 102831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191AF")]
		[Address(RVA = "0x11CEE10", Offset = "0x11CDA10", VA = "0x1811CEE10")]
		private void _Render(SiracusaCharSelectViewModel viewModel)
		{
		}

		// Token: 0x060191B0 RID: 102832 RVA: 0x0009CF90 File Offset: 0x0009B190
		[Token(Token = "0x60191B0")]
		[Address(RVA = "0x11CCC10", Offset = "0x11CB810", VA = "0x1811CCC10")]
		private bool _CheckIfSelectChange()
		{
			return default(bool);
		}

		// Token: 0x060191B1 RID: 102833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B1")]
		[Address(RVA = "0x11CEBA0", Offset = "0x11CD7A0", VA = "0x1811CEBA0")]
		private void _RenderTheme(SiracusaCharSelectItemViewModel viewModel)
		{
		}

		// Token: 0x060191B2 RID: 102834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B2")]
		[Address(RVA = "0x11CDF30", Offset = "0x11CCB30", VA = "0x1811CDF30")]
		private void _RenderCharInfo(SiracusaCharSelectItemViewModel viewModel, bool selectChanged, bool isRetro)
		{
		}

		// Token: 0x060191B3 RID: 102835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B3")]
		[Address(RVA = "0x11CDA10", Offset = "0x11CC610", VA = "0x1811CDA10")]
		private void _RenderCharCardRewardList(SiracusaCharSelectItemViewModel viewModel, bool isRetro)
		{
		}

		// Token: 0x060191B4 RID: 102836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B4")]
		[Address(RVA = "0x11CD980", Offset = "0x11CC580", VA = "0x1811CD980")]
		private void _RenderCharCardList()
		{
		}

		// Token: 0x060191B5 RID: 102837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B5")]
		[Address(RVA = "0x11CDC50", Offset = "0x11CC850", VA = "0x1811CDC50")]
		private void _RenderCharChoosingHighLight(SiracusaCharSelectItemViewModel viewModel)
		{
		}

		// Token: 0x060191B6 RID: 102838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60191B6")]
		[Address(RVA = "0x11CCD90", Offset = "0x11CB990", VA = "0x1811CCD90")]
		private IEnumerator _CoRenderCharChoosingHighLight(SiracusaCharSelectItemViewModel viewModel)
		{
			return null;
		}

		// Token: 0x060191B7 RID: 102839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B7")]
		[Address(RVA = "0x11CE850", Offset = "0x11CD450", VA = "0x1811CE850")]
		private void _RenderChoosingHighLight(SiracusaCharSelectItemViewModel choosingViewModel)
		{
		}

		// Token: 0x060191B8 RID: 102840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B8")]
		[Address(RVA = "0x11CF630", Offset = "0x11CE230", VA = "0x1811CF630")]
		private void _TryCoPlayHighLightAnimWhenEnterView(SiracusaCharSelectItemViewModel choosingViewModel)
		{
		}

		// Token: 0x060191B9 RID: 102841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191B9")]
		[Address(RVA = "0x11CF800", Offset = "0x11CE400", VA = "0x1811CF800")]
		private void _TryStopCoroutineChoosingHighLight()
		{
		}

		// Token: 0x060191BA RID: 102842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191BA")]
		[Address(RVA = "0x11CD860", Offset = "0x11CC460", VA = "0x1811CD860")]
		private void _RefreshHeadHighLightPos(int index)
		{
		}

		// Token: 0x060191BB RID: 102843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191BB")]
		[Address(RVA = "0x11CF2F0", Offset = "0x11CDEF0", VA = "0x1811CF2F0")]
		private void _ResetDetailRewardsPopView()
		{
		}

		// Token: 0x060191BC RID: 102844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191BC")]
		[Address(RVA = "0x11CF3D0", Offset = "0x11CDFD0", VA = "0x1811CF3D0")]
		private void _ShowDetailRewardsPopView(SiracusaCharSelectItemViewModel viewModel, bool show)
		{
		}

		// Token: 0x060191BD RID: 102845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60191BD")]
		[Address(RVA = "0x11CCE60", Offset = "0x11CBA60", VA = "0x1811CCE60")]
		private string _GetItalyNameSpritePath(string charCardId)
		{
			return null;
		}

		// Token: 0x060191BE RID: 102846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191BE")]
		[Address(RVA = "0x11CCB60", Offset = "0x11CB760", VA = "0x1811CCB60", Slot = "7")]
		public override void OnValueChanged(SiracusaCharSelectProperty property)
		{
		}

		// Token: 0x060191BF RID: 102847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191BF")]
		[Address(RVA = "0x11CC560", Offset = "0x11CB160", VA = "0x1811CC560")]
		public void Init(SiracusaMapController controller)
		{
		}

		// Token: 0x060191C0 RID: 102848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C0")]
		[Address(RVA = "0x11CC4E0", Offset = "0x11CB0E0", VA = "0x1811CC4E0")]
		public void CloseDetailRewardsPopView()
		{
		}

		// Token: 0x060191C1 RID: 102849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C1")]
		[Address(RVA = "0x11CCA30", Offset = "0x11CB630", VA = "0x1811CCA30")]
		public void OnRewardDetailCloseClick()
		{
		}

		// Token: 0x060191C2 RID: 102850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C2")]
		[Address(RVA = "0x11CC9C0", Offset = "0x11CB5C0", VA = "0x1811CC9C0")]
		public void OnRewardDetailClick()
		{
		}

		// Token: 0x060191C3 RID: 102851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C3")]
		[Address(RVA = "0x11CCA90", Offset = "0x11CB690", VA = "0x1811CCA90")]
		public void OnSelectConfirmClick()
		{
		}

		// Token: 0x060191C4 RID: 102852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C4")]
		[Address(RVA = "0x11CC770", Offset = "0x11CB370", VA = "0x1811CC770")]
		public void OnCharQuitClick()
		{
		}

		// Token: 0x060191C5 RID: 102853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C5")]
		[Address(RVA = "0x11CC850", Offset = "0x11CB450", VA = "0x1811CC850")]
		public void OnReviewClick()
		{
		}

		// Token: 0x060191C6 RID: 102854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C6")]
		[Address(RVA = "0x11CD3E0", Offset = "0x11CBFE0", VA = "0x1811CD3E0")]
		private void _OnCharCardItemClick(string charCardId)
		{
		}

		// Token: 0x060191C7 RID: 102855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191C7")]
		[Address(RVA = "0x11CF920", Offset = "0x11CE520", VA = "0x1811CF920")]
		public SiracusaCharSelectView()
		{
		}

		// Token: 0x0401F10B RID: 127243
		[Token(Token = "0x401F10B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBgTintTheme;

		// Token: 0x0401F10C RID: 127244
		[Token(Token = "0x401F10C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgBgGradientTheme;

		// Token: 0x0401F10D RID: 127245
		[Token(Token = "0x401F10D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objStateActive;

		// Token: 0x0401F10E RID: 127246
		[Token(Token = "0x401F10E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAVGCharacter _avgChar;

		// Token: 0x0401F10F RID: 127247
		[Token(Token = "0x401F10F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtCharName;

		// Token: 0x0401F110 RID: 127248
		[Token(Token = "0x401F110")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIDynImage _imgCharEspName;

		// Token: 0x0401F111 RID: 127249
		[Token(Token = "0x401F111")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objCharUnknown;

		// Token: 0x0401F112 RID: 127250
		[Token(Token = "0x401F112")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtCharDesActive;

		// Token: 0x0401F113 RID: 127251
		[Token(Token = "0x401F113")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect _scrollViewCharInfo;

		// Token: 0x0401F114 RID: 127252
		[Token(Token = "0x401F114")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtCharInfo;

		// Token: 0x0401F115 RID: 127253
		[Token(Token = "0x401F115")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _rewardListGo;

		// Token: 0x0401F116 RID: 127254
		[Token(Token = "0x401F116")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objRewardClear;

		// Token: 0x0401F117 RID: 127255
		[Token(Token = "0x401F117")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _layoutRewardsPreview;

		// Token: 0x0401F118 RID: 127256
		[Token(Token = "0x401F118")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _objStateEmpty;

		// Token: 0x0401F119 RID: 127257
		[Token(Token = "0x401F119")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _transHeadHighLight;

		// Token: 0x0401F11A RID: 127258
		[Token(Token = "0x401F11A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _objStateUnknown;

		// Token: 0x0401F11B RID: 127259
		[Token(Token = "0x401F11B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _objStateConfirm;

		// Token: 0x0401F11C RID: 127260
		[Token(Token = "0x401F11C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAtlasImage _imgConfirmBtnTheme;

		// Token: 0x0401F11D RID: 127261
		[Token(Token = "0x401F11D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _objStateSelected;

		// Token: 0x0401F11E RID: 127262
		[Token(Token = "0x401F11E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _objCharQuit;

		// Token: 0x0401F11F RID: 127263
		[Token(Token = "0x401F11F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _objBtnCharAction;

		// Token: 0x0401F120 RID: 127264
		[Token(Token = "0x401F120")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _objCompleted;

		// Token: 0x0401F121 RID: 127265
		[Token(Token = "0x401F121")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAtlasImage _imgReviewBtnTheme;

		// Token: 0x0401F122 RID: 127266
		[Token(Token = "0x401F122")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CanvasGroup _canvasRewardsDetail;

		// Token: 0x0401F123 RID: 127267
		[Token(Token = "0x401F123")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ScrollRect _scrollViewRewardsDetail;

		// Token: 0x0401F124 RID: 127268
		[Token(Token = "0x401F124")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private SimpleLayoutContent _layoutRewardsSpecial;

		// Token: 0x0401F125 RID: 127269
		[Token(Token = "0x401F125")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SimpleLayoutContent _layoutRewardsNormal;

		// Token: 0x0401F126 RID: 127270
		[Token(Token = "0x401F126")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _objRewardsSpecialGroup;

		// Token: 0x0401F127 RID: 127271
		[Token(Token = "0x401F127")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _objRewardsNormalGroup;

		// Token: 0x0401F128 RID: 127272
		[Token(Token = "0x401F128")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private SimpleLayoutContent _layoutCharCards;

		// Token: 0x0401F129 RID: 127273
		[Token(Token = "0x401F129")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private AnimationWrapper _switchAnimWrapper;

		// Token: 0x0401F12A RID: 127274
		[Token(Token = "0x401F12A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private AnimationWrapper _selectCharAnimWrapper;

		// Token: 0x0401F12B RID: 127275
		[Token(Token = "0x401F12B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private AnimationWrapper _unloadAnimWrapper;

		// Token: 0x0401F12C RID: 127276
		[Token(Token = "0x401F12C")]
		[FieldOffset(Offset = "0x128")]
		private bool m_hasInited;

		// Token: 0x0401F12D RID: 127277
		[Token(Token = "0x401F12D")]
		[FieldOffset(Offset = "0x130")]
		private FadeSwitchTween m_rewardsDetailTween;

		// Token: 0x0401F12E RID: 127278
		[Token(Token = "0x401F12E")]
		[FieldOffset(Offset = "0x138")]
		private SiracusaCharSelectView.RewardAdapter m_rewardPreviewAdapter;

		// Token: 0x0401F12F RID: 127279
		[Token(Token = "0x401F12F")]
		[FieldOffset(Offset = "0x140")]
		private SiracusaCharSelectView.RewardAdapter m_rewardDetailSpecialAdapter;

		// Token: 0x0401F130 RID: 127280
		[Token(Token = "0x401F130")]
		[FieldOffset(Offset = "0x148")]
		private SiracusaCharSelectView.RewardAdapter m_rewardDetailNormalAdapter;

		// Token: 0x0401F131 RID: 127281
		[Token(Token = "0x401F131")]
		[FieldOffset(Offset = "0x150")]
		private SiracusaCharSelectView.CharCardAdapter m_charCardsAdapter;

		// Token: 0x0401F132 RID: 127282
		[Token(Token = "0x401F132")]
		[FieldOffset(Offset = "0x158")]
		private AutoPackSpriteHub m_charItalyNameSpriteHub;

		// Token: 0x0401F133 RID: 127283
		[Token(Token = "0x401F133")]
		[FieldOffset(Offset = "0x160")]
		private SiracusaCharSelectViewModel m_viewModel;

		// Token: 0x0401F134 RID: 127284
		[Token(Token = "0x401F134")]
		[FieldOffset(Offset = "0x168")]
		private SiracusaCharSelectItemViewModel m_choosingItemViewModel;

		// Token: 0x0401F135 RID: 127285
		[Token(Token = "0x401F135")]
		[FieldOffset(Offset = "0x170")]
		private string m_choosingCharId;

		// Token: 0x0401F136 RID: 127286
		[Token(Token = "0x401F136")]
		[FieldOffset(Offset = "0x178")]
		private AutoPackSpriteHub m_charCardSpriteHub;

		// Token: 0x0401F137 RID: 127287
		[Token(Token = "0x401F137")]
		[FieldOffset(Offset = "0x180")]
		private float m_charCardCeilSize;

		// Token: 0x0401F138 RID: 127288
		[Token(Token = "0x401F138")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine m_coCharHighLight;

		// Token: 0x0401F139 RID: 127289
		[Token(Token = "0x401F139")]
		[FieldOffset(Offset = "0x190")]
		private SiracusaMapController m_controller;

		// Token: 0x0401F13A RID: 127290
		[Token(Token = "0x401F13A")]
		private const string SWITCH_ANIM = "siracusa_char_select_switch";

		// Token: 0x0401F13B RID: 127291
		[Token(Token = "0x401F13B")]
		private const string CHAR_HIGH_LIGHT_ANIM = "siracusa_char_select_list_highlight";

		// Token: 0x0401F13C RID: 127292
		[Token(Token = "0x401F13C")]
		private const string UNLOAD_ANIM = "siracusa_char_unload";

		// Token: 0x0401F13D RID: 127293
		[Token(Token = "0x401F13D")]
		private const float ENTER_VIEW_CHOOSING_HIGH_LIGHT_WAIT_TIME = 0.35f;

		// Token: 0x0401F143 RID: 127299
		[Token(Token = "0x401F143")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isRewardsDetailShowing;

		// Token: 0x0401F144 RID: 127300
		[Token(Token = "0x401F144")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isRewardsDetailShowing;

		// Token: 0x0401F145 RID: 127301
		[Token(Token = "0x401F145")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_eventCharCardSwitch;

		// Token: 0x0401F146 RID: 127302
		[Token(Token = "0x401F146")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_eventCharCardSwitch;

		// Token: 0x0401F147 RID: 127303
		[Token(Token = "0x401F147")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_eventQuitCharCard;

		// Token: 0x0401F148 RID: 127304
		[Token(Token = "0x401F148")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_eventQuitCharCard;

		// Token: 0x0401F149 RID: 127305
		[Token(Token = "0x401F149")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_eventReview;

		// Token: 0x0401F14A RID: 127306
		[Token(Token = "0x401F14A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_eventReview;

		// Token: 0x0401F14B RID: 127307
		[Token(Token = "0x401F14B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_eventSelectCharCard;

		// Token: 0x0401F14C RID: 127308
		[Token(Token = "0x401F14C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_eventSelectCharCard;

		// Token: 0x0401F14D RID: 127309
		[Token(Token = "0x401F14D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F14E RID: 127310
		[Token(Token = "0x401F14E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResetAnims;

		// Token: 0x0401F14F RID: 127311
		[Token(Token = "0x401F14F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitSwitchAnim;

		// Token: 0x0401F150 RID: 127312
		[Token(Token = "0x401F150")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnim;

		// Token: 0x0401F151 RID: 127313
		[Token(Token = "0x401F151")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitUnloadAnim;

		// Token: 0x0401F152 RID: 127314
		[Token(Token = "0x401F152")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayUnloadAnim;

		// Token: 0x0401F153 RID: 127315
		[Token(Token = "0x401F153")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitSelectCharCardAnim;

		// Token: 0x0401F154 RID: 127316
		[Token(Token = "0x401F154")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PlaySelectCharCardAnim;

		// Token: 0x0401F155 RID: 127317
		[Token(Token = "0x401F155")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401F156 RID: 127318
		[Token(Token = "0x401F156")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckIfSelectChange;

		// Token: 0x0401F157 RID: 127319
		[Token(Token = "0x401F157")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RenderTheme;

		// Token: 0x0401F158 RID: 127320
		[Token(Token = "0x401F158")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RenderCharInfo;

		// Token: 0x0401F159 RID: 127321
		[Token(Token = "0x401F159")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RenderCharCardRewardList;

		// Token: 0x0401F15A RID: 127322
		[Token(Token = "0x401F15A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RenderCharCardList;

		// Token: 0x0401F15B RID: 127323
		[Token(Token = "0x401F15B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RenderCharChoosingHighLight;

		// Token: 0x0401F15C RID: 127324
		[Token(Token = "0x401F15C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CoRenderCharChoosingHighLight;

		// Token: 0x0401F15D RID: 127325
		[Token(Token = "0x401F15D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RenderChoosingHighLight;

		// Token: 0x0401F15E RID: 127326
		[Token(Token = "0x401F15E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__TryCoPlayHighLightAnimWhenEnterView;

		// Token: 0x0401F15F RID: 127327
		[Token(Token = "0x401F15F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TryStopCoroutineChoosingHighLight;

		// Token: 0x0401F160 RID: 127328
		[Token(Token = "0x401F160")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__RefreshHeadHighLightPos;

		// Token: 0x0401F161 RID: 127329
		[Token(Token = "0x401F161")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ResetDetailRewardsPopView;

		// Token: 0x0401F162 RID: 127330
		[Token(Token = "0x401F162")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ShowDetailRewardsPopView;

		// Token: 0x0401F163 RID: 127331
		[Token(Token = "0x401F163")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetItalyNameSpritePath;

		// Token: 0x0401F164 RID: 127332
		[Token(Token = "0x401F164")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F165 RID: 127333
		[Token(Token = "0x401F165")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F166 RID: 127334
		[Token(Token = "0x401F166")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CloseDetailRewardsPopView;

		// Token: 0x0401F167 RID: 127335
		[Token(Token = "0x401F167")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnRewardDetailCloseClick;

		// Token: 0x0401F168 RID: 127336
		[Token(Token = "0x401F168")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnRewardDetailClick;

		// Token: 0x0401F169 RID: 127337
		[Token(Token = "0x401F169")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnSelectConfirmClick;

		// Token: 0x0401F16A RID: 127338
		[Token(Token = "0x401F16A")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnCharQuitClick;

		// Token: 0x0401F16B RID: 127339
		[Token(Token = "0x401F16B")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnReviewClick;

		// Token: 0x0401F16C RID: 127340
		[Token(Token = "0x401F16C")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnCharCardItemClick;

		// Token: 0x0401F16D RID: 127341
		[Token(Token = "0x401F16D")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F26 RID: 16166
		[Token(Token = "0x2003F26")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C0C RID: 15372
			// (get) Token: 0x060191C8 RID: 102856 RVA: 0x0009CFA8 File Offset: 0x0009B1A8
			[Token(Token = "0x17003C0C")]
			public override int count
			{
				[Token(Token = "0x60191C8")]
				[Address(RVA = "0x11C62E0", Offset = "0x11C4EE0", VA = "0x1811C62E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060191C9 RID: 102857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60191C9")]
			[Address(RVA = "0x11C5FF0", Offset = "0x11C4BF0", VA = "0x1811C5FF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060191CA RID: 102858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60191CA")]
			[Address(RVA = "0x11C6280", Offset = "0x11C4E80", VA = "0x1811C6280")]
			public RewardAdapter()
			{
			}

			// Token: 0x0401F16E RID: 127342
			[Token(Token = "0x401F16E")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public string charCardId;

			// Token: 0x0401F16F RID: 127343
			[Token(Token = "0x401F16F")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public List<SiracusaCharSelectTaskRingRewardInfo> itemList;

			// Token: 0x0401F170 RID: 127344
			[Token(Token = "0x401F170")]
			[FieldOffset(Offset = "0x30")]
			[NonSerialized]
			public bool itemClickable;

			// Token: 0x0401F171 RID: 127345
			[Token(Token = "0x401F171")]
			[FieldOffset(Offset = "0x31")]
			[NonSerialized]
			public bool needShowHasGetTag;

			// Token: 0x0401F172 RID: 127346
			[Token(Token = "0x401F172")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F173 RID: 127347
			[Token(Token = "0x401F173")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F174 RID: 127348
			[Token(Token = "0x401F174")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003F27 RID: 16167
		[Token(Token = "0x2003F27")]
		private class CharCardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060191CB RID: 102859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60191CB")]
			[Address(RVA = "0x11C5910", Offset = "0x11C4510", VA = "0x1811C5910")]
			public CharCardAdapter(SiracusaCharSelectView closure)
			{
			}

			// Token: 0x17003C0D RID: 15373
			// (get) Token: 0x060191CC RID: 102860 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
			[Token(Token = "0x17003C0D")]
			public override int count
			{
				[Token(Token = "0x60191CC")]
				[Address(RVA = "0x11C5990", Offset = "0x11C4590", VA = "0x1811C5990", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060191CD RID: 102861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60191CD")]
			[Address(RVA = "0x11C55B0", Offset = "0x11C41B0", VA = "0x1811C55B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401F175 RID: 127349
			[Token(Token = "0x401F175")]
			[FieldOffset(Offset = "0x20")]
			private SiracusaCharSelectView m_closure;

			// Token: 0x0401F176 RID: 127350
			[Token(Token = "0x401F176")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F177 RID: 127351
			[Token(Token = "0x401F177")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F178 RID: 127352
			[Token(Token = "0x401F178")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
