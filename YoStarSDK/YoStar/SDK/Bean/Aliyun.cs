using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	internal class Aliyun
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Aliyun()
		{
		}

		// Token: 0x0200029D RID: 669
		[Token(Token = "0x200029D")]
		[Serializable]
		public class AUTO
		{
			// Token: 0x06000FAF RID: 4015 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AUTO()
			{
			}

			// Token: 0x04000CE8 RID: 3304
			[Token(Token = "0x4000CE8")]
			[FieldOffset(Offset = "0x10")]
			public List<string> HTTP;

			// Token: 0x04000CE9 RID: 3305
			[Token(Token = "0x4000CE9")]
			[FieldOffset(Offset = "0x18")]
			public List<string> PING;

			// Token: 0x04000CEA RID: 3306
			[Token(Token = "0x4000CEA")]
			[FieldOffset(Offset = "0x20")]
			public List<string> TCP;

			// Token: 0x04000CEB RID: 3307
			[Token(Token = "0x4000CEB")]
			[FieldOffset(Offset = "0x28")]
			public List<string> MTR;

			// Token: 0x04000CEC RID: 3308
			[Token(Token = "0x4000CEC")]
			[FieldOffset(Offset = "0x30")]
			public List<string> DNS;
		}

		// Token: 0x0200029E RID: 670
		[Token(Token = "0x200029E")]
		[Serializable]
		public class DETECTION_ADDRESS
		{
			// Token: 0x06000FB0 RID: 4016 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DETECTION_ADDRESS()
			{
			}

			// Token: 0x04000CED RID: 3309
			[Token(Token = "0x4000CED")]
			[FieldOffset(Offset = "0x10")]
			public Aliyun.AUTO AUTO;

			// Token: 0x04000CEE RID: 3310
			[Token(Token = "0x4000CEE")]
			[FieldOffset(Offset = "0x18")]
			public bool ENABLE;

			// Token: 0x04000CEF RID: 3311
			[Token(Token = "0x4000CEF")]
			[FieldOffset(Offset = "0x20")]
			public string INTERNET;

			// Token: 0x04000CF0 RID: 3312
			[Token(Token = "0x4000CF0")]
			[FieldOffset(Offset = "0x28")]
			public bool ENABLE_MANUAL;

			// Token: 0x04000CF1 RID: 3313
			[Token(Token = "0x4000CF1")]
			[FieldOffset(Offset = "0x30")]
			public string NETWORK_ENDPORINT;

			// Token: 0x04000CF2 RID: 3314
			[Token(Token = "0x4000CF2")]
			[FieldOffset(Offset = "0x38")]
			public string NETWORK_PROJECT;

			// Token: 0x04000CF3 RID: 3315
			[Token(Token = "0x4000CF3")]
			[FieldOffset(Offset = "0x40")]
			public string NETWORK_SECRET_KEY;
		}
	}
}
