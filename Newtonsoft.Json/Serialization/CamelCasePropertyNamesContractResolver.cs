using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[Preserve]
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x4D9BE50", Offset = "0x4D9AA50", VA = "0x184D9BE50")]
		public CamelCasePropertyNamesContractResolver()
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4D9BE40", Offset = "0x4D9AA40", VA = "0x184D9BE40", Slot = "21")]
		protected override string ResolvePropertyName(string propertyName)
		{
			return null;
		}
	}
}
