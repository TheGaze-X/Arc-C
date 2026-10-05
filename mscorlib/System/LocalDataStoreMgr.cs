using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	internal sealed class LocalDataStoreMgr
	{
		// Token: 0x06000DA0 RID: 3488 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x4D1ED20", Offset = "0x4D1D920", VA = "0x184D1ED20")]
		public LocalDataStoreHolder CreateLocalDataStore()
		{
			return null;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x4D1EED0", Offset = "0x4D1DAD0", VA = "0x184D1EED0")]
		public void DeleteLocalDataStore(LocalDataStore store)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x4D1E9D0", Offset = "0x4D1D5D0", VA = "0x184D1E9D0")]
		public System.LocalDataStoreSlot AllocateDataSlot()
		{
			return null;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x4D1EC30", Offset = "0x4D1D830", VA = "0x184D1EC30")]
		public System.LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			return null;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x4D1F220", Offset = "0x4D1DE20", VA = "0x184D1F220")]
		public System.LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			return null;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x4D1F150", Offset = "0x4D1DD50", VA = "0x184D1F150")]
		public void FreeNamedDataSlot(string name)
		{
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x4D1EFA0", Offset = "0x4D1DBA0", VA = "0x184D1EFA0")]
		internal void FreeDataSlot(int slot, long cookie)
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x4D1F330", Offset = "0x4D1DF30", VA = "0x184D1F330")]
		public void ValidateSlot(System.LocalDataStoreSlot slot)
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0")]
		internal int GetSlotTableLength()
		{
			return 0;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x4D1F3C0", Offset = "0x4D1DFC0", VA = "0x184D1F3C0")]
		public LocalDataStoreMgr()
		{
		}

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		private const int InitialSlotTableSize = 64;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		private const int SlotTableDoubleThreshold = 512;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		private const int LargeSlotTableSizeIncrease = 128;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x10")]
		private bool[] m_SlotInfoTable;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x18")]
		private int m_FirstAvailableSlot;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x20")]
		private System.Collections.Generic.List<LocalDataStore> m_ManagedLocalDataStores;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x28")]
		private System.Collections.Generic.Dictionary<string, System.LocalDataStoreSlot> m_KeyToSlotMap;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x30")]
		private long m_CookieGenerator;
	}
}
