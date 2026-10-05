using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	[Serializable]
	public class ECamera
	{
		// Token: 0x06000A7F RID: 2687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1182440", Offset = "0x1181040", VA = "0x181182440")]
		public ECamera(Camera cam, bool gui)
		{
		}

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x10")]
		public Camera camera;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x18")]
		public bool guiCamera;
	}
}
