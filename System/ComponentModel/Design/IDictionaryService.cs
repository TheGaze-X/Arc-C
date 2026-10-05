using System;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public interface IDictionaryService
	{
		// Token: 0x06000F7E RID: 3966
		[Token(Token = "0x6000F7E")]
		object GetValue(object key);

		// Token: 0x06000F7F RID: 3967
		[Token(Token = "0x6000F7F")]
		void SetValue(object key, object value);
	}
}
