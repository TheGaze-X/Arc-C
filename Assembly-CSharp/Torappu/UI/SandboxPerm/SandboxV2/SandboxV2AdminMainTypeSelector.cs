using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004065 RID: 16485
	[Token(Token = "0x2004065")]
	public class SandboxV2AdminMainTypeSelector : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000083 RID: 131
		// (add) Token: 0x060197FB RID: 104443 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060197FC RID: 104444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000083")]
		public event Action<int> eSelectChanged
		{
			[Token(Token = "0x60197FB")]
			[Address(RVA = "0x12320D0", Offset = "0x1230CD0", VA = "0x1812320D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60197FC")]
			[Address(RVA = "0x1232290", Offset = "0x1230E90", VA = "0x181232290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x060197FD RID: 104445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060197FE RID: 104446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CBF")]
		public Func<bool> checkIfShowRacingBtn
		{
			[Token(Token = "0x60197FD")]
			[Address(RVA = "0x12321D0", Offset = "0x1230DD0", VA = "0x1812321D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60197FE")]
			[Address(RVA = "0x1232390", Offset = "0x1230F90", VA = "0x181232390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060197FF RID: 104447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197FF")]
		[Address(RVA = "0x1231C40", Offset = "0x1230840", VA = "0x181231C40")]
		public void SetRacerBagNameText(string racerBagName)
		{
		}

		// Token: 0x06019800 RID: 104448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019800")]
		[Address(RVA = "0x1231A70", Offset = "0x1230670", VA = "0x181231A70")]
		public void Render(IList<SandboxV2AdminMainTypeItemData> typeList, Color selBgClr, Color selTitleClr)
		{
		}

		// Token: 0x06019801 RID: 104449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019801")]
		[Address(RVA = "0x12319F0", Offset = "0x12305F0", VA = "0x1812319F0")]
		public void EventOnRacingBtnClicked()
		{
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x06019802 RID: 104450 RVA: 0x0009E598 File Offset: 0x0009C798
		// (set) Token: 0x06019803 RID: 104451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CC0")]
		public int selected
		{
			[Token(Token = "0x6019802")]
			[Address(RVA = "0x1232230", Offset = "0x1230E30", VA = "0x181232230")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019803")]
			[Address(RVA = "0x1232410", Offset = "0x1231010", VA = "0x181232410")]
			set
			{
			}
		}

		// Token: 0x06019804 RID: 104452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019804")]
		[Address(RVA = "0x1231F80", Offset = "0x1230B80", VA = "0x181231F80")]
		private void _SetSelect(int selectedIdx)
		{
		}

		// Token: 0x06019805 RID: 104453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019805")]
		[Address(RVA = "0x1231E60", Offset = "0x1230A60", VA = "0x181231E60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019806 RID: 104454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019806")]
		[Address(RVA = "0x1231CE0", Offset = "0x12308E0", VA = "0x181231CE0")]
		public GameObject TutorialOnly_GetItemButtonGO(int index)
		{
			return null;
		}

		// Token: 0x06019807 RID: 104455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019807")]
		[Address(RVA = "0x1232060", Offset = "0x1230C60", VA = "0x181232060")]
		public SandboxV2AdminMainTypeSelector()
		{
		}

		// Token: 0x0401FC7C RID: 130172
		[Token(Token = "0x401FC7C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layout;

		// Token: 0x0401FC7D RID: 130173
		[Token(Token = "0x401FC7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRacingBtn;

		// Token: 0x0401FC7E RID: 130174
		[Token(Token = "0x401FC7E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRacerBagName;

		// Token: 0x0401FC7F RID: 130175
		[Token(Token = "0x401FC7F")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2AdminMainTypeSelector.LayoutAdapter m_adapter;

		// Token: 0x0401FC80 RID: 130176
		[Token(Token = "0x401FC80")]
		[FieldOffset(Offset = "0x38")]
		private IList<SandboxV2AdminMainTypeItemData> m_typeList;

		// Token: 0x0401FC81 RID: 130177
		[Token(Token = "0x401FC81")]
		[FieldOffset(Offset = "0x40")]
		private Color m_selBgClr;

		// Token: 0x0401FC82 RID: 130178
		[Token(Token = "0x401FC82")]
		[FieldOffset(Offset = "0x50")]
		private Color m_selTitleClr;

		// Token: 0x0401FC83 RID: 130179
		[Token(Token = "0x401FC83")]
		[FieldOffset(Offset = "0x60")]
		private int m_selected;

		// Token: 0x0401FC84 RID: 130180
		[Token(Token = "0x401FC84")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FC87 RID: 130183
		[Token(Token = "0x401FC87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eSelectChanged;

		// Token: 0x0401FC88 RID: 130184
		[Token(Token = "0x401FC88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eSelectChanged;

		// Token: 0x0401FC89 RID: 130185
		[Token(Token = "0x401FC89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_checkIfShowRacingBtn;

		// Token: 0x0401FC8A RID: 130186
		[Token(Token = "0x401FC8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_checkIfShowRacingBtn;

		// Token: 0x0401FC8B RID: 130187
		[Token(Token = "0x401FC8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRacerBagNameText;

		// Token: 0x0401FC8C RID: 130188
		[Token(Token = "0x401FC8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FC8D RID: 130189
		[Token(Token = "0x401FC8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnRacingBtnClicked;

		// Token: 0x0401FC8E RID: 130190
		[Token(Token = "0x401FC8E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x0401FC8F RID: 130191
		[Token(Token = "0x401FC8F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x0401FC90 RID: 130192
		[Token(Token = "0x401FC90")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetSelect;

		// Token: 0x0401FC91 RID: 130193
		[Token(Token = "0x401FC91")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FC92 RID: 130194
		[Token(Token = "0x401FC92")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetItemButtonGO;

		// Token: 0x0401FC93 RID: 130195
		[Token(Token = "0x401FC93")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004066 RID: 16486
		[Token(Token = "0x2004066")]
		private class LayoutAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019808 RID: 104456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019808")]
			[Address(RVA = "0x122A840", Offset = "0x1229440", VA = "0x18122A840")]
			public LayoutAdapter(SandboxV2AdminMainTypeSelector closure)
			{
			}

			// Token: 0x17003CC1 RID: 15553
			// (get) Token: 0x06019809 RID: 104457 RVA: 0x0009E5B0 File Offset: 0x0009C7B0
			[Token(Token = "0x17003CC1")]
			public override int count
			{
				[Token(Token = "0x6019809")]
				[Address(RVA = "0x122A8C0", Offset = "0x12294C0", VA = "0x18122A8C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601980A RID: 104458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601980A")]
			[Address(RVA = "0x122A160", Offset = "0x1228D60", VA = "0x18122A160", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FC94 RID: 130196
			[Token(Token = "0x401FC94")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2AdminMainTypeSelector m_closure;

			// Token: 0x0401FC95 RID: 130197
			[Token(Token = "0x401FC95")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FC96 RID: 130198
			[Token(Token = "0x401FC96")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FC97 RID: 130199
			[Token(Token = "0x401FC97")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
