using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200583F RID: 22591
	[Token(Token = "0x200583F")]
	public class RL03MenuVCZoneBuffDescView : RL03MenuVCWindowElement
	{
		// Token: 0x06021038 RID: 135224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021038")]
		[Address(RVA = "0x1B4BEA0", Offset = "0x1B4AAA0", VA = "0x181B4BEA0", Slot = "4")]
		public override void Render(RL03MenuVisionAndChaosViewModel.VCWindowViewModel model)
		{
		}

		// Token: 0x06021039 RID: 135225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021039")]
		[Address(RVA = "0x1B4BF80", Offset = "0x1B4AB80", VA = "0x181B4BF80")]
		public RL03MenuVCZoneBuffDescView()
		{
		}

		// Token: 0x0402CE64 RID: 183908
		[Token(Token = "0x402CE64")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402CE65 RID: 183909
		[Token(Token = "0x402CE65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE66 RID: 183910
		[Token(Token = "0x402CE66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
