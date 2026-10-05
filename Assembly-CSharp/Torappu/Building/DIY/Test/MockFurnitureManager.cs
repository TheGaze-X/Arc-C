using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001928 RID: 6440
	[Token(Token = "0x2001928")]
	public class MockFurnitureManager : MonoBehaviour, IFurnitureManager, IFurnitureProvider
	{
		// Token: 0x0600A231 RID: 41521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A231")]
		[Address(RVA = "0x31D0830", Offset = "0x31CF430", VA = "0x1831D0830")]
		public void Setup([Optional] IFurnitureDataProvider db)
		{
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A232")]
		[Address(RVA = "0x31D00D0", Offset = "0x31CECD0", VA = "0x1831D00D0", Slot = "4")]
		public void AddFurniture(Furniture furniture)
		{
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A233")]
		[Address(RVA = "0x31D0660", Offset = "0x31CF260", VA = "0x1831D0660", Slot = "5")]
		public void RemoveFurniture(Furniture furniture)
		{
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A234")]
		[Address(RVA = "0x31D0290", Offset = "0x31CEE90", VA = "0x1831D0290", Slot = "6")]
		public void ClearFurniture()
		{
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A235")]
		[Address(RVA = "0x31D0400", Offset = "0x31CF000", VA = "0x1831D0400", Slot = "7")]
		public void QueryData(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A236")]
		[Address(RVA = "0x31D04F0", Offset = "0x31CF0F0", VA = "0x1831D04F0", Slot = "8")]
		public void QueryDatas(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A237")]
		[Address(RVA = "0x31D05E0", Offset = "0x31CF1E0", VA = "0x1831D05E0", Slot = "9")]
		public void RegisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A238")]
		[Address(RVA = "0x31D0A00", Offset = "0x31CF600", VA = "0x1831D0A00", Slot = "10")]
		public void UnregisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A239")]
		[Address(RVA = "0x31D0A80", Offset = "0x31CF680", VA = "0x1831D0A80")]
		public MockFurnitureManager()
		{
		}

		// Token: 0x0400987E RID: 39038
		[Token(Token = "0x400987E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockFurnitureManager.MockFurnitureConfig[] _furnitureConfigs;

		// Token: 0x0400987F RID: 39039
		[Token(Token = "0x400987F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MockFurnitureDB _furnitureDB;

		// Token: 0x04009880 RID: 39040
		[Token(Token = "0x4009880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<IFurnitureProviderListener> m_listeners;

		// Token: 0x04009881 RID: 39041
		[Token(Token = "0x4009881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Furniture> m_furnitures;

		// Token: 0x04009882 RID: 39042
		[Token(Token = "0x4009882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IFurnitureDataProvider m_furnitureDB;

		// Token: 0x02001929 RID: 6441
		[Token(Token = "0x2001929")]
		[Serializable]
		public class MockFurnitureConfig
		{
			// Token: 0x0600A23A RID: 41530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A23A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MockFurnitureConfig()
			{
			}

			// Token: 0x04009883 RID: 39043
			[Token(Token = "0x4009883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04009884 RID: 39044
			[Token(Token = "0x4009884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int pos0;

			// Token: 0x04009885 RID: 39045
			[Token(Token = "0x4009885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int pos1;

			// Token: 0x04009886 RID: 39046
			[Token(Token = "0x4009886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int roomIndex;
		}
	}
}
