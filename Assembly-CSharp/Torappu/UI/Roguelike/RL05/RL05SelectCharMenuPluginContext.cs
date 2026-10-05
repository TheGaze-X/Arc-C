using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200560D RID: 22029
	[Token(Token = "0x200560D")]
	public class RL05SelectCharMenuPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x0602052C RID: 132396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602052C")]
		[Address(RVA = "0x1A70EA0", Offset = "0x1A6FAA0", VA = "0x181A70EA0", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0602052D RID: 132397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602052D")]
		[Address(RVA = "0x1A70F80", Offset = "0x1A6FB80", VA = "0x181A70F80", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0602052E RID: 132398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602052E")]
		[Address(RVA = "0x1A70DD0", Offset = "0x1A6F9D0", VA = "0x181A70DD0", Slot = "19")]
		public override RoguelikeSquadStartBattleButtonPluginBase GetCustomSquadStartBattleButtonPlugin()
		{
			return null;
		}

		// Token: 0x0602052F RID: 132399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602052F")]
		[Address(RVA = "0x1A70E40", Offset = "0x1A6FA40", VA = "0x181A70E40", Slot = "20")]
		public override RoguelikeSelectCharStashTicketButtonBase GetCustomStashTicketButtonPlugin()
		{
			return null;
		}

		// Token: 0x06020530 RID: 132400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020530")]
		[Address(RVA = "0x1A70BA0", Offset = "0x1A6F7A0", VA = "0x181A70BA0", Slot = "21")]
		public override UIGuidebookTrigger GetCustomSelectCharGuideBookTriggerAsset(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06020531 RID: 132401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020531")]
		[Address(RVA = "0x1A70A50", Offset = "0x1A6F650", VA = "0x181A70A50", Slot = "22")]
		public override string GetCustomSelectCharGuideBookSubSignal()
		{
			return null;
		}

		// Token: 0x06020532 RID: 132402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020532")]
		[Address(RVA = "0x1A709C0", Offset = "0x1A6F5C0", VA = "0x181A709C0", Slot = "18")]
		public override RoguelikeMenuButtonPluginBase GetCustomPendingEventSelectMenuPlugin(RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
			return null;
		}

		// Token: 0x06020533 RID: 132403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020533")]
		[Address(RVA = "0x1A71050", Offset = "0x1A6FC50", VA = "0x181A71050")]
		public RL05SelectCharMenuPluginContext()
		{
		}

		// Token: 0x06020534 RID: 132404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020534")]
		[Address(RVA = "0x1A71030", Offset = "0x1A6FC30", VA = "0x181A71030")]
		private RoguelikeSquadStartBattleButtonPluginBase <>xLuaBaseProxy_GetCustomSquadStartBattleButtonPlugin()
		{
			return null;
		}

		// Token: 0x06020535 RID: 132405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020535")]
		[Address(RVA = "0x1A71040", Offset = "0x1A6FC40", VA = "0x181A71040")]
		private RoguelikeSelectCharStashTicketButtonBase <>xLuaBaseProxy_GetCustomStashTicketButtonPlugin()
		{
			return null;
		}

		// Token: 0x06020536 RID: 132406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020536")]
		[Address(RVA = "0x1A71020", Offset = "0x1A6FC20", VA = "0x181A71020")]
		private UIGuidebookTrigger <>xLuaBaseProxy_GetCustomSelectCharGuideBookTriggerAsset(ILoadAsset P0)
		{
			return null;
		}

		// Token: 0x06020537 RID: 132407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020537")]
		[Address(RVA = "0x1A71010", Offset = "0x1A6FC10", VA = "0x181A71010")]
		private string <>xLuaBaseProxy_GetCustomSelectCharGuideBookSubSignal()
		{
			return null;
		}

		// Token: 0x06020538 RID: 132408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020538")]
		[Address(RVA = "0x1A71000", Offset = "0x1A6FC00", VA = "0x181A71000")]
		private RoguelikeMenuButtonPluginBase <>xLuaBaseProxy_GetCustomPendingEventSelectMenuPlugin(RoguelikeCharSelectStateBean.ShowConfig P0)
		{
			return null;
		}

		// Token: 0x0402BC05 RID: 179205
		[Token(Token = "0x402BC05")]
		private const string RL05_CAN_STASH_SELECT_SUBSIGNAL = "rl05_stash_select";

		// Token: 0x0402BC06 RID: 179206
		[Token(Token = "0x402BC06")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeSquadStartBattleButtonPluginBase _startBattleButtonPlugin;

		// Token: 0x0402BC07 RID: 179207
		[Token(Token = "0x402BC07")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeSquadStartBattleButtonPluginBase _startBattleSpZoneButtonPlugin;

		// Token: 0x0402BC08 RID: 179208
		[Token(Token = "0x402BC08")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeSelectCharStashTicketButtonBase _stashTicketButtonPlugin;

		// Token: 0x0402BC09 RID: 179209
		[Token(Token = "0x402BC09")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeMenuButtonPluginBase _pendingEventMenuButtonPlugin;

		// Token: 0x0402BC0A RID: 179210
		[Token(Token = "0x402BC0A")]
		[FieldOffset(Offset = "0x38")]
		private string m_topicId;

		// Token: 0x0402BC0B RID: 179211
		[Token(Token = "0x402BC0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402BC0C RID: 179212
		[Token(Token = "0x402BC0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BC0D RID: 179213
		[Token(Token = "0x402BC0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCustomSquadStartBattleButtonPlugin;

		// Token: 0x0402BC0E RID: 179214
		[Token(Token = "0x402BC0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCustomStashTicketButtonPlugin;

		// Token: 0x0402BC0F RID: 179215
		[Token(Token = "0x402BC0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCustomSelectCharGuideBookTriggerAsset;

		// Token: 0x0402BC10 RID: 179216
		[Token(Token = "0x402BC10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCustomSelectCharGuideBookSubSignal;

		// Token: 0x0402BC11 RID: 179217
		[Token(Token = "0x402BC11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCustomPendingEventSelectMenuPlugin;

		// Token: 0x0402BC12 RID: 179218
		[Token(Token = "0x402BC12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200560E RID: 22030
		[Token(Token = "0x200560E")]
		public class RL05SelectCharCardStartBattlePlugin : RoguelikeCharCardPlugin<RL05SelectCharMenuPluginContext>
		{
			// Token: 0x06020539 RID: 132409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020539")]
			[Address(RVA = "0x1A70950", Offset = "0x1A6F550", VA = "0x181A70950")]
			public RL05SelectCharCardStartBattlePlugin()
			{
			}

			// Token: 0x0402BC13 RID: 179219
			[Token(Token = "0x402BC13")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
