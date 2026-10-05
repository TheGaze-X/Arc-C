using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	internal class MonoBtlsBioMemory : MonoBtlsBio
	{
		// Token: 0x06000199 RID: 409
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4F53870", Offset = "0x4F52470", VA = "0x184F53870")]
		[PreserveSig]
		private static extern IntPtr mono_btls_bio_mem_new();

		// Token: 0x0600019A RID: 410
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4F537E0", Offset = "0x4F523E0", VA = "0x184F537E0")]
		[PreserveSig]
		private static extern int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data);

		// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4F53700", Offset = "0x4F52300", VA = "0x184F53700")]
		public MonoBtlsBioMemory()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4F534C0", Offset = "0x4F520C0", VA = "0x184F534C0")]
		public byte[] GetData()
		{
			return null;
		}
	}
}
