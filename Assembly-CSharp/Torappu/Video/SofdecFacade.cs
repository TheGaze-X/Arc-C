using System;
using Il2CppDummyDll;

namespace Torappu.Video
{
	// Token: 0x020016C9 RID: 5833
	[Token(Token = "0x20016C9")]
	public static class SofdecFacade
	{
		// Token: 0x060093E2 RID: 37858 RVA: 0x00039B58 File Offset: 0x00037D58
		[Token(Token = "0x60093E2")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
		public static VideoManager.VideoType GetVideoType()
		{
			return VideoManager.VideoType.AVPRO;
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093E3")]
		[Address(RVA = "0x2B3B8A0", Offset = "0x2B3A4A0", VA = "0x182B3B8A0")]
		public static string DealWithVideoRawExt(string path)
		{
			return null;
		}
	}
}
