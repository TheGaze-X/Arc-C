using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033AA RID: 13226
	[Token(Token = "0x20033AA")]
	public class UIBattleSandboxConstructCharacterMenuPanel : MonoBehaviour, UICharacterMenuState.IUICharacterMenuPanel, IHotfixable
	{
		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x060151BA RID: 86458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700321A")]
		private SandboxV2Data dataTable
		{
			[Token(Token = "0x60151BA")]
			[Address(RVA = "0xD885C0", Offset = "0xD871C0", VA = "0x180D885C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x060151BB RID: 86459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700321B")]
		private string topicId
		{
			[Token(Token = "0x60151BB")]
			[Address(RVA = "0xD88710", Offset = "0xD87310", VA = "0x180D88710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x060151BC RID: 86460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700321C")]
		private ConstructLandManager manager
		{
			[Token(Token = "0x60151BC")]
			[Address(RVA = "0xD88650", Offset = "0xD87250", VA = "0x180D88650")]
			get
			{
				return null;
			}
		}

		// Token: 0x060151BD RID: 86461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151BD")]
		[Address(RVA = "0xD86810", Offset = "0xD85410", VA = "0x180D86810")]
		public void OnUpgradeButtonClicked()
		{
		}

		// Token: 0x060151BE RID: 86462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151BE")]
		[Address(RVA = "0xD86B00", Offset = "0xD85700", VA = "0x180D86B00")]
		public void OnWithdrawButtonClicked()
		{
		}

		// Token: 0x060151BF RID: 86463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151BF")]
		[Address(RVA = "0xD865F0", Offset = "0xD851F0", VA = "0x180D865F0")]
		public void OnRepairButtonClicked()
		{
		}

		// Token: 0x060151C0 RID: 86464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C0")]
		[Address(RVA = "0xD86CD0", Offset = "0xD858D0", VA = "0x180D86CD0", Slot = "4")]
		public void Show(Character character)
		{
		}

		// Token: 0x060151C1 RID: 86465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C1")]
		[Address(RVA = "0xD86500", Offset = "0xD85100", VA = "0x180D86500", Slot = "5")]
		public void Hide()
		{
		}

		// Token: 0x060151C2 RID: 86466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C2")]
		[Address(RVA = "0xD87F60", Offset = "0xD86B60", VA = "0x180D87F60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060151C3 RID: 86467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C3")]
		[Address(RVA = "0xD88230", Offset = "0xD86E30", VA = "0x180D88230")]
		private void _SetData(Character character)
		{
		}

		// Token: 0x060151C4 RID: 86468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C4")]
		[Address(RVA = "0xD87E50", Offset = "0xD86A50", VA = "0x180D87E50")]
		private void _DoUpdateRangeToShow(Character character)
		{
		}

		// Token: 0x060151C5 RID: 86469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C5")]
		[Address(RVA = "0xD87AC0", Offset = "0xD866C0", VA = "0x180D87AC0")]
		private void _DoRenderWithdraw(Character character, string buildingId)
		{
		}

		// Token: 0x060151C6 RID: 86470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C6")]
		[Address(RVA = "0xD873D0", Offset = "0xD85FD0", VA = "0x180D873D0")]
		private void _DoRenderRepair(Character character)
		{
		}

		// Token: 0x060151C7 RID: 86471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C7")]
		[Address(RVA = "0xD87690", Offset = "0xD86290", VA = "0x180D87690")]
		private void _DoRenderUpgrade(Character character, string buildingId)
		{
		}

		// Token: 0x060151C8 RID: 86472 RVA: 0x0008A6A8 File Offset: 0x000888A8
		[Token(Token = "0x60151C8")]
		[Address(RVA = "0xD88000", Offset = "0xD86C00", VA = "0x180D88000")]
		private bool _IsResEnoughToUpgrade(BattleSandboxConstructItemListModel model, string buildingId)
		{
			return default(bool);
		}

		// Token: 0x060151C9 RID: 86473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151C9")]
		[Address(RVA = "0xD87180", Offset = "0xD85D80", VA = "0x180D87180")]
		private void _CreateEffectToSelectedCharacter(string commonKey, string giantOnlyKey)
		{
		}

		// Token: 0x060151CA RID: 86474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151CA")]
		[Address(RVA = "0xD883D0", Offset = "0xD86FD0", VA = "0x180D883D0")]
		public UIBattleSandboxConstructCharacterMenuPanel()
		{
		}

		// Token: 0x04019246 RID: 102982
		[Token(Token = "0x4019246")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x04019247 RID: 102983
		[Token(Token = "0x4019247")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _repairRoot;

		// Token: 0x04019248 RID: 102984
		[Token(Token = "0x4019248")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBattleSandboxConstructMenuItemList _repairList;

		// Token: 0x04019249 RID: 102985
		[Token(Token = "0x4019249")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _upgradeRoot;

		// Token: 0x0401924A RID: 102986
		[Token(Token = "0x401924A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIBattleSandboxConstructMenuItemList _upgradeList;

		// Token: 0x0401924B RID: 102987
		[Token(Token = "0x401924B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _withdrawRoot;

		// Token: 0x0401924C RID: 102988
		[Token(Token = "0x401924C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBattleSandboxConstructMenuItemList _withdrawList;

		// Token: 0x0401924D RID: 102989
		[Token(Token = "0x401924D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _repairEffectKey;

		// Token: 0x0401924E RID: 102990
		[Token(Token = "0x401924E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _repairEffectCommonKey;

		// Token: 0x0401924F RID: 102991
		[Token(Token = "0x401924F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _upgradeEffect;

		// Token: 0x04019250 RID: 102992
		[Token(Token = "0x4019250")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _upgradeCommonEffect;

		// Token: 0x04019251 RID: 102993
		[Token(Token = "0x4019251")]
		[FieldOffset(Offset = "0x70")]
		private BattleSandboxConstructItemListModel m_repairModel;

		// Token: 0x04019252 RID: 102994
		[Token(Token = "0x4019252")]
		[FieldOffset(Offset = "0x78")]
		private BattleSandboxConstructItemListModel m_upgradeModel;

		// Token: 0x04019253 RID: 102995
		[Token(Token = "0x4019253")]
		[FieldOffset(Offset = "0x80")]
		private BattleSandboxConstructItemListModel m_withdrawModel;

		// Token: 0x04019254 RID: 102996
		[Token(Token = "0x4019254")]
		[FieldOffset(Offset = "0x88")]
		private ListDict<string, int> m_upgradeCostCache;

		// Token: 0x04019255 RID: 102997
		[Token(Token = "0x4019255")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x04019256 RID: 102998
		[Token(Token = "0x4019256")]
		[FieldOffset(Offset = "0x91")]
		private bool m_operationExecuted;

		// Token: 0x04019257 RID: 102999
		[Token(Token = "0x4019257")]
		[FieldOffset(Offset = "0x98")]
		private ConstructLandManager m_manager;

		// Token: 0x04019258 RID: 103000
		[Token(Token = "0x4019258")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public UIBattleSandboxConstructCharacterMenuPanel.OnConstructMenuHide onHide;

		// Token: 0x04019259 RID: 103001
		[Token(Token = "0x4019259")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action<Character> onCharacterClicked;

		// Token: 0x0401925A RID: 103002
		[Token(Token = "0x401925A")]
		[FieldOffset(Offset = "0xB0")]
		private ObjectPtr<Character> m_character;

		// Token: 0x0401925B RID: 103003
		[Token(Token = "0x401925B")]
		[FieldOffset(Offset = "0xC0")]
		private string m_buildingOrBasePortTrapId;

		// Token: 0x0401925C RID: 103004
		[Token(Token = "0x401925C")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isOpen;

		// Token: 0x0401925D RID: 103005
		[Token(Token = "0x401925D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataTable;

		// Token: 0x0401925E RID: 103006
		[Token(Token = "0x401925E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401925F RID: 103007
		[Token(Token = "0x401925F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_manager;

		// Token: 0x04019260 RID: 103008
		[Token(Token = "0x4019260")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpgradeButtonClicked;

		// Token: 0x04019261 RID: 103009
		[Token(Token = "0x4019261")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnWithdrawButtonClicked;

		// Token: 0x04019262 RID: 103010
		[Token(Token = "0x4019262")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRepairButtonClicked;

		// Token: 0x04019263 RID: 103011
		[Token(Token = "0x4019263")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04019264 RID: 103012
		[Token(Token = "0x4019264")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04019265 RID: 103013
		[Token(Token = "0x4019265")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019266 RID: 103014
		[Token(Token = "0x4019266")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x04019267 RID: 103015
		[Token(Token = "0x4019267")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoUpdateRangeToShow;

		// Token: 0x04019268 RID: 103016
		[Token(Token = "0x4019268")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoRenderWithdraw;

		// Token: 0x04019269 RID: 103017
		[Token(Token = "0x4019269")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoRenderRepair;

		// Token: 0x0401926A RID: 103018
		[Token(Token = "0x401926A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoRenderUpgrade;

		// Token: 0x0401926B RID: 103019
		[Token(Token = "0x401926B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsResEnoughToUpgrade;

		// Token: 0x0401926C RID: 103020
		[Token(Token = "0x401926C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CreateEffectToSelectedCharacter;

		// Token: 0x0401926D RID: 103021
		[Token(Token = "0x401926D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033AB RID: 13227
		// (Invoke) Token: 0x060151CC RID: 86476
		[Token(Token = "0x20033AB")]
		public delegate void OnConstructMenuHide(bool opExecuted);
	}
}
