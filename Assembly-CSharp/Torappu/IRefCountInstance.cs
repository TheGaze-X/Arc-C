using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	public interface IRefCountInstance
	{
		// Token: 0x06005B9E RID: 23454
		[Token(Token = "0x6005B9E")]
		void Retain();

		// Token: 0x06005B9F RID: 23455
		[Token(Token = "0x6005B9F")]
		void Release();

		// Token: 0x06005BA0 RID: 23456
		[Token(Token = "0x6005BA0")]
		long GetInstSignature();
	}
}
