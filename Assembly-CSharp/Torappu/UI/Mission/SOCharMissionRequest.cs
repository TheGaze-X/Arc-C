using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Mission
{
	// Token: 0x020048B2 RID: 18610
	[Token(Token = "0x20048B2")]
	public class SOCharMissionRequest
	{
		// Token: 0x0601C13B RID: 115003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C13B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SOCharMissionRequest()
		{
		}

		// Token: 0x04024AEE RID: 150254
		[Token(Token = "0x4024AEE")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 startPos;

		// Token: 0x04024AEF RID: 150255
		[Token(Token = "0x4024AEF")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 endPos;

		// Token: 0x04024AF0 RID: 150256
		[Token(Token = "0x4024AF0")]
		[FieldOffset(Offset = "0x28")]
		public MissionViewModel missionViewModel;
	}
}
