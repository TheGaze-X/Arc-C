using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004755 RID: 18261
	[Token(Token = "0x2004755")]
	[Serializable]
	public class RecruitImage
	{
		// Token: 0x0601BA6B RID: 113259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA6B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecruitImage()
		{
		}

		// Token: 0x04023E3E RID: 147006
		[Token(Token = "0x4023E3E")]
		[FieldOffset(Offset = "0x10")]
		public RectTransform image;

		// Token: 0x04023E3F RID: 147007
		[Token(Token = "0x4023E3F")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Vector2 pagePos;

		// Token: 0x04023E40 RID: 147008
		[Token(Token = "0x4023E40")]
		[FieldOffset(Offset = "0x20")]
		public float deltaX;
	}
}
