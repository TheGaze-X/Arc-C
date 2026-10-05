using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200583D RID: 22589
	[Token(Token = "0x200583D")]
	public class RL03MenuVCPredictView : RL03MenuVCWindowElement
	{
		// Token: 0x06021034 RID: 135220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021034")]
		[Address(RVA = "0x1B4B730", Offset = "0x1B4A330", VA = "0x181B4B730", Slot = "4")]
		public override void Render(RL03MenuVisionAndChaosViewModel.VCWindowViewModel model)
		{
		}

		// Token: 0x06021035 RID: 135221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021035")]
		[Address(RVA = "0x1B4B860", Offset = "0x1B4A460", VA = "0x181B4B860")]
		public RL03MenuVCPredictView()
		{
		}

		// Token: 0x0402CE57 RID: 183895
		[Token(Token = "0x402CE57")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _chaosName;

		// Token: 0x0402CE58 RID: 183896
		[Token(Token = "0x402CE58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _chaosDesc;

		// Token: 0x0402CE59 RID: 183897
		[Token(Token = "0x402CE59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE5A RID: 183898
		[Token(Token = "0x402CE5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
