using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF5 RID: 28661
	[Token(Token = "0x2006FF5")]
	public class ActMultiV3StageListItemModeExScoreView : ActMultiV3StageListItemModeView
	{
		// Token: 0x06028B27 RID: 166695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B27")]
		[Address(RVA = "0x240FBE0", Offset = "0x240E7E0", VA = "0x18240FBE0", Slot = "4")]
		public override void Render(ActMultiV3StageItemViewModel viewModel)
		{
		}

		// Token: 0x06028B28 RID: 166696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B28")]
		[Address(RVA = "0x240FCC0", Offset = "0x240E8C0", VA = "0x18240FCC0")]
		public ActMultiV3StageListItemModeExScoreView()
		{
		}

		// Token: 0x0403A00D RID: 237581
		[Token(Token = "0x403A00D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textExScore;

		// Token: 0x0403A00E RID: 237582
		[Token(Token = "0x403A00E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A00F RID: 237583
		[Token(Token = "0x403A00F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
