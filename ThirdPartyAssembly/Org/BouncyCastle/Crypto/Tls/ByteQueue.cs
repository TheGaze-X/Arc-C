using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000240")]
	public class ByteQueue
	{
		// Token: 0x0600141E RID: 5150 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x5242210", Offset = "0x5240E10", VA = "0x185242210")]
		public static int NextTwoPow(int i)
		{
			return 0;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x5242640", Offset = "0x5241240", VA = "0x185242640")]
		public ByteQueue()
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x52426A0", Offset = "0x52412A0", VA = "0x1852426A0")]
		public ByteQueue(int capacity)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x5242240", Offset = "0x5240E40", VA = "0x185242240")]
		public void Read(byte[] buf, int offset, int len, int skip)
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x52420C0", Offset = "0x5240CC0", VA = "0x1852420C0")]
		public void AddData(byte[] data, int offset, int len)
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x5242570", Offset = "0x5241170", VA = "0x185242570")]
		public void RemoveData(int i)
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x5242490", Offset = "0x5241090", VA = "0x185242490")]
		public void RemoveData(byte[] buf, int off, int len, int skip)
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x52424E0", Offset = "0x52410E0", VA = "0x1852424E0")]
		public byte[] RemoveData(int len, int skip)
		{
			return null;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x170002CA")]
		public int Available
		{
			[Token(Token = "0x6001426")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		private const int DefaultCapacity = 1024;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x10")]
		private byte[] databuf;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x18")]
		private int skipped;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x1C")]
		private int available;
	}
}
