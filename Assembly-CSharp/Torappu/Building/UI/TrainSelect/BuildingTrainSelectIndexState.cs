using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.TrainSelect
{
	// Token: 0x02001C04 RID: 7172
	[Token(Token = "0x2001C04")]
	public class BuildingTrainSelectIndexState : State, IBuildingCharSelectContext
	{
		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x00044100 File Offset: 0x00042300
		[Token(Token = "0x17001578")]
		public bool usePluginWorkingPanel
		{
			[Token(Token = "0x600B2C4")]
			[Address(RVA = "0x32DC690", Offset = "0x32DB290", VA = "0x1832DC690", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x0600B2C5 RID: 45765 RVA: 0x00044118 File Offset: 0x00042318
		[Token(Token = "0x17001579")]
		public bool usePluginDormLockPanel
		{
			[Token(Token = "0x600B2C5")]
			[Address(RVA = "0x32DC630", Offset = "0x32DB230", VA = "0x1832DC630", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2C6")]
		[Address(RVA = "0x32DBD60", Offset = "0x32DA960", VA = "0x1832DBD60", Slot = "25")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x00044130 File Offset: 0x00042330
		[Token(Token = "0x600B2C7")]
		[Address(RVA = "0x32DBD00", Offset = "0x32DA900", VA = "0x1832DBD00", Slot = "26")]
		public BuildingData.RoomType GetCurrentRoomType()
		{
			return BuildingData.RoomType.NONE;
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x00044148 File Offset: 0x00042348
		[Token(Token = "0x600B2C8")]
		[Address(RVA = "0x32DBC30", Offset = "0x32DA830", VA = "0x1832DBC30", Slot = "27")]
		public bool CheckIfCharValid(int instId)
		{
			return default(bool);
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2C9")]
		[Address(RVA = "0x32DBCA0", Offset = "0x32DA8A0", VA = "0x1832DBCA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CA")]
		[Address(RVA = "0x32DBDC0", Offset = "0x32DA9C0", VA = "0x1832DBDC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2CB")]
		[Address(RVA = "0x32DBE20", Offset = "0x32DAA20", VA = "0x1832DBE20", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CC")]
		[Address(RVA = "0x32DC020", Offset = "0x32DAC20", VA = "0x1832DC020")]
		private void _OnJumpToCharSelect(CharSelectStateBean selectBean)
		{
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CD")]
		[Address(RVA = "0x32DC580", Offset = "0x32DB180", VA = "0x1832DC580")]
		public BuildingTrainSelectIndexState()
		{
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2D0")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0400ADCE RID: 44494
		[Token(Token = "0x400ADCE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingCharSelectMaskPlugin _maskPlugin;

		// Token: 0x0400ADCF RID: 44495
		[Token(Token = "0x400ADCF")]
		[FieldOffset(Offset = "0x58")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0400ADD0 RID: 44496
		[Token(Token = "0x400ADD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_usePluginWorkingPanel;

		// Token: 0x0400ADD1 RID: 44497
		[Token(Token = "0x400ADD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_usePluginDormLockPanel;

		// Token: 0x0400ADD2 RID: 44498
		[Token(Token = "0x400ADD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0400ADD3 RID: 44499
		[Token(Token = "0x400ADD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentRoomType;

		// Token: 0x0400ADD4 RID: 44500
		[Token(Token = "0x400ADD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0400ADD5 RID: 44501
		[Token(Token = "0x400ADD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400ADD6 RID: 44502
		[Token(Token = "0x400ADD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400ADD7 RID: 44503
		[Token(Token = "0x400ADD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400ADD8 RID: 44504
		[Token(Token = "0x400ADD8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelect;

		// Token: 0x0400ADD9 RID: 44505
		[Token(Token = "0x400ADD9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C05 RID: 7173
		[Token(Token = "0x2001C05")]
		private class CharSelectPlugin : UICharacterSelectState.Plugin<BuildingTrainSelectIndexState>
		{
			// Token: 0x0600B2D1 RID: 45777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2D1")]
			[Address(RVA = "0x32E2E00", Offset = "0x32E1A00", VA = "0x1832E2E00", Slot = "22")]
			public override void OnInit(CharSelectStateBean stateBean, object context)
			{
			}

			// Token: 0x0600B2D2 RID: 45778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2D2")]
			[Address(RVA = "0x32E2C30", Offset = "0x32E1830", VA = "0x1832E2C30", Slot = "23")]
			public override void OnExit()
			{
			}

			// Token: 0x1700157A RID: 5498
			// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700157A")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x600B2D3")]
				[Address(RVA = "0x32E3D60", Offset = "0x32E2960", VA = "0x1832E3D60", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700157B RID: 5499
			// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x00044160 File Offset: 0x00042360
			[Token(Token = "0x1700157B")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x600B2D4")]
				[Address(RVA = "0x32E3DE0", Offset = "0x32E29E0", VA = "0x1832E3DE0", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700157C RID: 5500
			// (get) Token: 0x0600B2D5 RID: 45781 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700157C")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x600B2D5")]
				[Address(RVA = "0x32E3CE0", Offset = "0x32E28E0", VA = "0x1832E3CE0", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B2D6 RID: 45782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2D6")]
			[Address(RVA = "0x32E3050", Offset = "0x32E1C50", VA = "0x1832E3050", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x0600B2D7 RID: 45783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2D7")]
			[Address(RVA = "0x32E31A0", Offset = "0x32E1DA0", VA = "0x1832E31A0", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x0600B2D8 RID: 45784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2D8")]
			[Address(RVA = "0x32E3220", Offset = "0x32E1E20", VA = "0x1832E3220", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0600B2D9 RID: 45785 RVA: 0x00044178 File Offset: 0x00042378
			[Token(Token = "0x600B2D9")]
			[Address(RVA = "0x32E3970", Offset = "0x32E2570", VA = "0x1832E3970")]
			private bool _CheckIsNeedShowDormLockConfirm(BuildingModel buildingModel, List<int> charInstIdList)
			{
				return default(bool);
			}

			// Token: 0x0600B2DA RID: 45786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2DA")]
			[Address(RVA = "0x32E3630", Offset = "0x32E2230", VA = "0x1832E3630", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x0600B2DB RID: 45787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2DB")]
			[Address(RVA = "0x32E2FD0", Offset = "0x32E1BD0", VA = "0x1832E2FD0", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x0600B2DC RID: 45788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2DC")]
			[Address(RVA = "0x32E30F0", Offset = "0x32E1CF0", VA = "0x1832E30F0", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0600B2DD RID: 45789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2DD")]
			[Address(RVA = "0x32E36B0", Offset = "0x32E22B0", VA = "0x1832E36B0", Slot = "24")]
			public override void PostUpdateAttribute(CharAttrViewModel attrModel)
			{
			}

			// Token: 0x0600B2DE RID: 45790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2DE")]
			[Address(RVA = "0x32E2A70", Offset = "0x32E1670", VA = "0x1832E2A70", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x0600B2DF RID: 45791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2DF")]
			[Address(RVA = "0x32E3BD0", Offset = "0x32E27D0", VA = "0x1832E3BD0")]
			private void _OnPlayerDataChanged()
			{
			}

			// Token: 0x0600B2E0 RID: 45792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2E0")]
			[Address(RVA = "0x32E3C70", Offset = "0x32E2870", VA = "0x1832E3C70")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0400ADDA RID: 44506
			[Token(Token = "0x400ADDA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x0400ADDB RID: 44507
			[Token(Token = "0x400ADDB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnExit;

			// Token: 0x0400ADDC RID: 44508
			[Token(Token = "0x400ADDC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x0400ADDD RID: 44509
			[Token(Token = "0x400ADDD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x0400ADDE RID: 44510
			[Token(Token = "0x400ADDE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0400ADDF RID: 44511
			[Token(Token = "0x400ADDF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0400ADE0 RID: 44512
			[Token(Token = "0x400ADE0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x0400ADE1 RID: 44513
			[Token(Token = "0x400ADE1")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0400ADE2 RID: 44514
			[Token(Token = "0x400ADE2")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__CheckIsNeedShowDormLockConfirm;

			// Token: 0x0400ADE3 RID: 44515
			[Token(Token = "0x400ADE3")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x0400ADE4 RID: 44516
			[Token(Token = "0x400ADE4")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x0400ADE5 RID: 44517
			[Token(Token = "0x400ADE5")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0400ADE6 RID: 44518
			[Token(Token = "0x400ADE6")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_PostUpdateAttribute;

			// Token: 0x0400ADE7 RID: 44519
			[Token(Token = "0x400ADE7")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0400ADE8 RID: 44520
			[Token(Token = "0x400ADE8")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

			// Token: 0x0400ADE9 RID: 44521
			[Token(Token = "0x400ADE9")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
