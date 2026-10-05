using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E99 RID: 28313
	[Token(Token = "0x2006E99")]
	public class VecBreakV2SeasonRecordCharInfo
	{
		// Token: 0x060284B3 RID: 165043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284B3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2SeasonRecordCharInfo()
		{
		}

		// Token: 0x0403943F RID: 234559
		[Token(Token = "0x403943F")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04039440 RID: 234560
		[Token(Token = "0x4039440")]
		[FieldOffset(Offset = "0x18")]
		public string currentTmpl;

		// Token: 0x04039441 RID: 234561
		[Token(Token = "0x4039441")]
		[FieldOffset(Offset = "0x20")]
		public int potentialRank;

		// Token: 0x04039442 RID: 234562
		[Token(Token = "0x4039442")]
		[FieldOffset(Offset = "0x24")]
		public int level;

		// Token: 0x04039443 RID: 234563
		[Token(Token = "0x4039443")]
		[FieldOffset(Offset = "0x28")]
		public int mainSkillLvl;

		// Token: 0x04039444 RID: 234564
		[Token(Token = "0x4039444")]
		[FieldOffset(Offset = "0x2C")]
		public EvolvePhase evolvePhase;

		// Token: 0x04039445 RID: 234565
		[Token(Token = "0x4039445")]
		[FieldOffset(Offset = "0x30")]
		public string skin;

		// Token: 0x04039446 RID: 234566
		[Token(Token = "0x4039446")]
		[FieldOffset(Offset = "0x38")]
		public VecBreakV2SeasonRecordCharInfo.SkillInfo skill;

		// Token: 0x04039447 RID: 234567
		[Token(Token = "0x4039447")]
		[FieldOffset(Offset = "0x40")]
		public VecBreakV2SeasonRecordCharInfo.EquipInfo equip;

		// Token: 0x02006E9A RID: 28314
		[Token(Token = "0x2006E9A")]
		public class SkillInfo
		{
			// Token: 0x060284B4 RID: 165044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60284B4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkillInfo()
			{
			}

			// Token: 0x04039448 RID: 234568
			[Token(Token = "0x4039448")]
			[FieldOffset(Offset = "0x10")]
			public int skillIndex;

			// Token: 0x04039449 RID: 234569
			[Token(Token = "0x4039449")]
			[FieldOffset(Offset = "0x14")]
			public int specializeLevel;
		}

		// Token: 0x02006E9B RID: 28315
		[Token(Token = "0x2006E9B")]
		public class EquipInfo
		{
			// Token: 0x060284B5 RID: 165045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60284B5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EquipInfo()
			{
			}

			// Token: 0x0403944A RID: 234570
			[Token(Token = "0x403944A")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0403944B RID: 234571
			[Token(Token = "0x403944B")]
			[FieldOffset(Offset = "0x18")]
			public int level;
		}
	}
}
