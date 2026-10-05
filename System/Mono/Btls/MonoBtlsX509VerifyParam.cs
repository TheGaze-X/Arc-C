using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	internal class MonoBtlsX509VerifyParam : MonoBtlsObject
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		internal new MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle Handle
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x50DA160", Offset = "0x50D8D60", VA = "0x1850DA160")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600030B RID: 779
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x50DA2A0", Offset = "0x50D8EA0", VA = "0x1850DA2A0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle);

		// Token: 0x0600030C RID: 780
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x50DA3A0", Offset = "0x50D8FA0", VA = "0x1850DA3A0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name);

		// Token: 0x0600030D RID: 781
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x50DA220", Offset = "0x50D8E20", VA = "0x1850DA220")]
		[PreserveSig]
		private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param);

		// Token: 0x0600030E RID: 782
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x50DA420", Offset = "0x50D9020", VA = "0x1850DA420")]
		[PreserveSig]
		private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen);

		// Token: 0x0600030F RID: 783
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x50DA4C0", Offset = "0x50D90C0", VA = "0x1850DA4C0")]
		[PreserveSig]
		private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, long time);

		// Token: 0x06000310 RID: 784
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x50DA320", Offset = "0x50D8F20", VA = "0x1850DA320")]
		[PreserveSig]
		private static extern void mono_btls_x509_verify_param_free(IntPtr handle);

		// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x4FA7520", Offset = "0x4FA6120", VA = "0x184FA7520")]
		internal MonoBtlsX509VerifyParam(MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x50D97E0", Offset = "0x50D83E0", VA = "0x1850D97E0")]
		public MonoBtlsX509VerifyParam Copy()
		{
			return null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x50D9950", Offset = "0x50D8550", VA = "0x1850D9950")]
		public static MonoBtlsX509VerifyParam GetSslClient()
		{
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x50D9990", Offset = "0x50D8590", VA = "0x1850D9990")]
		public static MonoBtlsX509VerifyParam GetSslServer()
		{
			return null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x50D99D0", Offset = "0x50D85D0", VA = "0x1850D99D0")]
		public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false)
		{
			return null;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x17000080")]
		public bool CanModify
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x50DA0C0", Offset = "0x50D8CC0", VA = "0x1850DA0C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x50D9FD0", Offset = "0x50D8BD0", VA = "0x1850D9FD0")]
		private void WantToModify()
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x50D9C60", Offset = "0x50D8860", VA = "0x1850D9C60")]
		public void SetHost(string name)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x50D9E10", Offset = "0x50D8A10", VA = "0x1850D9E10")]
		public void SetTime(DateTime time)
		{
		}

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		internal class BoringX509VerifyParamHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x0600031A RID: 794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringX509VerifyParamHandle(IntPtr handle)
			{
			}

			// Token: 0x0600031B RID: 795 RVA: 0x00002E98 File Offset: 0x00001098
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x50C9C20", Offset = "0x50C8820", VA = "0x1850C9C20", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
