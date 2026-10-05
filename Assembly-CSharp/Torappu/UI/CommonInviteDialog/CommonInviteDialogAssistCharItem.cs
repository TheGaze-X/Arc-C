using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BA4 RID: 23460
	[Token(Token = "0x2005BA4")]
	public class CommonInviteDialogAssistCharItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060220B1 RID: 139441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B1")]
		[Address(RVA = "0x1C8FAE0", Offset = "0x1C8E6E0", VA = "0x181C8FAE0")]
		public void Render(SharedCharData sharedCharData)
		{
		}

		// Token: 0x060220B2 RID: 139442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B2")]
		[Address(RVA = "0x1C8FD10", Offset = "0x1C8E910", VA = "0x181C8FD10")]
		public CommonInviteDialogAssistCharItem()
		{
		}

		// Token: 0x0402EAC2 RID: 191170
		[Token(Token = "0x402EAC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x0402EAC3 RID: 191171
		[Token(Token = "0x402EAC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _level;

		// Token: 0x0402EAC4 RID: 191172
		[Token(Token = "0x402EAC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _elite;

		// Token: 0x0402EAC5 RID: 191173
		[Token(Token = "0x402EAC5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402EAC6 RID: 191174
		[Token(Token = "0x402EAC6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0402EAC7 RID: 191175
		[Token(Token = "0x402EAC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EAC8 RID: 191176
		[Token(Token = "0x402EAC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
