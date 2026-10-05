using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C83 RID: 31875
	[Token(Token = "0x2007C83")]
	public class fiFactory<T> where T : new()
	{
		// Token: 0x0602C884 RID: 182404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C884")]
		public fiFactory(Action<T> reset, params object[] constructArgs)
		{
		}

		// Token: 0x0602C885 RID: 182405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C885")]
		public T GetInstance()
		{
			return null;
		}

		// Token: 0x0602C886 RID: 182406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C886")]
		public void ReuseInstance(T instance)
		{
		}

		// Token: 0x0404036E RID: 263022
		[Token(Token = "0x404036E")]
		[FieldOffset(Offset = "0x0")]
		private Stack<T> _reusable;

		// Token: 0x0404036F RID: 263023
		[Token(Token = "0x404036F")]
		[FieldOffset(Offset = "0x0")]
		private Action<T> _reset;

		// Token: 0x04040370 RID: 263024
		[Token(Token = "0x4040370")]
		[FieldOffset(Offset = "0x0")]
		private object[] _constructArgs;
	}
}
