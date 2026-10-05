using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x0200649E RID: 25758
	[Token(Token = "0x200649E")]
	public class AutoChessBattleUIMultiBossPrepareDialog : UICompDialog<AutoChessBattleUIMultiBossPrepareDialog.Input>
	{
		// Token: 0x06025097 RID: 151703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025097")]
		[Address(RVA = "0x1FEB8E0", Offset = "0x1FEA4E0", VA = "0x181FEB8E0", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIMultiBossPrepareDialog.Input input)
		{
		}

		// Token: 0x06025098 RID: 151704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025098")]
		[Address(RVA = "0x1FEBB40", Offset = "0x1FEA740", VA = "0x181FEBB40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025099 RID: 151705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025099")]
		[Address(RVA = "0x1FEBDD0", Offset = "0x1FEA9D0", VA = "0x181FEBDD0")]
		private IEnumerator _PlayAnimCoroutine()
		{
			return null;
		}

		// Token: 0x0602509A RID: 151706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602509A")]
		[Address(RVA = "0x1FEBD10", Offset = "0x1FEA910", VA = "0x181FEBD10")]
		private IEnumerator _OnPlayAnim(AutoChessBattleBossRoundModel.AnimStatus animStatus)
		{
			return null;
		}

		// Token: 0x0602509B RID: 151707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602509B")]
		[Address(RVA = "0x1FEBE80", Offset = "0x1FEAA80", VA = "0x181FEBE80")]
		public AutoChessBattleUIMultiBossPrepareDialog()
		{
		}

		// Token: 0x04033DA6 RID: 212390
		[Token(Token = "0x4033DA6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessBattleUIMultiBossPrepareView _view;

		// Token: 0x04033DA7 RID: 212391
		[Token(Token = "0x4033DA7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _enterAnimDuration;

		// Token: 0x04033DA8 RID: 212392
		[Token(Token = "0x4033DA8")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _expandAnimDuration;

		// Token: 0x04033DA9 RID: 212393
		[Token(Token = "0x4033DA9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _exitAnimDuration;

		// Token: 0x04033DAA RID: 212394
		[Token(Token = "0x4033DAA")]
		[FieldOffset(Offset = "0x84")]
		private bool m_hasInited;

		// Token: 0x04033DAB RID: 212395
		[Token(Token = "0x4033DAB")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessBattleUIViewModelProperty m_prop;

		// Token: 0x04033DAC RID: 212396
		[Token(Token = "0x4033DAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033DAD RID: 212397
		[Token(Token = "0x4033DAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033DAE RID: 212398
		[Token(Token = "0x4033DAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayAnimCoroutine;

		// Token: 0x04033DAF RID: 212399
		[Token(Token = "0x4033DAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPlayAnim;

		// Token: 0x04033DB0 RID: 212400
		[Token(Token = "0x4033DB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200649F RID: 25759
		[Token(Token = "0x200649F")]
		public class Input
		{
			// Token: 0x0602509C RID: 151708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602509C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033DB1 RID: 212401
			[Token(Token = "0x4033DB1")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBattleUIViewModelProperty viewProp;
		}
	}
}
