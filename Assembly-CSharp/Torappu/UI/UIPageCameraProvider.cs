using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003622 RID: 13858
	[Token(Token = "0x2003622")]
	public class UIPageCameraProvider
	{
		// Token: 0x06016153 RID: 90451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016153")]
		[Address(RVA = "0xEA4510", Offset = "0xEA3110", VA = "0x180EA4510")]
		public UIPageCameraProvider(UIPageCameraProvider.CameraInfo[] virtualCams)
		{
		}

		// Token: 0x06016154 RID: 90452 RVA: 0x0008F5E0 File Offset: 0x0008D7E0
		[Token(Token = "0x6016154")]
		[Address(RVA = "0xEA4450", Offset = "0xEA3050", VA = "0x180EA4450")]
		public CameraWrapper GetCameraWrapper(UIPageVirtualCamType camType)
		{
			return default(CameraWrapper);
		}

		// Token: 0x0401A86E RID: 108654
		[Token(Token = "0x401A86E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Camera> m_cameras;

		// Token: 0x02003623 RID: 13859
		[Token(Token = "0x2003623")]
		public struct CameraInfo
		{
			// Token: 0x0401A86F RID: 108655
			[Token(Token = "0x401A86F")]
			[FieldOffset(Offset = "0x0")]
			public UIPageVirtualCamType camType;

			// Token: 0x0401A870 RID: 108656
			[Token(Token = "0x401A870")]
			[FieldOffset(Offset = "0x8")]
			public Camera camera;
		}
	}
}
