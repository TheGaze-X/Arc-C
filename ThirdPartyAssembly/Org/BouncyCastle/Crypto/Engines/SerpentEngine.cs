using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	public sealed class SerpentEngine : SerpentEngineBase
	{
		// Token: 0x06001C89 RID: 7305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x52D6350", Offset = "0x52D4F50", VA = "0x1852D6350", Slot = "15")]
		protected override int[] MakeWorkingKey(byte[] key)
		{
			return null;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x52D4C60", Offset = "0x52D3860", VA = "0x1852D4C60", Slot = "16")]
		protected override void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x52D33F0", Offset = "0x52D1FF0", VA = "0x1852D33F0", Slot = "17")]
		protected override void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0x52D8110", Offset = "0x52D6D10", VA = "0x1852D8110")]
		public SerpentEngine()
		{
		}
	}
}
