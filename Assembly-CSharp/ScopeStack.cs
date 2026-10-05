using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public class ScopeStack<T>
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600007D RID: 125 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x17000018")]
	public int Count
	{
		[Token(Token = "0x600007D")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000019 RID: 25
	[Token(Token = "0x17000019")]
	public ScopeStack<T>.Scope<T> this[int index]
	{
		[Token(Token = "0x600007E")]
		get
		{
			return default(ScopeStack<T>.Scope<T>);
		}
		[Token(Token = "0x600007F")]
		set
		{
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	public T PeekScopeValue(T defaultValue)
	{
		return null;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	public T GetScopeValue(int index)
	{
		return null;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x6000082")]
	public bool TryPeekScopeValue(out T result)
	{
		return default(bool);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x6000083")]
	public ScopeStack<T>.Scope<T> PushScopeValue(T value)
	{
		return default(ScopeStack<T>.Scope<T>);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000084")]
	public void PopScope()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000085")]
	public ScopeStack()
	{
	}

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x0")]
	private List<ScopeStack<T>.Scope<T>> m_scopeStack;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x0")]
	public Action<T> onBeforePop;

	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public struct Scope<TValue> : IDisposable
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000086")]
		public void Dispose()
		{
		}

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		public TValue value;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x0")]
		internal ScopeStack<TValue> stackRef;
	}
}
