using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061FE RID: 25086
	[Token(Token = "0x20061FE")]
	public class BattleFinishDropInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x0602432D RID: 148269 RVA: 0x000C3690 File Offset: 0x000C1890
		// (set) Token: 0x0602432E RID: 148270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005563")]
		public bool rendering
		{
			[Token(Token = "0x602432D")]
			[Address(RVA = "0x1ECF1F0", Offset = "0x1ECDDF0", VA = "0x181ECF1F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602432E")]
			[Address(RVA = "0x1ECF250", Offset = "0x1ECDE50", VA = "0x181ECF250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602432F RID: 148271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602432F")]
		[Address(RVA = "0x1ECE710", Offset = "0x1ECD310", VA = "0x181ECE710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024330 RID: 148272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024330")]
		[Address(RVA = "0x1ECF0D0", Offset = "0x1ECDCD0", VA = "0x181ECF0D0")]
		private IEnumerator _RenderViewModel()
		{
			return null;
		}

		// Token: 0x06024331 RID: 148273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024331")]
		[Address(RVA = "0x1ECE040", Offset = "0x1ECCC40", VA = "0x181ECE040")]
		public void Render(DropInfoGroupViewModel viewModel)
		{
		}

		// Token: 0x06024332 RID: 148274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024332")]
		[Address(RVA = "0x1ECF180", Offset = "0x1ECDD80", VA = "0x181ECF180")]
		public BattleFinishDropInfoView()
		{
		}

		// Token: 0x04032520 RID: 206112
		[Token(Token = "0x4032520")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemGridFirst;

		// Token: 0x04032521 RID: 206113
		[Token(Token = "0x4032521")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemGridMulti;

		// Token: 0x04032522 RID: 206114
		[Token(Token = "0x4032522")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemGridNormal;

		// Token: 0x04032523 RID: 206115
		[Token(Token = "0x4032523")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _itemGridUnusual;

		// Token: 0x04032524 RID: 206116
		[Token(Token = "0x4032524")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _itemGridAdditional;

		// Token: 0x04032525 RID: 206117
		[Token(Token = "0x4032525")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _itemGridAP;

		// Token: 0x04032526 RID: 206118
		[Token(Token = "0x4032526")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _itemGridItemReturn;

		// Token: 0x04032527 RID: 206119
		[Token(Token = "0x4032527")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _itemGridDiamondMaterial;

		// Token: 0x04032528 RID: 206120
		[Token(Token = "0x4032528")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _itemGridFurniture;

		// Token: 0x04032529 RID: 206121
		[Token(Token = "0x4032529")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _itemGridOverride;

		// Token: 0x0403252A RID: 206122
		[Token(Token = "0x403252A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _percentText;

		// Token: 0x0403252B RID: 206123
		[Token(Token = "0x403252B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _percentTextWhite;

		// Token: 0x0403252C RID: 206124
		[Token(Token = "0x403252C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _delayPerItem;

		// Token: 0x0403252D RID: 206125
		[Token(Token = "0x403252D")]
		[FieldOffset(Offset = "0x80")]
		private List<DropInfoViewModel> m_dropItemsFirst;

		// Token: 0x0403252E RID: 206126
		[Token(Token = "0x403252E")]
		[FieldOffset(Offset = "0x88")]
		private List<DropInfoViewModel> m_dropItemsMulti;

		// Token: 0x0403252F RID: 206127
		[Token(Token = "0x403252F")]
		[FieldOffset(Offset = "0x90")]
		private List<DropInfoViewModel> m_dropItemsAP;

		// Token: 0x04032530 RID: 206128
		[Token(Token = "0x4032530")]
		[FieldOffset(Offset = "0x98")]
		private List<DropInfoViewModel> m_dropItemsNormal;

		// Token: 0x04032531 RID: 206129
		[Token(Token = "0x4032531")]
		[FieldOffset(Offset = "0xA0")]
		private List<DropInfoViewModel> m_dropItemsUnusual;

		// Token: 0x04032532 RID: 206130
		[Token(Token = "0x4032532")]
		[FieldOffset(Offset = "0xA8")]
		private List<DropInfoViewModel> m_dropItemsAdditional;

		// Token: 0x04032533 RID: 206131
		[Token(Token = "0x4032533")]
		[FieldOffset(Offset = "0xB0")]
		private List<DropInfoViewModel> m_dropItemsDiamondMaterial;

		// Token: 0x04032534 RID: 206132
		[Token(Token = "0x4032534")]
		[FieldOffset(Offset = "0xB8")]
		private List<DropInfoViewModel> m_dropItemsFurniture;

		// Token: 0x04032535 RID: 206133
		[Token(Token = "0x4032535")]
		[FieldOffset(Offset = "0xC0")]
		private List<DropInfoViewModel> m_dropItemsOverride;

		// Token: 0x04032536 RID: 206134
		[Token(Token = "0x4032536")]
		[FieldOffset(Offset = "0xC8")]
		private List<DropInfoViewModel> m_dropItemsReturn;

		// Token: 0x04032537 RID: 206135
		[Token(Token = "0x4032537")]
		[FieldOffset(Offset = "0xD0")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterFirst;

		// Token: 0x04032538 RID: 206136
		[Token(Token = "0x4032538")]
		[FieldOffset(Offset = "0xD8")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterMulti;

		// Token: 0x04032539 RID: 206137
		[Token(Token = "0x4032539")]
		[FieldOffset(Offset = "0xE0")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterAP;

		// Token: 0x0403253A RID: 206138
		[Token(Token = "0x403253A")]
		[FieldOffset(Offset = "0xE8")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterNormal;

		// Token: 0x0403253B RID: 206139
		[Token(Token = "0x403253B")]
		[FieldOffset(Offset = "0xF0")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterUnusual;

		// Token: 0x0403253C RID: 206140
		[Token(Token = "0x403253C")]
		[FieldOffset(Offset = "0xF8")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterAdditional;

		// Token: 0x0403253D RID: 206141
		[Token(Token = "0x403253D")]
		[FieldOffset(Offset = "0x100")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterDiamondMaterial;

		// Token: 0x0403253E RID: 206142
		[Token(Token = "0x403253E")]
		[FieldOffset(Offset = "0x108")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterFurniture;

		// Token: 0x0403253F RID: 206143
		[Token(Token = "0x403253F")]
		[FieldOffset(Offset = "0x110")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterOverride;

		// Token: 0x04032540 RID: 206144
		[Token(Token = "0x4032540")]
		[FieldOffset(Offset = "0x118")]
		private BattleFinishDropInfoView.ItemAdapter m_itemAdapterReturn;

		// Token: 0x04032541 RID: 206145
		[Token(Token = "0x4032541")]
		[FieldOffset(Offset = "0x120")]
		private Animator m_itemAnimatorFirst;

		// Token: 0x04032542 RID: 206146
		[Token(Token = "0x4032542")]
		[FieldOffset(Offset = "0x128")]
		private Animator m_itemAnimatorMulti;

		// Token: 0x04032543 RID: 206147
		[Token(Token = "0x4032543")]
		[FieldOffset(Offset = "0x130")]
		private Animator m_itemAnimatorAP;

		// Token: 0x04032544 RID: 206148
		[Token(Token = "0x4032544")]
		[FieldOffset(Offset = "0x138")]
		private Animator m_itemAnimatorNormal;

		// Token: 0x04032545 RID: 206149
		[Token(Token = "0x4032545")]
		[FieldOffset(Offset = "0x140")]
		private Animator m_itemAnimatorUnusual;

		// Token: 0x04032546 RID: 206150
		[Token(Token = "0x4032546")]
		[FieldOffset(Offset = "0x148")]
		private Animator m_itemAnimatorAdditional;

		// Token: 0x04032547 RID: 206151
		[Token(Token = "0x4032547")]
		[FieldOffset(Offset = "0x150")]
		private Animator m_itemAnimatorDiamondMaterial;

		// Token: 0x04032548 RID: 206152
		[Token(Token = "0x4032548")]
		[FieldOffset(Offset = "0x158")]
		private Animator m_itemAnimatorFurniture;

		// Token: 0x04032549 RID: 206153
		[Token(Token = "0x4032549")]
		[FieldOffset(Offset = "0x160")]
		private Animator m_itemAnimatorOverride;

		// Token: 0x0403254A RID: 206154
		[Token(Token = "0x403254A")]
		[FieldOffset(Offset = "0x168")]
		private Animator m_itemAnimatorReturn;

		// Token: 0x0403254B RID: 206155
		[Token(Token = "0x403254B")]
		[FieldOffset(Offset = "0x170")]
		private bool m_isInited;

		// Token: 0x0403254D RID: 206157
		[Token(Token = "0x403254D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rendering;

		// Token: 0x0403254E RID: 206158
		[Token(Token = "0x403254E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rendering;

		// Token: 0x0403254F RID: 206159
		[Token(Token = "0x403254F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032550 RID: 206160
		[Token(Token = "0x4032550")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderViewModel;

		// Token: 0x04032551 RID: 206161
		[Token(Token = "0x4032551")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032552 RID: 206162
		[Token(Token = "0x4032552")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061FF RID: 25087
		[Token(Token = "0x20061FF")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024333 RID: 148275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024333")]
			[Address(RVA = "0x1F1C0C0", Offset = "0x1F1ACC0", VA = "0x181F1C0C0")]
			public ItemAdapter(List<DropInfoViewModel> dropList, float delayPerItem)
			{
			}

			// Token: 0x06024334 RID: 148276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024334")]
			[Address(RVA = "0x1F1BCC0", Offset = "0x1F1A8C0", VA = "0x181F1BCC0", Slot = "7")]
			protected override void RecycleViews(List<GameObject> views)
			{
			}

			// Token: 0x17005564 RID: 21860
			// (get) Token: 0x06024335 RID: 148277 RVA: 0x000C36A8 File Offset: 0x000C18A8
			[Token(Token = "0x17005564")]
			public override int count
			{
				[Token(Token = "0x6024335")]
				[Address(RVA = "0x1F1C150", Offset = "0x1F1AD50", VA = "0x181F1C150", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024336 RID: 148278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024336")]
			[Address(RVA = "0x1F1BDD0", Offset = "0x1F1A9D0", VA = "0x181F1BDD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06024337 RID: 148279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024337")]
			[Address(RVA = "0xF88970", Offset = "0xF87570", VA = "0x180F88970")]
			private void <>xLuaBaseProxy_RecycleViews(List<GameObject> P0)
			{
			}

			// Token: 0x04032553 RID: 206163
			[Token(Token = "0x4032553")]
			[FieldOffset(Offset = "0x20")]
			private List<DropInfoViewModel> m_viewModel;

			// Token: 0x04032554 RID: 206164
			[Token(Token = "0x4032554")]
			[FieldOffset(Offset = "0x28")]
			private float m_delayPerItem;

			// Token: 0x04032555 RID: 206165
			[Token(Token = "0x4032555")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032556 RID: 206166
			[Token(Token = "0x4032556")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RecycleViews;

			// Token: 0x04032557 RID: 206167
			[Token(Token = "0x4032557")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032558 RID: 206168
			[Token(Token = "0x4032558")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
