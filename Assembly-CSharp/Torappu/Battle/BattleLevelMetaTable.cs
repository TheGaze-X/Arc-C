using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002678 RID: 9848
	[Token(Token = "0x2002678")]
	public class BattleLevelMetaTable
	{
		// Token: 0x06010190 RID: 65936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010190")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleLevelMetaTable()
		{
		}

		// Token: 0x04011EB4 RID: 73396
		[Token(Token = "0x4011EB4")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, BattleLevelMetaTable.ActSandboxStageMeta> sandboxLevelMeta;

		// Token: 0x02002679 RID: 9849
		[Token(Token = "0x2002679")]
		public class SandboxLevelMeta
		{
			// Token: 0x06010191 RID: 65937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010191")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SandboxLevelMeta()
			{
			}

			// Token: 0x04011EB5 RID: 73397
			[Token(Token = "0x4011EB5")]
			[FieldOffset(Offset = "0x10")]
			public RouteData[] routes;

			// Token: 0x04011EB6 RID: 73398
			[Token(Token = "0x4011EB6")]
			[FieldOffset(Offset = "0x18")]
			public LevelData.WaveData[] waves;

			// Token: 0x04011EB7 RID: 73399
			[Token(Token = "0x4011EB7")]
			[FieldOffset(Offset = "0x20")]
			public LevelData.PredefinedData predefines;
		}

		// Token: 0x0200267A RID: 9850
		[Token(Token = "0x200267A")]
		public class ActSandboxStageMeta : Dictionary<string, BattleLevelMetaTable.SandboxLevelMeta>
		{
			// Token: 0x06010192 RID: 65938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010192")]
			[Address(RVA = "0x7BC420", Offset = "0x7BB020", VA = "0x1807BC420")]
			public ActSandboxStageMeta()
			{
			}
		}
	}
}
