using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CCB RID: 27851
	[Token(Token = "0x2006CCB")]
	public class TemplateActivityMissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x06027BB3 RID: 162739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DCF")]
		public TemplateActivityMissionPlugin plugin
		{
			[Token(Token = "0x6027BB3")]
			[Address(RVA = "0x22E67F0", Offset = "0x22E53F0", VA = "0x1822E67F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x06027BB4 RID: 162740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DD0")]
		public TemplateActivityMissionItem.Adapter adatper
		{
			[Token(Token = "0x6027BB4")]
			[Address(RVA = "0x22E6790", Offset = "0x22E5390", VA = "0x1822E6790")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027BB5 RID: 162741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BB5")]
		[Address(RVA = "0x22E63A0", Offset = "0x22E4FA0", VA = "0x1822E63A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x06027BB6 RID: 162742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DD1")]
		protected TemplateMissionViewModel viewModel
		{
			[Token(Token = "0x6027BB6")]
			[Address(RVA = "0x22E6860", Offset = "0x22E5460", VA = "0x1822E6860")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027BB7 RID: 162743 RVA: 0x000CF2B8 File Offset: 0x000CD4B8
		[Token(Token = "0x6027BB7")]
		[Address(RVA = "0x22E66D0", Offset = "0x22E52D0", VA = "0x1822E66D0")]
		private bool _ShowProgressWithText()
		{
			return default(bool);
		}

		// Token: 0x06027BB8 RID: 162744 RVA: 0x000CF2D0 File Offset: 0x000CD4D0
		[Token(Token = "0x6027BB8")]
		[Address(RVA = "0x22E6600", Offset = "0x22E5200", VA = "0x1822E6600")]
		private bool _ShowProgressWithProgressBar()
		{
			return default(bool);
		}

		// Token: 0x06027BB9 RID: 162745 RVA: 0x000CF2E8 File Offset: 0x000CD4E8
		[Token(Token = "0x6027BB9")]
		[Address(RVA = "0x22E6670", Offset = "0x22E5270", VA = "0x1822E6670")]
		private bool _ShowProgressWithProgressSlider()
		{
			return default(bool);
		}

		// Token: 0x06027BBA RID: 162746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BBA")]
		[Address(RVA = "0x22E4F40", Offset = "0x22E3B40", VA = "0x1822E4F40")]
		private void _BasicRender()
		{
		}

		// Token: 0x06027BBB RID: 162747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BBB")]
		[Address(RVA = "0x22E6260", Offset = "0x22E4E60", VA = "0x1822E6260")]
		private void _FillProgress()
		{
		}

		// Token: 0x06027BBC RID: 162748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BBC")]
		[Address(RVA = "0x22E64E0", Offset = "0x22E50E0", VA = "0x1822E64E0")]
		private void _InitTextFormatOrColor(Dictionary<string, string> activityStringRes, string stringResKey, out string textToInit, string defaultValue)
		{
		}

		// Token: 0x06027BBD RID: 162749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BBD")]
		[Address(RVA = "0x22E4C50", Offset = "0x22E3850", VA = "0x1822E4C50")]
		public void OnClick()
		{
		}

		// Token: 0x06027BBE RID: 162750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BBE")]
		[Address(RVA = "0x22E4CF0", Offset = "0x22E38F0", VA = "0x1822E4CF0")]
		public void Render(TemplateMissionViewModel viewModel)
		{
		}

		// Token: 0x06027BBF RID: 162751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BBF")]
		[Address(RVA = "0x22E6730", Offset = "0x22E5330", VA = "0x1822E6730")]
		public TemplateActivityMissionItem()
		{
		}

		// Token: 0x04038569 RID: 230761
		[Token(Token = "0x4038569")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> onAbleToGetPart;

		// Token: 0x0403856A RID: 230762
		[Token(Token = "0x403856A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> onAlreadyGetPart;

		// Token: 0x0403856B RID: 230763
		[Token(Token = "0x403856B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> onCannotGetPart;

		// Token: 0x0403856C RID: 230764
		[Token(Token = "0x403856C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> onAvailPart;

		// Token: 0x0403856D RID: 230765
		[Token(Token = "0x403856D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _missionDetail;

		// Token: 0x0403856E RID: 230766
		[Token(Token = "0x403856E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TemplateActivityMissionItem.ShowProgressType _showProgressType;

		// Token: 0x0403856F RID: 230767
		[Token(Token = "0x403856F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Inspect("_ShowProgressWithProgressBar")]
		private Image _progress;

		// Token: 0x04038570 RID: 230768
		[Token(Token = "0x4038570")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("_ShowProgressWithProgressBar")]
		private Slider _progressSlider;

		// Token: 0x04038571 RID: 230769
		[Token(Token = "0x4038571")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("_ShowProgressWithProgressBar")]
		private Text _progressDetail;

		// Token: 0x04038572 RID: 230770
		[Token(Token = "0x4038572")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Inspect("_ShowProgressWithProgressSlider")]
		private Text _progressSliderDetail;

		// Token: 0x04038573 RID: 230771
		[Token(Token = "0x4038573")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04038574 RID: 230772
		[Token(Token = "0x4038574")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MonoBehaviour _plugin;

		// Token: 0x04038575 RID: 230773
		[Token(Token = "0x4038575")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Graphic _uiColoredImg;

		// Token: 0x04038576 RID: 230774
		[Token(Token = "0x4038576")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _availColor;

		// Token: 0x04038577 RID: 230775
		[Token(Token = "0x4038577")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _notAvailColor;

		// Token: 0x04038578 RID: 230776
		[Token(Token = "0x4038578")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _scalerFactor;

		// Token: 0x04038579 RID: 230777
		[Token(Token = "0x4038579")]
		[FieldOffset(Offset = "0xA8")]
		private string m_textProgressFormatCanClaim;

		// Token: 0x0403857A RID: 230778
		[Token(Token = "0x403857A")]
		[FieldOffset(Offset = "0xB0")]
		private string m_textProgressFormatCannotClaim;

		// Token: 0x0403857B RID: 230779
		[Token(Token = "0x403857B")]
		[FieldOffset(Offset = "0xB8")]
		private string m_textDetailColorCanClaim;

		// Token: 0x0403857C RID: 230780
		[Token(Token = "0x403857C")]
		[FieldOffset(Offset = "0xC0")]
		private string m_textDetailColorCannotClaim;

		// Token: 0x0403857D RID: 230781
		[Token(Token = "0x403857D")]
		private const string DEFAULT_TEXT_PROGRESS_FORMAT = "<color=#000000>{0}</color><color=#000000>/{1}</color>";

		// Token: 0x0403857E RID: 230782
		[Token(Token = "0x403857E")]
		private const string DEFAULT_TEXT_DETAIL_COLOR = "<color=#000000>{0}</color>";

		// Token: 0x0403857F RID: 230783
		[Token(Token = "0x403857F")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public UIStringEvent onMissionGetRewardClick;

		// Token: 0x04038580 RID: 230784
		[Token(Token = "0x4038580")]
		[FieldOffset(Offset = "0xD0")]
		private TemplateActivityMissionItem.Adapter m_adapter;

		// Token: 0x04038581 RID: 230785
		[Token(Token = "0x4038581")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x04038582 RID: 230786
		[Token(Token = "0x4038582")]
		[FieldOffset(Offset = "0xE0")]
		private TemplateMissionViewModel m_cacheViewModel;

		// Token: 0x04038583 RID: 230787
		[Token(Token = "0x4038583")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x04038584 RID: 230788
		[Token(Token = "0x4038584")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_adatper;

		// Token: 0x04038585 RID: 230789
		[Token(Token = "0x4038585")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038586 RID: 230790
		[Token(Token = "0x4038586")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x04038587 RID: 230791
		[Token(Token = "0x4038587")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowProgressWithText;

		// Token: 0x04038588 RID: 230792
		[Token(Token = "0x4038588")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowProgressWithProgressBar;

		// Token: 0x04038589 RID: 230793
		[Token(Token = "0x4038589")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowProgressWithProgressSlider;

		// Token: 0x0403858A RID: 230794
		[Token(Token = "0x403858A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BasicRender;

		// Token: 0x0403858B RID: 230795
		[Token(Token = "0x403858B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FillProgress;

		// Token: 0x0403858C RID: 230796
		[Token(Token = "0x403858C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitTextFormatOrColor;

		// Token: 0x0403858D RID: 230797
		[Token(Token = "0x403858D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403858E RID: 230798
		[Token(Token = "0x403858E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403858F RID: 230799
		[Token(Token = "0x403858F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CCC RID: 27852
		[Token(Token = "0x2006CCC")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005DD2 RID: 24018
			// (get) Token: 0x06027BC0 RID: 162752 RVA: 0x000CF300 File Offset: 0x000CD500
			[Token(Token = "0x17005DD2")]
			public override int count
			{
				[Token(Token = "0x6027BC0")]
				[Address(RVA = "0x22D4A30", Offset = "0x22D3630", VA = "0x1822D4A30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027BC1 RID: 162753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027BC1")]
			[Address(RVA = "0x22D45E0", Offset = "0x22D31E0", VA = "0x1822D45E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06027BC2 RID: 162754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BC2")]
			[Address(RVA = "0x22D49D0", Offset = "0x22D35D0", VA = "0x1822D49D0")]
			public Adapter()
			{
			}

			// Token: 0x04038590 RID: 230800
			[Token(Token = "0x4038590")]
			[FieldOffset(Offset = "0x20")]
			public float scaleFactor;

			// Token: 0x04038591 RID: 230801
			[Token(Token = "0x4038591")]
			[FieldOffset(Offset = "0x28")]
			public List<BasicActivityItemViewModel> itemViewModelList;

			// Token: 0x04038592 RID: 230802
			[Token(Token = "0x4038592")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038593 RID: 230803
			[Token(Token = "0x4038593")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038594 RID: 230804
			[Token(Token = "0x4038594")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006CCD RID: 27853
		[Token(Token = "0x2006CCD")]
		private enum ShowProgressType
		{
			// Token: 0x04038596 RID: 230806
			[Token(Token = "0x4038596")]
			WITH_MISSION_DETAIL_TEXT,
			// Token: 0x04038597 RID: 230807
			[Token(Token = "0x4038597")]
			WITH_PROGRESS_BAR,
			// Token: 0x04038598 RID: 230808
			[Token(Token = "0x4038598")]
			WITH_PROGRESS_SLIDER,
			// Token: 0x04038599 RID: 230809
			[Token(Token = "0x4038599")]
			WITH_PROGRESS_BAR_AND_SIMPLE_COUNT,
			// Token: 0x0403859A RID: 230810
			[Token(Token = "0x403859A")]
			CUSTOM_FORMAT
		}
	}
}
