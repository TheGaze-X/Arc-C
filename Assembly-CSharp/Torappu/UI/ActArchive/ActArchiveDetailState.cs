using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C6A RID: 27754
	[Token(Token = "0x2006C6A")]
	public class ActArchiveDetailState : PopupFloatState
	{
		// Token: 0x060279C7 RID: 162247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279C7")]
		[Address(RVA = "0x22BE9D0", Offset = "0x22BD5D0", VA = "0x1822BE9D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060279C8 RID: 162248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279C8")]
		[Address(RVA = "0x22BE590", Offset = "0x22BD190", VA = "0x1822BE590", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060279C9 RID: 162249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279C9")]
		[Address(RVA = "0x22BE100", Offset = "0x22BCD00", VA = "0x1822BE100", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060279CA RID: 162250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279CA")]
		[Address(RVA = "0x22BE3D0", Offset = "0x22BCFD0", VA = "0x1822BE3D0")]
		public void OnBackClick()
		{
		}

		// Token: 0x060279CB RID: 162251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279CB")]
		[Address(RVA = "0x22BE760", Offset = "0x22BD360", VA = "0x1822BE760", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060279CC RID: 162252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279CC")]
		[Address(RVA = "0x22BE160", Offset = "0x22BCD60", VA = "0x1822BE160", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060279CD RID: 162253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279CD")]
		[Address(RVA = "0x22BE8A0", Offset = "0x22BD4A0", VA = "0x1822BE8A0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060279CE RID: 162254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279CE")]
		[Address(RVA = "0x22BE2A0", Offset = "0x22BCEA0", VA = "0x1822BE2A0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060279CF RID: 162255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279CF")]
		[Address(RVA = "0x22BEAF0", Offset = "0x22BD6F0", VA = "0x1822BEAF0")]
		public ActArchiveDetailState()
		{
		}

		// Token: 0x060279D0 RID: 162256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279D0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060279D1 RID: 162257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279D1")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x060279D2 RID: 162258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279D2")]
		[Address(RVA = "0x15A4170", Offset = "0x15A2D70", VA = "0x1815A4170")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x060279D3 RID: 162259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279D3")]
		[Address(RVA = "0x15A4200", Offset = "0x15A2E00", VA = "0x1815A4200")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x060279D4 RID: 162260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279D4")]
		[Address(RVA = "0x15A41A0", Offset = "0x15A2DA0", VA = "0x1815A41A0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x040382F3 RID: 230131
		[Token(Token = "0x40382F3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x040382F4 RID: 230132
		[Token(Token = "0x40382F4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActArchiveStateBean _stateBean;

		// Token: 0x040382F5 RID: 230133
		[Token(Token = "0x40382F5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x040382F6 RID: 230134
		[Token(Token = "0x40382F6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ActArchiveCompDataBinder _compBinder;

		// Token: 0x040382F7 RID: 230135
		[Token(Token = "0x40382F7")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x040382F8 RID: 230136
		[Token(Token = "0x40382F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040382F9 RID: 230137
		[Token(Token = "0x40382F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040382FA RID: 230138
		[Token(Token = "0x40382FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040382FB RID: 230139
		[Token(Token = "0x40382FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x040382FC RID: 230140
		[Token(Token = "0x40382FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040382FD RID: 230141
		[Token(Token = "0x40382FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040382FE RID: 230142
		[Token(Token = "0x40382FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040382FF RID: 230143
		[Token(Token = "0x40382FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04038300 RID: 230144
		[Token(Token = "0x4038300")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
