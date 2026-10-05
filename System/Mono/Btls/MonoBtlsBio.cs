using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	internal class MonoBtlsBio : MonoBtlsObject
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal MonoBtlsBio(MonoBtlsBio.BoringBioHandle handle)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		protected internal new MonoBtlsBio.BoringBioHandle Handle
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x4F549D0", Offset = "0x4F535D0", VA = "0x184F549D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000196 RID: 406
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4F54A90", Offset = "0x4F53690", VA = "0x184F54A90")]
		[PreserveSig]
		private static extern void mono_btls_bio_free(IntPtr handle);

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		protected internal class BoringBioHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x4F4DCD0", Offset = "0x4F4C8D0", VA = "0x184F4DCD0")]
			public BoringBioHandle(IntPtr handle)
			{
			}

			// Token: 0x06000198 RID: 408 RVA: 0x000027A8 File Offset: 0x000009A8
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x4F4DBF0", Offset = "0x4F4C7F0", VA = "0x184F4DBF0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
