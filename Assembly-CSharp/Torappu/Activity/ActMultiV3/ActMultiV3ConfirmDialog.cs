using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F01 RID: 28417
	[Token(Token = "0x2006F01")]
	public class ActMultiV3ConfirmDialog : UICustomDialog<ActMultiV3ConfirmDialog.Option>
	{
		// Token: 0x060285E7 RID: 165351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E7")]
		[Address(RVA = "0x23AA500", Offset = "0x23A9100", VA = "0x1823AA500")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060285E8 RID: 165352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E8")]
		[Address(RVA = "0x23AA2C0", Offset = "0x23A8EC0", VA = "0x1823AA2C0", Slot = "7")]
		protected override void OnRender(ActMultiV3ConfirmDialog.Option options)
		{
		}

		// Token: 0x060285E9 RID: 165353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E9")]
		[Address(RVA = "0x23AA650", Offset = "0x23A9250", VA = "0x1823AA650")]
		private void _OnConfirm()
		{
		}

		// Token: 0x060285EA RID: 165354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285EA")]
		[Address(RVA = "0x23AA5E0", Offset = "0x23A91E0", VA = "0x1823AA5E0")]
		private void _OnCancel()
		{
		}

		// Token: 0x060285EB RID: 165355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285EB")]
		[Address(RVA = "0x23AA6C0", Offset = "0x23A92C0", VA = "0x1823AA6C0")]
		public ActMultiV3ConfirmDialog()
		{
		}

		// Token: 0x04039664 RID: 235108
		[Token(Token = "0x4039664")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActMultiV3ConfirmDialogView _viewPrefab;

		// Token: 0x04039665 RID: 235109
		[Token(Token = "0x4039665")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04039666 RID: 235110
		[Token(Token = "0x4039666")]
		[FieldOffset(Offset = "0x50")]
		private ActMultiV3ConfirmDialogView m_view;

		// Token: 0x04039667 RID: 235111
		[Token(Token = "0x4039667")]
		[FieldOffset(Offset = "0x58")]
		private ActMultiV3Util.ActMultiV3ConfirmDialogConfig m_config;

		// Token: 0x04039668 RID: 235112
		[Token(Token = "0x4039668")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039669 RID: 235113
		[Token(Token = "0x4039669")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403966A RID: 235114
		[Token(Token = "0x403966A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnConfirm;

		// Token: 0x0403966B RID: 235115
		[Token(Token = "0x403966B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x0403966C RID: 235116
		[Token(Token = "0x403966C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F02 RID: 28418
		[Token(Token = "0x2006F02")]
		public class Option
		{
			// Token: 0x060285EC RID: 165356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403966D RID: 235117
			[Token(Token = "0x403966D")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3Util.ActMultiV3ConfirmDialogConfig config;
		}
	}
}
