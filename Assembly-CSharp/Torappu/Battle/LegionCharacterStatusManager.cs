using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Legion;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200223C RID: 8764
	[Token(Token = "0x200223C")]
	public class LegionCharacterStatusManager : IHotfixable
	{
		// Token: 0x0600DC2A RID: 56362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC2A")]
		[Address(RVA = "0x3621650", Offset = "0x3620250", VA = "0x183621650")]
		public void Init(GameModeFactory.LegionGameMode legionMode)
		{
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC2B")]
		[Address(RVA = "0x36221F0", Offset = "0x3620DF0", VA = "0x1836221F0")]
		public void ResetCharStatusInfo(List<BattleCharacterData> charDataList)
		{
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x00050628 File Offset: 0x0004E828
		[Token(Token = "0x600DC2C")]
		[Address(RVA = "0x36228F0", Offset = "0x36214F0", VA = "0x1836228F0")]
		private int _GetCharLevelDefaultAddCnt(Character character)
		{
			return 0;
		}

		// Token: 0x0600DC2D RID: 56365 RVA: 0x00050640 File Offset: 0x0004E840
		[Token(Token = "0x600DC2D")]
		[Address(RVA = "0x3621470", Offset = "0x3620070", VA = "0x183621470")]
		public int GetStatusBuffMaxCnt(Character character)
		{
			return 0;
		}

		// Token: 0x0600DC2E RID: 56366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC2E")]
		[Address(RVA = "0x3621AE0", Offset = "0x36206E0", VA = "0x183621AE0")]
		public void ModifyProfessionBuffMaxCnt(Character character, int addValue, bool isReset)
		{
		}

		// Token: 0x0600DC2F RID: 56367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC2F")]
		[Address(RVA = "0x3621920", Offset = "0x3620520", VA = "0x183621920")]
		public void ModifyProfessionBuffDefaultAddCnt(Character character, int addValue, bool isReset)
		{
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC30")]
		[Address(RVA = "0x3622AD0", Offset = "0x36216D0", VA = "0x183622AD0")]
		private LegionCharacterStatusManager.LegionCharacterStatus _GetOwnerStatus(uint uid)
		{
			return null;
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC31")]
		[Address(RVA = "0x3621090", Offset = "0x361FC90", VA = "0x183621090")]
		public LegionCharacterStatusManager.LegionCharacterStatus GetOwnerStatus(Character character, bool initIfNull = false)
		{
			return null;
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC32")]
		[Address(RVA = "0x3622A00", Offset = "0x3621600", VA = "0x183622A00")]
		private LegionCharacterStatusManager.LegionCharacterStatus _GetOwnerStatusByKey(uint stateKey)
		{
			return null;
		}

		// Token: 0x0600DC33 RID: 56371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC33")]
		[Address(RVA = "0x3621CD0", Offset = "0x36208D0", VA = "0x183621CD0")]
		public void OnCardRecycleClearStatus(uint stateKey)
		{
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC34")]
		[Address(RVA = "0x3621F30", Offset = "0x3620B30", VA = "0x183621F30")]
		public void ReplaceCharacter(Character source, Character target)
		{
		}

		// Token: 0x0600DC35 RID: 56373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC35")]
		[Address(RVA = "0x3620540", Offset = "0x361F140", VA = "0x183620540")]
		public void AddTargetProfessionLevelDirectly(ProfessionCategory profession, Character target, int levelCount = 0)
		{
		}

		// Token: 0x0600DC36 RID: 56374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC36")]
		[Address(RVA = "0x36223D0", Offset = "0x3620FD0", VA = "0x1836223D0")]
		public void TemporaryAddEachProfessionStatus(Character target)
		{
		}

		// Token: 0x0600DC37 RID: 56375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC37")]
		[Address(RVA = "0x36207E0", Offset = "0x361F3E0", VA = "0x1836207E0")]
		public void FinishTemporaryProfessionStatus(Character target)
		{
		}

		// Token: 0x0600DC38 RID: 56376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC38")]
		[Address(RVA = "0x36206D0", Offset = "0x361F2D0", VA = "0x1836206D0")]
		public void ClearTargetProfessionLevel(Character character)
		{
		}

		// Token: 0x0600DC39 RID: 56377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC39")]
		[Address(RVA = "0x3621E80", Offset = "0x3620A80", VA = "0x183621E80")]
		public void RefreshTargetProfessionBuff(Character character)
		{
		}

		// Token: 0x0600DC3A RID: 56378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC3A")]
		[Address(RVA = "0x3621740", Offset = "0x3620340", VA = "0x183621740")]
		public void KeepCharacterStatus(Character source)
		{
		}

		// Token: 0x0600DC3B RID: 56379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC3B")]
		[Address(RVA = "0x36217D0", Offset = "0x36203D0", VA = "0x1836217D0")]
		public void MarkCharReturnToHandAndKeepStatues(Character source, bool isRedrawOnReplace)
		{
		}

		// Token: 0x0600DC3C RID: 56380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC3C")]
		[Address(RVA = "0x36208E0", Offset = "0x361F4E0", VA = "0x1836208E0")]
		public string GetCharacterProfessionBuffInfo(Character character)
		{
			return null;
		}

		// Token: 0x0600DC3D RID: 56381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC3D")]
		[Address(RVA = "0x3620F70", Offset = "0x361FB70", VA = "0x183620F70")]
		public List<LegionModeProfessionBuffStatus> GetCharacterProfessionStatus(uint characterUid)
		{
			return null;
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC3E")]
		[Address(RVA = "0x3620B70", Offset = "0x361F770", VA = "0x183620B70")]
		public List<LegionModeProfessionBuffStatus> GetCharacterProfessionStatusWithHighLight(Character fromTarget, Character toTarget, List<ProfessionCategory> hlList)
		{
			return null;
		}

		// Token: 0x0600DC3F RID: 56383 RVA: 0x00050658 File Offset: 0x0004E858
		[Token(Token = "0x600DC3F")]
		[Address(RVA = "0x3621320", Offset = "0x361FF20", VA = "0x183621320")]
		public int GetProfessionBuffNum(Character character)
		{
			return 0;
		}

		// Token: 0x0600DC40 RID: 56384 RVA: 0x00050670 File Offset: 0x0004E870
		[Token(Token = "0x600DC40")]
		[Address(RVA = "0x36215C0", Offset = "0x36201C0", VA = "0x1836215C0")]
		public int GetStatusProfessionCnt(Character character)
		{
			return 0;
		}

		// Token: 0x0600DC41 RID: 56385 RVA: 0x00050688 File Offset: 0x0004E888
		[Token(Token = "0x600DC41")]
		[Address(RVA = "0x36213B0", Offset = "0x361FFB0", VA = "0x1836213B0")]
		public int GetSpecifiedProfessionStatusBuffCnt(Character character, ProfessionCategory queryProfession)
		{
			return 0;
		}

		// Token: 0x0600DC42 RID: 56386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC42")]
		[Address(RVA = "0x3622800", Offset = "0x3621400", VA = "0x183622800")]
		private LegionCharacterStatusManager.LegionCharacterStatus _CreateCharacterStatus(float hatred)
		{
			return null;
		}

		// Token: 0x0600DC43 RID: 56387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC43")]
		[Address(RVA = "0x36231A0", Offset = "0x3621DA0", VA = "0x1836231A0")]
		private void _RemoveCharacterStatus(uint stateKey)
		{
		}

		// Token: 0x0600DC44 RID: 56388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC44")]
		[Address(RVA = "0x36224F0", Offset = "0x36210F0", VA = "0x1836224F0")]
		private LegionCharacterStatusManager.LegionCharacterStatus _AddTargetProfessionLevel(ProfessionCategory profession, Character fromTarget, Character toTarget, int levelCount, bool refreshDict = true)
		{
			return null;
		}

		// Token: 0x0600DC45 RID: 56389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC45")]
		[Address(RVA = "0x3622CF0", Offset = "0x36218F0", VA = "0x183622CF0")]
		private void _RefreshLegionAbilityByName(Character character, string abilityName)
		{
		}

		// Token: 0x0600DC46 RID: 56390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC46")]
		[Address(RVA = "0x3622E60", Offset = "0x3621A60", VA = "0x183622E60")]
		private void _RefreshUiCachedProfessionBuffStatus(LegionCharacterStatusManager.LegionCharacterStatus status, List<LegionModeProfessionBuffStatus> refreshList)
		{
		}

		// Token: 0x0600DC47 RID: 56391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC47")]
		[Address(RVA = "0x3622BA0", Offset = "0x36217A0", VA = "0x183622BA0")]
		private void _LogProfessionBuffLevel(Character character)
		{
		}

		// Token: 0x0600DC48 RID: 56392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC48")]
		[Address(RVA = "0x36232D0", Offset = "0x3621ED0", VA = "0x1836232D0")]
		public LegionCharacterStatusManager()
		{
		}

		// Token: 0x0400EDFD RID: 60925
		[Token(Token = "0x400EDFD")]
		[FieldOffset(Offset = "0x10")]
		private readonly LegionCharacterStatusManager.LegionCharacterStatus m_sharedStatus;

		// Token: 0x0400EDFE RID: 60926
		[Token(Token = "0x400EDFE")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<uint, LegionCharacterStatusManager.LegionCharacterStatus> m_characterStateDict;

		// Token: 0x0400EDFF RID: 60927
		[Token(Token = "0x400EDFF")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<LegionCharacterStatusManager.LegionCharacterStatus> m_statusReusePool;

		// Token: 0x0400EE00 RID: 60928
		[Token(Token = "0x400EE00")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<LegionModeProfessionBuffStatus> m_uiCachedProfessionStatusList;

		// Token: 0x0400EE01 RID: 60929
		[Token(Token = "0x400EE01")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<ProfessionCategory, int> m_uiCachedProfessionStatusDict;

		// Token: 0x0400EE02 RID: 60930
		[Token(Token = "0x400EE02")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<uint, LegionCharacterStatusManager.CharacterStatusInfo> m_charStatusInfoDict;

		// Token: 0x0400EE03 RID: 60931
		[Token(Token = "0x400EE03")]
		[FieldOffset(Offset = "0x40")]
		private GameModeFactory.LegionGameMode m_legionMode;

		// Token: 0x0400EE04 RID: 60932
		[Token(Token = "0x400EE04")]
		[FieldOffset(Offset = "0x48")]
		private int m_originMaxProfessionLevel;

		// Token: 0x0400EE05 RID: 60933
		[Token(Token = "0x400EE05")]
		[FieldOffset(Offset = "0x4C")]
		private int m_originProfessionLevelAdd;

		// Token: 0x0400EE06 RID: 60934
		[Token(Token = "0x400EE06")]
		[FieldOffset(Offset = "0x50")]
		private readonly StringBuilder m_buffInfoString;

		// Token: 0x0400EE07 RID: 60935
		[Token(Token = "0x400EE07")]
		private const string FORMAT_BUFF_INFO = "{0} x{1}\n";

		// Token: 0x0400EE08 RID: 60936
		[Token(Token = "0x400EE08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EE09 RID: 60937
		[Token(Token = "0x400EE09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetCharStatusInfo;

		// Token: 0x0400EE0A RID: 60938
		[Token(Token = "0x400EE0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetCharLevelDefaultAddCnt;

		// Token: 0x0400EE0B RID: 60939
		[Token(Token = "0x400EE0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStatusBuffMaxCnt;

		// Token: 0x0400EE0C RID: 60940
		[Token(Token = "0x400EE0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ModifyProfessionBuffMaxCnt;

		// Token: 0x0400EE0D RID: 60941
		[Token(Token = "0x400EE0D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ModifyProfessionBuffDefaultAddCnt;

		// Token: 0x0400EE0E RID: 60942
		[Token(Token = "0x400EE0E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetOwnerStatus;

		// Token: 0x0400EE0F RID: 60943
		[Token(Token = "0x400EE0F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetOwnerStatus;

		// Token: 0x0400EE10 RID: 60944
		[Token(Token = "0x400EE10")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetOwnerStatusByKey;

		// Token: 0x0400EE11 RID: 60945
		[Token(Token = "0x400EE11")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCardRecycleClearStatus;

		// Token: 0x0400EE12 RID: 60946
		[Token(Token = "0x400EE12")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReplaceCharacter;

		// Token: 0x0400EE13 RID: 60947
		[Token(Token = "0x400EE13")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddTargetProfessionLevelDirectly;

		// Token: 0x0400EE14 RID: 60948
		[Token(Token = "0x400EE14")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TemporaryAddEachProfessionStatus;

		// Token: 0x0400EE15 RID: 60949
		[Token(Token = "0x400EE15")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FinishTemporaryProfessionStatus;

		// Token: 0x0400EE16 RID: 60950
		[Token(Token = "0x400EE16")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ClearTargetProfessionLevel;

		// Token: 0x0400EE17 RID: 60951
		[Token(Token = "0x400EE17")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RefreshTargetProfessionBuff;

		// Token: 0x0400EE18 RID: 60952
		[Token(Token = "0x400EE18")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_KeepCharacterStatus;

		// Token: 0x0400EE19 RID: 60953
		[Token(Token = "0x400EE19")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_MarkCharReturnToHandAndKeepStatues;

		// Token: 0x0400EE1A RID: 60954
		[Token(Token = "0x400EE1A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCharacterProfessionBuffInfo;

		// Token: 0x0400EE1B RID: 60955
		[Token(Token = "0x400EE1B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetCharacterProfessionStatus;

		// Token: 0x0400EE1C RID: 60956
		[Token(Token = "0x400EE1C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCharacterProfessionStatusWithHighLight;

		// Token: 0x0400EE1D RID: 60957
		[Token(Token = "0x400EE1D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetProfessionBuffNum;

		// Token: 0x0400EE1E RID: 60958
		[Token(Token = "0x400EE1E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetStatusProfessionCnt;

		// Token: 0x0400EE1F RID: 60959
		[Token(Token = "0x400EE1F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetSpecifiedProfessionStatusBuffCnt;

		// Token: 0x0400EE20 RID: 60960
		[Token(Token = "0x400EE20")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CreateCharacterStatus;

		// Token: 0x0400EE21 RID: 60961
		[Token(Token = "0x400EE21")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RemoveCharacterStatus;

		// Token: 0x0400EE22 RID: 60962
		[Token(Token = "0x400EE22")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__AddTargetProfessionLevel;

		// Token: 0x0400EE23 RID: 60963
		[Token(Token = "0x400EE23")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RefreshLegionAbilityByName;

		// Token: 0x0400EE24 RID: 60964
		[Token(Token = "0x400EE24")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshUiCachedProfessionBuffStatus;

		// Token: 0x0400EE25 RID: 60965
		[Token(Token = "0x400EE25")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__LogProfessionBuffLevel;

		// Token: 0x0400EE26 RID: 60966
		[Token(Token = "0x400EE26")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200223D RID: 8765
		[Token(Token = "0x200223D")]
		private struct CharacterStatusInfo
		{
			// Token: 0x0400EE27 RID: 60967
			[Token(Token = "0x400EE27")]
			[FieldOffset(Offset = "0x0")]
			public int maxProfessionLevel;

			// Token: 0x0400EE28 RID: 60968
			[Token(Token = "0x400EE28")]
			[FieldOffset(Offset = "0x4")]
			public int professionLevelAdd;
		}

		// Token: 0x0200223E RID: 8766
		[Token(Token = "0x200223E")]
		public struct StatusKeyValuePair
		{
			// Token: 0x0600DC49 RID: 56393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC49")]
			[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
			public StatusKeyValuePair(ProfessionCategory professionKey, int level)
			{
			}

			// Token: 0x0400EE29 RID: 60969
			[Token(Token = "0x400EE29")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory Key;

			// Token: 0x0400EE2A RID: 60970
			[Token(Token = "0x400EE2A")]
			[FieldOffset(Offset = "0x4")]
			public int Value;
		}

		// Token: 0x0200223F RID: 8767
		[Token(Token = "0x200223F")]
		[Serializable]
		public class LegionCharacterStatus : IHotfixable
		{
			// Token: 0x0600DC4A RID: 56394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC4A")]
			[Address(RVA = "0x3624500", Offset = "0x3623100", VA = "0x183624500")]
			public void Reset()
			{
			}

			// Token: 0x17001BC4 RID: 7108
			// (get) Token: 0x0600DC4B RID: 56395 RVA: 0x000506A0 File Offset: 0x0004E8A0
			// (set) Token: 0x0600DC4C RID: 56396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BC4")]
			public float hatred
			{
				[Token(Token = "0x600DC4B")]
				[Address(RVA = "0x36247F0", Offset = "0x36233F0", VA = "0x1836247F0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600DC4C")]
				[Address(RVA = "0x3624980", Offset = "0x3623580", VA = "0x183624980")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001BC5 RID: 7109
			// (get) Token: 0x0600DC4D RID: 56397 RVA: 0x000506B8 File Offset: 0x0004E8B8
			// (set) Token: 0x0600DC4E RID: 56398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BC5")]
			public bool keepStatusOnce
			{
				[Token(Token = "0x600DC4D")]
				[Address(RVA = "0x3624860", Offset = "0x3623460", VA = "0x183624860")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600DC4E")]
				[Address(RVA = "0x3624A10", Offset = "0x3623610", VA = "0x183624A10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001BC6 RID: 7110
			// (get) Token: 0x0600DC4F RID: 56399 RVA: 0x000506D0 File Offset: 0x0004E8D0
			[Token(Token = "0x17001BC6")]
			public ProfessionCategory lastStatusProfession
			{
				[Token(Token = "0x600DC4F")]
				[Address(RVA = "0x36248D0", Offset = "0x36234D0", VA = "0x1836248D0")]
				get
				{
					return ProfessionCategory.NONE;
				}
			}

			// Token: 0x0600DC50 RID: 56400 RVA: 0x000506E8 File Offset: 0x0004E8E8
			[Token(Token = "0x600DC50")]
			[Address(RVA = "0x3623570", Offset = "0x3622170", VA = "0x183623570")]
			public bool AddStatusLevel(ProfessionCategory professionKey, int num, int maxNum)
			{
				return default(bool);
			}

			// Token: 0x0600DC51 RID: 56401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC51")]
			[Address(RVA = "0x3623A50", Offset = "0x3622650", VA = "0x183623A50")]
			public void FilterMaxLevel(int maxLevel)
			{
			}

			// Token: 0x0600DC52 RID: 56402 RVA: 0x00050700 File Offset: 0x0004E900
			[Token(Token = "0x600DC52")]
			[Address(RVA = "0x3623EB0", Offset = "0x3622AB0", VA = "0x183623EB0")]
			public int GetStatusLevel(ProfessionCategory key)
			{
				return 0;
			}

			// Token: 0x0600DC53 RID: 56403 RVA: 0x00050718 File Offset: 0x0004E918
			[Token(Token = "0x600DC53")]
			[Address(RVA = "0x3624490", Offset = "0x3623090", VA = "0x183624490")]
			public int GetStatusTotalLevel()
			{
				return 0;
			}

			// Token: 0x0600DC54 RID: 56404 RVA: 0x00050730 File Offset: 0x0004E930
			[Token(Token = "0x600DC54")]
			[Address(RVA = "0x3623C50", Offset = "0x3622850", VA = "0x183623C50")]
			public int GetSpecifiedProfessionStatusTotalLevel(ProfessionCategory queryProfession)
			{
				return 0;
			}

			// Token: 0x0600DC55 RID: 56405 RVA: 0x00050748 File Offset: 0x0004E948
			[Token(Token = "0x600DC55")]
			[Address(RVA = "0x3624150", Offset = "0x3622D50", VA = "0x183624150")]
			public int GetStatusProfessionCnt()
			{
				return 0;
			}

			// Token: 0x0600DC56 RID: 56406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC56")]
			[Address(RVA = "0x36236C0", Offset = "0x36222C0", VA = "0x1836236C0")]
			public void AddStatusToTmpStatusDic()
			{
			}

			// Token: 0x0600DC57 RID: 56407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC57")]
			[Address(RVA = "0x3623880", Offset = "0x3622480", VA = "0x183623880")]
			public void ClearTmpStatusDic()
			{
			}

			// Token: 0x0600DC58 RID: 56408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC58")]
			[Address(RVA = "0x3623920", Offset = "0x3622520", VA = "0x183623920")]
			public void CopyFrom(LegionCharacterStatusManager.LegionCharacterStatus fromStatus)
			{
			}

			// Token: 0x0600DC59 RID: 56409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC59")]
			[Address(RVA = "0x3624660", Offset = "0x3623260", VA = "0x183624660")]
			public LegionCharacterStatus()
			{
			}

			// Token: 0x0400EE2B RID: 60971
			[Token(Token = "0x400EE2B")]
			[FieldOffset(Offset = "0x0")]
			private static HashSet<ProfessionCategory> m_sharedSet;

			// Token: 0x0400EE2E RID: 60974
			[Token(Token = "0x400EE2E")]
			[FieldOffset(Offset = "0x18")]
			public List<LegionCharacterStatusManager.StatusKeyValuePair> statusList;

			// Token: 0x0400EE2F RID: 60975
			[Token(Token = "0x400EE2F")]
			[FieldOffset(Offset = "0x20")]
			public List<LegionCharacterStatusManager.StatusKeyValuePair> tempStatusList;

			// Token: 0x0400EE30 RID: 60976
			[Token(Token = "0x400EE30")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<ProfessionCategory, int> m_tmpStatusDic;

			// Token: 0x0400EE31 RID: 60977
			[Token(Token = "0x400EE31")]
			[FieldOffset(Offset = "0x30")]
			public int statusLevel;

			// Token: 0x0400EE32 RID: 60978
			[Token(Token = "0x400EE32")]
			[FieldOffset(Offset = "0x34")]
			public int tmpStatusLevel;

			// Token: 0x0400EE33 RID: 60979
			[Token(Token = "0x400EE33")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400EE34 RID: 60980
			[Token(Token = "0x400EE34")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_hatred;

			// Token: 0x0400EE35 RID: 60981
			[Token(Token = "0x400EE35")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_hatred;

			// Token: 0x0400EE36 RID: 60982
			[Token(Token = "0x400EE36")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_keepStatusOnce;

			// Token: 0x0400EE37 RID: 60983
			[Token(Token = "0x400EE37")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_keepStatusOnce;

			// Token: 0x0400EE38 RID: 60984
			[Token(Token = "0x400EE38")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_lastStatusProfession;

			// Token: 0x0400EE39 RID: 60985
			[Token(Token = "0x400EE39")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_AddStatusLevel;

			// Token: 0x0400EE3A RID: 60986
			[Token(Token = "0x400EE3A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_FilterMaxLevel;

			// Token: 0x0400EE3B RID: 60987
			[Token(Token = "0x400EE3B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_GetStatusLevel;

			// Token: 0x0400EE3C RID: 60988
			[Token(Token = "0x400EE3C")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GetStatusTotalLevel;

			// Token: 0x0400EE3D RID: 60989
			[Token(Token = "0x400EE3D")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_GetSpecifiedProfessionStatusTotalLevel;

			// Token: 0x0400EE3E RID: 60990
			[Token(Token = "0x400EE3E")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_GetStatusProfessionCnt;

			// Token: 0x0400EE3F RID: 60991
			[Token(Token = "0x400EE3F")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_AddStatusToTmpStatusDic;

			// Token: 0x0400EE40 RID: 60992
			[Token(Token = "0x400EE40")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_ClearTmpStatusDic;

			// Token: 0x0400EE41 RID: 60993
			[Token(Token = "0x400EE41")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_CopyFrom;

			// Token: 0x0400EE42 RID: 60994
			[Token(Token = "0x400EE42")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
