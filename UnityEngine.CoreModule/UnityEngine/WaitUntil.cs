using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	public sealed class WaitUntil : CustomYieldInstruction
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x1700020D")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x59795B0", Offset = "0x59781B0", VA = "0x1859795B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public WaitUntil(Func<bool> predicate)
		{
		}

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x10")]
		private Func<bool> m_Predicate;
	}
}
