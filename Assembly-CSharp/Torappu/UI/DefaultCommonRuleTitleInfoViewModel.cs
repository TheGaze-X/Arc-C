using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003757 RID: 14167
	[Token(Token = "0x2003757")]
	public class DefaultCommonRuleTitleInfoViewModel : DefaultCommonGroupBaseViewModel
	{
		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0601680B RID: 92171 RVA: 0x00091698 File Offset: 0x0008F898
		[Token(Token = "0x170035EC")]
		public override ICommonRuleInfoNodeViewModel.NodeType nodeType
		{
			[Token(Token = "0x601680B")]
			[Address(RVA = "0xEDADB0", Offset = "0xED99B0", VA = "0x180EDADB0", Slot = "7")]
			get
			{
				return ICommonRuleInfoNodeViewModel.NodeType.NONE;
			}
		}

		// Token: 0x0601680C RID: 92172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601680C")]
		[Address(RVA = "0xEDAD10", Offset = "0xED9910", VA = "0x180EDAD10")]
		public DefaultCommonRuleTitleInfoViewModel()
		{
		}

		// Token: 0x0401B1B6 RID: 111030
		[Token(Token = "0x401B1B6")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0401B1B7 RID: 111031
		[Token(Token = "0x401B1B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401B1B8 RID: 111032
		[Token(Token = "0x401B1B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
