using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003756 RID: 14166
	[Token(Token = "0x2003756")]
	public class DefaultCommonRuleTitleInfoView : CommonRuleInfoNodeView
	{
		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x06016808 RID: 92168 RVA: 0x00091680 File Offset: 0x0008F880
		[Token(Token = "0x170035EB")]
		public override ICommonRuleInfoNodeViewModel.NodeType nodeType
		{
			[Token(Token = "0x6016808")]
			[Address(RVA = "0xEDAFC0", Offset = "0xED9BC0", VA = "0x180EDAFC0", Slot = "4")]
			get
			{
				return ICommonRuleInfoNodeViewModel.NodeType.NONE;
			}
		}

		// Token: 0x06016809 RID: 92169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016809")]
		[Address(RVA = "0xEDAE10", Offset = "0xED9A10", VA = "0x180EDAE10", Slot = "5")]
		public override void Render(ICommonRuleInfoNodeViewModel nodeInfoViewModel)
		{
		}

		// Token: 0x0601680A RID: 92170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601680A")]
		[Address(RVA = "0xEDAF20", Offset = "0xED9B20", VA = "0x180EDAF20")]
		public DefaultCommonRuleTitleInfoView()
		{
		}

		// Token: 0x0401B1B2 RID: 111026
		[Token(Token = "0x401B1B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _labelText;

		// Token: 0x0401B1B3 RID: 111027
		[Token(Token = "0x401B1B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401B1B4 RID: 111028
		[Token(Token = "0x401B1B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B1B5 RID: 111029
		[Token(Token = "0x401B1B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
