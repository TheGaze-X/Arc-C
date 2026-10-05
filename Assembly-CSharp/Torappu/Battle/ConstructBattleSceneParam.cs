using System;
using Il2CppDummyDll;
using Torappu.Battle.Sandbox;

namespace Torappu.Battle
{
	// Token: 0x020020DA RID: 8410
	[Token(Token = "0x20020DA")]
	public class ConstructBattleSceneParam : ISceneParam
	{
		// Token: 0x0600CDC7 RID: 52679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConstructBattleSceneParam()
		{
		}

		// Token: 0x0400DB33 RID: 56115
		[Token(Token = "0x400DB33")]
		[FieldOffset(Offset = "0x10")]
		public string sceneName;

		// Token: 0x0400DB34 RID: 56116
		[Token(Token = "0x400DB34")]
		[FieldOffset(Offset = "0x18")]
		public LevelData levelData;

		// Token: 0x0400DB35 RID: 56117
		[Token(Token = "0x400DB35")]
		[FieldOffset(Offset = "0x20")]
		public SandboxInput sandboxInput;

		// Token: 0x0400DB36 RID: 56118
		[Token(Token = "0x400DB36")]
		[FieldOffset(Offset = "0x28")]
		public GameModeMeta.GameModeType gameMode;

		// Token: 0x0400DB37 RID: 56119
		[Token(Token = "0x400DB37")]
		[FieldOffset(Offset = "0x30")]
		public string homeBuildModeBGM;

		// Token: 0x0400DB38 RID: 56120
		[Token(Token = "0x400DB38")]
		[FieldOffset(Offset = "0x38")]
		public string nodeId;

		// Token: 0x0400DB39 RID: 56121
		[Token(Token = "0x400DB39")]
		[FieldOffset(Offset = "0x40")]
		public ConstructBattleSceneUser user;
	}
}
