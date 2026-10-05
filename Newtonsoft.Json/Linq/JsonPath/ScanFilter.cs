using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[Preserve]
	internal class ScanFilter : PathFilter
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C8")]
		public string Name
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x4DEB2C0", Offset = "0x4DE9EC0", VA = "0x184DEB2C0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ScanFilter()
		{
		}
	}
}
