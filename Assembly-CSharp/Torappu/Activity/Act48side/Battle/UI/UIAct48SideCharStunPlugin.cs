using System;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act48side.Battle.UI
{
	// Token: 0x0200729F RID: 29343
	[Token(Token = "0x200729F")]
	public class UIAct48SideCharStunPlugin : UnitHudPluginManager.HudPlugin
	{
		// Token: 0x060298B8 RID: 170168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B8")]
		[Address(RVA = "0x24EC3F0", Offset = "0x24EAFF0", VA = "0x1824EC3F0")]
		private void Start()
		{
		}

		// Token: 0x060298B9 RID: 170169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B9")]
		[Address(RVA = "0x24EC450", Offset = "0x24EB050", VA = "0x1824EC450")]
		private void Update()
		{
		}

		// Token: 0x060298BA RID: 170170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298BA")]
		[Address(RVA = "0x24EC7F0", Offset = "0x24EB3F0", VA = "0x1824EC7F0")]
		private void _OnUIShown()
		{
		}

		// Token: 0x060298BB RID: 170171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298BB")]
		[Address(RVA = "0x24EC780", Offset = "0x24EB380", VA = "0x1824EC780")]
		private void _OnUIHide()
		{
		}

		// Token: 0x060298BC RID: 170172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298BC")]
		[Address(RVA = "0x24EC860", Offset = "0x24EB460", VA = "0x1824EC860")]
		public UIAct48SideCharStunPlugin()
		{
		}

		// Token: 0x0403B644 RID: 243268
		[Token(Token = "0x403B644")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _progressPanel;

		// Token: 0x0403B645 RID: 243269
		[Token(Token = "0x403B645")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _progress;

		// Token: 0x0403B646 RID: 243270
		[Token(Token = "0x403B646")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x0403B647 RID: 243271
		[Token(Token = "0x403B647")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _markBuffKey;

		// Token: 0x0403B648 RID: 243272
		[Token(Token = "0x403B648")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Buff> m_buff;

		// Token: 0x0403B649 RID: 243273
		[Token(Token = "0x403B649")]
		[FieldOffset(Offset = "0x58")]
		private ObjectPtr<Buff> m_markBuff;

		// Token: 0x0403B64A RID: 243274
		[Token(Token = "0x403B64A")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isShow;

		// Token: 0x0403B64B RID: 243275
		[Token(Token = "0x403B64B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403B64C RID: 243276
		[Token(Token = "0x403B64C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403B64D RID: 243277
		[Token(Token = "0x403B64D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUIShown;

		// Token: 0x0403B64E RID: 243278
		[Token(Token = "0x403B64E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUIHide;

		// Token: 0x0403B64F RID: 243279
		[Token(Token = "0x403B64F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
