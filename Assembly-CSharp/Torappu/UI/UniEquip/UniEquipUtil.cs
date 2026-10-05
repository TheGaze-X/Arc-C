using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C1F RID: 15391
	[Token(Token = "0x2003C1F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UniEquipUtil
	{
		// Token: 0x0601813A RID: 98618 RVA: 0x00099390 File Offset: 0x00097590
		[Token(Token = "0x601813A")]
		[Address(RVA = "0x108C9C0", Offset = "0x108B5C0", VA = "0x18108C9C0")]
		public static int GetEquipMaxLevel()
		{
			return 0;
		}

		// Token: 0x0601813B RID: 98619 RVA: 0x000993A8 File Offset: 0x000975A8
		[Token(Token = "0x601813B")]
		[Address(RVA = "0x108CC30", Offset = "0x108B830", VA = "0x18108CC30")]
		public static bool IsEquipLevelValid(int level)
		{
			return default(bool);
		}

		// Token: 0x0601813C RID: 98620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601813C")]
		[Address(RVA = "0x108CCC0", Offset = "0x108B8C0", VA = "0x18108CCC0")]
		public static UniEquipData LoadUniEquipData(CharQuery charQuery, string equipId)
		{
			return null;
		}

		// Token: 0x0601813D RID: 98621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601813D")]
		[Address(RVA = "0x108CB10", Offset = "0x108B710", VA = "0x18108CB10")]
		public static List<ItemBundle> GetEquipUnlockItems(UniEquipData uniEquipData)
		{
			return null;
		}

		// Token: 0x0601813E RID: 98622 RVA: 0x000993C0 File Offset: 0x000975C0
		[Token(Token = "0x601813E")]
		[Address(RVA = "0x108CA30", Offset = "0x108B630", VA = "0x18108CA30")]
		public static int GetEquipUnlockFavorPoint(UniEquipData uniEquipData)
		{
			return 0;
		}

		// Token: 0x0601813F RID: 98623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601813F")]
		[Address(RVA = "0x108C4C0", Offset = "0x108B0C0", VA = "0x18108C4C0")]
		public static List<ItemBundle> GetEquipLevelUpItems(UniEquipData uniEquipData, int fromLevel, int targetLevel)
		{
			return null;
		}

		// Token: 0x06018140 RID: 98624 RVA: 0x000993D8 File Offset: 0x000975D8
		[Token(Token = "0x6018140")]
		[Address(RVA = "0x108C3E0", Offset = "0x108AFE0", VA = "0x18108C3E0")]
		public static int GetEquipLevelUpFavor(UniEquipData uniEquipData, int targetLevel)
		{
			return 0;
		}

		// Token: 0x06018141 RID: 98625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018141")]
		[Address(RVA = "0x108B140", Offset = "0x1089D40", VA = "0x18108B140")]
		public static List<RequireViewModel> GeneEquipRequireViewModelList(PlayerCharacter playerChar, UniEquipData uniEquipData, List<ItemBundle> requireItems, int requireFavor, bool needPlayerRequires = true)
		{
			return null;
		}

		// Token: 0x06018142 RID: 98626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018142")]
		[Address(RVA = "0x108A9F0", Offset = "0x10895F0", VA = "0x18108A9F0")]
		public static string ApplyBasicAttrText(string name, float delta, bool eorFlag = false)
		{
			return null;
		}

		// Token: 0x06018143 RID: 98627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018143")]
		[Address(RVA = "0x108A940", Offset = "0x1089540", VA = "0x18108A940")]
		public static void AmendStringIntoBuilderWithEnter(StringBuilder builder, string str)
		{
		}

		// Token: 0x06018144 RID: 98628 RVA: 0x000993F0 File Offset: 0x000975F0
		[Token(Token = "0x6018144")]
		[Address(RVA = "0x108AF10", Offset = "0x1089B10", VA = "0x18108AF10")]
		public static bool CheckEquipAvail(string equipId, EvolvePhase evolvePhase, int level)
		{
			return default(bool);
		}

		// Token: 0x06018145 RID: 98629 RVA: 0x00099408 File Offset: 0x00097608
		[Token(Token = "0x6018145")]
		[Address(RVA = "0x108B060", Offset = "0x1089C60", VA = "0x18108B060")]
		public static bool CheckEquipLevelUpValid(UniEquipData uniEquipData, int equipLevel, bool isUnlock)
		{
			return default(bool);
		}

		// Token: 0x06018146 RID: 98630 RVA: 0x00099420 File Offset: 0x00097620
		[Token(Token = "0x6018146")]
		[Address(RVA = "0x108ABB0", Offset = "0x10897B0", VA = "0x18108ABB0")]
		public static bool CheckEquipAttributesChanges(string uniEquipId, string charId)
		{
			return default(bool);
		}

		// Token: 0x06018147 RID: 98631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018147")]
		[Address(RVA = "0x108C200", Offset = "0x108AE00", VA = "0x18108C200")]
		public static string GetEquipAttrName(AttributeType attributeType)
		{
			return null;
		}

		// Token: 0x06018148 RID: 98632 RVA: 0x00099438 File Offset: 0x00097638
		[Token(Token = "0x6018148")]
		[Address(RVA = "0x108BC10", Offset = "0x108A810", VA = "0x18108BC10")]
		public static ValueTuple<string, string> GenerateUniEquipAttrChange(string charId, string uniEquipId, int equipLevel)
		{
			return default(ValueTuple<string, string>);
		}

		// Token: 0x06018149 RID: 98633 RVA: 0x00099450 File Offset: 0x00097650
		[Token(Token = "0x6018149")]
		[Address(RVA = "0x108B560", Offset = "0x108A160", VA = "0x18108B560")]
		public static ValueTuple<string, string> GenerateSubProfessionTraitChange(CharacterData charData, UniEquipData uniEquipData, int potentialRank, int equipLevel)
		{
			return default(ValueTuple<string, string>);
		}

		// Token: 0x0601814A RID: 98634 RVA: 0x00099468 File Offset: 0x00097668
		[Token(Token = "0x601814A")]
		[Address(RVA = "0x108B860", Offset = "0x108A460", VA = "0x18108B860")]
		public static ValueTuple<string, string> GenerateTalentChange(CharacterData charData, UniEquipData uniEquipData, int potentialRank, int equipLevel)
		{
			return default(ValueTuple<string, string>);
		}

		// Token: 0x0401D33E RID: 119614
		[Token(Token = "0x401D33E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<AttributeType> EQUIP_CHECK_TYPES;

		// Token: 0x0401D33F RID: 119615
		[Token(Token = "0x401D33F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEquipMaxLevel;

		// Token: 0x0401D340 RID: 119616
		[Token(Token = "0x401D340")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEquipLevelValid;

		// Token: 0x0401D341 RID: 119617
		[Token(Token = "0x401D341")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadUniEquipData;

		// Token: 0x0401D342 RID: 119618
		[Token(Token = "0x401D342")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEquipUnlockItems;

		// Token: 0x0401D343 RID: 119619
		[Token(Token = "0x401D343")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEquipUnlockFavorPoint;

		// Token: 0x0401D344 RID: 119620
		[Token(Token = "0x401D344")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEquipLevelUpItems;

		// Token: 0x0401D345 RID: 119621
		[Token(Token = "0x401D345")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEquipLevelUpFavor;

		// Token: 0x0401D346 RID: 119622
		[Token(Token = "0x401D346")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GeneEquipRequireViewModelList;

		// Token: 0x0401D347 RID: 119623
		[Token(Token = "0x401D347")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyBasicAttrText;

		// Token: 0x0401D348 RID: 119624
		[Token(Token = "0x401D348")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_AmendStringIntoBuilderWithEnter;

		// Token: 0x0401D349 RID: 119625
		[Token(Token = "0x401D349")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckEquipAvail;

		// Token: 0x0401D34A RID: 119626
		[Token(Token = "0x401D34A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckEquipLevelUpValid;

		// Token: 0x0401D34B RID: 119627
		[Token(Token = "0x401D34B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckEquipAttributesChanges;

		// Token: 0x0401D34C RID: 119628
		[Token(Token = "0x401D34C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetEquipAttrName;

		// Token: 0x0401D34D RID: 119629
		[Token(Token = "0x401D34D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GenerateUniEquipAttrChange;

		// Token: 0x0401D34E RID: 119630
		[Token(Token = "0x401D34E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GenerateSubProfessionTraitChange;

		// Token: 0x0401D34F RID: 119631
		[Token(Token = "0x401D34F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GenerateTalentChange;
	}
}
