using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C87 RID: 7303
	[Token(Token = "0x2001C87")]
	public class BuildingStationSelectCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D3")]
		private FadeSwitchTween securedFadeSwitch
		{
			[Token(Token = "0x600B562")]
			[Address(RVA = "0x32F1D00", Offset = "0x32F0900", VA = "0x1832F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B563")]
		[Address(RVA = "0x32F1780", Offset = "0x32F0380", VA = "0x1832F1780")]
		public void SetSelectionInfo(bool isSelected, int selectIndex, int maxSelectCount)
		{
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B564")]
		[Address(RVA = "0x32F1420", Offset = "0x32F0020", VA = "0x1832F1420")]
		public void Render(StationCharViewModel viewModel, CharSortType sortType, StationSelectStateBean.StationSelectStateBeanInputType selectType)
		{
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B565")]
		[Address(RVA = "0x32F1310", Offset = "0x32EFF10", VA = "0x1832F1310")]
		public void RenderSelectPlugin(BuildingStationSelectMaskPlugin maskPluginPrefab, StationSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B566")]
		[Address(RVA = "0x32F18B0", Offset = "0x32F04B0", VA = "0x1832F18B0")]
		private void _InitIfNot(StationCharViewModel viewModel)
		{
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B567")]
		[Address(RVA = "0x32F1C10", Offset = "0x32F0810", VA = "0x1832F1C10")]
		private void _OnCardClick(int _)
		{
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B568")]
		[Address(RVA = "0x32F19F0", Offset = "0x32F05F0", VA = "0x1832F19F0")]
		private void _InitSelectPluginIfNot(BuildingStationSelectMaskPlugin prefab, StationSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x0600B569 RID: 46441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B569")]
		[Address(RVA = "0x32F1C90", Offset = "0x32F0890", VA = "0x1832F1C90")]
		public BuildingStationSelectCharItemView()
		{
		}

		// Token: 0x0400B199 RID: 45465
		[Token(Token = "0x400B199")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingStationSelectCharCard _cardPrefab;

		// Token: 0x0400B19A RID: 45466
		[Token(Token = "0x400B19A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x0400B19B RID: 45467
		[Token(Token = "0x400B19B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSelectIndex;

		// Token: 0x0400B19C RID: 45468
		[Token(Token = "0x400B19C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _panelSelected;

		// Token: 0x0400B19D RID: 45469
		[Token(Token = "0x400B19D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _selectedMaskTypeTag;

		// Token: 0x0400B19E RID: 45470
		[Token(Token = "0x400B19E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _pluginContainer;

		// Token: 0x0400B19F RID: 45471
		[Token(Token = "0x400B19F")]
		[FieldOffset(Offset = "0x48")]
		private BuildingStationSelectCharCard m_cardPanel;

		// Token: 0x0400B1A0 RID: 45472
		[Token(Token = "0x400B1A0")]
		[FieldOffset(Offset = "0x50")]
		private StationCharViewModel m_viewModel;

		// Token: 0x0400B1A1 RID: 45473
		[Token(Token = "0x400B1A1")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400B1A2 RID: 45474
		[Token(Token = "0x400B1A2")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x0400B1A3 RID: 45475
		[Token(Token = "0x400B1A3")]
		[FieldOffset(Offset = "0x68")]
		private int m_lastInst;

		// Token: 0x0400B1A4 RID: 45476
		[Token(Token = "0x400B1A4")]
		[FieldOffset(Offset = "0x6C")]
		private int m_selectPluginPrefabId;

		// Token: 0x0400B1A5 RID: 45477
		[Token(Token = "0x400B1A5")]
		[FieldOffset(Offset = "0x70")]
		private BuildingStationSelectMaskPlugin m_selectPluginInst;

		// Token: 0x0400B1A6 RID: 45478
		[Token(Token = "0x400B1A6")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<StationCharViewModel> onCharClicked;

		// Token: 0x0400B1A7 RID: 45479
		[Token(Token = "0x400B1A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_securedFadeSwitch;

		// Token: 0x0400B1A8 RID: 45480
		[Token(Token = "0x400B1A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectionInfo;

		// Token: 0x0400B1A9 RID: 45481
		[Token(Token = "0x400B1A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B1AA RID: 45482
		[Token(Token = "0x400B1AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelectPlugin;

		// Token: 0x0400B1AB RID: 45483
		[Token(Token = "0x400B1AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B1AC RID: 45484
		[Token(Token = "0x400B1AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCardClick;

		// Token: 0x0400B1AD RID: 45485
		[Token(Token = "0x400B1AD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitSelectPluginIfNot;

		// Token: 0x0400B1AE RID: 45486
		[Token(Token = "0x400B1AE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
