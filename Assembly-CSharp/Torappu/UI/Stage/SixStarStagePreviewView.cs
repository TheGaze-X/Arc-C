using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006835 RID: 26677
	[Token(Token = "0x2006835")]
	public class SixStarStagePreviewView : StagePreviewInfoBasicPanel
	{
		// Token: 0x0602633E RID: 156478 RVA: 0x000CA578 File Offset: 0x000C8778
		[Token(Token = "0x602633E")]
		[Address(RVA = "0x214ED00", Offset = "0x214D900", VA = "0x18214ED00", Slot = "6")]
		protected override bool OnZoneViewChanged(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x0602633F RID: 156479 RVA: 0x000CA590 File Offset: 0x000C8790
		[Token(Token = "0x602633F")]
		[Address(RVA = "0x214F0D0", Offset = "0x214DCD0", VA = "0x18214F0D0", Slot = "7")]
		protected override bool SelectStageViewModel(IStageSelectHandler zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06026340 RID: 156480 RVA: 0x000CA5A8 File Offset: 0x000C87A8
		[Token(Token = "0x6026340")]
		[Address(RVA = "0x214E9E0", Offset = "0x214D5E0", VA = "0x18214E9E0", Slot = "8")]
		protected override bool CheckToShow(IStageSelectHandler zoneModel)
		{
			return default(bool);
		}

		// Token: 0x06026341 RID: 156481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026341")]
		[Address(RVA = "0x214F270", Offset = "0x214DE70", VA = "0x18214F270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026342 RID: 156482 RVA: 0x000CA5C0 File Offset: 0x000C87C0
		[Token(Token = "0x6026342")]
		[Address(RVA = "0x214F1B0", Offset = "0x214DDB0", VA = "0x18214F1B0")]
		private bool _CheckIfNeedRuneSelect(StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06026343 RID: 156483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026343")]
		[Address(RVA = "0x214F4A0", Offset = "0x214E0A0", VA = "0x18214F4A0")]
		private void _RaiseTutorialSignal()
		{
		}

		// Token: 0x06026344 RID: 156484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026344")]
		[Address(RVA = "0x214EB00", Offset = "0x214D700", VA = "0x18214EB00")]
		public void OnRewardGroupBtnClick()
		{
		}

		// Token: 0x06026345 RID: 156485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026345")]
		[Address(RVA = "0x214EB90", Offset = "0x214D790", VA = "0x18214EB90")]
		public void OnSixStarStartBattleBtnClick()
		{
		}

		// Token: 0x06026346 RID: 156486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026346")]
		[Address(RVA = "0x214F500", Offset = "0x214E100", VA = "0x18214F500")]
		public SixStarStagePreviewView()
		{
		}

		// Token: 0x06026347 RID: 156487 RVA: 0x000CA5D8 File Offset: 0x000C87D8
		[Token(Token = "0x6026347")]
		[Address(RVA = "0x214F1A0", Offset = "0x214DDA0", VA = "0x18214F1A0")]
		private bool <>xLuaBaseProxy_OnZoneViewChanged(IStageSelectHandler P0, StageViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x04035D5C RID: 220508
		[Token(Token = "0x4035D5C")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private SixStarStagePreviewRankView _rankView;

		// Token: 0x04035D5D RID: 220509
		[Token(Token = "0x4035D5D")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private SixStarStagePreviewRuneBarView _runeBarView;

		// Token: 0x04035D5E RID: 220510
		[Token(Token = "0x4035D5E")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GameObject _panelRewardGroup;

		// Token: 0x04035D5F RID: 220511
		[Token(Token = "0x4035D5F")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private SimpleLayoutContent _advanceRuneLayoutContent;

		// Token: 0x04035D60 RID: 220512
		[Token(Token = "0x4035D60")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private UIAnimationLocation _showBaseAnimationLocation;

		// Token: 0x04035D61 RID: 220513
		[Token(Token = "0x4035D61")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private UIAnimationLocation _showAdvanceAnimationLocation;

		// Token: 0x04035D62 RID: 220514
		[Token(Token = "0x4035D62")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Text _txtStartBattle;

		// Token: 0x04035D63 RID: 220515
		[Token(Token = "0x4035D63")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_isInited;

		// Token: 0x04035D64 RID: 220516
		[Token(Token = "0x4035D64")]
		[FieldOffset(Offset = "0x1A8")]
		private UIStateFinder m_uiStateFinder;

		// Token: 0x04035D65 RID: 220517
		[Token(Token = "0x4035D65")]
		[FieldOffset(Offset = "0x1B8")]
		private UIBiAnimClipSwitchTween m_runeModeSwitchTween;

		// Token: 0x04035D66 RID: 220518
		[Token(Token = "0x4035D66")]
		[FieldOffset(Offset = "0x1C0")]
		private StageViewModel m_stageModel;

		// Token: 0x04035D67 RID: 220519
		[Token(Token = "0x4035D67")]
		[FieldOffset(Offset = "0x1C8")]
		private SixStarStagePreviewAdvanceDescViewModel m_advanceDescViewModel;

		// Token: 0x04035D68 RID: 220520
		[Token(Token = "0x4035D68")]
		[FieldOffset(Offset = "0x1D0")]
		private SixStarStagePreviewView.ListAdapter m_listAdapter;

		// Token: 0x04035D69 RID: 220521
		[Token(Token = "0x4035D69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x04035D6A RID: 220522
		[Token(Token = "0x4035D6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x04035D6B RID: 220523
		[Token(Token = "0x4035D6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckToShow;

		// Token: 0x04035D6C RID: 220524
		[Token(Token = "0x4035D6C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035D6D RID: 220525
		[Token(Token = "0x4035D6D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfNeedRuneSelect;

		// Token: 0x04035D6E RID: 220526
		[Token(Token = "0x4035D6E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RaiseTutorialSignal;

		// Token: 0x04035D6F RID: 220527
		[Token(Token = "0x4035D6F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRewardGroupBtnClick;

		// Token: 0x04035D70 RID: 220528
		[Token(Token = "0x4035D70")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSixStarStartBattleBtnClick;

		// Token: 0x04035D71 RID: 220529
		[Token(Token = "0x4035D71")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006836 RID: 26678
		[Token(Token = "0x2006836")]
		public enum StageSixStarRuneStatus
		{
			// Token: 0x04035D73 RID: 220531
			[Token(Token = "0x4035D73")]
			Base,
			// Token: 0x04035D74 RID: 220532
			[Token(Token = "0x4035D74")]
			Advance
		}

		// Token: 0x02006837 RID: 26679
		[Token(Token = "0x2006837")]
		private class ListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06026348 RID: 156488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026348")]
			[Address(RVA = "0x2147FA0", Offset = "0x2146BA0", VA = "0x182147FA0")]
			public ListAdapter(SixStarStagePreviewView closure)
			{
			}

			// Token: 0x17005A4B RID: 23115
			// (get) Token: 0x06026349 RID: 156489 RVA: 0x000CA5F0 File Offset: 0x000C87F0
			[Token(Token = "0x17005A4B")]
			public override int count
			{
				[Token(Token = "0x6026349")]
				[Address(RVA = "0x2148020", Offset = "0x2146C20", VA = "0x182148020", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602634A RID: 156490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602634A")]
			[Address(RVA = "0x2147DE0", Offset = "0x21469E0", VA = "0x182147DE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04035D75 RID: 220533
			[Token(Token = "0x4035D75")]
			[FieldOffset(Offset = "0x20")]
			private SixStarStagePreviewView m_closure;

			// Token: 0x04035D76 RID: 220534
			[Token(Token = "0x4035D76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035D77 RID: 220535
			[Token(Token = "0x4035D77")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035D78 RID: 220536
			[Token(Token = "0x4035D78")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
