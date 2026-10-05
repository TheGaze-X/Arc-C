using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F7B RID: 16251
	[Token(Token = "0x2003F7B")]
	public class SiracusaBigMapNodeViewHolder : SiracusaMapNodeViewHolder
	{
		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0601935D RID: 103261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601935E RID: 103262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C34")]
		public Action<SiracusaMapMapNodeViewModel> onNodeClick
		{
			[Token(Token = "0x601935D")]
			[Address(RVA = "0x11E48B0", Offset = "0x11E34B0", VA = "0x1811E48B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601935E")]
			[Address(RVA = "0x11E4970", Offset = "0x11E3570", VA = "0x1811E4970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0601935F RID: 103263 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019360 RID: 103264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C35")]
		public AutoPackSpriteHub taskCharAvatarHub
		{
			[Token(Token = "0x601935F")]
			[Address(RVA = "0x11E4910", Offset = "0x11E3510", VA = "0x1811E4910")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6019360")]
			[Address(RVA = "0x11E49F0", Offset = "0x11E35F0", VA = "0x1811E49F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019361 RID: 103265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019361")]
		[Address(RVA = "0x11E3C30", Offset = "0x11E2830", VA = "0x1811E3C30", Slot = "4")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x06019362 RID: 103266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019362")]
		[Address(RVA = "0x11E4050", Offset = "0x11E2C50", VA = "0x1811E4050", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06019363 RID: 103267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019363")]
		[Address(RVA = "0x11E42D0", Offset = "0x11E2ED0", VA = "0x1811E42D0")]
		private SiracusaMapNodeViewBase _LoadNodeView(SiracusaMapMapNodeViewModel.NodeType nodeType, bool isSelected)
		{
			return null;
		}

		// Token: 0x06019364 RID: 103268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019364")]
		[Address(RVA = "0x11E46F0", Offset = "0x11E32F0", VA = "0x1811E46F0")]
		private void _OnBigMapNodeClicked(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x06019365 RID: 103269 RVA: 0x0009D410 File Offset: 0x0009B610
		[Token(Token = "0x6019365")]
		[Address(RVA = "0x11E41B0", Offset = "0x11E2DB0", VA = "0x1811E41B0")]
		private static bool _CheckIfNeedAnim(NodeModelStruct prevViewModel, NodeModelStruct newViewModel)
		{
			return default(bool);
		}

		// Token: 0x06019366 RID: 103270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019366")]
		[Address(RVA = "0x11E4810", Offset = "0x11E3410", VA = "0x1811E4810")]
		public SiracusaBigMapNodeViewHolder()
		{
		}

		// Token: 0x0401F435 RID: 128053
		[Token(Token = "0x401F435")]
		[FieldOffset(Offset = "0x58")]
		private SiracusaMapNodeViewBase m_normalNodeView;

		// Token: 0x0401F436 RID: 128054
		[Token(Token = "0x401F436")]
		[FieldOffset(Offset = "0x60")]
		private SiracusaMapNodeViewBase m_selectedNodeView;

		// Token: 0x0401F437 RID: 128055
		[Token(Token = "0x401F437")]
		[FieldOffset(Offset = "0x68")]
		private SiracusaMapNodeViewBase m_taskNodeView;

		// Token: 0x0401F438 RID: 128056
		[Token(Token = "0x401F438")]
		[FieldOffset(Offset = "0x70")]
		private NodeModelStruct m_nodeModelStruct;

		// Token: 0x0401F439 RID: 128057
		[Token(Token = "0x401F439")]
		[FieldOffset(Offset = "0xC0")]
		private SiracusaMapNodeViewBase m_curNodeView;

		// Token: 0x0401F43C RID: 128060
		[Token(Token = "0x401F43C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0401F43D RID: 128061
		[Token(Token = "0x401F43D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0401F43E RID: 128062
		[Token(Token = "0x401F43E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_taskCharAvatarHub;

		// Token: 0x0401F43F RID: 128063
		[Token(Token = "0x401F43F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_taskCharAvatarHub;

		// Token: 0x0401F440 RID: 128064
		[Token(Token = "0x401F440")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F441 RID: 128065
		[Token(Token = "0x401F441")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401F442 RID: 128066
		[Token(Token = "0x401F442")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadNodeView;

		// Token: 0x0401F443 RID: 128067
		[Token(Token = "0x401F443")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBigMapNodeClicked;

		// Token: 0x0401F444 RID: 128068
		[Token(Token = "0x401F444")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfNeedAnim;

		// Token: 0x0401F445 RID: 128069
		[Token(Token = "0x401F445")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
