using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003696 RID: 13974
	[Token(Token = "0x2003696")]
	public abstract class CustomJudgeDialogView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x06016393 RID: 91027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016394 RID: 91028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700356A")]
		public Action onConfirm
		{
			[Token(Token = "0x6016393")]
			[Address(RVA = "0xEADBD0", Offset = "0xEAC7D0", VA = "0x180EADBD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6016394")]
			[Address(RVA = "0xEADCB0", Offset = "0xEAC8B0", VA = "0x180EADCB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x06016395 RID: 91029 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016396 RID: 91030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700356B")]
		public Action onCancel
		{
			[Token(Token = "0x6016395")]
			[Address(RVA = "0xEADB70", Offset = "0xEAC770", VA = "0x180EADB70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6016396")]
			[Address(RVA = "0xEADC30", Offset = "0xEAC830", VA = "0x180EADC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06016397 RID: 91031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016397")]
		[Address(RVA = "0xEAD860", Offset = "0xEAC460", VA = "0x180EAD860")]
		public void RenderView(ValueBundle customVal)
		{
		}

		// Token: 0x06016398 RID: 91032
		[Token(Token = "0x6016398")]
		protected abstract void OnRenderView(ValueBundle customVal);

		// Token: 0x06016399 RID: 91033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016399")]
		[Address(RVA = "0xEADA10", Offset = "0xEAC610", VA = "0x180EADA10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601639A RID: 91034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601639A")]
		[Address(RVA = "0xEAD750", Offset = "0xEAC350", VA = "0x180EAD750")]
		public void EventOnBtnConfirm()
		{
		}

		// Token: 0x0601639B RID: 91035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601639B")]
		[Address(RVA = "0xEAD640", Offset = "0xEAC240", VA = "0x180EAD640")]
		public void EventOnBtnCancel()
		{
		}

		// Token: 0x0601639C RID: 91036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601639C")]
		[Address(RVA = "0xEADB10", Offset = "0xEAC710", VA = "0x180EADB10")]
		protected CustomJudgeDialogView()
		{
		}

		// Token: 0x0401AB38 RID: 109368
		[Token(Token = "0x401AB38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _backTrans;

		// Token: 0x0401AB39 RID: 109369
		[Token(Token = "0x401AB39")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x0401AB3C RID: 109372
		[Token(Token = "0x401AB3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onConfirm;

		// Token: 0x0401AB3D RID: 109373
		[Token(Token = "0x401AB3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x0401AB3E RID: 109374
		[Token(Token = "0x401AB3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCancel;

		// Token: 0x0401AB3F RID: 109375
		[Token(Token = "0x401AB3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCancel;

		// Token: 0x0401AB40 RID: 109376
		[Token(Token = "0x401AB40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401AB41 RID: 109377
		[Token(Token = "0x401AB41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AB42 RID: 109378
		[Token(Token = "0x401AB42")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnConfirm;

		// Token: 0x0401AB43 RID: 109379
		[Token(Token = "0x401AB43")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnCancel;

		// Token: 0x0401AB44 RID: 109380
		[Token(Token = "0x401AB44")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
