using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A1B RID: 23067
	[Token(Token = "0x2005A1B")]
	public abstract class CommonChooseCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060219A0 RID: 137632
		[Token(Token = "0x60219A0")]
		public abstract void SetClickCallback(Action<string> action);

		// Token: 0x060219A1 RID: 137633
		[Token(Token = "0x60219A1")]
		public abstract void Render(ICommonChooseCharCardViewModel viewModel);

		// Token: 0x060219A2 RID: 137634
		[Token(Token = "0x60219A2")]
		public abstract void OnItemClick();

		// Token: 0x060219A3 RID: 137635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219A3")]
		[Address(RVA = "0x1C027B0", Offset = "0x1C013B0", VA = "0x181C027B0")]
		protected CommonChooseCharCardView()
		{
		}

		// Token: 0x0402DEED RID: 188141
		[Token(Token = "0x402DEED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
