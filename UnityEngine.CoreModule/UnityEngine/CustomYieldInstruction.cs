using System;
using System.Collections;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public abstract class CustomYieldInstruction : IEnumerator
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000954 RID: 2388
		[Token(Token = "0x170001F5")]
		public abstract bool keepWaiting { [Token(Token = "0x6000954")] get; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F6")]
		public object Current
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x592C430", Offset = "0x592B030", VA = "0x18592C430", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x5959E70", Offset = "0x5958A70", VA = "0x185959E70", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void Reset()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CustomYieldInstruction()
		{
		}
	}
}
