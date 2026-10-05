using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B6B RID: 31595
	[Token(Token = "0x2007B6B")]
	public sealed class fsContext
	{
		// Token: 0x0602C379 RID: 181113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C379")]
		[Address(RVA = "0x2822EC0", Offset = "0x2821AC0", VA = "0x182822EC0")]
		public void Reset()
		{
		}

		// Token: 0x0602C37A RID: 181114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C37A")]
		public void Set<T>(T obj)
		{
		}

		// Token: 0x0602C37B RID: 181115 RVA: 0x000DE708 File Offset: 0x000DC908
		[Token(Token = "0x602C37B")]
		public bool Has<T>()
		{
			return default(bool);
		}

		// Token: 0x0602C37C RID: 181116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C37C")]
		public T Get<T>()
		{
			return null;
		}

		// Token: 0x0602C37D RID: 181117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C37D")]
		[Address(RVA = "0x2822F10", Offset = "0x2821B10", VA = "0x182822F10")]
		public fsContext()
		{
		}

		// Token: 0x0404019A RID: 262554
		[Token(Token = "0x404019A")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Type, object> _contextObjects;
	}
}
