using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF2 RID: 28658
	[Token(Token = "0x2006FF2")]
	public class ActMultiV3StageListInfoDialogItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B20 RID: 166688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B20")]
		[Address(RVA = "0x240F990", Offset = "0x240E590", VA = "0x18240F990")]
		public void Render(ActMultiV3StageListInfoDialog.ModeItemViewModel viewModel)
		{
		}

		// Token: 0x06028B21 RID: 166689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B21")]
		[Address(RVA = "0x240FB80", Offset = "0x240E780", VA = "0x18240FB80")]
		public ActMultiV3StageListInfoDialogItemView()
		{
		}

		// Token: 0x04039FF0 RID: 237552
		[Token(Token = "0x4039FF0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04039FF1 RID: 237553
		[Token(Token = "0x4039FF1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04039FF2 RID: 237554
		[Token(Token = "0x4039FF2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04039FF3 RID: 237555
		[Token(Token = "0x4039FF3")]
		[FieldOffset(Offset = "0x30")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04039FF4 RID: 237556
		[Token(Token = "0x4039FF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039FF5 RID: 237557
		[Token(Token = "0x4039FF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
