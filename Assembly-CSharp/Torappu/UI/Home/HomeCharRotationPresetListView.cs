using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AF2 RID: 19186
	[Token(Token = "0x2004AF2")]
	public class HomeCharRotationPresetListView : DataBinder<HomeCharRotationPresetListViewProperty>
	{
		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x0601CD16 RID: 118038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD17 RID: 118039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004406")]
		public Action<string> onBtnNameClick
		{
			[Token(Token = "0x601CD16")]
			[Address(RVA = "0x16443B0", Offset = "0x1642FB0", VA = "0x1816443B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD17")]
			[Address(RVA = "0x1644610", Offset = "0x1643210", VA = "0x181644610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x0601CD18 RID: 118040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD19 RID: 118041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004407")]
		public Action<string> onBtnDeleteClick
		{
			[Token(Token = "0x601CD18")]
			[Address(RVA = "0x16442F0", Offset = "0x1642EF0", VA = "0x1816442F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD19")]
			[Address(RVA = "0x1644510", Offset = "0x1643110", VA = "0x181644510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x0601CD1A RID: 118042 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD1B RID: 118043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004408")]
		public Action<string> onBtnEditClick
		{
			[Token(Token = "0x601CD1A")]
			[Address(RVA = "0x1644350", Offset = "0x1642F50", VA = "0x181644350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD1B")]
			[Address(RVA = "0x1644590", Offset = "0x1643190", VA = "0x181644590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x0601CD1C RID: 118044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD1D RID: 118045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004409")]
		public Action<string> onBtnApplyClick
		{
			[Token(Token = "0x601CD1C")]
			[Address(RVA = "0x1644230", Offset = "0x1642E30", VA = "0x181644230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD1D")]
			[Address(RVA = "0x1644410", Offset = "0x1643010", VA = "0x181644410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x0601CD1E RID: 118046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD1F RID: 118047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700440A")]
		public Action onBtnCreateClick
		{
			[Token(Token = "0x601CD1E")]
			[Address(RVA = "0x1644290", Offset = "0x1642E90", VA = "0x181644290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD1F")]
			[Address(RVA = "0x1644490", Offset = "0x1643090", VA = "0x181644490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601CD20 RID: 118048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD20")]
		[Address(RVA = "0x1644090", Offset = "0x1642C90", VA = "0x181644090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CD21 RID: 118049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD21")]
		[Address(RVA = "0x1643C90", Offset = "0x1642890", VA = "0x181643C90", Slot = "7")]
		public override void OnValueChanged(HomeCharRotationPresetListViewProperty property)
		{
		}

		// Token: 0x0601CD22 RID: 118050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD22")]
		[Address(RVA = "0x1643B80", Offset = "0x1642780", VA = "0x181643B80")]
		public void OnBtnCreatePresetClick()
		{
		}

		// Token: 0x0601CD23 RID: 118051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD23")]
		[Address(RVA = "0x16441C0", Offset = "0x1642DC0", VA = "0x1816441C0")]
		public HomeCharRotationPresetListView()
		{
		}

		// Token: 0x04025CF9 RID: 154873
		[Token(Token = "0x4025CF9")]
		private const string TOTAL_PRESET_NUM_FORMAT = "/{0}";

		// Token: 0x04025CFA RID: 154874
		[Token(Token = "0x4025CFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurrNum;

		// Token: 0x04025CFB RID: 154875
		[Token(Token = "0x4025CFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalNum;

		// Token: 0x04025CFC RID: 154876
		[Token(Token = "0x4025CFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlNewPreset;

		// Token: 0x04025CFD RID: 154877
		[Token(Token = "0x4025CFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlPresetLimit;

		// Token: 0x04025CFE RID: 154878
		[Token(Token = "0x4025CFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _presetList;

		// Token: 0x04025CFF RID: 154879
		[Token(Token = "0x4025CFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04025D05 RID: 154885
		[Token(Token = "0x4025D05")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04025D06 RID: 154886
		[Token(Token = "0x4025D06")]
		[FieldOffset(Offset = "0x80")]
		private HomeCharRotationPresetListView.Adapter m_adapter;

		// Token: 0x04025D07 RID: 154887
		[Token(Token = "0x4025D07")]
		[FieldOffset(Offset = "0x88")]
		private HomeCharRotationPresetListViewModel m_cachedViewModel;

		// Token: 0x04025D08 RID: 154888
		[Token(Token = "0x4025D08")]
		[FieldOffset(Offset = "0x90")]
		private int m_cachedCreatePresetSeqNum;

		// Token: 0x04025D09 RID: 154889
		[Token(Token = "0x4025D09")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_scrollRectTween;

		// Token: 0x04025D0A RID: 154890
		[Token(Token = "0x4025D0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnNameClick;

		// Token: 0x04025D0B RID: 154891
		[Token(Token = "0x4025D0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnNameClick;

		// Token: 0x04025D0C RID: 154892
		[Token(Token = "0x4025D0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onBtnDeleteClick;

		// Token: 0x04025D0D RID: 154893
		[Token(Token = "0x4025D0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onBtnDeleteClick;

		// Token: 0x04025D0E RID: 154894
		[Token(Token = "0x4025D0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onBtnEditClick;

		// Token: 0x04025D0F RID: 154895
		[Token(Token = "0x4025D0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onBtnEditClick;

		// Token: 0x04025D10 RID: 154896
		[Token(Token = "0x4025D10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onBtnApplyClick;

		// Token: 0x04025D11 RID: 154897
		[Token(Token = "0x4025D11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onBtnApplyClick;

		// Token: 0x04025D12 RID: 154898
		[Token(Token = "0x4025D12")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onBtnCreateClick;

		// Token: 0x04025D13 RID: 154899
		[Token(Token = "0x4025D13")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onBtnCreateClick;

		// Token: 0x04025D14 RID: 154900
		[Token(Token = "0x4025D14")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025D15 RID: 154901
		[Token(Token = "0x4025D15")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04025D16 RID: 154902
		[Token(Token = "0x4025D16")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnCreatePresetClick;

		// Token: 0x04025D17 RID: 154903
		[Token(Token = "0x4025D17")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004AF3 RID: 19187
		[Token(Token = "0x2004AF3")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601CD24 RID: 118052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CD24")]
			[Address(RVA = "0x16372A0", Offset = "0x1635EA0", VA = "0x1816372A0")]
			public Adapter(HomeCharRotationPresetListView closure)
			{
			}

			// Token: 0x1700440B RID: 17419
			// (get) Token: 0x0601CD25 RID: 118053 RVA: 0x000A99C8 File Offset: 0x000A7BC8
			[Token(Token = "0x1700440B")]
			public override int count
			{
				[Token(Token = "0x601CD25")]
				[Address(RVA = "0x16373A0", Offset = "0x1635FA0", VA = "0x1816373A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601CD26 RID: 118054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CD26")]
			[Address(RVA = "0x1636D80", Offset = "0x1635980", VA = "0x181636D80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025D18 RID: 154904
			[Token(Token = "0x4025D18")]
			[FieldOffset(Offset = "0x20")]
			private HomeCharRotationPresetListView m_closure;

			// Token: 0x04025D19 RID: 154905
			[Token(Token = "0x4025D19")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025D1A RID: 154906
			[Token(Token = "0x4025D1A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025D1B RID: 154907
			[Token(Token = "0x4025D1B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
