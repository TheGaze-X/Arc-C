using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B03 RID: 31491
	[Token(Token = "0x2007B03")]
	public class Act12D6GameEndViewModel : IHotfixable
	{
		// Token: 0x0602C182 RID: 180610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C182")]
		[Address(RVA = "0x27F20F0", Offset = "0x27F0CF0", VA = "0x1827F20F0")]
		private void _LoadRelics()
		{
		}

		// Token: 0x0602C183 RID: 180611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C183")]
		[Address(RVA = "0x27F22F0", Offset = "0x27F0EF0", VA = "0x1827F22F0")]
		private void _LoadUnlockedRelics(PlayerRoguelikeRecord record)
		{
		}

		// Token: 0x0602C184 RID: 180612 RVA: 0x000DE150 File Offset: 0x000DC350
		[Token(Token = "0x602C184")]
		[Address(RVA = "0x27F1F30", Offset = "0x27F0B30", VA = "0x1827F1F30")]
		private int _CompareChar(RoguelikeCharCardViewModel lhs, RoguelikeCharCardViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0602C185 RID: 180613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C185")]
		[Address(RVA = "0x27F23F0", Offset = "0x27F0FF0", VA = "0x1827F23F0")]
		public Act12D6GameEndViewModel()
		{
		}

		// Token: 0x0403FE8B RID: 261771
		[Token(Token = "0x403FE8B")]
		[FieldOffset(Offset = "0x10")]
		public bool isDead;

		// Token: 0x0403FE8C RID: 261772
		[Token(Token = "0x403FE8C")]
		[FieldOffset(Offset = "0x18")]
		public string lastZoneName;

		// Token: 0x0403FE8D RID: 261773
		[Token(Token = "0x403FE8D")]
		[FieldOffset(Offset = "0x20")]
		public string lastZoneEndingDesc;

		// Token: 0x0403FE8E RID: 261774
		[Token(Token = "0x403FE8E")]
		[FieldOffset(Offset = "0x28")]
		public string endingId;

		// Token: 0x0403FE8F RID: 261775
		[Token(Token = "0x403FE8F")]
		[FieldOffset(Offset = "0x30")]
		public string endingBackgroundId;

		// Token: 0x0403FE90 RID: 261776
		[Token(Token = "0x403FE90")]
		[FieldOffset(Offset = "0x38")]
		public string endingName;

		// Token: 0x0403FE91 RID: 261777
		[Token(Token = "0x403FE91")]
		[FieldOffset(Offset = "0x40")]
		public string endingDesc;

		// Token: 0x0403FE92 RID: 261778
		[Token(Token = "0x403FE92")]
		[FieldOffset(Offset = "0x48")]
		public string nickName;

		// Token: 0x0403FE93 RID: 261779
		[Token(Token = "0x403FE93")]
		[FieldOffset(Offset = "0x50")]
		public long beginTs;

		// Token: 0x0403FE94 RID: 261780
		[Token(Token = "0x403FE94")]
		[FieldOffset(Offset = "0x58")]
		public long endTs;

		// Token: 0x0403FE95 RID: 261781
		[Token(Token = "0x403FE95")]
		[FieldOffset(Offset = "0x60")]
		public int totalSeconds;

		// Token: 0x0403FE96 RID: 261782
		[Token(Token = "0x403FE96")]
		[FieldOffset(Offset = "0x64")]
		public int passedZoneCnt;

		// Token: 0x0403FE97 RID: 261783
		[Token(Token = "0x403FE97")]
		[FieldOffset(Offset = "0x68")]
		public int moveCnt;

		// Token: 0x0403FE98 RID: 261784
		[Token(Token = "0x403FE98")]
		[FieldOffset(Offset = "0x6C")]
		public int normalBattleCnt;

		// Token: 0x0403FE99 RID: 261785
		[Token(Token = "0x403FE99")]
		[FieldOffset(Offset = "0x70")]
		public int eliteBattleCnt;

		// Token: 0x0403FE9A RID: 261786
		[Token(Token = "0x403FE9A")]
		[FieldOffset(Offset = "0x74")]
		public int bossBattleCnt;

		// Token: 0x0403FE9B RID: 261787
		[Token(Token = "0x403FE9B")]
		[FieldOffset(Offset = "0x78")]
		public int relicCnt;

		// Token: 0x0403FE9C RID: 261788
		[Token(Token = "0x403FE9C")]
		[FieldOffset(Offset = "0x7C")]
		public int charCnt;

		// Token: 0x0403FE9D RID: 261789
		[Token(Token = "0x403FE9D")]
		[FieldOffset(Offset = "0x80")]
		public int passedZoneScore;

		// Token: 0x0403FE9E RID: 261790
		[Token(Token = "0x403FE9E")]
		[FieldOffset(Offset = "0x84")]
		public int moveScore;

		// Token: 0x0403FE9F RID: 261791
		[Token(Token = "0x403FE9F")]
		[FieldOffset(Offset = "0x88")]
		public int normalBattleScore;

		// Token: 0x0403FEA0 RID: 261792
		[Token(Token = "0x403FEA0")]
		[FieldOffset(Offset = "0x8C")]
		public int eliteBattleScore;

		// Token: 0x0403FEA1 RID: 261793
		[Token(Token = "0x403FEA1")]
		[FieldOffset(Offset = "0x90")]
		public int bossBattleScore;

		// Token: 0x0403FEA2 RID: 261794
		[Token(Token = "0x403FEA2")]
		[FieldOffset(Offset = "0x94")]
		public int relicScore;

		// Token: 0x0403FEA3 RID: 261795
		[Token(Token = "0x403FEA3")]
		[FieldOffset(Offset = "0x98")]
		public int charScore;

		// Token: 0x0403FEA4 RID: 261796
		[Token(Token = "0x403FEA4")]
		[FieldOffset(Offset = "0xA0")]
		public string modeId;

		// Token: 0x0403FEA5 RID: 261797
		[Token(Token = "0x403FEA5")]
		[FieldOffset(Offset = "0xA8")]
		public string modeName;

		// Token: 0x0403FEA6 RID: 261798
		[Token(Token = "0x403FEA6")]
		[FieldOffset(Offset = "0xB0")]
		public float modeFactor;

		// Token: 0x0403FEA7 RID: 261799
		[Token(Token = "0x403FEA7")]
		[FieldOffset(Offset = "0xB4")]
		public int totalScore;

		// Token: 0x0403FEA8 RID: 261800
		[Token(Token = "0x403FEA8")]
		[FieldOffset(Offset = "0xB8")]
		public string outBuffTokenId;

		// Token: 0x0403FEA9 RID: 261801
		[Token(Token = "0x403FEA9")]
		[FieldOffset(Offset = "0xC0")]
		public string outBuffTokenName;

		// Token: 0x0403FEAA RID: 261802
		[Token(Token = "0x403FEAA")]
		[FieldOffset(Offset = "0xC8")]
		public Sprite outBuffTokenIconSprite;

		// Token: 0x0403FEAB RID: 261803
		[Token(Token = "0x403FEAB")]
		[FieldOffset(Offset = "0xD0")]
		public float outbuffTokenFactor;

		// Token: 0x0403FEAC RID: 261804
		[Token(Token = "0x403FEAC")]
		[FieldOffset(Offset = "0xD4")]
		public int outBuffTokenCnt;

		// Token: 0x0403FEAD RID: 261805
		[Token(Token = "0x403FEAD")]
		[FieldOffset(Offset = "0xD8")]
		public string milestoneTokenId;

		// Token: 0x0403FEAE RID: 261806
		[Token(Token = "0x403FEAE")]
		[FieldOffset(Offset = "0xE0")]
		public string milestoneTokenName;

		// Token: 0x0403FEAF RID: 261807
		[Token(Token = "0x403FEAF")]
		[FieldOffset(Offset = "0xE8")]
		public Sprite milestoneTokenIconSprite;

		// Token: 0x0403FEB0 RID: 261808
		[Token(Token = "0x403FEB0")]
		[FieldOffset(Offset = "0xF0")]
		public float milestoneTokenFactor;

		// Token: 0x0403FEB1 RID: 261809
		[Token(Token = "0x403FEB1")]
		[FieldOffset(Offset = "0xF4")]
		public int milestoneTokenCnt;

		// Token: 0x0403FEB2 RID: 261810
		[Token(Token = "0x403FEB2")]
		[FieldOffset(Offset = "0xF8")]
		public RoguelikeRelicViewModel initRelic;

		// Token: 0x0403FEB3 RID: 261811
		[Token(Token = "0x403FEB3")]
		[FieldOffset(Offset = "0x100")]
		public List<RoguelikeRelicViewModel> relics;

		// Token: 0x0403FEB4 RID: 261812
		[Token(Token = "0x403FEB4")]
		[FieldOffset(Offset = "0x108")]
		public List<RoguelikeCharCardViewModel> chars;

		// Token: 0x0403FEB5 RID: 261813
		[Token(Token = "0x403FEB5")]
		[FieldOffset(Offset = "0x110")]
		public List<string> unlockedModes;

		// Token: 0x0403FEB6 RID: 261814
		[Token(Token = "0x403FEB6")]
		[FieldOffset(Offset = "0x118")]
		public List<RoguelikeRelicViewModel> unlockedInitRelics;

		// Token: 0x0403FEB7 RID: 261815
		[Token(Token = "0x403FEB7")]
		[FieldOffset(Offset = "0x120")]
		public List<RoguelikeRelicViewModel> unlockedRelics;

		// Token: 0x0403FEB8 RID: 261816
		[Token(Token = "0x403FEB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadRelics;

		// Token: 0x0403FEB9 RID: 261817
		[Token(Token = "0x403FEB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadUnlockedRelics;

		// Token: 0x0403FEBA RID: 261818
		[Token(Token = "0x403FEBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareChar;

		// Token: 0x0403FEBB RID: 261819
		[Token(Token = "0x403FEBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
