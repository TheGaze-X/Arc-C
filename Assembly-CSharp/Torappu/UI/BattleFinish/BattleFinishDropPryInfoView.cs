using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006203 RID: 25091
	[Token(Token = "0x2006203")]
	public class BattleFinishDropPryInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602434A RID: 148298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602434A")]
		[Address(RVA = "0x1F13720", Offset = "0x1F12320", VA = "0x181F13720")]
		public void Render(DropInfoGroupViewModel viewModel)
		{
		}

		// Token: 0x0602434B RID: 148299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602434B")]
		[Address(RVA = "0x1F13900", Offset = "0x1F12500", VA = "0x181F13900")]
		private void _RenderFrame(DropInfoGroupViewModel viewModel)
		{
		}

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x0602434C RID: 148300 RVA: 0x000C36F0 File Offset: 0x000C18F0
		[Token(Token = "0x17005569")]
		public bool rendering
		{
			[Token(Token = "0x602434C")]
			[Address(RVA = "0x1F13AE0", Offset = "0x1F126E0", VA = "0x181F13AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602434D RID: 148301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602434D")]
		[Address(RVA = "0x1F13A70", Offset = "0x1F12670", VA = "0x181F13A70")]
		public BattleFinishDropPryInfoView()
		{
		}

		// Token: 0x04032566 RID: 206182
		[Token(Token = "0x4032566")]
		private const int HORIZONTAL_LAYOUT_GROUP_PADDING_LEFT_NO_TAG = 8;

		// Token: 0x04032567 RID: 206183
		[Token(Token = "0x4032567")]
		private const int HORIZONTAL_LAYOUT_GROUP_PADDING_LEFT_WITH_TAG = 120;

		// Token: 0x04032568 RID: 206184
		[Token(Token = "0x4032568")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _frame;

		// Token: 0x04032569 RID: 206185
		[Token(Token = "0x4032569")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeinDur;

		// Token: 0x0403256A RID: 206186
		[Token(Token = "0x403256A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalTag;

		// Token: 0x0403256B RID: 206187
		[Token(Token = "0x403256B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _easyTag;

		// Token: 0x0403256C RID: 206188
		[Token(Token = "0x403256C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BattleFinishDropInfoView _dropInfoView;

		// Token: 0x0403256D RID: 206189
		[Token(Token = "0x403256D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LayoutGroup _layoutGroup;

		// Token: 0x0403256E RID: 206190
		[Token(Token = "0x403256E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403256F RID: 206191
		[Token(Token = "0x403256F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderFrame;

		// Token: 0x04032570 RID: 206192
		[Token(Token = "0x4032570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rendering;

		// Token: 0x04032571 RID: 206193
		[Token(Token = "0x4032571")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
