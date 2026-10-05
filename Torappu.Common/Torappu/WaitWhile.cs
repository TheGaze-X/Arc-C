using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0000671C File Offset: 0x0000491C
		[Token(Token = "0x1700008F")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x28A1C10", Offset = "0x28A0810", VA = "0x1828A1C10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public WaitWhile(Func<bool> predicate)
		{
		}

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x10")]
		private Func<bool> m_predicate;
	}
}
