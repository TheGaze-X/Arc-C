using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	public class VmpcMac : IMac
	{
		// Token: 0x06001ACD RID: 6861 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x52AE160", Offset = "0x52ACD60", VA = "0x1852AE160", Slot = "11")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BF")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001ACE")]
			[Address(RVA = "0x52AEC30", Offset = "0x52AD830", VA = "0x1852AEC30", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x3D286E0", Offset = "0x3D272E0", VA = "0x183D286E0", Slot = "13")]
		public virtual int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x52AE5A0", Offset = "0x52AD1A0", VA = "0x1852AE5A0", Slot = "14")]
		public virtual void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x52AEC60", Offset = "0x52AD860", VA = "0x1852AEC60")]
		private void initKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x52AE940", Offset = "0x52AD540", VA = "0x1852AE940", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x52AE9E0", Offset = "0x52AD5E0", VA = "0x1852AE9E0", Slot = "16")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x52AE060", Offset = "0x52ACC60", VA = "0x1852AE060", Slot = "17")]
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VmpcMac()
		{
		}

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x10")]
		private byte g;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x11")]
		private byte n;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x18")]
		private byte[] P;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x20")]
		private byte s;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x28")]
		private byte[] T;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x30")]
		private byte[] workingIV;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x38")]
		private byte[] workingKey;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x40")]
		private byte x1;

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x41")]
		private byte x2;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x42")]
		private byte x3;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x43")]
		private byte x4;
	}
}
