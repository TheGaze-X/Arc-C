using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019CA RID: 6602
	[Token(Token = "0x20019CA")]
	public class DIYListViewState : DIYPopupState
	{
		// Token: 0x0600A5C0 RID: 42432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5C0")]
		[Address(RVA = "0x31F16A0", Offset = "0x31F02A0", VA = "0x1831F16A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C1")]
		[Address(RVA = "0x31F1700", Offset = "0x31F0300", VA = "0x1831F1700", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x00040278 File Offset: 0x0003E478
		[Token(Token = "0x600A5C2")]
		[Address(RVA = "0x31F1DC0", Offset = "0x31F09C0", VA = "0x1831F1DC0")]
		private bool _OnInfoButtonPressed(DIYItemViewData data)
		{
			return default(bool);
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C3")]
		[Address(RVA = "0x31F1940", Offset = "0x31F0540", VA = "0x1831F1940")]
		public void OnFilterPressed(DIYFilterType filterType)
		{
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C4")]
		[Address(RVA = "0x31F1B90", Offset = "0x31F0790", VA = "0x1831F1B90")]
		public void OnSubTypePressed(BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C5")]
		[Address(RVA = "0x31F1860", Offset = "0x31F0460", VA = "0x1831F1860")]
		public void OnExpandPressed()
		{
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C6")]
		[Address(RVA = "0x31F1A80", Offset = "0x31F0680", VA = "0x1831F1A80")]
		public void OnListViewBackButtonPressed()
		{
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C7")]
		[Address(RVA = "0x31F1CD0", Offset = "0x31F08D0", VA = "0x1831F1CD0")]
		public void OnThemeQuickSetup()
		{
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C8")]
		[Address(RVA = "0x31F1560", Offset = "0x31F0160", VA = "0x1831F1560")]
		public void EventOnSortPanelItemClicked(BuildingData.DiySortType diyUIType, int index)
		{
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C9")]
		[Address(RVA = "0x31F2380", Offset = "0x31F0F80", VA = "0x1831F2380")]
		public DIYListViewState()
		{
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5CA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04009D87 RID: 40327
		[Token(Token = "0x4009D87")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected DIYListViewStateBean _stateBean;

		// Token: 0x04009D88 RID: 40328
		[Token(Token = "0x4009D88")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DIYFurnitureDetailPanel _furnitureDetailPanel;

		// Token: 0x04009D89 RID: 40329
		[Token(Token = "0x4009D89")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DIYFurnitureExpandViewList _expandViewList;

		// Token: 0x04009D8A RID: 40330
		[Token(Token = "0x4009D8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009D8B RID: 40331
		[Token(Token = "0x4009D8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009D8C RID: 40332
		[Token(Token = "0x4009D8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnInfoButtonPressed;

		// Token: 0x04009D8D RID: 40333
		[Token(Token = "0x4009D8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFilterPressed;

		// Token: 0x04009D8E RID: 40334
		[Token(Token = "0x4009D8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSubTypePressed;

		// Token: 0x04009D8F RID: 40335
		[Token(Token = "0x4009D8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExpandPressed;

		// Token: 0x04009D90 RID: 40336
		[Token(Token = "0x4009D90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnListViewBackButtonPressed;

		// Token: 0x04009D91 RID: 40337
		[Token(Token = "0x4009D91")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnThemeQuickSetup;

		// Token: 0x04009D92 RID: 40338
		[Token(Token = "0x4009D92")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnSortPanelItemClicked;

		// Token: 0x04009D93 RID: 40339
		[Token(Token = "0x4009D93")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
