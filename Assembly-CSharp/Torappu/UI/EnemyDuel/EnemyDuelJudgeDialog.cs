using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F5A RID: 20314
	[Token(Token = "0x2004F5A")]
	public class EnemyDuelJudgeDialog : UICustomDialog<EnemyDuelJudgeDialog.Options>
	{
		// Token: 0x0601E3E5 RID: 123877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E5")]
		[Address(RVA = "0x1804840", Offset = "0x1803440", VA = "0x181804840", Slot = "7")]
		protected override void OnRender(EnemyDuelJudgeDialog.Options options)
		{
		}

		// Token: 0x0601E3E6 RID: 123878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E6")]
		[Address(RVA = "0x1804760", Offset = "0x1803360", VA = "0x181804760")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x0601E3E7 RID: 123879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E7")]
		[Address(RVA = "0x18047D0", Offset = "0x18033D0", VA = "0x1818047D0")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601E3E8 RID: 123880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E8")]
		[Address(RVA = "0x18049E0", Offset = "0x18035E0", VA = "0x1818049E0")]
		public EnemyDuelJudgeDialog()
		{
		}

		// Token: 0x04028578 RID: 165240
		[Token(Token = "0x4028578")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04028579 RID: 165241
		[Token(Token = "0x4028579")]
		[FieldOffset(Offset = "0x58")]
		private Action m_confirmCallback;

		// Token: 0x0402857A RID: 165242
		[Token(Token = "0x402857A")]
		[FieldOffset(Offset = "0x60")]
		private Action m_cancelCallback;

		// Token: 0x0402857B RID: 165243
		[Token(Token = "0x402857B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402857C RID: 165244
		[Token(Token = "0x402857C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0402857D RID: 165245
		[Token(Token = "0x402857D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0402857E RID: 165246
		[Token(Token = "0x402857E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F5B RID: 20315
		[Token(Token = "0x2004F5B")]
		public struct Options
		{
			// Token: 0x0402857F RID: 165247
			[Token(Token = "0x402857F")]
			[FieldOffset(Offset = "0x0")]
			public Action confirmCallback;

			// Token: 0x04028580 RID: 165248
			[Token(Token = "0x4028580")]
			[FieldOffset(Offset = "0x8")]
			public Action cancelCallback;

			// Token: 0x04028581 RID: 165249
			[Token(Token = "0x4028581")]
			[FieldOffset(Offset = "0x10")]
			public string desc;
		}
	}
}
