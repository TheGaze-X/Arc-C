using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Scripts.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DFB RID: 15867
	[Token(Token = "0x2003DFB")]
	public class SquadHomeStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x06018AEC RID: 101100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC2")]
		public string stageId
		{
			[Token(Token = "0x6018AEC")]
			[Address(RVA = "0x11481B0", Offset = "0x1146DB0", VA = "0x1811481B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x06018AED RID: 101101 RVA: 0x0009B478 File Offset: 0x00099678
		[Token(Token = "0x17003AC3")]
		public bool isRetro
		{
			[Token(Token = "0x6018AED")]
			[Address(RVA = "0x1147EB0", Offset = "0x1146AB0", VA = "0x181147EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x06018AEE RID: 101102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC4")]
		public List<string> charmList
		{
			[Token(Token = "0x6018AEE")]
			[Address(RVA = "0x1147930", Offset = "0x1146530", VA = "0x181147930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x06018AEF RID: 101103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC5")]
		public List<string> techBranchList
		{
			[Token(Token = "0x6018AEF")]
			[Address(RVA = "0x1148210", Offset = "0x1146E10", VA = "0x181148210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x06018AF0 RID: 101104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC6")]
		public string fireworkAnimalId
		{
			[Token(Token = "0x6018AF0")]
			[Address(RVA = "0x1147BD0", Offset = "0x11467D0", VA = "0x181147BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x06018AF1 RID: 101105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC7")]
		public List<FireworkData.PlateSlotData> fireworkSlotList
		{
			[Token(Token = "0x6018AF1")]
			[Address(RVA = "0x1147C30", Offset = "0x1146830", VA = "0x181147C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x06018AF2 RID: 101106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC8")]
		public Dictionary<CartComponents.CartAccessoryPos, string> cartComponentsDict
		{
			[Token(Token = "0x6018AF2")]
			[Address(RVA = "0x11478D0", Offset = "0x11464D0", VA = "0x1811478D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x06018AF3 RID: 101107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AC9")]
		public List<string> trapToolList
		{
			[Token(Token = "0x6018AF3")]
			[Address(RVA = "0x1148270", Offset = "0x1146E70", VA = "0x181148270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x06018AF4 RID: 101108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ACA")]
		public List<string> battlePerformanceList
		{
			[Token(Token = "0x6018AF4")]
			[Address(RVA = "0x1147870", Offset = "0x1146470", VA = "0x181147870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x06018AF5 RID: 101109 RVA: 0x0009B490 File Offset: 0x00099690
		[Token(Token = "0x17003ACB")]
		public bool isSquadImmutable
		{
			[Token(Token = "0x6018AF5")]
			[Address(RVA = "0x1147F70", Offset = "0x1146B70", VA = "0x181147F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x06018AF6 RID: 101110 RVA: 0x0009B4A8 File Offset: 0x000996A8
		[Token(Token = "0x17003ACC")]
		public bool isSkillSelectablePredefine
		{
			[Token(Token = "0x6018AF6")]
			[Address(RVA = "0x1147F10", Offset = "0x1146B10", VA = "0x181147F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x06018AF7 RID: 101111 RVA: 0x0009B4C0 File Offset: 0x000996C0
		[Token(Token = "0x17003ACD")]
		public bool isSquadValid
		{
			[Token(Token = "0x6018AF7")]
			[Address(RVA = "0x1147FD0", Offset = "0x1146BD0", VA = "0x181147FD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x06018AF8 RID: 101112 RVA: 0x0009B4D8 File Offset: 0x000996D8
		[Token(Token = "0x17003ACE")]
		public bool isFriendLegal
		{
			[Token(Token = "0x6018AF8")]
			[Address(RVA = "0x1147C90", Offset = "0x1146890", VA = "0x181147C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x06018AF9 RID: 101113 RVA: 0x0009B4F0 File Offset: 0x000996F0
		[Token(Token = "0x17003ACF")]
		public bool allowStartBattle
		{
			[Token(Token = "0x6018AF9")]
			[Address(RVA = "0x11477F0", Offset = "0x11463F0", VA = "0x1811477F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x06018AFA RID: 101114 RVA: 0x0009B508 File Offset: 0x00099708
		[Token(Token = "0x17003AD0")]
		public bool allowAssistChar
		{
			[Token(Token = "0x6018AFA")]
			[Address(RVA = "0x11476C0", Offset = "0x11462C0", VA = "0x1811476C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x06018AFB RID: 101115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AD1")]
		public List<RuneTable.PackedRuneData> optionalPackedRunes
		{
			[Token(Token = "0x6018AFB")]
			[Address(RVA = "0x1148030", Offset = "0x1146C30", VA = "0x181148030")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018AFC RID: 101116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AFC")]
		[Address(RVA = "0x11443E0", Offset = "0x1142FE0", VA = "0x1811443E0")]
		public void LoadData(SquadHomeStateBean.SquadHomeStateBeanParam param)
		{
		}

		// Token: 0x06018AFD RID: 101117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AFD")]
		[Address(RVA = "0x1143640", Offset = "0x1142240", VA = "0x181143640")]
		public void CleanAssistChar()
		{
		}

		// Token: 0x06018AFE RID: 101118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AFE")]
		[Address(RVA = "0x11451A0", Offset = "0x1143DA0", VA = "0x1811451A0")]
		public void RefreshData()
		{
		}

		// Token: 0x06018AFF RID: 101119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AFF")]
		[Address(RVA = "0x11471E0", Offset = "0x1145DE0", VA = "0x1811471E0")]
		private void _TryReloadSquadData()
		{
		}

		// Token: 0x06018B00 RID: 101120 RVA: 0x0009B520 File Offset: 0x00099720
		[Token(Token = "0x6018B00")]
		[Address(RVA = "0x1142FF0", Offset = "0x1141BF0", VA = "0x181142FF0")]
		public bool CheckIfSquadChanged()
		{
			return default(bool);
		}

		// Token: 0x06018B01 RID: 101121 RVA: 0x0009B538 File Offset: 0x00099738
		[Token(Token = "0x6018B01")]
		[Address(RVA = "0x1142C80", Offset = "0x1141880", VA = "0x181142C80")]
		public bool CheckIfPredefinedSkillChanged()
		{
			return default(bool);
		}

		// Token: 0x06018B02 RID: 101122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B02")]
		[Address(RVA = "0x1143740", Offset = "0x1142340", VA = "0x181143740")]
		public SquadItemStruct[] CreateSquadToStartBattle()
		{
			return null;
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x06018B03 RID: 101123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AD2")]
		public SquadItemStruct[] predefinedSquad
		{
			[Token(Token = "0x6018B03")]
			[Address(RVA = "0x1148090", Offset = "0x1146C90", VA = "0x181148090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x06018B04 RID: 101124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AD3")]
		private SquadItemStruct[] currentSquad
		{
			[Token(Token = "0x6018B04")]
			[Address(RVA = "0x1147AA0", Offset = "0x11466A0", VA = "0x181147AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x06018B05 RID: 101125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AD4")]
		private SharedCharData currentFriendAssist
		{
			[Token(Token = "0x6018B05")]
			[Address(RVA = "0x1147990", Offset = "0x1146590", VA = "0x181147990")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018B06 RID: 101126 RVA: 0x0009B550 File Offset: 0x00099750
		[Token(Token = "0x6018B06")]
		[Address(RVA = "0x1144230", Offset = "0x1142E30", VA = "0x181144230")]
		public bool IsCurrentSquadEmpty()
		{
			return default(bool);
		}

		// Token: 0x06018B07 RID: 101127 RVA: 0x0009B568 File Offset: 0x00099768
		[Token(Token = "0x6018B07")]
		[Address(RVA = "0x11428E0", Offset = "0x11414E0", VA = "0x1811428E0")]
		public bool CanStartBattleWithEmptySquad()
		{
			return default(bool);
		}

		// Token: 0x06018B08 RID: 101128 RVA: 0x0009B580 File Offset: 0x00099780
		[Token(Token = "0x6018B08")]
		[Address(RVA = "0x1142940", Offset = "0x1141540", VA = "0x181142940")]
		public ExternalRuneChecker.CheckSquadResult CheckCurrentSquadHasExcludedChar()
		{
			return ExternalRuneChecker.CheckSquadResult.PASS_THROUGH;
		}

		// Token: 0x06018B09 RID: 101129 RVA: 0x0009B598 File Offset: 0x00099798
		[Token(Token = "0x6018B09")]
		[Address(RVA = "0x1142BD0", Offset = "0x11417D0", VA = "0x181142BD0")]
		public bool CheckIfCharValid(CharQuery query)
		{
			return default(bool);
		}

		// Token: 0x06018B0A RID: 101130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B0A")]
		[Address(RVA = "0x11449D0", Offset = "0x11435D0", VA = "0x1811449D0")]
		public void LoadExcludedCharInCurrentSquad(List<SquadItemStruct> result)
		{
		}

		// Token: 0x06018B0B RID: 101131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B0B")]
		[Address(RVA = "0x1144C50", Offset = "0x1143850", VA = "0x181144C50")]
		public CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x06018B0C RID: 101132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B0C")]
		[Address(RVA = "0x1142760", Offset = "0x1141360", VA = "0x181142760")]
		public void ApplyToFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06018B0D RID: 101133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B0D")]
		[Address(RVA = "0x11450B0", Offset = "0x1143CB0", VA = "0x1811450B0")]
		public void ReceiveFromFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06018B0E RID: 101134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B0E")]
		[Address(RVA = "0x11436D0", Offset = "0x11422D0", VA = "0x1811436D0")]
		public void CleanFriendCache()
		{
		}

		// Token: 0x06018B0F RID: 101135 RVA: 0x0009B5B0 File Offset: 0x000997B0
		[Token(Token = "0x6018B0F")]
		[Address(RVA = "0x1143370", Offset = "0x1141F70", VA = "0x181143370")]
		public bool CheckRequiredCharIncluded()
		{
			return default(bool);
		}

		// Token: 0x06018B10 RID: 101136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B10")]
		[Address(RVA = "0x11438C0", Offset = "0x11424C0", VA = "0x1811438C0")]
		public List<StageStartCond.RequireChar> GetRequireChars()
		{
			return null;
		}

		// Token: 0x06018B11 RID: 101137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B11")]
		[Address(RVA = "0x1144A90", Offset = "0x1143690", VA = "0x181144A90")]
		public void LoadRequiredCharStatus(StageStartCond.RequireChar requiredChar, out bool isCharIncluded, out bool isEvolveMatch)
		{
		}

		// Token: 0x06018B12 RID: 101138 RVA: 0x0009B5C8 File Offset: 0x000997C8
		[Token(Token = "0x6018B12")]
		[Address(RVA = "0x1142A30", Offset = "0x1141630", VA = "0x181142A30")]
		public bool CheckIfCharRequired(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018B13 RID: 101139 RVA: 0x0009B5E0 File Offset: 0x000997E0
		[Token(Token = "0x6018B13")]
		[Address(RVA = "0x1142F50", Offset = "0x1141B50", VA = "0x181142F50")]
		public bool CheckIfPredefinedSquadSkillChanged(string activityId)
		{
			return default(bool);
		}

		// Token: 0x06018B14 RID: 101140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B14")]
		[Address(RVA = "0x1143B60", Offset = "0x1142760", VA = "0x181143B60")]
		public static List<RuneTable.PackedRuneData> GetRuneListByCharms(List<string> charmList)
		{
			return null;
		}

		// Token: 0x06018B15 RID: 101141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B15")]
		[Address(RVA = "0x1143CF0", Offset = "0x11428F0", VA = "0x181143CF0")]
		public static List<RuneTable.PackedRuneData> GetRuneListByTeches(bool isRetro, string groupId, List<string> techBranchList)
		{
			return null;
		}

		// Token: 0x06018B16 RID: 101142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B16")]
		[Address(RVA = "0x1143990", Offset = "0x1142590", VA = "0x181143990")]
		public static List<RuneTable.PackedRuneData> GetRuneListByBattlePerformances(bool isRetro, string groupId, List<string> battlePerformanceList)
		{
			return null;
		}

		// Token: 0x06018B17 RID: 101143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B17")]
		[Address(RVA = "0x1143FE0", Offset = "0x1142BE0", VA = "0x181143FE0")]
		public static List<RuneTable.PackedRuneData> GetRuneListByTrapTools(string groupId, List<string> trapList)
		{
			return null;
		}

		// Token: 0x06018B18 RID: 101144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B18")]
		[Address(RVA = "0x1145F80", Offset = "0x1144B80", VA = "0x181145F80")]
		private void _RefreshCharmsList()
		{
		}

		// Token: 0x06018B19 RID: 101145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B19")]
		[Address(RVA = "0x11467A0", Offset = "0x11453A0", VA = "0x1811467A0")]
		private void _RefreshTechesList()
		{
		}

		// Token: 0x06018B1A RID: 101146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B1A")]
		[Address(RVA = "0x1145AB0", Offset = "0x11446B0", VA = "0x181145AB0")]
		private void _RefreshCarComponentDict()
		{
		}

		// Token: 0x06018B1B RID: 101147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B1B")]
		[Address(RVA = "0x1145720", Offset = "0x1144320", VA = "0x181145720")]
		private void _RefreshBattlePerformanceList()
		{
		}

		// Token: 0x06018B1C RID: 101148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B1C")]
		[Address(RVA = "0x1146C60", Offset = "0x1145860", VA = "0x181146C60")]
		private void _RefreshTrapToolsList()
		{
		}

		// Token: 0x06018B1D RID: 101149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B1D")]
		[Address(RVA = "0x1146340", Offset = "0x1144F40", VA = "0x181146340")]
		private void _RefreshFireworkList()
		{
		}

		// Token: 0x06018B1E RID: 101150 RVA: 0x0009B5F8 File Offset: 0x000997F8
		[Token(Token = "0x6018B1E")]
		[Address(RVA = "0x11456A0", Offset = "0x11442A0", VA = "0x1811456A0")]
		private bool _IsStagePassed(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06018B1F RID: 101151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B1F")]
		[Address(RVA = "0x1145240", Offset = "0x1143E40", VA = "0x181145240")]
		private List<RuneTable.PackedRuneData> _GeneOptionalPackedRuneData(List<string> optionalRuneKeys, LevelData levelData)
		{
			return null;
		}

		// Token: 0x06018B20 RID: 101152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B20")]
		[Address(RVA = "0x1147360", Offset = "0x1145F60", VA = "0x181147360")]
		public SquadHomeStateBean()
		{
		}

		// Token: 0x0401E434 RID: 123956
		[Token(Token = "0x401E434")]
		[FieldOffset(Offset = "0x18")]
		public SquadGroupViewProperty squadGroupProperty;

		// Token: 0x0401E435 RID: 123957
		[Token(Token = "0x401E435")]
		[FieldOffset(Offset = "0x20")]
		public SquadLayoutProperty squadLayoutProperty;

		// Token: 0x0401E436 RID: 123958
		[Token(Token = "0x401E436")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int renameSquadId;

		// Token: 0x0401E437 RID: 123959
		[Token(Token = "0x401E437")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public SquadHomeStateBean.FriendAssistDataStruct friendDataCache;

		// Token: 0x0401E438 RID: 123960
		[Token(Token = "0x401E438")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public ProfessionCategory assistProfession;

		// Token: 0x0401E439 RID: 123961
		[Token(Token = "0x401E439")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		public SquadMode squadMode;

		// Token: 0x0401E43A RID: 123962
		[Token(Token = "0x401E43A")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public SquadStartButtonTypeEnum startButtonMode;

		// Token: 0x0401E43B RID: 123963
		[Token(Token = "0x401E43B")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public string startButtonOverrideId;

		// Token: 0x0401E43C RID: 123964
		[Token(Token = "0x401E43C")]
		[FieldOffset(Offset = "0x58")]
		private ExternalRuneChecker m_externalRuneChecker;

		// Token: 0x0401E43D RID: 123965
		[Token(Token = "0x401E43D")]
		[FieldOffset(Offset = "0x60")]
		private SquadMaxNumInfo m_squadMaxNumInfo;

		// Token: 0x0401E43E RID: 123966
		[Token(Token = "0x401E43E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isSquadValid;

		// Token: 0x0401E43F RID: 123967
		[Token(Token = "0x401E43F")]
		[FieldOffset(Offset = "0x70")]
		private string m_stageId;

		// Token: 0x0401E440 RID: 123968
		[Token(Token = "0x401E440")]
		[FieldOffset(Offset = "0x78")]
		private LevelData.PredefinedData.PredefinedCard[] m_cachedPredefine;

		// Token: 0x0401E441 RID: 123969
		[Token(Token = "0x401E441")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isRetro;

		// Token: 0x0401E442 RID: 123970
		[Token(Token = "0x401E442")]
		[FieldOffset(Offset = "0x88")]
		private List<string> m_charmList;

		// Token: 0x0401E443 RID: 123971
		[Token(Token = "0x401E443")]
		[FieldOffset(Offset = "0x90")]
		private List<string> m_techBranchList;

		// Token: 0x0401E444 RID: 123972
		[Token(Token = "0x401E444")]
		[FieldOffset(Offset = "0x98")]
		private string m_fireworkAnimalId;

		// Token: 0x0401E445 RID: 123973
		[Token(Token = "0x401E445")]
		[FieldOffset(Offset = "0xA0")]
		private List<FireworkData.PlateSlotData> m_fireworkSlotList;

		// Token: 0x0401E446 RID: 123974
		[Token(Token = "0x401E446")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<CartComponents.CartAccessoryPos, string> m_cartComponentsDict;

		// Token: 0x0401E447 RID: 123975
		[Token(Token = "0x401E447")]
		[FieldOffset(Offset = "0xB0")]
		private List<string> m_trapToolList;

		// Token: 0x0401E448 RID: 123976
		[Token(Token = "0x401E448")]
		[FieldOffset(Offset = "0xB8")]
		private List<string> m_battlePerformanceList;

		// Token: 0x0401E449 RID: 123977
		[Token(Token = "0x401E449")]
		[FieldOffset(Offset = "0xC0")]
		private List<RuneTable.PackedRuneData> m_optionalRunes;

		// Token: 0x0401E44A RID: 123978
		[Token(Token = "0x401E44A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401E44B RID: 123979
		[Token(Token = "0x401E44B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x0401E44C RID: 123980
		[Token(Token = "0x401E44C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charmList;

		// Token: 0x0401E44D RID: 123981
		[Token(Token = "0x401E44D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_techBranchList;

		// Token: 0x0401E44E RID: 123982
		[Token(Token = "0x401E44E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fireworkAnimalId;

		// Token: 0x0401E44F RID: 123983
		[Token(Token = "0x401E44F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_fireworkSlotList;

		// Token: 0x0401E450 RID: 123984
		[Token(Token = "0x401E450")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cartComponentsDict;

		// Token: 0x0401E451 RID: 123985
		[Token(Token = "0x401E451")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_trapToolList;

		// Token: 0x0401E452 RID: 123986
		[Token(Token = "0x401E452")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_battlePerformanceList;

		// Token: 0x0401E453 RID: 123987
		[Token(Token = "0x401E453")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isSquadImmutable;

		// Token: 0x0401E454 RID: 123988
		[Token(Token = "0x401E454")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isSkillSelectablePredefine;

		// Token: 0x0401E455 RID: 123989
		[Token(Token = "0x401E455")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isSquadValid;

		// Token: 0x0401E456 RID: 123990
		[Token(Token = "0x401E456")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isFriendLegal;

		// Token: 0x0401E457 RID: 123991
		[Token(Token = "0x401E457")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_allowStartBattle;

		// Token: 0x0401E458 RID: 123992
		[Token(Token = "0x401E458")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_allowAssistChar;

		// Token: 0x0401E459 RID: 123993
		[Token(Token = "0x401E459")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_optionalPackedRunes;

		// Token: 0x0401E45A RID: 123994
		[Token(Token = "0x401E45A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401E45B RID: 123995
		[Token(Token = "0x401E45B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CleanAssistChar;

		// Token: 0x0401E45C RID: 123996
		[Token(Token = "0x401E45C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E45D RID: 123997
		[Token(Token = "0x401E45D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryReloadSquadData;

		// Token: 0x0401E45E RID: 123998
		[Token(Token = "0x401E45E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CheckIfSquadChanged;

		// Token: 0x0401E45F RID: 123999
		[Token(Token = "0x401E45F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckIfPredefinedSkillChanged;

		// Token: 0x0401E460 RID: 124000
		[Token(Token = "0x401E460")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CreateSquadToStartBattle;

		// Token: 0x0401E461 RID: 124001
		[Token(Token = "0x401E461")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_predefinedSquad;

		// Token: 0x0401E462 RID: 124002
		[Token(Token = "0x401E462")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_currentSquad;

		// Token: 0x0401E463 RID: 124003
		[Token(Token = "0x401E463")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_currentFriendAssist;

		// Token: 0x0401E464 RID: 124004
		[Token(Token = "0x401E464")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_IsCurrentSquadEmpty;

		// Token: 0x0401E465 RID: 124005
		[Token(Token = "0x401E465")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CanStartBattleWithEmptySquad;

		// Token: 0x0401E466 RID: 124006
		[Token(Token = "0x401E466")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckCurrentSquadHasExcludedChar;

		// Token: 0x0401E467 RID: 124007
		[Token(Token = "0x401E467")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0401E468 RID: 124008
		[Token(Token = "0x401E468")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadExcludedCharInCurrentSquad;

		// Token: 0x0401E469 RID: 124009
		[Token(Token = "0x401E469")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x0401E46A RID: 124010
		[Token(Token = "0x401E46A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ApplyToFriendAssistBean;

		// Token: 0x0401E46B RID: 124011
		[Token(Token = "0x401E46B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ReceiveFromFriendAssistBean;

		// Token: 0x0401E46C RID: 124012
		[Token(Token = "0x401E46C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CleanFriendCache;

		// Token: 0x0401E46D RID: 124013
		[Token(Token = "0x401E46D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckRequiredCharIncluded;

		// Token: 0x0401E46E RID: 124014
		[Token(Token = "0x401E46E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetRequireChars;

		// Token: 0x0401E46F RID: 124015
		[Token(Token = "0x401E46F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_LoadRequiredCharStatus;

		// Token: 0x0401E470 RID: 124016
		[Token(Token = "0x401E470")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckIfCharRequired;

		// Token: 0x0401E471 RID: 124017
		[Token(Token = "0x401E471")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckIfPredefinedSquadSkillChanged;

		// Token: 0x0401E472 RID: 124018
		[Token(Token = "0x401E472")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetRuneListByCharms;

		// Token: 0x0401E473 RID: 124019
		[Token(Token = "0x401E473")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetRuneListByTeches;

		// Token: 0x0401E474 RID: 124020
		[Token(Token = "0x401E474")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetRuneListByBattlePerformances;

		// Token: 0x0401E475 RID: 124021
		[Token(Token = "0x401E475")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetRuneListByTrapTools;

		// Token: 0x0401E476 RID: 124022
		[Token(Token = "0x401E476")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__RefreshCharmsList;

		// Token: 0x0401E477 RID: 124023
		[Token(Token = "0x401E477")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__RefreshTechesList;

		// Token: 0x0401E478 RID: 124024
		[Token(Token = "0x401E478")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__RefreshCarComponentDict;

		// Token: 0x0401E479 RID: 124025
		[Token(Token = "0x401E479")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__RefreshBattlePerformanceList;

		// Token: 0x0401E47A RID: 124026
		[Token(Token = "0x401E47A")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__RefreshTrapToolsList;

		// Token: 0x0401E47B RID: 124027
		[Token(Token = "0x401E47B")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__RefreshFireworkList;

		// Token: 0x0401E47C RID: 124028
		[Token(Token = "0x401E47C")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__IsStagePassed;

		// Token: 0x0401E47D RID: 124029
		[Token(Token = "0x401E47D")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__GeneOptionalPackedRuneData;

		// Token: 0x0401E47E RID: 124030
		[Token(Token = "0x401E47E")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DFC RID: 15868
		[Token(Token = "0x2003DFC")]
		public struct FriendAssistDataStruct
		{
			// Token: 0x0401E47F RID: 124031
			[Token(Token = "0x401E47F")]
			[FieldOffset(Offset = "0x0")]
			public GetFriendAssistCharListResponse friendAssistResp;

			// Token: 0x0401E480 RID: 124032
			[Token(Token = "0x401E480")]
			[FieldOffset(Offset = "0x8")]
			public bool isFromRemote;
		}

		// Token: 0x02003DFD RID: 15869
		[Token(Token = "0x2003DFD")]
		public struct SquadHomeStateBeanParam
		{
			// Token: 0x0401E481 RID: 124033
			[Token(Token = "0x401E481")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x0401E482 RID: 124034
			[Token(Token = "0x401E482")]
			[FieldOffset(Offset = "0x8")]
			public bool isRetro;

			// Token: 0x0401E483 RID: 124035
			[Token(Token = "0x401E483")]
			[FieldOffset(Offset = "0x9")]
			public bool isAutoBattle;

			// Token: 0x0401E484 RID: 124036
			[Token(Token = "0x401E484")]
			[FieldOffset(Offset = "0xA")]
			public bool isPractice;

			// Token: 0x0401E485 RID: 124037
			[Token(Token = "0x401E485")]
			[FieldOffset(Offset = "0x10")]
			public List<string> optionalRuneKeys;
		}
	}
}
