using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.DIY.UI;
using Torappu.Building.UI;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C3 RID: 6339
	[Token(Token = "0x20018C3")]
	public class FurnitureTypeDatabase : IFurnitureTypeDB, IHotfixable
	{
		// Token: 0x0600A004 RID: 40964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A004")]
		[Address(RVA = "0x31B55F0", Offset = "0x31B41F0", VA = "0x1831B55F0")]
		public void Setup()
		{
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A005")]
		[Address(RVA = "0x31B5440", Offset = "0x31B4040", VA = "0x1831B5440", Slot = "4")]
		public void QueryTypeFurnitures(BuildingData.FurnitureType furnitureType, Action<string> action)
		{
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A006")]
		[Address(RVA = "0x31B5300", Offset = "0x31B3F00", VA = "0x1831B5300", Slot = "5")]
		public string GetDisplayName(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A007")]
		[Address(RVA = "0x31B53A0", Offset = "0x31B3FA0", VA = "0x1831B53A0", Slot = "6")]
		public string GetFilterName(DIYFilterType filterType)
		{
			return null;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A008")]
		[Address(RVA = "0x31B58F0", Offset = "0x31B44F0", VA = "0x1831B58F0")]
		public FurnitureTypeDatabase()
		{
		}

		// Token: 0x04009663 RID: 38499
		[Token(Token = "0x4009663")]
		[FieldOffset(Offset = "0x10")]
		private List<FurnitureTypeDatabase.Entry> m_data;

		// Token: 0x04009664 RID: 38500
		[Token(Token = "0x4009664")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009665 RID: 38501
		[Token(Token = "0x4009665")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_QueryTypeFurnitures;

		// Token: 0x04009666 RID: 38502
		[Token(Token = "0x4009666")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDisplayName;

		// Token: 0x04009667 RID: 38503
		[Token(Token = "0x4009667")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFilterName;

		// Token: 0x04009668 RID: 38504
		[Token(Token = "0x4009668")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020018C4 RID: 6340
		[Token(Token = "0x20018C4")]
		private class Entry
		{
			// Token: 0x0600A009 RID: 40969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A009")]
			[Address(RVA = "0x31B0700", Offset = "0x31AF300", VA = "0x1831B0700")]
			public Entry()
			{
			}

			// Token: 0x04009669 RID: 38505
			[Token(Token = "0x4009669")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.FurnitureType type;

			// Token: 0x0400966A RID: 38506
			[Token(Token = "0x400966A")]
			[FieldOffset(Offset = "0x18")]
			public List<string> names;
		}
	}
}
