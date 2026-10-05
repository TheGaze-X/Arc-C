using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200544A RID: 21578
	[Token(Token = "0x200544A")]
	public class RoguelikeLocalCache : Singleton<RoguelikeLocalCache>
	{
		// Token: 0x0601FBEC RID: 130028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBEC")]
		[Address(RVA = "0x196DBE0", Offset = "0x196C7E0", VA = "0x18196DBE0")]
		private RoguelikeLocalCache()
		{
		}

		// Token: 0x0601FBED RID: 130029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FBED")]
		[Address(RVA = "0x196D910", Offset = "0x196C510", VA = "0x18196D910")]
		private RoguelikeLocalCache.Data _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601FBEE RID: 130030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBEE")]
		[Address(RVA = "0x196DB50", Offset = "0x196C750", VA = "0x18196DB50")]
		private void _SaveData(RoguelikeLocalCache.Data data)
		{
		}

		// Token: 0x0601FBEF RID: 130031 RVA: 0x000B2ED8 File Offset: 0x000B10D8
		[Token(Token = "0x601FBEF")]
		[Address(RVA = "0x196B230", Offset = "0x1969E30", VA = "0x18196B230")]
		public bool CheckFragmentHeavyDialogDisable(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FBF0 RID: 130032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBF0")]
		[Address(RVA = "0x196C3D0", Offset = "0x196AFD0", VA = "0x18196C3D0")]
		public void SaveFragmentHeavyDialogDisable(string topicId)
		{
		}

		// Token: 0x0601FBF1 RID: 130033 RVA: 0x000B2EF0 File Offset: 0x000B10F0
		[Token(Token = "0x601FBF1")]
		[Address(RVA = "0x196B320", Offset = "0x1969F20", VA = "0x18196B320")]
		public bool CheckFragmentWeightCharConfirmed(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FBF2 RID: 130034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBF2")]
		[Address(RVA = "0x196C4D0", Offset = "0x196B0D0", VA = "0x18196C4D0")]
		public void SaveFragmentWeightCharConfirmed(string topicId)
		{
		}

		// Token: 0x0601FBF3 RID: 130035 RVA: 0x000B2F08 File Offset: 0x000B1108
		[Token(Token = "0x601FBF3")]
		[Address(RVA = "0x196B9B0", Offset = "0x196A5B0", VA = "0x18196B9B0")]
		public RoguelikeFragmentDialogListType GetFragmentBagListType(string topicId)
		{
			return RoguelikeFragmentDialogListType.NONE;
		}

		// Token: 0x0601FBF4 RID: 130036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBF4")]
		[Address(RVA = "0x196C230", Offset = "0x196AE30", VA = "0x18196C230")]
		public void SaveFragmentBagListType(string topicId, RoguelikeFragmentDialogListType type)
		{
		}

		// Token: 0x0601FBF5 RID: 130037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBF5")]
		[Address(RVA = "0x196D1B0", Offset = "0x196BDB0", VA = "0x18196D1B0")]
		public void TrySyncDifficultyFromPlayerData()
		{
		}

		// Token: 0x0601FBF6 RID: 130038 RVA: 0x000B2F20 File Offset: 0x000B1120
		[Token(Token = "0x601FBF6")]
		[Address(RVA = "0x196BE70", Offset = "0x196AA70", VA = "0x18196BE70")]
		public RoguelikeTopicDifficultyID GetTopicPrefDifficulty(string topicId)
		{
			return default(RoguelikeTopicDifficultyID);
		}

		// Token: 0x0601FBF7 RID: 130039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBF7")]
		[Address(RVA = "0x196CE40", Offset = "0x196BA40", VA = "0x18196CE40")]
		public void SaveTopicPrefDifficulty(string topicId, RoguelikeTopicDifficultyID difficultyID)
		{
		}

		// Token: 0x0601FBF8 RID: 130040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FBF8")]
		[Address(RVA = "0x196BD40", Offset = "0x196A940", VA = "0x18196BD40")]
		public string GetTopicModePredefineId(string topicId, RoguelikeTopicMode mode)
		{
			return null;
		}

		// Token: 0x0601FBF9 RID: 130041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBF9")]
		[Address(RVA = "0x196CC20", Offset = "0x196B820", VA = "0x18196CC20")]
		public void SaveTopicModePredefineId(string topicId, RoguelikeTopicMode mode, string predefineId)
		{
		}

		// Token: 0x0601FBFA RID: 130042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FBFA")]
		[Address(RVA = "0x196BC60", Offset = "0x196A860", VA = "0x18196BC60")]
		public string GetTopicKeyVisual(string topicId)
		{
			return null;
		}

		// Token: 0x0601FBFB RID: 130043 RVA: 0x000B2F38 File Offset: 0x000B1138
		[Token(Token = "0x601FBFB")]
		[Address(RVA = "0x196CAE0", Offset = "0x196B6E0", VA = "0x18196CAE0")]
		public bool SaveTopicKeyVisual(string topicId, string kv)
		{
			return default(bool);
		}

		// Token: 0x0601FBFC RID: 130044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FBFC")]
		[Address(RVA = "0x196BB20", Offset = "0x196A720", VA = "0x18196BB20")]
		public string GetPreAutoSetKV(string topicId)
		{
			return null;
		}

		// Token: 0x0601FBFD RID: 130045 RVA: 0x000B2F50 File Offset: 0x000B1150
		[Token(Token = "0x601FBFD")]
		[Address(RVA = "0x196C040", Offset = "0x196AC40", VA = "0x18196C040")]
		public bool SaveAutoSetKV(string topicId, string kv)
		{
			return default(bool);
		}

		// Token: 0x0601FBFE RID: 130046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FBFE")]
		[Address(RVA = "0x196BF80", Offset = "0x196AB80", VA = "0x18196BF80")]
		public List<RoguelikeSquadViewModel> LoadSquad()
		{
			return null;
		}

		// Token: 0x0601FBFF RID: 130047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBFF")]
		[Address(RVA = "0x196C940", Offset = "0x196B540", VA = "0x18196C940")]
		public void SaveSquad(List<RoguelikeSquadViewModel> squad)
		{
		}

		// Token: 0x0601FC00 RID: 130048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC00")]
		[Address(RVA = "0x196BAB0", Offset = "0x196A6B0", VA = "0x18196BAB0")]
		public string GetPendingChatId()
		{
			return null;
		}

		// Token: 0x0601FC01 RID: 130049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC01")]
		[Address(RVA = "0x196C760", Offset = "0x196B360", VA = "0x18196C760")]
		public void SavePendingChatId(string chatId)
		{
		}

		// Token: 0x0601FC02 RID: 130050 RVA: 0x000B2F68 File Offset: 0x000B1168
		[Token(Token = "0x601FC02")]
		[Address(RVA = "0x196B410", Offset = "0x196A010", VA = "0x18196B410")]
		public bool CheckIfHaveSquadAutoSet()
		{
			return default(bool);
		}

		// Token: 0x0601FC03 RID: 130051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC03")]
		[Address(RVA = "0x196C880", Offset = "0x196B480", VA = "0x18196C880")]
		public void SaveSquadAutoSet()
		{
		}

		// Token: 0x0601FC04 RID: 130052 RVA: 0x000B2F80 File Offset: 0x000B1180
		[Token(Token = "0x601FC04")]
		[Address(RVA = "0x196B530", Offset = "0x196A130", VA = "0x18196B530")]
		public bool CheckMonthChatRead(string chatStoryId)
		{
			return default(bool);
		}

		// Token: 0x0601FC05 RID: 130053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC05")]
		[Address(RVA = "0x196C5D0", Offset = "0x196B1D0", VA = "0x18196C5D0")]
		public void SaveMonthChatRead(string chatStoryId)
		{
		}

		// Token: 0x0601FC06 RID: 130054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC06")]
		[Address(RVA = "0x196D6B0", Offset = "0x196C2B0", VA = "0x18196D6B0")]
		private List<string> _EnsureChatReadList()
		{
			return null;
		}

		// Token: 0x0601FC07 RID: 130055 RVA: 0x000B2F98 File Offset: 0x000B1198
		[Token(Token = "0x601FC07")]
		[Address(RVA = "0x196B480", Offset = "0x196A080", VA = "0x18196B480")]
		public static bool CheckIfRogueActivityTrackPoint(string rlActId)
		{
			return default(bool);
		}

		// Token: 0x0601FC08 RID: 130056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC08")]
		[Address(RVA = "0x196CFB0", Offset = "0x196BBB0", VA = "0x18196CFB0")]
		public static void SetRogueActivityChecked(string rlActId)
		{
		}

		// Token: 0x0601FC09 RID: 130057 RVA: 0x000B2FB0 File Offset: 0x000B11B0
		[Token(Token = "0x601FC09")]
		[Address(RVA = "0x196B710", Offset = "0x196A310", VA = "0x18196B710")]
		public bool CheckSpecialOperatorAccessed(string charId)
		{
			return default(bool);
		}

		// Token: 0x0601FC0A RID: 130058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC0A")]
		[Address(RVA = "0x196D060", Offset = "0x196BC60", VA = "0x18196D060")]
		public void SetSpecialOperatorAccessed(string charId)
		{
		}

		// Token: 0x0601FC0B RID: 130059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC0B")]
		[Address(RVA = "0x196C170", Offset = "0x196AD70", VA = "0x18196C170")]
		public void SaveCandleStartBattleCheckDialogDisable()
		{
		}

		// Token: 0x0601FC0C RID: 130060 RVA: 0x000B2FC8 File Offset: 0x000B11C8
		[Token(Token = "0x601FC0C")]
		[Address(RVA = "0x196B940", Offset = "0x196A540", VA = "0x18196B940")]
		public bool GetCandleStartBattleCheckDialogDisable()
		{
			return default(bool);
		}

		// Token: 0x0601FC0D RID: 130061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC0D")]
		[Address(RVA = "0x196CA20", Offset = "0x196B620", VA = "0x18196CA20")]
		public void SaveSwapCopperCheckDialogDisable()
		{
		}

		// Token: 0x0601FC0E RID: 130062 RVA: 0x000B2FE0 File Offset: 0x000B11E0
		[Token(Token = "0x601FC0E")]
		[Address(RVA = "0x196BBF0", Offset = "0x196A7F0", VA = "0x18196BBF0")]
		public bool GetSwapCopperCheckDialogDisable()
		{
			return default(bool);
		}

		// Token: 0x0601FC0F RID: 130063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC0F")]
		[Address(RVA = "0x196B0D0", Offset = "0x1969CD0", VA = "0x18196B0D0")]
		public void AddCachedNewWrathIdList(List<string> newWrathIdList)
		{
		}

		// Token: 0x0601FC10 RID: 130064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC10")]
		[Address(RVA = "0x196B8D0", Offset = "0x196A4D0", VA = "0x18196B8D0")]
		public List<string> GetCachedNewWrathIdList()
		{
			return null;
		}

		// Token: 0x0601FC11 RID: 130065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC11")]
		[Address(RVA = "0x196B7C0", Offset = "0x196A3C0", VA = "0x18196B7C0")]
		public void ClearCachedNewWrathIdList()
		{
		}

		// Token: 0x0601FC12 RID: 130066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC12")]
		[Address(RVA = "0x196D5F0", Offset = "0x196C1F0", VA = "0x18196D5F0")]
		private string _CurGameID()
		{
			return null;
		}

		// Token: 0x0601FC13 RID: 130067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC13")]
		[Address(RVA = "0x196D810", Offset = "0x196C410", VA = "0x18196D810")]
		private RoguelikeLocalCache.DataInGame _EnsureDataInGame()
		{
			return null;
		}

		// Token: 0x0601FC14 RID: 130068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC14")]
		[Address(RVA = "0x196D3F0", Offset = "0x196BFF0", VA = "0x18196D3F0")]
		private void _ConfirmDataInGame(RoguelikeLocalCache.DataInGame data, bool triggerSave = true)
		{
		}

		// Token: 0x0601FC15 RID: 130069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC15")]
		[Address(RVA = "0x196DA50", Offset = "0x196C650", VA = "0x18196DA50")]
		private RoguelikeLocalCache.OtherCacheInGame _EnsureOtherCacheInGame()
		{
			return null;
		}

		// Token: 0x0601FC16 RID: 130070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC16")]
		[Address(RVA = "0x196D4F0", Offset = "0x196C0F0", VA = "0x18196D4F0")]
		private void _ConfirmOtherCacheInGame(RoguelikeLocalCache.OtherCacheInGame data, bool triggerSave = true)
		{
		}

		// Token: 0x0402AC63 RID: 175203
		[Token(Token = "0x402AC63")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<RoguelikeLocalCache.Data> m_memData;

		// Token: 0x0402AC64 RID: 175204
		[Token(Token = "0x402AC64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402AC65 RID: 175205
		[Token(Token = "0x402AC65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0402AC66 RID: 175206
		[Token(Token = "0x402AC66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0402AC67 RID: 175207
		[Token(Token = "0x402AC67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckFragmentHeavyDialogDisable;

		// Token: 0x0402AC68 RID: 175208
		[Token(Token = "0x402AC68")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SaveFragmentHeavyDialogDisable;

		// Token: 0x0402AC69 RID: 175209
		[Token(Token = "0x402AC69")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckFragmentWeightCharConfirmed;

		// Token: 0x0402AC6A RID: 175210
		[Token(Token = "0x402AC6A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveFragmentWeightCharConfirmed;

		// Token: 0x0402AC6B RID: 175211
		[Token(Token = "0x402AC6B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetFragmentBagListType;

		// Token: 0x0402AC6C RID: 175212
		[Token(Token = "0x402AC6C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveFragmentBagListType;

		// Token: 0x0402AC6D RID: 175213
		[Token(Token = "0x402AC6D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TrySyncDifficultyFromPlayerData;

		// Token: 0x0402AC6E RID: 175214
		[Token(Token = "0x402AC6E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTopicPrefDifficulty;

		// Token: 0x0402AC6F RID: 175215
		[Token(Token = "0x402AC6F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SaveTopicPrefDifficulty;

		// Token: 0x0402AC70 RID: 175216
		[Token(Token = "0x402AC70")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetTopicModePredefineId;

		// Token: 0x0402AC71 RID: 175217
		[Token(Token = "0x402AC71")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SaveTopicModePredefineId;

		// Token: 0x0402AC72 RID: 175218
		[Token(Token = "0x402AC72")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTopicKeyVisual;

		// Token: 0x0402AC73 RID: 175219
		[Token(Token = "0x402AC73")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SaveTopicKeyVisual;

		// Token: 0x0402AC74 RID: 175220
		[Token(Token = "0x402AC74")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetPreAutoSetKV;

		// Token: 0x0402AC75 RID: 175221
		[Token(Token = "0x402AC75")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SaveAutoSetKV;

		// Token: 0x0402AC76 RID: 175222
		[Token(Token = "0x402AC76")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadSquad;

		// Token: 0x0402AC77 RID: 175223
		[Token(Token = "0x402AC77")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SaveSquad;

		// Token: 0x0402AC78 RID: 175224
		[Token(Token = "0x402AC78")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetPendingChatId;

		// Token: 0x0402AC79 RID: 175225
		[Token(Token = "0x402AC79")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SavePendingChatId;

		// Token: 0x0402AC7A RID: 175226
		[Token(Token = "0x402AC7A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckIfHaveSquadAutoSet;

		// Token: 0x0402AC7B RID: 175227
		[Token(Token = "0x402AC7B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SaveSquadAutoSet;

		// Token: 0x0402AC7C RID: 175228
		[Token(Token = "0x402AC7C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CheckMonthChatRead;

		// Token: 0x0402AC7D RID: 175229
		[Token(Token = "0x402AC7D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SaveMonthChatRead;

		// Token: 0x0402AC7E RID: 175230
		[Token(Token = "0x402AC7E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EnsureChatReadList;

		// Token: 0x0402AC7F RID: 175231
		[Token(Token = "0x402AC7F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckIfRogueActivityTrackPoint;

		// Token: 0x0402AC80 RID: 175232
		[Token(Token = "0x402AC80")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SetRogueActivityChecked;

		// Token: 0x0402AC81 RID: 175233
		[Token(Token = "0x402AC81")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckSpecialOperatorAccessed;

		// Token: 0x0402AC82 RID: 175234
		[Token(Token = "0x402AC82")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SetSpecialOperatorAccessed;

		// Token: 0x0402AC83 RID: 175235
		[Token(Token = "0x402AC83")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SaveCandleStartBattleCheckDialogDisable;

		// Token: 0x0402AC84 RID: 175236
		[Token(Token = "0x402AC84")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetCandleStartBattleCheckDialogDisable;

		// Token: 0x0402AC85 RID: 175237
		[Token(Token = "0x402AC85")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_SaveSwapCopperCheckDialogDisable;

		// Token: 0x0402AC86 RID: 175238
		[Token(Token = "0x402AC86")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetSwapCopperCheckDialogDisable;

		// Token: 0x0402AC87 RID: 175239
		[Token(Token = "0x402AC87")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_AddCachedNewWrathIdList;

		// Token: 0x0402AC88 RID: 175240
		[Token(Token = "0x402AC88")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetCachedNewWrathIdList;

		// Token: 0x0402AC89 RID: 175241
		[Token(Token = "0x402AC89")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ClearCachedNewWrathIdList;

		// Token: 0x0402AC8A RID: 175242
		[Token(Token = "0x402AC8A")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CurGameID;

		// Token: 0x0402AC8B RID: 175243
		[Token(Token = "0x402AC8B")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__EnsureDataInGame;

		// Token: 0x0402AC8C RID: 175244
		[Token(Token = "0x402AC8C")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__ConfirmDataInGame;

		// Token: 0x0402AC8D RID: 175245
		[Token(Token = "0x402AC8D")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__EnsureOtherCacheInGame;

		// Token: 0x0402AC8E RID: 175246
		[Token(Token = "0x402AC8E")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__ConfirmOtherCacheInGame;

		// Token: 0x0200544B RID: 21579
		[Token(Token = "0x200544B")]
		private class RoguelikeFragmentListTypeInfo
		{
			// Token: 0x0601FC17 RID: 130071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FC17")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoguelikeFragmentListTypeInfo()
			{
			}

			// Token: 0x0402AC8F RID: 175247
			[Token(Token = "0x402AC8F")]
			[FieldOffset(Offset = "0x10")]
			public string gameId;

			// Token: 0x0402AC90 RID: 175248
			[Token(Token = "0x402AC90")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeFragmentDialogListType type;
		}

		// Token: 0x0200544C RID: 21580
		[Token(Token = "0x200544C")]
		private class Data
		{
			// Token: 0x0601FC18 RID: 130072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FC18")]
			[Address(RVA = "0x1969220", Offset = "0x1967E20", VA = "0x181969220")]
			public Data()
			{
			}

			// Token: 0x0402AC91 RID: 175249
			[Token(Token = "0x402AC91")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeLocalCache.DataInGame dataInGame;

			// Token: 0x0402AC92 RID: 175250
			[Token(Token = "0x402AC92")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, RoguelikeTopicDifficultyID> currDifficulty;

			// Token: 0x0402AC93 RID: 175251
			[Token(Token = "0x402AC93")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, string> keyVisuals;

			// Token: 0x0402AC94 RID: 175252
			[Token(Token = "0x402AC94")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> preAutoKV;

			// Token: 0x0402AC95 RID: 175253
			[Token(Token = "0x402AC95")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> fragmentHeavyDialogDisableGameIds;

			// Token: 0x0402AC96 RID: 175254
			[Token(Token = "0x402AC96")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, string> fragmentWeightCharConfirmed;

			// Token: 0x0402AC97 RID: 175255
			[Token(Token = "0x402AC97")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, RoguelikeLocalCache.RoguelikeFragmentListTypeInfo> fragmentBagListTypeGameIds;

			// Token: 0x0402AC98 RID: 175256
			[Token(Token = "0x402AC98")]
			[FieldOffset(Offset = "0x48")]
			public List<string> readChats;

			// Token: 0x0402AC99 RID: 175257
			[Token(Token = "0x402AC99")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, Dictionary<RoguelikeTopicMode, string>> modePredefineInfos;

			// Token: 0x0402AC9A RID: 175258
			[Token(Token = "0x402AC9A")]
			[FieldOffset(Offset = "0x58")]
			public List<string> accessedSpecialOperators;

			// Token: 0x0402AC9B RID: 175259
			[Token(Token = "0x402AC9B")]
			[FieldOffset(Offset = "0x60")]
			public RoguelikeLocalCache.OtherCacheInGame otherCacheInGame;
		}

		// Token: 0x0200544D RID: 21581
		[Token(Token = "0x200544D")]
		private class DataInGame
		{
			// Token: 0x0601FC19 RID: 130073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FC19")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInGame()
			{
			}

			// Token: 0x0402AC9C RID: 175260
			[Token(Token = "0x402AC9C")]
			[FieldOffset(Offset = "0x10")]
			public string gameID;

			// Token: 0x0402AC9D RID: 175261
			[Token(Token = "0x402AC9D")]
			[FieldOffset(Offset = "0x18")]
			public List<RoguelikeSquadViewModel> squad;

			// Token: 0x0402AC9E RID: 175262
			[Token(Token = "0x402AC9E")]
			[FieldOffset(Offset = "0x20")]
			public string pendChatId;

			// Token: 0x0402AC9F RID: 175263
			[Token(Token = "0x402AC9F")]
			[FieldOffset(Offset = "0x28")]
			public bool isSquadAutoSet;
		}

		// Token: 0x0200544E RID: 21582
		[Token(Token = "0x200544E")]
		private class OtherCacheInGame
		{
			// Token: 0x0601FC1A RID: 130074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FC1A")]
			[Address(RVA = "0x1969650", Offset = "0x1968250", VA = "0x181969650")]
			public OtherCacheInGame()
			{
			}

			// Token: 0x0402ACA0 RID: 175264
			[Token(Token = "0x402ACA0")]
			[FieldOffset(Offset = "0x10")]
			public string gameID;

			// Token: 0x0402ACA1 RID: 175265
			[Token(Token = "0x402ACA1")]
			[FieldOffset(Offset = "0x18")]
			public bool candleStartBattleDialogDisable;

			// Token: 0x0402ACA2 RID: 175266
			[Token(Token = "0x402ACA2")]
			[FieldOffset(Offset = "0x19")]
			public bool swapCopperDrawnDisable;

			// Token: 0x0402ACA3 RID: 175267
			[Token(Token = "0x402ACA3")]
			[FieldOffset(Offset = "0x20")]
			public List<string> newWrathIdList;
		}
	}
}
