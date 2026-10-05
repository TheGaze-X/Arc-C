using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060EE RID: 24814
	[Token(Token = "0x20060EE")]
	public class CampaignMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x06023DCF RID: 146895 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023DD0 RID: 146896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054B7")]
		public Action<CampaignPermanentMissionViewModel> onPermObjClicked
		{
			[Token(Token = "0x6023DCF")]
			[Address(RVA = "0x1E73390", Offset = "0x1E71F90", VA = "0x181E73390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023DD0")]
			[Address(RVA = "0x1E73470", Offset = "0x1E72070", VA = "0x181E73470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x06023DD1 RID: 146897 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023DD2 RID: 146898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054B8")]
		public Action<CampaignCommonMissionViewModel> onCommonObjClicked
		{
			[Token(Token = "0x6023DD1")]
			[Address(RVA = "0x1E73330", Offset = "0x1E71F30", VA = "0x181E73330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023DD2")]
			[Address(RVA = "0x1E733F0", Offset = "0x1E71FF0", VA = "0x181E733F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023DD3 RID: 146899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DD3")]
		[Address(RVA = "0x1E72CF0", Offset = "0x1E718F0", VA = "0x181E72CF0")]
		public void Render(CampaignMissionStateBean stateBean)
		{
		}

		// Token: 0x06023DD4 RID: 146900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DD4")]
		[Address(RVA = "0x1E730F0", Offset = "0x1E71CF0", VA = "0x181E730F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023DD5 RID: 146901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DD5")]
		[Address(RVA = "0x1E73250", Offset = "0x1E71E50", VA = "0x181E73250")]
		public CampaignMissionView()
		{
		}

		// Token: 0x04031BE3 RID: 203747
		[Token(Token = "0x4031BE3")]
		private const string TEXT_PROGRESS_FORMAT = "{0}<size=21>/{1}</size>";

		// Token: 0x04031BE4 RID: 203748
		[Token(Token = "0x4031BE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _permObjLayoutContent;

		// Token: 0x04031BE5 RID: 203749
		[Token(Token = "0x4031BE5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _commonObjLayoutContent;

		// Token: 0x04031BE6 RID: 203750
		[Token(Token = "0x4031BE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelCommonMissionList;

		// Token: 0x04031BE7 RID: 203751
		[Token(Token = "0x4031BE7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelNoCommonMission;

		// Token: 0x04031BE8 RID: 203752
		[Token(Token = "0x4031BE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _buttonRedirect;

		// Token: 0x04031BE9 RID: 203753
		[Token(Token = "0x4031BE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04031BEA RID: 203754
		[Token(Token = "0x4031BEA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x04031BEB RID: 203755
		[Token(Token = "0x4031BEB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x04031BEC RID: 203756
		[Token(Token = "0x4031BEC")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04031BED RID: 203757
		[Token(Token = "0x4031BED")]
		[FieldOffset(Offset = "0x60")]
		private CampaignMissionView.PermanentObjAdapter m_permObjAdapter;

		// Token: 0x04031BEE RID: 203758
		[Token(Token = "0x4031BEE")]
		[FieldOffset(Offset = "0x68")]
		private CampaignMissionView.CommonObjAdapter m_commonObjAdapter;

		// Token: 0x04031BF1 RID: 203761
		[Token(Token = "0x4031BF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onPermObjClicked;

		// Token: 0x04031BF2 RID: 203762
		[Token(Token = "0x4031BF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onPermObjClicked;

		// Token: 0x04031BF3 RID: 203763
		[Token(Token = "0x4031BF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCommonObjClicked;

		// Token: 0x04031BF4 RID: 203764
		[Token(Token = "0x4031BF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCommonObjClicked;

		// Token: 0x04031BF5 RID: 203765
		[Token(Token = "0x4031BF5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031BF6 RID: 203766
		[Token(Token = "0x4031BF6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031BF7 RID: 203767
		[Token(Token = "0x4031BF7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060EF RID: 24815
		[Token(Token = "0x20060EF")]
		private class PermanentObjAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170054B9 RID: 21689
			// (get) Token: 0x06023DD6 RID: 146902 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023DD7 RID: 146903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054B9")]
			public List<CampaignPermanentMissionViewModel> dataSet
			{
				[Token(Token = "0x6023DD6")]
				[Address(RVA = "0x1E9B420", Offset = "0x1E9A020", VA = "0x181E9B420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6023DD7")]
				[Address(RVA = "0x1E9B4E0", Offset = "0x1E9A0E0", VA = "0x181E9B4E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170054BA RID: 21690
			// (get) Token: 0x06023DD8 RID: 146904 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023DD9 RID: 146905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054BA")]
			public Action<CampaignPermanentMissionViewModel> onObjClicked
			{
				[Token(Token = "0x6023DD8")]
				[Address(RVA = "0x1E9B480", Offset = "0x1E9A080", VA = "0x181E9B480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6023DD9")]
				[Address(RVA = "0x1E9B560", Offset = "0x1E9A160", VA = "0x181E9B560")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170054BB RID: 21691
			// (get) Token: 0x06023DDA RID: 146906 RVA: 0x000C2448 File Offset: 0x000C0648
			[Token(Token = "0x170054BB")]
			public override int count
			{
				[Token(Token = "0x6023DDA")]
				[Address(RVA = "0x1E9B360", Offset = "0x1E99F60", VA = "0x181E9B360", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023DDB RID: 146907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023DDB")]
			[Address(RVA = "0x1E9B0C0", Offset = "0x1E99CC0", VA = "0x181E9B0C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023DDC RID: 146908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023DDC")]
			[Address(RVA = "0x1E9B300", Offset = "0x1E99F00", VA = "0x181E9B300")]
			public PermanentObjAdapter()
			{
			}

			// Token: 0x04031BFA RID: 203770
			[Token(Token = "0x4031BFA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04031BFB RID: 203771
			[Token(Token = "0x4031BFB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04031BFC RID: 203772
			[Token(Token = "0x4031BFC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_onObjClicked;

			// Token: 0x04031BFD RID: 203773
			[Token(Token = "0x4031BFD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_onObjClicked;

			// Token: 0x04031BFE RID: 203774
			[Token(Token = "0x4031BFE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031BFF RID: 203775
			[Token(Token = "0x4031BFF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031C00 RID: 203776
			[Token(Token = "0x4031C00")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020060F0 RID: 24816
		[Token(Token = "0x20060F0")]
		private class CommonObjAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170054BC RID: 21692
			// (get) Token: 0x06023DDD RID: 146909 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023DDE RID: 146910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054BC")]
			public List<CampaignCommonMissionViewModel> dataSet
			{
				[Token(Token = "0x6023DDD")]
				[Address(RVA = "0x1E9A940", Offset = "0x1E99540", VA = "0x181E9A940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6023DDE")]
				[Address(RVA = "0x1E9AA00", Offset = "0x1E99600", VA = "0x181E9AA00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170054BD RID: 21693
			// (get) Token: 0x06023DDF RID: 146911 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023DE0 RID: 146912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054BD")]
			public Action<CampaignCommonMissionViewModel> onObjClicked
			{
				[Token(Token = "0x6023DDF")]
				[Address(RVA = "0x1E9A9A0", Offset = "0x1E995A0", VA = "0x181E9A9A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6023DE0")]
				[Address(RVA = "0x1E9AA80", Offset = "0x1E99680", VA = "0x181E9AA80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170054BE RID: 21694
			// (get) Token: 0x06023DE1 RID: 146913 RVA: 0x000C2460 File Offset: 0x000C0660
			[Token(Token = "0x170054BE")]
			public override int count
			{
				[Token(Token = "0x6023DE1")]
				[Address(RVA = "0x1E9A880", Offset = "0x1E99480", VA = "0x181E9A880", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023DE2 RID: 146914 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023DE2")]
			[Address(RVA = "0x1E9A5E0", Offset = "0x1E991E0", VA = "0x181E9A5E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023DE3 RID: 146915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023DE3")]
			[Address(RVA = "0x1E9A820", Offset = "0x1E99420", VA = "0x181E9A820")]
			public CommonObjAdapter()
			{
			}

			// Token: 0x04031C03 RID: 203779
			[Token(Token = "0x4031C03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04031C04 RID: 203780
			[Token(Token = "0x4031C04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04031C05 RID: 203781
			[Token(Token = "0x4031C05")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_onObjClicked;

			// Token: 0x04031C06 RID: 203782
			[Token(Token = "0x4031C06")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_onObjClicked;

			// Token: 0x04031C07 RID: 203783
			[Token(Token = "0x4031C07")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031C08 RID: 203784
			[Token(Token = "0x4031C08")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031C09 RID: 203785
			[Token(Token = "0x4031C09")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
