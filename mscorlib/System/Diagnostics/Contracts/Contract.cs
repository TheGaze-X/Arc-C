using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System.Diagnostics.Contracts
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	public static class Contract
	{
		// Token: 0x06002B66 RID: 11110 RVA: 0x00018000 File Offset: 0x00016200
		[Token(Token = "0x6002B66")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static bool ForAll<T>(System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> predicate)
		{
			return default(bool);
		}
	}
}
