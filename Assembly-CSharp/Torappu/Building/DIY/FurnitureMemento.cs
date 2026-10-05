using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018AD RID: 6317
	[Token(Token = "0x20018AD")]
	public class FurnitureMemento : IFurnitureManager, IFurnitureProvider
	{
		// Token: 0x06009FA9 RID: 40873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FA9")]
		[Address(RVA = "0x31B09B0", Offset = "0x31AF5B0", VA = "0x1831B09B0")]
		public void BuildFromFurnitureManager(IFurnitureProvider mgr)
		{
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAA")]
		[Address(RVA = "0x31B1110", Offset = "0x31AFD10", VA = "0x1831B1110")]
		public void SaveToFurnitureManager(IFurnitureManager mgr)
		{
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAB")]
		[Address(RVA = "0x31B0CE0", Offset = "0x31AF8E0", VA = "0x1831B0CE0", Slot = "7")]
		public void QueryData(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAC")]
		[Address(RVA = "0x31B0DD0", Offset = "0x31AF9D0", VA = "0x1831B0DD0", Slot = "8")]
		public void QueryDatas(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAD")]
		[Address(RVA = "0x31B0EC0", Offset = "0x31AFAC0", VA = "0x1831B0EC0", Slot = "9")]
		public void RegisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAE")]
		[Address(RVA = "0x31B1470", Offset = "0x31B0070", VA = "0x1831B1470", Slot = "10")]
		public void UnregisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAF")]
		[Address(RVA = "0x31B07F0", Offset = "0x31AF3F0", VA = "0x1831B07F0", Slot = "4")]
		public void AddFurniture(Furniture furniture)
		{
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB0")]
		[Address(RVA = "0x31B0F40", Offset = "0x31AFB40", VA = "0x1831B0F40", Slot = "5")]
		public void RemoveFurniture(Furniture furniture)
		{
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB1")]
		[Address(RVA = "0x31B0B70", Offset = "0x31AF770", VA = "0x1831B0B70", Slot = "6")]
		public void ClearFurniture()
		{
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB2")]
		[Address(RVA = "0x31B14F0", Offset = "0x31B00F0", VA = "0x1831B14F0")]
		public FurnitureMemento()
		{
		}

		// Token: 0x04009636 RID: 38454
		[Token(Token = "0x4009636")]
		[FieldOffset(Offset = "0x10")]
		private List<IFurnitureProviderListener> m_listeners;

		// Token: 0x04009637 RID: 38455
		[Token(Token = "0x4009637")]
		[FieldOffset(Offset = "0x18")]
		private List<Furniture> m_furnitures;
	}
}
