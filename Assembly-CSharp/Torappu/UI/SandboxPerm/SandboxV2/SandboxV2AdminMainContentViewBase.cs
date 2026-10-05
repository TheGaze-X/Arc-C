using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200405B RID: 16475
	[Token(Token = "0x200405B")]
	public abstract class SandboxV2AdminMainContentViewBase<PropType> : DataBinder<PropType>, IHotfixable where PropType : IBindProperty
	{
		// Token: 0x060197C7 RID: 104391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197C7")]
		protected void SetShow(bool show, bool skipTween = false)
		{
		}

		// Token: 0x060197C8 RID: 104392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197C8")]
		protected virtual void OnShow()
		{
		}

		// Token: 0x060197C9 RID: 104393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197C9")]
		protected virtual void OnHide()
		{
		}

		// Token: 0x060197CA RID: 104394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197CA")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x060197CB RID: 104395 RVA: 0x0009E4D8 File Offset: 0x0009C6D8
		[Token(Token = "0x17003CB3")]
		protected bool tutorialOnly_isTweening
		{
			[Token(Token = "0x60197CB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060197CC RID: 104396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197CC")]
		protected SandboxV2AdminMainContentViewBase()
		{
		}

		// Token: 0x0401FC39 RID: 130105
		[Token(Token = "0x401FC39")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401FC3A RID: 130106
		[Token(Token = "0x401FC3A")]
		[FieldOffset(Offset = "0x0")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x0401FC3B RID: 130107
		[Token(Token = "0x401FC3B")]
		[FieldOffset(Offset = "0x0")]
		private bool m_cachedShow;

		// Token: 0x0401FC3C RID: 130108
		[Token(Token = "0x401FC3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0401FC3D RID: 130109
		[Token(Token = "0x401FC3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401FC3E RID: 130110
		[Token(Token = "0x401FC3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x0401FC3F RID: 130111
		[Token(Token = "0x401FC3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FC40 RID: 130112
		[Token(Token = "0x401FC40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tutorialOnly_isTweening;

		// Token: 0x0401FC41 RID: 130113
		[Token(Token = "0x401FC41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
