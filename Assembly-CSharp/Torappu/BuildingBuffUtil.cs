using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building;
using Torappu.Building.UI;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	public static class BuildingBuffUtil
	{
		// Token: 0x06004D0E RID: 19726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0x1788AB0", Offset = "0x17876B0", VA = "0x181788AB0")]
		public static void LoadBuffDescs(string charId, EvolvePhase phase, int level, ref List<BuildingBuffDescStruct> descs)
		{
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0F")]
		[Address(RVA = "0x1788920", Offset = "0x1787520", VA = "0x181788920")]
		public static void LoadBuffDescs(BuildingCharModel charModel, ref List<BuildingBuffDescStruct> descs)
		{
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D10")]
		[Address(RVA = "0x1789000", Offset = "0x1787C00", VA = "0x181789000")]
		private static void _LoadBuffDesc(string charId, EvolvePhase phase, int level, ref List<BuildingBuffDescStruct> descs)
		{
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D11")]
		[Address(RVA = "0x1788880", Offset = "0x1787480", VA = "0x181788880")]
		public static List<BuildingData.BuildingBuffCharSlot> GetBuffSlots(string charId)
		{
			return null;
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D12")]
		[Address(RVA = "0x1788710", Offset = "0x1787310", VA = "0x181788710")]
		public static BuildingData.BuildingBuff FindUnlockedBuffFromSlot(EvolvePhase phase, int level, BuildingData.BuildingBuffCharSlot slot)
		{
			return null;
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x0002D618 File Offset: 0x0002B818
		[Token(Token = "0x6004D13")]
		[Address(RVA = "0x1788530", Offset = "0x1787130", VA = "0x181788530")]
		public static KeyValuePair<CharacterData.UnlockCondition, BuildingData.BuildingBuff> FindFirstLockedBuffFromSlot(EvolvePhase phase, int level, BuildingData.BuildingBuffCharSlot slot)
		{
			return default(KeyValuePair<CharacterData.UnlockCondition, BuildingData.BuildingBuff>);
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D14")]
		[Address(RVA = "0x1788360", Offset = "0x1786F60", VA = "0x181788360")]
		public static void FindChangedBuffs(string charId, EvolvePhase fromPhase, int fromLevel, EvolvePhase toPhase, int toLevel, out List<BuildingData.BuildingBuff> upgradedBuffs, out List<BuildingData.BuildingBuff> unlockedBuffs)
		{
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x1788E30", Offset = "0x1787A30", VA = "0x181788E30")]
		public static string ParseBuffUnlockCondition(CharacterData.UnlockCondition condition, bool isReplace = false)
		{
			return null;
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D16")]
		[Address(RVA = "0x1788BA0", Offset = "0x17877A0", VA = "0x181788BA0")]
		public static Sprite LoadBuffIcon(string iconId)
		{
			return null;
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D17")]
		[Address(RVA = "0x1788D00", Offset = "0x1787900", VA = "0x181788D00")]
		public static BuildingBuffImgConfig LoadBuffImageConfig()
		{
			return null;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D18")]
		[Address(RVA = "0x1788E00", Offset = "0x1787A00", VA = "0x181788E00")]
		public static Sprite LoadBuffSkillIcon(string iconId)
		{
			return null;
		}
	}
}
