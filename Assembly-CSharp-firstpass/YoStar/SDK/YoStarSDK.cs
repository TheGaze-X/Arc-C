using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public sealed class YoStarSDK
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private YoStarSDK()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		public static IYoSDK Instance
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4F6BC0", Offset = "0x4F57C0", VA = "0x1804F6BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static IYoSDK m_instance;
	}
}
