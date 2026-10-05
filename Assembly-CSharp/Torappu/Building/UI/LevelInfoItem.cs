using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B5B RID: 7003
	[Token(Token = "0x2001B5B")]
	public struct LevelInfoItem
	{
		// Token: 0x0600AFDB RID: 45019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFDB")]
		[Address(RVA = "0x32B0670", Offset = "0x32AF270", VA = "0x1832B0670")]
		public LevelInfoItem(LevelInfoType type, string val0, [Optional] string val1, bool single = false)
		{
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFDC")]
		[Address(RVA = "0x32AF180", Offset = "0x32ADD80", VA = "0x1832AF180")]
		public static void ParseLevelInfoItemsUpgrade(string slotId, BuildingData.RoomType roomType, int level0, int level1, Action<LevelInfoItem> action)
		{
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFDD")]
		[Address(RVA = "0x32AC2E0", Offset = "0x32AAEE0", VA = "0x1832AC2E0")]
		public static void ParseLevelInfoItemsLeveldown(BuildingData.RoomType roomType, int level0, int level1, Action<LevelInfoItem> action)
		{
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFDE")]
		[Address(RVA = "0x32AEFB0", Offset = "0x32ADBB0", VA = "0x1832AEFB0")]
		public static void ParseLevelInfoItemsSingle(RoomSlotModel roomSlotModel, Action<LevelInfoItem> action, bool withStation = false, bool ignoreCustomManpowerRecover = false)
		{
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFDF")]
		[Address(RVA = "0x32AE1D0", Offset = "0x32ACDD0", VA = "0x1832AE1D0")]
		public static void ParseLevelInfoItemsSingle(string slotId, BuildingData.RoomType roomType, int level, Action<LevelInfoItem> action, bool withStation = false, int customManpowerRecover = 0, bool displayCustom = false, int buffRecoverPercent = 0)
		{
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE0")]
		[Address(RVA = "0x32AD820", Offset = "0x32AC420", VA = "0x1832AD820")]
		public static void ParseLevelInfoItemsSingleBuild(string slotId, BuildingData.RoomType roomType, Action<LevelInfoItem> action)
		{
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFE1")]
		[Address(RVA = "0x32B05F0", Offset = "0x32AF1F0", VA = "0x1832B05F0")]
		private static string _ParseHireSpeedForDisplay(BuildingData.HirePhase phase)
		{
			return null;
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE2")]
		[Address(RVA = "0x32B0430", Offset = "0x32AF030", VA = "0x1832B0430")]
		private static void _CountNewManufactFormula(string slotId, int targetLevel, out int prevCount, out int afterCount)
		{
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE3")]
		[Address(RVA = "0x32B0510", Offset = "0x32AF110", VA = "0x1832B0510")]
		private static void _CountNewWorkshopFormula(string slotId, int targetLevel, out int prevCount, out int afterCount)
		{
		}

		// Token: 0x0400AA1D RID: 43549
		[Token(Token = "0x400AA1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LevelInfoType type;

		// Token: 0x0400AA1E RID: 43550
		[Token(Token = "0x400AA1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string val0;

		// Token: 0x0400AA1F RID: 43551
		[Token(Token = "0x400AA1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string val1;

		// Token: 0x0400AA20 RID: 43552
		[Token(Token = "0x400AA20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool single;
	}
}
