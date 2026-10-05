using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DF8 RID: 15864
	[Token(Token = "0x2003DF8")]
	public class SquadGroupViewModel : IHotfixable
	{
		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x06018AD4 RID: 101076 RVA: 0x0009B3A0 File Offset: 0x000995A0
		[Token(Token = "0x17003AC1")]
		public SquadMode squadMode
		{
			[Token(Token = "0x6018AD4")]
			[Address(RVA = "0x1140BD0", Offset = "0x113F7D0", VA = "0x181140BD0")]
			get
			{
				return SquadMode.NORMAL;
			}
		}

		// Token: 0x06018AD5 RID: 101077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AD5")]
		[Address(RVA = "0x1140AF0", Offset = "0x113F6F0", VA = "0x181140AF0")]
		public void SetConstrainPolicy(SquadGroupConstrainPolicy policy)
		{
		}

		// Token: 0x06018AD6 RID: 101078 RVA: 0x0009B3B8 File Offset: 0x000995B8
		[Token(Token = "0x6018AD6")]
		[Address(RVA = "0x113EEE0", Offset = "0x113DAE0", VA = "0x18113EEE0")]
		public bool CheckIfAssistLocked()
		{
			return default(bool);
		}

		// Token: 0x06018AD7 RID: 101079 RVA: 0x0009B3D0 File Offset: 0x000995D0
		[Token(Token = "0x6018AD7")]
		[Address(RVA = "0x113EF80", Offset = "0x113DB80", VA = "0x18113EF80")]
		public bool CheckIfSquadSlotLocked(SquadViewModel squadModel, int index)
		{
			return default(bool);
		}

		// Token: 0x06018AD8 RID: 101080 RVA: 0x0009B3E8 File Offset: 0x000995E8
		[Token(Token = "0x6018AD8")]
		[Address(RVA = "0x113F9D0", Offset = "0x113E5D0", VA = "0x18113F9D0")]
		public bool IsAssistEnabled()
		{
			return default(bool);
		}

		// Token: 0x06018AD9 RID: 101081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AD9")]
		[Address(RVA = "0x11400F0", Offset = "0x113ECF0", VA = "0x1811400F0")]
		public void LoadDataNormal()
		{
		}

		// Token: 0x06018ADA RID: 101082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ADA")]
		[Address(RVA = "0x11408D0", Offset = "0x113F4D0", VA = "0x1811408D0")]
		public void ReloadName()
		{
		}

		// Token: 0x06018ADB RID: 101083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ADB")]
		[Address(RVA = "0x11405A0", Offset = "0x113F1A0", VA = "0x1811405A0")]
		public void LoadDataPredefined(List<CharacterCardViewModel> predefined)
		{
		}

		// Token: 0x06018ADC RID: 101084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ADC")]
		[Address(RVA = "0x1140540", Offset = "0x113F140", VA = "0x181140540")]
		public void LoadDataOverrideSkillSelectable()
		{
		}

		// Token: 0x06018ADD RID: 101085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ADD")]
		[Address(RVA = "0x113FB10", Offset = "0x113E710", VA = "0x18113FB10")]
		public void LoadDataAutoBattle(AutoBattleConvertUtil.BattleLog battleLog)
		{
		}

		// Token: 0x06018ADE RID: 101086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ADE")]
		[Address(RVA = "0x113F4D0", Offset = "0x113E0D0", VA = "0x18113F4D0")]
		public void GenerateAutoBattleBannedCharList(ExternalRuneChecker checker)
		{
		}

		// Token: 0x06018ADF RID: 101087 RVA: 0x0009B400 File Offset: 0x00099600
		[Token(Token = "0x6018ADF")]
		[Address(RVA = "0x113FA50", Offset = "0x113E650", VA = "0x18113FA50")]
		public bool IsAutoBattleCharBanned(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018AE0 RID: 101088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AE0")]
		[Address(RVA = "0x113F2F0", Offset = "0x113DEF0", VA = "0x18113F2F0")]
		private void EnsureAutoBattleBannedList()
		{
		}

		// Token: 0x06018AE1 RID: 101089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AE1")]
		[Address(RVA = "0x1140090", Offset = "0x113EC90", VA = "0x181140090")]
		public void LoadDataCustomized()
		{
		}

		// Token: 0x06018AE2 RID: 101090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AE2")]
		[Address(RVA = "0x113F460", Offset = "0x113E060", VA = "0x18113F460", Slot = "4")]
		protected virtual SquadFriendData GeneSquadFriendData(PredefinedAssistData predefinedAssistData)
		{
			return null;
		}

		// Token: 0x06018AE3 RID: 101091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AE3")]
		[Address(RVA = "0x113F050", Offset = "0x113DC50", VA = "0x18113F050")]
		public void ClearAssistCharIfConflict(IList<SquadItemStruct> squadMembers)
		{
		}

		// Token: 0x06018AE4 RID: 101092 RVA: 0x0009B418 File Offset: 0x00099618
		[Token(Token = "0x6018AE4")]
		[Address(RVA = "0x113F730", Offset = "0x113E330", VA = "0x18113F730")]
		public int GetCurSquadValidMemberNum()
		{
			return 0;
		}

		// Token: 0x06018AE5 RID: 101093 RVA: 0x0009B430 File Offset: 0x00099630
		[Token(Token = "0x6018AE5")]
		[Address(RVA = "0x113F970", Offset = "0x113E570", VA = "0x18113F970")]
		public int GetSquadAssistNum()
		{
			return 0;
		}

		// Token: 0x06018AE6 RID: 101094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AE6")]
		[Address(RVA = "0x113F3B0", Offset = "0x113DFB0", VA = "0x18113F3B0")]
		protected SquadGroupConstrainPolicy EnsureConstrains()
		{
			return null;
		}

		// Token: 0x06018AE7 RID: 101095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AE7")]
		[Address(RVA = "0x1140B70", Offset = "0x113F770", VA = "0x181140B70")]
		public SquadGroupViewModel()
		{
		}

		// Token: 0x0401E419 RID: 123929
		[Token(Token = "0x401E419")]
		[FieldOffset(Offset = "0x10")]
		protected SquadMode mode;

		// Token: 0x0401E41A RID: 123930
		[Token(Token = "0x401E41A")]
		[FieldOffset(Offset = "0x14")]
		public int selectedIndex;

		// Token: 0x0401E41B RID: 123931
		[Token(Token = "0x401E41B")]
		[FieldOffset(Offset = "0x18")]
		public SquadViewModel[] squads;

		// Token: 0x0401E41C RID: 123932
		[Token(Token = "0x401E41C")]
		[FieldOffset(Offset = "0x20")]
		public SquadFriendData assistCharModel;

		// Token: 0x0401E41D RID: 123933
		[Token(Token = "0x401E41D")]
		[FieldOffset(Offset = "0x28")]
		private SquadGroupConstrainPolicy m_constrainPolicy;

		// Token: 0x0401E41E RID: 123934
		[Token(Token = "0x401E41E")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<string> m_autoModeBannedCharIds;

		// Token: 0x0401E41F RID: 123935
		[Token(Token = "0x401E41F")]
		[FieldOffset(Offset = "0x38")]
		public bool isFriendAssist;

		// Token: 0x0401E420 RID: 123936
		[Token(Token = "0x401E420")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadMode;

		// Token: 0x0401E421 RID: 123937
		[Token(Token = "0x401E421")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetConstrainPolicy;

		// Token: 0x0401E422 RID: 123938
		[Token(Token = "0x401E422")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfAssistLocked;

		// Token: 0x0401E423 RID: 123939
		[Token(Token = "0x401E423")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfSquadSlotLocked;

		// Token: 0x0401E424 RID: 123940
		[Token(Token = "0x401E424")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsAssistEnabled;

		// Token: 0x0401E425 RID: 123941
		[Token(Token = "0x401E425")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadDataNormal;

		// Token: 0x0401E426 RID: 123942
		[Token(Token = "0x401E426")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReloadName;

		// Token: 0x0401E427 RID: 123943
		[Token(Token = "0x401E427")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadDataPredefined;

		// Token: 0x0401E428 RID: 123944
		[Token(Token = "0x401E428")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadDataOverrideSkillSelectable;

		// Token: 0x0401E429 RID: 123945
		[Token(Token = "0x401E429")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadDataAutoBattle;

		// Token: 0x0401E42A RID: 123946
		[Token(Token = "0x401E42A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GenerateAutoBattleBannedCharList;

		// Token: 0x0401E42B RID: 123947
		[Token(Token = "0x401E42B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsAutoBattleCharBanned;

		// Token: 0x0401E42C RID: 123948
		[Token(Token = "0x401E42C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EnsureAutoBattleBannedList;

		// Token: 0x0401E42D RID: 123949
		[Token(Token = "0x401E42D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadDataCustomized;

		// Token: 0x0401E42E RID: 123950
		[Token(Token = "0x401E42E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GeneSquadFriendData;

		// Token: 0x0401E42F RID: 123951
		[Token(Token = "0x401E42F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ClearAssistCharIfConflict;

		// Token: 0x0401E430 RID: 123952
		[Token(Token = "0x401E430")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetCurSquadValidMemberNum;

		// Token: 0x0401E431 RID: 123953
		[Token(Token = "0x401E431")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetSquadAssistNum;

		// Token: 0x0401E432 RID: 123954
		[Token(Token = "0x401E432")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EnsureConstrains;

		// Token: 0x0401E433 RID: 123955
		[Token(Token = "0x401E433")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
