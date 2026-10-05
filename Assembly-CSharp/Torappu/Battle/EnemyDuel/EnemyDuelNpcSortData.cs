using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026CD RID: 9933
	[Token(Token = "0x20026CD")]
	public class EnemyDuelNpcSortData : IItemWithWeight
	{
		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x060102F1 RID: 66289 RVA: 0x00062BC8 File Offset: 0x00060DC8
		// (set) Token: 0x060102F2 RID: 66290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700234A")]
		public float weightValue
		{
			[Token(Token = "0x60102F1")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60102F2")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060102F3 RID: 66291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelNpcSortData()
		{
		}

		// Token: 0x040120F4 RID: 73972
		[Token(Token = "0x40120F4")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x040120F5 RID: 73973
		[Token(Token = "0x40120F5")]
		[FieldOffset(Offset = "0x18")]
		public float priority;

		// Token: 0x040120F6 RID: 73974
		[Token(Token = "0x40120F6")]
		[FieldOffset(Offset = "0x20")]
		public ActivityEnemyDuelNpcData data;
	}
}
