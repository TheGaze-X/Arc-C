using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001989 RID: 6537
	[Token(Token = "0x2001989")]
	public class DIYFurniturePanelSort : DataBinder<DIYSortMethodViewProperty>
	{
		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3FA RID: 41978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012F8")]
		public DIYListViewState bindState
		{
			[Token(Token = "0x600A3F9")]
			[Address(RVA = "0x31DC4A0", Offset = "0x31DB0A0", VA = "0x1831DC4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A3FA")]
			[Address(RVA = "0x31DC510", Offset = "0x31DB110", VA = "0x1831DC510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FB")]
		[Address(RVA = "0x31DBF70", Offset = "0x31DAB70", VA = "0x1831DBF70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FC")]
		[Address(RVA = "0x31DC190", Offset = "0x31DAD90", VA = "0x1831DC190")]
		private void _ResetPositionBeforeShow()
		{
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FD")]
		[Address(RVA = "0x31DBC50", Offset = "0x31DA850", VA = "0x1831DBC50", Slot = "7")]
		public override void OnValueChanged(DIYSortMethodViewProperty property)
		{
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FE")]
		[Address(RVA = "0x31DBD40", Offset = "0x31DA940", VA = "0x1831DBD40")]
		public void SetExpandListState(bool isExpand)
		{
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FF")]
		[Address(RVA = "0x31DBDF0", Offset = "0x31DA9F0", VA = "0x1831DBDF0")]
		public void SetShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A400")]
		[Address(RVA = "0x31DBEF0", Offset = "0x31DAAF0", VA = "0x1831DBEF0")]
		public void Toggle()
		{
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A401")]
		[Address(RVA = "0x31DBB40", Offset = "0x31DA740", VA = "0x1831DBB40")]
		public void EventOnClicked(BuildingData.DiySortType diyUIType, int index)
		{
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A402")]
		[Address(RVA = "0x31DC410", Offset = "0x31DB010", VA = "0x1831DC410")]
		public DIYFurniturePanelSort()
		{
		}

		// Token: 0x04009AE5 RID: 39653
		[Token(Token = "0x4009AE5")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 FLOAT_PANEL_PIVOT_NORMAL;

		// Token: 0x04009AE6 RID: 39654
		[Token(Token = "0x4009AE6")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 FLOAT_PANEL_PIVOT_EXPAND;

		// Token: 0x04009AE7 RID: 39655
		[Token(Token = "0x4009AE7")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 FLOAT_PANEL_ANCHORED_POS_NORMAL;

		// Token: 0x04009AE8 RID: 39656
		[Token(Token = "0x4009AE8")]
		[FieldOffset(Offset = "0x18")]
		private static Vector2 FLOAT_PANEL_ANCHORED_POS_EXPAND;

		// Token: 0x04009AE9 RID: 39657
		[Token(Token = "0x4009AE9")]
		private const float SHOW_DURATION = 0.16f;

		// Token: 0x04009AEA RID: 39658
		[Token(Token = "0x4009AEA")]
		private const int SHOW_OFFSET_Y = 18;

		// Token: 0x04009AEB RID: 39659
		[Token(Token = "0x4009AEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _pnlList;

		// Token: 0x04009AEC RID: 39660
		[Token(Token = "0x4009AEC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlBkg;

		// Token: 0x04009AEE RID: 39662
		[Token(Token = "0x4009AEE")]
		[FieldOffset(Offset = "0x38")]
		private DIYSortMethodViewModel m_cachedModel;

		// Token: 0x04009AEF RID: 39663
		[Token(Token = "0x4009AEF")]
		[FieldOffset(Offset = "0x40")]
		private DIYFurniturePanelSort.ShowSwitchTween m_switchTween;

		// Token: 0x04009AF0 RID: 39664
		[Token(Token = "0x4009AF0")]
		[FieldOffset(Offset = "0x48")]
		private DIYFurniturePanelSort.Adapter m_listAdapter;

		// Token: 0x04009AF1 RID: 39665
		[Token(Token = "0x4009AF1")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04009AF2 RID: 39666
		[Token(Token = "0x4009AF2")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isShow;

		// Token: 0x04009AF3 RID: 39667
		[Token(Token = "0x4009AF3")]
		[FieldOffset(Offset = "0x52")]
		private bool m_isExpand;

		// Token: 0x04009AF4 RID: 39668
		[Token(Token = "0x4009AF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x04009AF5 RID: 39669
		[Token(Token = "0x4009AF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x04009AF6 RID: 39670
		[Token(Token = "0x4009AF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009AF7 RID: 39671
		[Token(Token = "0x4009AF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetPositionBeforeShow;

		// Token: 0x04009AF8 RID: 39672
		[Token(Token = "0x4009AF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009AF9 RID: 39673
		[Token(Token = "0x4009AF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetExpandListState;

		// Token: 0x04009AFA RID: 39674
		[Token(Token = "0x4009AFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x04009AFB RID: 39675
		[Token(Token = "0x4009AFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Toggle;

		// Token: 0x04009AFC RID: 39676
		[Token(Token = "0x4009AFC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04009AFD RID: 39677
		[Token(Token = "0x4009AFD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200198A RID: 6538
		[Token(Token = "0x200198A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0600A404 RID: 41988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A404")]
			[Address(RVA = "0x31D6230", Offset = "0x31D4E30", VA = "0x1831D6230")]
			public Adapter(DIYFurniturePanelSort closure)
			{
			}

			// Token: 0x170012F9 RID: 4857
			// (get) Token: 0x0600A405 RID: 41989 RVA: 0x0003F900 File Offset: 0x0003DB00
			[Token(Token = "0x170012F9")]
			public override int count
			{
				[Token(Token = "0x600A405")]
				[Address(RVA = "0x31D62B0", Offset = "0x31D4EB0", VA = "0x1831D62B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600A406 RID: 41990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A406")]
			[Address(RVA = "0x31D6000", Offset = "0x31D4C00", VA = "0x1831D6000", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04009AFE RID: 39678
			[Token(Token = "0x4009AFE")]
			[FieldOffset(Offset = "0x20")]
			private DIYFurniturePanelSort m_closure;

			// Token: 0x04009AFF RID: 39679
			[Token(Token = "0x4009AFF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009B00 RID: 39680
			[Token(Token = "0x4009B00")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04009B01 RID: 39681
			[Token(Token = "0x4009B01")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200198B RID: 6539
		[Token(Token = "0x200198B")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0600A407 RID: 41991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A407")]
			[Address(RVA = "0x31EA420", Offset = "0x31E9020", VA = "0x1831EA420")]
			public ShowSwitchTween(DIYFurniturePanelSort closure)
			{
			}

			// Token: 0x0600A408 RID: 41992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A408")]
			[Address(RVA = "0x31EA0F0", Offset = "0x31E8CF0", VA = "0x1831EA0F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0600A409 RID: 41993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A409")]
			[Address(RVA = "0x31EA240", Offset = "0x31E8E40", VA = "0x1831EA240", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0600A40A RID: 41994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A40A")]
			[Address(RVA = "0x31E9FE0", Offset = "0x31E8BE0", VA = "0x1831E9FE0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0600A40B RID: 41995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A40B")]
			[Address(RVA = "0x31EA060", Offset = "0x31E8C60", VA = "0x1831EA060", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0600A40C RID: 41996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A40C")]
			[Address(RVA = "0x31EA370", Offset = "0x31E8F70", VA = "0x1831EA370", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0600A40D RID: 41997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A40D")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0600A40E RID: 41998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A40E")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0600A40F RID: 41999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A40F")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04009B02 RID: 39682
			[Token(Token = "0x4009B02")]
			[FieldOffset(Offset = "0x48")]
			private DIYFurniturePanelSort m_closure;

			// Token: 0x04009B03 RID: 39683
			[Token(Token = "0x4009B03")]
			[FieldOffset(Offset = "0x50")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x04009B04 RID: 39684
			[Token(Token = "0x4009B04")]
			[FieldOffset(Offset = "0x58")]
			private RectTransform m_rectTransform;

			// Token: 0x04009B05 RID: 39685
			[Token(Token = "0x4009B05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009B06 RID: 39686
			[Token(Token = "0x4009B06")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04009B07 RID: 39687
			[Token(Token = "0x4009B07")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04009B08 RID: 39688
			[Token(Token = "0x4009B08")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04009B09 RID: 39689
			[Token(Token = "0x4009B09")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04009B0A RID: 39690
			[Token(Token = "0x4009B0A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
