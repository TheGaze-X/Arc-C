using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x020074A1 RID: 29857
	[Token(Token = "0x20074A1")]
	public class Act29signProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A1C1 RID: 172481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1C1")]
		[Address(RVA = "0x25BC2F0", Offset = "0x25BAEF0", VA = "0x1825BC2F0")]
		public void Render(Act29signDynViewModel viewModel)
		{
		}

		// Token: 0x0602A1C2 RID: 172482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1C2")]
		[Address(RVA = "0x25BC530", Offset = "0x25BB130", VA = "0x1825BC530")]
		private void _RenderExpandView(bool isShow)
		{
		}

		// Token: 0x0602A1C3 RID: 172483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1C3")]
		[Address(RVA = "0x25BC5F0", Offset = "0x25BB1F0", VA = "0x1825BC5F0")]
		public Act29signProgressView()
		{
		}

		// Token: 0x0403C769 RID: 247657
		[Token(Token = "0x403C769")]
		private const float EXPAND_DELAY = 0.16f;

		// Token: 0x0403C76A RID: 247658
		[Token(Token = "0x403C76A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act29signExpandView _expandView;

		// Token: 0x0403C76B RID: 247659
		[Token(Token = "0x403C76B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _optionCompleteDescText;

		// Token: 0x0403C76C RID: 247660
		[Token(Token = "0x403C76C")]
		[FieldOffset(Offset = "0x28")]
		private int m_dayIndex;

		// Token: 0x0403C76D RID: 247661
		[Token(Token = "0x403C76D")]
		[FieldOffset(Offset = "0x2C")]
		private Act29signExpandView.Model m_expandViewModel;

		// Token: 0x0403C76E RID: 247662
		[Token(Token = "0x403C76E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C76F RID: 247663
		[Token(Token = "0x403C76F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderExpandView;

		// Token: 0x0403C770 RID: 247664
		[Token(Token = "0x403C770")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
