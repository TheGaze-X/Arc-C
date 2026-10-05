using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020B")]
		public float waitTime
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x1700020C")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x5979500", Offset = "0x5978100", VA = "0x185979500", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x59794D0", Offset = "0x59780D0", VA = "0x1859794D0")]
		public WaitForSecondsRealtime(float time)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x59794C0", Offset = "0x59780C0", VA = "0x1859794C0", Slot = "8")]
		public override void Reset()
		{
		}

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x14")]
		private float m_WaitUntilTime;
	}
}
