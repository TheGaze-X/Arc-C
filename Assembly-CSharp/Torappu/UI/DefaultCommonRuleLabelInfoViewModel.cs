using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003755 RID: 14165
	[Token(Token = "0x2003755")]
	public class DefaultCommonRuleLabelInfoViewModel : ICommonRuleInfoNodeViewModel, IHotfixable
	{
		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x06016806 RID: 92166 RVA: 0x00091668 File Offset: 0x0008F868
		[Token(Token = "0x170035EA")]
		public ICommonRuleInfoNodeViewModel.NodeType nodeType
		{
			[Token(Token = "0x6016806")]
			[Address(RVA = "0xEDAAA0", Offset = "0xED96A0", VA = "0x180EDAAA0", Slot = "4")]
			get
			{
				return ICommonRuleInfoNodeViewModel.NodeType.NONE;
			}
		}

		// Token: 0x06016807 RID: 92167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016807")]
		[Address(RVA = "0xEDAA40", Offset = "0xED9640", VA = "0x180EDAA40")]
		public DefaultCommonRuleLabelInfoViewModel()
		{
		}

		// Token: 0x0401B1AF RID: 111023
		[Token(Token = "0x401B1AF")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x0401B1B0 RID: 111024
		[Token(Token = "0x401B1B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401B1B1 RID: 111025
		[Token(Token = "0x401B1B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
