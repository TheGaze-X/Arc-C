using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x5301860", Offset = "0x5300460", VA = "0x185301860")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x5302C20", Offset = "0x5301820", VA = "0x185302C20")]
		public Vortex()
		{
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;
	}
}
