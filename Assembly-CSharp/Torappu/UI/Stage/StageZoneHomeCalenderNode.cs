using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A5 RID: 26533
	[Token(Token = "0x20067A5")]
	public class StageZoneHomeCalenderNode : UIProgressCalender.NodeView
	{
		// Token: 0x060260DF RID: 155871 RVA: 0x000C9D20 File Offset: 0x000C7F20
		[Token(Token = "0x60260DF")]
		[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70", Slot = "14")]
		public override float GetPureNodeWidth()
		{
			return 0f;
		}

		// Token: 0x060260E0 RID: 155872 RVA: 0x000C9D38 File Offset: 0x000C7F38
		[Token(Token = "0x60260E0")]
		[Address(RVA = "0x211EC20", Offset = "0x211D820", VA = "0x18211EC20", Slot = "13")]
		public override float GetPreferWidth()
		{
			return 0f;
		}

		// Token: 0x060260E1 RID: 155873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260E1")]
		[Address(RVA = "0x211EC30", Offset = "0x211D830", VA = "0x18211EC30", Slot = "15")]
		public override void Render(UIProgressCalender.NodeView.ViewModel viewModel)
		{
		}

		// Token: 0x060260E2 RID: 155874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260E2")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public StageZoneHomeCalenderNode()
		{
		}

		// Token: 0x040358DB RID: 219355
		[Token(Token = "0x40358DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x040358DC RID: 219356
		[Token(Token = "0x40358DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _lineRect;

		// Token: 0x040358DD RID: 219357
		[Token(Token = "0x40358DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _linePrg;

		// Token: 0x040358DE RID: 219358
		[Token(Token = "0x40358DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _nodeWidth;

		// Token: 0x040358DF RID: 219359
		[Token(Token = "0x40358DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Node Style")]
		private Image _imgNode;

		// Token: 0x040358E0 RID: 219360
		[Token(Token = "0x40358E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Node Style")]
		private Sprite _spriteActive;

		// Token: 0x040358E1 RID: 219361
		[Token(Token = "0x40358E1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Node Style")]
		private Sprite _spriteEmpty;

		// Token: 0x040358E2 RID: 219362
		[Token(Token = "0x40358E2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Node Style")]
		private Color _colorActive;

		// Token: 0x040358E3 RID: 219363
		[Token(Token = "0x40358E3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Node Style")]
		private Color _colorEmpty;

		// Token: 0x040358E4 RID: 219364
		[Token(Token = "0x40358E4")]
		[FieldOffset(Offset = "0x70")]
		private float m_lineWidth;
	}
}
