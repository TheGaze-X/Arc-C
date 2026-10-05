using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006850 RID: 26704
	[Token(Token = "0x2006850")]
	public class SixStarStageMapMilestoneButton : StageZoneMilestoneButtonBase
	{
		// Token: 0x17005A4E RID: 23118
		// (get) Token: 0x06026392 RID: 156562 RVA: 0x000CA698 File Offset: 0x000C8898
		[Token(Token = "0x17005A4E")]
		public override StageZoneMilestoneButtonBase.StageZoneMilestoneButtonType buttonType
		{
			[Token(Token = "0x6026392")]
			[Address(RVA = "0x214D840", Offset = "0x214C440", VA = "0x18214D840", Slot = "4")]
			get
			{
				return StageZoneMilestoneButtonBase.StageZoneMilestoneButtonType.NONE;
			}
		}

		// Token: 0x06026393 RID: 156563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026393")]
		[Address(RVA = "0x214D710", Offset = "0x214C310", VA = "0x18214D710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026394 RID: 156564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026394")]
		[Address(RVA = "0x214D570", Offset = "0x214C170", VA = "0x18214D570", Slot = "5")]
		public override void Render(ZoneViewModel selectedZoneModel)
		{
		}

		// Token: 0x06026395 RID: 156565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026395")]
		[Address(RVA = "0x214D460", Offset = "0x214C060", VA = "0x18214D460")]
		public void EventOnClickMilestoneButton()
		{
		}

		// Token: 0x06026396 RID: 156566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026396")]
		[Address(RVA = "0x214D7A0", Offset = "0x214C3A0", VA = "0x18214D7A0")]
		public SixStarStageMapMilestoneButton()
		{
		}

		// Token: 0x04035E0C RID: 220684
		[Token(Token = "0x4035E0C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x04035E0D RID: 220685
		[Token(Token = "0x4035E0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommonTrackPoint _rewardTrackPoint;

		// Token: 0x04035E0E RID: 220686
		[Token(Token = "0x4035E0E")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035E0F RID: 220687
		[Token(Token = "0x4035E0F")]
		[FieldOffset(Offset = "0x38")]
		private string m_groupId;

		// Token: 0x04035E10 RID: 220688
		[Token(Token = "0x4035E10")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_rewardTrackProp;

		// Token: 0x04035E11 RID: 220689
		[Token(Token = "0x4035E11")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04035E12 RID: 220690
		[Token(Token = "0x4035E12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buttonType;

		// Token: 0x04035E13 RID: 220691
		[Token(Token = "0x4035E13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035E14 RID: 220692
		[Token(Token = "0x4035E14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035E15 RID: 220693
		[Token(Token = "0x4035E15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickMilestoneButton;

		// Token: 0x04035E16 RID: 220694
		[Token(Token = "0x4035E16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006851 RID: 26705
		[Token(Token = "0x2006851")]
		public class RewardPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17005A4F RID: 23119
			// (get) Token: 0x06026397 RID: 156567 RVA: 0x000CA6B0 File Offset: 0x000C88B0
			// (set) Token: 0x06026398 RID: 156568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005A4F")]
			public bool isShow
			{
				[Token(Token = "0x6026397")]
				[Address(RVA = "0x21485F0", Offset = "0x21471F0", VA = "0x1821485F0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6026398")]
				[Address(RVA = "0x2148650", Offset = "0x2147250", VA = "0x182148650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06026399 RID: 156569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026399")]
			[Address(RVA = "0x21481F0", Offset = "0x2146DF0", VA = "0x1821481F0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602639A RID: 156570 RVA: 0x000CA6C8 File Offset: 0x000C88C8
			[Token(Token = "0x602639A")]
			[Address(RVA = "0x2148420", Offset = "0x2147020", VA = "0x182148420")]
			private bool _CheckHasReward(string groupId)
			{
				return default(bool);
			}

			// Token: 0x0602639B RID: 156571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602639B")]
			[Address(RVA = "0x2148590", Offset = "0x2147190", VA = "0x182148590")]
			public RewardPointModel()
			{
			}

			// Token: 0x04035E18 RID: 220696
			[Token(Token = "0x4035E18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04035E19 RID: 220697
			[Token(Token = "0x4035E19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x04035E1A RID: 220698
			[Token(Token = "0x4035E1A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04035E1B RID: 220699
			[Token(Token = "0x4035E1B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CheckHasReward;

			// Token: 0x04035E1C RID: 220700
			[Token(Token = "0x4035E1C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
