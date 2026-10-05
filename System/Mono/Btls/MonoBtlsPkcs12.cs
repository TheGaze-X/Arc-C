using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Mono.Btls
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	internal class MonoBtlsPkcs12 : MonoBtlsObject
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		internal new MonoBtlsPkcs12.BoringPkcs12Handle Handle
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x4F59210", Offset = "0x4F57E10", VA = "0x184F59210")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001F8 RID: 504
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4F59370", Offset = "0x4F57F70", VA = "0x184F59370")]
		[PreserveSig]
		private static extern void mono_btls_pkcs12_free(IntPtr handle);

		// Token: 0x060001F9 RID: 505
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4F596F0", Offset = "0x4F582F0", VA = "0x184F596F0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_pkcs12_new();

		// Token: 0x060001FA RID: 506
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4F59480", Offset = "0x4F58080", VA = "0x184F59480")]
		[PreserveSig]
		private static extern int mono_btls_pkcs12_get_count(IntPtr handle);

		// Token: 0x060001FB RID: 507
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4F593F0", Offset = "0x4F57FF0", VA = "0x184F593F0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index);

		// Token: 0x060001FC RID: 508
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4F59600", Offset = "0x4F58200", VA = "0x184F59600")]
		[PreserveSig]
		private unsafe static extern int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password);

		// Token: 0x060001FD RID: 509
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4F59580", Offset = "0x4F58180", VA = "0x184F59580")]
		[PreserveSig]
		private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12);

		// Token: 0x060001FE RID: 510
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4F59500", Offset = "0x4F58100", VA = "0x184F59500")]
		[PreserveSig]
		private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12);

		// Token: 0x060001FF RID: 511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4F59090", Offset = "0x4F57C90", VA = "0x184F59090")]
		internal MonoBtlsPkcs12()
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x1700006A")]
		public int Count
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x4F59170", Offset = "0x4F57D70", VA = "0x184F59170")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4F58A90", Offset = "0x4F57690", VA = "0x184F58A90")]
		public MonoBtlsX509 GetCertificate(int index)
		{
			return null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4F58F30", Offset = "0x4F57B30", VA = "0x184F58F30")]
		public void Import(byte[] buffer, SafePasswordHandle password)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x1700006B")]
		public bool HasPrivateKey
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x4F592D0", Offset = "0x4F57ED0", VA = "0x184F592D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4F58CD0", Offset = "0x4F578D0", VA = "0x184F58CD0")]
		public MonoBtlsKey GetPrivateKey()
		{
			return null;
		}

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MonoBtlsKey privateKey;

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		internal class BoringPkcs12Handle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x4F4DCD0", Offset = "0x4F4C8D0", VA = "0x184F4DCD0")]
			public BoringPkcs12Handle(IntPtr handle)
			{
			}

			// Token: 0x06000206 RID: 518 RVA: 0x00002A18 File Offset: 0x00000C18
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x4F4DD60", Offset = "0x4F4C960", VA = "0x184F4DD60", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
