using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002665 RID: 9829
	[Token(Token = "0x2002665")]
	public abstract class MultiEnterExitHandler<T> where T : class, IPtrObject
	{
		// Token: 0x06010127 RID: 65831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010127")]
		public virtual void Clear()
		{
		}

		// Token: 0x06010128 RID: 65832 RVA: 0x00062250 File Offset: 0x00060450
		[Token(Token = "0x6010128")]
		protected bool Contains(T target)
		{
			return default(bool);
		}

		// Token: 0x06010129 RID: 65833
		[Token(Token = "0x6010129")]
		protected abstract void OnRealEnter(T target);

		// Token: 0x0601012A RID: 65834
		[Token(Token = "0x601012A")]
		protected abstract void OnRealExit(T target);

		// Token: 0x0601012B RID: 65835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601012B")]
		protected void DoMultiEnter(T target)
		{
		}

		// Token: 0x0601012C RID: 65836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601012C")]
		protected void DoMultiExit(T target)
		{
		}

		// Token: 0x0601012D RID: 65837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601012D")]
		protected MultiEnterExitHandler()
		{
		}

		// Token: 0x04011E0C RID: 73228
		[Token(Token = "0x4011E0C")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<ObjectPtr<T>, MultiEnterExitHandler<T>.TargetRef> m_targetMap;

		// Token: 0x02002666 RID: 9830
		[Token(Token = "0x2002666")]
		private class TargetRef
		{
			// Token: 0x0601012E RID: 65838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601012E")]
			public TargetRef()
			{
			}

			// Token: 0x04011E0D RID: 73229
			[Token(Token = "0x4011E0D")]
			[FieldOffset(Offset = "0x0")]
			public int refCnt;
		}
	}
}
