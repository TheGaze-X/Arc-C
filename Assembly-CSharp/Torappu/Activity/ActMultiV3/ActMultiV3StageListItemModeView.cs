using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF7 RID: 28663
	[Token(Token = "0x2006FF7")]
	public abstract class ActMultiV3StageListItemModeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B2B RID: 166699
		[Token(Token = "0x6028B2B")]
		public abstract void Render(ActMultiV3StageItemViewModel viewModel);

		// Token: 0x06028B2C RID: 166700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B2C")]
		[Address(RVA = "0x240FF70", Offset = "0x240EB70", VA = "0x18240FF70")]
		protected ActMultiV3StageListItemModeView()
		{
		}

		// Token: 0x0403A016 RID: 237590
		[Token(Token = "0x403A016")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
