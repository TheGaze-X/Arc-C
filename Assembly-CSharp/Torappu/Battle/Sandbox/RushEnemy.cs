using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A67 RID: 10855
	[Token(Token = "0x2002A67")]
	public class RushEnemy : IHotfixable
	{
		// Token: 0x060120FA RID: 73978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120FA")]
		[Address(RVA = "0xA27F60", Offset = "0xA26B60", VA = "0x180A27F60")]
		public RushEnemy()
		{
		}

		// Token: 0x0401466D RID: 83565
		[Token(Token = "0x401466D")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2EnemyRushType type;

		// Token: 0x0401466E RID: 83566
		[Token(Token = "0x401466E")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x0401466F RID: 83567
		[Token(Token = "0x401466F")]
		[FieldOffset(Offset = "0x20")]
		public string groupId;

		// Token: 0x04014670 RID: 83568
		[Token(Token = "0x4014670")]
		[FieldOffset(Offset = "0x28")]
		public int groupIndex;

		// Token: 0x04014671 RID: 83569
		[Token(Token = "0x4014671")]
		[FieldOffset(Offset = "0x2C")]
		public int count;

		// Token: 0x04014672 RID: 83570
		[Token(Token = "0x4014672")]
		[FieldOffset(Offset = "0x30")]
		public int totalCount;

		// Token: 0x04014673 RID: 83571
		[Token(Token = "0x4014673")]
		[FieldOffset(Offset = "0x34")]
		[JsonIgnore]
		public bool isRareAnimal;

		// Token: 0x04014674 RID: 83572
		[Token(Token = "0x4014674")]
		[FieldOffset(Offset = "0x38")]
		public RareAnimalExtraInfo extra;

		// Token: 0x04014675 RID: 83573
		[Token(Token = "0x4014675")]
		[FieldOffset(Offset = "0x40")]
		public string enemyId;

		// Token: 0x04014676 RID: 83574
		[Token(Token = "0x4014676")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
