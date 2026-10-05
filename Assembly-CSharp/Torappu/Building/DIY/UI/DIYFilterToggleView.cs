using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001980 RID: 6528
	[Token(Token = "0x2001980")]
	public class DIYFilterToggleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A3CA RID: 41930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3CA")]
		[Address(RVA = "0x31D9D60", Offset = "0x31D8960", VA = "0x1831D9D60")]
		private void _InitIfNot(DIYFilterModel filterModel, bool dontChangeContent)
		{
		}

		// Token: 0x0600A3CB RID: 41931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3CB")]
		[Address(RVA = "0x31DA220", Offset = "0x31D8E20", VA = "0x1831DA220")]
		private void _InitSubTypeButton(ListDict<BuildingData.FurnitureSubType, DIYFilterSubTypeModel> subtypeModels)
		{
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3CC")]
		[Address(RVA = "0x31DA900", Offset = "0x31D9500", VA = "0x1831DA900")]
		private void _OnSubTypePressed(BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x0003F8B8 File Offset: 0x0003DAB8
		[Token(Token = "0x600A3CD")]
		[Address(RVA = "0x31D9BE0", Offset = "0x31D87E0", VA = "0x1831D9BE0")]
		private float _GetTextWidth(TextGenerationSettings settings, string textContent)
		{
			return 0f;
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3CE")]
		[Address(RVA = "0x31DA980", Offset = "0x31D9580", VA = "0x1831DA980")]
		private void _OnSubTypeToggle(BuildingData.FurnitureSubType subType, bool fastMode)
		{
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3CF")]
		[Address(RVA = "0x31D99E0", Offset = "0x31D85E0", VA = "0x1831D99E0")]
		public void SetTextGenerationSettings(TextGenerationSettings settings)
		{
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D0")]
		[Address(RVA = "0x31D9AD0", Offset = "0x31D86D0", VA = "0x1831D9AD0")]
		public void SetupFilterToggle(DIYFilterModel filterModel)
		{
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D1")]
		[Address(RVA = "0x31D9740", Offset = "0x31D8340", VA = "0x1831D9740")]
		public void OnToggle(bool isSelected, bool fastMode)
		{
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D2")]
		[Address(RVA = "0x31D9580", Offset = "0x31D8180", VA = "0x1831D9580")]
		public void OnSubTypeToggle(BuildingData.FurnitureSubType subType, bool fastMode)
		{
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D3")]
		[Address(RVA = "0x31D9810", Offset = "0x31D8410", VA = "0x1831D9810")]
		public void RenderTrackPointStatus(DIYFilterModel filterModel)
		{
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D4")]
		[Address(RVA = "0x31D9500", Offset = "0x31D8100", VA = "0x1831D9500")]
		public void OnFilterTogglePressed()
		{
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D5")]
		[Address(RVA = "0x31DAB10", Offset = "0x31D9710", VA = "0x1831DAB10")]
		public DIYFilterToggleView()
		{
		}

		// Token: 0x04009A87 RID: 39559
		[Token(Token = "0x4009A87")]
		private const float TOGGLE_ICON_WIDTH = 74f;

		// Token: 0x04009A88 RID: 39560
		[Token(Token = "0x4009A88")]
		private const float TOGGLE_FOLD_WIDTH = 60f;

		// Token: 0x04009A89 RID: 39561
		[Token(Token = "0x4009A89")]
		private const float SUB_TYPE_BG_EXPAND_PADDING = 10f;

		// Token: 0x04009A8A RID: 39562
		[Token(Token = "0x4009A8A")]
		private const float PADDING_SUB_BUTTON_WIDTH = 20f;

		// Token: 0x04009A8B RID: 39563
		[Token(Token = "0x4009A8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _toggleIcon;

		// Token: 0x04009A8C RID: 39564
		[Token(Token = "0x4009A8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _toggleIconLight;

		// Token: 0x04009A8D RID: 39565
		[Token(Token = "0x4009A8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _iconAtlas;

		// Token: 0x04009A8E RID: 39566
		[Token(Token = "0x4009A8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _toggleBackGround;

		// Token: 0x04009A8F RID: 39567
		[Token(Token = "0x4009A8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _subTypeBackGround;

		// Token: 0x04009A90 RID: 39568
		[Token(Token = "0x4009A90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _toggleBgRect;

		// Token: 0x04009A91 RID: 39569
		[Token(Token = "0x4009A91")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _lightPanel;

		// Token: 0x04009A92 RID: 39570
		[Token(Token = "0x4009A92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04009A93 RID: 39571
		[Token(Token = "0x4009A93")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _selectIconColor;

		// Token: 0x04009A94 RID: 39572
		[Token(Token = "0x4009A94")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _selectBgColor;

		// Token: 0x04009A95 RID: 39573
		[Token(Token = "0x4009A95")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _selectSubTypeColor;

		// Token: 0x04009A96 RID: 39574
		[Token(Token = "0x4009A96")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _unselectIconColor;

		// Token: 0x04009A97 RID: 39575
		[Token(Token = "0x4009A97")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _unselectBgColor;

		// Token: 0x04009A98 RID: 39576
		[Token(Token = "0x4009A98")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _unselectSubTypeColor;

		// Token: 0x04009A99 RID: 39577
		[Token(Token = "0x4009A99")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _expandDuration;

		// Token: 0x04009A9A RID: 39578
		[Token(Token = "0x4009A9A")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _isFixed;

		// Token: 0x04009A9B RID: 39579
		[Token(Token = "0x4009A9B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _panelSubType;

		// Token: 0x04009A9C RID: 39580
		[Token(Token = "0x4009A9C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _subTypeContainer;

		// Token: 0x04009A9D RID: 39581
		[Token(Token = "0x4009A9D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private DIYFilterSubButton _filterSubButtonPrefab;

		// Token: 0x04009A9E RID: 39582
		[Token(Token = "0x4009A9E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x04009A9F RID: 39583
		[Token(Token = "0x4009A9F")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public Action<DIYFilterType> onFilterPressed;

		// Token: 0x04009AA0 RID: 39584
		[Token(Token = "0x4009AA0")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public Action<BuildingData.FurnitureSubType> onSubTypePressed;

		// Token: 0x04009AA1 RID: 39585
		[Token(Token = "0x4009AA1")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x04009AA2 RID: 39586
		[Token(Token = "0x4009AA2")]
		[FieldOffset(Offset = "0xF4")]
		private DIYFilterType m_filterType;

		// Token: 0x04009AA3 RID: 39587
		[Token(Token = "0x4009AA3")]
		[FieldOffset(Offset = "0xF8")]
		private List<DIYFilterSubButton> m_subButtons;

		// Token: 0x04009AA4 RID: 39588
		[Token(Token = "0x4009AA4")]
		[FieldOffset(Offset = "0x100")]
		private DIYFilterToggleView.FilterToggleSwitchTween m_filterToggleSwitchTween;

		// Token: 0x04009AA5 RID: 39589
		[Token(Token = "0x4009AA5")]
		[FieldOffset(Offset = "0x108")]
		private float m_bgExpandWidth;

		// Token: 0x04009AA6 RID: 39590
		[Token(Token = "0x4009AA6")]
		[FieldOffset(Offset = "0x10C")]
		private float m_toggleExpandWidth;

		// Token: 0x04009AA7 RID: 39591
		[Token(Token = "0x4009AA7")]
		[FieldOffset(Offset = "0x110")]
		private bool m_hasSubTypes;

		// Token: 0x04009AA8 RID: 39592
		[Token(Token = "0x4009AA8")]
		[FieldOffset(Offset = "0x118")]
		private TextGenerationSettings m_filterTextGenerationSettings;

		// Token: 0x04009AA9 RID: 39593
		[Token(Token = "0x4009AA9")]
		[FieldOffset(Offset = "0x178")]
		private TextGenerator m_cachedTextGenerator;

		// Token: 0x04009AAA RID: 39594
		[Token(Token = "0x4009AAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009AAB RID: 39595
		[Token(Token = "0x4009AAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitSubTypeButton;

		// Token: 0x04009AAC RID: 39596
		[Token(Token = "0x4009AAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSubTypePressed;

		// Token: 0x04009AAD RID: 39597
		[Token(Token = "0x4009AAD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTextWidth;

		// Token: 0x04009AAE RID: 39598
		[Token(Token = "0x4009AAE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSubTypeToggle;

		// Token: 0x04009AAF RID: 39599
		[Token(Token = "0x4009AAF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTextGenerationSettings;

		// Token: 0x04009AB0 RID: 39600
		[Token(Token = "0x4009AB0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetupFilterToggle;

		// Token: 0x04009AB1 RID: 39601
		[Token(Token = "0x4009AB1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnToggle;

		// Token: 0x04009AB2 RID: 39602
		[Token(Token = "0x4009AB2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSubTypeToggle;

		// Token: 0x04009AB3 RID: 39603
		[Token(Token = "0x4009AB3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RenderTrackPointStatus;

		// Token: 0x04009AB4 RID: 39604
		[Token(Token = "0x4009AB4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnFilterTogglePressed;

		// Token: 0x04009AB5 RID: 39605
		[Token(Token = "0x4009AB5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001981 RID: 6529
		[Token(Token = "0x2001981")]
		private class FilterToggleSwitchTween : UISwitchTween
		{
			// Token: 0x0600A3D6 RID: 41942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3D6")]
			[Address(RVA = "0x31E9ED0", Offset = "0x31E8AD0", VA = "0x1831E9ED0")]
			public FilterToggleSwitchTween(DIYFilterToggleView filterView)
			{
			}

			// Token: 0x0600A3D7 RID: 41943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A3D7")]
			[Address(RVA = "0x31E92C0", Offset = "0x31E7EC0", VA = "0x1831E92C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0600A3D8 RID: 41944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A3D8")]
			[Address(RVA = "0x31E9710", Offset = "0x31E8310", VA = "0x1831E9710", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0600A3D9 RID: 41945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3D9")]
			[Address(RVA = "0x31E9BA0", Offset = "0x31E87A0", VA = "0x1831E9BA0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0600A3DA RID: 41946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3DA")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04009AB6 RID: 39606
			[Token(Token = "0x4009AB6")]
			[FieldOffset(Offset = "0x48")]
			private DIYFilterToggleView m_closure;

			// Token: 0x04009AB7 RID: 39607
			[Token(Token = "0x4009AB7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009AB8 RID: 39608
			[Token(Token = "0x4009AB8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04009AB9 RID: 39609
			[Token(Token = "0x4009AB9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04009ABA RID: 39610
			[Token(Token = "0x4009ABA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
