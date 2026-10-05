using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Hypergryph.ToolKits
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public static class GenericPool<T> where T : class, new()
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x6000470")]
		public static GenericPool<T>.Ref GetRef()
		{
			return default(GenericPool<T>.Ref);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		public static T Get()
		{
			return null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000472")]
		public static void Release(T obj)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x6000473")]
		public static int InactiveObjectCount()
		{
			return 0;
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool s_Pool;

		// Token: 0x020000FF RID: 255
		[Token(Token = "0x20000FF")]
		public struct Ref : IDisposable
		{
			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000476 RID: 1142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700008D")]
			public T inst
			{
				[Token(Token = "0x6000475")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000476")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000477")]
			public Ref(T inst)
			{
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000478")]
			public void Dispose()
			{
			}

			// Token: 0x040005D8 RID: 1496
			[Token(Token = "0x40005D8")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> resetCallback;
		}
	}
}
