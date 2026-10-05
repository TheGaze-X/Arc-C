using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public abstract class Focusable : CallbackEventHandler
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5A30F40", Offset = "0x5A2FB40", VA = "0x185A30F40")]
		protected Focusable()
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CD RID: 205
		[Token(Token = "0x17000026")]
		public abstract FocusController focusController { [Token(Token = "0x60000CD")] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public bool focusable
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public int tabIndex
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public bool delegatesFocus
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x5A30F70", Offset = "0x5A2FB70", VA = "0x185A30F70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x5A30F90", Offset = "0x5A2FB90", VA = "0x185A30F90")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002538 File Offset: 0x00000738
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		internal bool excludeFromFocusRing
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x5A30F80", Offset = "0x5A2FB80", VA = "0x185A30F80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x5A31130", Offset = "0x5A2FD30", VA = "0x185A31130")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x1700002B")]
		public virtual bool canGrabFocus
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5A30B70", Offset = "0x5A2F770", VA = "0x185A30B70", Slot = "17")]
		public virtual void Focus()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5A30A90", Offset = "0x5A2F690", VA = "0x185A30A90", Slot = "18")]
		public virtual void Blur()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5A30A30", Offset = "0x5A2F630", VA = "0x185A30A30")]
		internal void BlurImmediately()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5A30E40", Offset = "0x5A2FA40", VA = "0x185A30E40")]
		private Focusable GetFocusDelegate()
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x5A30CF0", Offset = "0x5A2F8F0", VA = "0x185A30CF0")]
		private static Focusable GetFirstFocusableChild(VisualElement ve)
		{
			return null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5A30AF0", Offset = "0x5A2F6F0", VA = "0x185A30AF0", Slot = "12")]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5A30AF0", Offset = "0x5A2F6F0", VA = "0x185A30AF0", Slot = "14")]
		internal override void ExecuteDefaultActionDisabled(EventBase evt)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5A30ED0", Offset = "0x5A2FAD0", VA = "0x185A30ED0")]
		private void ProcessEvent(EventBase evt)
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		private bool m_DelegatesFocus;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x21")]
		private bool m_ExcludeFromFocusRing;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x22")]
		internal bool isIMGUIContainer;
	}
}
