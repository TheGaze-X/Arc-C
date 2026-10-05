using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200250F RID: 9487
	[Token(Token = "0x200250F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class FilterUtil
	{
		// Token: 0x0600F475 RID: 62581 RVA: 0x0005A4F8 File Offset: 0x000586F8
		[Token(Token = "0x600F475")]
		public static int Filter<TEntity>(List<TEntity> candidates, Entity source, int maxNum, FilterUtil.FilterFunc filter, FP weightSmallEnoughGap) where TEntity : Entity
		{
			return 0;
		}

		// Token: 0x0600F476 RID: 62582 RVA: 0x0005A510 File Offset: 0x00058710
		[Token(Token = "0x600F476")]
		public static int Filter<TEntity>(List<TEntity> candidates, Entity source, int maxNum, FilterUtil.FilterFuncWithPriorWeight filter, FP weightSmallEnoughGap) where TEntity : Entity
		{
			return 0;
		}

		// Token: 0x0600F477 RID: 62583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F477")]
		[Address(RVA = "0x6C98D0", Offset = "0x6C84D0", VA = "0x1806C98D0")]
		private static void _SecondFilterInExtraMode(Entity candidate, Entity source, ref FP weight)
		{
		}

		// Token: 0x0600F478 RID: 62584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F478")]
		[Address(RVA = "0x6C99C0", Offset = "0x6C85C0", VA = "0x1806C99C0")]
		private static void _SecondFilterInSandBox(Entity candidate, Entity source, ref FP weight)
		{
		}

		// Token: 0x0600F479 RID: 62585 RVA: 0x0005A528 File Offset: 0x00058728
		[Token(Token = "0x600F479")]
		public static int Filter<TEntity>(List<TEntity> candidates, Entity source, int maxNum, FilterUtil.FilterFunc filter) where TEntity : Entity
		{
			return 0;
		}

		// Token: 0x0600F47A RID: 62586 RVA: 0x0005A540 File Offset: 0x00058740
		[Token(Token = "0x600F47A")]
		public static int Filter<TEntity>(List<TEntity> candidates, Entity source, int maxNum, FilterUtil.FilterFuncWithPriorWeight filter) where TEntity : Entity
		{
			return 0;
		}

		// Token: 0x0600F47B RID: 62587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F47B")]
		public static List<Entity> FilterWithVolumne<TEntity>(UnorderedArray<TEntity> candidates, Entity source, int maxVolume, FilterUtil.FilterFuncWithVolumne filter, FP weightSmallEnoughGap) where TEntity : Entity
		{
			return null;
		}

		// Token: 0x0600F47C RID: 62588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F47C")]
		public static List<Entity> FilterWithVolumne<TEntity>(UnorderedArray<TEntity> candidates, Entity source, int maxVolume, FilterUtil.FilterFuncWithVolumne filter) where TEntity : Entity
		{
			return null;
		}

		// Token: 0x0600F47D RID: 62589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F47D")]
		[Address(RVA = "0x6BF800", Offset = "0x6BE400", VA = "0x1806BF800")]
		public static List<Entity> FilterWithVolume(List<Entity> candidates, Entity source, int maxVolume, FilterUtil.FilterFuncWithVolumne filter)
		{
			return null;
		}

		// Token: 0x0600F47E RID: 62590 RVA: 0x0005A558 File Offset: 0x00058758
		[Token(Token = "0x600F47E")]
		[Address(RVA = "0x6BF140", Offset = "0x6BDD40", VA = "0x1806BF140")]
		public static int FilterTileWithinSliceInplace(ref List<Tile> candidates, int left, int right, FilterUtil.FilterFuncWithTile filter, FP weightSmallEnoughGap)
		{
			return 0;
		}

		// Token: 0x0600F47F RID: 62591 RVA: 0x0005A570 File Offset: 0x00058770
		[Token(Token = "0x600F47F")]
		[Address(RVA = "0x6BED70", Offset = "0x6BD970", VA = "0x1806BED70")]
		public static int FilterTileWithinSliceInplace(ref List<Tile> candidates, int left, int right, FilterUtil.FilterFuncWithTileWithPriorWeight filter, FP weightSmallEnoughGap)
		{
			return 0;
		}

		// Token: 0x0600F480 RID: 62592 RVA: 0x0005A588 File Offset: 0x00058788
		[Token(Token = "0x600F480")]
		[Address(RVA = "0x6BF5E0", Offset = "0x6BE1E0", VA = "0x1806BF5E0")]
		public static int FilterTileWithinSliceInplace(ref List<Tile> candidates, int left, int right, FilterUtil.FilterFuncWithTile filter)
		{
			return 0;
		}

		// Token: 0x0600F481 RID: 62593 RVA: 0x0005A5A0 File Offset: 0x000587A0
		[Token(Token = "0x600F481")]
		[Address(RVA = "0x6BF500", Offset = "0x6BE100", VA = "0x1806BF500")]
		public static int FilterTileWithinSliceInplace(ref List<Tile> candidates, int left, int right, FilterUtil.FilterFuncWithTileWithPriorWeight filter)
		{
			return 0;
		}

		// Token: 0x0600F482 RID: 62594 RVA: 0x0005A5B8 File Offset: 0x000587B8
		[Token(Token = "0x600F482")]
		[Address(RVA = "0x6BEA10", Offset = "0x6BD610", VA = "0x1806BEA10")]
		public static int FilterRandomTileWithOneGridOffset(List<Tile> tiles, List<Tile> result, int maxNum = 1)
		{
			return 0;
		}

		// Token: 0x0600F483 RID: 62595 RVA: 0x0005A5D0 File Offset: 0x000587D0
		[Token(Token = "0x600F483")]
		[Address(RVA = "0x6BFC40", Offset = "0x6BE840", VA = "0x1806BFC40")]
		public static int Filter(List<Entity> candidates, Entity source, int maxNum, FilterUtil.FilterType filterType)
		{
			return 0;
		}

		// Token: 0x0600F484 RID: 62596 RVA: 0x0005A5E8 File Offset: 0x000587E8
		[Token(Token = "0x600F484")]
		[Address(RVA = "0x6BF6C0", Offset = "0x6BE2C0", VA = "0x1806BF6C0")]
		public static int FilterWithFilterByPriorCompFunc(List<Entity> candidates, Entity source, int maxNum, FilterUtil.FilterType filterType, Comparison<Entity> priorComparison)
		{
			return 0;
		}

		// Token: 0x0600F485 RID: 62597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F485")]
		[Address(RVA = "0x6BE360", Offset = "0x6BCF60", VA = "0x1806BE360")]
		public static void ClearStaticVariables()
		{
		}

		// Token: 0x0600F486 RID: 62598 RVA: 0x0005A600 File Offset: 0x00058800
		[Token(Token = "0x600F486")]
		[Address(RVA = "0x6C1F40", Offset = "0x6C0B40", VA = "0x1806C1F40")]
		private static bool _Filter_All(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F487 RID: 62599 RVA: 0x0005A618 File Offset: 0x00058818
		[Token(Token = "0x600F487")]
		[Address(RVA = "0x6C7E00", Offset = "0x6C6A00", VA = "0x1806C7E00")]
		private static bool _Filter_HpRatioNotFullAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F488 RID: 62600 RVA: 0x0005A630 File Offset: 0x00058830
		[Token(Token = "0x600F488")]
		[Address(RVA = "0x6C7940", Offset = "0x6C6540", VA = "0x1806C7940")]
		private static bool _Filter_HpRatioNotFullAscFlyFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F489 RID: 62601 RVA: 0x0005A648 File Offset: 0x00058848
		[Token(Token = "0x600F489")]
		[Address(RVA = "0x6C7750", Offset = "0x6C6350", VA = "0x1806C7750")]
		private static bool _Filter_HpRatioAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F48A RID: 62602 RVA: 0x0005A660 File Offset: 0x00058860
		[Token(Token = "0x600F48A")]
		[Address(RVA = "0x6C7630", Offset = "0x6C6230", VA = "0x1806C7630")]
		private static bool _Filter_HpRatioAscHatredDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F48B RID: 62603 RVA: 0x0005A678 File Offset: 0x00058878
		[Token(Token = "0x600F48B")]
		[Address(RVA = "0x6C72F0", Offset = "0x6C5EF0", VA = "0x1806C72F0")]
		private static bool _Filter_HpRatioAscDistToSourceAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F48C RID: 62604 RVA: 0x0005A690 File Offset: 0x00058890
		[Token(Token = "0x600F48C")]
		[Address(RVA = "0x6C7810", Offset = "0x6C6410", VA = "0x1806C7810")]
		private static bool _Filter_HpRatioDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F48D RID: 62605 RVA: 0x0005A6A8 File Offset: 0x000588A8
		[Token(Token = "0x600F48D")]
		[Address(RVA = "0x6C7F20", Offset = "0x6C6B20", VA = "0x1806C7F20")]
		private static bool _Filter_HpRatioNotFull(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F48E RID: 62606 RVA: 0x0005A6C0 File Offset: 0x000588C0
		[Token(Token = "0x600F48E")]
		[Address(RVA = "0x6C33F0", Offset = "0x6C1FF0", VA = "0x1806C33F0")]
		private static bool _Filter_DistToExitAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F48F RID: 62607 RVA: 0x0005A6D8 File Offset: 0x000588D8
		[Token(Token = "0x600F48F")]
		[Address(RVA = "0x6C67C0", Offset = "0x6C53C0", VA = "0x1806C67C0")]
		private static bool _Filter_HatredDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F490 RID: 62608 RVA: 0x0005A6F0 File Offset: 0x000588F0
		[Token(Token = "0x600F490")]
		[Address(RVA = "0x6C49B0", Offset = "0x6C35B0", VA = "0x1806C49B0")]
		private static bool _Filter_HatredAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F491 RID: 62609 RVA: 0x0005A708 File Offset: 0x00058908
		[Token(Token = "0x600F491")]
		[Address(RVA = "0x6C8E40", Offset = "0x6C7A40", VA = "0x1806C8E40")]
		private static bool _Filter_NotStunnedHatredDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F492 RID: 62610 RVA: 0x0005A720 File Offset: 0x00058920
		[Token(Token = "0x600F492")]
		[Address(RVA = "0x6C8F60", Offset = "0x6C7B60", VA = "0x1806C8F60")]
		private static bool _Filter_OnlyLevitatedHatredDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F493 RID: 62611 RVA: 0x0005A738 File Offset: 0x00058938
		[Token(Token = "0x600F493")]
		[Address(RVA = "0x6C30B0", Offset = "0x6C1CB0", VA = "0x1806C30B0")]
		private static bool _Filter_DefDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F494 RID: 62612 RVA: 0x0005A750 File Offset: 0x00058950
		[Token(Token = "0x600F494")]
		[Address(RVA = "0x6C2F90", Offset = "0x6C1B90", VA = "0x1806C2F90")]
		private static bool _Filter_DefAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F495 RID: 62613 RVA: 0x0005A768 File Offset: 0x00058968
		[Token(Token = "0x600F495")]
		[Address(RVA = "0x6C5920", Offset = "0x6C4520", VA = "0x1806C5920")]
		private static bool _Filter_HatredDesFlyFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F496 RID: 62614 RVA: 0x0005A780 File Offset: 0x00058980
		[Token(Token = "0x600F496")]
		[Address(RVA = "0x6C5F60", Offset = "0x6C4B60", VA = "0x1806C5F60")]
		private static bool _Filter_HatredDesRangedFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F497 RID: 62615 RVA: 0x0005A798 File Offset: 0x00058998
		[Token(Token = "0x600F497")]
		[Address(RVA = "0x6C83B0", Offset = "0x6C6FB0", VA = "0x1806C83B0")]
		private static bool _Filter_LowlandFirstCreatedTimeDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F498 RID: 62616 RVA: 0x0005A7B0 File Offset: 0x000589B0
		[Token(Token = "0x600F498")]
		[Address(RVA = "0x6C29A0", Offset = "0x6C15A0", VA = "0x1806C29A0")]
		private static bool _Filter_CharBuildableTypeMeleeFirstHatredDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F499 RID: 62617 RVA: 0x0005A7C8 File Offset: 0x000589C8
		[Token(Token = "0x600F499")]
		[Address(RVA = "0x6C39E0", Offset = "0x6C25E0", VA = "0x1806C39E0")]
		private static bool _Filter_DistToSourceAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F49A RID: 62618 RVA: 0x0005A7E0 File Offset: 0x000589E0
		[Token(Token = "0x600F49A")]
		[Address(RVA = "0x6C3B20", Offset = "0x6C2720", VA = "0x1806C3B20")]
		private static bool _Filter_DistToSourceDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F49B RID: 62619 RVA: 0x0005A7F8 File Offset: 0x000589F8
		[Token(Token = "0x600F49B")]
		[Address(RVA = "0x6C45A0", Offset = "0x6C31A0", VA = "0x1806C45A0")]
		private static bool _Filter_Haak_Only_ForwardFirstManhattanAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F49C RID: 62620 RVA: 0x0005A810 File Offset: 0x00058A10
		[Token(Token = "0x600F49C")]
		[Address(RVA = "0x6C31E0", Offset = "0x6C1DE0", VA = "0x1806C31E0")]
		private static bool _Filter_DirectionalDistToSourceAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F49D RID: 62621 RVA: 0x0005A828 File Offset: 0x00058A28
		[Token(Token = "0x600F49D")]
		[Address(RVA = "0x6C94C0", Offset = "0x6C80C0", VA = "0x1806C94C0")]
		private static bool _Filter_Random(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F49E RID: 62622 RVA: 0x0005A840 File Offset: 0x00058A40
		[Token(Token = "0x600F49E")]
		[Address(RVA = "0x6C69F0", Offset = "0x6C55F0", VA = "0x1806C69F0")]
		private static bool _Filter_HpDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F49F RID: 62623 RVA: 0x0005A858 File Offset: 0x00058A58
		[Token(Token = "0x600F49F")]
		[Address(RVA = "0x6C3FA0", Offset = "0x6C2BA0", VA = "0x1806C3FA0")]
		private static bool _Filter_EpSanityDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A0 RID: 62624 RVA: 0x0005A870 File Offset: 0x00058A70
		[Token(Token = "0x600F4A0")]
		[Address(RVA = "0x6C40F0", Offset = "0x6C2CF0", VA = "0x1806C40F0")]
		private static bool _Filter_EpWaterDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A1 RID: 62625 RVA: 0x0005A888 File Offset: 0x00058A88
		[Token(Token = "0x600F4A1")]
		[Address(RVA = "0x6C68D0", Offset = "0x6C54D0", VA = "0x1806C68D0")]
		private static bool _Filter_HpAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A2 RID: 62626 RVA: 0x0005A8A0 File Offset: 0x00058AA0
		[Token(Token = "0x600F4A2")]
		[Address(RVA = "0x6C23D0", Offset = "0x6C0FD0", VA = "0x1806C23D0")]
		private static bool _Filter_AtkDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A3 RID: 62627 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		[Token(Token = "0x600F4A3")]
		[Address(RVA = "0x6C22B0", Offset = "0x6C0EB0", VA = "0x1806C22B0")]
		private static bool _Filter_AtkAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A4 RID: 62628 RVA: 0x0005A8D0 File Offset: 0x00058AD0
		[Token(Token = "0x600F4A4")]
		[Address(RVA = "0x6C8D10", Offset = "0x6C7910", VA = "0x1806C8D10")]
		private static bool _Filter_MaxHpDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A5 RID: 62629 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		[Token(Token = "0x600F4A5")]
		[Address(RVA = "0x6C8BF0", Offset = "0x6C77F0", VA = "0x1806C8BF0")]
		private static bool _Filter_MaxHpAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A6 RID: 62630 RVA: 0x0005A900 File Offset: 0x00058B00
		[Token(Token = "0x600F4A6")]
		[Address(RVA = "0x6C2850", Offset = "0x6C1450", VA = "0x1806C2850")]
		private static bool _Filter_BlockCountDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A7 RID: 62631 RVA: 0x0005A918 File Offset: 0x00058B18
		[Token(Token = "0x600F4A7")]
		[Address(RVA = "0x6C6580", Offset = "0x6C5180", VA = "0x1806C6580")]
		private static bool _Filter_HatredDesUnblockedFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A8 RID: 62632 RVA: 0x0005A930 File Offset: 0x00058B30
		[Token(Token = "0x600F4A8")]
		[Address(RVA = "0x6C4CE0", Offset = "0x6C38E0", VA = "0x1806C4CE0")]
		private static bool _Filter_HatredDesBlockedFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4A9 RID: 62633 RVA: 0x0005A948 File Offset: 0x00058B48
		[Token(Token = "0x600F4A9")]
		[Address(RVA = "0x6C6B20", Offset = "0x6C5720", VA = "0x1806C6B20")]
		private static bool _Filter_HpNotFullRandom(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x0005A960 File Offset: 0x00058B60
		[Token(Token = "0x600F4AA")]
		[Address(RVA = "0x6C5C10", Offset = "0x6C4810", VA = "0x1806C5C10")]
		private static bool _Filter_HatredDesInvisibleFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4AB RID: 62635 RVA: 0x0005A978 File Offset: 0x00058B78
		[Token(Token = "0x600F4AB")]
		[Address(RVA = "0x6C60D0", Offset = "0x6C4CD0", VA = "0x1806C60D0")]
		private static bool _Filter_HatredDesSleepingFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4AC RID: 62636 RVA: 0x0005A990 File Offset: 0x00058B90
		[Token(Token = "0x600F4AC")]
		[Address(RVA = "0x6C6410", Offset = "0x6C5010", VA = "0x1806C6410")]
		private static bool _Filter_HatredDesSleepingLast(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4AD RID: 62637 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		[Token(Token = "0x600F4AD")]
		[Address(RVA = "0x6C6240", Offset = "0x6C4E40", VA = "0x1806C6240")]
		private static bool _Filter_HatredDesSleepingLastExcludeImmuneSleeping(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4AE RID: 62638 RVA: 0x0005A9C0 File Offset: 0x00058BC0
		[Token(Token = "0x600F4AE")]
		[Address(RVA = "0x6C57C0", Offset = "0x6C43C0", VA = "0x1806C57C0")]
		private static bool _Filter_HatredDesExcludeImmuneSleeping(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x0005A9D8 File Offset: 0x00058BD8
		[Token(Token = "0x600F4AF")]
		[Address(RVA = "0x6C6EF0", Offset = "0x6C5AF0", VA = "0x1806C6EF0")]
		private static bool _Filter_HpRatioAscContainsStatusResistableBuffFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B0 RID: 62640 RVA: 0x0005A9F0 File Offset: 0x00058BF0
		[Token(Token = "0x600F4B0")]
		[Address(RVA = "0x6C7060", Offset = "0x6C5C60", VA = "0x1806C7060")]
		private static bool _Filter_HpRatioAscContainsStatusResistableBuff(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B1 RID: 62641 RVA: 0x0005AA08 File Offset: 0x00058C08
		[Token(Token = "0x600F4B1")]
		[Address(RVA = "0x6C52B0", Offset = "0x6C3EB0", VA = "0x1806C52B0")]
		private static bool _Filter_HatredDesDistFartherFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B2 RID: 62642 RVA: 0x0005AA20 File Offset: 0x00058C20
		[Token(Token = "0x600F4B2")]
		[Address(RVA = "0x6C5430", Offset = "0x6C4030", VA = "0x1806C5430")]
		private static bool _Filter_HatredDesDistNearerFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x0005AA38 File Offset: 0x00058C38
		[Token(Token = "0x600F4B3")]
		[Address(RVA = "0x6C8AB0", Offset = "0x6C76B0", VA = "0x1806C8AB0")]
		private static bool _Filter_MassDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x0005AA50 File Offset: 0x00058C50
		[Token(Token = "0x600F4B4")]
		[Address(RVA = "0x6C8790", Offset = "0x6C7390", VA = "0x1806C8790")]
		private static bool _Filter_MassAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B5 RID: 62645 RVA: 0x0005AA68 File Offset: 0x00058C68
		[Token(Token = "0x600F4B5")]
		[Address(RVA = "0x6C2CA0", Offset = "0x6C18A0", VA = "0x1806C2CA0")]
		private static bool _Filter_CreatedTimeDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B6 RID: 62646 RVA: 0x0005AA80 File Offset: 0x00058C80
		[Token(Token = "0x600F4B6")]
		[Address(RVA = "0x6C2BC0", Offset = "0x6C17C0", VA = "0x1806C2BC0")]
		private static bool _Filter_CreatedTimeAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B7 RID: 62647 RVA: 0x0005AA98 File Offset: 0x00058C98
		[Token(Token = "0x600F4B7")]
		[Address(RVA = "0x6C4430", Offset = "0x6C3030", VA = "0x1806C4430")]
		private static bool _Filter_GridposBySmallColBigRow(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B8 RID: 62648 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		[Token(Token = "0x600F4B8")]
		[Address(RVA = "0x6C7B20", Offset = "0x6C6720", VA = "0x1806C7B20")]
		private static bool _Filter_HpRatioNotFullAscMyTokenOrMeFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4B9 RID: 62649 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		[Token(Token = "0x600F4B9")]
		[Address(RVA = "0x6C3DB0", Offset = "0x6C29B0", VA = "0x1806C3DB0")]
		private static bool _Filter_EpMinAscHpRatioAscFirstNotAllFull(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4BA RID: 62650 RVA: 0x0005AAE0 File Offset: 0x00058CE0
		[Token(Token = "0x600F4BA")]
		[Address(RVA = "0x6C7440", Offset = "0x6C6040", VA = "0x1806C7440")]
		private static bool _Filter_HpRatioAscEpMinAscFirstNotAllFull(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4BB RID: 62651 RVA: 0x0005AAF8 File Offset: 0x00058CF8
		[Token(Token = "0x600F4BB")]
		[Address(RVA = "0x6C71D0", Offset = "0x6C5DD0", VA = "0x1806C71D0")]
		private static bool _Filter_HpRatioAscCreatedTimeDesFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4BC RID: 62652 RVA: 0x0005AB10 File Offset: 0x00058D10
		[Token(Token = "0x600F4BC")]
		[Address(RVA = "0x6C5100", Offset = "0x6C3D00", VA = "0x1806C5100")]
		private static bool _Filter_HatredDesColdFirstThenNotFrozen(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x0005AB28 File Offset: 0x00058D28
		[Token(Token = "0x600F4BD")]
		[Address(RVA = "0x6C88D0", Offset = "0x6C74D0", VA = "0x1806C88D0")]
		private static bool _Filter_MassDesSleepingFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x0005AB40 File Offset: 0x00058D40
		[Token(Token = "0x600F4BE")]
		[Address(RVA = "0x6C9760", Offset = "0x6C8360", VA = "0x1806C9760")]
		private static bool _Filter_TileHeightDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4BF RID: 62655 RVA: 0x0005AB58 File Offset: 0x00058D58
		[Token(Token = "0x600F4BF")]
		[Address(RVA = "0x6C3C60", Offset = "0x6C2860", VA = "0x1806C3C60")]
		private static bool _Filter_EnemyFirstHatredDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C0 RID: 62656 RVA: 0x0005AB70 File Offset: 0x00058D70
		[Token(Token = "0x600F4C0")]
		[Address(RVA = "0x6C5DD0", Offset = "0x6C49D0", VA = "0x1806C5DD0")]
		private static bool _Filter_HatredDesLowLandFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C1 RID: 62657 RVA: 0x0005AB88 File Offset: 0x00058D88
		[Token(Token = "0x600F4C1")]
		[Address(RVA = "0x6C5A80", Offset = "0x6C4680", VA = "0x1806C5A80")]
		private static bool _Filter_HatredDesHighLandFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C2 RID: 62658 RVA: 0x0005ABA0 File Offset: 0x00058DA0
		[Token(Token = "0x600F4C2")]
		[Address(RVA = "0x6C55A0", Offset = "0x6C41A0", VA = "0x1806C55A0")]
		private static bool _Filter_HatredDesEliteBossFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C3 RID: 62659 RVA: 0x0005ABB8 File Offset: 0x00058DB8
		[Token(Token = "0x600F4C3")]
		[Address(RVA = "0x6C2DB0", Offset = "0x6C19B0", VA = "0x1806C2DB0")]
		private static bool _Filter_CrossOnlyWithHatredDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C4 RID: 62660 RVA: 0x0005ABD0 File Offset: 0x00058DD0
		[Token(Token = "0x600F4C4")]
		[Address(RVA = "0x6C4240", Offset = "0x6C2E40", VA = "0x1806C4240")]
		private static bool _Filter_FootballSearchTeammate(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C5 RID: 62661 RVA: 0x0005ABE8 File Offset: 0x00058DE8
		[Token(Token = "0x600F4C5")]
		[Address(RVA = "0x6C2650", Offset = "0x6C1250", VA = "0x1806C2650")]
		private static bool _Filter_BlockCntNoZeroDistToSourceAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C6 RID: 62662 RVA: 0x0005AC00 File Offset: 0x00058E00
		[Token(Token = "0x600F4C6")]
		[Address(RVA = "0x6C9360", Offset = "0x6C7F60", VA = "0x1806C9360")]
		private static bool _Filter_PreferNotInEpBreakAndHatredDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C7 RID: 62663 RVA: 0x0005AC18 File Offset: 0x00058E18
		[Token(Token = "0x600F4C7")]
		[Address(RVA = "0x6C9210", Offset = "0x6C7E10", VA = "0x1806C9210")]
		private static bool _Filter_PreferInEpBreakAndMinEpThenHatredDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C8 RID: 62664 RVA: 0x0005AC30 File Offset: 0x00058E30
		[Token(Token = "0x600F4C8")]
		[Address(RVA = "0x6C95F0", Offset = "0x6C81F0", VA = "0x1806C95F0")]
		private static bool _Filter_StayStillRandom(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4C9 RID: 62665 RVA: 0x0005AC48 File Offset: 0x00058E48
		[Token(Token = "0x600F4C9")]
		[Address(RVA = "0x6C4A90", Offset = "0x6C3690", VA = "0x1806C4A90")]
		private static bool _Filter_HatredDesBlockedByOwnerFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4CA RID: 62666 RVA: 0x0005AC60 File Offset: 0x00058E60
		[Token(Token = "0x600F4CA")]
		[Address(RVA = "0x6C2500", Offset = "0x6C1100", VA = "0x1806C2500")]
		private static bool _Filter_BlockCntAscCreatedTimeDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x0005AC78 File Offset: 0x00058E78
		[Token(Token = "0x600F4CB")]
		[Address(RVA = "0x6C4F20", Offset = "0x6C3B20", VA = "0x1806C4F20")]
		private static bool _Filter_HatredDesCharacterFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4CC RID: 62668 RVA: 0x0005AC90 File Offset: 0x00058E90
		[Token(Token = "0x600F4CC")]
		[Address(RVA = "0x6C8050", Offset = "0x6C6C50", VA = "0x1806C8050")]
		private static bool _Filter_KALSIT_M3_SELECTOR(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4CD RID: 62669 RVA: 0x0005ACA8 File Offset: 0x00058EA8
		[Token(Token = "0x600F4CD")]
		[Address(RVA = "0x6C8540", Offset = "0x6C7140", VA = "0x1806C8540")]
		private static bool _Filter_MagicResistAsc(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4CE RID: 62670 RVA: 0x0005ACC0 File Offset: 0x00058EC0
		[Token(Token = "0x600F4CE")]
		[Address(RVA = "0x6C8660", Offset = "0x6C7260", VA = "0x1806C8660")]
		private static bool _Filter_MagicResistDes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4CF RID: 62671 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		[Token(Token = "0x600F4CF")]
		[Address(RVA = "0x6C6DD0", Offset = "0x6C59D0", VA = "0x1806C6DD0")]
		private static bool _Filter_HpRatioAscContainsStatusResistableBuffFirstEvenHpFull(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4D0 RID: 62672 RVA: 0x0005ACF0 File Offset: 0x00058EF0
		[Token(Token = "0x600F4D0")]
		[Address(RVA = "0x6C6CB0", Offset = "0x6C58B0", VA = "0x1806C6CB0")]
		private static bool _Filter_HpRatioAscButSpLossDesFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4D1 RID: 62673 RVA: 0x0005AD08 File Offset: 0x00058F08
		[Token(Token = "0x600F4D1")]
		[Address(RVA = "0x6C2020", Offset = "0x6C0C20", VA = "0x1806C2020")]
		private static bool _Filter_AmmoNotFullCreatedTimeDesFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4D2 RID: 62674 RVA: 0x0005AD20 File Offset: 0x00058F20
		[Token(Token = "0x600F4D2")]
		[Address(RVA = "0x6C3610", Offset = "0x6C2210", VA = "0x1806C3610")]
		private static bool _Filter_DistToExitDes(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4D3 RID: 62675 RVA: 0x0005AD38 File Offset: 0x00058F38
		[Token(Token = "0x600F4D3")]
		[Address(RVA = "0x6C9070", Offset = "0x6C7C70", VA = "0x1806C9070")]
		private static bool _Filter_PathDistToSourceAsc(Entity candidate, Entity source, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F4D4 RID: 62676 RVA: 0x0005AD50 File Offset: 0x00058F50
		[Token(Token = "0x600F4D4")]
		[Address(RVA = "0x6C3830", Offset = "0x6C2430", VA = "0x1806C3830")]
		private static bool _Filter_DistToSourceAscLowLandFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F4D5 RID: 62677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F4D5")]
		[Address(RVA = "0x6BE480", Offset = "0x6BD080", VA = "0x1806BE480")]
		public static ReusableList<Entity> CollectLocatedCharacterLinkedWithTarget_DISPOSE(Entity mainTarget, Entity source, Func<Entity, bool> validator, int maxNum = 128, FilterUtil.FilterType type = FilterUtil.FilterType.ALL)
		{
			return null;
		}

		// Token: 0x04010EB6 RID: 69302
		[Token(Token = "0x4010EB6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FP DISTANCE_WEIGHT_SMALL_ENOUGH_GAP;

		// Token: 0x04010EB7 RID: 69303
		[Token(Token = "0x4010EB7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly FP HATRED_WEIGHT_SMALL_ENOUGH_GAP;

		// Token: 0x04010EB8 RID: 69304
		[Token(Token = "0x4010EB8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FP DEFAULT_SMALL_ENOUGH_GAP;

		// Token: 0x04010EB9 RID: 69305
		[Token(Token = "0x4010EB9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FP DEFAULT_MAX_WEIGHT;

		// Token: 0x04010EBA RID: 69306
		[Token(Token = "0x4010EBA")]
		[FieldOffset(Offset = "0x20")]
		private static PriorityQueue<FilterUtil.WeightedTarget<Entity>> s_weightQueue;

		// Token: 0x04010EBB RID: 69307
		[Token(Token = "0x4010EBB")]
		[FieldOffset(Offset = "0x28")]
		private static PriorityQueue<FilterUtil.WeightedTarget<Tile>> s_tileWeightQueue;

		// Token: 0x04010EBC RID: 69308
		[Token(Token = "0x4010EBC")]
		[FieldOffset(Offset = "0x30")]
		private static List<Entity> s_sharedList;

		// Token: 0x04010EBD RID: 69309
		[Token(Token = "0x4010EBD")]
		[FieldOffset(Offset = "0x38")]
		private static int WEIGHT_FOR_COL;

		// Token: 0x04010EBE RID: 69310
		[Token(Token = "0x4010EBE")]
		[FieldOffset(Offset = "0x3C")]
		private static int WEIGHT_FOR_SLEEPING;

		// Token: 0x04010EBF RID: 69311
		[Token(Token = "0x4010EBF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Filter;

		// Token: 0x04010EC0 RID: 69312
		[Token(Token = "0x4010EC0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_Filter;

		// Token: 0x04010EC1 RID: 69313
		[Token(Token = "0x4010EC1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SecondFilterInExtraMode;

		// Token: 0x04010EC2 RID: 69314
		[Token(Token = "0x4010EC2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SecondFilterInSandBox;

		// Token: 0x04010EC3 RID: 69315
		[Token(Token = "0x4010EC3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix2_Filter;

		// Token: 0x04010EC4 RID: 69316
		[Token(Token = "0x4010EC4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix3_Filter;

		// Token: 0x04010EC5 RID: 69317
		[Token(Token = "0x4010EC5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_FilterWithVolumne;

		// Token: 0x04010EC6 RID: 69318
		[Token(Token = "0x4010EC6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_FilterWithVolumne;

		// Token: 0x04010EC7 RID: 69319
		[Token(Token = "0x4010EC7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_FilterWithVolume;

		// Token: 0x04010EC8 RID: 69320
		[Token(Token = "0x4010EC8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FilterTileWithinSliceInplace;

		// Token: 0x04010EC9 RID: 69321
		[Token(Token = "0x4010EC9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1_FilterTileWithinSliceInplace;

		// Token: 0x04010ECA RID: 69322
		[Token(Token = "0x4010ECA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix2_FilterTileWithinSliceInplace;

		// Token: 0x04010ECB RID: 69323
		[Token(Token = "0x4010ECB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix3_FilterTileWithinSliceInplace;

		// Token: 0x04010ECC RID: 69324
		[Token(Token = "0x4010ECC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_FilterRandomTileWithOneGridOffset;

		// Token: 0x04010ECD RID: 69325
		[Token(Token = "0x4010ECD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix4_Filter;

		// Token: 0x04010ECE RID: 69326
		[Token(Token = "0x4010ECE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_FilterWithFilterByPriorCompFunc;

		// Token: 0x04010ECF RID: 69327
		[Token(Token = "0x4010ECF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ClearStaticVariables;

		// Token: 0x04010ED0 RID: 69328
		[Token(Token = "0x4010ED0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__Filter_All;

		// Token: 0x04010ED1 RID: 69329
		[Token(Token = "0x4010ED1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioNotFullAsc;

		// Token: 0x04010ED2 RID: 69330
		[Token(Token = "0x4010ED2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioNotFullAscFlyFirst;

		// Token: 0x04010ED3 RID: 69331
		[Token(Token = "0x4010ED3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAsc;

		// Token: 0x04010ED4 RID: 69332
		[Token(Token = "0x4010ED4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscHatredDes;

		// Token: 0x04010ED5 RID: 69333
		[Token(Token = "0x4010ED5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscDistToSourceAsc;

		// Token: 0x04010ED6 RID: 69334
		[Token(Token = "0x4010ED6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioDes;

		// Token: 0x04010ED7 RID: 69335
		[Token(Token = "0x4010ED7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioNotFull;

		// Token: 0x04010ED8 RID: 69336
		[Token(Token = "0x4010ED8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__Filter_DistToExitAsc;

		// Token: 0x04010ED9 RID: 69337
		[Token(Token = "0x4010ED9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__Filter_HatredDes;

		// Token: 0x04010EDA RID: 69338
		[Token(Token = "0x4010EDA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__Filter_HatredAsc;

		// Token: 0x04010EDB RID: 69339
		[Token(Token = "0x4010EDB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__Filter_NotStunnedHatredDes;

		// Token: 0x04010EDC RID: 69340
		[Token(Token = "0x4010EDC")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__Filter_OnlyLevitatedHatredDes;

		// Token: 0x04010EDD RID: 69341
		[Token(Token = "0x4010EDD")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__Filter_DefDes;

		// Token: 0x04010EDE RID: 69342
		[Token(Token = "0x4010EDE")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__Filter_DefAsc;

		// Token: 0x04010EDF RID: 69343
		[Token(Token = "0x4010EDF")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesFlyFirst;

		// Token: 0x04010EE0 RID: 69344
		[Token(Token = "0x4010EE0")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesRangedFirst;

		// Token: 0x04010EE1 RID: 69345
		[Token(Token = "0x4010EE1")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__Filter_LowlandFirstCreatedTimeDes;

		// Token: 0x04010EE2 RID: 69346
		[Token(Token = "0x4010EE2")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__Filter_CharBuildableTypeMeleeFirstHatredDes;

		// Token: 0x04010EE3 RID: 69347
		[Token(Token = "0x4010EE3")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__Filter_DistToSourceAsc;

		// Token: 0x04010EE4 RID: 69348
		[Token(Token = "0x4010EE4")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__Filter_DistToSourceDes;

		// Token: 0x04010EE5 RID: 69349
		[Token(Token = "0x4010EE5")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__Filter_Haak_Only_ForwardFirstManhattanAsc;

		// Token: 0x04010EE6 RID: 69350
		[Token(Token = "0x4010EE6")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__Filter_DirectionalDistToSourceAsc;

		// Token: 0x04010EE7 RID: 69351
		[Token(Token = "0x4010EE7")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__Filter_Random;

		// Token: 0x04010EE8 RID: 69352
		[Token(Token = "0x4010EE8")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__Filter_HpDes;

		// Token: 0x04010EE9 RID: 69353
		[Token(Token = "0x4010EE9")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__Filter_EpSanityDes;

		// Token: 0x04010EEA RID: 69354
		[Token(Token = "0x4010EEA")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__Filter_EpWaterDes;

		// Token: 0x04010EEB RID: 69355
		[Token(Token = "0x4010EEB")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__Filter_HpAsc;

		// Token: 0x04010EEC RID: 69356
		[Token(Token = "0x4010EEC")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__Filter_AtkDes;

		// Token: 0x04010EED RID: 69357
		[Token(Token = "0x4010EED")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__Filter_AtkAsc;

		// Token: 0x04010EEE RID: 69358
		[Token(Token = "0x4010EEE")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__Filter_MaxHpDes;

		// Token: 0x04010EEF RID: 69359
		[Token(Token = "0x4010EEF")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__Filter_MaxHpAsc;

		// Token: 0x04010EF0 RID: 69360
		[Token(Token = "0x4010EF0")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__Filter_BlockCountDes;

		// Token: 0x04010EF1 RID: 69361
		[Token(Token = "0x4010EF1")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesUnblockedFirst;

		// Token: 0x04010EF2 RID: 69362
		[Token(Token = "0x4010EF2")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesBlockedFirst;

		// Token: 0x04010EF3 RID: 69363
		[Token(Token = "0x4010EF3")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__Filter_HpNotFullRandom;

		// Token: 0x04010EF4 RID: 69364
		[Token(Token = "0x4010EF4")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesInvisibleFirst;

		// Token: 0x04010EF5 RID: 69365
		[Token(Token = "0x4010EF5")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesSleepingFirst;

		// Token: 0x04010EF6 RID: 69366
		[Token(Token = "0x4010EF6")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesSleepingLast;

		// Token: 0x04010EF7 RID: 69367
		[Token(Token = "0x4010EF7")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesSleepingLastExcludeImmuneSleeping;

		// Token: 0x04010EF8 RID: 69368
		[Token(Token = "0x4010EF8")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesExcludeImmuneSleeping;

		// Token: 0x04010EF9 RID: 69369
		[Token(Token = "0x4010EF9")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscContainsStatusResistableBuffFirst;

		// Token: 0x04010EFA RID: 69370
		[Token(Token = "0x4010EFA")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscContainsStatusResistableBuff;

		// Token: 0x04010EFB RID: 69371
		[Token(Token = "0x4010EFB")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesDistFartherFirst;

		// Token: 0x04010EFC RID: 69372
		[Token(Token = "0x4010EFC")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesDistNearerFirst;

		// Token: 0x04010EFD RID: 69373
		[Token(Token = "0x4010EFD")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__Filter_MassDes;

		// Token: 0x04010EFE RID: 69374
		[Token(Token = "0x4010EFE")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__Filter_MassAsc;

		// Token: 0x04010EFF RID: 69375
		[Token(Token = "0x4010EFF")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__Filter_CreatedTimeDes;

		// Token: 0x04010F00 RID: 69376
		[Token(Token = "0x4010F00")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__Filter_CreatedTimeAsc;

		// Token: 0x04010F01 RID: 69377
		[Token(Token = "0x4010F01")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__Filter_GridposBySmallColBigRow;

		// Token: 0x04010F02 RID: 69378
		[Token(Token = "0x4010F02")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioNotFullAscMyTokenOrMeFirst;

		// Token: 0x04010F03 RID: 69379
		[Token(Token = "0x4010F03")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__Filter_EpMinAscHpRatioAscFirstNotAllFull;

		// Token: 0x04010F04 RID: 69380
		[Token(Token = "0x4010F04")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscEpMinAscFirstNotAllFull;

		// Token: 0x04010F05 RID: 69381
		[Token(Token = "0x4010F05")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscCreatedTimeDesFirst;

		// Token: 0x04010F06 RID: 69382
		[Token(Token = "0x4010F06")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesColdFirstThenNotFrozen;

		// Token: 0x04010F07 RID: 69383
		[Token(Token = "0x4010F07")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__Filter_MassDesSleepingFirst;

		// Token: 0x04010F08 RID: 69384
		[Token(Token = "0x4010F08")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__Filter_TileHeightDes;

		// Token: 0x04010F09 RID: 69385
		[Token(Token = "0x4010F09")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__Filter_EnemyFirstHatredDes;

		// Token: 0x04010F0A RID: 69386
		[Token(Token = "0x4010F0A")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesLowLandFirst;

		// Token: 0x04010F0B RID: 69387
		[Token(Token = "0x4010F0B")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesHighLandFirst;

		// Token: 0x04010F0C RID: 69388
		[Token(Token = "0x4010F0C")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesEliteBossFirst;

		// Token: 0x04010F0D RID: 69389
		[Token(Token = "0x4010F0D")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__Filter_CrossOnlyWithHatredDes;

		// Token: 0x04010F0E RID: 69390
		[Token(Token = "0x4010F0E")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__Filter_FootballSearchTeammate;

		// Token: 0x04010F0F RID: 69391
		[Token(Token = "0x4010F0F")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__Filter_BlockCntNoZeroDistToSourceAsc;

		// Token: 0x04010F10 RID: 69392
		[Token(Token = "0x4010F10")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__Filter_PreferNotInEpBreakAndHatredDes;

		// Token: 0x04010F11 RID: 69393
		[Token(Token = "0x4010F11")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__Filter_PreferInEpBreakAndMinEpThenHatredDes;

		// Token: 0x04010F12 RID: 69394
		[Token(Token = "0x4010F12")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__Filter_StayStillRandom;

		// Token: 0x04010F13 RID: 69395
		[Token(Token = "0x4010F13")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesBlockedByOwnerFirst;

		// Token: 0x04010F14 RID: 69396
		[Token(Token = "0x4010F14")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__Filter_BlockCntAscCreatedTimeDes;

		// Token: 0x04010F15 RID: 69397
		[Token(Token = "0x4010F15")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__Filter_HatredDesCharacterFirst;

		// Token: 0x04010F16 RID: 69398
		[Token(Token = "0x4010F16")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__Filter_KALSIT_M3_SELECTOR;

		// Token: 0x04010F17 RID: 69399
		[Token(Token = "0x4010F17")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__Filter_MagicResistAsc;

		// Token: 0x04010F18 RID: 69400
		[Token(Token = "0x4010F18")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__Filter_MagicResistDes;

		// Token: 0x04010F19 RID: 69401
		[Token(Token = "0x4010F19")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscContainsStatusResistableBuffFirstEvenHpFull;

		// Token: 0x04010F1A RID: 69402
		[Token(Token = "0x4010F1A")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__Filter_HpRatioAscButSpLossDesFirst;

		// Token: 0x04010F1B RID: 69403
		[Token(Token = "0x4010F1B")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0__Filter_AmmoNotFullCreatedTimeDesFirst;

		// Token: 0x04010F1C RID: 69404
		[Token(Token = "0x4010F1C")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0__Filter_DistToExitDes;

		// Token: 0x04010F1D RID: 69405
		[Token(Token = "0x4010F1D")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0__Filter_PathDistToSourceAsc;

		// Token: 0x04010F1E RID: 69406
		[Token(Token = "0x4010F1E")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0__Filter_DistToSourceAscLowLandFirst;

		// Token: 0x04010F1F RID: 69407
		[Token(Token = "0x4010F1F")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_CollectLocatedCharacterLinkedWithTarget_DISPOSE;

		// Token: 0x02002510 RID: 9488
		// (Invoke) Token: 0x0600F4D8 RID: 62680
		[Token(Token = "0x2002510")]
		public delegate bool FilterFunc(Entity candidate, Entity source, out FP weight);

		// Token: 0x02002511 RID: 9489
		// (Invoke) Token: 0x0600F4DC RID: 62684
		[Token(Token = "0x2002511")]
		public delegate bool FilterFuncWithPriorWeight(Entity candidate, Entity source, out FP weight, out FP priorWeight);

		// Token: 0x02002512 RID: 9490
		// (Invoke) Token: 0x0600F4E0 RID: 62688
		[Token(Token = "0x2002512")]
		public delegate bool FilterFuncWithVolumne(Entity candidate, Entity source, out FP weight, out int volume);

		// Token: 0x02002513 RID: 9491
		// (Invoke) Token: 0x0600F4E4 RID: 62692
		[Token(Token = "0x2002513")]
		public delegate bool FilterFuncWithTile(Tile tile, out FP weight);

		// Token: 0x02002514 RID: 9492
		// (Invoke) Token: 0x0600F4E8 RID: 62696
		[Token(Token = "0x2002514")]
		public delegate bool FilterFuncWithTileWithPriorWeight(Tile tile, out FP weight, out FP priorWeight);

		// Token: 0x02002515 RID: 9493
		[Token(Token = "0x2002515")]
		public enum FilterType
		{
			// Token: 0x04010F21 RID: 69409
			[Token(Token = "0x4010F21")]
			ALL,
			// Token: 0x04010F22 RID: 69410
			[Token(Token = "0x4010F22")]
			DIST_TO_EXIT_ASC,
			// Token: 0x04010F23 RID: 69411
			[Token(Token = "0x4010F23")]
			HP_RATIO_ASC,
			// Token: 0x04010F24 RID: 69412
			[Token(Token = "0x4010F24")]
			HP_RATIO_NOT_FULL_ASC,
			// Token: 0x04010F25 RID: 69413
			[Token(Token = "0x4010F25")]
			HATRED_DES,
			// Token: 0x04010F26 RID: 69414
			[Token(Token = "0x4010F26")]
			HP_RATIO_NOT_FULL,
			// Token: 0x04010F27 RID: 69415
			[Token(Token = "0x4010F27")]
			HATRED_DES_FLY_FIRST,
			// Token: 0x04010F28 RID: 69416
			[Token(Token = "0x4010F28")]
			HATRED_DES_RANGED_FIRST,
			// Token: 0x04010F29 RID: 69417
			[Token(Token = "0x4010F29")]
			DEF_DES,
			// Token: 0x04010F2A RID: 69418
			[Token(Token = "0x4010F2A")]
			DEF_ASC,
			// Token: 0x04010F2B RID: 69419
			[Token(Token = "0x4010F2B")]
			DIST_TO_SOURCE_DES,
			// Token: 0x04010F2C RID: 69420
			[Token(Token = "0x4010F2C")]
			DIST_TO_SOURCE_ASC,
			// Token: 0x04010F2D RID: 69421
			[Token(Token = "0x4010F2D")]
			NOT_STUNNED_HATRED_DES,
			// Token: 0x04010F2E RID: 69422
			[Token(Token = "0x4010F2E")]
			DIRECTIONAL_DIST_TO_SOURCE_ASC,
			// Token: 0x04010F2F RID: 69423
			[Token(Token = "0x4010F2F")]
			RANDOM,
			// Token: 0x04010F30 RID: 69424
			[Token(Token = "0x4010F30")]
			HP_DES,
			// Token: 0x04010F31 RID: 69425
			[Token(Token = "0x4010F31")]
			HP_ASC,
			// Token: 0x04010F32 RID: 69426
			[Token(Token = "0x4010F32")]
			ATK_DES,
			// Token: 0x04010F33 RID: 69427
			[Token(Token = "0x4010F33")]
			ATK_ASC,
			// Token: 0x04010F34 RID: 69428
			[Token(Token = "0x4010F34")]
			MAX_HP_DES,
			// Token: 0x04010F35 RID: 69429
			[Token(Token = "0x4010F35")]
			MAX_HP_ASC,
			// Token: 0x04010F36 RID: 69430
			[Token(Token = "0x4010F36")]
			HAAK_ONLY_FORWARD_FIRST_MANHATTAN_ASC,
			// Token: 0x04010F37 RID: 69431
			[Token(Token = "0x4010F37")]
			HATRED_DES_UNBLOCKED_FIRST,
			// Token: 0x04010F38 RID: 69432
			[Token(Token = "0x4010F38")]
			HP_NOT_FULL_RANDOM,
			// Token: 0x04010F39 RID: 69433
			[Token(Token = "0x4010F39")]
			HATRED_DES_INVISIBLE_FIRST,
			// Token: 0x04010F3A RID: 69434
			[Token(Token = "0x4010F3A")]
			HATRED_DES_DIST_FARTHER_FIRST,
			// Token: 0x04010F3B RID: 69435
			[Token(Token = "0x4010F3B")]
			HATRED_DES_DIST_NEARER_FIRST,
			// Token: 0x04010F3C RID: 69436
			[Token(Token = "0x4010F3C")]
			MASS_DES,
			// Token: 0x04010F3D RID: 69437
			[Token(Token = "0x4010F3D")]
			MASS_ASC,
			// Token: 0x04010F3E RID: 69438
			[Token(Token = "0x4010F3E")]
			HATRED_DES_SLEEPING_FIRST,
			// Token: 0x04010F3F RID: 69439
			[Token(Token = "0x4010F3F")]
			HP_RATIO_ASC_CONTAINS_STATUS_RESISTABLE_BUFF_FIRST,
			// Token: 0x04010F40 RID: 69440
			[Token(Token = "0x4010F40")]
			HATRED_DES_IMMUNE_SLEEPING_EXCLUDE,
			// Token: 0x04010F41 RID: 69441
			[Token(Token = "0x4010F41")]
			EP_DES,
			// Token: 0x04010F42 RID: 69442
			[Token(Token = "0x4010F42")]
			HATRED_DES_BLOCKED_FIRST,
			// Token: 0x04010F43 RID: 69443
			[Token(Token = "0x4010F43")]
			CREATED_TIME_DES,
			// Token: 0x04010F44 RID: 69444
			[Token(Token = "0x4010F44")]
			CREATED_TIME_ASC,
			// Token: 0x04010F45 RID: 69445
			[Token(Token = "0x4010F45")]
			HP_RATIO_NOT_FULL_ASC_MY_TOKEN_OR_ME_FIRST,
			// Token: 0x04010F46 RID: 69446
			[Token(Token = "0x4010F46")]
			EP_MIN_ASC_HP_RATIO_ASC_FIRST_NOT_ALL_FULL,
			// Token: 0x04010F47 RID: 69447
			[Token(Token = "0x4010F47")]
			HP_RATIO_ASC_EP_MIN_ASC_FIRST_NOT_ALL_FULL,
			// Token: 0x04010F48 RID: 69448
			[Token(Token = "0x4010F48")]
			HP_RATIO_ASC_CREATED_TIME_DES_FIRST,
			// Token: 0x04010F49 RID: 69449
			[Token(Token = "0x4010F49")]
			HATRED_DES_COLD_FIRST_THEN_NOT_FROZEN,
			// Token: 0x04010F4A RID: 69450
			[Token(Token = "0x4010F4A")]
			GRIDPOS_BY_SMALL_COL_BIG_ROW,
			// Token: 0x04010F4B RID: 69451
			[Token(Token = "0x4010F4B")]
			BLOCK_COUNT_DES,
			// Token: 0x04010F4C RID: 69452
			[Token(Token = "0x4010F4C")]
			HP_RATIO_ASC_CONTAINS_STATUS_RESISTABLE_BUFF,
			// Token: 0x04010F4D RID: 69453
			[Token(Token = "0x4010F4D")]
			MASS_DES_SLEEPING_FIRST,
			// Token: 0x04010F4E RID: 69454
			[Token(Token = "0x4010F4E")]
			HP_RATIO_DES,
			// Token: 0x04010F4F RID: 69455
			[Token(Token = "0x4010F4F")]
			HATRED_ASC,
			// Token: 0x04010F50 RID: 69456
			[Token(Token = "0x4010F50")]
			LOWLAND_FIRST_CREATED_TIME_DES,
			// Token: 0x04010F51 RID: 69457
			[Token(Token = "0x4010F51")]
			TILE_HEIGHT_DES,
			// Token: 0x04010F52 RID: 69458
			[Token(Token = "0x4010F52")]
			ONLY_LEVITATED_HATRED_DES,
			// Token: 0x04010F53 RID: 69459
			[Token(Token = "0x4010F53")]
			ENEMY_FIRST_HATRED_DES,
			// Token: 0x04010F54 RID: 69460
			[Token(Token = "0x4010F54")]
			HATRED_DES_LOWLAND_FIRST,
			// Token: 0x04010F55 RID: 69461
			[Token(Token = "0x4010F55")]
			HATRED_DES_HIGHLAND_FIRST,
			// Token: 0x04010F56 RID: 69462
			[Token(Token = "0x4010F56")]
			HATRED_DES_ELITE_BOSS_FIRST,
			// Token: 0x04010F57 RID: 69463
			[Token(Token = "0x4010F57")]
			CROSS_ONLY_WITH_HATRED_DES,
			// Token: 0x04010F58 RID: 69464
			[Token(Token = "0x4010F58")]
			FOOTBALL_SEARCH_TEAMMATE,
			// Token: 0x04010F59 RID: 69465
			[Token(Token = "0x4010F59")]
			BLOCK_CNT_NO_ZERO_DIST_TO_SOURCE_ASC,
			// Token: 0x04010F5A RID: 69466
			[Token(Token = "0x4010F5A")]
			PREFER_NOT_IN_EP_BREAK_AND_HATRED_DES,
			// Token: 0x04010F5B RID: 69467
			[Token(Token = "0x4010F5B")]
			STAY_STILL_RANDOM,
			// Token: 0x04010F5C RID: 69468
			[Token(Token = "0x4010F5C")]
			HATRED_DES_BLOCKED_BY_OWNER_FIRST,
			// Token: 0x04010F5D RID: 69469
			[Token(Token = "0x4010F5D")]
			EP_WATER_DES,
			// Token: 0x04010F5E RID: 69470
			[Token(Token = "0x4010F5E")]
			BLOCK_COUNT_ASC_CREATED_TIME_DES_FIRST,
			// Token: 0x04010F5F RID: 69471
			[Token(Token = "0x4010F5F")]
			HATRED_DES_CHARACTER_FIRST,
			// Token: 0x04010F60 RID: 69472
			[Token(Token = "0x4010F60")]
			HP_RATIO_ASC_CONTAINS_STATUS_RESISTABLE_BUFF_FIRST_EVEN_HP_FULL,
			// Token: 0x04010F61 RID: 69473
			[Token(Token = "0x4010F61")]
			KALSIT_M3_SELECTOR,
			// Token: 0x04010F62 RID: 69474
			[Token(Token = "0x4010F62")]
			HP_RATIO_ASC_BUT_SP_LOSS_DES_FIRST,
			// Token: 0x04010F63 RID: 69475
			[Token(Token = "0x4010F63")]
			AMMO_NOT_FULL_ASC_CREATED_TIME_DES_FIRST,
			// Token: 0x04010F64 RID: 69476
			[Token(Token = "0x4010F64")]
			MAGIC_RESIST_ASC,
			// Token: 0x04010F65 RID: 69477
			[Token(Token = "0x4010F65")]
			MAGIC_RESIST_DES,
			// Token: 0x04010F66 RID: 69478
			[Token(Token = "0x4010F66")]
			PREFER_IN_EP_BREAK_AND_MIN_EP_THEN_HATRED_DES,
			// Token: 0x04010F67 RID: 69479
			[Token(Token = "0x4010F67")]
			DIST_TO_EXIT_DES,
			// Token: 0x04010F68 RID: 69480
			[Token(Token = "0x4010F68")]
			FILTER_CHAR_BUILDABLE_TYPE_MELEE_FIRST_HATRED_DES,
			// Token: 0x04010F69 RID: 69481
			[Token(Token = "0x4010F69")]
			HATRED_DES_SLEEPING_LAST,
			// Token: 0x04010F6A RID: 69482
			[Token(Token = "0x4010F6A")]
			HATRED_DES_SLEEPING_LAST_EXCLUDE_SLEEP_IMMUNE,
			// Token: 0x04010F6B RID: 69483
			[Token(Token = "0x4010F6B")]
			HP_RATIO_ASC_HATRED_DES,
			// Token: 0x04010F6C RID: 69484
			[Token(Token = "0x4010F6C")]
			HP_RATIO_NOT_FULL_ASC_FLY_FIRST,
			// Token: 0x04010F6D RID: 69485
			[Token(Token = "0x4010F6D")]
			PATH_DIST_TO_SOURCE_ASC,
			// Token: 0x04010F6E RID: 69486
			[Token(Token = "0x4010F6E")]
			DIST_TO_SOURCE_ASC_LOWLAND_FIRST,
			// Token: 0x04010F6F RID: 69487
			[Token(Token = "0x4010F6F")]
			HP_RATIO_ASC_DIST_TO_SOURCE_ASC_FIRST
		}

		// Token: 0x02002516 RID: 9494
		[Token(Token = "0x2002516")]
		[Hotfix(HotfixFlag.Stateless)]
		private struct WeightedTarget<T> : IComparable<FilterUtil.WeightedTarget<T>> where T : class, IComparable<T>
		{
			// Token: 0x0600F4EB RID: 62699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F4EB")]
			public WeightedTarget(FP weight, T target)
			{
			}

			// Token: 0x0600F4EC RID: 62700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F4EC")]
			public WeightedTarget(FP weight, FP priorWeight, T target)
			{
			}

			// Token: 0x0600F4ED RID: 62701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F4ED")]
			public WeightedTarget(FP weight, T target, int volume)
			{
			}

			// Token: 0x0600F4EE RID: 62702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F4EE")]
			public WeightedTarget(FP weight, FP priorWeight, T target, int volume)
			{
			}

			// Token: 0x0600F4EF RID: 62703 RVA: 0x0005AD68 File Offset: 0x00058F68
			[Token(Token = "0x600F4EF")]
			public int CompareTo(FilterUtil.WeightedTarget<T> another)
			{
				return 0;
			}

			// Token: 0x04010F70 RID: 69488
			[Token(Token = "0x4010F70")]
			[FieldOffset(Offset = "0x0")]
			public static FP s_curSmallEnoughGap;

			// Token: 0x04010F71 RID: 69489
			[Token(Token = "0x4010F71")]
			[FieldOffset(Offset = "0x0")]
			public FP weight;

			// Token: 0x04010F72 RID: 69490
			[Token(Token = "0x4010F72")]
			[FieldOffset(Offset = "0x0")]
			public FP priorWeight;

			// Token: 0x04010F73 RID: 69491
			[Token(Token = "0x4010F73")]
			[FieldOffset(Offset = "0x0")]
			public T target;

			// Token: 0x04010F74 RID: 69492
			[Token(Token = "0x4010F74")]
			[FieldOffset(Offset = "0x0")]
			public int volume;

			// Token: 0x04010F75 RID: 69493
			[Token(Token = "0x4010F75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04010F76 RID: 69494
			[Token(Token = "0x4010F76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix1_ctor;

			// Token: 0x04010F77 RID: 69495
			[Token(Token = "0x4010F77")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix2_ctor;

			// Token: 0x04010F78 RID: 69496
			[Token(Token = "0x4010F78")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix3_ctor;

			// Token: 0x04010F79 RID: 69497
			[Token(Token = "0x4010F79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;
		}
	}
}
