using System;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public interface IReferenceService
	{
		// Token: 0x06000F81 RID: 3969
		[Token(Token = "0x6000F81")]
		object GetReference(string name);

		// Token: 0x06000F82 RID: 3970
		[Token(Token = "0x6000F82")]
		string GetName(object reference);

		// Token: 0x06000F83 RID: 3971
		[Token(Token = "0x6000F83")]
		object[] GetReferences(Type baseType);
	}
}
