using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002057 RID: 8279
	[Token(Token = "0x2002057")]
	[RequireComponent(typeof(MeshRenderer))]
	public class HighlightLevelTile : HighlightTileBase<HighlightLevelTileProfile>
	{
		// Token: 0x0600CBFC RID: 52220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBFC")]
		[Address(RVA = "0x34D5600", Offset = "0x34D4200", VA = "0x1834D5600")]
		public void Awake()
		{
		}

		// Token: 0x0600CBFD RID: 52221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBFD")]
		[Address(RVA = "0x34D58B0", Offset = "0x34D44B0", VA = "0x1834D58B0", Slot = "6")]
		public override void SwitchHighlightLevel(int level)
		{
		}

		// Token: 0x0600CBFE RID: 52222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBFE")]
		[Address(RVA = "0x34D5830", Offset = "0x34D4430", VA = "0x1834D5830", Slot = "4")]
		public override void LitOn()
		{
		}

		// Token: 0x0600CBFF RID: 52223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBFF")]
		[Address(RVA = "0x34D57F0", Offset = "0x34D43F0", VA = "0x1834D57F0", Slot = "5")]
		public override void LitOff()
		{
		}

		// Token: 0x0600CC00 RID: 52224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC00")]
		[Address(RVA = "0x34D57A0", Offset = "0x34D43A0", VA = "0x1834D57A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CC01 RID: 52225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC01")]
		[Address(RVA = "0x34D57A0", Offset = "0x34D43A0", VA = "0x1834D57A0")]
		private void FinishTweenIfNot()
		{
		}

		// Token: 0x0600CC02 RID: 52226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC02")]
		[Address(RVA = "0x34D5BE0", Offset = "0x34D47E0", VA = "0x1834D5BE0")]
		public HighlightLevelTile()
		{
		}

		// Token: 0x0400D682 RID: 54914
		[Token(Token = "0x400D682")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PROP_STRENGTH;

		// Token: 0x0400D683 RID: 54915
		[Token(Token = "0x400D683")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string TINT_COLOR;

		// Token: 0x0400D684 RID: 54916
		[Token(Token = "0x400D684")]
		[FieldOffset(Offset = "0x20")]
		private MeshRenderer m_renderer;

		// Token: 0x0400D685 RID: 54917
		[Token(Token = "0x400D685")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock m_materialPB;

		// Token: 0x0400D686 RID: 54918
		[Token(Token = "0x400D686")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_colorTween;

		// Token: 0x0400D687 RID: 54919
		[Token(Token = "0x400D687")]
		[FieldOffset(Offset = "0x38")]
		private Color m_color;

		// Token: 0x0400D688 RID: 54920
		[Token(Token = "0x400D688")]
		[FieldOffset(Offset = "0x48")]
		private float m_strength;
	}
}
