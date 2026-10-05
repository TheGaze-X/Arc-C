using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006933 RID: 26931
	[Token(Token = "0x2006933")]
	public class StagePreviewRewardGroupOverridePlugin : StagePreviewRewardGroupViewPlugin
	{
		// Token: 0x06026919 RID: 157977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026919")]
		[Address(RVA = "0x21B4A10", Offset = "0x21B3610", VA = "0x1821B4A10", Slot = "4")]
		public override void Render(OverrideDropInfo viewModel)
		{
		}

		// Token: 0x0602691A RID: 157978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602691A")]
		[Address(RVA = "0x21B4B50", Offset = "0x21B3750", VA = "0x1821B4B50")]
		public StagePreviewRewardGroupOverridePlugin()
		{
		}

		// Token: 0x0403666A RID: 222826
		[Token(Token = "0x403666A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _groupDetail;

		// Token: 0x0403666B RID: 222827
		[Token(Token = "0x403666B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _groupSimpleBar;

		// Token: 0x0403666C RID: 222828
		[Token(Token = "0x403666C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _groupMultiBar;

		// Token: 0x0403666D RID: 222829
		[Token(Token = "0x403666D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403666E RID: 222830
		[Token(Token = "0x403666E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
