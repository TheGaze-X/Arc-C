using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class LocalDataStoreSlot
	{
		// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x4D1F550", Offset = "0x4D1E150", VA = "0x184D1F550")]
		internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie)
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000129")]
		internal LocalDataStoreMgr Manager
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		[Token(Token = "0x1700012A")]
		internal int Slot
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x1700012B")]
		internal long Cookie
		{
			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x4D1F4C0", Offset = "0x4D1E0C0", VA = "0x184D1F4C0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LocalDataStoreMgr m_mgr;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_slot;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long m_cookie;
	}
}
