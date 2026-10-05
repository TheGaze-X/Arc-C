using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.Abilities;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x020015ED RID: 5613
	[Token(Token = "0x20015ED")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public class LuaBattleMgr : Singleton<LuaBattleMgr>
	{
		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x00037FE0 File Offset: 0x000361E0
		[Token(Token = "0x17000F1C")]
		private bool isCallbackReady
		{
			[Token(Token = "0x6007F2E")]
			[Address(RVA = "0x288B7F0", Offset = "0x288A3F0", VA = "0x18288B7F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2F")]
		[Address(RVA = "0x288B780", Offset = "0x288A380", VA = "0x18288B780")]
		private LuaBattleMgr()
		{
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F30")]
		[Address(RVA = "0x288B3D0", Offset = "0x2889FD0", VA = "0x18288B3D0")]
		public static void LuaOnlyBindCallback(LuaBattleMgr.ILuaServiceCallback callback)
		{
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F31")]
		[Address(RVA = "0x288B4A0", Offset = "0x288A0A0", VA = "0x18288B4A0")]
		public void ResetAll()
		{
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x00037FF8 File Offset: 0x000361F8
		[Token(Token = "0x6007F32")]
		[Address(RVA = "0x288B580", Offset = "0x288A180", VA = "0x18288B580")]
		public bool RunActions(string actionName, Blackboard blackboard, ActionNode.SourceType sourceType, ref Context.Snapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F33")]
		[Address(RVA = "0x288B1E0", Offset = "0x2889DE0", VA = "0x18288B1E0")]
		public LuaAbilityBehaviourStub.LuaBinding CreateAbilityBehaviour(LuaAbilityBehaviourStub wrapper)
		{
			return null;
		}

		// Token: 0x040080DA RID: 32986
		[Token(Token = "0x40080DA")]
		[FieldOffset(Offset = "0x10")]
		private LuaBattleMgr.ILuaServiceCallback m_luaCallback;

		// Token: 0x040080DB RID: 32987
		[Token(Token = "0x40080DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCallbackReady;

		// Token: 0x040080DC RID: 32988
		[Token(Token = "0x40080DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040080DD RID: 32989
		[Token(Token = "0x40080DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LuaOnlyBindCallback;

		// Token: 0x040080DE RID: 32990
		[Token(Token = "0x40080DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetAll;

		// Token: 0x040080DF RID: 32991
		[Token(Token = "0x40080DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RunActions;

		// Token: 0x040080E0 RID: 32992
		[Token(Token = "0x40080E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateAbilityBehaviour;

		// Token: 0x020015EE RID: 5614
		[Token(Token = "0x20015EE")]
		[CSharpCallLua]
		public interface ILuaServiceCallback
		{
			// Token: 0x06007F34 RID: 32564
			[Token(Token = "0x6007F34")]
			bool ExportRunAction(string actionName, Blackboard blackboard, ActionNode.SourceType sourceType, ref Context.Snapshot snapshot);

			// Token: 0x06007F35 RID: 32565
			[Token(Token = "0x6007F35")]
			LuaAbilityBehaviourStub.LuaBinding ExportCreateAbilityBehaviour(string className, LuaAbilityBehaviourStub wrapper);

			// Token: 0x06007F36 RID: 32566
			[Token(Token = "0x6007F36")]
			void ExportResetAll();
		}
	}
}
