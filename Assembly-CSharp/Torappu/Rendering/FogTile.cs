using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002052 RID: 8274
	[Token(Token = "0x2002052")]
	public class FogTile : HighlightTileBase<HighlightTileProfile>
	{
		// Token: 0x0600CBED RID: 52205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBED")]
		[Address(RVA = "0x34D0B80", Offset = "0x34CF780", VA = "0x1834D0B80", Slot = "6")]
		public override void SwitchHighlightLevel(int level)
		{
		}

		// Token: 0x0600CBEE RID: 52206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBEE")]
		[Address(RVA = "0x34D0A20", Offset = "0x34CF620", VA = "0x1834D0A20")]
		private void Awake()
		{
		}

		// Token: 0x0600CBEF RID: 52207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBEF")]
		[Address(RVA = "0x34D0A30", Offset = "0x34CF630", VA = "0x1834D0A30")]
		private void GetComponentIfNot()
		{
		}

		// Token: 0x0600CBF0 RID: 52208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBF0")]
		[Address(RVA = "0x34D0B30", Offset = "0x34CF730", VA = "0x1834D0B30")]
		private void _FinishTweenIfNot()
		{
		}

		// Token: 0x0600CBF1 RID: 52209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBF1")]
		[Address(RVA = "0x34D0B30", Offset = "0x34CF730", VA = "0x1834D0B30")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CBF2 RID: 52210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBF2")]
		[Address(RVA = "0x34D0E40", Offset = "0x34CFA40", VA = "0x1834D0E40")]
		public FogTile()
		{
		}

		// Token: 0x0400D671 RID: 54897
		[Token(Token = "0x400D671")]
		[FieldOffset(Offset = "0x20")]
		private MaterialPropertyBlock m_materialPB;

		// Token: 0x0400D672 RID: 54898
		[Token(Token = "0x400D672")]
		[FieldOffset(Offset = "0x28")]
		private Renderer m_renderer;

		// Token: 0x0400D673 RID: 54899
		[Token(Token = "0x400D673")]
		[FieldOffset(Offset = "0x30")]
		private int m_propID;

		// Token: 0x0400D674 RID: 54900
		[Token(Token = "0x400D674")]
		[FieldOffset(Offset = "0x34")]
		private Color m_targetColor;

		// Token: 0x0400D675 RID: 54901
		[Token(Token = "0x400D675")]
		[FieldOffset(Offset = "0x44")]
		private Color m_color;

		// Token: 0x0400D676 RID: 54902
		[Token(Token = "0x400D676")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_colorTween;
	}
}
