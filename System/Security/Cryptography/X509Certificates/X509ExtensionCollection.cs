using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	public sealed class X509ExtensionCollection : ICollection, IEnumerable
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x5135FD0", Offset = "0x5134BD0", VA = "0x185135FD0")]
		public X509ExtensionCollection()
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x170001A2")]
		public int Count
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x4C5C450", Offset = "0x4C5B050", VA = "0x184C5C450", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x170001A3")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x4C5BA30", Offset = "0x4C5A630", VA = "0x184C5BA30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A4")]
		public object SyncRoot
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		[Token(Token = "0x170001A5")]
		public X509Extension this[string oid]
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x5136040", Offset = "0x5134C40", VA = "0x185136040")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x5135C10", Offset = "0x5134810", VA = "0x185135C10")]
		public int Add(X509Extension extension)
		{
			return 0;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x5135D60", Offset = "0x5134960", VA = "0x185135D60", Slot = "4")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x5135CC0", Offset = "0x51348C0", VA = "0x185135CC0")]
		public X509ExtensionEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x5135EC0", Offset = "0x5134AC0", VA = "0x185135EC0", Slot = "8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] Empty;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
