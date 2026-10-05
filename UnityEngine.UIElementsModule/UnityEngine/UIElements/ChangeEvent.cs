using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class ChangeEvent<T> : EventBase<ChangeEvent<T>>
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025E")]
		public T previousValue
		{
			[Token(Token = "0x6000AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE1")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025F")]
		public T newValue
		{
			[Token(Token = "0x6000AE2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE3")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE4")]
		protected override void Init()
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE5")]
		private void LocalInit()
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AE6")]
		public static ChangeEvent<T> GetPooled(T previousValue, T newValue)
		{
			return null;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE7")]
		public ChangeEvent()
		{
		}
	}
}
