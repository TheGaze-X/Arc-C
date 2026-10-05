using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006996 RID: 27030
	[Token(Token = "0x2006996")]
	public class StageTrainingButtonOnMap : StageButtonOnMap
	{
		// Token: 0x06026ACD RID: 158413 RVA: 0x000CBFB8 File Offset: 0x000CA1B8
		[Token(Token = "0x6026ACD")]
		[Address(RVA = "0x21BCD80", Offset = "0x21BB980", VA = "0x1821BCD80", Slot = "5")]
		protected override bool TryLockStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
			return default(bool);
		}

		// Token: 0x06026ACE RID: 158414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ACE")]
		[Address(RVA = "0x21BCA20", Offset = "0x21BB620", VA = "0x1821BCA20", Slot = "8")]
		public override void RenderStage(StageButtonOnMapHolder rawHolder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x06026ACF RID: 158415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ACF")]
		[Address(RVA = "0x21BD160", Offset = "0x21BBD60", VA = "0x1821BD160")]
		private void _RenderMain(StageTrainingButtonHolder holder)
		{
		}

		// Token: 0x06026AD0 RID: 158416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AD0")]
		[Address(RVA = "0x21BD3E0", Offset = "0x21BBFE0", VA = "0x1821BD3E0")]
		private void _RenderRewards(StageViewModel viewModel)
		{
		}

		// Token: 0x06026AD1 RID: 158417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AD1")]
		[Address(RVA = "0x21BCE30", Offset = "0x21BBA30", VA = "0x1821BCE30")]
		private UIItemCard _CreateItemCard(RectTransform container)
		{
			return null;
		}

		// Token: 0x06026AD2 RID: 158418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AD2")]
		[Address(RVA = "0x21BCFA0", Offset = "0x21BBBA0", VA = "0x1821BCFA0")]
		private string _ParseChainedLockedStr(string stageId)
		{
			return null;
		}

		// Token: 0x06026AD3 RID: 158419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AD3")]
		[Address(RVA = "0x21BD780", Offset = "0x21BC380", VA = "0x1821BD780")]
		public StageTrainingButtonOnMap()
		{
		}

		// Token: 0x06026AD4 RID: 158420 RVA: 0x000CBFD0 File Offset: 0x000CA1D0
		[Token(Token = "0x6026AD4")]
		[Address(RVA = "0x21BCE10", Offset = "0x21BBA10", VA = "0x1821BCE10")]
		private bool <>xLuaBaseProxy_TryLockStage(StageButtonOnMapHolder P0, StageViewModel P1, ZoneViewModel P2, bool P3)
		{
			return default(bool);
		}

		// Token: 0x06026AD5 RID: 158421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AD5")]
		[Address(RVA = "0x20FCE20", Offset = "0x20FBA20", VA = "0x1820FCE20")]
		private void <>xLuaBaseProxy_RenderStage(StageButtonOnMapHolder P0, StageViewModel P1, ZoneViewModel P2, bool P3)
		{
		}

		// Token: 0x04036993 RID: 223635
		[Token(Token = "0x4036993")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x04036994 RID: 223636
		[Token(Token = "0x4036994")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _panelChainedLock;

		// Token: 0x04036995 RID: 223637
		[Token(Token = "0x4036995")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _textChainedLock;

		// Token: 0x04036996 RID: 223638
		[Token(Token = "0x4036996")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _panelSingleLock;

		// Token: 0x04036997 RID: 223639
		[Token(Token = "0x4036997")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Rewards")]
		private float _itemScaler;

		// Token: 0x04036998 RID: 223640
		[Token(Token = "0x4036998")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Rewards")]
		private RectTransform _itemCardSlotMain;

		// Token: 0x04036999 RID: 223641
		[Token(Token = "0x4036999")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Rewards")]
		private RectTransform _itemCardSlotSub;

		// Token: 0x0403699A RID: 223642
		[Token(Token = "0x403699A")]
		[FieldOffset(Offset = "0x110")]
		private StageTrainingButtonOnMap.ViewModelCache m_cache;

		// Token: 0x0403699B RID: 223643
		[Token(Token = "0x403699B")]
		[FieldOffset(Offset = "0x113")]
		private bool m_isinited;

		// Token: 0x0403699C RID: 223644
		[Token(Token = "0x403699C")]
		[FieldOffset(Offset = "0x118")]
		private UIItemCard m_itemCardMain;

		// Token: 0x0403699D RID: 223645
		[Token(Token = "0x403699D")]
		[FieldOffset(Offset = "0x120")]
		private UIItemCard m_itemCardSub;

		// Token: 0x0403699E RID: 223646
		[Token(Token = "0x403699E")]
		[FieldOffset(Offset = "0x128")]
		private UIItemViewModel m_diamondViewModel;

		// Token: 0x0403699F RID: 223647
		[Token(Token = "0x403699F")]
		[FieldOffset(Offset = "0x130")]
		private UIItemViewModel m_charViewModel;

		// Token: 0x040369A0 RID: 223648
		[Token(Token = "0x40369A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryLockStage;

		// Token: 0x040369A1 RID: 223649
		[Token(Token = "0x40369A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x040369A2 RID: 223650
		[Token(Token = "0x40369A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderMain;

		// Token: 0x040369A3 RID: 223651
		[Token(Token = "0x40369A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderRewards;

		// Token: 0x040369A4 RID: 223652
		[Token(Token = "0x40369A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateItemCard;

		// Token: 0x040369A5 RID: 223653
		[Token(Token = "0x40369A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ParseChainedLockedStr;

		// Token: 0x040369A6 RID: 223654
		[Token(Token = "0x40369A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006997 RID: 27031
		[Token(Token = "0x2006997")]
		private struct ViewModelCache
		{
			// Token: 0x06026AD6 RID: 158422 RVA: 0x000CBFE8 File Offset: 0x000CA1E8
			[Token(Token = "0x6026AD6")]
			[Address(RVA = "0x21D1A10", Offset = "0x21D0610", VA = "0x1821D1A10")]
			public static StageTrainingButtonOnMap.ViewModelCache Create(StageTrainingButtonHolder holder, StageViewModel viewModel)
			{
				return default(StageTrainingButtonOnMap.ViewModelCache);
			}

			// Token: 0x040369A7 RID: 223655
			[Token(Token = "0x40369A7")]
			[FieldOffset(Offset = "0x0")]
			public bool isUnlocked;

			// Token: 0x040369A8 RID: 223656
			[Token(Token = "0x40369A8")]
			[FieldOffset(Offset = "0x1")]
			public bool isChainedLocked;

			// Token: 0x040369A9 RID: 223657
			[Token(Token = "0x40369A9")]
			[FieldOffset(Offset = "0x2")]
			public bool isSingleLocked;
		}
	}
}
