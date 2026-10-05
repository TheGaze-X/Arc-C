using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006832 RID: 26674
	[Token(Token = "0x2006832")]
	public class SixStarStagePreviewRuneBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026335 RID: 156469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026335")]
		[Address(RVA = "0x214E640", Offset = "0x214D240", VA = "0x18214E640")]
		public void Render(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
		}

		// Token: 0x06026336 RID: 156470 RVA: 0x000CA548 File Offset: 0x000C8748
		[Token(Token = "0x6026336")]
		[Address(RVA = "0x214E880", Offset = "0x214D480", VA = "0x18214E880")]
		private bool _CheckIfAdvanceTagUnlocked(StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06026337 RID: 156471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026337")]
		[Address(RVA = "0x214E500", Offset = "0x214D100", VA = "0x18214E500")]
		public void OnTagSwitchBtnClick()
		{
		}

		// Token: 0x06026338 RID: 156472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026338")]
		[Address(RVA = "0x214E470", Offset = "0x214D070", VA = "0x18214E470")]
		public void OnSelectRuneBtnClick()
		{
		}

		// Token: 0x06026339 RID: 156473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026339")]
		[Address(RVA = "0x214E940", Offset = "0x214D540", VA = "0x18214E940")]
		public SixStarStagePreviewRuneBarView()
		{
		}

		// Token: 0x04035D4A RID: 220490
		[Token(Token = "0x4035D4A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04035D4B RID: 220491
		[Token(Token = "0x4035D4B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _validToggle;

		// Token: 0x04035D4C RID: 220492
		[Token(Token = "0x4035D4C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _advanceTrackPoint;

		// Token: 0x04035D4D RID: 220493
		[Token(Token = "0x4035D4D")]
		[FieldOffset(Offset = "0x30")]
		private SixStarStagePreviewView.StageSixStarRuneStatus m_cachedSixStarRuneStatus;

		// Token: 0x04035D4E RID: 220494
		[Token(Token = "0x4035D4E")]
		[FieldOffset(Offset = "0x34")]
		private bool m_cachedIsAdvanceTagUnlocked;

		// Token: 0x04035D4F RID: 220495
		[Token(Token = "0x4035D4F")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_uiStateFinder;

		// Token: 0x04035D50 RID: 220496
		[Token(Token = "0x4035D50")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_pointViewProperty;

		// Token: 0x04035D51 RID: 220497
		[Token(Token = "0x4035D51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035D52 RID: 220498
		[Token(Token = "0x4035D52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckIfAdvanceTagUnlocked;

		// Token: 0x04035D53 RID: 220499
		[Token(Token = "0x4035D53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTagSwitchBtnClick;

		// Token: 0x04035D54 RID: 220500
		[Token(Token = "0x4035D54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelectRuneBtnClick;

		// Token: 0x04035D55 RID: 220501
		[Token(Token = "0x4035D55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006833 RID: 26675
		[Token(Token = "0x2006833")]
		private class SixStarAdvanceUnlockTrackPointParam
		{
			// Token: 0x0602633A RID: 156474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602633A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SixStarAdvanceUnlockTrackPointParam()
			{
			}

			// Token: 0x04035D56 RID: 220502
			[Token(Token = "0x4035D56")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04035D57 RID: 220503
			[Token(Token = "0x4035D57")]
			[FieldOffset(Offset = "0x18")]
			public bool isAdvanceTagUnlocked;
		}

		// Token: 0x02006834 RID: 26676
		[Token(Token = "0x2006834")]
		private class SixStarAdvanceUnlockTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x0602633B RID: 156475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602633B")]
			[Address(RVA = "0x21486C0", Offset = "0x21472C0", VA = "0x1821486C0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17005A4A RID: 23114
			// (get) Token: 0x0602633C RID: 156476 RVA: 0x000CA560 File Offset: 0x000C8760
			[Token(Token = "0x17005A4A")]
			public bool isShow
			{
				[Token(Token = "0x602633C")]
				[Address(RVA = "0x2148870", Offset = "0x2147470", VA = "0x182148870", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602633D RID: 156477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602633D")]
			[Address(RVA = "0x2148810", Offset = "0x2147410", VA = "0x182148810")]
			public SixStarAdvanceUnlockTrackPointModel()
			{
			}

			// Token: 0x04035D58 RID: 220504
			[Token(Token = "0x4035D58")]
			[FieldOffset(Offset = "0x10")]
			private bool m_hasTrackPoint;

			// Token: 0x04035D59 RID: 220505
			[Token(Token = "0x4035D59")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04035D5A RID: 220506
			[Token(Token = "0x4035D5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04035D5B RID: 220507
			[Token(Token = "0x4035D5B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
