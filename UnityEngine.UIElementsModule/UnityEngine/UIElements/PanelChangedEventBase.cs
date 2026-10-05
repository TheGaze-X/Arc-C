using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public abstract class PanelChangedEventBase<T> : EventBase<T> where T : PanelChangedEventBase<T>, new()
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		public IPanel originPanel
		{
			[Token(Token = "0x6000C58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C59")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public IPanel destinationPanel
		{
			[Token(Token = "0x6000C5A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C5B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5C")]
		protected override void Init()
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5D")]
		private void LocalInit()
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C5E")]
		public static T GetPooled(IPanel originPanel, IPanel destinationPanel)
		{
			return null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5F")]
		protected PanelChangedEventBase()
		{
		}
	}
}
