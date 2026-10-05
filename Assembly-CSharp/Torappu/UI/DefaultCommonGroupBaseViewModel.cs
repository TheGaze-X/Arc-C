using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003751 RID: 14161
	[Token(Token = "0x2003751")]
	public abstract class DefaultCommonGroupBaseViewModel : ICommonRuleInfoGroupViewModel, ICommonRuleInfoNodeViewModel, IHotfixable
	{
		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x060167F4 RID: 92148
		[Token(Token = "0x170035E6")]
		public abstract ICommonRuleInfoNodeViewModel.NodeType nodeType { [Token(Token = "0x60167F4")] get; }

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x060167F5 RID: 92149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060167F6 RID: 92150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035E7")]
		public List<ICommonRuleInfoNodeViewModel> childNodes
		{
			[Token(Token = "0x60167F5")]
			[Address(RVA = "0xED9510", Offset = "0xED8110", VA = "0x180ED9510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60167F6")]
			[Address(RVA = "0xED9570", Offset = "0xED8170", VA = "0x180ED9570", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060167F7 RID: 92151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167F7")]
		[Address(RVA = "0xED93E0", Offset = "0xED7FE0", VA = "0x180ED93E0", Slot = "8")]
		public virtual void ClearChildNodes()
		{
		}

		// Token: 0x060167F8 RID: 92152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167F8")]
		[Address(RVA = "0xED9210", Offset = "0xED7E10", VA = "0x180ED9210")]
		public void AddChild(ICommonRuleInfoNodeViewModel childNodeViewModel)
		{
		}

		// Token: 0x060167F9 RID: 92153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167F9")]
		[Address(RVA = "0xED94B0", Offset = "0xED80B0", VA = "0x180ED94B0")]
		protected DefaultCommonGroupBaseViewModel()
		{
		}

		// Token: 0x0401B199 RID: 111001
		[Token(Token = "0x401B199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_childNodes;

		// Token: 0x0401B19A RID: 111002
		[Token(Token = "0x401B19A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_childNodes;

		// Token: 0x0401B19B RID: 111003
		[Token(Token = "0x401B19B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearChildNodes;

		// Token: 0x0401B19C RID: 111004
		[Token(Token = "0x401B19C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddChild;

		// Token: 0x0401B19D RID: 111005
		[Token(Token = "0x401B19D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
