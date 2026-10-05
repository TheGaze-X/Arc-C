using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200797C RID: 31100
	[Token(Token = "0x200797C")]
	public class Act1ArcadeSquadPlugin : DefaultCommonSquadPlugin
	{
		// Token: 0x0602B9FE RID: 178686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9FE")]
		[Address(RVA = "0x2789430", Offset = "0x2788030", VA = "0x182789430")]
		private Act1ArcadeSquadPlugin.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0602B9FF RID: 178687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9FF")]
		[Address(RVA = "0x2789270", Offset = "0x2787E70", VA = "0x182789270")]
		private Act1ArcadeSquadPlugin.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x0602BA00 RID: 178688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA00")]
		[Address(RVA = "0x2789570", Offset = "0x2788170", VA = "0x182789570")]
		private Act1ArcadeSquadPlugin.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x0602BA01 RID: 178689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA01")]
		[Address(RVA = "0x2789AD0", Offset = "0x27886D0", VA = "0x182789AD0")]
		private void _SaveData(Act1ArcadeSquadPlugin.ActData data)
		{
		}

		// Token: 0x0602BA02 RID: 178690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA02")]
		[Address(RVA = "0x2788220", Offset = "0x2786E20", VA = "0x182788220", Slot = "40")]
		public override ICustomSquadGroupViewModel GetCustomViewModel()
		{
			return null;
		}

		// Token: 0x0602BA03 RID: 178691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA03")]
		[Address(RVA = "0x2788AF0", Offset = "0x27876F0", VA = "0x182788AF0", Slot = "67")]
		public override List<CommonSquadSingleSquadViewModel> LoadSquadCache()
		{
			return null;
		}

		// Token: 0x0602BA04 RID: 178692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA04")]
		[Address(RVA = "0x27896A0", Offset = "0x27882A0", VA = "0x1827896A0")]
		private ICommonSquadChar[] _LoadActCacheSquad()
		{
			return null;
		}

		// Token: 0x0602BA05 RID: 178693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA05")]
		[Address(RVA = "0x2788CF0", Offset = "0x27878F0", VA = "0x182788CF0", Slot = "68")]
		public override void SaveSquadCache()
		{
		}

		// Token: 0x0602BA06 RID: 178694 RVA: 0x000DCA58 File Offset: 0x000DAC58
		[Token(Token = "0x602BA06")]
		[Address(RVA = "0x2788880", Offset = "0x2787480", VA = "0x182788880", Slot = "73")]
		public override int GetMaxAssistCount()
		{
			return 0;
		}

		// Token: 0x0602BA07 RID: 178695 RVA: 0x000DCA70 File Offset: 0x000DAC70
		[Token(Token = "0x602BA07")]
		[Address(RVA = "0x2788820", Offset = "0x2787420", VA = "0x182788820", Slot = "74")]
		protected override bool GetIsSlotMaxIncludeAssistCount()
		{
			return default(bool);
		}

		// Token: 0x0602BA08 RID: 178696 RVA: 0x000DCA88 File Offset: 0x000DAC88
		[Token(Token = "0x602BA08")]
		[Address(RVA = "0x2788550", Offset = "0x2787150", VA = "0x182788550", Slot = "52")]
		public override GameModeMeta GetGameModeMeta()
		{
			return default(GameModeMeta);
		}

		// Token: 0x0602BA09 RID: 178697 RVA: 0x000DCAA0 File Offset: 0x000DACA0
		[Token(Token = "0x602BA09")]
		[Address(RVA = "0x27881C0", Offset = "0x2786DC0", VA = "0x1827881C0", Slot = "54")]
		public override BattleSysMenuStyle GetBattleSysMenuStyle()
		{
			return BattleSysMenuStyle.DEFAULT;
		}

		// Token: 0x0602BA0A RID: 178698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA0A")]
		[Address(RVA = "0x27888E0", Offset = "0x27874E0", VA = "0x1827888E0", Slot = "46")]
		public override IStartBattleServiceConfig GetStartBattleServiceConfig(CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend)
		{
			return null;
		}

		// Token: 0x0602BA0B RID: 178699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA0B")]
		[Address(RVA = "0x27883E0", Offset = "0x2786FE0", VA = "0x1827883E0", Slot = "47")]
		public override IFinishBattleServiceConfig GetFinishBattleServiceConfig()
		{
			return null;
		}

		// Token: 0x0602BA0C RID: 178700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA0C")]
		[Address(RVA = "0x2789B60", Offset = "0x2788760", VA = "0x182789B60")]
		public Act1ArcadeSquadPlugin()
		{
		}

		// Token: 0x0602BA0D RID: 178701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA0D")]
		[Address(RVA = "0x2789250", Offset = "0x2787E50", VA = "0x182789250")]
		private ICustomSquadGroupViewModel <>xLuaBaseProxy_GetCustomViewModel()
		{
			return null;
		}

		// Token: 0x0602BA0E RID: 178702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA0E")]
		[Address(RVA = "0x2789260", Offset = "0x2787E60", VA = "0x182789260")]
		private List<CommonSquadSingleSquadViewModel> <>xLuaBaseProxy_LoadSquadCache()
		{
			return null;
		}

		// Token: 0x0403F1AD RID: 258477
		[Token(Token = "0x403F1AD")]
		public const string KEY_ZONE_ID = "KEY_ZONE_ID";

		// Token: 0x0403F1AE RID: 258478
		[Token(Token = "0x403F1AE")]
		[FieldOffset(Offset = "0x18")]
		private MemUserDataStore.Data<Act1ArcadeSquadPlugin.ActData> m_memData;

		// Token: 0x0403F1AF RID: 258479
		[Token(Token = "0x403F1AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403F1B0 RID: 258480
		[Token(Token = "0x403F1B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0403F1B1 RID: 258481
		[Token(Token = "0x403F1B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x0403F1B2 RID: 258482
		[Token(Token = "0x403F1B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0403F1B3 RID: 258483
		[Token(Token = "0x403F1B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCustomViewModel;

		// Token: 0x0403F1B4 RID: 258484
		[Token(Token = "0x403F1B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadSquadCache;

		// Token: 0x0403F1B5 RID: 258485
		[Token(Token = "0x403F1B5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadActCacheSquad;

		// Token: 0x0403F1B6 RID: 258486
		[Token(Token = "0x403F1B6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveSquadCache;

		// Token: 0x0403F1B7 RID: 258487
		[Token(Token = "0x403F1B7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMaxAssistCount;

		// Token: 0x0403F1B8 RID: 258488
		[Token(Token = "0x403F1B8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetIsSlotMaxIncludeAssistCount;

		// Token: 0x0403F1B9 RID: 258489
		[Token(Token = "0x403F1B9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetGameModeMeta;

		// Token: 0x0403F1BA RID: 258490
		[Token(Token = "0x403F1BA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetBattleSysMenuStyle;

		// Token: 0x0403F1BB RID: 258491
		[Token(Token = "0x403F1BB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetStartBattleServiceConfig;

		// Token: 0x0403F1BC RID: 258492
		[Token(Token = "0x403F1BC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetFinishBattleServiceConfig;

		// Token: 0x0403F1BD RID: 258493
		[Token(Token = "0x403F1BD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200797D RID: 31101
		[Token(Token = "0x200797D")]
		public class Act1ArcadeSquadCustomData : CustomSquadGroupViewModelForMainlineTypeSquad
		{
			// Token: 0x0602BA0F RID: 178703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BA0F")]
			[Address(RVA = "0x2787FE0", Offset = "0x2786BE0", VA = "0x182787FE0", Slot = "8")]
			protected override void LoadCustomData(CommonSquadGroupViewModel squadGroupViewModel)
			{
			}

			// Token: 0x0602BA10 RID: 178704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BA10")]
			[Address(RVA = "0x2788160", Offset = "0x2786D60", VA = "0x182788160")]
			public Act1ArcadeSquadCustomData()
			{
			}

			// Token: 0x0602BA11 RID: 178705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BA11")]
			[Address(RVA = "0x2788150", Offset = "0x2786D50", VA = "0x182788150")]
			private void <>xLuaBaseProxy_LoadCustomData(CommonSquadGroupViewModel P0)
			{
			}

			// Token: 0x0403F1BE RID: 258494
			[Token(Token = "0x403F1BE")]
			[FieldOffset(Offset = "0x18")]
			public string zoneId;

			// Token: 0x0403F1BF RID: 258495
			[Token(Token = "0x403F1BF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadCustomData;

			// Token: 0x0403F1C0 RID: 258496
			[Token(Token = "0x403F1C0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200797E RID: 31102
		[Token(Token = "0x200797E")]
		private class DataInAct
		{
			// Token: 0x0602BA12 RID: 178706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BA12")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x0403F1C1 RID: 258497
			[Token(Token = "0x403F1C1")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, List<DefaultCommonCharCardViewModel.DefaultCharCache>> squadCacheDict;
		}

		// Token: 0x0200797F RID: 31103
		[Token(Token = "0x200797F")]
		private class ActData
		{
			// Token: 0x0602BA13 RID: 178707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BA13")]
			[Address(RVA = "0x27913D0", Offset = "0x278FFD0", VA = "0x1827913D0")]
			public ActData()
			{
			}

			// Token: 0x0403F1C2 RID: 258498
			[Token(Token = "0x403F1C2")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403F1C3 RID: 258499
			[Token(Token = "0x403F1C3")]
			[FieldOffset(Offset = "0x18")]
			public Act1ArcadeSquadPlugin.DataInAct dataInAct;
		}
	}
}
