using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[Preserve]
	public interface IValueProvider
	{
		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x600053A")]
		void SetValue(object target, object value);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x600053B")]
		object GetValue(object target);
	}
}
