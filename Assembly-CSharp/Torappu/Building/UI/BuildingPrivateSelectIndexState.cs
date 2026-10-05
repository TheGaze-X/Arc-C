using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B91 RID: 7057
	[Token(Token = "0x2001B91")]
	public class BuildingPrivateSelectIndexState : State, IBuildingCharSelectContext
	{
		// Token: 0x0600B067 RID: 45159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B067")]
		[Address(RVA = "0x32A5080", Offset = "0x32A3C80", VA = "0x1832A5080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B068")]
		[Address(RVA = "0x32A51A0", Offset = "0x32A3DA0", VA = "0x1832A51A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B069")]
		[Address(RVA = "0x32A5250", Offset = "0x32A3E50", VA = "0x1832A5250", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B06A")]
		[Address(RVA = "0x32A5450", Offset = "0x32A4050", VA = "0x1832A5450")]
		private void _OnJumpToCharSelect(CharSelectStateBean selectBean)
		{
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600B06B RID: 45163 RVA: 0x000436C8 File Offset: 0x000418C8
		[Token(Token = "0x170014E3")]
		public bool usePluginWorkingPanel
		{
			[Token(Token = "0x600B06B")]
			[Address(RVA = "0x32A58C0", Offset = "0x32A44C0", VA = "0x1832A58C0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x000436E0 File Offset: 0x000418E0
		[Token(Token = "0x170014E4")]
		public bool usePluginDormLockPanel
		{
			[Token(Token = "0x600B06C")]
			[Address(RVA = "0x32A5860", Offset = "0x32A4460", VA = "0x1832A5860", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B06D")]
		[Address(RVA = "0x32A5140", Offset = "0x32A3D40", VA = "0x1832A5140", Slot = "25")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x000436F8 File Offset: 0x000418F8
		[Token(Token = "0x600B06E")]
		[Address(RVA = "0x32A50E0", Offset = "0x32A3CE0", VA = "0x1832A50E0", Slot = "26")]
		public BuildingData.RoomType GetCurrentRoomType()
		{
			return BuildingData.RoomType.NONE;
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x00043710 File Offset: 0x00041910
		[Token(Token = "0x600B06F")]
		[Address(RVA = "0x32A5010", Offset = "0x32A3C10", VA = "0x1832A5010", Slot = "27")]
		public bool CheckIfCharValid(int instId)
		{
			return default(bool);
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B070")]
		[Address(RVA = "0x32A57B0", Offset = "0x32A43B0", VA = "0x1832A57B0")]
		public BuildingPrivateSelectIndexState()
		{
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B072")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B073")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0400AAD1 RID: 43729
		[Token(Token = "0x400AAD1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingPrivateSelectMaskPlugin _maskPlugin;

		// Token: 0x0400AAD2 RID: 43730
		[Token(Token = "0x400AAD2")]
		[FieldOffset(Offset = "0x58")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0400AAD3 RID: 43731
		[Token(Token = "0x400AAD3")]
		[FieldOffset(Offset = "0x60")]
		private BuildingPrivateCharSelectPage.Param m_param;

		// Token: 0x0400AAD4 RID: 43732
		[Token(Token = "0x400AAD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AAD5 RID: 43733
		[Token(Token = "0x400AAD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AAD6 RID: 43734
		[Token(Token = "0x400AAD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400AAD7 RID: 43735
		[Token(Token = "0x400AAD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelect;

		// Token: 0x0400AAD8 RID: 43736
		[Token(Token = "0x400AAD8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_usePluginWorkingPanel;

		// Token: 0x0400AAD9 RID: 43737
		[Token(Token = "0x400AAD9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_usePluginDormLockPanel;

		// Token: 0x0400AADA RID: 43738
		[Token(Token = "0x400AADA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0400AADB RID: 43739
		[Token(Token = "0x400AADB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCurrentRoomType;

		// Token: 0x0400AADC RID: 43740
		[Token(Token = "0x400AADC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0400AADD RID: 43741
		[Token(Token = "0x400AADD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B92 RID: 7058
		[Token(Token = "0x2001B92")]
		private class CharSelectPlugin : BuildingCharSelectFavorRelatedPlugin<BuildingPrivateSelectIndexState>
		{
			// Token: 0x0600B074 RID: 45172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B074")]
			[Address(RVA = "0x32AB7B0", Offset = "0x32AA3B0", VA = "0x1832AB7B0", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x170014E5 RID: 5349
			// (get) Token: 0x0600B075 RID: 45173 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014E5")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x600B075")]
				[Address(RVA = "0x32ABBF0", Offset = "0x32AA7F0", VA = "0x1832ABBF0", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B076 RID: 45174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B076")]
			[Address(RVA = "0x32AB850", Offset = "0x32AA450", VA = "0x1832AB850", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0600B077 RID: 45175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B077")]
			[Address(RVA = "0x32AB900", Offset = "0x32AA500", VA = "0x1832AB900", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0600B078 RID: 45176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B078")]
			[Address(RVA = "0x32ABB80", Offset = "0x32AA780", VA = "0x1832ABB80")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0400AADE RID: 43742
			[Token(Token = "0x400AADE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0400AADF RID: 43743
			[Token(Token = "0x400AADF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0400AAE0 RID: 43744
			[Token(Token = "0x400AAE0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0400AAE1 RID: 43745
			[Token(Token = "0x400AAE1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0400AAE2 RID: 43746
			[Token(Token = "0x400AAE2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
