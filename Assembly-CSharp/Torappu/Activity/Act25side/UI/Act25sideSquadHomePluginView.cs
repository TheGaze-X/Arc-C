using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side.UI
{
	// Token: 0x0200753C RID: 30012
	[Token(Token = "0x200753C")]
	public class Act25sideSquadHomePluginView : SquadHomePluginView
	{
		// Token: 0x0602A470 RID: 173168 RVA: 0x000D7EB0 File Offset: 0x000D60B0
		[Token(Token = "0x602A470")]
		[Address(RVA = "0x25EBDE0", Offset = "0x25EA9E0", VA = "0x1825EBDE0", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602A471 RID: 173169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A471")]
		[Address(RVA = "0x25EBCB0", Offset = "0x25EA8B0", VA = "0x1825EBCB0", Slot = "9")]
		protected override void OnSquadGroupChanged(SquadGroupViewModel groupModel)
		{
		}

		// Token: 0x0602A472 RID: 173170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A472")]
		[Address(RVA = "0x25EBE40", Offset = "0x25EAA40", VA = "0x1825EBE40", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0602A473 RID: 173171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A473")]
		[Address(RVA = "0x25EC5B0", Offset = "0x25EB1B0", VA = "0x1825EC5B0")]
		private void _Render(Dictionary<Act25SideData.Act25sideTechType, Act25sideSquadHomePluginView.TechData> slotData)
		{
		}

		// Token: 0x0602A474 RID: 173172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A474")]
		[Address(RVA = "0x25EC800", Offset = "0x25EB400", VA = "0x1825EC800")]
		private void _TryUpdateLeftArrowStatus(SquadGroupViewModel squadGroupModel)
		{
		}

		// Token: 0x0602A475 RID: 173173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A475")]
		[Address(RVA = "0x25EBB50", Offset = "0x25EA750", VA = "0x1825EBB50")]
		public void OnShowDetailClicked()
		{
		}

		// Token: 0x0602A476 RID: 173174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A476")]
		[Address(RVA = "0x25EBAC0", Offset = "0x25EA6C0", VA = "0x1825EBAC0", Slot = "11")]
		public override SquadHomeStartBattleServicePluginBase CreateStartBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A477 RID: 173175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A477")]
		[Address(RVA = "0x25EBA30", Offset = "0x25EA630", VA = "0x1825EBA30", Slot = "12")]
		public override SquadHomeFinishBattleServicePluginBase CreateFinishBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A478 RID: 173176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A478")]
		[Address(RVA = "0x25EC8E0", Offset = "0x25EB4E0", VA = "0x1825EC8E0")]
		public Act25sideSquadHomePluginView()
		{
		}

		// Token: 0x0602A479 RID: 173177 RVA: 0x000D7EC8 File Offset: 0x000D60C8
		[Token(Token = "0x602A479")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602A47A RID: 173178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A47A")]
		[Address(RVA = "0x1EB7190", Offset = "0x1EB5D90", VA = "0x181EB7190")]
		private void <>xLuaBaseProxy_OnSquadGroupChanged(SquadGroupViewModel P0)
		{
		}

		// Token: 0x0602A47B RID: 173179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A47B")]
		[Address(RVA = "0x25EC5A0", Offset = "0x25EB1A0", VA = "0x1825EC5A0")]
		private SquadHomeStartBattleServicePluginBase <>xLuaBaseProxy_CreateStartBattlePlugin()
		{
			return null;
		}

		// Token: 0x0602A47C RID: 173180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A47C")]
		[Address(RVA = "0x25EC590", Offset = "0x25EB190", VA = "0x1825EC590")]
		private SquadHomeFinishBattleServicePluginBase <>xLuaBaseProxy_CreateFinishBattlePlugin()
		{
			return null;
		}

		// Token: 0x0403CCA4 RID: 248996
		[Token(Token = "0x403CCA4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act25sideSquadHomePluginView.SlotItem[] _slotItems;

		// Token: 0x0403CCA5 RID: 248997
		[Token(Token = "0x403CCA5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403CCA6 RID: 248998
		[Token(Token = "0x403CCA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _techTypeConfigs;

		// Token: 0x0403CCA7 RID: 248999
		[Token(Token = "0x403CCA7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _techRarityBkgConfigs;

		// Token: 0x0403CCA8 RID: 249000
		[Token(Token = "0x403CCA8")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isRetro;

		// Token: 0x0403CCA9 RID: 249001
		[Token(Token = "0x403CCA9")]
		[FieldOffset(Offset = "0x58")]
		private string m_groupId;

		// Token: 0x0403CCAA RID: 249002
		[Token(Token = "0x403CCAA")]
		[FieldOffset(Offset = "0x60")]
		private string m_stageId;

		// Token: 0x0403CCAB RID: 249003
		[Token(Token = "0x403CCAB")]
		[FieldOffset(Offset = "0x68")]
		private StageData m_stageData;

		// Token: 0x0403CCAC RID: 249004
		[Token(Token = "0x403CCAC")]
		[FieldOffset(Offset = "0x70")]
		private bool m_showStatus;

		// Token: 0x0403CCAD RID: 249005
		[Token(Token = "0x403CCAD")]
		[FieldOffset(Offset = "0x71")]
		private bool m_canEdit;

		// Token: 0x0403CCAE RID: 249006
		[Token(Token = "0x403CCAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403CCAF RID: 249007
		[Token(Token = "0x403CCAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSquadGroupChanged;

		// Token: 0x0403CCB0 RID: 249008
		[Token(Token = "0x403CCB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403CCB1 RID: 249009
		[Token(Token = "0x403CCB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403CCB2 RID: 249010
		[Token(Token = "0x403CCB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryUpdateLeftArrowStatus;

		// Token: 0x0403CCB3 RID: 249011
		[Token(Token = "0x403CCB3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnShowDetailClicked;

		// Token: 0x0403CCB4 RID: 249012
		[Token(Token = "0x403CCB4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateStartBattlePlugin;

		// Token: 0x0403CCB5 RID: 249013
		[Token(Token = "0x403CCB5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateFinishBattlePlugin;

		// Token: 0x0403CCB6 RID: 249014
		[Token(Token = "0x403CCB6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200753D RID: 30013
		[Token(Token = "0x200753D")]
		private class TechData : IHotfixable
		{
			// Token: 0x0602A47D RID: 173181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A47D")]
			[Address(RVA = "0x25F02B0", Offset = "0x25EEEB0", VA = "0x1825F02B0")]
			public TechData()
			{
			}

			// Token: 0x0403CCB7 RID: 249015
			[Token(Token = "0x403CCB7")]
			[FieldOffset(Offset = "0x10")]
			public string techId;

			// Token: 0x0403CCB8 RID: 249016
			[Token(Token = "0x403CCB8")]
			[FieldOffset(Offset = "0x18")]
			public int techSortId;

			// Token: 0x0403CCB9 RID: 249017
			[Token(Token = "0x403CCB9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200753E RID: 30014
		[Token(Token = "0x200753E")]
		[Serializable]
		private class SlotItem : IHotfixable
		{
			// Token: 0x0602A47E RID: 173182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A47E")]
			[Address(RVA = "0x25F0090", Offset = "0x25EEC90", VA = "0x1825F0090")]
			public void Render(Act25sideSquadHomePluginView.TechData techData, SpriteRenderData raritySprite, SpriteRenderData iconSprite)
			{
			}

			// Token: 0x0602A47F RID: 173183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A47F")]
			[Address(RVA = "0x25F0250", Offset = "0x25EEE50", VA = "0x1825F0250")]
			public SlotItem()
			{
			}

			// Token: 0x0403CCBA RID: 249018
			[Token(Token = "0x403CCBA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UIAtlasImage _imgBkg;

			// Token: 0x0403CCBB RID: 249019
			[Token(Token = "0x403CCBB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAtlasImage _imgIcon;

			// Token: 0x0403CCBC RID: 249020
			[Token(Token = "0x403CCBC")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _panelPlus;

			// Token: 0x0403CCBD RID: 249021
			[Token(Token = "0x403CCBD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403CCBE RID: 249022
			[Token(Token = "0x403CCBE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
