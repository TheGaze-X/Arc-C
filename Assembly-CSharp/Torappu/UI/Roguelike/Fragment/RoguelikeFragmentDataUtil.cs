using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Fragment
{
	// Token: 0x020057F5 RID: 22517
	[Token(Token = "0x20057F5")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeFragmentDataUtil
	{
		// Token: 0x06020EB7 RID: 134839 RVA: 0x000B7CA8 File Offset: 0x000B5EA8
		[Token(Token = "0x6020EB7")]
		[Address(RVA = "0x1B34320", Offset = "0x1B32F20", VA = "0x181B34320")]
		public static FragmentBagStatus GetCurrentBagStatus()
		{
			return FragmentBagStatus.NONE;
		}

		// Token: 0x06020EB8 RID: 134840 RVA: 0x000B7CC0 File Offset: 0x000B5EC0
		[Token(Token = "0x6020EB8")]
		[Address(RVA = "0x1B34430", Offset = "0x1B33030", VA = "0x181B34430")]
		public static FragmentBagStatus GetCurrentBagStatus(int totalWeight, int limitWeight, int overweight)
		{
			return FragmentBagStatus.NONE;
		}

		// Token: 0x06020EB9 RID: 134841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020EB9")]
		[Address(RVA = "0x1B34D10", Offset = "0x1B33910", VA = "0x181B34D10")]
		public static PlayerRoguelikeV2.CurrentData.Module.Fragment GetPlayerFragmentData()
		{
			return null;
		}

		// Token: 0x06020EBA RID: 134842 RVA: 0x000B7CD8 File Offset: 0x000B5ED8
		[Token(Token = "0x6020EBA")]
		[Address(RVA = "0x1B34C30", Offset = "0x1B33830", VA = "0x181B34C30")]
		public static int GetLimitWeightThresholdValue(string topicId)
		{
			return 0;
		}

		// Token: 0x06020EBB RID: 134843 RVA: 0x000B7CF0 File Offset: 0x000B5EF0
		[Token(Token = "0x6020EBB")]
		[Address(RVA = "0x1B34CA0", Offset = "0x1B338A0", VA = "0x181B34CA0")]
		public static int GetOverWeightThresholdValue(string topicId)
		{
			return 0;
		}

		// Token: 0x06020EBC RID: 134844 RVA: 0x000B7D08 File Offset: 0x000B5F08
		[Token(Token = "0x6020EBC")]
		[Address(RVA = "0x1B348B0", Offset = "0x1B334B0", VA = "0x181B348B0")]
		public static int GetFragmentCountByType(string topicId, RoguelikeFragmentType type)
		{
			return 0;
		}

		// Token: 0x06020EBD RID: 134845 RVA: 0x000B7D20 File Offset: 0x000B5F20
		[Token(Token = "0x6020EBD")]
		[Address(RVA = "0x1B34BD0", Offset = "0x1B337D0", VA = "0x181B34BD0")]
		public static int GetFragmentCount(string topicId)
		{
			return 0;
		}

		// Token: 0x06020EBE RID: 134846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020EBE")]
		[Address(RVA = "0x1B34DD0", Offset = "0x1B339D0", VA = "0x181B34DD0")]
		private static RoguelikeFragmentModuleConsts _GetFragmentModuleConsts(string topicId)
		{
			return null;
		}

		// Token: 0x06020EBF RID: 134847 RVA: 0x000B7D38 File Offset: 0x000B5F38
		[Token(Token = "0x6020EBF")]
		[Address(RVA = "0x1B34270", Offset = "0x1B32E70", VA = "0x181B34270")]
		public static bool CheckHasFragmentTroopCarry(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06020EC0 RID: 134848 RVA: 0x000B7D50 File Offset: 0x000B5F50
		[Token(Token = "0x6020EC0")]
		[Address(RVA = "0x1B33E00", Offset = "0x1B32A00", VA = "0x181B33E00")]
		public static bool CheckHasBetterTroopCarry(string topicId, int weightSlot)
		{
			return default(bool);
		}

		// Token: 0x06020EC1 RID: 134849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020EC1")]
		[Address(RVA = "0x1B344D0", Offset = "0x1B330D0", VA = "0x181B344D0")]
		public static List<uint> GetFragmentCarryCharUniqueList(string topicId)
		{
			return null;
		}

		// Token: 0x0402CBFB RID: 183291
		[Token(Token = "0x402CBFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCurrentBagStatus;

		// Token: 0x0402CBFC RID: 183292
		[Token(Token = "0x402CBFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_GetCurrentBagStatus;

		// Token: 0x0402CBFD RID: 183293
		[Token(Token = "0x402CBFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayerFragmentData;

		// Token: 0x0402CBFE RID: 183294
		[Token(Token = "0x402CBFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLimitWeightThresholdValue;

		// Token: 0x0402CBFF RID: 183295
		[Token(Token = "0x402CBFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetOverWeightThresholdValue;

		// Token: 0x0402CC00 RID: 183296
		[Token(Token = "0x402CC00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFragmentCountByType;

		// Token: 0x0402CC01 RID: 183297
		[Token(Token = "0x402CC01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetFragmentCount;

		// Token: 0x0402CC02 RID: 183298
		[Token(Token = "0x402CC02")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetFragmentModuleConsts;

		// Token: 0x0402CC03 RID: 183299
		[Token(Token = "0x402CC03")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckHasFragmentTroopCarry;

		// Token: 0x0402CC04 RID: 183300
		[Token(Token = "0x402CC04")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckHasBetterTroopCarry;

		// Token: 0x0402CC05 RID: 183301
		[Token(Token = "0x402CC05")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetFragmentCarryCharUniqueList;
	}
}
