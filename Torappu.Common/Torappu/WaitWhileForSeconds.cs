using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public class WaitWhileForSeconds : CustomYieldInstruction
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x17000090")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x552C2B0", Offset = "0x552AEB0", VA = "0x18552C2B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x17000091")]
		public float endTime
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x552C260", Offset = "0x552AE60", VA = "0x18552C260")]
		public WaitWhileForSeconds(Func<bool> predicate, float time)
		{
		}

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x10")]
		private float m_endTime;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x18")]
		private Func<bool> m_predicate;
	}
}
