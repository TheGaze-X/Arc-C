using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	internal struct CancellationCallbackCoreWorkArguments
	{
		// Token: 0x06001213 RID: 4627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
		public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
		{
		}

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment;

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0x8")]
		internal int _currArrayIndex;
	}
}
