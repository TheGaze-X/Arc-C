using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006942 RID: 26946
	[Token(Token = "0x2006942")]
	public abstract class StageZoneSeasonEntryItem<ViewModel> : MonoBehaviour, IHotfixable where ViewModel : StageZoneSeasonEntryViewModel
	{
		// Token: 0x06026951 RID: 158033
		[Token(Token = "0x6026951")]
		public abstract void Render(ViewModel viewModel);

		// Token: 0x06026952 RID: 158034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026952")]
		protected StageZoneSeasonEntryItem()
		{
		}

		// Token: 0x040366DF RID: 222943
		[Token(Token = "0x40366DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
