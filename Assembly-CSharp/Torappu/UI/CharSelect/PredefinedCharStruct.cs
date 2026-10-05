using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E0A RID: 24074
	[Token(Token = "0x2005E0A")]
	public struct PredefinedCharStruct
	{
		// Token: 0x040300A7 RID: 196775
		[Token(Token = "0x40300A7")]
		[FieldOffset(Offset = "0x0")]
		public CharQuery charQuery;

		// Token: 0x040300A8 RID: 196776
		[Token(Token = "0x40300A8")]
		[FieldOffset(Offset = "0x18")]
		public int chrInstId;

		// Token: 0x040300A9 RID: 196777
		[Token(Token = "0x40300A9")]
		[FieldOffset(Offset = "0x1C")]
		public int level;

		// Token: 0x040300AA RID: 196778
		[Token(Token = "0x40300AA")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase evolvePhase;

		// Token: 0x040300AB RID: 196779
		[Token(Token = "0x40300AB")]
		[FieldOffset(Offset = "0x24")]
		public int potentialRank;

		// Token: 0x040300AC RID: 196780
		[Token(Token = "0x40300AC")]
		[FieldOffset(Offset = "0x28")]
		public int favorPoint;

		// Token: 0x040300AD RID: 196781
		[Token(Token = "0x40300AD")]
		[FieldOffset(Offset = "0x30")]
		public string equipId;

		// Token: 0x040300AE RID: 196782
		[Token(Token = "0x40300AE")]
		[FieldOffset(Offset = "0x38")]
		public ListDict<string, PlayerCharEquipInfo> equips;

		// Token: 0x040300AF RID: 196783
		[Token(Token = "0x40300AF")]
		[FieldOffset(Offset = "0x40")]
		public string charId;

		// Token: 0x040300B0 RID: 196784
		[Token(Token = "0x40300B0")]
		[FieldOffset(Offset = "0x48")]
		public PlayerCharSkill[] skills;

		// Token: 0x040300B1 RID: 196785
		[Token(Token = "0x40300B1")]
		[FieldOffset(Offset = "0x50")]
		public int mainSkillLvl;
	}
}
