using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200528D RID: 21133
	[Token(Token = "0x200528D")]
	public abstract class RoguelikeClassicEndingMonthEndInfoBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F2F4 RID: 127732
		[Token(Token = "0x601F2F4")]
		public abstract void Render(RoguelikeClassicEndingMonthViewModel viewModel);

		// Token: 0x0601F2F5 RID: 127733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2F5")]
		[Address(RVA = "0x18E0D70", Offset = "0x18DF970", VA = "0x1818E0D70")]
		protected RoguelikeClassicEndingMonthEndInfoBaseView()
		{
		}

		// Token: 0x04029D97 RID: 171415
		[Token(Token = "0x4029D97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
