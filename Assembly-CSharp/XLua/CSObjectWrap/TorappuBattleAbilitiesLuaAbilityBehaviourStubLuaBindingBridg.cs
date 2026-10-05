using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;
using Torappu.Battle.Abilities;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	public class TorappuBattleAbilitiesLuaAbilityBehaviourStubLuaBindingBridge : LuaBase, LuaAbilityBehaviourStub.LuaBinding
	{
		// Token: 0x06003B6E RID: 15214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x8C9960", Offset = "0x8C8560", VA = "0x1808C9960")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuBattleAbilitiesLuaAbilityBehaviourStubLuaBindingBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x8C9430", Offset = "0x8C8030", VA = "0x1808C9430", Slot = "7")]
		private void ExportSetData(Blackboard blackboard)
		{
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x8C8DB0", Offset = "0x8C79B0", VA = "0x1808C8DB0", Slot = "8")]
		private void ExportOnCastStart()
		{
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x8C8940", Offset = "0x8C7540", VA = "0x1808C8940", Slot = "9")]
		private void ExportOnCastFinish()
		{
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x8C8FC0", Offset = "0x8C7BC0", VA = "0x1808C8FC0", Slot = "10")]
		private void ExportOnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7750", VA = "0x1808C8B50", Slot = "11")]
		private void ExportOnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x8C9220", Offset = "0x8C7E20", VA = "0x1808C9220", Slot = "12")]
		private void ExportOnStopAffect()
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x0001A1D8 File Offset: 0x000183D8
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x8C9690", Offset = "0x8C8290", VA = "0x1808C9690", Slot = "13")]
		private bool ExportUpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
		{
			return default(bool);
		}
	}
}
