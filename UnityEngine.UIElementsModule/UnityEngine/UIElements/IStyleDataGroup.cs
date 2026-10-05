using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	internal interface IStyleDataGroup<T>
	{
		// Token: 0x06001099 RID: 4249
		[Token(Token = "0x6001099")]
		T Copy();

		// Token: 0x0600109A RID: 4250
		[Token(Token = "0x600109A")]
		void CopyFrom(ref T other);
	}
}
