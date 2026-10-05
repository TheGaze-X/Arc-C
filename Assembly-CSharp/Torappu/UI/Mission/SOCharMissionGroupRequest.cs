using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Mission
{
	// Token: 0x020048B3 RID: 18611
	[Token(Token = "0x20048B3")]
	public class SOCharMissionGroupRequest
	{
		// Token: 0x0601C13C RID: 115004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C13C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SOCharMissionGroupRequest()
		{
		}

		// Token: 0x04024AF1 RID: 150257
		[Token(Token = "0x4024AF1")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 startPos;

		// Token: 0x04024AF2 RID: 150258
		[Token(Token = "0x4024AF2")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 endPos;

		// Token: 0x04024AF3 RID: 150259
		[Token(Token = "0x4024AF3")]
		[FieldOffset(Offset = "0x28")]
		public List<MissionViewModel> missionViewModels;
	}
}
