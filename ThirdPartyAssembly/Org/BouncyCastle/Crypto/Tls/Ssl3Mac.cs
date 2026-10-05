using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	public class Ssl3Mac : IMac
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x5250E60", Offset = "0x524FA60", VA = "0x185250E60")]
		public Ssl3Mac(IDigest digest)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000302")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x600155D")]
			[Address(RVA = "0x5250EF0", Offset = "0x524FAF0", VA = "0x185250EF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x5250A90", Offset = "0x524F690", VA = "0x185250A90", Slot = "12")]
		public virtual void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x5250A40", Offset = "0x524F640", VA = "0x185250A40", Slot = "13")]
		public virtual int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x5250D00", Offset = "0x524F900", VA = "0x185250D00", Slot = "14")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x5250780", Offset = "0x524F380", VA = "0x185250780", Slot = "15")]
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x5250800", Offset = "0x524F400", VA = "0x185250800", Slot = "16")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x5250C00", Offset = "0x524F800", VA = "0x185250C00", Slot = "17")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x52509E0", Offset = "0x524F5E0", VA = "0x1852509E0")]
		private static byte[] GenPad(byte b, int count)
		{
			return null;
		}

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		private const byte IPAD_BYTE = 54;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		private const byte OPAD_BYTE = 92;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly byte[] IPAD;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly byte[] OPAD;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDigest digest;

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x18")]
		private readonly int padLength;

		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x20")]
		private byte[] secret;
	}
}
