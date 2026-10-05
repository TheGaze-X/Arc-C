using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D04 RID: 15620
	[Token(Token = "0x2003D04")]
	public class TuningProductConfirmState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060185C0 RID: 99776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60185C0")]
		[Address(RVA = "0x10DF8C0", Offset = "0x10DE4C0", VA = "0x1810DF8C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060185C1 RID: 99777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C1")]
		[Address(RVA = "0x10DF920", Offset = "0x10DE520", VA = "0x1810DF920", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060185C2 RID: 99778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C2")]
		[Address(RVA = "0x10DFD90", Offset = "0x10DE990", VA = "0x1810DFD90", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060185C3 RID: 99779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60185C3")]
		[Address(RVA = "0x10DFEF0", Offset = "0x10DEAF0", VA = "0x1810DFEF0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060185C4 RID: 99780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C4")]
		[Address(RVA = "0x10E0430", Offset = "0x10DF030", VA = "0x1810E0430")]
		private void _PlayMusic()
		{
		}

		// Token: 0x060185C5 RID: 99781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C5")]
		[Address(RVA = "0x10E01D0", Offset = "0x10DEDD0", VA = "0x1810E01D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060185C6 RID: 99782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C6")]
		[Address(RVA = "0x10E0370", Offset = "0x10DEF70", VA = "0x1810E0370")]
		private void _OnPressBackBtn()
		{
		}

		// Token: 0x060185C7 RID: 99783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C7")]
		[Address(RVA = "0x10E07D0", Offset = "0x10DF3D0", VA = "0x1810E07D0")]
		public TuningProductConfirmState()
		{
		}

		// Token: 0x060185C8 RID: 99784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185C8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060185C9 RID: 99785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60185C9")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0401DC72 RID: 121970
		[Token(Token = "0x401DC72")]
		private const float ENTRY_AUDIO_DELAY = 1.1f;

		// Token: 0x0401DC73 RID: 121971
		[Token(Token = "0x401DC73")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnimLocation;

		// Token: 0x0401DC74 RID: 121972
		[Token(Token = "0x401DC74")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TuningProductConfirmView _confirmView;

		// Token: 0x0401DC75 RID: 121973
		[Token(Token = "0x401DC75")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0401DC76 RID: 121974
		[Token(Token = "0x401DC76")]
		[FieldOffset(Offset = "0x90")]
		private TuningProductConfirmStateBean m_stateBean;

		// Token: 0x0401DC77 RID: 121975
		[Token(Token = "0x401DC77")]
		[FieldOffset(Offset = "0x98")]
		private Sequence m_enterSequence;

		// Token: 0x0401DC78 RID: 121976
		[Token(Token = "0x401DC78")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0401DC79 RID: 121977
		[Token(Token = "0x401DC79")]
		[NonSerialized]
		public const int CONFIRM_PRODUCT = 0;

		// Token: 0x0401DC7A RID: 121978
		[Token(Token = "0x401DC7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DC7B RID: 121979
		[Token(Token = "0x401DC7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DC7C RID: 121980
		[Token(Token = "0x401DC7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401DC7D RID: 121981
		[Token(Token = "0x401DC7D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401DC7E RID: 121982
		[Token(Token = "0x401DC7E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayMusic;

		// Token: 0x0401DC7F RID: 121983
		[Token(Token = "0x401DC7F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DC80 RID: 121984
		[Token(Token = "0x401DC80")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPressBackBtn;

		// Token: 0x0401DC81 RID: 121985
		[Token(Token = "0x401DC81")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
