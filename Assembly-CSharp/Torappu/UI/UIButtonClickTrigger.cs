using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037DA RID: 14298
	[Token(Token = "0x20037DA")]
	[RequireComponent(typeof(Button))]
	public class UIButtonClickTrigger : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016AC1 RID: 92865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AC1")]
		[Address(RVA = "0xF0D820", Offset = "0xF0C420", VA = "0x180F0D820")]
		public void OnClick()
		{
		}

		// Token: 0x06016AC2 RID: 92866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AC2")]
		[Address(RVA = "0xF0D900", Offset = "0xF0C500", VA = "0x180F0D900")]
		public UIButtonClickTrigger()
		{
		}

		// Token: 0x0401B52C RID: 111916
		[Token(Token = "0x401B52C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401B52D RID: 111917
		[Token(Token = "0x401B52D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
