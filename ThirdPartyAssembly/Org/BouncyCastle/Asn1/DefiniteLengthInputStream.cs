using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	internal class DefiniteLengthInputStream : LimitedInputStream
	{
		// Token: 0x06001FDD RID: 8157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x531A5E0", Offset = "0x53191E0", VA = "0x18531A5E0")]
		internal DefiniteLengthInputStream(Stream inStream, int length)
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x17000426")]
		internal int Remaining
		{
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0000F120 File Offset: 0x0000D320
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x531A110", Offset = "0x5318D10", VA = "0x18531A110", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x531A260", Offset = "0x5318E60", VA = "0x18531A260", Slot = "32")]
		public override int Read(byte[] buf, int off, int len)
		{
			return 0;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x5319FA0", Offset = "0x5318BA0", VA = "0x185319FA0")]
		internal void ReadAllIntoByteArray(byte[] buf)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x531A3E0", Offset = "0x5318FE0", VA = "0x18531A3E0")]
		internal byte[] ToArray()
		{
			return null;
		}

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] EmptyBytes;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x40")]
		private readonly int _originalLength;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x44")]
		private int _remaining;
	}
}
