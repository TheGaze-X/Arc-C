using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006805 RID: 26629
	[Token(Token = "0x2006805")]
	public abstract class MainMapDecroView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026285 RID: 156293
		[Token(Token = "0x6026285")]
		public abstract void Render(string actId, ZoneViewModel viewModel);

		// Token: 0x06026286 RID: 156294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026286")]
		[Address(RVA = "0x2130D40", Offset = "0x212F940", VA = "0x182130D40")]
		protected MainMapDecroView()
		{
		}

		// Token: 0x04035BDD RID: 220125
		[Token(Token = "0x4035BDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
