using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	public class DigestRandomGenerator : IRandomGenerator
	{
		// Token: 0x06001827 RID: 6183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x52857B0", Offset = "0x52843B0", VA = "0x1852857B0")]
		public DigestRandomGenerator(IDigest digest)
		{
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x5284EF0", Offset = "0x5283AF0", VA = "0x185284EF0", Slot = "4")]
		public void AddSeedMaterial(byte[] inSeed)
		{
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x5285080", Offset = "0x5283C80", VA = "0x185285080", Slot = "5")]
		public void AddSeedMaterial(long rSeed)
		{
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x5285780", Offset = "0x5284380", VA = "0x185285780", Slot = "6")]
		public void NextBytes(byte[] bytes)
		{
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x5285650", Offset = "0x5284250", VA = "0x185285650", Slot = "7")]
		public void NextBytes(byte[] bytes, int start, int len)
		{
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x52851D0", Offset = "0x5283DD0", VA = "0x1852851D0")]
		private void CycleSeed()
		{
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x5285440", Offset = "0x5284040", VA = "0x185285440")]
		private void GenerateState()
		{
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x52852B0", Offset = "0x5283EB0", VA = "0x1852852B0")]
		private void DigestAddCounter(long seedVal)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x52853D0", Offset = "0x5283FD0", VA = "0x1852853D0")]
		private void DigestUpdate(byte[] inSeed)
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x5285360", Offset = "0x5283F60", VA = "0x185285360")]
		private void DigestDoFinal(byte[] result)
		{
		}

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		private const long CYCLE_COUNT = 10L;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x10")]
		private long stateCounter;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x18")]
		private long seedCounter;

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x20")]
		private IDigest digest;

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x28")]
		private byte[] state;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x30")]
		private byte[] seed;
	}
}
