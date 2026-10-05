using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D78 RID: 28024
	[Token(Token = "0x2006D78")]
	public class ActCommonFavorUpStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06027EDD RID: 163549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EDD")]
		[Address(RVA = "0x232CB00", Offset = "0x232B700", VA = "0x18232CB00")]
		public ActCommonFavorUpStateBean()
		{
		}

		// Token: 0x04038977 RID: 231799
		[Token(Token = "0x4038977")]
		[FieldOffset(Offset = "0x10")]
		public ActCommonFavorUpStateBean.Input input;

		// Token: 0x04038978 RID: 231800
		[Token(Token = "0x4038978")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D79 RID: 28025
		[Token(Token = "0x2006D79")]
		public class Input
		{
			// Token: 0x06027EDE RID: 163550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027EDE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04038979 RID: 231801
			[Token(Token = "0x4038979")]
			[FieldOffset(Offset = "0x10")]
			public List<string> charIdList;

			// Token: 0x0403897A RID: 231802
			[Token(Token = "0x403897A")]
			[FieldOffset(Offset = "0x18")]
			public string actId;
		}
	}
}
