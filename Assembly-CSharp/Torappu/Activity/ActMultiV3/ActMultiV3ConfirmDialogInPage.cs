using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F03 RID: 28419
	[Token(Token = "0x2006F03")]
	public class ActMultiV3ConfirmDialogInPage : UICompDialog<ActMultiV3ConfirmDialogInPage.Option>
	{
		// Token: 0x060285ED RID: 165357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285ED")]
		[Address(RVA = "0x23A9980", Offset = "0x23A8580", VA = "0x1823A9980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060285EE RID: 165358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285EE")]
		[Address(RVA = "0x23A9730", Offset = "0x23A8330", VA = "0x1823A9730", Slot = "18")]
		protected override void OnRender(ActMultiV3ConfirmDialogInPage.Option options)
		{
		}

		// Token: 0x060285EF RID: 165359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285EF")]
		[Address(RVA = "0x23A9B20", Offset = "0x23A8720", VA = "0x1823A9B20")]
		private void _OnConfirm()
		{
		}

		// Token: 0x060285F0 RID: 165360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285F0")]
		[Address(RVA = "0x23A9A60", Offset = "0x23A8660", VA = "0x1823A9A60")]
		private void _OnCancel()
		{
		}

		// Token: 0x060285F1 RID: 165361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285F1")]
		[Address(RVA = "0x23A9BE0", Offset = "0x23A87E0", VA = "0x1823A9BE0")]
		public ActMultiV3ConfirmDialogInPage()
		{
		}

		// Token: 0x0403966E RID: 235118
		[Token(Token = "0x403966E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3ConfirmDialogView _viewPrefab;

		// Token: 0x0403966F RID: 235119
		[Token(Token = "0x403966F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04039670 RID: 235120
		[Token(Token = "0x4039670")]
		[FieldOffset(Offset = "0x80")]
		private ActMultiV3ConfirmDialogView m_view;

		// Token: 0x04039671 RID: 235121
		[Token(Token = "0x4039671")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3Util.ActMultiV3ConfirmDialogConfig m_config;

		// Token: 0x04039672 RID: 235122
		[Token(Token = "0x4039672")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039673 RID: 235123
		[Token(Token = "0x4039673")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039674 RID: 235124
		[Token(Token = "0x4039674")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnConfirm;

		// Token: 0x04039675 RID: 235125
		[Token(Token = "0x4039675")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x04039676 RID: 235126
		[Token(Token = "0x4039676")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F04 RID: 28420
		[Token(Token = "0x2006F04")]
		public class Option
		{
			// Token: 0x060285F2 RID: 165362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285F2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04039677 RID: 235127
			[Token(Token = "0x4039677")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3Util.ActMultiV3ConfirmDialogConfig config;
		}
	}
}
