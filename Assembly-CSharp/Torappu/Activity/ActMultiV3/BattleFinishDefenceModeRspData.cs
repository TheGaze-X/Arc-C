using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ECF RID: 28367
	[Token(Token = "0x2006ECF")]
	public class BattleFinishDefenceModeRspData
	{
		// Token: 0x06028546 RID: 165190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028546")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFinishDefenceModeRspData()
		{
		}

		// Token: 0x04039535 RID: 234805
		[Token(Token = "0x4039535")]
		[FieldOffset(Offset = "0x10")]
		public int damage;

		// Token: 0x04039536 RID: 234806
		[Token(Token = "0x4039536")]
		[FieldOffset(Offset = "0x14")]
		public int damagePct;

		// Token: 0x04039537 RID: 234807
		[Token(Token = "0x4039537")]
		[FieldOffset(Offset = "0x18")]
		public bool bossKill;

		// Token: 0x04039538 RID: 234808
		[Token(Token = "0x4039538")]
		[FieldOffset(Offset = "0x20")]
		public List<BattleFinishDefenceModeRspData.ProgressRspData> targets;

		// Token: 0x04039539 RID: 234809
		[Token(Token = "0x4039539")]
		[FieldOffset(Offset = "0x28")]
		public bool newStar;

		// Token: 0x0403953A RID: 234810
		[Token(Token = "0x403953A")]
		[FieldOffset(Offset = "0x29")]
		public bool newDamage;

		// Token: 0x02006ED0 RID: 28368
		[Token(Token = "0x2006ED0")]
		public class ProgressRspData
		{
			// Token: 0x06028547 RID: 165191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028547")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProgressRspData()
			{
			}

			// Token: 0x0403953B RID: 234811
			[Token(Token = "0x403953B")]
			[FieldOffset(Offset = "0x10")]
			public bool complete;

			// Token: 0x0403953C RID: 234812
			[Token(Token = "0x403953C")]
			[FieldOffset(Offset = "0x18")]
			public List<float> progressValue;
		}
	}
}
