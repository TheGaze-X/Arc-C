using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;
using Torappu.Battle.Abilities;
using Torappu.Battle.Action;
using Torappu.Lua;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	public class TorappuLuaLuaBattleMgrILuaServiceCallbackBridge : LuaBase, LuaBattleMgr.ILuaServiceCallback
	{
		// Token: 0x0600407B RID: 16507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407B")]
		[Address(RVA = "0xCF5980", Offset = "0xCF4580", VA = "0x180CF5980")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuLuaLuaBattleMgrILuaServiceCallbackBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		[Token(Token = "0x600407D")]
		[Address(RVA = "0xCF55E0", Offset = "0xCF41E0", VA = "0x180CF55E0", Slot = "7")]
		private bool ExportRunAction(string actionName, Blackboard blackboard, ActionNode.SourceType sourceType, ref Context.Snapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407E")]
		[Address(RVA = "0xCF50B0", Offset = "0xCF3CB0", VA = "0x180CF50B0", Slot = "8")]
		private LuaAbilityBehaviourStub.LuaBinding ExportCreateAbilityBehaviour(string className, LuaAbilityBehaviourStub wrapper)
		{
			return null;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407F")]
		[Address(RVA = "0xCF53D0", Offset = "0xCF3FD0", VA = "0x180CF53D0", Slot = "9")]
		private void ExportResetAll()
		{
		}
	}
}
