using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Popup
{
	// Token: 0x020033CE RID: 13262
	[Token(Token = "0x20033CE")]
	public class UIDiceToastPanel : UIToastController.UIToastSubPanel
	{
		// Token: 0x060152A8 RID: 86696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152A8")]
		[Address(RVA = "0xDACE90", Offset = "0xDABA90", VA = "0x180DACE90", Slot = "5")]
		public override void OnShow(UIToastController.Options options)
		{
		}

		// Token: 0x060152A9 RID: 86697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152A9")]
		[Address(RVA = "0xDAD090", Offset = "0xDABC90", VA = "0x180DAD090", Slot = "6")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060152AA RID: 86698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152AA")]
		[Address(RVA = "0xDAD130", Offset = "0xDABD30", VA = "0x180DAD130")]
		public UIDiceToastPanel()
		{
		}

		// Token: 0x060152AB RID: 86699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152AB")]
		[Address(RVA = "0xD5A470", Offset = "0xD59070", VA = "0x180D5A470")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x04019413 RID: 103443
		[Token(Token = "0x4019413")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _diceIcon;

		// Token: 0x04019414 RID: 103444
		[Token(Token = "0x4019414")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _diceNumText;

		// Token: 0x04019415 RID: 103445
		[Token(Token = "0x4019415")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04019416 RID: 103446
		[Token(Token = "0x4019416")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x04019417 RID: 103447
		[Token(Token = "0x4019417")]
		[FieldOffset(Offset = "0x48")]
		private float m_lastTime;

		// Token: 0x04019418 RID: 103448
		[Token(Token = "0x4019418")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x04019419 RID: 103449
		[Token(Token = "0x4019419")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0401941A RID: 103450
		[Token(Token = "0x401941A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
