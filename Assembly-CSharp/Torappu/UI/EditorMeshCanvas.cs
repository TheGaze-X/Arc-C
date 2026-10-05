using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200398C RID: 14732
	[Token(Token = "0x200398C")]
	[ExecuteInEditMode]
	public class EditorMeshCanvas : Graphic
	{
		// Token: 0x060174C0 RID: 95424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174C0")]
		[Address(RVA = "0x513230", Offset = "0x511E30", VA = "0x180513230", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x060174C1 RID: 95425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174C1")]
		[Address(RVA = "0xF9BD80", Offset = "0xF9A980", VA = "0x180F9BD80")]
		private static void _PopulateLine(VertexHelper vh, EditorMeshCanvas.Line line)
		{
		}

		// Token: 0x060174C2 RID: 95426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174C2")]
		[Address(RVA = "0xF9C320", Offset = "0xF9AF20", VA = "0x180F9C320")]
		public EditorMeshCanvas()
		{
		}

		// Token: 0x0401C1F1 RID: 115185
		[Token(Token = "0x401C1F1")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<EditorMeshCanvasDrawer> _drawers;

		// Token: 0x0401C1F2 RID: 115186
		[Token(Token = "0x401C1F2")]
		[FieldOffset(Offset = "0xB8")]
		private EditorMeshCanvas.DrawHandler m_handler;

		// Token: 0x0401C1F3 RID: 115187
		[Token(Token = "0x401C1F3")]
		[FieldOffset(Offset = "0xC0")]
		private List<EditorMeshCanvas.Line> m_lines;

		// Token: 0x0401C1F4 RID: 115188
		[Token(Token = "0x401C1F4")]
		[FieldOffset(Offset = "0xC8")]
		private List<IMeshCanvasDrawer> m_drawers;

		// Token: 0x0200398D RID: 14733
		[Token(Token = "0x200398D")]
		public class DrawHandler
		{
			// Token: 0x060174C3 RID: 95427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60174C3")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public DrawHandler(EditorMeshCanvas canvas)
			{
			}

			// Token: 0x060174C4 RID: 95428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60174C4")]
			[Address(RVA = "0xF9BBE0", Offset = "0xF9A7E0", VA = "0x180F9BBE0")]
			public void Draw(EditorMeshCanvas.Line line)
			{
			}

			// Token: 0x060174C5 RID: 95429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60174C5")]
			[Address(RVA = "0xF9BA60", Offset = "0xF9A660", VA = "0x180F9BA60")]
			public void Draw(EditorMeshCanvas.Point point)
			{
			}

			// Token: 0x060174C6 RID: 95430 RVA: 0x00095D90 File Offset: 0x00093F90
			[Token(Token = "0x60174C6")]
			[Address(RVA = "0xF9BCD0", Offset = "0xF9A8D0", VA = "0x180F9BCD0")]
			private static EditorMeshCanvas.Line _ToLine(EditorMeshCanvas.Point point)
			{
				return default(EditorMeshCanvas.Line);
			}

			// Token: 0x0401C1F5 RID: 115189
			[Token(Token = "0x401C1F5")]
			[FieldOffset(Offset = "0x10")]
			private EditorMeshCanvas m_canvas;
		}

		// Token: 0x0200398E RID: 14734
		[Token(Token = "0x200398E")]
		public struct Line
		{
			// Token: 0x0401C1F6 RID: 115190
			[Token(Token = "0x401C1F6")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 from;

			// Token: 0x0401C1F7 RID: 115191
			[Token(Token = "0x401C1F7")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 to;

			// Token: 0x0401C1F8 RID: 115192
			[Token(Token = "0x401C1F8")]
			[FieldOffset(Offset = "0x10")]
			public float weight;

			// Token: 0x0401C1F9 RID: 115193
			[Token(Token = "0x401C1F9")]
			[FieldOffset(Offset = "0x14")]
			public Color color;
		}

		// Token: 0x0200398F RID: 14735
		[Token(Token = "0x200398F")]
		public struct Point
		{
			// Token: 0x0401C1FA RID: 115194
			[Token(Token = "0x401C1FA")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x0401C1FB RID: 115195
			[Token(Token = "0x401C1FB")]
			[FieldOffset(Offset = "0x8")]
			public Color color;

			// Token: 0x0401C1FC RID: 115196
			[Token(Token = "0x401C1FC")]
			[FieldOffset(Offset = "0x18")]
			public float size;
		}
	}
}
