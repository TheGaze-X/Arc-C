using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004170 RID: 16752
	[Token(Token = "0x2004170")]
	public class SandboxV2DungeonCameraRTHolder
	{
		// Token: 0x06019DB6 RID: 105910 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
		[Token(Token = "0x6019DB6")]
		[Address(RVA = "0x12BE530", Offset = "0x12BD130", VA = "0x1812BE530")]
		public static bool IsSystemEnabled()
		{
			return default(bool);
		}

		// Token: 0x06019DB7 RID: 105911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DB7")]
		[Address(RVA = "0x12BE270", Offset = "0x12BCE70", VA = "0x1812BE270")]
		public void BindRTHost(UIBlendRTHost host)
		{
		}

		// Token: 0x06019DB8 RID: 105912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DB8")]
		[Address(RVA = "0x12BE470", Offset = "0x12BD070", VA = "0x1812BE470")]
		public void BindRTImage(UIBlendRTImage image)
		{
		}

		// Token: 0x06019DB9 RID: 105913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DB9")]
		[Address(RVA = "0x12BE580", Offset = "0x12BD180", VA = "0x1812BE580")]
		public SandboxV2DungeonCameraRTHolder()
		{
		}

		// Token: 0x040207CF RID: 133071
		[Token(Token = "0x40207CF")]
		private const int BLUR_TEX_SIZE = 640;

		// Token: 0x040207D0 RID: 133072
		[Token(Token = "0x40207D0")]
		[FieldOffset(Offset = "0x10")]
		private List<UIBlendRTImage> m_pendingImages;

		// Token: 0x040207D1 RID: 133073
		[Token(Token = "0x40207D1")]
		[FieldOffset(Offset = "0x18")]
		private UIBlendRTHost m_host;
	}
}
