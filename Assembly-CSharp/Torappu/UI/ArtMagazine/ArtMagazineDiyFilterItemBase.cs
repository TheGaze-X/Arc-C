using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065AE RID: 26030
	[Token(Token = "0x20065AE")]
	public abstract class ArtMagazineDiyFilterItemBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060256A1 RID: 153249
		[Token(Token = "0x60256A1")]
		public abstract void Render(object activeFilterParam);

		// Token: 0x060256A2 RID: 153250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A2")]
		[Address(RVA = "0x2062030", Offset = "0x2060C30", VA = "0x182062030")]
		protected ArtMagazineDiyFilterItemBase()
		{
		}

		// Token: 0x04034819 RID: 215065
		[Token(Token = "0x4034819")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
