using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	public class VmpcKsa3Engine : VmpcEngine
	{
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F7")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001CE3")]
			[Address(RVA = "0x52F0270", Offset = "0x52EEE70", VA = "0x1852F0270", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x52EFF90", Offset = "0x52EEB90", VA = "0x1852EFF90", Slot = "11")]
		protected override void InitKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VmpcKsa3Engine()
		{
		}
	}
}
