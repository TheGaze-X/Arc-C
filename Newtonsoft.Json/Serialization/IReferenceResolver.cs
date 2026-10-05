using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	[Preserve]
	public interface IReferenceResolver
	{
		// Token: 0x060005E3 RID: 1507
		[Token(Token = "0x60005E3")]
		object ResolveReference(object context, string reference);

		// Token: 0x060005E4 RID: 1508
		[Token(Token = "0x60005E4")]
		string GetReference(object context, object value);

		// Token: 0x060005E5 RID: 1509
		[Token(Token = "0x60005E5")]
		bool IsReferenced(object context, object value);

		// Token: 0x060005E6 RID: 1510
		[Token(Token = "0x60005E6")]
		void AddReference(object context, string reference, object value);
	}
}
