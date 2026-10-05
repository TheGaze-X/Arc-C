using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	[Preserve]
	internal class ArraySliceFilter : PathFilter
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00005A60 File Offset: 0x00003C60
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B5")]
		public int? Start
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00005A78 File Offset: 0x00003C78
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B6")]
		public int? End
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00005A90 File Offset: 0x00003C90
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B7")]
		public int? Step
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x4DDC810", Offset = "0x4DDB410", VA = "0x184DDC810", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x4DDC8D0", Offset = "0x4DDB4D0", VA = "0x184DDC8D0")]
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			return default(bool);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArraySliceFilter()
		{
		}
	}
}
