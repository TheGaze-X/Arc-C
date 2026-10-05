using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A01 RID: 14849
	[Token(Token = "0x2003A01")]
	public abstract class UIFloatMask : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x060176F9 RID: 95993 RVA: 0x00096720 File Offset: 0x00094920
		[Token(Token = "0x17003822")]
		public bool isShownOrShowing
		{
			[Token(Token = "0x60176F9")]
			[Address(RVA = "0xFC5210", Offset = "0xFC3E10", VA = "0x180FC5210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060176FA RID: 95994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176FA")]
		[Address(RVA = "0xFC4780", Offset = "0xFC3380", VA = "0x180FC4780")]
		protected void UpdateStates()
		{
		}

		// Token: 0x060176FB RID: 95995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176FB")]
		[Address(RVA = "0xFC4E60", Offset = "0xFC3A60", VA = "0x180FC4E60")]
		private void _ShowCallback()
		{
		}

		// Token: 0x060176FC RID: 95996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176FC")]
		[Address(RVA = "0xFC4DC0", Offset = "0xFC39C0", VA = "0x180FC4DC0")]
		private void _HideCallback()
		{
		}

		// Token: 0x060176FD RID: 95997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176FD")]
		[Address(RVA = "0xFC4520", Offset = "0xFC3120", VA = "0x180FC4520")]
		protected void PumpEvent(UIFloatMask.OptType evtType, Action callback)
		{
		}

		// Token: 0x060176FE RID: 95998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176FE")]
		[Address(RVA = "0xFC4710", Offset = "0xFC3310", VA = "0x180FC4710")]
		public void Show([Optional] Action callback)
		{
		}

		// Token: 0x060176FF RID: 95999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176FF")]
		[Address(RVA = "0xFC43F0", Offset = "0xFC2FF0", VA = "0x180FC43F0")]
		public void Hide([Optional] Action callback)
		{
		}

		// Token: 0x06017700 RID: 96000
		[Token(Token = "0x6017700")]
		protected abstract IEnumerator ShowCoroutine();

		// Token: 0x06017701 RID: 96001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017701")]
		[Address(RVA = "0xFC44C0", Offset = "0xFC30C0", VA = "0x180FC44C0", Slot = "5")]
		protected virtual void OnShow()
		{
		}

		// Token: 0x06017702 RID: 96002
		[Token(Token = "0x6017702")]
		protected abstract IEnumerator HideCoroutine();

		// Token: 0x06017703 RID: 96003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017703")]
		[Address(RVA = "0xFC4460", Offset = "0xFC3060", VA = "0x180FC4460", Slot = "7")]
		protected virtual void OnHide()
		{
		}

		// Token: 0x06017704 RID: 96004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017704")]
		[Address(RVA = "0xFC4C80", Offset = "0xFC3880", VA = "0x180FC4C80")]
		private void _DoShowEffect()
		{
		}

		// Token: 0x06017705 RID: 96005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017705")]
		[Address(RVA = "0xFC4B50", Offset = "0xFC3750", VA = "0x180FC4B50")]
		private void _DoHideEffect()
		{
		}

		// Token: 0x06017706 RID: 96006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017706")]
		[Address(RVA = "0xFC5050", Offset = "0xFC3C50", VA = "0x180FC5050")]
		private IEnumerator _TriggerShow()
		{
			return null;
		}

		// Token: 0x06017707 RID: 96007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017707")]
		[Address(RVA = "0xFC4EF0", Offset = "0xFC3AF0", VA = "0x180FC4EF0")]
		private IEnumerator _TriggerHide()
		{
			return null;
		}

		// Token: 0x06017708 RID: 96008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017708")]
		[Address(RVA = "0xFC4FA0", Offset = "0xFC3BA0", VA = "0x180FC4FA0")]
		private IEnumerator _TriggerNextFrame(Action call)
		{
			return null;
		}

		// Token: 0x06017709 RID: 96009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017709")]
		[Address(RVA = "0xFC5100", Offset = "0xFC3D00", VA = "0x180FC5100")]
		protected UIFloatMask()
		{
		}

		// Token: 0x0401C504 RID: 115972
		[Token(Token = "0x401C504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Queue<UIFloatMask.OptEvent> m_eventQueue;

		// Token: 0x0401C505 RID: 115973
		[Token(Token = "0x401C505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<UIFloatMask.OptEvent> m_eventBuffer;

		// Token: 0x0401C506 RID: 115974
		[Token(Token = "0x401C506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIFloatMask.MaskState m_state;

		// Token: 0x0401C507 RID: 115975
		[Token(Token = "0x401C507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action m_pendingCallback;

		// Token: 0x0401C508 RID: 115976
		[Token(Token = "0x401C508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_updatingLock;

		// Token: 0x0401C509 RID: 115977
		[Token(Token = "0x401C509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShownOrShowing;

		// Token: 0x0401C50A RID: 115978
		[Token(Token = "0x401C50A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStates;

		// Token: 0x0401C50B RID: 115979
		[Token(Token = "0x401C50B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowCallback;

		// Token: 0x0401C50C RID: 115980
		[Token(Token = "0x401C50C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideCallback;

		// Token: 0x0401C50D RID: 115981
		[Token(Token = "0x401C50D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PumpEvent;

		// Token: 0x0401C50E RID: 115982
		[Token(Token = "0x401C50E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401C50F RID: 115983
		[Token(Token = "0x401C50F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401C510 RID: 115984
		[Token(Token = "0x401C510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401C511 RID: 115985
		[Token(Token = "0x401C511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x0401C512 RID: 115986
		[Token(Token = "0x401C512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoShowEffect;

		// Token: 0x0401C513 RID: 115987
		[Token(Token = "0x401C513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoHideEffect;

		// Token: 0x0401C514 RID: 115988
		[Token(Token = "0x401C514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerShow;

		// Token: 0x0401C515 RID: 115989
		[Token(Token = "0x401C515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TriggerHide;

		// Token: 0x0401C516 RID: 115990
		[Token(Token = "0x401C516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TriggerNextFrame;

		// Token: 0x0401C517 RID: 115991
		[Token(Token = "0x401C517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A02 RID: 14850
		[Token(Token = "0x2003A02")]
		protected enum MaskState
		{
			// Token: 0x0401C519 RID: 115993
			[Token(Token = "0x401C519")]
			SHOWN,
			// Token: 0x0401C51A RID: 115994
			[Token(Token = "0x401C51A")]
			HIDDEN,
			// Token: 0x0401C51B RID: 115995
			[Token(Token = "0x401C51B")]
			SHOWING,
			// Token: 0x0401C51C RID: 115996
			[Token(Token = "0x401C51C")]
			HIDDING
		}

		// Token: 0x02003A03 RID: 14851
		[Token(Token = "0x2003A03")]
		protected enum OptType
		{
			// Token: 0x0401C51E RID: 115998
			[Token(Token = "0x401C51E")]
			SHOW,
			// Token: 0x0401C51F RID: 115999
			[Token(Token = "0x401C51F")]
			HIDE
		}

		// Token: 0x02003A04 RID: 14852
		[Token(Token = "0x2003A04")]
		protected struct OptEvent
		{
			// Token: 0x0401C520 RID: 116000
			[Token(Token = "0x401C520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action callback;

			// Token: 0x0401C521 RID: 116001
			[Token(Token = "0x401C521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UIFloatMask.OptType type;
		}
	}
}
