using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	[Preserve]
	internal class ArrayIndexFilter : PathFilter
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00005A18 File Offset: 0x00003C18
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AF")]
		public int? Index
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000973")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x4DDC690", Offset = "0x4DDB290", VA = "0x184DDC690", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArrayIndexFilter()
		{
		}
	}
}
