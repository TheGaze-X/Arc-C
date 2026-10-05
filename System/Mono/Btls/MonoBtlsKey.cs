using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	internal class MonoBtlsKey : MonoBtlsObject
	{
		// Token: 0x060001DB RID: 475
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4F580C0", Offset = "0x4F56CC0", VA = "0x184F580C0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_key_new();

		// Token: 0x060001DC RID: 476
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4F57F90", Offset = "0x4F56B90", VA = "0x184F57F90")]
		[PreserveSig]
		private static extern void mono_btls_key_free(IntPtr handle);

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4F58130", Offset = "0x4F56D30", VA = "0x184F58130")]
		[PreserveSig]
		private static extern IntPtr mono_btls_key_up_ref(IntPtr handle);

		// Token: 0x060001DE RID: 478
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4F58010", Offset = "0x4F56C10", VA = "0x184F58010")]
		[PreserveSig]
		private static extern int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits);

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4F57EE0", Offset = "0x4F56AE0", VA = "0x184F57EE0")]
		[PreserveSig]
		private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, byte[] der, int der_length);

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		internal new MonoBtlsKey.BoringKeyHandle Handle
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x4F57E20", Offset = "0x4F56A20", VA = "0x184F57E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal MonoBtlsKey(MonoBtlsKey.BoringKeyHandle handle)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4F57C50", Offset = "0x4F56850", VA = "0x184F57C50")]
		public byte[] GetBytes(bool include_private_bits)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4F578B0", Offset = "0x4F564B0", VA = "0x184F578B0")]
		public MonoBtlsKey Copy()
		{
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4F57A30", Offset = "0x4F56630", VA = "0x184F57A30")]
		public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey)
		{
			return null;
		}

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		internal class BoringKeyHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060001E5 RID: 485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x4F4DCD0", Offset = "0x4F4C8D0", VA = "0x184F4DCD0")]
			internal BoringKeyHandle(IntPtr handle)
			{
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x000029A0 File Offset: 0x00000BA0
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x4F4DCE0", Offset = "0x4F4C8E0", VA = "0x184F4DCE0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
