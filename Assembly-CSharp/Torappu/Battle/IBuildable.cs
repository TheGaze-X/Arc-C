using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200221F RID: 8735
	[Token(Token = "0x200221F")]
	public interface IBuildable : ILocatable
	{
		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x0600DBF8 RID: 56312
		[Token(Token = "0x17001BBB")]
		Tile rootTile { [Token(Token = "0x600DBF8")] get; }

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x0600DBF9 RID: 56313
		[Token(Token = "0x17001BBC")]
		SharedConsts.Direction direction { [Token(Token = "0x600DBF9")] get; }

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x0600DBFA RID: 56314
		[Token(Token = "0x17001BBD")]
		BuildCondition buildCondition { [Token(Token = "0x600DBFA")] get; }

		// Token: 0x0600DBFB RID: 56315
		[Token(Token = "0x600DBFB")]
		bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool ignoreAdvancedBuildableMask);
	}
}
