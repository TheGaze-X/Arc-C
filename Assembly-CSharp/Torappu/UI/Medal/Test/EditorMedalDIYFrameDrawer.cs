using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Medal.Test
{
	// Token: 0x020049B0 RID: 18864
	[Token(Token = "0x20049B0")]
	[ExecuteInEditMode]
	public class EditorMedalDIYFrameDrawer : EditorMeshCanvasDrawer
	{
		// Token: 0x0601C6D0 RID: 116432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D0")]
		[Address(RVA = "0x15DD8F0", Offset = "0x15DC4F0", VA = "0x1815DD8F0", Slot = "6")]
		public override void PopulateOperations(EditorMeshCanvas.DrawHandler handler)
		{
		}

		// Token: 0x0601C6D1 RID: 116433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D1")]
		[Address(RVA = "0x15DDF60", Offset = "0x15DCB60", VA = "0x1815DDF60")]
		public EditorMedalDIYFrameDrawer()
		{
		}

		// Token: 0x040253C7 RID: 152519
		[Token(Token = "0x40253C7")]
		private const int MAX_LINE_COUNT = 600;

		// Token: 0x040253C8 RID: 152520
		[Token(Token = "0x40253C8")]
		private const int NORMAL_LINE_W = 1;

		// Token: 0x040253C9 RID: 152521
		[Token(Token = "0x40253C9")]
		private const int BOLD_LINE_W = 2;

		// Token: 0x040253CA RID: 152522
		[Token(Token = "0x40253CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _size;

		// Token: 0x040253CB RID: 152523
		[Token(Token = "0x40253CB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color _color;

		// Token: 0x040253CC RID: 152524
		[Token(Token = "0x40253CC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _isBold;

		// Token: 0x040253CD RID: 152525
		[Token(Token = "0x40253CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _boundColor;

		// Token: 0x040253CE RID: 152526
		[Token(Token = "0x40253CE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _meshDrawer;
	}
}
