using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Popup
{
	// Token: 0x020033D0 RID: 13264
	[Token(Token = "0x20033D0")]
	public class UIInfoToastPanel : UIToastController.UIToastSubPanel
	{
		// Token: 0x060152B8 RID: 86712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B8")]
		[Address(RVA = "0xDADBD0", Offset = "0xDAC7D0", VA = "0x180DADBD0", Slot = "5")]
		public override void OnShow(UIToastController.Options options)
		{
		}

		// Token: 0x060152B9 RID: 86713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B9")]
		[Address(RVA = "0xDADD40", Offset = "0xDAC940", VA = "0x180DADD40", Slot = "6")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060152BA RID: 86714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152BA")]
		[Address(RVA = "0xDADDE0", Offset = "0xDAC9E0", VA = "0x180DADDE0")]
		public UIInfoToastPanel()
		{
		}

		// Token: 0x060152BB RID: 86715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152BB")]
		[Address(RVA = "0xD5A470", Offset = "0xD59070", VA = "0x180D5A470")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x04019429 RID: 103465
		[Token(Token = "0x4019429")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0401942A RID: 103466
		[Token(Token = "0x401942A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0401942B RID: 103467
		[Token(Token = "0x401942B")]
		[FieldOffset(Offset = "0x38")]
		private float m_lastTime;

		// Token: 0x0401942C RID: 103468
		[Token(Token = "0x401942C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401942D RID: 103469
		[Token(Token = "0x401942D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0401942E RID: 103470
		[Token(Token = "0x401942E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
