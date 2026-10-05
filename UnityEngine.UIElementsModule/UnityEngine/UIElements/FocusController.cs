using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class FocusController
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5A30910", Offset = "0x5A2F510", VA = "0x185A30910")]
		public FocusController(IFocusRing focusRing)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700002F")]
		private IFocusRing focusRing
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000030")]
		public Focusable focusedElement
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x5A309C0", Offset = "0x5A2F5C0", VA = "0x185A309C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5A2FB90", Offset = "0x5A2E790", VA = "0x185A2FB90")]
		internal bool IsFocused(Focusable f)
		{
			return default(bool);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5A2F830", Offset = "0x5A2E430", VA = "0x185A2F830")]
		internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst)
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5A2F760", Offset = "0x5A2E360", VA = "0x185A2F760")]
		internal Focusable GetLeafFocusedElement()
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5A2FCE0", Offset = "0x5A2E8E0", VA = "0x185A2FCE0")]
		private bool IsLocalElement(Focusable f)
		{
			return default(bool);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5A2FD40", Offset = "0x5A2E940", VA = "0x185A2FD40")]
		internal bool IsPendingFocus(Focusable f)
		{
			return default(bool);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5A30080", Offset = "0x5A2EC80", VA = "0x185A30080")]
		internal void SetFocusToLastFocusedElement()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5A2F100", Offset = "0x5A2DD00", VA = "0x185A2F100")]
		internal void BlurLastFocusedElement()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x5A2F300", Offset = "0x5A2DF00", VA = "0x185A2F300")]
		internal void DoFocusChange(Focusable f)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5A2F4D0", Offset = "0x5A2E0D0", VA = "0x185A2F4D0")]
		internal Focusable FocusNextInDirection(FocusChangeDirection direction)
		{
			return null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x5A2EFD0", Offset = "0x5A2DBD0", VA = "0x185A2EFD0")]
		private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x5A2FF50", Offset = "0x5A2EB50", VA = "0x185A2FF50")]
		private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x5A2EEA0", Offset = "0x5A2DAA0", VA = "0x185A2EEA0")]
		private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x5A2FA60", Offset = "0x5A2E660", VA = "0x185A2FA60")]
		private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5A2F1E0", Offset = "0x5A2DDE0", VA = "0x185A2F1E0")]
		internal void Blur(Focusable focusable, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5A304C0", Offset = "0x5A2F0C0", VA = "0x185A304C0")]
		internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x5A30590", Offset = "0x5A2F190", VA = "0x185A30590")]
		internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x5A30150", Offset = "0x5A2ED50", VA = "0x185A30150")]
		internal Focusable SwitchFocusOnEvent(EventBase e)
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x5A2FE30", Offset = "0x5A2EA30", VA = "0x185A2FE30")]
		internal void ReevaluateFocus()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x5A2F600", Offset = "0x5A2E200", VA = "0x185A2F600")]
		internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget)
		{
			return default(bool);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		internal int imguiKeyboardControl
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x5A307F0", Offset = "0x5A2F3F0", VA = "0x185A307F0")]
		internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch)
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x18")]
		private List<FocusController.FocusedElement> m_FocusedElements;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		private Focusable m_LastFocusedElement;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		private Focusable m_LastPendingFocusedElement;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x30")]
		private int m_PendingFocusCount;

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		private struct FocusedElement
		{
			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x0")]
			public VisualElement m_SubTreeRoot;

			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x8")]
			public Focusable m_FocusedElement;
		}
	}
}
