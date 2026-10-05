using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018EB RID: 6379
	[Token(Token = "0x20018EB")]
	public static class BuildingDIYUtil
	{
		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x0600A0D8 RID: 41176 RVA: 0x0003EA78 File Offset: 0x0003CC78
		[Token(Token = "0x17001278")]
		public static BuildingDIYUtil.DIYModeConfig currentDIYModeConfig
		{
			[Token(Token = "0x600A0D8")]
			[Address(RVA = "0x31A6C30", Offset = "0x31A5830", VA = "0x1831A6C30")]
			get
			{
				return default(BuildingDIYUtil.DIYModeConfig);
			}
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D9")]
		[Address(RVA = "0x31A6190", Offset = "0x31A4D90", VA = "0x1831A6190")]
		public static void OnRequestDIY(RoomSlotModel activeSelectedRoom)
		{
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0DA")]
		[Address(RVA = "0x31A6100", Offset = "0x31A4D00", VA = "0x1831A6100")]
		public static void OnCloseDIY()
		{
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DB")]
		[Address(RVA = "0x31A4720", Offset = "0x31A3320", VA = "0x1831A4720")]
		public static ICollection<IDIYItem> GetAllDIYItems(bool filterRoomType = true)
		{
			return null;
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DC")]
		[Address(RVA = "0x31A5440", Offset = "0x31A4040", VA = "0x1831A5440")]
		public static ICollection<IDIYItem> GetDIYItemsByType(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DD")]
		[Address(RVA = "0x31A4D70", Offset = "0x31A3970", VA = "0x1831A4D70")]
		public static ICollection<IDIYItem> GetDIYItemsBySubType(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DE")]
		[Address(RVA = "0x31A50D0", Offset = "0x31A3CD0", VA = "0x1831A50D0")]
		public static ICollection<IDIYItem> GetDIYItemsByTheme(BuildingData.CustomData.ThemeData themeData)
		{
			return null;
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DF")]
		[Address(RVA = "0x31A57A0", Offset = "0x31A43A0", VA = "0x1831A57A0")]
		public static ICollection<IDIYItem> GetDIYItemsFromRecentFurniture(ListDict<string, long> recentFurnitures, Predicate<IDIYItem> fiter, bool filterRoomType = true)
		{
			return null;
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0E0")]
		[Address(RVA = "0x31A6690", Offset = "0x31A5290", VA = "0x1831A6690")]
		private static ICollection<IDIYItem> _GetDIYItems(IList<IFurnitureData> furnitureDatas, IList<IDIYRoomModifierData> modifierDatas, bool filterRoomType = true)
		{
			return null;
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0E1")]
		[Address(RVA = "0x31A4B00", Offset = "0x31A3700", VA = "0x1831A4B00")]
		public static ICollection<BuildingData.CustomData.ThemeData> GetAllThemes()
		{
			return null;
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0E2")]
		[Address(RVA = "0x31A5D40", Offset = "0x31A4940", VA = "0x1831A5D40")]
		public static ICollection<BuildingData.CustomData.ThemeData> GetRecentThemes(ListDict<string, long> recentThemes)
		{
			return null;
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x0003EA90 File Offset: 0x0003CC90
		[Token(Token = "0x600A0E3")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool IsRoomTypeOnly(int enableRoomType, BuildingData.RoomType roomType)
		{
			return default(bool);
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x0003EAA8 File Offset: 0x0003CCA8
		[Token(Token = "0x600A0E4")]
		[Address(RVA = "0x31A45C0", Offset = "0x31A31C0", VA = "0x1831A45C0")]
		public static bool FilterCurrentRoomTypeEnable(IDIYItem item)
		{
			return default(bool);
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0E5")]
		[Address(RVA = "0x31A5C30", Offset = "0x31A4830", VA = "0x1831A5C30")]
		public static string GetFuncFurnitureTitleDesc()
		{
			return null;
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x0003EAC0 File Offset: 0x0003CCC0
		[Token(Token = "0x600A0E6")]
		[Address(RVA = "0x31A65B0", Offset = "0x31A51B0", VA = "0x1831A65B0")]
		private static bool _FilterCurrentRoomTypeEnable(int enableRoomType)
		{
			return default(bool);
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0E7")]
		[Address(RVA = "0x31A2E40", Offset = "0x31A1A40", VA = "0x1831A2E40")]
		public static void ApplyDIYPresetWithoutCheck(IDIYPreset preset, int roomIndex, IFurnitureManager furnitureManager, IDIYRoomModifierManager modifierManager, [Optional] DIYRoom room)
		{
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x0003EAD8 File Offset: 0x0003CCD8
		[Token(Token = "0x600A0E8")]
		[Address(RVA = "0x31A6960", Offset = "0x31A5560", VA = "0x1831A6960")]
		private static int _GetFurnitureTotalCount(string furnitureId)
		{
			return 0;
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x0003EAF0 File Offset: 0x0003CCF0
		[Token(Token = "0x600A0E9")]
		[Address(RVA = "0x31A6060", Offset = "0x31A4C60", VA = "0x1831A6060")]
		public static int GetSubTypeLimitCount(BuildingData.FurnitureSubType subType)
		{
			return 0;
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x0003EB08 File Offset: 0x0003CD08
		[Token(Token = "0x600A0EA")]
		[Address(RVA = "0x31A6300", Offset = "0x31A4F00", VA = "0x1831A6300")]
		public static bool ReplaceFuntionFuniture(IFurnitureManager manager, Furniture newFurniture, int roomIndex)
		{
			return default(bool);
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x0003EB20 File Offset: 0x0003CD20
		[Token(Token = "0x600A0EB")]
		[Address(RVA = "0x31A4640", Offset = "0x31A3240", VA = "0x1831A4640")]
		public static bool FilterFurniRoomType(string furnId)
		{
			return default(bool);
		}

		// Token: 0x04009735 RID: 38709
		[Token(Token = "0x4009735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<BuildingData.CustomData.ThemeData> m_sharedThemeDatas;

		// Token: 0x04009736 RID: 38710
		[Token(Token = "0x4009736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<IDIYItem> m_sharedDIYItems;

		// Token: 0x04009737 RID: 38711
		[Token(Token = "0x4009737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Furniture> m_sharedFurnitures;

		// Token: 0x04009738 RID: 38712
		[Token(Token = "0x4009738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static BuildingDIYUtil.DIYModeConfig m_currentDIYModeConfig;

		// Token: 0x020018EC RID: 6380
		[Token(Token = "0x20018EC")]
		public struct DIYModeConfig
		{
			// Token: 0x04009739 RID: 38713
			[Token(Token = "0x4009739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool showComfort;

			// Token: 0x0400973A RID: 38714
			[Token(Token = "0x400973A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool showRoomTitle;

			// Token: 0x0400973B RID: 38715
			[Token(Token = "0x400973B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool showShop;

			// Token: 0x0400973C RID: 38716
			[Token(Token = "0x400973C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int presetSlotCount;

			// Token: 0x0400973D RID: 38717
			[Token(Token = "0x400973D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int presetIndexStart;

			// Token: 0x0400973E RID: 38718
			[Token(Token = "0x400973E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400973F RID: 38719
			[Token(Token = "0x400973F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly BuildingDIYUtil.DIYModeConfig DEFAULT;

			// Token: 0x04009740 RID: 38720
			[Token(Token = "0x4009740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly BuildingDIYUtil.DIYModeConfig PRIVATE;

			// Token: 0x04009741 RID: 38721
			[Token(Token = "0x4009741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly BuildingDIYUtil.DIYModeConfig MEETING;
		}
	}
}
