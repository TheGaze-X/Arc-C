using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007462 RID: 29794
	[Token(Token = "0x2007462")]
	public class Act36sideZoneMapCardFrontView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006325 RID: 25381
		// (get) Token: 0x0602A07A RID: 172154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006325")]
		public List<Act36sideZoneMapCardFrontView.StageGroup> stagesOnCard
		{
			[Token(Token = "0x602A07A")]
			[Address(RVA = "0x25A18F0", Offset = "0x25A04F0", VA = "0x1825A18F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006326 RID: 25382
		// (get) Token: 0x0602A07B RID: 172155 RVA: 0x000D7478 File Offset: 0x000D5678
		[Token(Token = "0x17006326")]
		public int pageIndex
		{
			[Token(Token = "0x602A07B")]
			[Address(RVA = "0x25A1890", Offset = "0x25A0490", VA = "0x1825A1890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006327 RID: 25383
		// (get) Token: 0x0602A07C RID: 172156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006327")]
		public Act36sideZoneFocusAnimView animViewPrefab
		{
			[Token(Token = "0x602A07C")]
			[Address(RVA = "0x25A1830", Offset = "0x25A0430", VA = "0x1825A1830")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A07D RID: 172157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A07D")]
		[Address(RVA = "0x25A1310", Offset = "0x259FF10", VA = "0x1825A1310")]
		private void _InitStageButtonIfNot(ZoneViewModel model)
		{
		}

		// Token: 0x0602A07E RID: 172158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A07E")]
		[Address(RVA = "0x25A0EF0", Offset = "0x259FAF0", VA = "0x1825A0EF0")]
		public void BindBackCard(Act36sideZoneMapCardBackView backView)
		{
		}

		// Token: 0x0602A07F RID: 172159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A07F")]
		[Address(RVA = "0x25A10B0", Offset = "0x259FCB0", VA = "0x1825A10B0")]
		public void Render(ZoneViewModel model, int pageIndex)
		{
		}

		// Token: 0x0602A080 RID: 172160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A080")]
		[Address(RVA = "0x25A1040", Offset = "0x259FC40", VA = "0x1825A1040")]
		public void OnCardClick()
		{
		}

		// Token: 0x0602A081 RID: 172161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A081")]
		[Address(RVA = "0x25A1620", Offset = "0x25A0220", VA = "0x1825A1620")]
		private void _ZoneMapOnlyRenderStage(StageButtonOnMap button, MainStageButtonOnMapHolder holder, StageViewModel stageModel, ZoneViewModel zoneModel, bool isSelected)
		{
		}

		// Token: 0x0602A082 RID: 172162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A082")]
		[Address(RVA = "0x25A1780", Offset = "0x25A0380", VA = "0x1825A1780")]
		public Act36sideZoneMapCardFrontView()
		{
		}

		// Token: 0x0403C4B6 RID: 246966
		[Token(Token = "0x403C4B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _floatPanel;

		// Token: 0x0403C4B7 RID: 246967
		[Token(Token = "0x403C4B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act36sideZoneFocusAnimView _animViewPrefab;

		// Token: 0x0403C4B8 RID: 246968
		[Token(Token = "0x403C4B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _hotspot;

		// Token: 0x0403C4B9 RID: 246969
		[Token(Token = "0x403C4B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _backSprite;

		// Token: 0x0403C4BA RID: 246970
		[Token(Token = "0x403C4BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Act36sideZoneMapCardFrontView.HolderGroup> _stageButtonHolders;

		// Token: 0x0403C4BB RID: 246971
		[Token(Token = "0x403C4BB")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> onCardClick;

		// Token: 0x0403C4BC RID: 246972
		[Token(Token = "0x403C4BC")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onStageSelect;

		// Token: 0x0403C4BD RID: 246973
		[Token(Token = "0x403C4BD")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onSpecialStageReward;

		// Token: 0x0403C4BE RID: 246974
		[Token(Token = "0x403C4BE")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0403C4BF RID: 246975
		[Token(Token = "0x403C4BF")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isButtonInited;

		// Token: 0x0403C4C0 RID: 246976
		[Token(Token = "0x403C4C0")]
		[FieldOffset(Offset = "0x5C")]
		private int m_pageIndex;

		// Token: 0x0403C4C1 RID: 246977
		[Token(Token = "0x403C4C1")]
		[FieldOffset(Offset = "0x60")]
		private List<Act36sideZoneMapCardFrontView.StageGroup> m_stagesOnCard;

		// Token: 0x0403C4C2 RID: 246978
		[Token(Token = "0x403C4C2")]
		[FieldOffset(Offset = "0x68")]
		private List<MainStageButtonOnMapHolder> m_activeHolders;

		// Token: 0x0403C4C3 RID: 246979
		[Token(Token = "0x403C4C3")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_lineFadeSwitchTween;

		// Token: 0x0403C4C4 RID: 246980
		[Token(Token = "0x403C4C4")]
		[FieldOffset(Offset = "0x78")]
		private UIBiAnimClipSwitchTween m_stableAnimTween;

		// Token: 0x0403C4C5 RID: 246981
		[Token(Token = "0x403C4C5")]
		[FieldOffset(Offset = "0x80")]
		private Act36sideZoneMapCardBackView m_backView;

		// Token: 0x0403C4C6 RID: 246982
		[Token(Token = "0x403C4C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stagesOnCard;

		// Token: 0x0403C4C7 RID: 246983
		[Token(Token = "0x403C4C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageIndex;

		// Token: 0x0403C4C8 RID: 246984
		[Token(Token = "0x403C4C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_animViewPrefab;

		// Token: 0x0403C4C9 RID: 246985
		[Token(Token = "0x403C4C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitStageButtonIfNot;

		// Token: 0x0403C4CA RID: 246986
		[Token(Token = "0x403C4CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindBackCard;

		// Token: 0x0403C4CB RID: 246987
		[Token(Token = "0x403C4CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C4CC RID: 246988
		[Token(Token = "0x403C4CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0403C4CD RID: 246989
		[Token(Token = "0x403C4CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ZoneMapOnlyRenderStage;

		// Token: 0x0403C4CE RID: 246990
		[Token(Token = "0x403C4CE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007463 RID: 29795
		[Token(Token = "0x2007463")]
		[Serializable]
		public struct HolderGroup
		{
			// Token: 0x0403C4CF RID: 246991
			[Token(Token = "0x403C4CF")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform connectPos;

			// Token: 0x0403C4D0 RID: 246992
			[Token(Token = "0x403C4D0")]
			[FieldOffset(Offset = "0x8")]
			public MainStageButtonOnMapHolder stageButtonHolder;
		}

		// Token: 0x02007464 RID: 29796
		[Token(Token = "0x2007464")]
		public struct StageGroup
		{
			// Token: 0x0403C4D1 RID: 246993
			[Token(Token = "0x403C4D1")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x0403C4D2 RID: 246994
			[Token(Token = "0x403C4D2")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform connectPos;
		}
	}
}
