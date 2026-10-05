using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200219C RID: 8604
	[Token(Token = "0x200219C")]
	public class BossRushSchedulerPreprocessor : Scheduler.SchedulerPreprocessor
	{
		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x0600D52A RID: 54570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019D7")]
		public List<LevelData.WaveData> waveDatas
		{
			[Token(Token = "0x600D52A")]
			[Address(RVA = "0x3589EA0", Offset = "0x3588AA0", VA = "0x183589EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D52B RID: 54571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D52B")]
		[Address(RVA = "0x3589A80", Offset = "0x3588680", VA = "0x183589A80", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D52C")]
		[Address(RVA = "0x3589A20", Offset = "0x3588620", VA = "0x183589A20", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600D52D RID: 54573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D52D")]
		[Address(RVA = "0x3589DF0", Offset = "0x35889F0", VA = "0x183589DF0")]
		public BossRushSchedulerPreprocessor()
		{
		}

		// Token: 0x0400E4B3 RID: 58547
		[Token(Token = "0x400E4B3")]
		[FieldOffset(Offset = "0x10")]
		private List<LevelData.WaveData> m_waveDatas;

		// Token: 0x0400E4B4 RID: 58548
		[Token(Token = "0x400E4B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waveDatas;

		// Token: 0x0400E4B5 RID: 58549
		[Token(Token = "0x400E4B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x0400E4B6 RID: 58550
		[Token(Token = "0x400E4B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400E4B7 RID: 58551
		[Token(Token = "0x400E4B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
