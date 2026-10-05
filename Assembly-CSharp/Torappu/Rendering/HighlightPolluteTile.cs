using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200205A RID: 8282
	[Token(Token = "0x200205A")]
	[RequireComponent(typeof(MeshRenderer))]
	public class HighlightPolluteTile : HighlightTileBase<HighlightPolluteTileProfile>
	{
		// Token: 0x0600CC09 RID: 52233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC09")]
		[Address(RVA = "0x34D5C40", Offset = "0x34D4840", VA = "0x1834D5C40")]
		public void Awake()
		{
		}

		// Token: 0x0600CC0A RID: 52234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC0A")]
		[Address(RVA = "0x34D5D50", Offset = "0x34D4950", VA = "0x1834D5D50", Slot = "7")]
		public override void SetHighlightStrength(float strength)
		{
		}

		// Token: 0x0600CC0B RID: 52235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC0B")]
		[Address(RVA = "0x34D60B0", Offset = "0x34D4CB0", VA = "0x1834D60B0")]
		private void _SetStrength()
		{
		}

		// Token: 0x0600CC0C RID: 52236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC0C")]
		[Address(RVA = "0x34D5F30", Offset = "0x34D4B30", VA = "0x1834D5F30")]
		private void _DoIncreaseStrength(float endStrength)
		{
		}

		// Token: 0x0600CC0D RID: 52237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC0D")]
		[Address(RVA = "0x34D6020", Offset = "0x34D4C20", VA = "0x1834D6020")]
		private IEnumerator _IncreaseStrength(float endStrength)
		{
			return null;
		}

		// Token: 0x0600CC0E RID: 52238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC0E")]
		[Address(RVA = "0x34D61B0", Offset = "0x34D4DB0", VA = "0x1834D61B0")]
		public HighlightPolluteTile()
		{
		}

		// Token: 0x0400D68F RID: 54927
		[Token(Token = "0x400D68F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PROP_STRENGTH;

		// Token: 0x0400D690 RID: 54928
		[Token(Token = "0x400D690")]
		[FieldOffset(Offset = "0x20")]
		private MeshRenderer hlMesh;

		// Token: 0x0400D691 RID: 54929
		[Token(Token = "0x400D691")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock materialPB;

		// Token: 0x0400D692 RID: 54930
		[Token(Token = "0x400D692")]
		[FieldOffset(Offset = "0x30")]
		private float m_crtAnimRatio;

		// Token: 0x0400D693 RID: 54931
		[Token(Token = "0x400D693")]
		[FieldOffset(Offset = "0x34")]
		private float m_crtStrength;
	}
}
