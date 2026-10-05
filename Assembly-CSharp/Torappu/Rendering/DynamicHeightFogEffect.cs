using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200206F RID: 8303
	[Token(Token = "0x200206F")]
	public class DynamicHeightFogEffect : MonoBehaviour
	{
		// Token: 0x0600CC86 RID: 52358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC86")]
		[Address(RVA = "0x34D02A0", Offset = "0x34CEEA0", VA = "0x1834D02A0")]
		private void Start()
		{
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC87")]
		[Address(RVA = "0x34D0300", Offset = "0x34CEF00", VA = "0x1834D0300")]
		private void Update()
		{
		}

		// Token: 0x0600CC88 RID: 52360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC88")]
		[Address(RVA = "0x34D0260", Offset = "0x34CEE60", VA = "0x1834D0260")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC89")]
		[Address(RVA = "0x34D04E0", Offset = "0x34CF0E0", VA = "0x1834D04E0")]
		public DynamicHeightFogEffect()
		{
		}

		// Token: 0x0400D781 RID: 55169
		[Token(Token = "0x400D781")]
		[FieldOffset(Offset = "0x18")]
		public Transform WaterSurface;

		// Token: 0x0400D782 RID: 55170
		[Token(Token = "0x400D782")]
		[FieldOffset(Offset = "0x20")]
		public float extrude;

		// Token: 0x0400D783 RID: 55171
		[Token(Token = "0x400D783")]
		[FieldOffset(Offset = "0x24")]
		public float range;

		// Token: 0x0400D784 RID: 55172
		[Token(Token = "0x400D784")]
		[FieldOffset(Offset = "0x28")]
		public Color fogColor;

		// Token: 0x0400D785 RID: 55173
		[Token(Token = "0x400D785")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D fogNoise;

		// Token: 0x0400D786 RID: 55174
		[Token(Token = "0x400D786")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 fogNoiseScale;

		// Token: 0x0400D787 RID: 55175
		[Token(Token = "0x400D787")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 20f)]
		public float fogSpeed;

		// Token: 0x0400D788 RID: 55176
		[Token(Token = "0x400D788")]
		[FieldOffset(Offset = "0x4C")]
		private Vector4 m_heightFogParam;

		// Token: 0x0400D789 RID: 55177
		[Token(Token = "0x400D789")]
		[FieldOffset(Offset = "0x5C")]
		private Vector4 m_heightFogNoiseST;

		// Token: 0x0400D78A RID: 55178
		[Token(Token = "0x400D78A")]
		[FieldOffset(Offset = "0x6C")]
		private Vector4 m_colorgradingParam;

		// Token: 0x0400D78B RID: 55179
		[Token(Token = "0x400D78B")]
		[FieldOffset(Offset = "0x7C")]
		private float tempHeight;
	}
}
