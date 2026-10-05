using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200583E RID: 22590
	[Token(Token = "0x200583E")]
	public class RL03MenuVCVisionView : RL03MenuVCWindowElement
	{
		// Token: 0x06021036 RID: 135222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021036")]
		[Address(RVA = "0x1B4B900", Offset = "0x1B4A500", VA = "0x181B4B900", Slot = "4")]
		public override void Render(RL03MenuVisionAndChaosViewModel.VCWindowViewModel model)
		{
		}

		// Token: 0x06021037 RID: 135223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021037")]
		[Address(RVA = "0x1B4BBE0", Offset = "0x1B4A7E0", VA = "0x181B4BBE0")]
		public RL03MenuVCVisionView()
		{
		}

		// Token: 0x0402CE5B RID: 183899
		[Token(Token = "0x402CE5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0402CE5C RID: 183900
		[Token(Token = "0x402CE5C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxLvlText;

		// Token: 0x0402CE5D RID: 183901
		[Token(Token = "0x402CE5D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _statusIcon;

		// Token: 0x0402CE5E RID: 183902
		[Token(Token = "0x402CE5E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _statusText;

		// Token: 0x0402CE5F RID: 183903
		[Token(Token = "0x402CE5F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _statusBg;

		// Token: 0x0402CE60 RID: 183904
		[Token(Token = "0x402CE60")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _desc1;

		// Token: 0x0402CE61 RID: 183905
		[Token(Token = "0x402CE61")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _desc2;

		// Token: 0x0402CE62 RID: 183906
		[Token(Token = "0x402CE62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE63 RID: 183907
		[Token(Token = "0x402CE63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
