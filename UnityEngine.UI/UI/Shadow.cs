using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	[AddComponentMenu("UI/Effects/Shadow", 80)]
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x5B8A740", Offset = "0x5B89340", VA = "0x185B8A740")]
		protected Shadow()
		{
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00004170 File Offset: 0x00002370
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016D")]
		public Color effectColor
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x5B93620", Offset = "0x5B92220", VA = "0x185B93620")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00004188 File Offset: 0x00002388
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016E")]
		public Vector2 effectDistance
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x4FD490", Offset = "0x4FC090", VA = "0x1804FD490")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x5B936D0", Offset = "0x5B922D0", VA = "0x185B936D0")]
			set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x000041A0 File Offset: 0x000023A0
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016F")]
		public bool useGraphicAlpha
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x5B93820", Offset = "0x5B92420", VA = "0x185B93820")]
			set
			{
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x5B93130", Offset = "0x5B91D30", VA = "0x185B93130")]
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x5B934C0", Offset = "0x5B920C0", VA = "0x185B934C0")]
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x5B934D0", Offset = "0x5B920D0", VA = "0x185B934D0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_EffectColor;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_EffectDistance;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_UseGraphicAlpha;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		private const float kMaxEffectDistance = 600f;
	}
}
