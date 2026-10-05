using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A30 RID: 31280
	[Token(Token = "0x2007A30")]
	public class Act13sideDailyReplaceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066C7 RID: 26311
		// (get) Token: 0x0602BD4C RID: 179532 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD4D RID: 179533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066C7")]
		public Action<int, bool> onItemClick
		{
			[Token(Token = "0x602BD4C")]
			[Address(RVA = "0x27B4DB0", Offset = "0x27B39B0", VA = "0x1827B4DB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD4D")]
			[Address(RVA = "0x27B4E10", Offset = "0x27B3A10", VA = "0x1827B4E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BD4E RID: 179534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD4E")]
		[Address(RVA = "0x27B4670", Offset = "0x27B3270", VA = "0x1827B4670")]
		public void Render(int position, string actId, Act13sideDailyMissionItemViewModel itemModel)
		{
		}

		// Token: 0x0602BD4F RID: 179535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD4F")]
		[Address(RVA = "0x27B4C90", Offset = "0x27B3890", VA = "0x1827B4C90")]
		public void SetSelect(bool isSelect)
		{
		}

		// Token: 0x0602BD50 RID: 179536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD50")]
		[Address(RVA = "0x27B4550", Offset = "0x27B3150", VA = "0x1827B4550")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602BD51 RID: 179537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD51")]
		[Address(RVA = "0x27B4D40", Offset = "0x27B3940", VA = "0x1827B4D40")]
		public Act13sideDailyReplaceItemView()
		{
		}

		// Token: 0x0403F701 RID: 259841
		[Token(Token = "0x403F701")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403F702 RID: 259842
		[Token(Token = "0x403F702")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0403F703 RID: 259843
		[Token(Token = "0x403F703")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedPartGo;

		// Token: 0x0403F704 RID: 259844
		[Token(Token = "0x403F704")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEmptyHint;

		// Token: 0x0403F705 RID: 259845
		[Token(Token = "0x403F705")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _normalAlphaHandler;

		// Token: 0x0403F706 RID: 259846
		[Token(Token = "0x403F706")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _selectAlphaVal;

		// Token: 0x0403F707 RID: 259847
		[Token(Token = "0x403F707")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPrincipalName;

		// Token: 0x0403F708 RID: 259848
		[Token(Token = "0x403F708")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textMissionName;

		// Token: 0x0403F709 RID: 259849
		[Token(Token = "0x403F709")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textMissionDesc;

		// Token: 0x0403F70A RID: 259850
		[Token(Token = "0x403F70A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textPrestigeDesc;

		// Token: 0x0403F70B RID: 259851
		[Token(Token = "0x403F70B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textAgenda;

		// Token: 0x0403F70C RID: 259852
		[Token(Token = "0x403F70C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgOrgLogo;

		// Token: 0x0403F70D RID: 259853
		[Token(Token = "0x403F70D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgPrincipalBg;

		// Token: 0x0403F70E RID: 259854
		[Token(Token = "0x403F70E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0403F70F RID: 259855
		[Token(Token = "0x403F70F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0403F710 RID: 259856
		[Token(Token = "0x403F710")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _btnClick;

		// Token: 0x0403F712 RID: 259858
		[Token(Token = "0x403F712")]
		[FieldOffset(Offset = "0xA0")]
		private Act13sideDailyReplaceItemView.Adapter m_adapter;

		// Token: 0x0403F713 RID: 259859
		[Token(Token = "0x403F713")]
		[FieldOffset(Offset = "0xA8")]
		private Act13sideDailyMissionItemViewModel m_itemModel;

		// Token: 0x0403F714 RID: 259860
		[Token(Token = "0x403F714")]
		[FieldOffset(Offset = "0xB0")]
		private int m_position;

		// Token: 0x0403F715 RID: 259861
		[Token(Token = "0x403F715")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isSelect;

		// Token: 0x0403F716 RID: 259862
		[Token(Token = "0x403F716")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403F717 RID: 259863
		[Token(Token = "0x403F717")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403F718 RID: 259864
		[Token(Token = "0x403F718")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F719 RID: 259865
		[Token(Token = "0x403F719")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x0403F71A RID: 259866
		[Token(Token = "0x403F71A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403F71B RID: 259867
		[Token(Token = "0x403F71B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A31 RID: 31281
		[Token(Token = "0x2007A31")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD52 RID: 179538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD52")]
			[Address(RVA = "0x27BFA70", Offset = "0x27BE670", VA = "0x1827BFA70")]
			public Adapter(Act13sideDailyReplaceItemView closure)
			{
			}

			// Token: 0x170066C8 RID: 26312
			// (get) Token: 0x0602BD53 RID: 179539 RVA: 0x000DD610 File Offset: 0x000DB810
			[Token(Token = "0x170066C8")]
			public override int count
			{
				[Token(Token = "0x602BD53")]
				[Address(RVA = "0x27BFB70", Offset = "0x27BE770", VA = "0x1827BFB70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD54 RID: 179540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD54")]
			[Address(RVA = "0x27BEFB0", Offset = "0x27BDBB0", VA = "0x1827BEFB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F71C RID: 259868
			[Token(Token = "0x403F71C")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDailyReplaceItemView m_closure;

			// Token: 0x0403F71D RID: 259869
			[Token(Token = "0x403F71D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F71E RID: 259870
			[Token(Token = "0x403F71E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F71F RID: 259871
			[Token(Token = "0x403F71F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
