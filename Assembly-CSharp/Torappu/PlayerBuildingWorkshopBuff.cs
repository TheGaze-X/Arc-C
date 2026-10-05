using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A58 RID: 2648
	[Token(Token = "0x2000A58")]
	public class PlayerBuildingWorkshopBuff
	{
		// Token: 0x06006717 RID: 26391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006717")]
		[Address(RVA = "0x1EF2210", Offset = "0x1EF0E10", VA = "0x181EF2210")]
		public PlayerBuildingWorkshopBuff()
		{
		}

		// Token: 0x0400385F RID: 14431
		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, float> rate;

		// Token: 0x04003860 RID: 14432
		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Dictionary<string, float>> apRate;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x20")]
		public List<PlayerBuildingWorkshopBuff.Frate> frate;

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, int> goldFree;

		// Token: 0x04003863 RID: 14435
		[Token(Token = "0x4003863")]
		[FieldOffset(Offset = "0x30")]
		public PlayerBuildingWorkshopBuff.Cost cost;

		// Token: 0x04003864 RID: 14436
		[Token(Token = "0x4003864")]
		[FieldOffset(Offset = "0x38")]
		public PlayerBuildingWorkshopBuff.CostRe costRe;

		// Token: 0x04003865 RID: 14437
		[Token(Token = "0x4003865")]
		[FieldOffset(Offset = "0x40")]
		public PlayerBuildingWorkshopBuff.CostFormula costFormula;

		// Token: 0x04003866 RID: 14438
		[Token(Token = "0x4003866")]
		[FieldOffset(Offset = "0x48")]
		public PlayerBuildingWorkshopBuff.CostForce costForce;

		// Token: 0x04003867 RID: 14439
		[Token(Token = "0x4003867")]
		[FieldOffset(Offset = "0x50")]
		public PlayerBuildingWorkshopBuff.CostDevide costDevide;

		// Token: 0x02000A59 RID: 2649
		[Token(Token = "0x2000A59")]
		public class Cost
		{
			// Token: 0x06006718 RID: 26392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006718")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Cost()
			{
			}

			// Token: 0x04003868 RID: 14440
			[Token(Token = "0x4003868")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x04003869 RID: 14441
			[Token(Token = "0x4003869")]
			[FieldOffset(Offset = "0x18")]
			public long limit;

			// Token: 0x0400386A RID: 14442
			[Token(Token = "0x400386A")]
			[FieldOffset(Offset = "0x20")]
			public long reduction;
		}

		// Token: 0x02000A5A RID: 2650
		[Token(Token = "0x2000A5A")]
		public class CostRe
		{
			// Token: 0x06006719 RID: 26393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006719")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CostRe()
			{
			}

			// Token: 0x0400386B RID: 14443
			[Token(Token = "0x400386B")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x0400386C RID: 14444
			[Token(Token = "0x400386C")]
			[FieldOffset(Offset = "0x18")]
			public long from;

			// Token: 0x0400386D RID: 14445
			[Token(Token = "0x400386D")]
			[FieldOffset(Offset = "0x20")]
			public long change;
		}

		// Token: 0x02000A5B RID: 2651
		[Token(Token = "0x2000A5B")]
		public class CostFormula
		{
			// Token: 0x0600671A RID: 26394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600671A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CostFormula()
			{
			}

			// Token: 0x0400386E RID: 14446
			[Token(Token = "0x400386E")]
			[FieldOffset(Offset = "0x10")]
			public List<string> formulaIds;

			// Token: 0x0400386F RID: 14447
			[Token(Token = "0x400386F")]
			[FieldOffset(Offset = "0x18")]
			public long reduction;
		}

		// Token: 0x02000A5C RID: 2652
		[Token(Token = "0x2000A5C")]
		public class CostForce
		{
			// Token: 0x0600671B RID: 26395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600671B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CostForce()
			{
			}

			// Token: 0x04003870 RID: 14448
			[Token(Token = "0x4003870")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x04003871 RID: 14449
			[Token(Token = "0x4003871")]
			[FieldOffset(Offset = "0x18")]
			public long cost;
		}

		// Token: 0x02000A5D RID: 2653
		[Token(Token = "0x2000A5D")]
		public class CostDevide
		{
			// Token: 0x0600671C RID: 26396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600671C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CostDevide()
			{
			}

			// Token: 0x04003872 RID: 14450
			[Token(Token = "0x4003872")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x04003873 RID: 14451
			[Token(Token = "0x4003873")]
			[FieldOffset(Offset = "0x18")]
			public long limit;

			// Token: 0x04003874 RID: 14452
			[Token(Token = "0x4003874")]
			[FieldOffset(Offset = "0x20")]
			public long denominator;
		}

		// Token: 0x02000A5E RID: 2654
		[Token(Token = "0x2000A5E")]
		public class Frate
		{
			// Token: 0x0600671D RID: 26397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600671D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Frate()
			{
			}

			// Token: 0x04003875 RID: 14453
			[Token(Token = "0x4003875")]
			[FieldOffset(Offset = "0x10")]
			public string fid;

			// Token: 0x04003876 RID: 14454
			[Token(Token = "0x4003876")]
			[FieldOffset(Offset = "0x18")]
			public float rate;
		}
	}
}
