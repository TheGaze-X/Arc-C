using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EB RID: 1003
	[Token(Token = "0x20003EB")]
	[System.CLSCompliant(false)]
	public interface IFormatterConverter
	{
		// Token: 0x06001F6C RID: 8044
		[Token(Token = "0x6001F6C")]
		object Convert(object value, System.Type type);

		// Token: 0x06001F6D RID: 8045
		[Token(Token = "0x6001F6D")]
		bool ToBoolean(object value);

		// Token: 0x06001F6E RID: 8046
		[Token(Token = "0x6001F6E")]
		int ToInt32(object value);

		// Token: 0x06001F6F RID: 8047
		[Token(Token = "0x6001F6F")]
		long ToInt64(object value);

		// Token: 0x06001F70 RID: 8048
		[Token(Token = "0x6001F70")]
		float ToSingle(object value);

		// Token: 0x06001F71 RID: 8049
		[Token(Token = "0x6001F71")]
		string ToString(object value);
	}
}
