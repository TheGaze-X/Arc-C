using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200375F RID: 14175
	[Token(Token = "0x200375F")]
	public class SkillGroupViewModel
	{
		// Token: 0x06016820 RID: 92192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016820")]
		[Address(RVA = "0xEDE700", Offset = "0xEDD300", VA = "0x180EDE700")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06016821 RID: 92193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016821")]
		[Address(RVA = "0xEDE660", Offset = "0xEDD260", VA = "0x180EDE660")]
		public SkillItemViewModel AchieveSkillModelById(string skillId)
		{
			return null;
		}

		// Token: 0x06016822 RID: 92194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016822")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SkillGroupViewModel()
		{
		}

		// Token: 0x0401B1E7 RID: 111079
		[Token(Token = "0x401B1E7")]
		[FieldOffset(Offset = "0x10")]
		public string selectedSkillId;

		// Token: 0x0401B1E8 RID: 111080
		[Token(Token = "0x401B1E8")]
		[FieldOffset(Offset = "0x18")]
		public SkillItemViewModel[] skills;

		// Token: 0x0401B1E9 RID: 111081
		[Token(Token = "0x401B1E9")]
		[FieldOffset(Offset = "0x20")]
		public int skillAllLevel;

		// Token: 0x0401B1EA RID: 111082
		[Token(Token = "0x401B1EA")]
		[FieldOffset(Offset = "0x28")]
		public CharQuery charQuery;

		// Token: 0x0401B1EB RID: 111083
		[Token(Token = "0x401B1EB")]
		[FieldOffset(Offset = "0x40")]
		public bool allMaxFlag;

		// Token: 0x0401B1EC RID: 111084
		[Token(Token = "0x401B1EC")]
		[FieldOffset(Offset = "0x41")]
		public bool isSpecialOperator;
	}
}
