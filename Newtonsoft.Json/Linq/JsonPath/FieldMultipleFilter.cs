using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[Preserve]
	internal class FieldMultipleFilter : PathFilter
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BD")]
		public List<string> Names
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x4DDEC50", Offset = "0x4DDD850", VA = "0x184DDEC50", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FieldMultipleFilter()
		{
		}
	}
}
