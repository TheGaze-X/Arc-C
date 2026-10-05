using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200460F RID: 17935
	[Token(Token = "0x200460F")]
	public class RL02OuterBuffCurve : Image, IHotfixable
	{
		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x0601B425 RID: 111653 RVA: 0x000A4C70 File Offset: 0x000A2E70
		[Token(Token = "0x170040FA")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x601B425")]
			[Address(RVA = "0x1464B50", Offset = "0x1463750", VA = "0x181464B50", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B426")]
		[Address(RVA = "0x1463AC0", Offset = "0x14626C0", VA = "0x181463AC0")]
		public void SetPosition(PolarPoint startPos, PolarPoint endPos)
		{
		}

		// Token: 0x0601B427 RID: 111655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B427")]
		[Address(RVA = "0x1463A00", Offset = "0x1462600", VA = "0x181463A00", Slot = "62")]
		public override void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x0601B428 RID: 111656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B428")]
		[Address(RVA = "0x1463830", Offset = "0x1462430", VA = "0x181463830", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601B429 RID: 111657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B429")]
		[Address(RVA = "0x1463BE0", Offset = "0x14627E0", VA = "0x181463BE0")]
		private void _DrawArc(VertexHelper vh, PolarPoint startPos, PolarPoint endPos)
		{
		}

		// Token: 0x0601B42A RID: 111658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B42A")]
		[Address(RVA = "0x1464260", Offset = "0x1462E60", VA = "0x181464260")]
		private void _DrawLine(VertexHelper vh, PolarPoint startPos, PolarPoint endPos)
		{
		}

		// Token: 0x0601B42B RID: 111659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B42B")]
		[Address(RVA = "0x1464AA0", Offset = "0x14636A0", VA = "0x181464AA0")]
		public RL02OuterBuffCurve()
		{
		}

		// Token: 0x0601B42C RID: 111660 RVA: 0x000A4C88 File Offset: 0x000A2E88
		[Token(Token = "0x601B42C")]
		[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
		private bool <>xLuaBaseProxy_get_packIntoRuntimeAtlas()
		{
			return default(bool);
		}

		// Token: 0x0601B42D RID: 111661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B42D")]
		[Address(RVA = "0x12790C0", Offset = "0x1277CC0", VA = "0x1812790C0")]
		private void <>xLuaBaseProxy_SetClipRect(Rect P0, bool P1)
		{
		}

		// Token: 0x0601B42E RID: 111662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B42E")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x040232BE RID: 144062
		[Token(Token = "0x40232BE")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private PolarPoint _startPos;

		// Token: 0x040232BF RID: 144063
		[Token(Token = "0x40232BF")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private PolarPoint _endPos;

		// Token: 0x040232C0 RID: 144064
		[Token(Token = "0x40232C0")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private int _width;

		// Token: 0x040232C1 RID: 144065
		[Token(Token = "0x40232C1")]
		[FieldOffset(Offset = "0x1A8")]
		private UIVertex[] m_vertexArray;

		// Token: 0x040232C2 RID: 144066
		[Token(Token = "0x40232C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packIntoRuntimeAtlas;

		// Token: 0x040232C3 RID: 144067
		[Token(Token = "0x40232C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetPosition;

		// Token: 0x040232C4 RID: 144068
		[Token(Token = "0x40232C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetClipRect;

		// Token: 0x040232C5 RID: 144069
		[Token(Token = "0x40232C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x040232C6 RID: 144070
		[Token(Token = "0x40232C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DrawArc;

		// Token: 0x040232C7 RID: 144071
		[Token(Token = "0x40232C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DrawLine;

		// Token: 0x040232C8 RID: 144072
		[Token(Token = "0x40232C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
