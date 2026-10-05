using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200267B RID: 9851
	[Token(Token = "0x200267B")]
	[Serializable]
	public class LevelScriptDataMap
	{
		// Token: 0x06010193 RID: 65939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010193")]
		[Address(RVA = "0x7C8320", Offset = "0x7C6F20", VA = "0x1807C8320")]
		public void GatherLevelScriptDataByCharacter(string character, List<string> result)
		{
		}

		// Token: 0x06010194 RID: 65940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010194")]
		[Address(RVA = "0x7C83C0", Offset = "0x7C6FC0", VA = "0x1807C83C0")]
		public void GatherLevelScriptDataByEnemy(string enemy, List<string> result)
		{
		}

		// Token: 0x06010195 RID: 65941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010195")]
		[Address(RVA = "0x7C8580", Offset = "0x7C7180", VA = "0x1807C8580")]
		public void GatherLevelScriptDataByLevel(string level, List<string> result)
		{
		}

		// Token: 0x06010196 RID: 65942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010196")]
		[Address(RVA = "0x7C8460", Offset = "0x7C7060", VA = "0x1807C8460")]
		public void GatherLevelScriptDataByGameMode(GameModeMeta.GameModeType gameMode, List<string> result)
		{
		}

		// Token: 0x06010197 RID: 65943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010197")]
		[Address(RVA = "0x7C84F0", Offset = "0x7C70F0", VA = "0x1807C84F0")]
		public void GatherLevelScriptDataByKey(string key, List<string> result)
		{
		}

		// Token: 0x06010198 RID: 65944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010198")]
		[Address(RVA = "0x7C8660", Offset = "0x7C7260", VA = "0x1807C8660")]
		public LevelScriptDataMap()
		{
		}

		// Token: 0x04011EB8 RID: 73400
		[Token(Token = "0x4011EB8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<string>> levelScriptDataCharacterDict;

		// Token: 0x04011EB9 RID: 73401
		[Token(Token = "0x4011EB9")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<string>> levelScriptDataEnemyDict;

		// Token: 0x04011EBA RID: 73402
		[Token(Token = "0x4011EBA")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<string>> levelScriptDataLevelDict;

		// Token: 0x04011EBB RID: 73403
		[Token(Token = "0x4011EBB")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<string>> levelScriptDataGameModeDict;

		// Token: 0x04011EBC RID: 73404
		[Token(Token = "0x4011EBC")]
		[FieldOffset(Offset = "0x30")]
		public List<string> levelScriptDataMiscList;
	}
}
