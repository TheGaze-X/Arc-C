using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.I18N
{
	// Token: 0x02001621 RID: 5665
	[Token(Token = "0x2001621")]
	public class LocalizationPreferenceConfig : ScriptableObject
	{
		// Token: 0x060080A2 RID: 32930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A2")]
		[Address(RVA = "0x2887930", Offset = "0x2886530", VA = "0x182887930")]
		public LocalizationPreferenceConfig()
		{
		}

		// Token: 0x040081D3 RID: 33235
		[Token(Token = "0x40081D3")]
		[FieldOffset(Offset = "0x18")]
		public string numberUnitFormat;

		// Token: 0x040081D4 RID: 33236
		[Token(Token = "0x40081D4")]
		[FieldOffset(Offset = "0x20")]
		public string[] numberUnits;

		// Token: 0x040081D5 RID: 33237
		[Token(Token = "0x40081D5")]
		[FieldOffset(Offset = "0x28")]
		public int unitStepSize;

		// Token: 0x040081D6 RID: 33238
		[Token(Token = "0x40081D6")]
		[FieldOffset(Offset = "0x2C")]
		public int battleResultCharWordLineLength;

		// Token: 0x040081D7 RID: 33239
		[Token(Token = "0x40081D7")]
		[FieldOffset(Offset = "0x30")]
		public LocalizationPreferenceConfig.BattleResultCharWordSplitMode splitMode;

		// Token: 0x02001622 RID: 5666
		[Token(Token = "0x2001622")]
		public enum BattleResultCharWordSplitMode
		{
			// Token: 0x040081D9 RID: 33241
			[Token(Token = "0x40081D9")]
			LetterBased,
			// Token: 0x040081DA RID: 33242
			[Token(Token = "0x40081DA")]
			WordBased
		}
	}
}
