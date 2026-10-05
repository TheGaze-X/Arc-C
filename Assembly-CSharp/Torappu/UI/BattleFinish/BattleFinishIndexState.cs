using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061F2 RID: 25074
	[Token(Token = "0x20061F2")]
	public class BattleFinishIndexState : State
	{
		// Token: 0x06024301 RID: 148225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024301")]
		[Address(RVA = "0x1ED28E0", Offset = "0x1ED14E0", VA = "0x181ED28E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024302 RID: 148226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024302")]
		[Address(RVA = "0x1ED2940", Offset = "0x1ED1540", VA = "0x181ED2940", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06024303 RID: 148227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024303")]
		[Address(RVA = "0x1ED3410", Offset = "0x1ED2010", VA = "0x181ED3410")]
		private void _RouteToProperState()
		{
		}

		// Token: 0x06024304 RID: 148228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024304")]
		private IEnumerator _SwitchToStateCoroutine<StateType>() where StateType : State
		{
			return null;
		}

		// Token: 0x06024305 RID: 148229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024305")]
		[Address(RVA = "0x1ED3370", Offset = "0x1ED1F70", VA = "0x181ED3370")]
		private void _PreprocessOnBattleFinishResponse(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x06024306 RID: 148230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024306")]
		[Address(RVA = "0x1ED3620", Offset = "0x1ED2220", VA = "0x181ED3620")]
		private void _TriggerDefaultBattleFinishBGM()
		{
		}

		// Token: 0x06024307 RID: 148231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024307")]
		[Address(RVA = "0x1ED3850", Offset = "0x1ED2450", VA = "0x181ED3850")]
		public BattleFinishIndexState()
		{
		}

		// Token: 0x06024308 RID: 148232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024308")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040324DC RID: 206044
		[Token(Token = "0x40324DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040324DD RID: 206045
		[Token(Token = "0x40324DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040324DE RID: 206046
		[Token(Token = "0x40324DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x040324DF RID: 206047
		[Token(Token = "0x40324DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SwitchToStateCoroutine;

		// Token: 0x040324E0 RID: 206048
		[Token(Token = "0x40324E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PreprocessOnBattleFinishResponse;

		// Token: 0x040324E1 RID: 206049
		[Token(Token = "0x40324E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerDefaultBattleFinishBGM;

		// Token: 0x040324E2 RID: 206050
		[Token(Token = "0x40324E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061F3 RID: 25075
		[Token(Token = "0x20061F3")]
		public interface IPlugin : IHotfixable
		{
			// Token: 0x06024309 RID: 148233
			[Token(Token = "0x6024309")]
			bool HandleRedirection();
		}

		// Token: 0x020061F4 RID: 25076
		[Token(Token = "0x20061F4")]
		public abstract class Plugin : BattleFinishIndexState.IPlugin, IHotfixable
		{
			// Token: 0x0602430A RID: 148234 RVA: 0x000C35E8 File Offset: 0x000C17E8
			[Token(Token = "0x602430A")]
			[Address(RVA = "0x1EE4C90", Offset = "0x1EE3890", VA = "0x181EE4C90", Slot = "5")]
			public virtual bool HandleRedirection()
			{
				return default(bool);
			}

			// Token: 0x0602430B RID: 148235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602430B")]
			[Address(RVA = "0x1EE4CF0", Offset = "0x1EE38F0", VA = "0x181EE4CF0")]
			protected Plugin()
			{
			}

			// Token: 0x040324E3 RID: 206051
			[Token(Token = "0x40324E3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_HandleRedirection;

			// Token: 0x040324E4 RID: 206052
			[Token(Token = "0x40324E4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
