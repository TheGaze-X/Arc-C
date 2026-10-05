using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000373 RID: 883
	[Token(Token = "0x2000373")]
	public abstract class GeneralDigest : IDigest, IMemoable
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x52DB060", Offset = "0x52D9C60", VA = "0x1852DB060")]
		internal GeneralDigest()
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x52DB0C0", Offset = "0x52D9CC0", VA = "0x1852DB0C0")]
		internal GeneralDigest(GeneralDigest t)
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x52DAE20", Offset = "0x52D9A20", VA = "0x1852DAE20")]
		protected void CopyIn(GeneralDigest t)
		{
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x52DAFD0", Offset = "0x52D9BD0", VA = "0x1852DAFD0", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x52DAC90", Offset = "0x52D9890", VA = "0x1852DAC90", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x52DAE80", Offset = "0x52D9A80", VA = "0x1852DAE80")]
		public void Finish()
		{
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x52DAFA0", Offset = "0x52D9BA0", VA = "0x1852DAFA0", Slot = "13")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x3D28710", Offset = "0x3D27310", VA = "0x183D28710", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001D8C RID: 7564
		[Token(Token = "0x6001D8C")]
		internal abstract void ProcessWord(byte[] input, int inOff);

		// Token: 0x06001D8D RID: 7565
		[Token(Token = "0x6001D8D")]
		internal abstract void ProcessLength(long bitLength);

		// Token: 0x06001D8E RID: 7566
		[Token(Token = "0x6001D8E")]
		internal abstract void ProcessBlock();

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001D8F RID: 7567
		[Token(Token = "0x170003FF")]
		public abstract string AlgorithmName { [Token(Token = "0x6001D8F")] get; }

		// Token: 0x06001D90 RID: 7568
		[Token(Token = "0x6001D90")]
		public abstract int GetDigestSize();

		// Token: 0x06001D91 RID: 7569
		[Token(Token = "0x6001D91")]
		public abstract int DoFinal(byte[] output, int outOff);

		// Token: 0x06001D92 RID: 7570
		[Token(Token = "0x6001D92")]
		public abstract IMemoable Copy();

		// Token: 0x06001D93 RID: 7571
		[Token(Token = "0x6001D93")]
		public abstract void Reset(IMemoable t);

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		private const int BYTE_LENGTH = 64;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x10")]
		private byte[] xBuf;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x18")]
		private int xBufOff;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x20")]
		private long byteCount;
	}
}
