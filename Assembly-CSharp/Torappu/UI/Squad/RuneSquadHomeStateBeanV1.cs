using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.Scripts.UI.Squad;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DEB RID: 15851
	[Token(Token = "0x2003DEB")]
	public class RuneSquadHomeStateBeanV1 : IStateBean, IHotfixable
	{
		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x06018A7F RID: 100991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AB7")]
		public string stageId
		{
			[Token(Token = "0x6018A7F")]
			[Address(RVA = "0x1120F60", Offset = "0x111FB60", VA = "0x181120F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x06018A80 RID: 100992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AB8")]
		public List<RuneTable.PackedRuneData> selectedRunes
		{
			[Token(Token = "0x6018A80")]
			[Address(RVA = "0x1120F00", Offset = "0x111FB00", VA = "0x181120F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018A81 RID: 100993 RVA: 0x0009B1A8 File Offset: 0x000993A8
		[Token(Token = "0x6018A81")]
		[Address(RVA = "0x111F300", Offset = "0x111DF00", VA = "0x18111F300")]
		public int MaxNum4CharSelect()
		{
			return 0;
		}

		// Token: 0x06018A82 RID: 100994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A82")]
		[Address(RVA = "0x111ED50", Offset = "0x111D950", VA = "0x18111ED50")]
		public void LoadData(RuneSquadPageV1.Params pageParams)
		{
		}

		// Token: 0x06018A83 RID: 100995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A83")]
		[Address(RVA = "0x111EFB0", Offset = "0x111DBB0", VA = "0x18111EFB0")]
		public void LoadData(CrisisSquadPage.Params pageParams)
		{
		}

		// Token: 0x06018A84 RID: 100996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A84")]
		[Address(RVA = "0x111EB80", Offset = "0x111D780", VA = "0x18111EB80")]
		protected void LoadDataInternal(string runeStageId, string levelId, List<RuneTable.PackedRuneData> selectedRunes, [Optional] string overrideSquadSaveKey)
		{
		}

		// Token: 0x06018A85 RID: 100997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A85")]
		[Address(RVA = "0x111FB00", Offset = "0x111E700", VA = "0x18111FB00")]
		public void UpdateData()
		{
		}

		// Token: 0x06018A86 RID: 100998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A86")]
		[Address(RVA = "0x111F890", Offset = "0x111E490", VA = "0x18111F890")]
		public void RestrictSquadMembers()
		{
		}

		// Token: 0x06018A87 RID: 100999 RVA: 0x0009B1C0 File Offset: 0x000993C0
		[Token(Token = "0x6018A87")]
		[Address(RVA = "0x111E7C0", Offset = "0x111D3C0", VA = "0x18111E7C0")]
		public bool CheckIfCharValid(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06018A88 RID: 101000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A88")]
		[Address(RVA = "0x111FD00", Offset = "0x111E900", VA = "0x18111FD00")]
		private void _InitCurSquad(string squadSaveKey, List<RuneTable.PackedRuneData> selectedRunes)
		{
		}

		// Token: 0x06018A89 RID: 101001 RVA: 0x0009B1D8 File Offset: 0x000993D8
		[Token(Token = "0x6018A89")]
		[Address(RVA = "0x111E9E0", Offset = "0x111D5E0", VA = "0x18111E9E0")]
		public bool IsCurrentSquadEmpty()
		{
			return default(bool);
		}

		// Token: 0x06018A8A RID: 101002 RVA: 0x0009B1F0 File Offset: 0x000993F0
		[Token(Token = "0x6018A8A")]
		[Address(RVA = "0x111E700", Offset = "0x111D300", VA = "0x18111E700")]
		public bool CheckIfCharSelectable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06018A8B RID: 101003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A8B")]
		[Address(RVA = "0x111E870", Offset = "0x111D470", VA = "0x18111E870")]
		public SquadItemStruct[] CreateSquadToStartBattle()
		{
			return null;
		}

		// Token: 0x06018A8C RID: 101004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A8C")]
		[Address(RVA = "0x111F3C0", Offset = "0x111DFC0", VA = "0x18111F3C0")]
		public CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x06018A8D RID: 101005 RVA: 0x0009B208 File Offset: 0x00099408
		[Token(Token = "0x6018A8D")]
		[Address(RVA = "0x1120A10", Offset = "0x111F610", VA = "0x181120A10")]
		private static bool _TryLoadSquadForRune(string squadSaveKey, SquadItemStruct[] members)
		{
			return default(bool);
		}

		// Token: 0x06018A8E RID: 101006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A8E")]
		[Address(RVA = "0x1120530", Offset = "0x111F130", VA = "0x181120530")]
		private static string _MigrateSkillIfTmplChanged(CharacterCardViewModel curCard, RuneSquadHomeStateBeanV1.SquadSlotCache savedSlot)
		{
			return null;
		}

		// Token: 0x06018A8F RID: 101007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A8F")]
		[Address(RVA = "0x1120340", Offset = "0x111EF40", VA = "0x181120340")]
		private static string _MigrateEquipIfTmplChanged(CharacterCardViewModel curCard, RuneSquadHomeStateBeanV1.SquadSlotCache savedSlot)
		{
			return null;
		}

		// Token: 0x06018A90 RID: 101008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A90")]
		[Address(RVA = "0x1120040", Offset = "0x111EC40", VA = "0x181120040")]
		private static void _LoadFirstPlayerSquad(SquadItemStruct[] members)
		{
		}

		// Token: 0x06018A91 RID: 101009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A91")]
		[Address(RVA = "0x111E5D0", Offset = "0x111D1D0", VA = "0x18111E5D0")]
		public void ApplyToFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06018A92 RID: 101010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A92")]
		[Address(RVA = "0x111F7A0", Offset = "0x111E3A0", VA = "0x18111F7A0")]
		public void ReceiveFromFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06018A93 RID: 101011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A93")]
		[Address(RVA = "0x111FAA0", Offset = "0x111E6A0", VA = "0x18111FAA0")]
		public void SaveLocalCache()
		{
		}

		// Token: 0x06018A94 RID: 101012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A94")]
		[Address(RVA = "0x1120790", Offset = "0x111F390", VA = "0x181120790")]
		private void _SaveSquadToCache()
		{
		}

		// Token: 0x06018A95 RID: 101013 RVA: 0x0009B220 File Offset: 0x00099420
		[Token(Token = "0x6018A95")]
		[Address(RVA = "0x111FBE0", Offset = "0x111E7E0", VA = "0x18111FBE0")]
		private int _GetCurSquadValidMemberNum()
		{
			return 0;
		}

		// Token: 0x06018A96 RID: 101014 RVA: 0x0009B238 File Offset: 0x00099438
		[Token(Token = "0x6018A96")]
		[Address(RVA = "0x111FC70", Offset = "0x111E870", VA = "0x18111FC70")]
		private int _GetSquadAssistNum()
		{
			return 0;
		}

		// Token: 0x06018A97 RID: 101015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A97")]
		[Address(RVA = "0x1120D40", Offset = "0x111F940", VA = "0x181120D40")]
		public RuneSquadHomeStateBeanV1()
		{
		}

		// Token: 0x0401E374 RID: 123764
		[Token(Token = "0x401E374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SquadGroupViewProperty squadGroupProp;

		// Token: 0x0401E375 RID: 123765
		[Token(Token = "0x401E375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuneSquadHomeStateBeanV1.FriendAssistDataStruct friendDataCache;

		// Token: 0x0401E376 RID: 123766
		[Token(Token = "0x401E376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ProfessionCategory assistProfession;

		// Token: 0x0401E377 RID: 123767
		[Token(Token = "0x401E377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExternalRuneChecker m_runeChecker;

		// Token: 0x0401E378 RID: 123768
		[Token(Token = "0x401E378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SquadMaxNumInfo m_squadMaxNumInfo;

		// Token: 0x0401E379 RID: 123769
		[Token(Token = "0x401E379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_runeStageId;

		// Token: 0x0401E37A RID: 123770
		[Token(Token = "0x401E37A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_squadSaveKey;

		// Token: 0x0401E37B RID: 123771
		[Token(Token = "0x401E37B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<RuneTable.PackedRuneData> m_selectedRunes;

		// Token: 0x0401E37C RID: 123772
		[Token(Token = "0x401E37C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401E37D RID: 123773
		[Token(Token = "0x401E37D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedRunes;

		// Token: 0x0401E37E RID: 123774
		[Token(Token = "0x401E37E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_MaxNum4CharSelect;

		// Token: 0x0401E37F RID: 123775
		[Token(Token = "0x401E37F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401E380 RID: 123776
		[Token(Token = "0x401E380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0401E381 RID: 123777
		[Token(Token = "0x401E381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadDataInternal;

		// Token: 0x0401E382 RID: 123778
		[Token(Token = "0x401E382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401E383 RID: 123779
		[Token(Token = "0x401E383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RestrictSquadMembers;

		// Token: 0x0401E384 RID: 123780
		[Token(Token = "0x401E384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0401E385 RID: 123781
		[Token(Token = "0x401E385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitCurSquad;

		// Token: 0x0401E386 RID: 123782
		[Token(Token = "0x401E386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsCurrentSquadEmpty;

		// Token: 0x0401E387 RID: 123783
		[Token(Token = "0x401E387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x0401E388 RID: 123784
		[Token(Token = "0x401E388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateSquadToStartBattle;

		// Token: 0x0401E389 RID: 123785
		[Token(Token = "0x401E389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x0401E38A RID: 123786
		[Token(Token = "0x401E38A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryLoadSquadForRune;

		// Token: 0x0401E38B RID: 123787
		[Token(Token = "0x401E38B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__MigrateSkillIfTmplChanged;

		// Token: 0x0401E38C RID: 123788
		[Token(Token = "0x401E38C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__MigrateEquipIfTmplChanged;

		// Token: 0x0401E38D RID: 123789
		[Token(Token = "0x401E38D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadFirstPlayerSquad;

		// Token: 0x0401E38E RID: 123790
		[Token(Token = "0x401E38E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ApplyToFriendAssistBean;

		// Token: 0x0401E38F RID: 123791
		[Token(Token = "0x401E38F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReceiveFromFriendAssistBean;

		// Token: 0x0401E390 RID: 123792
		[Token(Token = "0x401E390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SaveLocalCache;

		// Token: 0x0401E391 RID: 123793
		[Token(Token = "0x401E391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SaveSquadToCache;

		// Token: 0x0401E392 RID: 123794
		[Token(Token = "0x401E392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetCurSquadValidMemberNum;

		// Token: 0x0401E393 RID: 123795
		[Token(Token = "0x401E393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetSquadAssistNum;

		// Token: 0x0401E394 RID: 123796
		[Token(Token = "0x401E394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DEC RID: 15852
		[Token(Token = "0x2003DEC")]
		private struct SquadSlotCache : ISquadMemberCompInfo, IHotfixable
		{
			// Token: 0x06018A98 RID: 101016 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A98")]
			[Address(RVA = "0x11337D0", Offset = "0x11323D0", VA = "0x1811337D0")]
			public string GetSkillId(string tmplId)
			{
				return null;
			}

			// Token: 0x06018A99 RID: 101017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A99")]
			[Address(RVA = "0x11334F0", Offset = "0x11320F0", VA = "0x1811334F0", Slot = "6")]
			public string GetDefaultEquipId()
			{
				return null;
			}

			// Token: 0x06018A9A RID: 101018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A9A")]
			[Address(RVA = "0x1133660", Offset = "0x1132260", VA = "0x181133660")]
			public string GetEquipId(string tmplId)
			{
				return null;
			}

			// Token: 0x06018A9B RID: 101019 RVA: 0x0009B250 File Offset: 0x00099450
			[Token(Token = "0x6018A9B")]
			[Address(RVA = "0x1132BF0", Offset = "0x11317F0", VA = "0x181132BF0")]
			public static RuneSquadHomeStateBeanV1.SquadSlotCache Create(SquadItemStruct member)
			{
				return default(RuneSquadHomeStateBeanV1.SquadSlotCache);
			}

			// Token: 0x06018A9C RID: 101020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A9C")]
			[Address(RVA = "0x11333B0", Offset = "0x1131FB0", VA = "0x1811333B0", Slot = "4")]
			public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
			{
				return null;
			}

			// Token: 0x06018A9D RID: 101021 RVA: 0x0009B268 File Offset: 0x00099468
			[Token(Token = "0x6018A9D")]
			[Address(RVA = "0x11332C0", Offset = "0x1131EC0", VA = "0x1811332C0", Slot = "5")]
			public int ExtraTmplCount()
			{
				return 0;
			}

			// Token: 0x0401E395 RID: 123797
			[Token(Token = "0x401E395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int chrInstId;

			// Token: 0x0401E396 RID: 123798
			[Token(Token = "0x401E396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string charId;

			// Token: 0x0401E397 RID: 123799
			[Token(Token = "0x401E397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string tmplId;

			// Token: 0x0401E398 RID: 123800
			[Token(Token = "0x401E398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[JsonProperty("skillId")]
			private string m_skillId;

			// Token: 0x0401E399 RID: 123801
			[Token(Token = "0x401E399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[JsonProperty("equipId")]
			private string m_equipId;

			// Token: 0x0401E39A RID: 123802
			[Token(Token = "0x401E39A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string m_defaultEquipId;

			// Token: 0x0401E39B RID: 123803
			[Token(Token = "0x401E39B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ListDict<string, SquadSlotTmplPatch> tmpl;

			// Token: 0x0401E39C RID: 123804
			[Token(Token = "0x401E39C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetSkillId;

			// Token: 0x0401E39D RID: 123805
			[Token(Token = "0x401E39D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetDefaultEquipId;

			// Token: 0x0401E39E RID: 123806
			[Token(Token = "0x401E39E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetEquipId;

			// Token: 0x0401E39F RID: 123807
			[Token(Token = "0x401E39F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0401E3A0 RID: 123808
			[Token(Token = "0x401E3A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ExtraTmplInfo;

			// Token: 0x0401E3A1 RID: 123809
			[Token(Token = "0x401E3A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ExtraTmplCount;
		}

		// Token: 0x02003DEE RID: 15854
		[Token(Token = "0x2003DEE")]
		public struct FriendAssistDataStruct
		{
			// Token: 0x0401E3A6 RID: 123814
			[Token(Token = "0x401E3A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GetFriendAssistCharListResponse friendAssistResp;

			// Token: 0x0401E3A7 RID: 123815
			[Token(Token = "0x401E3A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isFromRemote;
		}

		// Token: 0x02003DEF RID: 15855
		[Token(Token = "0x2003DEF")]
		private class SquadConstrainPolicy : SquadGroupConstrainPolicy
		{
			// Token: 0x06018AA4 RID: 101028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018AA4")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public SquadConstrainPolicy(RuneSquadHomeStateBeanV1 closure)
			{
			}

			// Token: 0x06018AA5 RID: 101029 RVA: 0x0009B2B0 File Offset: 0x000994B0
			[Token(Token = "0x6018AA5")]
			[Address(RVA = "0x1122630", Offset = "0x1121230", VA = "0x181122630", Slot = "4")]
			public override bool CheckIfAssistLocked()
			{
				return default(bool);
			}

			// Token: 0x06018AA6 RID: 101030 RVA: 0x0009B2C8 File Offset: 0x000994C8
			[Token(Token = "0x6018AA6")]
			[Address(RVA = "0x1122700", Offset = "0x1121300", VA = "0x181122700", Slot = "5")]
			public override bool CheckIfSquadSlotLocked(SquadViewModel squad, int index)
			{
				return default(bool);
			}

			// Token: 0x0401E3A8 RID: 123816
			[Token(Token = "0x401E3A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RuneSquadHomeStateBeanV1 m_closure;
		}
	}
}
