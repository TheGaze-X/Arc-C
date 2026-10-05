using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x5135530", Offset = "0x5134130", VA = "0x185135530")]
		public X509EnhancedKeyUsageExtension()
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x5135600", Offset = "0x5134200", VA = "0x185135600")]
		public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x5135710", Offset = "0x5134310", VA = "0x185135710")]
		public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x5134BD0", Offset = "0x51337D0", VA = "0x185134BD0", Slot = "4")]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x5134E40", Offset = "0x5133A40", VA = "0x185134E40")]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			return AsnDecodeStatus.Ok;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x5135080", Offset = "0x5133C80", VA = "0x185135080")]
		internal byte[] Encode()
		{
			return null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x51351F0", Offset = "0x5133DF0", VA = "0x1851351F0", Slot = "6")]
		internal override string ToString(bool multiLine)
		{
			return null;
		}

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x28")]
		private OidCollection _enhKeyUsage;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x30")]
		private AsnDecodeStatus _status;
	}
}
