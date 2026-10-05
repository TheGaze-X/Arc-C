using System;
using Il2CppDummyDll;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public sealed class X509Store : IDisposable
	{
		// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x5137E70", Offset = "0x5136A70", VA = "0x185137E70")]
		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A9")]
		public X509Certificate2Collection Certificates
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x5137FE0", Offset = "0x5136BE0", VA = "0x185137FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		private X509Stores Factory
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x5138080", Offset = "0x5136C80", VA = "0x185138080")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AB")]
		internal X509Store Store
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x5137A00", Offset = "0x5136600", VA = "0x185137A00")]
		public void Close()
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x5137A00", Offset = "0x5136600", VA = "0x185137A00", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5137A40", Offset = "0x5136640", VA = "0x185137A40")]
		public void Open(OpenFlags flags)
		{
		}

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x10")]
		private string _name;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x18")]
		private StoreLocation _location;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x20")]
		private X509Certificate2Collection list;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x28")]
		private OpenFlags _flags;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x30")]
		private X509Store store;
	}
}
