using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F05 RID: 28421
	[Token(Token = "0x2006F05")]
	public class ActMultiV3ConfirmDialogView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x060285F4 RID: 165364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060285F3 RID: 165363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F4B")]
		public Action onConfirm
		{
			[Token(Token = "0x60285F4")]
			[Address(RVA = "0x23AA160", Offset = "0x23A8D60", VA = "0x1823AA160")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60285F3")]
			[Address(RVA = "0x23AA240", Offset = "0x23A8E40", VA = "0x1823AA240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x060285F6 RID: 165366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060285F5 RID: 165365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F4C")]
		public Action onCancel
		{
			[Token(Token = "0x60285F6")]
			[Address(RVA = "0x23AA100", Offset = "0x23A8D00", VA = "0x1823AA100")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60285F5")]
			[Address(RVA = "0x23AA1C0", Offset = "0x23A8DC0", VA = "0x1823AA1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060285F7 RID: 165367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285F7")]
		[Address(RVA = "0x23A9E70", Offset = "0x23A8A70", VA = "0x1823A9E70")]
		public void Render(ActMultiV3Util.ActMultiV3ConfirmDialogConfig config)
		{
		}

		// Token: 0x060285F8 RID: 165368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285F8")]
		[Address(RVA = "0x23A9D60", Offset = "0x23A8960", VA = "0x1823A9D60")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x060285F9 RID: 165369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285F9")]
		[Address(RVA = "0x23A9C50", Offset = "0x23A8850", VA = "0x1823A9C50")]
		public void EventOnCancel()
		{
		}

		// Token: 0x060285FA RID: 165370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285FA")]
		[Address(RVA = "0x23AA0A0", Offset = "0x23A8CA0", VA = "0x1823AA0A0")]
		public ActMultiV3ConfirmDialogView()
		{
		}

		// Token: 0x04039678 RID: 235128
		[Token(Token = "0x4039678")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _dialogContentText;

		// Token: 0x04039679 RID: 235129
		[Token(Token = "0x4039679")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _confirmBtnText;

		// Token: 0x0403967A RID: 235130
		[Token(Token = "0x403967A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _confirmOnlyBtnText;

		// Token: 0x0403967B RID: 235131
		[Token(Token = "0x403967B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _cancelBtnText;

		// Token: 0x0403967C RID: 235132
		[Token(Token = "0x403967C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _confirmOnlyToggle;

		// Token: 0x0403967F RID: 235135
		[Token(Token = "0x403967F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x04039680 RID: 235136
		[Token(Token = "0x4039680")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onConfirm;

		// Token: 0x04039681 RID: 235137
		[Token(Token = "0x4039681")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onCancel;

		// Token: 0x04039682 RID: 235138
		[Token(Token = "0x4039682")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onCancel;

		// Token: 0x04039683 RID: 235139
		[Token(Token = "0x4039683")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039684 RID: 235140
		[Token(Token = "0x4039684")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04039685 RID: 235141
		[Token(Token = "0x4039685")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCancel;

		// Token: 0x04039686 RID: 235142
		[Token(Token = "0x4039686")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
