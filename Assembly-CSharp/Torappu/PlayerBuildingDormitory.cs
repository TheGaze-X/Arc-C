using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	public class PlayerBuildingDormitory
	{
		// Token: 0x06006733 RID: 26419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006733")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingDormitory()
		{
		}

		// Token: 0x040038D7 RID: 14551
		[Token(Token = "0x40038D7")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingDormitory.Buff buff;

		// Token: 0x040038D8 RID: 14552
		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x18")]
		public int comfort;

		// Token: 0x040038D9 RID: 14553
		[Token(Token = "0x40038D9")]
		[FieldOffset(Offset = "0x20")]
		public PlayerBuildingDIYSolution diySolution;

		// Token: 0x040038DA RID: 14554
		[Token(Token = "0x40038DA")]
		[FieldOffset(Offset = "0x28")]
		public int[] lockQueue;

		// Token: 0x02000A77 RID: 2679
		[Token(Token = "0x2000A77")]
		public class Buff
		{
			// Token: 0x06006734 RID: 26420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006734")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Buff()
			{
			}

			// Token: 0x040038DB RID: 14555
			[Token(Token = "0x40038DB")]
			[FieldOffset(Offset = "0x10")]
			public PlayerBuildingDormitory.Buff.APCost apCost;

			// Token: 0x02000A78 RID: 2680
			[Token(Token = "0x2000A78")]
			public class APCost
			{
				// Token: 0x06006735 RID: 26421 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006735")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public APCost()
				{
				}

				// Token: 0x040038DC RID: 14556
				[Token(Token = "0x40038DC")]
				[FieldOffset(Offset = "0x10")]
				public int all;

				// Token: 0x040038DD RID: 14557
				[Token(Token = "0x40038DD")]
				[FieldOffset(Offset = "0x18")]
				public PlayerBuildingDormitory.Buff.APCost.SingleTarget single;

				// Token: 0x02000A79 RID: 2681
				[Token(Token = "0x2000A79")]
				public class SingleTarget
				{
					// Token: 0x06006736 RID: 26422 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006736")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public SingleTarget()
					{
					}

					// Token: 0x040038DE RID: 14558
					[Token(Token = "0x40038DE")]
					[FieldOffset(Offset = "0x10")]
					public string target;

					// Token: 0x040038DF RID: 14559
					[Token(Token = "0x40038DF")]
					[FieldOffset(Offset = "0x18")]
					public int value;
				}
			}
		}
	}
}
