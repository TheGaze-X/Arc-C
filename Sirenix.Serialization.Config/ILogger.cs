using System;
using Il2CppDummyDll;

namespace Sirenix.Serialization
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public interface ILogger
	{
		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		void LogWarning(string warning);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		void LogError(string error);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		void LogException(Exception exception);
	}
}
