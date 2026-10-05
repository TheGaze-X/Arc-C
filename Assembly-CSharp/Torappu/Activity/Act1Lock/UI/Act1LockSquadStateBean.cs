using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D4 RID: 30932
	[Token(Token = "0x20078D4")]
	public class Act1LockSquadStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700658E RID: 25998
		// (get) Token: 0x0602B5F6 RID: 177654 RVA: 0x000DB978 File Offset: 0x000D9B78
		[Token(Token = "0x1700658E")]
		public bool isFriendLegal
		{
			[Token(Token = "0x602B5F6")]
			[Address(RVA = "0x2730E50", Offset = "0x272FA50", VA = "0x182730E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700658F RID: 25999
		// (get) Token: 0x0602B5F7 RID: 177655 RVA: 0x000DB990 File Offset: 0x000D9B90
		[Token(Token = "0x1700658F")]
		public bool isSquadValid
		{
			[Token(Token = "0x602B5F7")]
			[Address(RVA = "0x27310D0", Offset = "0x272FCD0", VA = "0x1827310D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006590 RID: 26000
		// (get) Token: 0x0602B5F8 RID: 177656 RVA: 0x000DB9A8 File Offset: 0x000D9BA8
		[Token(Token = "0x17006590")]
		public bool isSquadImmutable
		{
			[Token(Token = "0x602B5F8")]
			[Address(RVA = "0x2731070", Offset = "0x272FC70", VA = "0x182731070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B5F9 RID: 177657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B5F9")]
		[Address(RVA = "0x272F610", Offset = "0x272E210", VA = "0x18272F610")]
		public SquadItemStruct[] CreateSquadToStartBattle()
		{
			return null;
		}

		// Token: 0x0602B5FA RID: 177658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5FA")]
		[Address(RVA = "0x272FF50", Offset = "0x272EB50", VA = "0x18272FF50")]
		public void LoadData(Act1LockSquadPage.Params pageParams)
		{
		}

		// Token: 0x0602B5FB RID: 177659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5FB")]
		[Address(RVA = "0x272FA20", Offset = "0x272E620", VA = "0x18272FA20")]
		private void LoadDataInternal(string activityId, string stageId, ActivityInterlockData.InterlockStageType interlockStageType, bool isAutoBattle, bool isPractice)
		{
		}

		// Token: 0x0602B5FC RID: 177660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5FC")]
		[Address(RVA = "0x2730530", Offset = "0x272F130", VA = "0x182730530")]
		public void TryReloadSquadData()
		{
		}

		// Token: 0x0602B5FD RID: 177661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B5FD")]
		[Address(RVA = "0x2730040", Offset = "0x272EC40", VA = "0x182730040")]
		public CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x0602B5FE RID: 177662 RVA: 0x000DB9C0 File Offset: 0x000D9BC0
		[Token(Token = "0x602B5FE")]
		[Address(RVA = "0x272F880", Offset = "0x272E480", VA = "0x18272F880")]
		public bool IsCurrentSquadEmpty()
		{
			return default(bool);
		}

		// Token: 0x0602B5FF RID: 177663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5FF")]
		[Address(RVA = "0x272F580", Offset = "0x272E180", VA = "0x18272F580")]
		public void CleanAssistChar()
		{
		}

		// Token: 0x0602B600 RID: 177664 RVA: 0x000DB9D8 File Offset: 0x000D9BD8
		[Token(Token = "0x602B600")]
		[Address(RVA = "0x272F800", Offset = "0x272E400", VA = "0x18272F800")]
		public bool IsAssistSelected()
		{
			return default(bool);
		}

		// Token: 0x0602B601 RID: 177665 RVA: 0x000DB9F0 File Offset: 0x000D9BF0
		[Token(Token = "0x602B601")]
		[Address(RVA = "0x272F100", Offset = "0x272DD00", VA = "0x18272F100")]
		public bool CheckIfSquadChanged()
		{
			return default(bool);
		}

		// Token: 0x0602B602 RID: 177666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B602")]
		[Address(RVA = "0x272F790", Offset = "0x272E390", VA = "0x18272F790")]
		public SharedCharData GetSpecialAssistData()
		{
			return null;
		}

		// Token: 0x0602B603 RID: 177667 RVA: 0x000DBA08 File Offset: 0x000D9C08
		[Token(Token = "0x602B603")]
		[Address(RVA = "0x272F060", Offset = "0x272DC60", VA = "0x18272F060")]
		public bool CheckIfCharSelectable(int charInstId)
		{
			return default(bool);
		}

		// Token: 0x0602B604 RID: 177668 RVA: 0x000DBA20 File Offset: 0x000D9C20
		[Token(Token = "0x602B604")]
		[Address(RVA = "0x272EF70", Offset = "0x272DB70", VA = "0x18272EF70")]
		public bool CheckIfCharSelectable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x0602B605 RID: 177669 RVA: 0x000DBA38 File Offset: 0x000D9C38
		[Token(Token = "0x602B605")]
		[Address(RVA = "0x2730420", Offset = "0x272F020", VA = "0x182730420")]
		public bool TryGetRegionInterlockIndex(out int index)
		{
			return default(bool);
		}

		// Token: 0x0602B606 RID: 177670 RVA: 0x000DBA50 File Offset: 0x000D9C50
		[Token(Token = "0x602B606")]
		[Address(RVA = "0x2730660", Offset = "0x272F260", VA = "0x182730660")]
		private bool _CheckIfMemberChanged(SquadItemStruct viewItem, PlayerSquadItem prevMember)
		{
			return default(bool);
		}

		// Token: 0x0602B607 RID: 177671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B607")]
		[Address(RVA = "0x27309E0", Offset = "0x272F5E0", VA = "0x1827309E0")]
		private HashSet<int> _GetDefendCharInstIdSet(string stageId)
		{
			return null;
		}

		// Token: 0x0602B608 RID: 177672 RVA: 0x000DBA68 File Offset: 0x000D9C68
		[Token(Token = "0x602B608")]
		[Address(RVA = "0x2730810", Offset = "0x272F410", VA = "0x182730810")]
		private bool _CheckIfSpecialAssistDefendInOtherStage()
		{
			return default(bool);
		}

		// Token: 0x0602B609 RID: 177673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B609")]
		[Address(RVA = "0x2730C80", Offset = "0x272F880", VA = "0x182730C80")]
		private static void _GetStartButtonType(StageData stageData, ActivityInterlockData.InterlockStageType type, bool isPractice, out SquadStartButtonTypeEnum startButtonMode, out string startButtonOverrideId)
		{
		}

		// Token: 0x0602B60A RID: 177674 RVA: 0x000DBA80 File Offset: 0x000D9C80
		[Token(Token = "0x602B60A")]
		[Address(RVA = "0x27308B0", Offset = "0x272F4B0", VA = "0x1827308B0")]
		private bool _CheckIsSpecialAssist(AutoBattleConvertUtil.VerifyOption verifyOption)
		{
			return default(bool);
		}

		// Token: 0x0602B60B RID: 177675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B60B")]
		[Address(RVA = "0x2730D60", Offset = "0x272F960", VA = "0x182730D60")]
		public Act1LockSquadStateBean()
		{
		}

		// Token: 0x0403EB8E RID: 256910
		[Token(Token = "0x403EB8E")]
		[FieldOffset(Offset = "0x10")]
		public SquadGroupViewProperty squadGroupProperty;

		// Token: 0x0403EB8F RID: 256911
		[Token(Token = "0x403EB8F")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x0403EB90 RID: 256912
		[Token(Token = "0x403EB90")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x0403EB91 RID: 256913
		[Token(Token = "0x403EB91")]
		[FieldOffset(Offset = "0x28")]
		public ActivityInterlockData.InterlockStageType interlockStageType;

		// Token: 0x0403EB92 RID: 256914
		[Token(Token = "0x403EB92")]
		[FieldOffset(Offset = "0x2C")]
		public SquadMode squadMode;

		// Token: 0x0403EB93 RID: 256915
		[Token(Token = "0x403EB93")]
		[FieldOffset(Offset = "0x30")]
		public SquadStartButtonTypeEnum startButtonMode;

		// Token: 0x0403EB94 RID: 256916
		[Token(Token = "0x403EB94")]
		[FieldOffset(Offset = "0x38")]
		public string startButtonOverrideId;

		// Token: 0x0403EB95 RID: 256917
		[Token(Token = "0x403EB95")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isSquadValid;

		// Token: 0x0403EB96 RID: 256918
		[Token(Token = "0x403EB96")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<int> m_defendCharInstIdSet;

		// Token: 0x0403EB97 RID: 256919
		[Token(Token = "0x403EB97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isFriendLegal;

		// Token: 0x0403EB98 RID: 256920
		[Token(Token = "0x403EB98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSquadValid;

		// Token: 0x0403EB99 RID: 256921
		[Token(Token = "0x403EB99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSquadImmutable;

		// Token: 0x0403EB9A RID: 256922
		[Token(Token = "0x403EB9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateSquadToStartBattle;

		// Token: 0x0403EB9B RID: 256923
		[Token(Token = "0x403EB9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403EB9C RID: 256924
		[Token(Token = "0x403EB9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadDataInternal;

		// Token: 0x0403EB9D RID: 256925
		[Token(Token = "0x403EB9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryReloadSquadData;

		// Token: 0x0403EB9E RID: 256926
		[Token(Token = "0x403EB9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x0403EB9F RID: 256927
		[Token(Token = "0x403EB9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsCurrentSquadEmpty;

		// Token: 0x0403EBA0 RID: 256928
		[Token(Token = "0x403EBA0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CleanAssistChar;

		// Token: 0x0403EBA1 RID: 256929
		[Token(Token = "0x403EBA1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsAssistSelected;

		// Token: 0x0403EBA2 RID: 256930
		[Token(Token = "0x403EBA2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfSquadChanged;

		// Token: 0x0403EBA3 RID: 256931
		[Token(Token = "0x403EBA3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetSpecialAssistData;

		// Token: 0x0403EBA4 RID: 256932
		[Token(Token = "0x403EBA4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x0403EBA5 RID: 256933
		[Token(Token = "0x403EBA5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_CheckIfCharSelectable;

		// Token: 0x0403EBA6 RID: 256934
		[Token(Token = "0x403EBA6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetRegionInterlockIndex;

		// Token: 0x0403EBA7 RID: 256935
		[Token(Token = "0x403EBA7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckIfMemberChanged;

		// Token: 0x0403EBA8 RID: 256936
		[Token(Token = "0x403EBA8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetDefendCharInstIdSet;

		// Token: 0x0403EBA9 RID: 256937
		[Token(Token = "0x403EBA9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckIfSpecialAssistDefendInOtherStage;

		// Token: 0x0403EBAA RID: 256938
		[Token(Token = "0x403EBAA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetStartButtonType;

		// Token: 0x0403EBAB RID: 256939
		[Token(Token = "0x403EBAB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIsSpecialAssist;

		// Token: 0x0403EBAC RID: 256940
		[Token(Token = "0x403EBAC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078D5 RID: 30933
		[Token(Token = "0x20078D5")]
		private class SquadConstrainPolicy : SquadGroupConstrainPolicy
		{
			// Token: 0x0602B60C RID: 177676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B60C")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public SquadConstrainPolicy(Act1LockSquadStateBean closure)
			{
			}

			// Token: 0x0602B60D RID: 177677 RVA: 0x000DBA98 File Offset: 0x000D9C98
			[Token(Token = "0x602B60D")]
			[Address(RVA = "0x2762DF0", Offset = "0x27619F0", VA = "0x182762DF0", Slot = "4")]
			public override bool CheckIfAssistLocked()
			{
				return default(bool);
			}

			// Token: 0x0403EBAD RID: 256941
			[Token(Token = "0x403EBAD")]
			[FieldOffset(Offset = "0x10")]
			private Act1LockSquadStateBean m_closure;
		}
	}
}
