using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	public class DerObjectIdentifier : Asn1Object
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002083")]
		[Address(RVA = "0x53338C0", Offset = "0x53324C0", VA = "0x1853338C0")]
		public static DerObjectIdentifier GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x5333850", Offset = "0x5332450", VA = "0x185333850")]
		public static DerObjectIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002085")]
		[Address(RVA = "0x5334240", Offset = "0x5332E40", VA = "0x185334240")]
		public DerObjectIdentifier(string identifier)
		{
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002086")]
		[Address(RVA = "0x5334490", Offset = "0x5333090", VA = "0x185334490")]
		internal DerObjectIdentifier(DerObjectIdentifier oid, string branchID)
		{
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000435")]
		public string Id
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002088")]
		[Address(RVA = "0x5332FF0", Offset = "0x5331BF0", VA = "0x185332FF0", Slot = "9")]
		public virtual DerObjectIdentifier Branch(string branchID)
		{
			return null;
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x6002089")]
		[Address(RVA = "0x5333EA0", Offset = "0x5332AA0", VA = "0x185333EA0", Slot = "10")]
		public virtual bool On(DerObjectIdentifier stem)
		{
			return default(bool);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208A")]
		[Address(RVA = "0x5334400", Offset = "0x5333000", VA = "0x185334400")]
		internal DerObjectIdentifier(byte[] bytes)
		{
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x5333F40", Offset = "0x5332B40", VA = "0x185333F40")]
		private void WriteField(Stream outputStream, long fieldValue)
		{
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x5334050", Offset = "0x5332C50", VA = "0x185334050")]
		private void WriteField(Stream outputStream, BigInteger fieldValue)
		{
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x53331B0", Offset = "0x5331DB0", VA = "0x1853331B0")]
		private void DoOutput(MemoryStream bOut)
		{
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x5333720", Offset = "0x5332320", VA = "0x185333720")]
		internal byte[] GetBody()
		{
			return null;
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x53333E0", Offset = "0x5331FE0", VA = "0x1853333E0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x5332F40", Offset = "0x5331B40", VA = "0x185332F40", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x5333AC0", Offset = "0x53326C0", VA = "0x185333AC0")]
		private static bool IsValidBranchID(string branchID, int start)
		{
			return default(bool);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x5333B50", Offset = "0x5332750", VA = "0x185333B50")]
		private static bool IsValidIdentifier(string identifier)
		{
			return default(bool);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x5333BF0", Offset = "0x53327F0", VA = "0x185333BF0")]
		private static string MakeOidStringFromBytes(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x5333490", Offset = "0x5332090", VA = "0x185333490")]
		internal static DerObjectIdentifier FromOctetString(byte[] enc)
		{
			return null;
		}

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x10")]
		private readonly string identifier;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x18")]
		private byte[] body;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		private const long LONG_LIMIT = 72057594037927808L;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DerObjectIdentifier[] cache;
	}
}
