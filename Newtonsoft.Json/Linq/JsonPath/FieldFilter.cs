using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[Preserve]
	internal class FieldFilter : PathFilter
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BA")]
		public string Name
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x4DDEB90", Offset = "0x4DDD790", VA = "0x184DDEB90", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FieldFilter()
		{
		}
	}
}
