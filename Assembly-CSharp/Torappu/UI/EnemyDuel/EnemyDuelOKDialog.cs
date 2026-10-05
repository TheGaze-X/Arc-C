using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F5C RID: 20316
	[Token(Token = "0x2004F5C")]
	public class EnemyDuelOKDialog : UICustomDialog<EnemyDuelOKDialog.Options>
	{
		// Token: 0x0601E3E9 RID: 123881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E9")]
		[Address(RVA = "0x1807220", Offset = "0x1805E20", VA = "0x181807220", Slot = "7")]
		protected override void OnRender(EnemyDuelOKDialog.Options options)
		{
		}

		// Token: 0x0601E3EA RID: 123882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3EA")]
		[Address(RVA = "0x18071B0", Offset = "0x1805DB0", VA = "0x1818071B0")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x0601E3EB RID: 123883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3EB")]
		[Address(RVA = "0x1807430", Offset = "0x1806030", VA = "0x181807430")]
		public EnemyDuelOKDialog()
		{
		}

		// Token: 0x04028582 RID: 165250
		[Token(Token = "0x4028582")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04028583 RID: 165251
		[Token(Token = "0x4028583")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _btnText;

		// Token: 0x04028584 RID: 165252
		[Token(Token = "0x4028584")]
		[FieldOffset(Offset = "0x60")]
		private Action m_comfirmCallback;

		// Token: 0x04028585 RID: 165253
		[Token(Token = "0x4028585")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04028586 RID: 165254
		[Token(Token = "0x4028586")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x04028587 RID: 165255
		[Token(Token = "0x4028587")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F5D RID: 20317
		[Token(Token = "0x2004F5D")]
		public struct Options
		{
			// Token: 0x04028588 RID: 165256
			[Token(Token = "0x4028588")]
			[FieldOffset(Offset = "0x0")]
			public Action comfirmCallback;

			// Token: 0x04028589 RID: 165257
			[Token(Token = "0x4028589")]
			[FieldOffset(Offset = "0x8")]
			public string desc;

			// Token: 0x0402858A RID: 165258
			[Token(Token = "0x402858A")]
			[FieldOffset(Offset = "0x10")]
			public string btnDesc;
		}
	}
}
