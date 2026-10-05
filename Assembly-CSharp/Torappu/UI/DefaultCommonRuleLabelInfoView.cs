using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003754 RID: 14164
	[Token(Token = "0x2003754")]
	public class DefaultCommonRuleLabelInfoView : CommonRuleInfoNodeView
	{
		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x06016803 RID: 92163 RVA: 0x00091650 File Offset: 0x0008F850
		[Token(Token = "0x170035E9")]
		public override ICommonRuleInfoNodeViewModel.NodeType nodeType
		{
			[Token(Token = "0x6016803")]
			[Address(RVA = "0xEDACB0", Offset = "0xED98B0", VA = "0x180EDACB0", Slot = "4")]
			get
			{
				return ICommonRuleInfoNodeViewModel.NodeType.NONE;
			}
		}

		// Token: 0x06016804 RID: 92164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016804")]
		[Address(RVA = "0xEDAB00", Offset = "0xED9700", VA = "0x180EDAB00", Slot = "5")]
		public override void Render(ICommonRuleInfoNodeViewModel nodeInfoViewModel)
		{
		}

		// Token: 0x06016805 RID: 92165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016805")]
		[Address(RVA = "0xEDAC10", Offset = "0xED9810", VA = "0x180EDAC10")]
		public DefaultCommonRuleLabelInfoView()
		{
		}

		// Token: 0x0401B1AB RID: 111019
		[Token(Token = "0x401B1AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _labelText;

		// Token: 0x0401B1AC RID: 111020
		[Token(Token = "0x401B1AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401B1AD RID: 111021
		[Token(Token = "0x401B1AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B1AE RID: 111022
		[Token(Token = "0x401B1AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
