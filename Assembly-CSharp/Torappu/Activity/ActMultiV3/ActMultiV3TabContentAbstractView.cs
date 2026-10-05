using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F58 RID: 28504
	[Token(Token = "0x2006F58")]
	public abstract class ActMultiV3TabContentAbstractView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287AD RID: 165805
		[Token(Token = "0x60287AD")]
		public abstract void Render(ActMultiV3ManualViewModel viewModel);

		// Token: 0x060287AE RID: 165806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287AE")]
		[Address(RVA = "0x23D0AE0", Offset = "0x23CF6E0", VA = "0x1823D0AE0")]
		protected ActMultiV3TabContentAbstractView()
		{
		}

		// Token: 0x04039960 RID: 235872
		[Token(Token = "0x4039960")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
