using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200792B RID: 31019
	[Token(Token = "0x200792B")]
	public class Act1ArcadeBadgeBookItemHeadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B853 RID: 178259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B853")]
		[Address(RVA = "0x2769BB0", Offset = "0x27687B0", VA = "0x182769BB0")]
		public void OnClickEvent()
		{
		}

		// Token: 0x0602B854 RID: 178260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B854")]
		[Address(RVA = "0x2769CA0", Offset = "0x27688A0", VA = "0x182769CA0")]
		public void Render(string actId, Act1ArcadeBadgeBookItemViewModel model)
		{
		}

		// Token: 0x0602B855 RID: 178261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B855")]
		[Address(RVA = "0x2769A90", Offset = "0x2768690", VA = "0x182769A90")]
		public string GetActId()
		{
			return null;
		}

		// Token: 0x0602B856 RID: 178262 RVA: 0x000DC578 File Offset: 0x000DA778
		[Token(Token = "0x602B856")]
		[Address(RVA = "0x2769B50", Offset = "0x2768750", VA = "0x182769B50")]
		public bool GetUnlocked()
		{
			return default(bool);
		}

		// Token: 0x0602B857 RID: 178263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B857")]
		[Address(RVA = "0x2769AF0", Offset = "0x27686F0", VA = "0x182769AF0")]
		public string GetIconId()
		{
			return null;
		}

		// Token: 0x0602B858 RID: 178264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B858")]
		[Address(RVA = "0x27697C0", Offset = "0x27683C0", VA = "0x1827697C0")]
		public CrossAppShareImageModel GenerateIconImageModel()
		{
			return null;
		}

		// Token: 0x0602B859 RID: 178265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B859")]
		[Address(RVA = "0x27699A0", Offset = "0x27685A0", VA = "0x1827699A0")]
		public CrossAppShareImageModel GenerateTierImageModel()
		{
			return null;
		}

		// Token: 0x0602B85A RID: 178266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B85A")]
		[Address(RVA = "0x27698B0", Offset = "0x27684B0", VA = "0x1827698B0")]
		public CrossAppShareTextModel GenerateScoreTextModel()
		{
			return null;
		}

		// Token: 0x0602B85B RID: 178267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B85B")]
		[Address(RVA = "0x276A080", Offset = "0x2768C80", VA = "0x18276A080")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B85C RID: 178268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B85C")]
		[Address(RVA = "0x276A1D0", Offset = "0x2768DD0", VA = "0x18276A1D0")]
		private void _RenderLocked(string actId, string badgeId)
		{
		}

		// Token: 0x0602B85D RID: 178269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B85D")]
		[Address(RVA = "0x276A3E0", Offset = "0x2768FE0", VA = "0x18276A3E0")]
		private void _RenderUnlockedTier(string actId, Act1ArcadeBadgeBookItemTierViewModel model)
		{
		}

		// Token: 0x0602B85E RID: 178270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B85E")]
		[Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0")]
		public Act1ArcadeBadgeBookItemHeadView()
		{
		}

		// Token: 0x0403EEDD RID: 257757
		[Token(Token = "0x403EEDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _lockedPanels;

		// Token: 0x0403EEDE RID: 257758
		[Token(Token = "0x403EEDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0403EEDF RID: 257759
		[Token(Token = "0x403EEDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0403EEE0 RID: 257760
		[Token(Token = "0x403EEE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _tierIconImage;

		// Token: 0x0403EEE1 RID: 257761
		[Token(Token = "0x403EEE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _effectHolder;

		// Token: 0x0403EEE2 RID: 257762
		[Token(Token = "0x403EEE2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x0403EEE3 RID: 257763
		[Token(Token = "0x403EEE3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _scoreMaximum;

		// Token: 0x0403EEE4 RID: 257764
		[Token(Token = "0x403EEE4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _scoreFormat;

		// Token: 0x0403EEE5 RID: 257765
		[Token(Token = "0x403EEE5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403EEE6 RID: 257766
		[Token(Token = "0x403EEE6")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403EEE7 RID: 257767
		[Token(Token = "0x403EEE7")]
		[FieldOffset(Offset = "0x70")]
		private readonly Act1ArcadeBadgeBookItemHeadView.BadgeTrackPointModel.UpdateParam m_updateParam;

		// Token: 0x0403EEE8 RID: 257768
		[Token(Token = "0x403EEE8")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403EEE9 RID: 257769
		[Token(Token = "0x403EEE9")]
		[FieldOffset(Offset = "0x80")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x0403EEEA RID: 257770
		[Token(Token = "0x403EEEA")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403EEEB RID: 257771
		[Token(Token = "0x403EEEB")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedActId;

		// Token: 0x0403EEEC RID: 257772
		[Token(Token = "0x403EEEC")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedBadgeId;

		// Token: 0x0403EEED RID: 257773
		[Token(Token = "0x403EEED")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedTierId;

		// Token: 0x0403EEEE RID: 257774
		[Token(Token = "0x403EEEE")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cachedTier;

		// Token: 0x0403EEEF RID: 257775
		[Token(Token = "0x403EEEF")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedShareIconId;

		// Token: 0x0403EEF0 RID: 257776
		[Token(Token = "0x403EEF0")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedEffectId;

		// Token: 0x0403EEF1 RID: 257777
		[Token(Token = "0x403EEF1")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject m_loadedEffect;

		// Token: 0x0403EEF2 RID: 257778
		[Token(Token = "0x403EEF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0403EEF3 RID: 257779
		[Token(Token = "0x403EEF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EEF4 RID: 257780
		[Token(Token = "0x403EEF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActId;

		// Token: 0x0403EEF5 RID: 257781
		[Token(Token = "0x403EEF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetUnlocked;

		// Token: 0x0403EEF6 RID: 257782
		[Token(Token = "0x403EEF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetIconId;

		// Token: 0x0403EEF7 RID: 257783
		[Token(Token = "0x403EEF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateIconImageModel;

		// Token: 0x0403EEF8 RID: 257784
		[Token(Token = "0x403EEF8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenerateTierImageModel;

		// Token: 0x0403EEF9 RID: 257785
		[Token(Token = "0x403EEF9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateScoreTextModel;

		// Token: 0x0403EEFA RID: 257786
		[Token(Token = "0x403EEFA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EEFB RID: 257787
		[Token(Token = "0x403EEFB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderLocked;

		// Token: 0x0403EEFC RID: 257788
		[Token(Token = "0x403EEFC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderUnlockedTier;

		// Token: 0x0403EEFD RID: 257789
		[Token(Token = "0x403EEFD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200792C RID: 31020
		[Token(Token = "0x200792C")]
		private class BadgeTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x170065FA RID: 26106
			// (get) Token: 0x0602B85F RID: 178271 RVA: 0x000DC590 File Offset: 0x000DA790
			// (set) Token: 0x0602B860 RID: 178272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065FA")]
			public bool isShow
			{
				[Token(Token = "0x602B85F")]
				[Address(RVA = "0x277CF40", Offset = "0x277BB40", VA = "0x18277CF40", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602B860")]
				[Address(RVA = "0x277CFA0", Offset = "0x277BBA0", VA = "0x18277CFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602B861 RID: 178273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B861")]
			[Address(RVA = "0x277CD20", Offset = "0x277B920", VA = "0x18277CD20", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602B862 RID: 178274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B862")]
			[Address(RVA = "0x277CEE0", Offset = "0x277BAE0", VA = "0x18277CEE0")]
			public BadgeTrackPointModel()
			{
			}

			// Token: 0x0403EEFF RID: 257791
			[Token(Token = "0x403EEFF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403EF00 RID: 257792
			[Token(Token = "0x403EF00")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403EF01 RID: 257793
			[Token(Token = "0x403EF01")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403EF02 RID: 257794
			[Token(Token = "0x403EF02")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200792D RID: 31021
			[Token(Token = "0x200792D")]
			public class UpdateParam
			{
				// Token: 0x0602B863 RID: 178275 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602B863")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UpdateParam()
				{
				}

				// Token: 0x0403EF03 RID: 257795
				[Token(Token = "0x403EF03")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403EF04 RID: 257796
				[Token(Token = "0x403EF04")]
				[FieldOffset(Offset = "0x18")]
				public string badgeId;
			}
		}
	}
}
