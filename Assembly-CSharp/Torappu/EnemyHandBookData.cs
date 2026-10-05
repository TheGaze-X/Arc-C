using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200103F RID: 4159
	[Token(Token = "0x200103F")]
	public class EnemyHandBookData
	{
		// Token: 0x06006DA9 RID: 28073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA9")]
		[Address(RVA = "0x2103E70", Offset = "0x2102A70", VA = "0x182103E70")]
		public EnemyHandBookData()
		{
		}

		// Token: 0x04005862 RID: 22626
		[Token(Token = "0x4005862")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x04005863 RID: 22627
		[Token(Token = "0x4005863")]
		[FieldOffset(Offset = "0x18")]
		public string enemyIndex;

		// Token: 0x04005864 RID: 22628
		[Token(Token = "0x4005864")]
		[FieldOffset(Offset = "0x20")]
		public string[] enemyTags;

		// Token: 0x04005865 RID: 22629
		[Token(Token = "0x4005865")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x04005866 RID: 22630
		[Token(Token = "0x4005866")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04005867 RID: 22631
		[Token(Token = "0x4005867")]
		[FieldOffset(Offset = "0x38")]
		[JsonConverter(typeof(StringEnumConverter))]
		public EnemyLevelType enemyLevel;

		// Token: 0x04005868 RID: 22632
		[Token(Token = "0x4005868")]
		[FieldOffset(Offset = "0x40")]
		public string description;

		// Token: 0x04005869 RID: 22633
		[Token(Token = "0x4005869")]
		[FieldOffset(Offset = "0x48")]
		public string attackType;

		// Token: 0x0400586A RID: 22634
		[Token(Token = "0x400586A")]
		[FieldOffset(Offset = "0x50")]
		public string ability;

		// Token: 0x0400586B RID: 22635
		[Token(Token = "0x400586B")]
		[FieldOffset(Offset = "0x58")]
		public bool isInvalidKilled;

		// Token: 0x0400586C RID: 22636
		[Token(Token = "0x400586C")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, int> overrideKillCntInfos;

		// Token: 0x0400586D RID: 22637
		[Token(Token = "0x400586D")]
		[FieldOffset(Offset = "0x68")]
		public bool hideInHandbook;

		// Token: 0x0400586E RID: 22638
		[Token(Token = "0x400586E")]
		[FieldOffset(Offset = "0x69")]
		public bool hideInStage;

		// Token: 0x0400586F RID: 22639
		[Token(Token = "0x400586F")]
		[FieldOffset(Offset = "0x70")]
		public List<EnemyHandBookData.Abilty> abilityList;

		// Token: 0x04005870 RID: 22640
		[Token(Token = "0x4005870")]
		[FieldOffset(Offset = "0x78")]
		public List<string> linkEnemies;

		// Token: 0x04005871 RID: 22641
		[Token(Token = "0x4005871")]
		[FieldOffset(Offset = "0x80")]
		public List<EnemyHandBookDamageType> damageType;

		// Token: 0x04005872 RID: 22642
		[Token(Token = "0x4005872")]
		[FieldOffset(Offset = "0x88")]
		public bool invisibleDetail;

		// Token: 0x02001040 RID: 4160
		[Token(Token = "0x2001040")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TextFormat
		{
			// Token: 0x04005874 RID: 22644
			[Token(Token = "0x4005874")]
			NORMAL,
			// Token: 0x04005875 RID: 22645
			[Token(Token = "0x4005875")]
			TITLE,
			// Token: 0x04005876 RID: 22646
			[Token(Token = "0x4005876")]
			SILENCE
		}

		// Token: 0x02001041 RID: 4161
		[Token(Token = "0x2001041")]
		public class Abilty
		{
			// Token: 0x06006DAA RID: 28074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DAA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Abilty()
			{
			}

			// Token: 0x04005877 RID: 22647
			[Token(Token = "0x4005877")]
			[FieldOffset(Offset = "0x10")]
			public string text;

			// Token: 0x04005878 RID: 22648
			[Token(Token = "0x4005878")]
			[FieldOffset(Offset = "0x18")]
			public EnemyHandBookData.TextFormat textFormat;
		}
	}
}
