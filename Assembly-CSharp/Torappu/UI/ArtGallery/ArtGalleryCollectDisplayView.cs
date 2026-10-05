using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065E9 RID: 26089
	[Token(Token = "0x20065E9")]
	public class ArtGalleryCollectDisplayView : DataBinder<ArtGalleryCollectDisplayProperty>, IHotfixable
	{
		// Token: 0x060257FB RID: 153595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257FB")]
		[Address(RVA = "0x2079940", Offset = "0x2078540", VA = "0x182079940", Slot = "7")]
		public override void OnValueChanged(ArtGalleryCollectDisplayProperty property)
		{
		}

		// Token: 0x060257FC RID: 153596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257FC")]
		[Address(RVA = "0x207A1C0", Offset = "0x2078DC0", VA = "0x18207A1C0")]
		private void _RenderListPart()
		{
		}

		// Token: 0x060257FD RID: 153597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257FD")]
		[Address(RVA = "0x2079F10", Offset = "0x2078B10", VA = "0x182079F10")]
		private void _RebuildList()
		{
		}

		// Token: 0x060257FE RID: 153598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257FE")]
		[Address(RVA = "0x207A3D0", Offset = "0x2078FD0", VA = "0x18207A3D0")]
		private void _SwitchContentGroup(bool isEnter)
		{
		}

		// Token: 0x060257FF RID: 153599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257FF")]
		[Address(RVA = "0x207A080", Offset = "0x2078C80", VA = "0x18207A080")]
		private void _RenderFilterPart()
		{
		}

		// Token: 0x06025800 RID: 153600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025800")]
		[Address(RVA = "0x2079C90", Offset = "0x2078890", VA = "0x182079C90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025801 RID: 153601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025801")]
		[Address(RVA = "0x2079E50", Offset = "0x2078A50", VA = "0x182079E50")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x06025802 RID: 153602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025802")]
		[Address(RVA = "0x2079BA0", Offset = "0x20787A0", VA = "0x182079BA0")]
		private void Update()
		{
		}

		// Token: 0x06025803 RID: 153603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025803")]
		[Address(RVA = "0x20798B0", Offset = "0x20784B0", VA = "0x1820798B0")]
		public void EventOnOpenFilterBtnClick()
		{
		}

		// Token: 0x06025804 RID: 153604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025804")]
		[Address(RVA = "0x207A6B0", Offset = "0x20792B0", VA = "0x18207A6B0")]
		public ArtGalleryCollectDisplayView()
		{
		}

		// Token: 0x04034A53 RID: 215635
		[Token(Token = "0x4034A53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtGalleryCollectSetAdapter _adapter;

		// Token: 0x04034A54 RID: 215636
		[Token(Token = "0x4034A54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		// Token: 0x04034A55 RID: 215637
		[Token(Token = "0x4034A55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04034A56 RID: 215638
		[Token(Token = "0x4034A56")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtCurFilterTypeName;

		// Token: 0x04034A57 RID: 215639
		[Token(Token = "0x4034A57")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _filterHolder;

		// Token: 0x04034A58 RID: 215640
		[Token(Token = "0x4034A58")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtGalleryDisplayTypeFilterPanel _filterPanelPrefab;

		// Token: 0x04034A59 RID: 215641
		[Token(Token = "0x4034A59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _trackPointHolder;

		// Token: 0x04034A5A RID: 215642
		[Token(Token = "0x4034A5A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x04034A5B RID: 215643
		[Token(Token = "0x4034A5B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasContentPart;

		// Token: 0x04034A5C RID: 215644
		[Token(Token = "0x4034A5C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _fadeOutContentTime;

		// Token: 0x04034A5D RID: 215645
		[Token(Token = "0x4034A5D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _fadeInContentTime;

		// Token: 0x04034A5E RID: 215646
		[Token(Token = "0x4034A5E")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04034A5F RID: 215647
		[Token(Token = "0x4034A5F")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034A60 RID: 215648
		[Token(Token = "0x4034A60")]
		[FieldOffset(Offset = "0x88")]
		private ArtGalleryDisplayTypeFilterPanel m_filterPanel;

		// Token: 0x04034A61 RID: 215649
		[Token(Token = "0x4034A61")]
		[FieldOffset(Offset = "0x90")]
		private GameObject m_trackPoint;

		// Token: 0x04034A62 RID: 215650
		[Token(Token = "0x4034A62")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedSetTypeId;

		// Token: 0x04034A63 RID: 215651
		[Token(Token = "0x4034A63")]
		[FieldOffset(Offset = "0xA0")]
		private Sequence m_switchSequence;

		// Token: 0x04034A64 RID: 215652
		[Token(Token = "0x4034A64")]
		[FieldOffset(Offset = "0xA8")]
		private float m_sliderLength;

		// Token: 0x04034A65 RID: 215653
		[Token(Token = "0x4034A65")]
		[FieldOffset(Offset = "0xB0")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x04034A66 RID: 215654
		[Token(Token = "0x4034A66")]
		[FieldOffset(Offset = "0xB8")]
		private ArtGalleryCollectDisplayViewModel m_model;

		// Token: 0x04034A67 RID: 215655
		[Token(Token = "0x4034A67")]
		[FieldOffset(Offset = "0xC0")]
		private int m_cachedEnterSeq;

		// Token: 0x04034A68 RID: 215656
		[Token(Token = "0x4034A68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034A69 RID: 215657
		[Token(Token = "0x4034A69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderListPart;

		// Token: 0x04034A6A RID: 215658
		[Token(Token = "0x4034A6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RebuildList;

		// Token: 0x04034A6B RID: 215659
		[Token(Token = "0x4034A6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SwitchContentGroup;

		// Token: 0x04034A6C RID: 215660
		[Token(Token = "0x4034A6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderFilterPart;

		// Token: 0x04034A6D RID: 215661
		[Token(Token = "0x4034A6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034A6E RID: 215662
		[Token(Token = "0x4034A6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x04034A6F RID: 215663
		[Token(Token = "0x4034A6F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04034A70 RID: 215664
		[Token(Token = "0x4034A70")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnOpenFilterBtnClick;

		// Token: 0x04034A71 RID: 215665
		[Token(Token = "0x4034A71")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065EA RID: 26090
		[Token(Token = "0x20065EA")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06025805 RID: 153605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025805")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(ArtGalleryCollectDisplayView closure)
			{
			}

			// Token: 0x06025806 RID: 153606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025806")]
			[Address(RVA = "0x2087680", Offset = "0x2086280", VA = "0x182087680", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04034A72 RID: 215666
			[Token(Token = "0x4034A72")]
			[FieldOffset(Offset = "0x10")]
			private ArtGalleryCollectDisplayView m_closure;
		}
	}
}
