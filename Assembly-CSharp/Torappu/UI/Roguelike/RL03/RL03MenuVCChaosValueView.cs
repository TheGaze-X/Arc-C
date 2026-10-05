using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200583C RID: 22588
	[Token(Token = "0x200583C")]
	public class RL03MenuVCChaosValueView : RL03MenuVCWindowElement
	{
		// Token: 0x06021032 RID: 135218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021032")]
		[Address(RVA = "0x1B4B4C0", Offset = "0x1B4A0C0", VA = "0x181B4B4C0", Slot = "4")]
		public override void Render(RL03MenuVisionAndChaosViewModel.VCWindowViewModel model)
		{
		}

		// Token: 0x06021033 RID: 135219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021033")]
		[Address(RVA = "0x1B4B690", Offset = "0x1B4A290", VA = "0x181B4B690")]
		public RL03MenuVCChaosValueView()
		{
		}

		// Token: 0x0402CE52 RID: 183890
		[Token(Token = "0x402CE52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _curValue;

		// Token: 0x0402CE53 RID: 183891
		[Token(Token = "0x402CE53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxValue;

		// Token: 0x0402CE54 RID: 183892
		[Token(Token = "0x402CE54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _tips;

		// Token: 0x0402CE55 RID: 183893
		[Token(Token = "0x402CE55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE56 RID: 183894
		[Token(Token = "0x402CE56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
