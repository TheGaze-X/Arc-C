using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F0B RID: 7947
	[Token(Token = "0x2001F0B")]
	[CreateAssetMenu(fileName = "ChaosMaterialSettings", menuName = "Torappu/AVG/ChaosMaterialSettings")]
	public class AVGChaosMaterialSettings : ScriptableObject
	{
		// Token: 0x0600C533 RID: 50483 RVA: 0x00048480 File Offset: 0x00046680
		[Token(Token = "0x600C533")]
		[Address(RVA = "0x341E2D0", Offset = "0x341CED0", VA = "0x18341E2D0")]
		public AVGChaosMatParam Convert2Param()
		{
			return default(AVGChaosMatParam);
		}

		// Token: 0x0600C534 RID: 50484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C534")]
		[Address(RVA = "0x341E320", Offset = "0x341CF20", VA = "0x18341E320")]
		public AVGChaosMaterialSettings()
		{
		}

		// Token: 0x0400C9CA RID: 51658
		[Token(Token = "0x400C9CA")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400C9CB RID: 51659
		[Token(Token = "0x400C9CB")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 2f)]
		public float blurRange;

		// Token: 0x0400C9CC RID: 51660
		[Token(Token = "0x400C9CC")]
		[FieldOffset(Offset = "0x20")]
		public Color chaosColor1;

		// Token: 0x0400C9CD RID: 51661
		[Token(Token = "0x400C9CD")]
		[FieldOffset(Offset = "0x30")]
		public Color chaosColor2;

		// Token: 0x0400C9CE RID: 51662
		[Token(Token = "0x400C9CE")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float chaosRange;

		// Token: 0x0400C9CF RID: 51663
		[Token(Token = "0x400C9CF")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 maskCenter;

		// Token: 0x0400C9D0 RID: 51664
		[Token(Token = "0x400C9D0")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float maskRadius;

		// Token: 0x0400C9D1 RID: 51665
		[Token(Token = "0x400C9D1")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float maskSmoothness;
	}
}
