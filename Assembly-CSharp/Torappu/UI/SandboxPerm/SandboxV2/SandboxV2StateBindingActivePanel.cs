using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200412C RID: 16684
	[Token(Token = "0x200412C")]
	public class SandboxV2StateBindingActivePanel : SandboxV2StateBindingPanel
	{
		// Token: 0x06019C53 RID: 105555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C53")]
		[Address(RVA = "0x12B58D0", Offset = "0x12B44D0", VA = "0x1812B58D0", Slot = "4")]
		public override void SetShow(bool isShow)
		{
		}

		// Token: 0x06019C54 RID: 105556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C54")]
		[Address(RVA = "0x12B5950", Offset = "0x12B4550", VA = "0x1812B5950")]
		public SandboxV2StateBindingActivePanel()
		{
		}

		// Token: 0x04020502 RID: 132354
		[Token(Token = "0x4020502")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _gameObject;

		// Token: 0x04020503 RID: 132355
		[Token(Token = "0x4020503")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x04020504 RID: 132356
		[Token(Token = "0x4020504")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
