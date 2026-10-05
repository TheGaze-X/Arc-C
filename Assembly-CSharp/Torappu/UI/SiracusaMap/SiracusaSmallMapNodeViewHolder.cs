using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F95 RID: 16277
	[Token(Token = "0x2003F95")]
	public class SiracusaSmallMapNodeViewHolder : SiracusaMapNodeViewHolder
	{
		// Token: 0x060193F9 RID: 103417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F9")]
		[Address(RVA = "0x11F5860", Offset = "0x11F4460", VA = "0x1811F5860", Slot = "4")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x060193FA RID: 103418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193FA")]
		[Address(RVA = "0x11F5B30", Offset = "0x11F4730", VA = "0x1811F5B30", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060193FB RID: 103419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60193FB")]
		[Address(RVA = "0x11F5C90", Offset = "0x11F4890", VA = "0x1811F5C90")]
		private SiracusaMapNodeViewBase _LoadNodeView(bool isSelected)
		{
			return null;
		}

		// Token: 0x060193FC RID: 103420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193FC")]
		[Address(RVA = "0x11F5E60", Offset = "0x11F4A60", VA = "0x1811F5E60")]
		public SiracusaSmallMapNodeViewHolder()
		{
		}

		// Token: 0x0401F567 RID: 128359
		[Token(Token = "0x401F567")]
		[FieldOffset(Offset = "0x58")]
		private SiracusaMapNodeViewBase m_normalNodeView;

		// Token: 0x0401F568 RID: 128360
		[Token(Token = "0x401F568")]
		[FieldOffset(Offset = "0x60")]
		private SiracusaMapNodeViewBase m_selectedNodeView;

		// Token: 0x0401F569 RID: 128361
		[Token(Token = "0x401F569")]
		[FieldOffset(Offset = "0x68")]
		private NodeModelStruct m_nodeModelStruct;

		// Token: 0x0401F56A RID: 128362
		[Token(Token = "0x401F56A")]
		[FieldOffset(Offset = "0xB8")]
		private SiracusaMapNodeViewBase m_curNodeView;

		// Token: 0x0401F56B RID: 128363
		[Token(Token = "0x401F56B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F56C RID: 128364
		[Token(Token = "0x401F56C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401F56D RID: 128365
		[Token(Token = "0x401F56D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadNodeView;

		// Token: 0x0401F56E RID: 128366
		[Token(Token = "0x401F56E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
