using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004357 RID: 17239
	[Token(Token = "0x2004357")]
	public abstract class SandboxV2RacerInventoryListBaseView<T> : DataBinder<T>, IHotfixable where T : IBindProperty
	{
		// Token: 0x0601A769 RID: 108393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A769")]
		protected SandboxV2RacerInventoryListBaseView()
		{
		}

		// Token: 0x04021AA4 RID: 137892
		[Token(Token = "0x4021AA4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected SandboxV2RacerInventoryListAdapter _adapter;

		// Token: 0x04021AA5 RID: 137893
		[Token(Token = "0x4021AA5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Text _textEmpty;

		// Token: 0x04021AA6 RID: 137894
		[Token(Token = "0x4021AA6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameObject _panelEmpty;

		// Token: 0x04021AA7 RID: 137895
		[Token(Token = "0x4021AA7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameObject _panelCardList;

		// Token: 0x04021AA8 RID: 137896
		[Token(Token = "0x4021AA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
