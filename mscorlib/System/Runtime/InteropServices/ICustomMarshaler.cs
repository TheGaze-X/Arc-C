using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public interface ICustomMarshaler
	{
		// Token: 0x0600221C RID: 8732
		[Token(Token = "0x600221C")]
		object MarshalNativeToManaged(System.IntPtr pNativeData);

		// Token: 0x0600221D RID: 8733
		[Token(Token = "0x600221D")]
		System.IntPtr MarshalManagedToNative(object ManagedObj);

		// Token: 0x0600221E RID: 8734
		[Token(Token = "0x600221E")]
		void CleanUpNativeData(System.IntPtr pNativeData);

		// Token: 0x0600221F RID: 8735
		[Token(Token = "0x600221F")]
		void CleanUpManagedData(object ManagedObj);

		// Token: 0x06002220 RID: 8736
		[Token(Token = "0x6002220")]
		int GetNativeDataSize();
	}
}
