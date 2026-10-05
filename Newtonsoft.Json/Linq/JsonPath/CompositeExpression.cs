using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	[Preserve]
	internal class CompositeExpression : QueryExpression
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C2")]
		public List<QueryExpression> Expressions
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x4DDE9D0", Offset = "0x4DDD5D0", VA = "0x184DDE9D0")]
		public CompositeExpression()
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x4DDE700", Offset = "0x4DDD300", VA = "0x184DDE700", Slot = "4")]
		public override bool IsMatch(JToken t)
		{
			return default(bool);
		}
	}
}
