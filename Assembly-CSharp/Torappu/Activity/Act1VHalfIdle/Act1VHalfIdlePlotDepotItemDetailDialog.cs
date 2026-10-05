using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007759 RID: 30553
	[Token(Token = "0x2007759")]
	public class Act1VHalfIdlePlotDepotItemDetailDialog : UICompDialog<Act1VHalfIdlePlotDepotItemDetailDialog.Option>
	{
		// Token: 0x0602AE9F RID: 175775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE9F")]
		[Address(RVA = "0x26B1E90", Offset = "0x26B0A90", VA = "0x1826B1E90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AEA0 RID: 175776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA0")]
		[Address(RVA = "0x26B2020", Offset = "0x26B0C20", VA = "0x1826B2020")]
		private void _LoadData(Act1VHalfidlePlotViewModel itemViewModel, bool selectDerivedPlot)
		{
		}

		// Token: 0x0602AEA1 RID: 175777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AEA1")]
		[Address(RVA = "0x26B1E30", Offset = "0x26B0A30", VA = "0x1826B1E30")]
		private Act1VHalfidlePlotViewModel _GetSelectedPlotViewModel()
		{
			return null;
		}

		// Token: 0x0602AEA2 RID: 175778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AEA2")]
		[Address(RVA = "0x26B1D40", Offset = "0x26B0940", VA = "0x1826B1D40")]
		private Act1VHalfidlePlotViewModel _GetPlotViewModel(string plotId)
		{
			return null;
		}

		// Token: 0x0602AEA3 RID: 175779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA3")]
		[Address(RVA = "0x26B2C40", Offset = "0x26B1840", VA = "0x1826B2C40")]
		private void _SetSelectedPlotViewModel(string plotId)
		{
		}

		// Token: 0x0602AEA4 RID: 175780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA4")]
		[Address(RVA = "0x26B25D0", Offset = "0x26B11D0", VA = "0x1826B25D0")]
		private void _RenderDerivedList()
		{
		}

		// Token: 0x0602AEA5 RID: 175781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA5")]
		[Address(RVA = "0x26B2740", Offset = "0x26B1340", VA = "0x1826B2740")]
		private void _Render()
		{
		}

		// Token: 0x0602AEA6 RID: 175782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA6")]
		[Address(RVA = "0x26B19D0", Offset = "0x26B05D0", VA = "0x1826B19D0", Slot = "18")]
		protected override void OnRender(Act1VHalfIdlePlotDepotItemDetailDialog.Option input)
		{
		}

		// Token: 0x0602AEA7 RID: 175783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA7")]
		[Address(RVA = "0x26B2350", Offset = "0x26B0F50", VA = "0x1826B2350")]
		private void _OnDeriveItemClick(string plotId)
		{
		}

		// Token: 0x0602AEA8 RID: 175784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEA8")]
		[Address(RVA = "0x26B2490", Offset = "0x26B1090", VA = "0x1826B2490")]
		private void _OnEnemyDetailClicked(List<EnemyHandBookEverViewModel> enemyHandbookViewModel)
		{
		}

		// Token: 0x0602AEA9 RID: 175785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AEA9")]
		[Address(RVA = "0x26B1750", Offset = "0x26B0350", VA = "0x1826B1750", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602AEAA RID: 175786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEAA")]
		[Address(RVA = "0x26B1680", Offset = "0x26B0280", VA = "0x1826B1680")]
		public void EventOnClose()
		{
		}

		// Token: 0x0602AEAB RID: 175787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEAB")]
		[Address(RVA = "0x26B17B0", Offset = "0x26B03B0", VA = "0x1826B17B0")]
		public void OnBtnSwitchItemLeftClicked()
		{
		}

		// Token: 0x0602AEAC RID: 175788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEAC")]
		[Address(RVA = "0x26B18B0", Offset = "0x26B04B0", VA = "0x1826B18B0")]
		public void OnBtnSwitchItemRightClicked()
		{
		}

		// Token: 0x0602AEAD RID: 175789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEAD")]
		[Address(RVA = "0x26B2D10", Offset = "0x26B1910", VA = "0x1826B2D10")]
		public Act1VHalfIdlePlotDepotItemDetailDialog()
		{
		}

		// Token: 0x0602AEAE RID: 175790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AEAE")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403DE4F RID: 253519
		[Token(Token = "0x403DE4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurImage;

		// Token: 0x0403DE50 RID: 253520
		[Token(Token = "0x403DE50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403DE51 RID: 253521
		[Token(Token = "0x403DE51")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0403DE52 RID: 253522
		[Token(Token = "0x403DE52")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x0403DE53 RID: 253523
		[Token(Token = "0x403DE53")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _plotIcon;

		// Token: 0x0403DE54 RID: 253524
		[Token(Token = "0x403DE54")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _baseInfo;

		// Token: 0x0403DE55 RID: 253525
		[Token(Token = "0x403DE55")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _baseDesc;

		// Token: 0x0403DE56 RID: 253526
		[Token(Token = "0x403DE56")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Act1VHalfIdlePlotDepotDeriveItemView _basePlotItemView;

		// Token: 0x0403DE57 RID: 253527
		[Token(Token = "0x403DE57")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SimpleLayoutContent _derivedPlotList;

		// Token: 0x0403DE58 RID: 253528
		[Token(Token = "0x403DE58")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _pnlDerivedPlot;

		// Token: 0x0403DE59 RID: 253529
		[Token(Token = "0x403DE59")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Act1VHalfIdlePlotCombineView _plotCombineView;

		// Token: 0x0403DE5A RID: 253530
		[Token(Token = "0x403DE5A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Act1VHalfIdlePlotEnemyInfoView _enemyInfoView;

		// Token: 0x0403DE5B RID: 253531
		[Token(Token = "0x403DE5B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Act1VHalfIdlePlotProductionView _productionView;

		// Token: 0x0403DE5C RID: 253532
		[Token(Token = "0x403DE5C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _reciptDecoImg;

		// Token: 0x0403DE5D RID: 253533
		[Token(Token = "0x403DE5D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _pnlArrowLeft;

		// Token: 0x0403DE5E RID: 253534
		[Token(Token = "0x403DE5E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _pnlArrowRight;

		// Token: 0x0403DE5F RID: 253535
		[Token(Token = "0x403DE5F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x0403DE60 RID: 253536
		[Token(Token = "0x403DE60")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_inited;

		// Token: 0x0403DE61 RID: 253537
		[Token(Token = "0x403DE61")]
		[FieldOffset(Offset = "0x100")]
		private string m_actId;

		// Token: 0x0403DE62 RID: 253538
		[Token(Token = "0x403DE62")]
		[FieldOffset(Offset = "0x108")]
		private bool m_selectDerivedPlot;

		// Token: 0x0403DE63 RID: 253539
		[Token(Token = "0x403DE63")]
		[FieldOffset(Offset = "0x110")]
		private List<Act1VHalfidlePlotViewModel> m_cachedAllItemViewModels;

		// Token: 0x0403DE64 RID: 253540
		[Token(Token = "0x403DE64")]
		[FieldOffset(Offset = "0x118")]
		private int m_selectedIndex;

		// Token: 0x0403DE65 RID: 253541
		[Token(Token = "0x403DE65")]
		[FieldOffset(Offset = "0x120")]
		private Act1VHalfidlePlotViewModel m_viewModel;

		// Token: 0x0403DE66 RID: 253542
		[Token(Token = "0x403DE66")]
		[FieldOffset(Offset = "0x128")]
		private ListDict<string, Act1VHalfidlePlotViewModel> m_derivedViewModelList;

		// Token: 0x0403DE67 RID: 253543
		[Token(Token = "0x403DE67")]
		[FieldOffset(Offset = "0x130")]
		private string m_selectedPlotId;

		// Token: 0x0403DE68 RID: 253544
		[Token(Token = "0x403DE68")]
		[FieldOffset(Offset = "0x138")]
		private Act1VHalfIdlePlotDepotItemDetailDialog.Adapter m_derivedPlotListAdapter;

		// Token: 0x0403DE69 RID: 253545
		[Token(Token = "0x403DE69")]
		[FieldOffset(Offset = "0x140")]
		private string m_cachedPlotId;

		// Token: 0x0403DE6A RID: 253546
		[Token(Token = "0x403DE6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DE6B RID: 253547
		[Token(Token = "0x403DE6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0403DE6C RID: 253548
		[Token(Token = "0x403DE6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSelectedPlotViewModel;

		// Token: 0x0403DE6D RID: 253549
		[Token(Token = "0x403DE6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPlotViewModel;

		// Token: 0x0403DE6E RID: 253550
		[Token(Token = "0x403DE6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetSelectedPlotViewModel;

		// Token: 0x0403DE6F RID: 253551
		[Token(Token = "0x403DE6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderDerivedList;

		// Token: 0x0403DE70 RID: 253552
		[Token(Token = "0x403DE70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403DE71 RID: 253553
		[Token(Token = "0x403DE71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403DE72 RID: 253554
		[Token(Token = "0x403DE72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnDeriveItemClick;

		// Token: 0x0403DE73 RID: 253555
		[Token(Token = "0x403DE73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnEnemyDetailClicked;

		// Token: 0x0403DE74 RID: 253556
		[Token(Token = "0x403DE74")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403DE75 RID: 253557
		[Token(Token = "0x403DE75")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0403DE76 RID: 253558
		[Token(Token = "0x403DE76")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnSwitchItemLeftClicked;

		// Token: 0x0403DE77 RID: 253559
		[Token(Token = "0x403DE77")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBtnSwitchItemRightClicked;

		// Token: 0x0403DE78 RID: 253560
		[Token(Token = "0x403DE78")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200775A RID: 30554
		[Token(Token = "0x200775A")]
		public class Option
		{
			// Token: 0x0602AEAF RID: 175791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AEAF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403DE79 RID: 253561
			[Token(Token = "0x403DE79")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfidlePlotViewModel itemViewModel;

			// Token: 0x0403DE7A RID: 253562
			[Token(Token = "0x403DE7A")]
			[FieldOffset(Offset = "0x18")]
			public List<Act1VHalfidlePlotViewModel> itemViewModels;

			// Token: 0x0403DE7B RID: 253563
			[Token(Token = "0x403DE7B")]
			[FieldOffset(Offset = "0x20")]
			public bool selectDerivedPlot;
		}

		// Token: 0x0200775B RID: 30555
		[Token(Token = "0x200775B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602AEB0 RID: 175792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AEB0")]
			[Address(RVA = "0x26C1FF0", Offset = "0x26C0BF0", VA = "0x1826C1FF0")]
			public Adapter(Act1VHalfIdlePlotDepotItemDetailDialog closure)
			{
			}

			// Token: 0x170064A5 RID: 25765
			// (get) Token: 0x0602AEB1 RID: 175793 RVA: 0x000DA6A0 File Offset: 0x000D88A0
			[Token(Token = "0x170064A5")]
			public override int count
			{
				[Token(Token = "0x602AEB1")]
				[Address(RVA = "0x26C2170", Offset = "0x26C0D70", VA = "0x1826C2170", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602AEB2 RID: 175794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AEB2")]
			[Address(RVA = "0x26C1DC0", Offset = "0x26C09C0", VA = "0x1826C1DC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403DE7C RID: 253564
			[Token(Token = "0x403DE7C")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdlePlotDepotItemDetailDialog m_closure;

			// Token: 0x0403DE7D RID: 253565
			[Token(Token = "0x403DE7D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DE7E RID: 253566
			[Token(Token = "0x403DE7E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403DE7F RID: 253567
			[Token(Token = "0x403DE7F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
