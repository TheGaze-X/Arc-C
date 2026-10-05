using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001E65 RID: 7781
	[Token(Token = "0x2001E65")]
	public class MaterialTweenParam
	{
		// Token: 0x0600C0FD RID: 49405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MaterialTweenParam()
		{
		}

		// Token: 0x0400C277 RID: 49783
		[Token(Token = "0x400C277")]
		[FieldOffset(Offset = "0x10")]
		public string propertyName;

		// Token: 0x0400C278 RID: 49784
		[Token(Token = "0x400C278")]
		[FieldOffset(Offset = "0x18")]
		public MaterialTweenValueType type;

		// Token: 0x0400C279 RID: 49785
		[Token(Token = "0x400C279")]
		[FieldOffset(Offset = "0x1C")]
		public float toValue;

		// Token: 0x0400C27A RID: 49786
		[Token(Token = "0x400C27A")]
		[FieldOffset(Offset = "0x20")]
		public Color toColor;

		// Token: 0x0400C27B RID: 49787
		[Token(Token = "0x400C27B")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 toVec;

		// Token: 0x0400C27C RID: 49788
		[Token(Token = "0x400C27C")]
		[FieldOffset(Offset = "0x38")]
		public float duration;

		// Token: 0x0400C27D RID: 49789
		[Token(Token = "0x400C27D")]
		[FieldOffset(Offset = "0x3C")]
		public bool ignoreTimeScale;

		// Token: 0x0400C27E RID: 49790
		[Token(Token = "0x400C27E")]
		[FieldOffset(Offset = "0x40")]
		public Ease ease;
	}
}
