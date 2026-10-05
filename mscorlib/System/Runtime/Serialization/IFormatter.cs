using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IFormatter
	{
		// Token: 0x06001FCA RID: 8138
		[Token(Token = "0x6001FCA")]
		object Deserialize(System.IO.Stream serializationStream);
	}
}
