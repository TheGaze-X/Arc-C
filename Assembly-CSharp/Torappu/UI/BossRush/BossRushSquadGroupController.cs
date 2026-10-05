using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006199 RID: 24985
	[Token(Token = "0x2006199")]
	public class BossRushSquadGroupController : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x06024095 RID: 147605 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024096 RID: 147606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700550D")]
		public Action<int> onSlotClicked
		{
			[Token(Token = "0x6024095")]
			[Address(RVA = "0x1EABC40", Offset = "0x1EAA840", VA = "0x181EABC40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024096")]
			[Address(RVA = "0x1EABD00", Offset = "0x1EAA900", VA = "0x181EABD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x06024097 RID: 147607 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024098 RID: 147608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700550E")]
		public Action<int> onTabClicked
		{
			[Token(Token = "0x6024097")]
			[Address(RVA = "0x1EABCA0", Offset = "0x1EAA8A0", VA = "0x181EABCA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024098")]
			[Address(RVA = "0x1EABD80", Offset = "0x1EAA980", VA = "0x181EABD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024099 RID: 147609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024099")]
		[Address(RVA = "0x1EAB3A0", Offset = "0x1EA9FA0", VA = "0x181EAB3A0", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x0602409A RID: 147610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602409A")]
		[Address(RVA = "0x1EAB290", Offset = "0x1EA9E90", VA = "0x181EAB290")]
		public void InjectPlugin(SquadHomePlugin statePlugin)
		{
		}

		// Token: 0x0602409B RID: 147611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602409B")]
		[Address(RVA = "0x1EAB8A0", Offset = "0x1EAA4A0", VA = "0x181EAB8A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602409C RID: 147612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602409C")]
		[Address(RVA = "0x1EABB50", Offset = "0x1EAA750", VA = "0x181EABB50")]
		private void _OnShowLeftArrow(bool isShow)
		{
		}

		// Token: 0x0602409D RID: 147613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602409D")]
		[Address(RVA = "0x1EABA40", Offset = "0x1EAA640", VA = "0x181EABA40")]
		private void _OnCharCardClicked(SquadCardViewWithPredefine.Options options)
		{
		}

		// Token: 0x0602409E RID: 147614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602409E")]
		[Address(RVA = "0x1EABBD0", Offset = "0x1EAA7D0", VA = "0x181EABBD0")]
		public BossRushSquadGroupController()
		{
		}

		// Token: 0x04032132 RID: 205106
		[Token(Token = "0x4032132")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _squadLayout;

		// Token: 0x04032133 RID: 205107
		[Token(Token = "0x4032133")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSingleTeamTips;

		// Token: 0x04032134 RID: 205108
		[Token(Token = "0x4032134")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _leftbtn;

		// Token: 0x04032135 RID: 205109
		[Token(Token = "0x4032135")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rightbtn;

		// Token: 0x04032136 RID: 205110
		[Token(Token = "0x4032136")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rectMiddleControl;

		// Token: 0x04032137 RID: 205111
		[Token(Token = "0x4032137")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _squadTabLayout;

		// Token: 0x04032138 RID: 205112
		[Token(Token = "0x4032138")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04032139 RID: 205113
		[Token(Token = "0x4032139")]
		[FieldOffset(Offset = "0x58")]
		private BossRushSquadGroupViewModel m_squadGroupModel;

		// Token: 0x0403213A RID: 205114
		[Token(Token = "0x403213A")]
		[FieldOffset(Offset = "0x60")]
		private SquadViewModel m_squadModel;

		// Token: 0x0403213B RID: 205115
		[Token(Token = "0x403213B")]
		[FieldOffset(Offset = "0x68")]
		private string m_teamId;

		// Token: 0x0403213C RID: 205116
		[Token(Token = "0x403213C")]
		[FieldOffset(Offset = "0x70")]
		private SpriteHub m_professionHub;

		// Token: 0x0403213D RID: 205117
		[Token(Token = "0x403213D")]
		[FieldOffset(Offset = "0x78")]
		private BossRushSquadGroupController.SquadAdapter m_squadAdapter;

		// Token: 0x0403213E RID: 205118
		[Token(Token = "0x403213E")]
		[FieldOffset(Offset = "0x80")]
		private BossRushSquadGroupController.SquadTabAdapter m_squadTabAdapter;

		// Token: 0x0403213F RID: 205119
		[Token(Token = "0x403213F")]
		[FieldOffset(Offset = "0x88")]
		private SquadHomePlugin m_statePlugin;

		// Token: 0x04032140 RID: 205120
		[Token(Token = "0x4032140")]
		private const float MIDDLE_CONTROL_POS_Y_TEAM = 20f;

		// Token: 0x04032143 RID: 205123
		[Token(Token = "0x4032143")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotClicked;

		// Token: 0x04032144 RID: 205124
		[Token(Token = "0x4032144")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotClicked;

		// Token: 0x04032145 RID: 205125
		[Token(Token = "0x4032145")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onTabClicked;

		// Token: 0x04032146 RID: 205126
		[Token(Token = "0x4032146")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onTabClicked;

		// Token: 0x04032147 RID: 205127
		[Token(Token = "0x4032147")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032148 RID: 205128
		[Token(Token = "0x4032148")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x04032149 RID: 205129
		[Token(Token = "0x4032149")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403214A RID: 205130
		[Token(Token = "0x403214A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnShowLeftArrow;

		// Token: 0x0403214B RID: 205131
		[Token(Token = "0x403214B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x0403214C RID: 205132
		[Token(Token = "0x403214C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200619A RID: 24986
		[Token(Token = "0x200619A")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602409F RID: 147615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602409F")]
			[Address(RVA = "0x1EB2290", Offset = "0x1EB0E90", VA = "0x181EB2290")]
			public SquadAdapter(BossRushSquadGroupController controller)
			{
			}

			// Token: 0x1700550F RID: 21775
			// (get) Token: 0x060240A0 RID: 147616 RVA: 0x000C2D18 File Offset: 0x000C0F18
			[Token(Token = "0x1700550F")]
			public override int count
			{
				[Token(Token = "0x60240A0")]
				[Address(RVA = "0x1EB2310", Offset = "0x1EB0F10", VA = "0x181EB2310", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060240A1 RID: 147617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60240A1")]
			[Address(RVA = "0x1EB1F50", Offset = "0x1EB0B50", VA = "0x181EB1F50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403214D RID: 205133
			[Token(Token = "0x403214D")]
			[FieldOffset(Offset = "0x20")]
			private BossRushSquadGroupController m_closure;

			// Token: 0x0403214E RID: 205134
			[Token(Token = "0x403214E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403214F RID: 205135
			[Token(Token = "0x403214F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032150 RID: 205136
			[Token(Token = "0x4032150")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200619B RID: 24987
		[Token(Token = "0x200619B")]
		private class SquadTabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060240A2 RID: 147618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60240A2")]
			[Address(RVA = "0x1ECC230", Offset = "0x1ECAE30", VA = "0x181ECC230")]
			public SquadTabAdapter(BossRushSquadGroupController controller)
			{
			}

			// Token: 0x17005510 RID: 21776
			// (get) Token: 0x060240A3 RID: 147619 RVA: 0x000C2D30 File Offset: 0x000C0F30
			[Token(Token = "0x17005510")]
			public override int count
			{
				[Token(Token = "0x60240A3")]
				[Address(RVA = "0x1ECC2B0", Offset = "0x1ECAEB0", VA = "0x181ECC2B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060240A4 RID: 147620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60240A4")]
			[Address(RVA = "0x1ECBD10", Offset = "0x1ECA910", VA = "0x181ECBD10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032151 RID: 205137
			[Token(Token = "0x4032151")]
			[FieldOffset(Offset = "0x20")]
			private BossRushSquadGroupController m_closure;

			// Token: 0x04032152 RID: 205138
			[Token(Token = "0x4032152")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032153 RID: 205139
			[Token(Token = "0x4032153")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032154 RID: 205140
			[Token(Token = "0x4032154")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
