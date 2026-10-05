using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200205C RID: 8284
	[Token(Token = "0x200205C")]
	[RequireComponent(typeof(MeshRenderer))]
	public class HighlightTile : HighlightTileBase<HighlightTileProfile>
	{
		// Token: 0x0600CC16 RID: 52246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC16")]
		[Address(RVA = "0x34D61F0", Offset = "0x34D4DF0", VA = "0x1834D61F0")]
		public void Awake()
		{
		}

		// Token: 0x0600CC17 RID: 52247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC17")]
		[Address(RVA = "0x34D63F0", Offset = "0x34D4FF0", VA = "0x1834D63F0")]
		private IEnumerator IncreaseStrength(float finalAnmTime)
		{
			return null;
		}

		// Token: 0x0600CC18 RID: 52248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC18")]
		[Address(RVA = "0x34D6350", Offset = "0x34D4F50", VA = "0x1834D6350")]
		private IEnumerator DecreaseStrength(float finalAnmTime, bool disableAtEnd = true)
		{
			return null;
		}

		// Token: 0x0600CC19 RID: 52249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC19")]
		[Address(RVA = "0x34D6570", Offset = "0x34D5170", VA = "0x1834D6570", Slot = "4")]
		public override void LitOn()
		{
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC1A")]
		[Address(RVA = "0x34D6480", Offset = "0x34D5080", VA = "0x1834D6480", Slot = "5")]
		public override void LitOff()
		{
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC1B")]
		[Address(RVA = "0x34D6730", Offset = "0x34D5330", VA = "0x1834D6730", Slot = "6")]
		public override void SwitchHighlightLevel(int level)
		{
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC1C")]
		[Address(RVA = "0x34D66A0", Offset = "0x34D52A0", VA = "0x1834D66A0")]
		private void SetStrength()
		{
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC1D")]
		[Address(RVA = "0x34D6810", Offset = "0x34D5410", VA = "0x1834D6810")]
		public HighlightTile()
		{
		}

		// Token: 0x0400D69A RID: 54938
		[Token(Token = "0x400D69A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PROP_STRENGTH;

		// Token: 0x0400D69B RID: 54939
		[Token(Token = "0x400D69B")]
		[FieldOffset(Offset = "0x20")]
		private MeshRenderer hlMesh;

		// Token: 0x0400D69C RID: 54940
		[Token(Token = "0x400D69C")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock materialPB;

		// Token: 0x0400D69D RID: 54941
		[Token(Token = "0x400D69D")]
		[FieldOffset(Offset = "0x30")]
		private float crtAnmTime;

		// Token: 0x0400D69E RID: 54942
		[Token(Token = "0x400D69E")]
		[FieldOffset(Offset = "0x34")]
		private float crtStrength;
	}
}
