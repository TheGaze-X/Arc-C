using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200707B RID: 28795
	[Token(Token = "0x200707B")]
	[RequireComponent(typeof(CanvasGroup))]
	public abstract class ActMultiV3PrepareMainSquadPanelViewBase : DataBinder<ActMultiV3PrepareMainSquadPanelViewModelProperty>
	{
		// Token: 0x06028E4C RID: 167500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E4C")]
		[Address(RVA = "0x245BA80", Offset = "0x245A680", VA = "0x18245BA80")]
		protected void SetVisible(bool v)
		{
		}

		// Token: 0x06028E4D RID: 167501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E4D")]
		[Address(RVA = "0x245B9F0", Offset = "0x245A5F0", VA = "0x18245B9F0")]
		public void ResetVisible(bool v)
		{
		}

		// Token: 0x06028E4E RID: 167502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E4E")]
		[Address(RVA = "0x245BB50", Offset = "0x245A750", VA = "0x18245BB50")]
		private void _InitVisibleSwitch()
		{
		}

		// Token: 0x06028E4F RID: 167503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E4F")]
		[Address(RVA = "0x245B950", Offset = "0x245A550", VA = "0x18245B950", Slot = "8")]
		protected virtual void OnPlayEntryEntry()
		{
		}

		// Token: 0x06028E50 RID: 167504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E50")]
		[Address(RVA = "0x245BC40", Offset = "0x245A840", VA = "0x18245BC40")]
		protected ActMultiV3PrepareMainSquadPanelViewBase()
		{
		}

		// Token: 0x0403A55A RID: 238938
		[Token(Token = "0x403A55A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403A55B RID: 238939
		[Token(Token = "0x403A55B")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x0403A55C RID: 238940
		[Token(Token = "0x403A55C")]
		private const float FADE_DUR = 0.5f;

		// Token: 0x0403A55D RID: 238941
		[Token(Token = "0x403A55D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x0403A55E RID: 238942
		[Token(Token = "0x403A55E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetVisible;

		// Token: 0x0403A55F RID: 238943
		[Token(Token = "0x403A55F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitVisibleSwitch;

		// Token: 0x0403A560 RID: 238944
		[Token(Token = "0x403A560")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPlayEntryEntry;

		// Token: 0x0403A561 RID: 238945
		[Token(Token = "0x403A561")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
