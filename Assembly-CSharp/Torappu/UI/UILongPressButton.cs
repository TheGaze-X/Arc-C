using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x0200391E RID: 14622
	[Token(Token = "0x200391E")]
	[Obsolete("Use UILongPressButtonEx instead, please!")]
	public class UILongPressButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler
	{
		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x060171C6 RID: 94662 RVA: 0x00094E00 File Offset: 0x00093000
		// (set) Token: 0x060171C7 RID: 94663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003730")]
		public bool interactable
		{
			[Token(Token = "0x60171C6")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60171C7")]
			[Address(RVA = "0xF78DD0", Offset = "0xF779D0", VA = "0x180F78DD0")]
			set
			{
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x060171C8 RID: 94664 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060171C9 RID: 94665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003731")]
		public Action onClick
		{
			[Token(Token = "0x60171C8")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60171C9")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x060171CA RID: 94666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060171CB RID: 94667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003732")]
		public Func<bool> onLongPress
		{
			[Token(Token = "0x60171CA")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60171CB")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060171CC RID: 94668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171CC")]
		[Address(RVA = "0xF78A20", Offset = "0xF77620", VA = "0x180F78A20", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060171CD RID: 94669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171CD")]
		[Address(RVA = "0xF78A80", Offset = "0xF77680", VA = "0x180F78A80", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060171CE RID: 94670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171CE")]
		[Address(RVA = "0xF78AA0", Offset = "0xF776A0", VA = "0x180F78AA0", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060171CF RID: 94671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171CF")]
		[Address(RVA = "0xF78B00", Offset = "0xF77700", VA = "0x180F78B00")]
		private void Update()
		{
		}

		// Token: 0x060171D0 RID: 94672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171D0")]
		[Address(RVA = "0xF78C90", Offset = "0xF77890", VA = "0x180F78C90")]
		private void _FinishPointDown()
		{
		}

		// Token: 0x060171D1 RID: 94673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171D1")]
		[Address(RVA = "0xF78CC0", Offset = "0xF778C0", VA = "0x180F78CC0")]
		private void _UpdateLongPress()
		{
		}

		// Token: 0x060171D2 RID: 94674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171D2")]
		[Address(RVA = "0xF78D40", Offset = "0xF77940", VA = "0x180F78D40")]
		public UILongPressButton()
		{
		}

		// Token: 0x0401BE62 RID: 114274
		[Token(Token = "0x401BE62")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Millsecs")]
		private int _longPressThreshold;

		// Token: 0x0401BE63 RID: 114275
		[Token(Token = "0x401BE63")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("Millsecs")]
		private int _longPressInterval;

		// Token: 0x0401BE64 RID: 114276
		[Token(Token = "0x401BE64")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isPressing;

		// Token: 0x0401BE65 RID: 114277
		[Token(Token = "0x401BE65")]
		[FieldOffset(Offset = "0x28")]
		private DateTime m_pressStartTime;

		// Token: 0x0401BE66 RID: 114278
		[Token(Token = "0x401BE66")]
		[FieldOffset(Offset = "0x30")]
		private DateTime m_lastLongPressUpdateTime;

		// Token: 0x0401BE67 RID: 114279
		[Token(Token = "0x401BE67")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInteractable;

		// Token: 0x0401BE68 RID: 114280
		[Token(Token = "0x401BE68")]
		[FieldOffset(Offset = "0x3C")]
		private UILongPressButton.State m_state;

		// Token: 0x0200391F RID: 14623
		[Token(Token = "0x200391F")]
		private enum State
		{
			// Token: 0x0401BE6C RID: 114284
			[Token(Token = "0x401BE6C")]
			NONE,
			// Token: 0x0401BE6D RID: 114285
			[Token(Token = "0x401BE6D")]
			CLICK,
			// Token: 0x0401BE6E RID: 114286
			[Token(Token = "0x401BE6E")]
			LONG_PRESS,
			// Token: 0x0401BE6F RID: 114287
			[Token(Token = "0x401BE6F")]
			CANCEL
		}
	}
}
