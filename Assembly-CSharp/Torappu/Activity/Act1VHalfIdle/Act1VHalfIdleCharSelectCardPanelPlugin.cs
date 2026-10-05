using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076FE RID: 30462
	[Token(Token = "0x20076FE")]
	public class Act1VHalfIdleCharSelectCardPanelPlugin : CommonCharSelectCardPanelPlugin
	{
		// Token: 0x0602ACD0 RID: 175312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACD0")]
		[Address(RVA = "0x2697D90", Offset = "0x2696990", VA = "0x182697D90", Slot = "4")]
		public override void Render(CommonCharSelectCardDefaultViewModel viewModel, CommonCharSelectCardDefaultPanel.Options options)
		{
		}

		// Token: 0x0602ACD1 RID: 175313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACD1")]
		[Address(RVA = "0x2697EA0", Offset = "0x2696AA0", VA = "0x182697EA0")]
		public Act1VHalfIdleCharSelectCardPanelPlugin()
		{
		}

		// Token: 0x0403DADE RID: 252638
		[Token(Token = "0x403DADE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x0403DADF RID: 252639
		[Token(Token = "0x403DADF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DAE0 RID: 252640
		[Token(Token = "0x403DAE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
