using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C68 RID: 7272
	[Token(Token = "0x2001C68")]
	public static class Consts
	{
		// Token: 0x0600B499 RID: 46233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B499")]
		[Address(RVA = "0x32F8ED0", Offset = "0x32F7AD0", VA = "0x1832F8ED0")]
		public static Comparison<StationCharViewModel> AchieveCharSortFunc(RoomSlotModel slotModel, StationOrderStruct orderStruct)
		{
			return null;
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x00044748 File Offset: 0x00042948
		[Token(Token = "0x600B49A")]
		[Address(RVA = "0x32FA000", Offset = "0x32F8C00", VA = "0x1832FA000")]
		private static int _OverallCompare(StationCharViewModel lhs, StationCharViewModel rhs, RoomSlotModel slotModel, StationOrderStruct orderStruct)
		{
			return 0;
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B49B")]
		[Address(RVA = "0x32F9B30", Offset = "0x32F8730", VA = "0x1832F9B30")]
		private static ListDict<CharSortType, Func<StationCharViewModel, StationCharViewModel, int>> _AchieveSecondarySortFuncs(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x00044760 File Offset: 0x00042960
		[Token(Token = "0x600B49C")]
		[Address(RVA = "0x32F9E60", Offset = "0x32F8A60", VA = "0x1832F9E60")]
		private static int _CompareRoom(BuildingData.RoomType a, BuildingData.RoomType b)
		{
			return 0;
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x00044778 File Offset: 0x00042978
		[Token(Token = "0x600B49D")]
		[Address(RVA = "0x32F9F30", Offset = "0x32F8B30", VA = "0x1832F9F30")]
		private static int _CompareWorkState(StationedCharState a, StationedCharState b)
		{
			return 0;
		}

		// Token: 0x0600B49E RID: 46238 RVA: 0x00044790 File Offset: 0x00042990
		[Token(Token = "0x600B49E")]
		[Address(RVA = "0x32F9480", Offset = "0x32F8080", VA = "0x1832F9480")]
		public static int CompareCharByRoom(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x000447A8 File Offset: 0x000429A8
		[Token(Token = "0x600B49F")]
		[Address(RVA = "0x32F9520", Offset = "0x32F8120", VA = "0x1832F9520")]
		public static int CompareCharByWork(StationCharViewModel a, StationCharViewModel b, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x000447C0 File Offset: 0x000429C0
		[Token(Token = "0x600B4A0")]
		[Address(RVA = "0x32F9350", Offset = "0x32F7F50", VA = "0x1832F9350")]
		public static int CompareCharByLevel(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x000447D8 File Offset: 0x000429D8
		[Token(Token = "0x600B4A1")]
		[Address(RVA = "0x32F90D0", Offset = "0x32F7CD0", VA = "0x1832F90D0")]
		public static int CompareCharByBuffIndex(StationCharViewModel a, StationCharViewModel b, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x000447F0 File Offset: 0x000429F0
		[Token(Token = "0x600B4A2")]
		[Address(RVA = "0x32F9220", Offset = "0x32F7E20", VA = "0x1832F9220")]
		public static int CompareCharByFavor(StationCharViewModel a, StationCharViewModel b, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x00044808 File Offset: 0x00042A08
		[Token(Token = "0x600B4A3")]
		[Address(RVA = "0x32F96D0", Offset = "0x32F82D0", VA = "0x1832F96D0")]
		public static int SecCompareCharByBuffSortId(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x00044820 File Offset: 0x00042A20
		[Token(Token = "0x600B4A4")]
		[Address(RVA = "0x32F9710", Offset = "0x32F8310", VA = "0x1832F9710")]
		public static int SecCompareCharByBuff(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x00044838 File Offset: 0x00042A38
		[Token(Token = "0x600B4A5")]
		[Address(RVA = "0x32F9000", Offset = "0x32F7C00", VA = "0x1832F9000")]
		public static int CompareCharByApIncrease(StationCharViewModel a, StationCharViewModel b, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x00044850 File Offset: 0x00042A50
		[Token(Token = "0x600B4A6")]
		[Address(RVA = "0x32F96A0", Offset = "0x32F82A0", VA = "0x1832F96A0")]
		public static int SecCompareCharByApIncrease(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x00044868 File Offset: 0x00042A68
		[Token(Token = "0x600B4A7")]
		[Address(RVA = "0x32F9660", Offset = "0x32F8260", VA = "0x1832F9660")]
		public static int SecCompareCharByApDecrease(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x00044880 File Offset: 0x00042A80
		[Token(Token = "0x600B4A8")]
		[Address(RVA = "0x32F9A90", Offset = "0x32F8690", VA = "0x1832F9A90")]
		public static int SecCompareCharByRoom(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x00044898 File Offset: 0x00042A98
		[Token(Token = "0x600B4A9")]
		[Address(RVA = "0x32F9790", Offset = "0x32F8390", VA = "0x1832F9790")]
		public static int SecCompareCharByEvolvePhase(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x000448B0 File Offset: 0x00042AB0
		[Token(Token = "0x600B4AA")]
		[Address(RVA = "0x32F99A0", Offset = "0x32F85A0", VA = "0x1832F99A0")]
		public static int SecCompareCharByRarity(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x000448C8 File Offset: 0x00042AC8
		[Token(Token = "0x600B4AB")]
		[Address(RVA = "0x32F9880", Offset = "0x32F8480", VA = "0x1832F9880")]
		public static int SecCompareCharByLevel(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x000448E0 File Offset: 0x00042AE0
		[Token(Token = "0x600B4AC")]
		[Address(RVA = "0x32F9900", Offset = "0x32F8500", VA = "0x1832F9900")]
		public static int SecCompareCharByName(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4AD")]
		[Address(RVA = "0x32F8E20", Offset = "0x32F7A20", VA = "0x1832F8E20")]
		public static Comparison<StationCharViewModel> AchieveCharSortByEfficiencyFunc(StationOrderStruct orderStruct)
		{
			return null;
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x000448F8 File Offset: 0x00042AF8
		[Token(Token = "0x600B4AE")]
		[Address(RVA = "0x32F9150", Offset = "0x32F7D50", VA = "0x1832F9150")]
		public static int CompareCharByBuffMatchRoomTarget(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x00044910 File Offset: 0x00042B10
		[Token(Token = "0x600B4AF")]
		[Address(RVA = "0x32F9090", Offset = "0x32F7C90", VA = "0x1832F9090")]
		public static int CompareCharByBuffGroupSortId(StationCharViewModel a, StationCharViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x00044928 File Offset: 0x00042B28
		[Token(Token = "0x600B4B0")]
		[Address(RVA = "0x32F9040", Offset = "0x32F7C40", VA = "0x1832F9040")]
		public static int CompareCharByBuffEfficiency(StationCharViewModel a, StationCharViewModel b, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x00044940 File Offset: 0x00042B40
		[Token(Token = "0x600B4B1")]
		[Address(RVA = "0x32F91D0", Offset = "0x32F7DD0", VA = "0x1832F91D0")]
		public static int CompareCharByBuffSortIdForEfficiencySort(StationCharViewModel a, StationCharViewModel b, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0400B096 RID: 45206
		[Token(Token = "0x400B096")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ListDict<BuildingData.RoomType, int> ROOM_SORT_WEIGHT;

		// Token: 0x0400B097 RID: 45207
		[Token(Token = "0x400B097")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ListDict<StationedCharState, int> WORK_SORT_WEIGHT;

		// Token: 0x0400B098 RID: 45208
		[Token(Token = "0x400B098")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ListDict<CharSortType, Func<StationCharViewModel, StationCharViewModel, bool, int>> CHAR_SORT_FUNCS;
	}
}
