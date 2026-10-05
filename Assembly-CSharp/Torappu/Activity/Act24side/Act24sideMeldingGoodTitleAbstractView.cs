using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075A6 RID: 30118
	[Token(Token = "0x20075A6")]
	public abstract class Act24sideMeldingGoodTitleAbstractView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A614 RID: 173588
		[Token(Token = "0x602A614")]
		public abstract void Render(Act24sideMeldingGoodDisplayViewModel groupViewModel);

		// Token: 0x0602A615 RID: 173589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A615")]
		[Address(RVA = "0x260D840", Offset = "0x260C440", VA = "0x18260D840")]
		protected Act24sideMeldingGoodTitleAbstractView()
		{
		}

		// Token: 0x0403CF9A RID: 249754
		[Token(Token = "0x403CF9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
