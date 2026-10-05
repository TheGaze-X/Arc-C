using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018A7 RID: 6311
	[Token(Token = "0x20018A7")]
	public class FurnitureManager : IFurnitureManager, IFurnitureProvider
	{
		// Token: 0x06009F94 RID: 40852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F94")]
		[Address(RVA = "0x17B51E0", Offset = "0x17B3DE0", VA = "0x1817B51E0")]
		public void SetDataDirty()
		{
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F95")]
		[Address(RVA = "0x319D8B0", Offset = "0x319C4B0", VA = "0x18319D8B0")]
		public void Setup(IFurnitureDataProvider db, bool ignoreRefresh = false)
		{
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F96")]
		[Address(RVA = "0x319D140", Offset = "0x319BD40", VA = "0x18319D140")]
		public void Refresh(PlayerBuildingRoom playerBuildingRoom)
		{
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F97")]
		[Address(RVA = "0x319D9D0", Offset = "0x319C5D0", VA = "0x18319D9D0")]
		private void _Refresh(string slotId, PlayerBuildingDIYSolution diySolution)
		{
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F98")]
		[Address(RVA = "0x319CB70", Offset = "0x319B770", VA = "0x18319CB70", Slot = "4")]
		public void AddFurniture(Furniture furniture)
		{
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F99")]
		[Address(RVA = "0x319D6E0", Offset = "0x319C2E0", VA = "0x18319D6E0", Slot = "5")]
		public void RemoveFurniture(Furniture furniture)
		{
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F9A")]
		[Address(RVA = "0x319CD30", Offset = "0x319B930", VA = "0x18319CD30", Slot = "6")]
		public void ClearFurniture()
		{
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F9B")]
		[Address(RVA = "0x319CEA0", Offset = "0x319BAA0", VA = "0x18319CEA0", Slot = "7")]
		public void QueryData(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F9C")]
		[Address(RVA = "0x319CFF0", Offset = "0x319BBF0", VA = "0x18319CFF0", Slot = "8")]
		public void QueryDatas(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F9D")]
		[Address(RVA = "0x319D660", Offset = "0x319C260", VA = "0x18319D660", Slot = "9")]
		public void RegisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F9E")]
		[Address(RVA = "0x319D950", Offset = "0x319C550", VA = "0x18319D950", Slot = "10")]
		public void UnregisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F9F")]
		[Address(RVA = "0x319E2B0", Offset = "0x319CEB0", VA = "0x18319E2B0")]
		public FurnitureManager()
		{
		}

		// Token: 0x0400962B RID: 38443
		[Token(Token = "0x400962B")]
		[FieldOffset(Offset = "0x10")]
		private List<IFurnitureProviderListener> m_listeners;

		// Token: 0x0400962C RID: 38444
		[Token(Token = "0x400962C")]
		[FieldOffset(Offset = "0x18")]
		private List<Furniture> m_furnitures;

		// Token: 0x0400962D RID: 38445
		[Token(Token = "0x400962D")]
		[FieldOffset(Offset = "0x20")]
		private IFurnitureDataProvider m_furnitureDB;

		// Token: 0x0400962E RID: 38446
		[Token(Token = "0x400962E")]
		[FieldOffset(Offset = "0x28")]
		private bool m_furnitureDataDirty;
	}
}
