using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E00 RID: 7680
	[Token(Token = "0x2001E00")]
	public class AssistReportState : State, IBuildingCharSelectContext
	{
		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x0600BD9D RID: 48541 RVA: 0x000464B8 File Offset: 0x000446B8
		[Token(Token = "0x170016EA")]
		public bool usePluginWorkingPanel
		{
			[Token(Token = "0x600BD9D")]
			[Address(RVA = "0x339EB60", Offset = "0x339D760", VA = "0x18339EB60", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600BD9E RID: 48542 RVA: 0x000464D0 File Offset: 0x000446D0
		[Token(Token = "0x170016EB")]
		public bool usePluginDormLockPanel
		{
			[Token(Token = "0x600BD9E")]
			[Address(RVA = "0x339EB00", Offset = "0x339D700", VA = "0x18339EB00", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x0600BD9F RID: 48543 RVA: 0x000464E8 File Offset: 0x000446E8
		[Token(Token = "0x170016EC")]
		public int CachedSlotIndex
		{
			[Token(Token = "0x600BD9F")]
			[Address(RVA = "0x339EAA0", Offset = "0x339D6A0", VA = "0x18339EAA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BDA0")]
		[Address(RVA = "0x339D7D0", Offset = "0x339C3D0", VA = "0x18339D7D0", Slot = "25")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x00046500 File Offset: 0x00044700
		[Token(Token = "0x600BDA1")]
		[Address(RVA = "0x339D770", Offset = "0x339C370", VA = "0x18339D770", Slot = "26")]
		public BuildingData.RoomType GetCurrentRoomType()
		{
			return BuildingData.RoomType.NONE;
		}

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x00046518 File Offset: 0x00044718
		[Token(Token = "0x600BDA2")]
		[Address(RVA = "0x339D270", Offset = "0x339BE70", VA = "0x18339D270", Slot = "27")]
		public bool CheckIfCharValid(int instId)
		{
			return default(bool);
		}

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BDA3")]
		[Address(RVA = "0x339D710", Offset = "0x339C310", VA = "0x18339D710", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA4")]
		[Address(RVA = "0x339D830", Offset = "0x339C430", VA = "0x18339D830", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA5")]
		[Address(RVA = "0x339DCA0", Offset = "0x339C8A0", VA = "0x18339DCA0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BDA6")]
		[Address(RVA = "0x339DD20", Offset = "0x339C920", VA = "0x18339DD20", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA7")]
		[Address(RVA = "0x339E1E0", Offset = "0x339CDE0", VA = "0x18339E1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x00046530 File Offset: 0x00044730
		[Token(Token = "0x600BDA8")]
		[Address(RVA = "0x339D630", Offset = "0x339C230", VA = "0x18339D630")]
		public static int GetAssistantUnlock(int assistantId)
		{
			return 0;
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA9")]
		[Address(RVA = "0x339CE50", Offset = "0x339BA50", VA = "0x18339CE50")]
		public void AnimatorSpread()
		{
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAA")]
		[Address(RVA = "0x339D160", Offset = "0x339BD60", VA = "0x18339D160")]
		public void AnimatorUnspread()
		{
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAB")]
		[Address(RVA = "0x339E7E0", Offset = "0x339D3E0", VA = "0x18339E7E0")]
		private void _SendRequest()
		{
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAC")]
		[Address(RVA = "0x339E770", Offset = "0x339D370", VA = "0x18339E770")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAD")]
		[Address(RVA = "0x339E390", Offset = "0x339CF90", VA = "0x18339E390")]
		private void _OnAssistSlotClicked(int index)
		{
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAE")]
		[Address(RVA = "0x339E510", Offset = "0x339D110", VA = "0x18339E510")]
		private void _OnJumpToCharSelect(CharSelectStateBean stateBean)
		{
		}

		// Token: 0x0600BDAF RID: 48559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAF")]
		[Address(RVA = "0x339E9E0", Offset = "0x339D5E0", VA = "0x18339E9E0")]
		public AssistReportState()
		{
		}

		// Token: 0x0600BDB2 RID: 48562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BDB4")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0400BE2C RID: 48684
		[Token(Token = "0x400BE2C")]
		private const string SPREADPARAM = "spread";

		// Token: 0x0400BE2D RID: 48685
		[Token(Token = "0x400BE2D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingCharSelectMaskPlugin _maskPlugin;

		// Token: 0x0400BE2E RID: 48686
		[Token(Token = "0x400BE2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AssistReportDailyView _dailyView;

		// Token: 0x0400BE2F RID: 48687
		[Token(Token = "0x400BE2F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AssistAssistantContainer _assistantContainer;

		// Token: 0x0400BE30 RID: 48688
		[Token(Token = "0x400BE30")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform[] _dailyViewContainer;

		// Token: 0x0400BE31 RID: 48689
		[Token(Token = "0x400BE31")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _spreadAnimator;

		// Token: 0x0400BE32 RID: 48690
		[Token(Token = "0x400BE32")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform[] rectTransformList;

		// Token: 0x0400BE33 RID: 48691
		[Token(Token = "0x400BE33")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x0400BE34 RID: 48692
		[Token(Token = "0x400BE34")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _mask_button;

		// Token: 0x0400BE35 RID: 48693
		[Token(Token = "0x400BE35")]
		[FieldOffset(Offset = "0x90")]
		private List<AssistReportDailyView> m_assistantViews;

		// Token: 0x0400BE36 RID: 48694
		[Token(Token = "0x400BE36")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedClickedSlotIndex;

		// Token: 0x0400BE37 RID: 48695
		[Token(Token = "0x400BE37")]
		[FieldOffset(Offset = "0xA0")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0400BE38 RID: 48696
		[Token(Token = "0x400BE38")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_initFlag;

		// Token: 0x0400BE39 RID: 48697
		[Token(Token = "0x400BE39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_usePluginWorkingPanel;

		// Token: 0x0400BE3A RID: 48698
		[Token(Token = "0x400BE3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_usePluginDormLockPanel;

		// Token: 0x0400BE3B RID: 48699
		[Token(Token = "0x400BE3B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_CachedSlotIndex;

		// Token: 0x0400BE3C RID: 48700
		[Token(Token = "0x400BE3C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0400BE3D RID: 48701
		[Token(Token = "0x400BE3D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurrentRoomType;

		// Token: 0x0400BE3E RID: 48702
		[Token(Token = "0x400BE3E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0400BE3F RID: 48703
		[Token(Token = "0x400BE3F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400BE40 RID: 48704
		[Token(Token = "0x400BE40")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BE41 RID: 48705
		[Token(Token = "0x400BE41")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400BE42 RID: 48706
		[Token(Token = "0x400BE42")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400BE43 RID: 48707
		[Token(Token = "0x400BE43")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400BE44 RID: 48708
		[Token(Token = "0x400BE44")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetAssistantUnlock;

		// Token: 0x0400BE45 RID: 48709
		[Token(Token = "0x400BE45")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AnimatorSpread;

		// Token: 0x0400BE46 RID: 48710
		[Token(Token = "0x400BE46")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_AnimatorUnspread;

		// Token: 0x0400BE47 RID: 48711
		[Token(Token = "0x400BE47")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SendRequest;

		// Token: 0x0400BE48 RID: 48712
		[Token(Token = "0x400BE48")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400BE49 RID: 48713
		[Token(Token = "0x400BE49")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnAssistSlotClicked;

		// Token: 0x0400BE4A RID: 48714
		[Token(Token = "0x400BE4A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelect;

		// Token: 0x0400BE4B RID: 48715
		[Token(Token = "0x400BE4B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E01 RID: 7681
		[Token(Token = "0x2001E01")]
		public class SelectCharPlugin : BuildingCharSelectFavorRelatedPlugin<AssistReportState>
		{
			// Token: 0x170016ED RID: 5869
			// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170016ED")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x600BDB5")]
				[Address(RVA = "0x33B14E0", Offset = "0x33B00E0", VA = "0x1833B14E0", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600BDB6 RID: 48566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BDB6")]
			[Address(RVA = "0x33B0C70", Offset = "0x33AF870", VA = "0x1833B0C70", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x0600BDB7 RID: 48567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BDB7")]
			[Address(RVA = "0x33B1010", Offset = "0x33AFC10", VA = "0x1833B1010", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0600BDB8 RID: 48568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BDB8")]
			[Address(RVA = "0x33B1090", Offset = "0x33AFC90", VA = "0x1833B1090", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0600BDB9 RID: 48569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BDB9")]
			[Address(RVA = "0x33B1470", Offset = "0x33B0070", VA = "0x1833B1470")]
			public SelectCharPlugin()
			{
			}

			// Token: 0x0400BE4C RID: 48716
			[Token(Token = "0x400BE4C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0400BE4D RID: 48717
			[Token(Token = "0x400BE4D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0400BE4E RID: 48718
			[Token(Token = "0x400BE4E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0400BE4F RID: 48719
			[Token(Token = "0x400BE4F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0400BE50 RID: 48720
			[Token(Token = "0x400BE50")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
