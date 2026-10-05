using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007573 RID: 30067
	[Token(Token = "0x2007573")]
	public class Act24sideBattleTrapSquadHomePluginView : SquadHomePluginView
	{
		// Token: 0x0602A53E RID: 173374 RVA: 0x000D80A8 File Offset: 0x000D62A8
		[Token(Token = "0x602A53E")]
		[Address(RVA = "0x25F8EF0", Offset = "0x25F7AF0", VA = "0x1825F8EF0", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602A53F RID: 173375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A53F")]
		[Address(RVA = "0x25F8F50", Offset = "0x25F7B50", VA = "0x1825F8F50", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0602A540 RID: 173376 RVA: 0x000D80C0 File Offset: 0x000D62C0
		[Token(Token = "0x602A540")]
		[Address(RVA = "0x25F9D20", Offset = "0x25F8920", VA = "0x1825F9D20")]
		private bool _TryShowNewTag()
		{
			return default(bool);
		}

		// Token: 0x0602A541 RID: 173377 RVA: 0x000D80D8 File Offset: 0x000D62D8
		[Token(Token = "0x602A541")]
		[Address(RVA = "0x25F92D0", Offset = "0x25F7ED0", VA = "0x1825F92D0")]
		private bool _CheckIfStageCanUseTool(Act24SideData act24SideData, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602A542 RID: 173378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A542")]
		[Address(RVA = "0x25F93D0", Offset = "0x25F7FD0", VA = "0x1825F93D0")]
		private List<string> _GetSelectTrapToolIconIdsList(SquadHomePlugin.PluginInputParams param)
		{
			return null;
		}

		// Token: 0x0602A543 RID: 173379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A543")]
		[Address(RVA = "0x25F9820", Offset = "0x25F8420", VA = "0x1825F9820")]
		private List<string> _GetSelectTrapToolIdsListFromPlayerData()
		{
			return null;
		}

		// Token: 0x0602A544 RID: 173380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A544")]
		[Address(RVA = "0x25F9470", Offset = "0x25F8070", VA = "0x1825F9470")]
		private List<string> _GetSelectTrapToolIdsListFromMem(string stageId)
		{
			return null;
		}

		// Token: 0x0602A545 RID: 173381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A545")]
		[Address(RVA = "0x25F9A70", Offset = "0x25F8670", VA = "0x1825F9A70")]
		private void _RefreshTrapItems(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0602A546 RID: 173382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A546")]
		[Address(RVA = "0x25F8BE0", Offset = "0x25F77E0", VA = "0x1825F8BE0", Slot = "11")]
		public override SquadHomeStartBattleServicePluginBase CreateStartBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A547 RID: 173383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A547")]
		[Address(RVA = "0x25F8B00", Offset = "0x25F7700", VA = "0x1825F8B00", Slot = "12")]
		public override SquadHomeFinishBattleServicePluginBase CreateFinishBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A548 RID: 173384 RVA: 0x000D80F0 File Offset: 0x000D62F0
		[Token(Token = "0x602A548")]
		[Address(RVA = "0x25F8E30", Offset = "0x25F7A30", VA = "0x1825F8E30", Slot = "13")]
		public override BattleActivityMeta OverrideActMeta(string activityId)
		{
			return default(BattleActivityMeta);
		}

		// Token: 0x0602A549 RID: 173385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A549")]
		[Address(RVA = "0x25F8CC0", Offset = "0x25F78C0", VA = "0x1825F8CC0")]
		public void OnClick()
		{
		}

		// Token: 0x0602A54A RID: 173386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A54A")]
		[Address(RVA = "0x25F9E60", Offset = "0x25F8A60", VA = "0x1825F9E60")]
		public Act24sideBattleTrapSquadHomePluginView()
		{
		}

		// Token: 0x0602A54B RID: 173387 RVA: 0x000D8108 File Offset: 0x000D6308
		[Token(Token = "0x602A54B")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602A54C RID: 173388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A54C")]
		[Address(RVA = "0x25EC5A0", Offset = "0x25EB1A0", VA = "0x1825EC5A0")]
		private SquadHomeStartBattleServicePluginBase <>xLuaBaseProxy_CreateStartBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A54D RID: 173389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A54D")]
		[Address(RVA = "0x25EC590", Offset = "0x25EB190", VA = "0x1825EC590")]
		private SquadHomeFinishBattleServicePluginBase <>xLuaBaseProxy_CreateFinishBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A54E RID: 173390 RVA: 0x000D8120 File Offset: 0x000D6320
		[Token(Token = "0x602A54E")]
		[Address(RVA = "0x25F92A0", Offset = "0x25F7EA0", VA = "0x1825F92A0")]
		private BattleActivityMeta <>xLuaBaseProxy_OverrideActMeta(string P0)
		{
			return default(BattleActivityMeta);
		}

		// Token: 0x0403CDFC RID: 249340
		[Token(Token = "0x403CDFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Act24sideBattleTrapSquadHomePluginItemView> _itemViewList;

		// Token: 0x0403CDFD RID: 249341
		[Token(Token = "0x403CDFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objNew;

		// Token: 0x0403CDFE RID: 249342
		[Token(Token = "0x403CDFE")]
		[FieldOffset(Offset = "0x40")]
		private string m_groupId;

		// Token: 0x0403CDFF RID: 249343
		[Token(Token = "0x403CDFF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_canEdit;

		// Token: 0x0403CE00 RID: 249344
		[Token(Token = "0x403CE00")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, Act24SideData.ToolData> m_toolDataList;

		// Token: 0x0403CE01 RID: 249345
		[Token(Token = "0x403CE01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403CE02 RID: 249346
		[Token(Token = "0x403CE02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403CE03 RID: 249347
		[Token(Token = "0x403CE03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryShowNewTag;

		// Token: 0x0403CE04 RID: 249348
		[Token(Token = "0x403CE04")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfStageCanUseTool;

		// Token: 0x0403CE05 RID: 249349
		[Token(Token = "0x403CE05")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSelectTrapToolIconIdsList;

		// Token: 0x0403CE06 RID: 249350
		[Token(Token = "0x403CE06")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSelectTrapToolIdsListFromPlayerData;

		// Token: 0x0403CE07 RID: 249351
		[Token(Token = "0x403CE07")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetSelectTrapToolIdsListFromMem;

		// Token: 0x0403CE08 RID: 249352
		[Token(Token = "0x403CE08")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshTrapItems;

		// Token: 0x0403CE09 RID: 249353
		[Token(Token = "0x403CE09")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateStartBattlePlugin;

		// Token: 0x0403CE0A RID: 249354
		[Token(Token = "0x403CE0A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateFinishBattlePlugin;

		// Token: 0x0403CE0B RID: 249355
		[Token(Token = "0x403CE0B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OverrideActMeta;

		// Token: 0x0403CE0C RID: 249356
		[Token(Token = "0x403CE0C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403CE0D RID: 249357
		[Token(Token = "0x403CE0D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
