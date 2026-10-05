using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033BB RID: 13243
	[Token(Token = "0x20033BB")]
	public class UIBattleSandboxConstructMenuItemList : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601522C RID: 86572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601522C")]
		[Address(RVA = "0xD8A510", Offset = "0xD89110", VA = "0x180D8A510")]
		public void Init()
		{
		}

		// Token: 0x0601522D RID: 86573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601522D")]
		[Address(RVA = "0xD8A6A0", Offset = "0xD892A0", VA = "0x180D8A6A0")]
		public void Render(BattleSandboxConstructItemListModel model)
		{
		}

		// Token: 0x0601522E RID: 86574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601522E")]
		[Address(RVA = "0xD8ABD0", Offset = "0xD897D0", VA = "0x180D8ABD0")]
		private void _HideAll()
		{
		}

		// Token: 0x0601522F RID: 86575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601522F")]
		[Address(RVA = "0xD8ACA0", Offset = "0xD898A0", VA = "0x180D8ACA0")]
		private void _UpdateNormalList(BattleSandboxConstructItemListModel model)
		{
		}

		// Token: 0x06015230 RID: 86576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015230")]
		[Address(RVA = "0xD8ADD0", Offset = "0xD899D0", VA = "0x180D8ADD0")]
		public UIBattleSandboxConstructMenuItemList()
		{
		}

		// Token: 0x0401931D RID: 103197
		[Token(Token = "0x401931D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBattleSandboxConstructMenuItemList.ShowType _showType;

		// Token: 0x0401931E RID: 103198
		[Token(Token = "0x401931E")]
		[FieldOffset(Offset = "0x20")]
		[Group("Root")]
		[SerializeField]
		private Transform _costRoot;

		// Token: 0x0401931F RID: 103199
		[Token(Token = "0x401931F")]
		[FieldOffset(Offset = "0x28")]
		[Group("Root")]
		[SerializeField]
		private Transform _repairCostRoot;

		// Token: 0x04019320 RID: 103200
		[Token(Token = "0x4019320")]
		[FieldOffset(Offset = "0x30")]
		[Group("Root")]
		[SerializeField]
		private Transform _repairWhenUpgradeRoot;

		// Token: 0x04019321 RID: 103201
		[Token(Token = "0x4019321")]
		[FieldOffset(Offset = "0x38")]
		[Group("Root")]
		[SerializeField]
		private Transform _notUnlockRoot;

		// Token: 0x04019322 RID: 103202
		[Token(Token = "0x4019322")]
		[FieldOffset(Offset = "0x40")]
		[Group("Color")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x04019323 RID: 103203
		[Token(Token = "0x4019323")]
		[FieldOffset(Offset = "0x50")]
		[Group("Color")]
		[SerializeField]
		private Color _warningColor;

		// Token: 0x04019324 RID: 103204
		[Token(Token = "0x4019324")]
		[FieldOffset(Offset = "0x60")]
		[Group("Color")]
		private float _matColorAlpha;

		// Token: 0x04019325 RID: 103205
		[Token(Token = "0x4019325")]
		[FieldOffset(Offset = "0x68")]
		[Group("Cost")]
		[SerializeField]
		private SimpleLayoutContent _costLayout;

		// Token: 0x04019326 RID: 103206
		[Token(Token = "0x4019326")]
		[FieldOffset(Offset = "0x70")]
		[Group("Cost")]
		[SerializeField]
		private Image _costBg;

		// Token: 0x04019327 RID: 103207
		[Token(Token = "0x4019327")]
		[FieldOffset(Offset = "0x78")]
		[Group("Repair")]
		[SerializeField]
		private Text _repairText;

		// Token: 0x04019328 RID: 103208
		[Token(Token = "0x4019328")]
		[FieldOffset(Offset = "0x80")]
		[Group("Repair")]
		[SerializeField]
		private Image _repairBg;

		// Token: 0x04019329 RID: 103209
		[Token(Token = "0x4019329")]
		[FieldOffset(Offset = "0x88")]
		[Group("Upgrade")]
		[SerializeField]
		private Text _notUnlockText;

		// Token: 0x0401932A RID: 103210
		[Token(Token = "0x401932A")]
		[FieldOffset(Offset = "0x90")]
		[Group("Upgrade")]
		[SerializeField]
		private Image _repairWhenUpgradeBg;

		// Token: 0x0401932B RID: 103211
		[Token(Token = "0x401932B")]
		[FieldOffset(Offset = "0x98")]
		[Group("Upgrade")]
		[SerializeField]
		private Text _repairWhenUpgradeText;

		// Token: 0x0401932C RID: 103212
		[Token(Token = "0x401932C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _btn;

		// Token: 0x0401932D RID: 103213
		[Token(Token = "0x401932D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _btnIcon;

		// Token: 0x0401932E RID: 103214
		[Token(Token = "0x401932E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Sprite _iconValid;

		// Token: 0x0401932F RID: 103215
		[Token(Token = "0x401932F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Sprite _iconNotValid;

		// Token: 0x04019330 RID: 103216
		[Token(Token = "0x4019330")]
		[FieldOffset(Offset = "0xC0")]
		private UIBattleSandboxConstructMenuItemList.PairListAdapter m_costAdapter;

		// Token: 0x04019331 RID: 103217
		[Token(Token = "0x4019331")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04019332 RID: 103218
		[Token(Token = "0x4019332")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019333 RID: 103219
		[Token(Token = "0x4019333")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HideAll;

		// Token: 0x04019334 RID: 103220
		[Token(Token = "0x4019334")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateNormalList;

		// Token: 0x04019335 RID: 103221
		[Token(Token = "0x4019335")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033BC RID: 13244
		[Token(Token = "0x20033BC")]
		public enum ShowType
		{
			// Token: 0x04019337 RID: 103223
			[Token(Token = "0x4019337")]
			NONE,
			// Token: 0x04019338 RID: 103224
			[Token(Token = "0x4019338")]
			REPAIR,
			// Token: 0x04019339 RID: 103225
			[Token(Token = "0x4019339")]
			UPGRADE,
			// Token: 0x0401933A RID: 103226
			[Token(Token = "0x401933A")]
			WITHDRAW
		}

		// Token: 0x020033BD RID: 13245
		[Token(Token = "0x20033BD")]
		private class PairListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700322A RID: 12842
			// (get) Token: 0x06015231 RID: 86577 RVA: 0x0008A840 File Offset: 0x00088A40
			[Token(Token = "0x1700322A")]
			public override int count
			{
				[Token(Token = "0x6015231")]
				[Address(RVA = "0xD82BA0", Offset = "0xD817A0", VA = "0x180D82BA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06015232 RID: 86578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015232")]
			[Address(RVA = "0xD82A00", Offset = "0xD81600", VA = "0x180D82A00")]
			public PairListAdapter(UIBattleSandboxConstructMenuItemList holder)
			{
			}

			// Token: 0x06015233 RID: 86579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015233")]
			[Address(RVA = "0xD825D0", Offset = "0xD811D0", VA = "0x180D825D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401933B RID: 103227
			[Token(Token = "0x401933B")]
			[FieldOffset(Offset = "0x20")]
			public BattleSandboxConstructItemListModel model;

			// Token: 0x0401933C RID: 103228
			[Token(Token = "0x401933C")]
			[FieldOffset(Offset = "0x28")]
			public UIBattleSandboxConstructMenuItemList.ShowType showType;

			// Token: 0x0401933D RID: 103229
			[Token(Token = "0x401933D")]
			[FieldOffset(Offset = "0x30")]
			private UIBattleSandboxConstructMenuItemList m_holder;

			// Token: 0x0401933E RID: 103230
			[Token(Token = "0x401933E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401933F RID: 103231
			[Token(Token = "0x401933F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019340 RID: 103232
			[Token(Token = "0x4019340")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
