using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005282 RID: 21122
	[Token(Token = "0x2005282")]
	public class RoguelikeConnector : Image, IHotfixable
	{
		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x0601F29D RID: 127645 RVA: 0x000B10D8 File Offset: 0x000AF2D8
		// (set) Token: 0x0601F29E RID: 127646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004906")]
		public bool useClipColor
		{
			[Token(Token = "0x601F29D")]
			[Address(RVA = "0x18E6BF0", Offset = "0x18E57F0", VA = "0x1818E6BF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F29E")]
			[Address(RVA = "0x18E6CD0", Offset = "0x18E58D0", VA = "0x1818E6CD0")]
			set
			{
			}
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x0601F29F RID: 127647 RVA: 0x000B10F0 File Offset: 0x000AF2F0
		// (set) Token: 0x0601F2A0 RID: 127648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004907")]
		public Color clipColor
		{
			[Token(Token = "0x601F29F")]
			[Address(RVA = "0x18E6B70", Offset = "0x18E5770", VA = "0x1818E6B70")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x601F2A0")]
			[Address(RVA = "0x18E6C50", Offset = "0x18E5850", VA = "0x1818E6C50")]
			set
			{
			}
		}

		// Token: 0x0601F2A1 RID: 127649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2A1")]
		[Address(RVA = "0x18E6250", Offset = "0x18E4E50", VA = "0x1818E6250", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601F2A2 RID: 127650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2A2")]
		[Address(RVA = "0x18E6AE0", Offset = "0x18E56E0", VA = "0x1818E6AE0")]
		public RoguelikeConnector()
		{
		}

		// Token: 0x0601F2A3 RID: 127651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2A3")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x04029D1D RID: 171293
		[Token(Token = "0x4029D1D")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private bool _useClipColor;

		// Token: 0x04029D1E RID: 171294
		[Token(Token = "0x4029D1E")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _clipRatio;

		// Token: 0x04029D1F RID: 171295
		[Token(Token = "0x4029D1F")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Color _clipColor;

		// Token: 0x04029D20 RID: 171296
		[Token(Token = "0x4029D20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useClipColor;

		// Token: 0x04029D21 RID: 171297
		[Token(Token = "0x4029D21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_useClipColor;

		// Token: 0x04029D22 RID: 171298
		[Token(Token = "0x4029D22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_clipColor;

		// Token: 0x04029D23 RID: 171299
		[Token(Token = "0x4029D23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_clipColor;

		// Token: 0x04029D24 RID: 171300
		[Token(Token = "0x4029D24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x04029D25 RID: 171301
		[Token(Token = "0x4029D25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
