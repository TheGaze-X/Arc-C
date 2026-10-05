using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B74 RID: 31604
	[Token(Token = "0x2007B74")]
	public interface fsISerializationCallbacks
	{
		// Token: 0x0602C3AD RID: 181165
		[Token(Token = "0x602C3AD")]
		void OnBeforeSerialize(Type storageType);

		// Token: 0x0602C3AE RID: 181166
		[Token(Token = "0x602C3AE")]
		void OnAfterSerialize(Type storageType, ref fsData data);

		// Token: 0x0602C3AF RID: 181167
		[Token(Token = "0x602C3AF")]
		void OnBeforeDeserialize(Type storageType, ref fsData data);

		// Token: 0x0602C3B0 RID: 181168
		[Token(Token = "0x602C3B0")]
		void OnAfterDeserialize(Type storageType);
	}
}
