using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D75 RID: 23925
	[Token(Token = "0x2005D75")]
	public class ClimbTowerSquadMultiEditCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051C4 RID: 20932
		// (get) Token: 0x06022AC8 RID: 142024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022AC9 RID: 142025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051C4")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x6022AC8")]
			[Address(RVA = "0x1D3C600", Offset = "0x1D3B200", VA = "0x181D3C600")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022AC9")]
			[Address(RVA = "0x1D3C6E0", Offset = "0x1D3B2E0", VA = "0x181D3C6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051C5 RID: 20933
		// (get) Token: 0x06022ACA RID: 142026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022ACB RID: 142027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051C5")]
		public Action<int, string> onEquipSelect
		{
			[Token(Token = "0x6022ACA")]
			[Address(RVA = "0x1D3C5A0", Offset = "0x1D3B1A0", VA = "0x181D3C5A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022ACB")]
			[Address(RVA = "0x1D3C660", Offset = "0x1D3B260", VA = "0x181D3C660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022ACC RID: 142028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ACC")]
		[Address(RVA = "0x1D3BCA0", Offset = "0x1D3A8A0", VA = "0x181D3BCA0")]
		public void UpdateViewData(ClimbTowerSquadMultiEditCharModel charEditModel, ClimbTowerSquadMultiEditModel.EditType editType, bool needRebuild)
		{
		}

		// Token: 0x06022ACD RID: 142029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ACD")]
		[Address(RVA = "0x1D3C010", Offset = "0x1D3AC10", VA = "0x181D3C010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022ACE RID: 142030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ACE")]
		[Address(RVA = "0x1D3C430", Offset = "0x1D3B030", VA = "0x181D3C430")]
		private void _SetScrollViewDragDelegate()
		{
		}

		// Token: 0x06022ACF RID: 142031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ACF")]
		[Address(RVA = "0x1D3C530", Offset = "0x1D3B130", VA = "0x181D3C530")]
		public ClimbTowerSquadMultiEditCharItemView()
		{
		}

		// Token: 0x0402FA8B RID: 195211
		[Token(Token = "0x402FA8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _charCardParent;

		// Token: 0x0402FA8C RID: 195212
		[Token(Token = "0x402FA8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _skillList;

		// Token: 0x0402FA8D RID: 195213
		[Token(Token = "0x402FA8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _equipList;

		// Token: 0x0402FA8E RID: 195214
		[Token(Token = "0x402FA8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _charCardScale;

		// Token: 0x0402FA8F RID: 195215
		[Token(Token = "0x402FA8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _trackNewGo;

		// Token: 0x0402FA90 RID: 195216
		[Token(Token = "0x402FA90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _equipContentRectTransform;

		// Token: 0x0402FA91 RID: 195217
		[Token(Token = "0x402FA91")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIWrappedScrollRect _equipScrollRect;

		// Token: 0x0402FA92 RID: 195218
		[Token(Token = "0x402FA92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _equipScrollMaxHeight;

		// Token: 0x0402FA93 RID: 195219
		[Token(Token = "0x402FA93")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _equipScrollLimitHeight;

		// Token: 0x0402FA94 RID: 195220
		[Token(Token = "0x402FA94")]
		[FieldOffset(Offset = "0x58")]
		private UICharacterCardPanel m_charCard;

		// Token: 0x0402FA95 RID: 195221
		[Token(Token = "0x402FA95")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402FA96 RID: 195222
		[Token(Token = "0x402FA96")]
		[FieldOffset(Offset = "0x68")]
		private ClimbTowerSquadMultiEditCharItemView.SkillListAdapter m_skillAdapter;

		// Token: 0x0402FA97 RID: 195223
		[Token(Token = "0x402FA97")]
		[FieldOffset(Offset = "0x70")]
		private ClimbTowerSquadMultiEditCharItemView.EquipListAdapter m_equipAdapter;

		// Token: 0x0402FA98 RID: 195224
		[Token(Token = "0x402FA98")]
		[FieldOffset(Offset = "0x78")]
		private ClimbTowerSquadMultiEditCharModel m_charEditModel;

		// Token: 0x0402FA99 RID: 195225
		[Token(Token = "0x402FA99")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerSquadMultiEditModel.EditType m_editType;

		// Token: 0x0402FA9A RID: 195226
		[Token(Token = "0x402FA9A")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402FA9D RID: 195229
		[Token(Token = "0x402FA9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x0402FA9E RID: 195230
		[Token(Token = "0x402FA9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x0402FA9F RID: 195231
		[Token(Token = "0x402FA9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onEquipSelect;

		// Token: 0x0402FAA0 RID: 195232
		[Token(Token = "0x402FAA0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onEquipSelect;

		// Token: 0x0402FAA1 RID: 195233
		[Token(Token = "0x402FAA1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateViewData;

		// Token: 0x0402FAA2 RID: 195234
		[Token(Token = "0x402FAA2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FAA3 RID: 195235
		[Token(Token = "0x402FAA3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetScrollViewDragDelegate;

		// Token: 0x0402FAA4 RID: 195236
		[Token(Token = "0x402FAA4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D76 RID: 23926
		[Token(Token = "0x2005D76")]
		private class EquipListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022AD0 RID: 142032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AD0")]
			[Address(RVA = "0x1D470A0", Offset = "0x1D45CA0", VA = "0x181D470A0")]
			public EquipListAdapter(ClimbTowerSquadMultiEditCharItemView closure)
			{
			}

			// Token: 0x170051C6 RID: 20934
			// (get) Token: 0x06022AD1 RID: 142033 RVA: 0x000BE620 File Offset: 0x000BC820
			[Token(Token = "0x170051C6")]
			public override int count
			{
				[Token(Token = "0x6022AD1")]
				[Address(RVA = "0x1D47120", Offset = "0x1D45D20", VA = "0x181D47120", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022AD2 RID: 142034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022AD2")]
			[Address(RVA = "0x1D46DC0", Offset = "0x1D459C0", VA = "0x181D46DC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FAA5 RID: 195237
			[Token(Token = "0x402FAA5")]
			private const int EQUIP_SLOT_COUNT = 3;

			// Token: 0x0402FAA6 RID: 195238
			[Token(Token = "0x402FAA6")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadMultiEditCharItemView m_closure;

			// Token: 0x0402FAA7 RID: 195239
			[Token(Token = "0x402FAA7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FAA8 RID: 195240
			[Token(Token = "0x402FAA8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FAA9 RID: 195241
			[Token(Token = "0x402FAA9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005D77 RID: 23927
		[Token(Token = "0x2005D77")]
		private class SkillListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022AD3 RID: 142035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AD3")]
			[Address(RVA = "0x1D48030", Offset = "0x1D46C30", VA = "0x181D48030")]
			public SkillListAdapter(ClimbTowerSquadMultiEditCharItemView closure)
			{
			}

			// Token: 0x170051C7 RID: 20935
			// (get) Token: 0x06022AD4 RID: 142036 RVA: 0x000BE638 File Offset: 0x000BC838
			[Token(Token = "0x170051C7")]
			public override int count
			{
				[Token(Token = "0x6022AD4")]
				[Address(RVA = "0x1D480B0", Offset = "0x1D46CB0", VA = "0x181D480B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022AD5 RID: 142037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022AD5")]
			[Address(RVA = "0x1D47D60", Offset = "0x1D46960", VA = "0x181D47D60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FAAA RID: 195242
			[Token(Token = "0x402FAAA")]
			private const int SKILL_SLOT_COUNT = 3;

			// Token: 0x0402FAAB RID: 195243
			[Token(Token = "0x402FAAB")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadMultiEditCharItemView m_closure;

			// Token: 0x0402FAAC RID: 195244
			[Token(Token = "0x402FAAC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FAAD RID: 195245
			[Token(Token = "0x402FAAD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FAAE RID: 195246
			[Token(Token = "0x402FAAE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
