using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	internal sealed class LocalDataStore
	{
		// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x4D1FBA0", Offset = "0x4D1E7A0", VA = "0x184D1FBA0")]
		public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity)
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x4D1F5B0", Offset = "0x4D1E1B0", VA = "0x184D1F5B0")]
		internal void Dispose()
		{
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x4D1F640", Offset = "0x4D1E240", VA = "0x184D1F640")]
		public object GetData(System.LocalDataStoreSlot slot)
		{
			return null;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x4D1FA50", Offset = "0x4D1E650", VA = "0x184D1FA50")]
		public void SetData(System.LocalDataStoreSlot slot, object data)
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x4D1F5E0", Offset = "0x4D1E1E0", VA = "0x184D1F5E0")]
		internal void FreeData(int slot, long cookie)
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x4D1F780", Offset = "0x4D1E380", VA = "0x184D1F780")]
		private LocalDataStoreElement PopulateElement(System.LocalDataStoreSlot slot)
		{
			return null;
		}

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x10")]
		private LocalDataStoreElement[] m_DataTable;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x18")]
		private LocalDataStoreMgr m_Manager;
	}
}
