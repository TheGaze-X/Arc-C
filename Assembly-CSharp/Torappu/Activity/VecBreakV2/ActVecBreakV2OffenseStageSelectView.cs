using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E54 RID: 28244
	[Token(Token = "0x2006E54")]
	public class ActVecBreakV2OffenseStageSelectView : DataBinder<ActVecBreakV2OffenseProp>
	{
		// Token: 0x06028324 RID: 164644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028324")]
		[Address(RVA = "0x237EEB0", Offset = "0x237DAB0", VA = "0x18237EEB0")]
		public void OnNavPrev()
		{
		}

		// Token: 0x06028325 RID: 164645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028325")]
		[Address(RVA = "0x237EE10", Offset = "0x237DA10", VA = "0x18237EE10")]
		public void OnNavNext()
		{
		}

		// Token: 0x06028326 RID: 164646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028326")]
		[Address(RVA = "0x237ED70", Offset = "0x237D970", VA = "0x18237ED70")]
		public void OnEnterRaidMode()
		{
		}

		// Token: 0x06028327 RID: 164647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028327")]
		[Address(RVA = "0x237F9F0", Offset = "0x237E5F0", VA = "0x18237F9F0")]
		private void _OnClickEnemyDetail()
		{
		}

		// Token: 0x06028328 RID: 164648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028328")]
		[Address(RVA = "0x237FA80", Offset = "0x237E680", VA = "0x18237FA80")]
		private void _OnClickMapPreview()
		{
		}

		// Token: 0x06028329 RID: 164649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028329")]
		[Address(RVA = "0x237FB10", Offset = "0x237E710", VA = "0x18237FB10")]
		private void _OnOpenSquad()
		{
		}

		// Token: 0x0602832A RID: 164650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602832A")]
		[Address(RVA = "0x237EF50", Offset = "0x237DB50", VA = "0x18237EF50", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2OffenseProp property)
		{
		}

		// Token: 0x0602832B RID: 164651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602832B")]
		[Address(RVA = "0x237F790", Offset = "0x237E390", VA = "0x18237F790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602832C RID: 164652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602832C")]
		[Address(RVA = "0x2380130", Offset = "0x237ED30", VA = "0x182380130")]
		private void _RenderNavBar(bool isFirstRender)
		{
		}

		// Token: 0x0602832D RID: 164653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602832D")]
		[Address(RVA = "0x2380710", Offset = "0x237F310", VA = "0x182380710")]
		private void _RenderStageSummary(bool isFirstRender)
		{
		}

		// Token: 0x0602832E RID: 164654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602832E")]
		[Address(RVA = "0x23804C0", Offset = "0x237F0C0", VA = "0x1823804C0")]
		private void _RenderStageDetail(bool isFirstRender, bool needNavNext, bool showBtn)
		{
		}

		// Token: 0x0602832F RID: 164655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602832F")]
		[Address(RVA = "0x237FF20", Offset = "0x237EB20", VA = "0x18237FF20")]
		private void _PlayNavCursorTweenIfNeed(bool isFirstRender)
		{
		}

		// Token: 0x06028330 RID: 164656 RVA: 0x000D0DE8 File Offset: 0x000CEFE8
		[Token(Token = "0x6028330")]
		[Address(RVA = "0x237F6D0", Offset = "0x237E2D0", VA = "0x18237F6D0")]
		private float _GetCursorTargetPos(int navIdx)
		{
			return 0f;
		}

		// Token: 0x06028331 RID: 164657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028331")]
		[Address(RVA = "0x2380950", Offset = "0x237F550", VA = "0x182380950")]
		private void _RenderSwitchModeBtn()
		{
		}

		// Token: 0x06028332 RID: 164658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028332")]
		[Address(RVA = "0x23802F0", Offset = "0x237EEF0", VA = "0x1823802F0")]
		private void _RenderSeasonPart()
		{
		}

		// Token: 0x06028333 RID: 164659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028333")]
		[Address(RVA = "0x237FD60", Offset = "0x237E960", VA = "0x18237FD60")]
		private void _PlayEnterAnimIfNeed(bool isFirstRender, bool enterFromBattle)
		{
		}

		// Token: 0x06028334 RID: 164660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028334")]
		[Address(RVA = "0x237FBB0", Offset = "0x237E7B0", VA = "0x18237FBB0")]
		private void _PlayBtnAnimIfNeed(bool isFirstRender, bool needNavNext, bool showBtn)
		{
		}

		// Token: 0x06028335 RID: 164661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028335")]
		[Address(RVA = "0x2380A60", Offset = "0x237F660", VA = "0x182380A60")]
		public ActVecBreakV2OffenseStageSelectView()
		{
		}

		// Token: 0x04039188 RID: 233864
		[Token(Token = "0x4039188")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Nav Bar")]
		private SimpleLayoutContent _navList;

		// Token: 0x04039189 RID: 233865
		[Token(Token = "0x4039189")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Nav Bar")]
		private GridLayoutGroup _navListLayoutGroup;

		// Token: 0x0403918A RID: 233866
		[Token(Token = "0x403918A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Nav Bar")]
		private float _navCursorTweenDuration;

		// Token: 0x0403918B RID: 233867
		[Token(Token = "0x403918B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("Nav Bar")]
		private float _navItemHeight;

		// Token: 0x0403918C RID: 233868
		[Token(Token = "0x403918C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Nav Bar")]
		private UIAtlasImage _navCursor;

		// Token: 0x0403918D RID: 233869
		[Token(Token = "0x403918D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Nav Bar")]
		private GameObject _btnNavPrevPart;

		// Token: 0x0403918E RID: 233870
		[Token(Token = "0x403918E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Nav Bar")]
		private GameObject _btnNavNextPart;

		// Token: 0x0403918F RID: 233871
		[Token(Token = "0x403918F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Nav Bar")]
		private GameObject _btnNavNextAvailGo;

		// Token: 0x04039190 RID: 233872
		[Token(Token = "0x4039190")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Nav Bar")]
		private GameObject _btnNavNextLockGo;

		// Token: 0x04039191 RID: 233873
		[Token(Token = "0x4039191")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Stage Summary")]
		private Text _textCurrLv;

		// Token: 0x04039192 RID: 233874
		[Token(Token = "0x4039192")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Stage Summary")]
		private Text _textTotalLv;

		// Token: 0x04039193 RID: 233875
		[Token(Token = "0x4039193")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Stage Summary")]
		private Text _textStageCodeName;

		// Token: 0x04039194 RID: 233876
		[Token(Token = "0x4039194")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Stage Summary")]
		private UIAnimationLocation _effectSwitchAnimLocation;

		// Token: 0x04039195 RID: 233877
		[Token(Token = "0x4039195")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Tower")]
		private ActVecBreakV2OffenseTowerView _towerView;

		// Token: 0x04039196 RID: 233878
		[Token(Token = "0x4039196")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Stage Detail")]
		private RectTransform _stageDetailRoot;

		// Token: 0x04039197 RID: 233879
		[Token(Token = "0x4039197")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Stage Detail")]
		private ActVecBreakV2OffenseStageDetailView _stageDetailViewPrefab;

		// Token: 0x04039198 RID: 233880
		[Token(Token = "0x4039198")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Switch Mode")]
		private GameObject _switchUnlockPart;

		// Token: 0x04039199 RID: 233881
		[Token(Token = "0x4039199")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Switch Mode")]
		private GameObject _switchLockedPart;

		// Token: 0x0403919A RID: 233882
		[Token(Token = "0x403919A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Switch Mode")]
		private RectTransform _switchModeTrackContainer;

		// Token: 0x0403919B RID: 233883
		[Token(Token = "0x403919B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Switch Mode")]
		private GameObject _newTrackObject;

		// Token: 0x0403919C RID: 233884
		[Token(Token = "0x403919C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _enterAnimLocation;

		// Token: 0x0403919D RID: 233885
		[Token(Token = "0x403919D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _btnAnimLocation;

		// Token: 0x0403919E RID: 233886
		[Token(Token = "0x403919E")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_inited;

		// Token: 0x0403919F RID: 233887
		[Token(Token = "0x403919F")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040391A0 RID: 233888
		[Token(Token = "0x40391A0")]
		[FieldOffset(Offset = "0xF8")]
		private VecBreakV2OffenseModel m_cachedModel;

		// Token: 0x040391A1 RID: 233889
		[Token(Token = "0x40391A1")]
		[FieldOffset(Offset = "0x100")]
		private string m_actId;

		// Token: 0x040391A2 RID: 233890
		[Token(Token = "0x40391A2")]
		[FieldOffset(Offset = "0x108")]
		private Color m_themeColor;

		// Token: 0x040391A3 RID: 233891
		[Token(Token = "0x40391A3")]
		[FieldOffset(Offset = "0x118")]
		private int m_cachedEnterSeqNum;

		// Token: 0x040391A4 RID: 233892
		[Token(Token = "0x40391A4")]
		[FieldOffset(Offset = "0x11C")]
		private int m_cachedBtnSeqNum;

		// Token: 0x040391A5 RID: 233893
		[Token(Token = "0x40391A5")]
		[FieldOffset(Offset = "0x120")]
		private string m_cachedStageId;

		// Token: 0x040391A6 RID: 233894
		[Token(Token = "0x40391A6")]
		[FieldOffset(Offset = "0x128")]
		private int m_cachedNavIdx;

		// Token: 0x040391A7 RID: 233895
		[Token(Token = "0x40391A7")]
		[FieldOffset(Offset = "0x130")]
		private ActVecBreakV2OffenseStageSelectView.NavListAdapter m_navListAdapter;

		// Token: 0x040391A8 RID: 233896
		[Token(Token = "0x40391A8")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_navCursorTween;

		// Token: 0x040391A9 RID: 233897
		[Token(Token = "0x40391A9")]
		[FieldOffset(Offset = "0x140")]
		private Tween m_enterAnimTween;

		// Token: 0x040391AA RID: 233898
		[Token(Token = "0x40391AA")]
		[FieldOffset(Offset = "0x148")]
		private AnimationSwitchTween m_effectSwitchTween;

		// Token: 0x040391AB RID: 233899
		[Token(Token = "0x40391AB")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_btnTween;

		// Token: 0x040391AC RID: 233900
		[Token(Token = "0x40391AC")]
		[FieldOffset(Offset = "0x158")]
		private ActVecBreakV2OffenseStageDetailView m_stageDetailView;

		// Token: 0x040391AD RID: 233901
		[Token(Token = "0x40391AD")]
		[FieldOffset(Offset = "0x160")]
		private GameObject m_trackObject;

		// Token: 0x040391AE RID: 233902
		[Token(Token = "0x40391AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnNavPrev;

		// Token: 0x040391AF RID: 233903
		[Token(Token = "0x40391AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnNavNext;

		// Token: 0x040391B0 RID: 233904
		[Token(Token = "0x40391B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnterRaidMode;

		// Token: 0x040391B1 RID: 233905
		[Token(Token = "0x40391B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClickEnemyDetail;

		// Token: 0x040391B2 RID: 233906
		[Token(Token = "0x40391B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnClickMapPreview;

		// Token: 0x040391B3 RID: 233907
		[Token(Token = "0x40391B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnOpenSquad;

		// Token: 0x040391B4 RID: 233908
		[Token(Token = "0x40391B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040391B5 RID: 233909
		[Token(Token = "0x40391B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040391B6 RID: 233910
		[Token(Token = "0x40391B6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderNavBar;

		// Token: 0x040391B7 RID: 233911
		[Token(Token = "0x40391B7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderStageSummary;

		// Token: 0x040391B8 RID: 233912
		[Token(Token = "0x40391B8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderStageDetail;

		// Token: 0x040391B9 RID: 233913
		[Token(Token = "0x40391B9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayNavCursorTweenIfNeed;

		// Token: 0x040391BA RID: 233914
		[Token(Token = "0x40391BA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetCursorTargetPos;

		// Token: 0x040391BB RID: 233915
		[Token(Token = "0x40391BB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderSwitchModeBtn;

		// Token: 0x040391BC RID: 233916
		[Token(Token = "0x40391BC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderSeasonPart;

		// Token: 0x040391BD RID: 233917
		[Token(Token = "0x40391BD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x040391BE RID: 233918
		[Token(Token = "0x40391BE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PlayBtnAnimIfNeed;

		// Token: 0x040391BF RID: 233919
		[Token(Token = "0x40391BF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E55 RID: 28245
		[Token(Token = "0x2006E55")]
		private class NavListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028336 RID: 164662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028336")]
			[Address(RVA = "0x2387B00", Offset = "0x2386700", VA = "0x182387B00")]
			public NavListAdapter(ActVecBreakV2OffenseStageSelectView closure)
			{
			}

			// Token: 0x17005EFB RID: 24315
			// (get) Token: 0x06028337 RID: 164663 RVA: 0x000D0E00 File Offset: 0x000CF000
			[Token(Token = "0x17005EFB")]
			public override int count
			{
				[Token(Token = "0x6028337")]
				[Address(RVA = "0x2387B80", Offset = "0x2386780", VA = "0x182387B80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028338 RID: 164664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028338")]
			[Address(RVA = "0x2387920", Offset = "0x2386520", VA = "0x182387920", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040391C0 RID: 233920
			[Token(Token = "0x40391C0")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2OffenseStageSelectView m_closure;

			// Token: 0x040391C1 RID: 233921
			[Token(Token = "0x40391C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040391C2 RID: 233922
			[Token(Token = "0x40391C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040391C3 RID: 233923
			[Token(Token = "0x40391C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
