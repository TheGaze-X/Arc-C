using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A2D RID: 31277
	[Token(Token = "0x2007A2D")]
	public class Act13sideDailyMissionSearchView : DataBinder<Act13sideDailySearchProperty>
	{
		// Token: 0x0602BD42 RID: 179522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD42")]
		[Address(RVA = "0x27B3950", Offset = "0x27B2550", VA = "0x1827B3950")]
		public void Init(Action<string> onOrgSelected, Action<ItemBundle> onItemSelected)
		{
		}

		// Token: 0x0602BD43 RID: 179523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD43")]
		[Address(RVA = "0x27B3A00", Offset = "0x27B2600", VA = "0x1827B3A00", Slot = "7")]
		public override void OnValueChanged(Act13sideDailySearchProperty property)
		{
		}

		// Token: 0x0602BD44 RID: 179524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD44")]
		[Address(RVA = "0x27B3E10", Offset = "0x27B2A10", VA = "0x1827B3E10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BD45 RID: 179525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD45")]
		[Address(RVA = "0x27B3FE0", Offset = "0x27B2BE0", VA = "0x1827B3FE0")]
		public Act13sideDailyMissionSearchView()
		{
		}

		// Token: 0x0403F6E8 RID: 259816
		[Token(Token = "0x403F6E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _orgRandomToggle;

		// Token: 0x0403F6E9 RID: 259817
		[Token(Token = "0x403F6E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _matRandomToggle;

		// Token: 0x0403F6EA RID: 259818
		[Token(Token = "0x403F6EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textOrgSelection;

		// Token: 0x0403F6EB RID: 259819
		[Token(Token = "0x403F6EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMatSelection;

		// Token: 0x0403F6EC RID: 259820
		[Token(Token = "0x403F6EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSearchCount;

		// Token: 0x0403F6ED RID: 259821
		[Token(Token = "0x403F6ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _orgOptionList;

		// Token: 0x0403F6EE RID: 259822
		[Token(Token = "0x403F6EE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _matOptionList;

		// Token: 0x0403F6EF RID: 259823
		[Token(Token = "0x403F6EF")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403F6F0 RID: 259824
		[Token(Token = "0x403F6F0")]
		[FieldOffset(Offset = "0x60")]
		private Act13sideDailyMissionSearchView.OrgListAdapter m_orgListAdapter;

		// Token: 0x0403F6F1 RID: 259825
		[Token(Token = "0x403F6F1")]
		[FieldOffset(Offset = "0x68")]
		private Act13sideDailyMissionSearchView.MatListAdapter m_matListAdapter;

		// Token: 0x0403F6F2 RID: 259826
		[Token(Token = "0x403F6F2")]
		[FieldOffset(Offset = "0x70")]
		private Act13sideDailySearchViewModel m_model;

		// Token: 0x0403F6F3 RID: 259827
		[Token(Token = "0x403F6F3")]
		[FieldOffset(Offset = "0x78")]
		private Action<string> m_onOrgSelected;

		// Token: 0x0403F6F4 RID: 259828
		[Token(Token = "0x403F6F4")]
		[FieldOffset(Offset = "0x80")]
		private Action<ItemBundle> m_onMatSelected;

		// Token: 0x0403F6F5 RID: 259829
		[Token(Token = "0x403F6F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F6F6 RID: 259830
		[Token(Token = "0x403F6F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F6F7 RID: 259831
		[Token(Token = "0x403F6F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F6F8 RID: 259832
		[Token(Token = "0x403F6F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A2E RID: 31278
		[Token(Token = "0x2007A2E")]
		private class OrgListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD46 RID: 179526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD46")]
			[Address(RVA = "0x27C0730", Offset = "0x27BF330", VA = "0x1827C0730")]
			public OrgListAdapter(Act13sideDailyMissionSearchView closure)
			{
			}

			// Token: 0x170066C5 RID: 26309
			// (get) Token: 0x0602BD47 RID: 179527 RVA: 0x000DD5E0 File Offset: 0x000DB7E0
			[Token(Token = "0x170066C5")]
			public override int count
			{
				[Token(Token = "0x602BD47")]
				[Address(RVA = "0x27C07B0", Offset = "0x27BF3B0", VA = "0x1827C07B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD48 RID: 179528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD48")]
			[Address(RVA = "0x27C04F0", Offset = "0x27BF0F0", VA = "0x1827C04F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F6F9 RID: 259833
			[Token(Token = "0x403F6F9")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDailyMissionSearchView m_closure;

			// Token: 0x0403F6FA RID: 259834
			[Token(Token = "0x403F6FA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F6FB RID: 259835
			[Token(Token = "0x403F6FB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F6FC RID: 259836
			[Token(Token = "0x403F6FC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007A2F RID: 31279
		[Token(Token = "0x2007A2F")]
		private class MatListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD49 RID: 179529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD49")]
			[Address(RVA = "0x27C00B0", Offset = "0x27BECB0", VA = "0x1827C00B0")]
			public MatListAdapter(Act13sideDailyMissionSearchView closure)
			{
			}

			// Token: 0x170066C6 RID: 26310
			// (get) Token: 0x0602BD4A RID: 179530 RVA: 0x000DD5F8 File Offset: 0x000DB7F8
			[Token(Token = "0x170066C6")]
			public override int count
			{
				[Token(Token = "0x602BD4A")]
				[Address(RVA = "0x27C0130", Offset = "0x27BED30", VA = "0x1827C0130", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD4B RID: 179531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD4B")]
			[Address(RVA = "0x27BFE70", Offset = "0x27BEA70", VA = "0x1827BFE70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403F6FD RID: 259837
			[Token(Token = "0x403F6FD")]
			[FieldOffset(Offset = "0x20")]
			private Act13sideDailyMissionSearchView m_closure;

			// Token: 0x0403F6FE RID: 259838
			[Token(Token = "0x403F6FE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F6FF RID: 259839
			[Token(Token = "0x403F6FF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F700 RID: 259840
			[Token(Token = "0x403F700")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
