using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DE5 RID: 15845
	[Token(Token = "0x2003DE5")]
	public class ExternalRuneChecker
	{
		// Token: 0x06018A60 RID: 100960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A60")]
		[Address(RVA = "0x111E070", Offset = "0x111CC70", VA = "0x18111E070")]
		public ExternalRuneChecker()
		{
		}

		// Token: 0x06018A61 RID: 100961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A61")]
		[Address(RVA = "0x111DF70", Offset = "0x111CB70", VA = "0x18111DF70")]
		public ExternalRuneChecker(StageData stageData, LevelData levelData)
		{
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A62")]
		[Address(RVA = "0x111D060", Offset = "0x111BC60", VA = "0x18111D060")]
		public void LoadData(StageData stageData, LevelData levelData, [Optional] List<RuneTable.PackedRuneData> selectedRunes)
		{
		}

		// Token: 0x06018A63 RID: 100963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A63")]
		[Address(RVA = "0x111D080", Offset = "0x111BC80", VA = "0x18111D080")]
		public void LoadData(LevelData levelData, List<RuneTable.PackedRuneData> selectedRunes)
		{
		}

		// Token: 0x06018A64 RID: 100964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A64")]
		[Address(RVA = "0x111D870", Offset = "0x111C470", VA = "0x18111D870")]
		private void _LoadDataImpl(LevelData.Difficulty difficulty, LevelData levelData, List<RuneTable.PackedRuneData> selectedRunes)
		{
		}

		// Token: 0x06018A65 RID: 100965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A65")]
		private void _ApplyExcludeOrSquadNumChangeRunes<RuneDataType>(string runeKey, RuneDataType runeData, Func<RuneDataType, RuneData> convertRuneData, ref int runeLimitNum, ref int runeModifyNum)
		{
		}

		// Token: 0x06018A66 RID: 100966 RVA: 0x0009B040 File Offset: 0x00099240
		[Token(Token = "0x6018A66")]
		[Address(RVA = "0x111CC70", Offset = "0x111B870", VA = "0x18111CC70")]
		public ExternalRuneChecker.CheckSquadResult CheckSquadHasExcludedCharOrLimit(IList<SquadItemStruct> squad, SharedCharData friendAssist, int maxSquadNum)
		{
			return ExternalRuneChecker.CheckSquadResult.PASS_THROUGH;
		}

		// Token: 0x06018A67 RID: 100967 RVA: 0x0009B058 File Offset: 0x00099258
		[Token(Token = "0x6018A67")]
		[Address(RVA = "0x111CB80", Offset = "0x111B780", VA = "0x18111CB80")]
		public bool CheckIfCharValid(CharQuery query)
		{
			return default(bool);
		}

		// Token: 0x06018A68 RID: 100968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A68")]
		[Address(RVA = "0x111D0B0", Offset = "0x111BCB0", VA = "0x18111D0B0")]
		public void LoadExcludedCharInSquad(IList<SquadItemStruct> squad, SharedCharData friendAssist, List<SquadItemStruct> result)
		{
		}

		// Token: 0x06018A69 RID: 100969 RVA: 0x0009B070 File Offset: 0x00099270
		[Token(Token = "0x6018A69")]
		[Address(RVA = "0x111D530", Offset = "0x111C130", VA = "0x18111D530")]
		public bool TryGetSquadNumChangeInfo(out ExternalRuneChecker.SquadNumChangeInfoByRune changeInfoByRune)
		{
			return default(bool);
		}

		// Token: 0x06018A6A RID: 100970 RVA: 0x0009B088 File Offset: 0x00099288
		[Token(Token = "0x6018A6A")]
		[Address(RVA = "0x111D590", Offset = "0x111C190", VA = "0x18111D590")]
		private bool _CheckIsFriendAssistExcluded(SharedCharData friendAssist)
		{
			return default(bool);
		}

		// Token: 0x06018A6B RID: 100971 RVA: 0x0009B0A0 File Offset: 0x000992A0
		[Token(Token = "0x6018A6B")]
		[Address(RVA = "0x111DE30", Offset = "0x111CA30", VA = "0x18111DE30")]
		private static bool _TryGetSquadNumLimitFromRuneData(RuneData runeData, out int squadNumLimit)
		{
			return default(bool);
		}

		// Token: 0x06018A6C RID: 100972 RVA: 0x0009B0B8 File Offset: 0x000992B8
		[Token(Token = "0x6018A6C")]
		[Address(RVA = "0x111DED0", Offset = "0x111CAD0", VA = "0x18111DED0")]
		private static bool _TryGetSquadNumModifyFromRuneData(RuneData runeData, out int squadNumModify)
		{
			return default(bool);
		}

		// Token: 0x06018A6D RID: 100973 RVA: 0x0009B0D0 File Offset: 0x000992D0
		[Token(Token = "0x6018A6D")]
		[Address(RVA = "0x111D6D0", Offset = "0x111C2D0", VA = "0x18111D6D0")]
		private static int _GetValidSquadCharNum(IList<SquadItemStruct> squad, SharedCharData friendAssist)
		{
			return 0;
		}

		// Token: 0x0401E35F RID: 123743
		[Token(Token = "0x401E35F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<ExternalRuneChecker.ExcludeRune> m_excludeRunes;

		// Token: 0x0401E360 RID: 123744
		[Token(Token = "0x401E360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string[] m_commonExcludeCharIdList;

		// Token: 0x0401E361 RID: 123745
		[Token(Token = "0x401E361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ExternalRuneChecker.SquadNumChangeInfoByRune m_squadNumChangeInfo;

		// Token: 0x02003DE6 RID: 15846
		[Token(Token = "0x2003DE6")]
		public enum CheckSquadResult
		{
			// Token: 0x0401E363 RID: 123747
			[Token(Token = "0x401E363")]
			PASS_THROUGH,
			// Token: 0x0401E364 RID: 123748
			[Token(Token = "0x401E364")]
			PROMPT_EXCLUDED_CHARS,
			// Token: 0x0401E365 RID: 123749
			[Token(Token = "0x401E365")]
			DENIED_SQUAD_NUM_EXCEEDED
		}

		// Token: 0x02003DE7 RID: 15847
		[Token(Token = "0x2003DE7")]
		public struct SquadNumChangeInfoByRune : IHotfixable
		{
			// Token: 0x17003AB4 RID: 15028
			// (get) Token: 0x06018A6E RID: 100974 RVA: 0x0009B0E8 File Offset: 0x000992E8
			[Token(Token = "0x17003AB4")]
			public int squadLimitByRune
			{
				[Token(Token = "0x6018A6E")]
				[Address(RVA = "0x1131550", Offset = "0x1130150", VA = "0x181131550")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17003AB5 RID: 15029
			// (get) Token: 0x06018A6F RID: 100975 RVA: 0x0009B100 File Offset: 0x00099300
			[Token(Token = "0x17003AB5")]
			public int squadModifyByRune
			{
				[Token(Token = "0x6018A6F")]
				[Address(RVA = "0x11315C0", Offset = "0x11301C0", VA = "0x1811315C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018A70 RID: 100976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A70")]
			[Address(RVA = "0x11314C0", Offset = "0x11300C0", VA = "0x1811314C0")]
			public SquadNumChangeInfoByRune(int limitByRune, int modifyByRune)
			{
			}

			// Token: 0x06018A71 RID: 100977 RVA: 0x0009B118 File Offset: 0x00099318
			[Token(Token = "0x6018A71")]
			[Address(RVA = "0x11312A0", Offset = "0x112FEA0", VA = "0x1811312A0")]
			public bool HasNumChangedByRune()
			{
				return default(bool);
			}

			// Token: 0x06018A72 RID: 100978 RVA: 0x0009B130 File Offset: 0x00099330
			[Token(Token = "0x6018A72")]
			[Address(RVA = "0x1131160", Offset = "0x112FD60", VA = "0x181131160")]
			public int GetSquadMaxCharNum(int squadRawMax)
			{
				return 0;
			}

			// Token: 0x06018A73 RID: 100979 RVA: 0x0009B148 File Offset: 0x00099348
			[Token(Token = "0x6018A73")]
			[Address(RVA = "0x1131380", Offset = "0x112FF80", VA = "0x181131380")]
			private bool _HasNumLimitedByRune()
			{
				return default(bool);
			}

			// Token: 0x0401E366 RID: 123750
			[Token(Token = "0x401E366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int m_squadLimitByRune;

			// Token: 0x0401E367 RID: 123751
			[Token(Token = "0x401E367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private readonly int m_squadModifyByRune;

			// Token: 0x0401E368 RID: 123752
			[Token(Token = "0x401E368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ExternalRuneChecker.SquadNumChangeInfoByRune EMPTY;

			// Token: 0x0401E369 RID: 123753
			[Token(Token = "0x401E369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_squadLimitByRune;

			// Token: 0x0401E36A RID: 123754
			[Token(Token = "0x401E36A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_squadModifyByRune;

			// Token: 0x0401E36B RID: 123755
			[Token(Token = "0x401E36B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E36C RID: 123756
			[Token(Token = "0x401E36C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HasNumChangedByRune;

			// Token: 0x0401E36D RID: 123757
			[Token(Token = "0x401E36D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetSquadMaxCharNum;

			// Token: 0x0401E36E RID: 123758
			[Token(Token = "0x401E36E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__HasNumLimitedByRune;
		}

		// Token: 0x02003DE8 RID: 15848
		[Token(Token = "0x2003DE8")]
		private class ExcludeRune
		{
			// Token: 0x17003AB6 RID: 15030
			// (get) Token: 0x06018A75 RID: 100981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AB6")]
			private Blackboard blackboard
			{
				[Token(Token = "0x6018A75")]
				[Address(RVA = "0x111CB60", Offset = "0x111B760", VA = "0x18111CB60")]
				get
				{
					return null;
				}
			}

			// Token: 0x06018A76 RID: 100982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A76")]
			[Address(RVA = "0x111CA40", Offset = "0x111B640", VA = "0x18111CA40")]
			public ExcludeRune(RuneData data)
			{
			}

			// Token: 0x06018A77 RID: 100983 RVA: 0x0009B160 File Offset: 0x00099360
			[Token(Token = "0x6018A77")]
			[Address(RVA = "0x111C8A0", Offset = "0x111B4A0", VA = "0x18111C8A0")]
			public bool CheckExcluded(CharacterCardViewModel cardModel)
			{
				return default(bool);
			}

			// Token: 0x06018A78 RID: 100984 RVA: 0x0009B178 File Offset: 0x00099378
			[Token(Token = "0x6018A78")]
			[Address(RVA = "0x111C760", Offset = "0x111B360", VA = "0x18111C760")]
			public bool CheckExcluded(CharQuery charQuery)
			{
				return default(bool);
			}

			// Token: 0x06018A79 RID: 100985 RVA: 0x0009B190 File Offset: 0x00099390
			[Token(Token = "0x6018A79")]
			[Address(RVA = "0x111C990", Offset = "0x111B590", VA = "0x18111C990")]
			private bool _CheckExcluded(string charId, ProfessionCategory profession, BuildableType buildableType)
			{
				return default(bool);
			}

			// Token: 0x0401E36F RID: 123759
			[Token(Token = "0x401E36F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RuneData m_data;

			// Token: 0x0401E370 RID: 123760
			[Token(Token = "0x401E370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string[] m_charIdList;
		}
	}
}
