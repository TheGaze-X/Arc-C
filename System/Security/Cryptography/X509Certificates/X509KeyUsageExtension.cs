using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public sealed class X509KeyUsageExtension : X509Extension
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x51378B0", Offset = "0x51364B0", VA = "0x1851378B0")]
		public X509KeyUsageExtension()
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x5137690", Offset = "0x5136290", VA = "0x185137690")]
		public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x51377A0", Offset = "0x51363A0", VA = "0x1851377A0")]
		public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x170001A8")]
		public X509KeyUsageFlags KeyUsages
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x5137980", Offset = "0x5136580", VA = "0x185137980")]
			get
			{
				return X509KeyUsageFlags.None;
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x5136C70", Offset = "0x5135870", VA = "0x185136C70", Slot = "4")]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x51371D0", Offset = "0x5135DD0", VA = "0x1851371D0")]
		internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
		{
			return X509KeyUsageFlags.None;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5136EE0", Offset = "0x5135AE0", VA = "0x185136EE0")]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			return AsnDecodeStatus.Ok;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x5137040", Offset = "0x5135C40", VA = "0x185137040")]
		internal byte[] Encode()
		{
			return null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x51371E0", Offset = "0x5135DE0", VA = "0x1851371E0", Slot = "6")]
		internal override string ToString(bool multiLine)
		{
			return null;
		}

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		internal const string oid = "2.5.29.15";

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		internal const string friendlyName = "Key Usage";

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		internal const X509KeyUsageFlags all = X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DecipherOnly;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x28")]
		private X509KeyUsageFlags _keyUsages;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x2C")]
		private AsnDecodeStatus _status;
	}
}
