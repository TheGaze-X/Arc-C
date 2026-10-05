using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C61 RID: 23649
	[Token(Token = "0x2005C61")]
	public class ClimbTowerTrainView : DataBinder<ClimbTowerTrainProperty>, IHotfixable
	{
		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x06022439 RID: 140345 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602243A RID: 140346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005071")]
		public UIPage page
		{
			[Token(Token = "0x6022439")]
			[Address(RVA = "0x1CC7740", Offset = "0x1CC6340", VA = "0x181CC7740")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602243A")]
			[Address(RVA = "0x1CC78E0", Offset = "0x1CC64E0", VA = "0x181CC78E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602243B RID: 140347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602243B")]
		[Address(RVA = "0x1CC66C0", Offset = "0x1CC52C0", VA = "0x181CC66C0")]
		public void OnExit()
		{
		}

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x0602243C RID: 140348 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602243D RID: 140349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005072")]
		public Action<string> onTowerSelected
		{
			[Token(Token = "0x602243C")]
			[Address(RVA = "0x1CC76C0", Offset = "0x1CC62C0", VA = "0x181CC76C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602243D")]
			[Address(RVA = "0x1CC7850", Offset = "0x1CC6450", VA = "0x181CC7850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x0602243E RID: 140350 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602243F RID: 140351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005073")]
		public Action<string> onDetailClicked
		{
			[Token(Token = "0x602243E")]
			[Address(RVA = "0x1CC7640", Offset = "0x1CC6240", VA = "0x181CC7640")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602243F")]
			[Address(RVA = "0x1CC77C0", Offset = "0x1CC63C0", VA = "0x181CC77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022440 RID: 140352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022440")]
		[Address(RVA = "0x1CC6600", Offset = "0x1CC5200", VA = "0x181CC6600")]
		public void OnEmptySelected()
		{
		}

		// Token: 0x06022441 RID: 140353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022441")]
		[Address(RVA = "0x1CC6760", Offset = "0x1CC5360", VA = "0x181CC6760", Slot = "7")]
		public override void OnValueChanged(ClimbTowerTrainProperty property)
		{
		}

		// Token: 0x06022442 RID: 140354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022442")]
		[Address(RVA = "0x1CC71A0", Offset = "0x1CC5DA0", VA = "0x181CC71A0")]
		private void _RenderFadeSwitchContents(ClimbTowerTrainViewModel model)
		{
		}

		// Token: 0x06022443 RID: 140355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022443")]
		[Address(RVA = "0x1CC6E40", Offset = "0x1CC5A40", VA = "0x181CC6E40")]
		private void _PlayAllCompleteToastAnimIfNeed(bool isAllComplete)
		{
		}

		// Token: 0x06022444 RID: 140356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022444")]
		[Address(RVA = "0x1CC7320", Offset = "0x1CC5F20", VA = "0x181CC7320")]
		private void _RenderTowerInfo(ClimbTowerTrainViewModel model)
		{
		}

		// Token: 0x06022445 RID: 140357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022445")]
		[Address(RVA = "0x1CC6CE0", Offset = "0x1CC58E0", VA = "0x181CC6CE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022446 RID: 140358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022446")]
		[Address(RVA = "0x1CC75B0", Offset = "0x1CC61B0", VA = "0x181CC75B0")]
		public ClimbTowerTrainView()
		{
		}

		// Token: 0x0402F0C0 RID: 192704
		[Token(Token = "0x402F0C0")]
		private const float FADE_SWITCH_DUR = 0.15f;

		// Token: 0x0402F0C1 RID: 192705
		[Token(Token = "0x402F0C1")]
		private const float FADE_RENDER_DELAY = 0.05f;

		// Token: 0x0402F0C2 RID: 192706
		[Token(Token = "0x402F0C2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 ALL_COMPLETE_TOAST_START_POS;

		// Token: 0x0402F0C3 RID: 192707
		[Token(Token = "0x402F0C3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 ALL_COMPLETE_TOAST_END_POS;

		// Token: 0x0402F0C4 RID: 192708
		[Token(Token = "0x402F0C4")]
		private const float FADE_TOAST_DUR = 2f;

		// Token: 0x0402F0C5 RID: 192709
		[Token(Token = "0x402F0C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClimbTowerTrainItemView[] _trainTowerButtons;

		// Token: 0x0402F0C6 RID: 192710
		[Token(Token = "0x402F0C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _towerName;

		// Token: 0x0402F0C7 RID: 192711
		[Token(Token = "0x402F0C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _towerSubName;

		// Token: 0x0402F0C8 RID: 192712
		[Token(Token = "0x402F0C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _towerIcon;

		// Token: 0x0402F0C9 RID: 192713
		[Token(Token = "0x402F0C9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _towerDesc;

		// Token: 0x0402F0CA RID: 192714
		[Token(Token = "0x402F0CA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _btnEnter;

		// Token: 0x0402F0CB RID: 192715
		[Token(Token = "0x402F0CB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _btnContinue;

		// Token: 0x0402F0CC RID: 192716
		[Token(Token = "0x402F0CC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelBtnEnter;

		// Token: 0x0402F0CD RID: 192717
		[Token(Token = "0x402F0CD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _toggleDetailText;

		// Token: 0x0402F0CE RID: 192718
		[Token(Token = "0x402F0CE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelAllComplete;

		// Token: 0x0402F0CF RID: 192719
		[Token(Token = "0x402F0CF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rectAllComplete;

		// Token: 0x0402F0D0 RID: 192720
		[Token(Token = "0x402F0D0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasGroupBtn;

		// Token: 0x0402F0D1 RID: 192721
		[Token(Token = "0x402F0D1")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402F0D2 RID: 192722
		[Token(Token = "0x402F0D2")]
		[FieldOffset(Offset = "0x88")]
		private UISwitchTween.TweenWrapper m_tween;

		// Token: 0x0402F0D3 RID: 192723
		[Token(Token = "0x402F0D3")]
		[FieldOffset(Offset = "0x90")]
		private UISwitchTween.TweenWrapper m_toastTween;

		// Token: 0x0402F0D4 RID: 192724
		[Token(Token = "0x402F0D4")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedTower;

		// Token: 0x0402F0D8 RID: 192728
		[Token(Token = "0x402F0D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F0D9 RID: 192729
		[Token(Token = "0x402F0D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F0DA RID: 192730
		[Token(Token = "0x402F0DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402F0DB RID: 192731
		[Token(Token = "0x402F0DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onTowerSelected;

		// Token: 0x0402F0DC RID: 192732
		[Token(Token = "0x402F0DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onTowerSelected;

		// Token: 0x0402F0DD RID: 192733
		[Token(Token = "0x402F0DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_onDetailClicked;

		// Token: 0x0402F0DE RID: 192734
		[Token(Token = "0x402F0DE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_onDetailClicked;

		// Token: 0x0402F0DF RID: 192735
		[Token(Token = "0x402F0DF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEmptySelected;

		// Token: 0x0402F0E0 RID: 192736
		[Token(Token = "0x402F0E0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F0E1 RID: 192737
		[Token(Token = "0x402F0E1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderFadeSwitchContents;

		// Token: 0x0402F0E2 RID: 192738
		[Token(Token = "0x402F0E2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayAllCompleteToastAnimIfNeed;

		// Token: 0x0402F0E3 RID: 192739
		[Token(Token = "0x402F0E3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderTowerInfo;

		// Token: 0x0402F0E4 RID: 192740
		[Token(Token = "0x402F0E4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F0E5 RID: 192741
		[Token(Token = "0x402F0E5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
