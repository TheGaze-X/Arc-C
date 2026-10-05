using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005284 RID: 21124
	[Token(Token = "0x2005284")]
	public class RoguelikeEventImage : Image
	{
		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x0601F2B2 RID: 127666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700490D")]
		private Sprite activeSprite
		{
			[Token(Token = "0x601F2B2")]
			[Address(RVA = "0x18EC040", Offset = "0x18EAC40", VA = "0x1818EC040")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x0601F2B3 RID: 127667 RVA: 0x000B1150 File Offset: 0x000AF350
		[Token(Token = "0x1700490E")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x601F2B3")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F2B4 RID: 127668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2B4")]
		[Address(RVA = "0x18EBEA0", Offset = "0x18EAAA0", VA = "0x1818EBEA0")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyCheckIfMatValid()
		{
		}

		// Token: 0x0601F2B5 RID: 127669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2B5")]
		[Address(RVA = "0x18EB760", Offset = "0x18EA360", VA = "0x1818EB760", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601F2B6 RID: 127670 RVA: 0x000B1168 File Offset: 0x000AF368
		[Token(Token = "0x601F2B6")]
		[Address(RVA = "0x18EB120", Offset = "0x18E9D20", VA = "0x1818EB120")]
		private Vector4 GetDrawingDimensions()
		{
			return default(Vector4);
		}

		// Token: 0x0601F2B7 RID: 127671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2B7")]
		[Address(RVA = "0x18EBFF0", Offset = "0x18EABF0", VA = "0x1818EBFF0")]
		public RoguelikeEventImage()
		{
		}

		// Token: 0x04029D47 RID: 171335
		[Token(Token = "0x4029D47")]
		[FieldOffset(Offset = "0x190")]
		[NonSerialized]
		private Sprite m_OverrideSprite;
	}
}
