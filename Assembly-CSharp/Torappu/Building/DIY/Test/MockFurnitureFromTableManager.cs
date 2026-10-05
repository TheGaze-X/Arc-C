using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x0200191E RID: 6430
	[Token(Token = "0x200191E")]
	public class MockFurnitureFromTableManager : MonoBehaviour, IFurnitureManager, IFurnitureProvider
	{
		// Token: 0x0600A1F9 RID: 41465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1F9")]
		[Address(RVA = "0x31CF290", Offset = "0x31CDE90", VA = "0x1831CF290")]
		public void Setup([Optional] IFurnitureDataProvider db)
		{
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1FA")]
		[Address(RVA = "0x31CEB30", Offset = "0x31CD730", VA = "0x1831CEB30", Slot = "4")]
		public void AddFurniture(Furniture furniture)
		{
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1FB")]
		[Address(RVA = "0x31CF0C0", Offset = "0x31CDCC0", VA = "0x1831CF0C0", Slot = "5")]
		public void RemoveFurniture(Furniture furniture)
		{
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1FC")]
		[Address(RVA = "0x31CECF0", Offset = "0x31CD8F0", VA = "0x1831CECF0", Slot = "6")]
		public void ClearFurniture()
		{
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1FD")]
		[Address(RVA = "0x31CEE60", Offset = "0x31CDA60", VA = "0x1831CEE60", Slot = "7")]
		public void QueryData(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1FE")]
		[Address(RVA = "0x31CEF50", Offset = "0x31CDB50", VA = "0x1831CEF50", Slot = "8")]
		public void QueryDatas(Predicate<Furniture> filter, Action<Furniture> action)
		{
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1FF")]
		[Address(RVA = "0x31CF040", Offset = "0x31CDC40", VA = "0x1831CF040", Slot = "9")]
		public void RegisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A200")]
		[Address(RVA = "0x31CF750", Offset = "0x31CE350", VA = "0x1831CF750", Slot = "10")]
		public void UnregisterListener(IFurnitureProviderListener listener)
		{
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A201")]
		[Address(RVA = "0x31CF7D0", Offset = "0x31CE3D0", VA = "0x1831CF7D0")]
		public MockFurnitureFromTableManager()
		{
		}

		// Token: 0x0400984E RID: 38990
		[Token(Token = "0x400984E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockFurnitureFromTableManager.MockFurnitureConfig[] _furnitureConfigs;

		// Token: 0x0400984F RID: 38991
		[Token(Token = "0x400984F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MockFurnitureManager _additionalManager;

		// Token: 0x04009850 RID: 38992
		[Token(Token = "0x4009850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MockFurnitureGroupDB _furnitureGroupDB;

		// Token: 0x04009851 RID: 38993
		[Token(Token = "0x4009851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<IFurnitureProviderListener> m_listeners;

		// Token: 0x04009852 RID: 38994
		[Token(Token = "0x4009852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Furniture> m_furnitures;

		// Token: 0x04009853 RID: 38995
		[Token(Token = "0x4009853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IFurnitureDataProvider m_furnitureDB;

		// Token: 0x0200191F RID: 6431
		[Token(Token = "0x200191F")]
		[Serializable]
		public class MockFurnitureConfig
		{
			// Token: 0x0600A203 RID: 41475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A203")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MockFurnitureConfig()
			{
			}

			// Token: 0x04009854 RID: 38996
			[Token(Token = "0x4009854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04009855 RID: 38997
			[Token(Token = "0x4009855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int pos0;

			// Token: 0x04009856 RID: 38998
			[Token(Token = "0x4009856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int pos1;

			// Token: 0x04009857 RID: 38999
			[Token(Token = "0x4009857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int roomIndex;
		}
	}
}
