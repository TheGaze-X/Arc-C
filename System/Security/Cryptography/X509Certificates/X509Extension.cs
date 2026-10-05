using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public class X509Extension : AsnEncodedData
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509Extension()
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x51368E0", Offset = "0x51354E0", VA = "0x1851368E0")]
		public X509Extension(string oid, byte[] rawData, bool critical)
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00005268 File Offset: 0x00003468
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A1")]
		public bool Critical
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x5136590", Offset = "0x5135190", VA = "0x185136590", Slot = "4")]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x51367C0", Offset = "0x51353C0", VA = "0x1851367C0")]
		internal string FormatUnkownData(byte[] data)
		{
			return null;
		}

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x20")]
		private bool _critical;
	}
}
