using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent where T : KeyboardEventBase<T>, new()
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000061B0 File Offset: 0x000043B0
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		public EventModifiers modifiers
		{
			[Token(Token = "0x6000BB1")]
			[CompilerGenerated]
			get
			{
				return EventModifiers.None;
			}
			[Token(Token = "0x6000BB2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000061C8 File Offset: 0x000043C8
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		public char character
		{
			[Token(Token = "0x6000BB3")]
			[CompilerGenerated]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000BB4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000061E0 File Offset: 0x000043E0
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		public KeyCode keyCode
		{
			[Token(Token = "0x6000BB5")]
			[CompilerGenerated]
			get
			{
				return KeyCode.None;
			}
			[Token(Token = "0x6000BB6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x17000291")]
		public bool shiftKey
		{
			[Token(Token = "0x6000BB7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x17000292")]
		public bool ctrlKey
		{
			[Token(Token = "0x6000BB8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x17000293")]
		public bool commandKey
		{
			[Token(Token = "0x6000BB9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x17000294")]
		public bool altKey
		{
			[Token(Token = "0x6000BBA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x17000295")]
		public bool actionKey
		{
			[Token(Token = "0x6000BBB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBC")]
		protected override void Init()
		{
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBD")]
		private void LocalInit()
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000BBE")]
		public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers)
		{
			return null;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000BBF")]
		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC0")]
		protected KeyboardEventBase()
		{
		}
	}
}
