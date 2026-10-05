using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public class CollectionChangeEventArgs : EventArgs
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x513AFA0", Offset = "0x5139BA0", VA = "0x18513AFA0")]
		public CollectionChangeEventArgs(CollectionChangeAction action, object element)
		{
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x170001F3")]
		public virtual CollectionChangeAction Action
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (CollectionChangeAction)0;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F4")]
		public virtual object Element
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
