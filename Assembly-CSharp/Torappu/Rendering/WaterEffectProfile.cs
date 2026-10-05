using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002073 RID: 8307
	[Token(Token = "0x2002073")]
	[CreateAssetMenu(menuName = "HGEffect/new Water effect profile")]
	[Serializable]
	public class WaterEffectProfile : ScriptableObject
	{
		// Token: 0x0600CCB9 RID: 52409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB9")]
		[Address(RVA = "0x34EAF40", Offset = "0x34E9B40", VA = "0x1834EAF40")]
		public WaterEffectProfile()
		{
		}

		// Token: 0x0400D7CB RID: 55243
		[Token(Token = "0x400D7CB")]
		[FieldOffset(Offset = "0x18")]
		public bool depthFullRes;

		// Token: 0x0400D7CC RID: 55244
		[Token(Token = "0x400D7CC")]
		[FieldOffset(Offset = "0x19")]
		public bool distortEnable;

		// Token: 0x0400D7CD RID: 55245
		[Token(Token = "0x400D7CD")]
		[FieldOffset(Offset = "0x1A")]
		public bool reflectionEnable;

		// Token: 0x0400D7CE RID: 55246
		[Token(Token = "0x400D7CE")]
		[FieldOffset(Offset = "0x1C")]
		public float reflectionClipPlaneOffset;

		// Token: 0x0400D7CF RID: 55247
		[Token(Token = "0x400D7CF")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reflectionEulerOffset;

		// Token: 0x0400D7D0 RID: 55248
		[Token(Token = "0x400D7D0")]
		[FieldOffset(Offset = "0x28")]
		public Shader reflectionReplaceShader;

		// Token: 0x0400D7D1 RID: 55249
		[Token(Token = "0x400D7D1")]
		[FieldOffset(Offset = "0x30")]
		public bool dynamicEnable;

		// Token: 0x0400D7D2 RID: 55250
		[Token(Token = "0x400D7D2")]
		[FieldOffset(Offset = "0x31")]
		public bool copyDepth;

		// Token: 0x0400D7D3 RID: 55251
		[Token(Token = "0x400D7D3")]
		[FieldOffset(Offset = "0x32")]
		public bool spineIntersect;

		// Token: 0x0400D7D4 RID: 55252
		[Token(Token = "0x400D7D4")]
		[FieldOffset(Offset = "0x34")]
		public Color spineTintColor;

		// Token: 0x0400D7D5 RID: 55253
		[Token(Token = "0x400D7D5")]
		[FieldOffset(Offset = "0x48")]
		public Shader spineReplaceShader;

		// Token: 0x0400D7D6 RID: 55254
		[Token(Token = "0x400D7D6")]
		[FieldOffset(Offset = "0x50")]
		public float spineHeightTeak;

		// Token: 0x0400D7D7 RID: 55255
		[Token(Token = "0x400D7D7")]
		[FieldOffset(Offset = "0x54")]
		public float spineHeightOffset;
	}
}
