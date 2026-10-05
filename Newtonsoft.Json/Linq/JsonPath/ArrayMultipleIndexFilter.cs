using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[Preserve]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B2")]
		public List<int> Indexes
		{
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x4DDC750", Offset = "0x4DDB350", VA = "0x184DDC750", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArrayMultipleIndexFilter()
		{
		}
	}
}
