using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AF0 RID: 19184
	[Token(Token = "0x2004AF0")]
	public class HomeCharRotationPresetListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x0601CD04 RID: 118020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD05 RID: 118021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004401")]
		public Action<string> onBtnNameClick
		{
			[Token(Token = "0x601CD04")]
			[Address(RVA = "0x1643320", Offset = "0x1641F20", VA = "0x181643320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD05")]
			[Address(RVA = "0x1643500", Offset = "0x1642100", VA = "0x181643500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x0601CD06 RID: 118022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD07 RID: 118023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004402")]
		public Action<string> onBtnDeleteClick
		{
			[Token(Token = "0x601CD06")]
			[Address(RVA = "0x1643260", Offset = "0x1641E60", VA = "0x181643260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD07")]
			[Address(RVA = "0x1643400", Offset = "0x1642000", VA = "0x181643400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x0601CD08 RID: 118024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD09 RID: 118025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004403")]
		public Action<string> onBtnEditClick
		{
			[Token(Token = "0x601CD08")]
			[Address(RVA = "0x16432C0", Offset = "0x1641EC0", VA = "0x1816432C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD09")]
			[Address(RVA = "0x1643480", Offset = "0x1642080", VA = "0x181643480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x0601CD0A RID: 118026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CD0B RID: 118027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004404")]
		public Action<string> onBtnApplyClick
		{
			[Token(Token = "0x601CD0A")]
			[Address(RVA = "0x1643200", Offset = "0x1641E00", VA = "0x181643200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CD0B")]
			[Address(RVA = "0x1643380", Offset = "0x1641F80", VA = "0x181643380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601CD0C RID: 118028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD0C")]
		[Address(RVA = "0x1643070", Offset = "0x1641C70", VA = "0x181643070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CD0D RID: 118029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD0D")]
		[Address(RVA = "0x1642BE0", Offset = "0x16417E0", VA = "0x181642BE0")]
		public void Render(HomeCharRotationPresetItemViewModel viewModel, int index, string currPresetInstId)
		{
		}

		// Token: 0x0601CD0E RID: 118030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD0E")]
		[Address(RVA = "0x1642B00", Offset = "0x1641700", VA = "0x181642B00")]
		public void OnBtnNameClick()
		{
		}

		// Token: 0x0601CD0F RID: 118031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD0F")]
		[Address(RVA = "0x1642940", Offset = "0x1641540", VA = "0x181642940")]
		public void OnBtnDeleteClick()
		{
		}

		// Token: 0x0601CD10 RID: 118032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD10")]
		[Address(RVA = "0x1642A20", Offset = "0x1641620", VA = "0x181642A20")]
		public void OnBtnEditClick()
		{
		}

		// Token: 0x0601CD11 RID: 118033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD11")]
		[Address(RVA = "0x1642860", Offset = "0x1641460", VA = "0x181642860")]
		public void OnBtnApplyClick()
		{
		}

		// Token: 0x0601CD12 RID: 118034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD12")]
		[Address(RVA = "0x16431A0", Offset = "0x1641DA0", VA = "0x1816431A0")]
		public HomeCharRotationPresetListItemView()
		{
		}

		// Token: 0x04025CCC RID: 154828
		[Token(Token = "0x4025CCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textIndex;

		// Token: 0x04025CCD RID: 154829
		[Token(Token = "0x4025CCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04025CCE RID: 154830
		[Token(Token = "0x4025CCE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textBackgroundName;

		// Token: 0x04025CCF RID: 154831
		[Token(Token = "0x4025CCF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textThemeName;

		// Token: 0x04025CD0 RID: 154832
		[Token(Token = "0x4025CD0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBackground;

		// Token: 0x04025CD1 RID: 154833
		[Token(Token = "0x4025CD1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTheme;

		// Token: 0x04025CD2 RID: 154834
		[Token(Token = "0x4025CD2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _bgMultiFormIcon;

		// Token: 0x04025CD3 RID: 154835
		[Token(Token = "0x4025CD3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _tmMultiFormIcon;

		// Token: 0x04025CD4 RID: 154836
		[Token(Token = "0x4025CD4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _charSkinList;

		// Token: 0x04025CD5 RID: 154837
		[Token(Token = "0x4025CD5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlApply;

		// Token: 0x04025CD6 RID: 154838
		[Token(Token = "0x4025CD6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x04025CD7 RID: 154839
		[Token(Token = "0x4025CD7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlMoreSkin;

		// Token: 0x04025CD8 RID: 154840
		[Token(Token = "0x4025CD8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textSkinNum;

		// Token: 0x04025CD9 RID: 154841
		[Token(Token = "0x4025CD9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlSkinExceed;

		// Token: 0x04025CDA RID: 154842
		[Token(Token = "0x4025CDA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlDeleteBtn;

		// Token: 0x04025CDB RID: 154843
		[Token(Token = "0x4025CDB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIColorGraphic _editGraphic;

		// Token: 0x04025CE0 RID: 154848
		[Token(Token = "0x4025CE0")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_inited;

		// Token: 0x04025CE1 RID: 154849
		[Token(Token = "0x4025CE1")]
		[FieldOffset(Offset = "0xC0")]
		private HomeCharRotationPresetListItemView.Adapter m_adapter;

		// Token: 0x04025CE2 RID: 154850
		[Token(Token = "0x4025CE2")]
		[FieldOffset(Offset = "0xC8")]
		private List<HomeCharRotationPresetSkinItemViewModel> m_cachedSkinList;

		// Token: 0x04025CE3 RID: 154851
		[Token(Token = "0x4025CE3")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedProfileSkinTag;

		// Token: 0x04025CE4 RID: 154852
		[Token(Token = "0x4025CE4")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04025CE5 RID: 154853
		[Token(Token = "0x4025CE5")]
		[FieldOffset(Offset = "0xE8")]
		private string m_cachedInstId;

		// Token: 0x04025CE6 RID: 154854
		[Token(Token = "0x4025CE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnNameClick;

		// Token: 0x04025CE7 RID: 154855
		[Token(Token = "0x4025CE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnNameClick;

		// Token: 0x04025CE8 RID: 154856
		[Token(Token = "0x4025CE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onBtnDeleteClick;

		// Token: 0x04025CE9 RID: 154857
		[Token(Token = "0x4025CE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onBtnDeleteClick;

		// Token: 0x04025CEA RID: 154858
		[Token(Token = "0x4025CEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onBtnEditClick;

		// Token: 0x04025CEB RID: 154859
		[Token(Token = "0x4025CEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onBtnEditClick;

		// Token: 0x04025CEC RID: 154860
		[Token(Token = "0x4025CEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onBtnApplyClick;

		// Token: 0x04025CED RID: 154861
		[Token(Token = "0x4025CED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onBtnApplyClick;

		// Token: 0x04025CEE RID: 154862
		[Token(Token = "0x4025CEE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025CEF RID: 154863
		[Token(Token = "0x4025CEF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025CF0 RID: 154864
		[Token(Token = "0x4025CF0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnNameClick;

		// Token: 0x04025CF1 RID: 154865
		[Token(Token = "0x4025CF1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnDeleteClick;

		// Token: 0x04025CF2 RID: 154866
		[Token(Token = "0x4025CF2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnEditClick;

		// Token: 0x04025CF3 RID: 154867
		[Token(Token = "0x4025CF3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBtnApplyClick;

		// Token: 0x04025CF4 RID: 154868
		[Token(Token = "0x4025CF4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004AF1 RID: 19185
		[Token(Token = "0x2004AF1")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601CD13 RID: 118035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CD13")]
			[Address(RVA = "0x1637220", Offset = "0x1635E20", VA = "0x181637220")]
			public Adapter(HomeCharRotationPresetListItemView closure)
			{
			}

			// Token: 0x17004405 RID: 17413
			// (get) Token: 0x0601CD14 RID: 118036 RVA: 0x000A99B0 File Offset: 0x000A7BB0
			[Token(Token = "0x17004405")]
			public override int count
			{
				[Token(Token = "0x601CD14")]
				[Address(RVA = "0x1637320", Offset = "0x1635F20", VA = "0x181637320", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601CD15 RID: 118037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CD15")]
			[Address(RVA = "0x1636A30", Offset = "0x1635630", VA = "0x181636A30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025CF5 RID: 154869
			[Token(Token = "0x4025CF5")]
			[FieldOffset(Offset = "0x20")]
			private HomeCharRotationPresetListItemView m_closure;

			// Token: 0x04025CF6 RID: 154870
			[Token(Token = "0x4025CF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025CF7 RID: 154871
			[Token(Token = "0x4025CF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025CF8 RID: 154872
			[Token(Token = "0x4025CF8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
