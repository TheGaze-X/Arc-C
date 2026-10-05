using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	public abstract class TransitionEventBase<T> : EventBase<T> where T : TransitionEventBase<T>, new()
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x170002FA")]
		public StylePropertyNameCollection stylePropertyNames
		{
			[Token(Token = "0x6000D0F")]
			[CompilerGenerated]
			get
			{
				return default(StylePropertyNameCollection);
			}
		}

		// Token: 0x170002FB RID: 763
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FB")]
		protected double elapsedTime
		{
			[Token(Token = "0x6000D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D11")]
		protected TransitionEventBase()
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D12")]
		protected override void Init()
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D13")]
		private void LocalInit()
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D14")]
		public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime)
		{
			return null;
		}
	}
}
