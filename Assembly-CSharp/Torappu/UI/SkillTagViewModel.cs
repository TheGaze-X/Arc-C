using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200375D RID: 14173
	[Token(Token = "0x200375D")]
	public struct SkillTagViewModel
	{
		// Token: 0x0401B1CA RID: 111050
		[Token(Token = "0x401B1CA")]
		[FieldOffset(Offset = "0x0")]
		public static Color TAG_SP_WITH_TIME;

		// Token: 0x0401B1CB RID: 111051
		[Token(Token = "0x401B1CB")]
		[FieldOffset(Offset = "0x10")]
		public static Color TAG_SP_WHEN_ATTACK;

		// Token: 0x0401B1CC RID: 111052
		[Token(Token = "0x401B1CC")]
		[FieldOffset(Offset = "0x20")]
		public static Color TAG_SP_WHEN_TAKE_DAMAGE;

		// Token: 0x0401B1CD RID: 111053
		[Token(Token = "0x401B1CD")]
		[FieldOffset(Offset = "0x30")]
		public static Color TAG_BKG_NORMAL;

		// Token: 0x0401B1CE RID: 111054
		[Token(Token = "0x401B1CE")]
		[FieldOffset(Offset = "0x40")]
		public static Color DESC_TEXT_COLOR;

		// Token: 0x0401B1CF RID: 111055
		[Token(Token = "0x401B1CF")]
		public const string PREFAB_ID_TEXT_TAG = "skill_tag_text";

		// Token: 0x0401B1D0 RID: 111056
		[Token(Token = "0x401B1D0")]
		public const string PREFAB_ID_TIME_TAG = "skill_tag_time";

		// Token: 0x0401B1D1 RID: 111057
		[Token(Token = "0x401B1D1")]
		[FieldOffset(Offset = "0x0")]
		public SkillTagType type;

		// Token: 0x0401B1D2 RID: 111058
		[Token(Token = "0x401B1D2")]
		[FieldOffset(Offset = "0x4")]
		public Color color;

		// Token: 0x0401B1D3 RID: 111059
		[Token(Token = "0x401B1D3")]
		[FieldOffset(Offset = "0x18")]
		public string content;
	}
}
