using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A2B RID: 31275
	[Token(Token = "0x2007A2B")]
	public class Act13sideDailyMissionReplaceView : DataBinder<Act13sideDailyReplaceProperty>
	{
		// Token: 0x0602BD3B RID: 179515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD3B")]
		[Address(RVA = "0x27B1CA0", Offset = "0x27B08A0", VA = "0x1827B1CA0", Slot = "7")]
		public override void OnValueChanged(Act13sideDailyReplaceProperty property)
		{
		}

		// Token: 0x0602BD3C RID: 179516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD3C")]
		[Address(RVA = "0x27B2210", Offset = "0x27B0E10", VA = "0x1827B2210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BD3D RID: 179517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD3D")]
		[Address(RVA = "0x27B1BE0", Offset = "0x27B07E0", VA = "0x1827B1BE0")]
		public void Init(string activityId, Action<int, bool> onItemSelectAction)
		{
		}

		// Token: 0x0602BD3E RID: 179518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD3E")]
		[Address(RVA = "0x27B23A0", Offset = "0x27B0FA0", VA = "0x1827B23A0")]
		public Act13sideDailyMissionReplaceView()
		{
		}

		// Token: 0x0403F6D2 RID: 259794
		[Token(Token = "0x403F6D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _boardItemList;

		// Token: 0x0403F6D3 RID: 259795
		[Token(Token = "0x403F6D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act13sideDailyReplaceItemView _itemTemplate;

		// Token: 0x0403F6D4 RID: 259796
		[Token(Token = "0x403F6D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _candidateContainer;

		// Token: 0x0403F6D5 RID: 259797
		[Token(Token = "0x403F6D5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _btnReplace;

		// Token: 0x0403F6D6 RID: 259798
		[Token(Token = "0x403F6D6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textAgenda;

		// Token: 0x0403F6D7 RID: 259799
		[Token(Token = "0x403F6D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textAgendaMax;

		// Token: 0x0403F6D8 RID: 259800
		[Token(Token = "0x403F6D8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _hintColor;

		// Token: 0x0403F6D9 RID: 259801
		[Token(Token = "0x403F6D9")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403F6DA RID: 259802
		[Token(Token = "0x403F6DA")]
		[FieldOffset(Offset = "0x68")]
		private string m_actId;

		// Token: 0x0403F6DB RID: 259803
		[Token(Token = "0x403F6DB")]
		[FieldOffset(Offset = "0x70")]
		private Action<int, bool> m_onItemSelect;

		// Token: 0x0403F6DC RID: 259804
		[Token(Token = "0x403F6DC")]
		[FieldOffset(Offset = "0x78")]
		private Act13SideData m_actData;

		// Token: 0x0403F6DD RID: 259805
		[Token(Token = "0x403F6DD")]
		[FieldOffset(Offset = "0x80")]
		private Act13sideDailyMissionReplaceView.Adapter m_listAdapter;

		// Token: 0x0403F6DE RID: 259806
		[Token(Token = "0x403F6DE")]
		[FieldOffset(Offset = "0x88")]
		private Act13sideDailyReplaceItemView m_candidateView;

		// Token: 0x0403F6DF RID: 259807
		[Token(Token = "0x403F6DF")]
		[FieldOffset(Offset = "0x90")]
		private Act13sideDailyReplaceViewModel m_model;

		// Token: 0x0403F6E0 RID: 259808
		[Token(Token = "0x403F6E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F6E1 RID: 259809
		[Token(Token = "0x403F6E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F6E2 RID: 259810
		[Token(Token = "0x403F6E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F6E3 RID: 259811
		[Token(Token = "0x403F6E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A2C RID: 31276
		[Token(Token = "0x2007A2C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD3F RID: 179519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD3F")]
			[Address(RVA = "0x27BF9F0", Offset = "0x27BE5F0", VA = "0x1827BF9F0")]
			public Adapter(Act13sideDailyMissionReplaceView closure)
			{
			}

			// Token: 0x170066C4 RID: 26308
			// (get) Token: 0x0602BD40 RID: 179520 RVA: 0x000DD5C8 File Offset: 0x000DB7C8
			[Token(Token = "0x170066C4")]
			public override int count
			{
				[Token(Token = "0x602BD40")]
				[Address(RVA = "0x27BFC60", Offset = "0x27BE860", VA = "0x1827BFC60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD41 RID: 179521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD41")]
			[Address(RVA = "0x27BF640", Offset = "0x27BE240", VA = "0x1827BF640", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F6E4 RID: 259812
			[Token(Token = "0x403F6E4")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDailyMissionReplaceView m_closure;

			// Token: 0x0403F6E5 RID: 259813
			[Token(Token = "0x403F6E5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F6E6 RID: 259814
			[Token(Token = "0x403F6E6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F6E7 RID: 259815
			[Token(Token = "0x403F6E7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
