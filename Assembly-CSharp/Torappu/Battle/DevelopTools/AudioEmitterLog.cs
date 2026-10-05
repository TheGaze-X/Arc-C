using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x02002892 RID: 10386
	[Token(Token = "0x2002892")]
	public class AudioEmitterLog : MonoBehaviour
	{
		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x060114B8 RID: 70840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700263E")]
		public Text numText
		{
			[Token(Token = "0x60114B8")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060114B9 RID: 70841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114B9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AudioEmitterLog()
		{
		}

		// Token: 0x04013506 RID: 79110
		[Token(Token = "0x4013506")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _numText;

		// Token: 0x02002893 RID: 10387
		[Token(Token = "0x2002893")]
		public enum SourceType
		{
			// Token: 0x04013508 RID: 79112
			[Token(Token = "0x4013508")]
			NONE,
			// Token: 0x04013509 RID: 79113
			[Token(Token = "0x4013509")]
			UI,
			// Token: 0x0401350A RID: 79114
			[Token(Token = "0x401350A")]
			BATTLE_COMMON,
			// Token: 0x0401350B RID: 79115
			[Token(Token = "0x401350B")]
			BATTLE_CHAR = 4,
			// Token: 0x0401350C RID: 79116
			[Token(Token = "0x401350C")]
			BATTLE_ENEMY = 8,
			// Token: 0x0401350D RID: 79117
			[Token(Token = "0x401350D")]
			ALL = 15
		}

		// Token: 0x02002894 RID: 10388
		[Token(Token = "0x2002894")]
		public enum LogType
		{
			// Token: 0x0401350F RID: 79119
			[Token(Token = "0x401350F")]
			NONE,
			// Token: 0x04013510 RID: 79120
			[Token(Token = "0x4013510")]
			SIGNAL,
			// Token: 0x04013511 RID: 79121
			[Token(Token = "0x4013511")]
			AUDIO_CLIP,
			// Token: 0x04013512 RID: 79122
			[Token(Token = "0x4013512")]
			AUDIO_MIXER_OUTPUT = 4,
			// Token: 0x04013513 RID: 79123
			[Token(Token = "0x4013513")]
			ALL = 7
		}
	}
}
