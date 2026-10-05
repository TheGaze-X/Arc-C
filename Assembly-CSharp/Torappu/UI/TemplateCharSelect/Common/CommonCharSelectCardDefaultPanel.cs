using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C06 RID: 23558
	[Token(Token = "0x2005C06")]
	public class CommonCharSelectCardDefaultPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x06022255 RID: 139861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FF6")]
		public Graphic graphic
		{
			[Token(Token = "0x6022255")]
			[Address(RVA = "0x1C862A0", Offset = "0x1C84EA0", VA = "0x181C862A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022256 RID: 139862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022256")]
		[Address(RVA = "0x1C85900", Offset = "0x1C84500", VA = "0x181C85900")]
		public void DoRender(TemplateCharSelectCardViewModel viewModel, CommonCharSelectCardDefaultPanel.Options options)
		{
		}

		// Token: 0x06022257 RID: 139863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022257")]
		[Address(RVA = "0x1C85D40", Offset = "0x1C84940", VA = "0x181C85D40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022258 RID: 139864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022258")]
		[Address(RVA = "0x1C85F60", Offset = "0x1C84B60", VA = "0x181C85F60")]
		private void _UpdateViewData(CommonCharSelectCardDefaultViewModel viewModel, CommonCharSelectCardDefaultPanel.Options options)
		{
		}

		// Token: 0x06022259 RID: 139865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022259")]
		[Address(RVA = "0x1C85E30", Offset = "0x1C84A30", VA = "0x181C85E30")]
		private void _RenderSelectPanel(bool selected, int selectIndex)
		{
		}

		// Token: 0x0602225A RID: 139866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602225A")]
		[Address(RVA = "0x1C86230", Offset = "0x1C84E30", VA = "0x181C86230")]
		public CommonCharSelectCardDefaultPanel()
		{
		}

		// Token: 0x0402ED13 RID: 191763
		[Token(Token = "0x402ED13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402ED14 RID: 191764
		[Token(Token = "0x402ED14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardRoot;

		// Token: 0x0402ED15 RID: 191765
		[Token(Token = "0x402ED15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _cardScale;

		// Token: 0x0402ED16 RID: 191766
		[Token(Token = "0x402ED16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CommonCharCardView _cardAsset;

		// Token: 0x0402ED17 RID: 191767
		[Token(Token = "0x402ED17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Select")]
		private GameObject _selectedPanel;

		// Token: 0x0402ED18 RID: 191768
		[Token(Token = "0x402ED18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Select")]
		private Text _selectedIndex;

		// Token: 0x0402ED19 RID: 191769
		[Token(Token = "0x402ED19")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CommonCharSelectCardPanelPlugin[] _plugins;

		// Token: 0x0402ED1A RID: 191770
		[Token(Token = "0x402ED1A")]
		[FieldOffset(Offset = "0x50")]
		private CommonCharCardView m_cardView;

		// Token: 0x0402ED1B RID: 191771
		[Token(Token = "0x402ED1B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0402ED1C RID: 191772
		[Token(Token = "0x402ED1C")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402ED1D RID: 191773
		[Token(Token = "0x402ED1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402ED1E RID: 191774
		[Token(Token = "0x402ED1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402ED1F RID: 191775
		[Token(Token = "0x402ED1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402ED20 RID: 191776
		[Token(Token = "0x402ED20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateViewData;

		// Token: 0x0402ED21 RID: 191777
		[Token(Token = "0x402ED21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSelectPanel;

		// Token: 0x0402ED22 RID: 191778
		[Token(Token = "0x402ED22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C07 RID: 23559
		[Token(Token = "0x2005C07")]
		public struct Options
		{
			// Token: 0x0402ED23 RID: 191779
			[Token(Token = "0x402ED23")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CommonCharSelectCardDefaultPanel.Options DEFAULT;

			// Token: 0x0402ED24 RID: 191780
			[Token(Token = "0x402ED24")]
			[FieldOffset(Offset = "0x0")]
			public string pageName;

			// Token: 0x0402ED25 RID: 191781
			[Token(Token = "0x402ED25")]
			[FieldOffset(Offset = "0x8")]
			public string actId;
		}
	}
}
