using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002219 RID: 8729
	[Token(Token = "0x2002219")]
	public class PutDownTutorialTileBuildableChecker : ITileBuildableChecker
	{
		// Token: 0x0600DBCF RID: 56271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBCF")]
		[Address(RVA = "0x3629A50", Offset = "0x3628650", VA = "0x183629A50")]
		public PutDownTutorialTileBuildableChecker(int x, int y)
		{
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x00050508 File Offset: 0x0004E708
		[Token(Token = "0x600DBD0")]
		[Address(RVA = "0x36298B0", Offset = "0x36284B0", VA = "0x1836298B0", Slot = "4")]
		public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
		{
			return default(bool);
		}

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DBD1")]
		[Address(RVA = "0x36299C0", Offset = "0x36285C0", VA = "0x1836299C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400EDF2 RID: 60914
		[Token(Token = "0x400EDF2")]
		[FieldOffset(Offset = "0x10")]
		private int m_tileX;

		// Token: 0x0400EDF3 RID: 60915
		[Token(Token = "0x400EDF3")]
		[FieldOffset(Offset = "0x14")]
		private int m_tileY;
	}
}
