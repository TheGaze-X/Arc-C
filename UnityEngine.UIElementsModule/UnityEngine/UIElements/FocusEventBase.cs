using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	public abstract class FocusEventBase<T> : EventBase<T> where T : FocusEventBase<T>, new()
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000285")]
		public Focusable relatedTarget
		{
			[Token(Token = "0x6000B87")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000286")]
		public FocusChangeDirection direction
		{
			[Token(Token = "0x6000B89")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000287")]
		private protected FocusController focusController
		{
			[Token(Token = "0x6000B8B")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000B8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00006168 File Offset: 0x00004368
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000288")]
		internal bool IsFocusDelegated
		{
			[Token(Token = "0x6000B8D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B8E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8F")]
		protected override void Init()
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B90")]
		private void LocalInit()
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B91")]
		public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false)
		{
			return null;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B92")]
		protected FocusEventBase()
		{
		}
	}
}
