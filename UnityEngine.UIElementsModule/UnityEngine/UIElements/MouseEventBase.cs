using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal where T : MouseEventBase<T>, new()
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00006348 File Offset: 0x00004548
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A7")]
		public EventModifiers modifiers
		{
			[Token(Token = "0x6000BEB")]
			[CompilerGenerated]
			get
			{
				return EventModifiers.None;
			}
			[Token(Token = "0x6000BEC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00006360 File Offset: 0x00004560
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		public Vector2 mousePosition
		{
			[Token(Token = "0x6000BED")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000BEE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A9")]
		public Vector2 localMousePosition
		{
			[Token(Token = "0x6000BEF")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000BF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00006390 File Offset: 0x00004590
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		public Vector2 mouseDelta
		{
			[Token(Token = "0x6000BF1")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000BF2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		public int clickCount
		{
			[Token(Token = "0x6000BF3")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BF4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		public int button
		{
			[Token(Token = "0x6000BF5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BF6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000063D8 File Offset: 0x000045D8
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		public int pressedButtons
		{
			[Token(Token = "0x6000BF7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BF8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x170002AE")]
		public bool shiftKey
		{
			[Token(Token = "0x6000BF9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x170002AF")]
		public bool ctrlKey
		{
			[Token(Token = "0x6000BFA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x170002B0")]
		public bool commandKey
		{
			[Token(Token = "0x6000BFB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x170002B1")]
		public bool altKey
		{
			[Token(Token = "0x6000BFC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00006450 File Offset: 0x00004650
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B2")]
		private bool triggeredByOS
		{
			[Token(Token = "0x6000BFD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BFE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B3")]
		private bool recomputeTopElementUnderMouse
		{
			[Token(Token = "0x6000BFF")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B4")]
		private IPointerEvent sourcePointerEvent
		{
			[Token(Token = "0x6000C01")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C02")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		protected override void Init()
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C04")]
		private void LocalInit()
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B5")]
		public override IEventHandler currentTarget
		{
			[Token(Token = "0x6000C05")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C06")]
			internal set
			{
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		protected internal override void PreDispatch(IPanel panel)
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C08")]
		protected internal override void PostDispatch(IPanel panel)
		{
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C09")]
		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C0A")]
		internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse)
		{
			return null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C0B")]
		public static T GetPooled(IMouseEvent triggerEvent)
		{
			return null;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C0C")]
		protected static T GetPooled(IPointerEvent pointerEvent)
		{
			return null;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0D")]
		protected MouseEventBase()
		{
		}
	}
}
