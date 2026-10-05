using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BCE RID: 31694
	[Token(Token = "0x2007BCE")]
	public interface ISerializationCallbacks
	{
		// Token: 0x0602C5C5 RID: 181701
		[Token(Token = "0x602C5C5")]
		void OnBeforeSerialize();

		// Token: 0x0602C5C6 RID: 181702
		[Token(Token = "0x602C5C6")]
		void OnAfterSerialize();

		// Token: 0x0602C5C7 RID: 181703
		[Token(Token = "0x602C5C7")]
		void OnBeforeDeserialize();

		// Token: 0x0602C5C8 RID: 181704
		[Token(Token = "0x602C5C8")]
		void OnAfterDeserialize();
	}
}
