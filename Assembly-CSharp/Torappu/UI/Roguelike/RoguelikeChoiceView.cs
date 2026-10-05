using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051C3 RID: 20931
	[Token(Token = "0x20051C3")]
	public class RoguelikeChoiceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x0601EEA9 RID: 126633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EEAA RID: 126634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700482C")]
		public Action<string> onChoiceSelect
		{
			[Token(Token = "0x601EEA9")]
			[Address(RVA = "0x18A8B40", Offset = "0x18A7740", VA = "0x1818A8B40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EEAA")]
			[Address(RVA = "0x18A8C00", Offset = "0x18A7800", VA = "0x1818A8C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x0601EEAB RID: 126635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EEAC RID: 126636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700482D")]
		public Action<bool> onShowMenu
		{
			[Token(Token = "0x601EEAB")]
			[Address(RVA = "0x18A8BA0", Offset = "0x18A77A0", VA = "0x1818A8BA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EEAC")]
			[Address(RVA = "0x18A8C80", Offset = "0x18A7880", VA = "0x1818A8C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x0601EEAD RID: 126637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700482E")]
		public RoguelikeChoicePlugin choicePlugin
		{
			[Token(Token = "0x601EEAD")]
			[Address(RVA = "0x18A8A80", Offset = "0x18A7680", VA = "0x1818A8A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x0601EEAE RID: 126638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700482F")]
		public RoguelikeChoiceEffectBase effectPrefab
		{
			[Token(Token = "0x601EEAE")]
			[Address(RVA = "0x18A8AE0", Offset = "0x18A76E0", VA = "0x1818A8AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EEAF RID: 126639 RVA: 0x000B0208 File Offset: 0x000AE408
		[Token(Token = "0x601EEAF")]
		[Address(RVA = "0x18A7D40", Offset = "0x18A6940", VA = "0x1818A7D40")]
		private float _Cubic01(float val)
		{
			return 0f;
		}

		// Token: 0x0601EEB0 RID: 126640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB0")]
		[Address(RVA = "0x18A75D0", Offset = "0x18A61D0", VA = "0x1818A75D0")]
		public void Render(RoguelikeChoiceScene choiceScene, bool fade)
		{
		}

		// Token: 0x0601EEB1 RID: 126641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB1")]
		[Address(RVA = "0x18A70E0", Offset = "0x18A5CE0", VA = "0x1818A70E0")]
		public void HideMainView()
		{
		}

		// Token: 0x0601EEB2 RID: 126642 RVA: 0x000B0220 File Offset: 0x000AE420
		[Token(Token = "0x601EEB2")]
		[Address(RVA = "0x18A71E0", Offset = "0x18A5DE0", VA = "0x1818A71E0")]
		public bool IsSceneEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601EEB3 RID: 126643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB3")]
		[Address(RVA = "0x18A7E60", Offset = "0x18A6A60", VA = "0x1818A7E60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EEB4 RID: 126644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB4")]
		[Address(RVA = "0x18A77C0", Offset = "0x18A63C0", VA = "0x1818A77C0")]
		private void _ChoiceActiveControl([Optional] Func<RoguelikeChoiceItemView, bool> pred)
		{
		}

		// Token: 0x0601EEB5 RID: 126645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB5")]
		[Address(RVA = "0x18A7160", Offset = "0x18A5D60", VA = "0x1818A7160")]
		public void Init(RoguelikeDungeonPage page)
		{
		}

		// Token: 0x0601EEB6 RID: 126646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB6")]
		[Address(RVA = "0x18A7DE0", Offset = "0x18A69E0", VA = "0x1818A7DE0")]
		private void _IncrementAnimCount()
		{
		}

		// Token: 0x0601EEB7 RID: 126647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB7")]
		[Address(RVA = "0x18A8950", Offset = "0x18A7550", VA = "0x1818A8950")]
		private void _UnactiveAllChoice()
		{
		}

		// Token: 0x0601EEB8 RID: 126648 RVA: 0x000B0238 File Offset: 0x000AE438
		[Token(Token = "0x601EEB8")]
		[Address(RVA = "0x18A8000", Offset = "0x18A6C00", VA = "0x1818A8000")]
		private bool _IsOnlyLeaveOption()
		{
			return default(bool);
		}

		// Token: 0x0601EEB9 RID: 126649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEB9")]
		[Address(RVA = "0x18A80D0", Offset = "0x18A6CD0", VA = "0x1818A80D0")]
		private void _RefreshView(bool fade)
		{
		}

		// Token: 0x0601EEBA RID: 126650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EEBA")]
		[Address(RVA = "0x18A7F40", Offset = "0x18A6B40", VA = "0x1818A7F40")]
		private IEnumerator _IntroCoroutine(bool onlyLeaveChoice)
		{
			return null;
		}

		// Token: 0x0601EEBB RID: 126651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEBB")]
		[Address(RVA = "0x18A7AF0", Offset = "0x18A66F0", VA = "0x1818A7AF0")]
		private void _ChoiceActived(IRoguelikeGameChoice choice)
		{
		}

		// Token: 0x0601EEBC RID: 126652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEBC")]
		[Address(RVA = "0x18A7C10", Offset = "0x18A6810", VA = "0x1818A7C10")]
		private void _ChoiceSelected(IRoguelikeGameChoice choice)
		{
		}

		// Token: 0x0601EEBD RID: 126653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEBD")]
		[Address(RVA = "0x18A7370", Offset = "0x18A5F70", VA = "0x1818A7370")]
		public void OnLeaveButtonPressed()
		{
		}

		// Token: 0x0601EEBE RID: 126654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEBE")]
		[Address(RVA = "0x18A7240", Offset = "0x18A5E40", VA = "0x1818A7240")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x0601EEBF RID: 126655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEBF")]
		[Address(RVA = "0x18A89B0", Offset = "0x18A75B0", VA = "0x1818A89B0")]
		public RoguelikeChoiceView()
		{
		}

		// Token: 0x04029792 RID: 169874
		[Token(Token = "0x4029792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _backgroundFadeSpeed;

		// Token: 0x04029793 RID: 169875
		[Token(Token = "0x4029793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _dialogTitle;

		// Token: 0x04029794 RID: 169876
		[Token(Token = "0x4029794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AVGTypeWriterText _dialogContentTypewriter;

		// Token: 0x04029795 RID: 169877
		[Token(Token = "0x4029795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _choiceLayoutContent;

		// Token: 0x04029796 RID: 169878
		[Token(Token = "0x4029796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _dialogContentTargetRect;

		// Token: 0x04029797 RID: 169879
		[Token(Token = "0x4029797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _leavingPanel;

		// Token: 0x04029798 RID: 169880
		[Token(Token = "0x4029798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _choiceScroll;

		// Token: 0x04029799 RID: 169881
		[Token(Token = "0x4029799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _mainViewCanvasGroup;

		// Token: 0x0402979A RID: 169882
		[Token(Token = "0x402979A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _introTweenDuration;

		// Token: 0x0402979B RID: 169883
		[Token(Token = "0x402979B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _introTweenContentPosX0;

		// Token: 0x0402979C RID: 169884
		[Token(Token = "0x402979C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _introTweenContentPosX1;

		// Token: 0x0402979D RID: 169885
		[Token(Token = "0x402979D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _introTweenChoicePosX0;

		// Token: 0x0402979E RID: 169886
		[Token(Token = "0x402979E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _introTweenChoicePosX1;

		// Token: 0x0402979F RID: 169887
		[Token(Token = "0x402979F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool _introClickBlock;

		// Token: 0x040297A0 RID: 169888
		[Token(Token = "0x40297A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[SerializeField]
		private bool _introClickBlockUseMaxDuration;

		// Token: 0x040297A1 RID: 169889
		[Token(Token = "0x40297A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _introClickBlockMaxTimeDurationValue;

		// Token: 0x040297A2 RID: 169890
		[Token(Token = "0x40297A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _choiceCanvasGroup;

		// Token: 0x040297A3 RID: 169891
		[Token(Token = "0x40297A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _imgTitleIcon;

		// Token: 0x040297A4 RID: 169892
		[Token(Token = "0x40297A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x040297A5 RID: 169893
		[Token(Token = "0x40297A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeChoiceEffectBase _effectPrefab;

		// Token: 0x040297A6 RID: 169894
		[Token(Token = "0x40297A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeChoicePlugin _choicePlugin;

		// Token: 0x040297A7 RID: 169895
		[Token(Token = "0x40297A7")]
		private const string DEFAULT_TITLE_ICON = "title_icon_default";

		// Token: 0x040297A8 RID: 169896
		[Token(Token = "0x40297A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RoguelikeChoiceView.IntroStep m_introStep;

		// Token: 0x040297A9 RID: 169897
		[Token(Token = "0x40297A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool m_introClick;

		// Token: 0x040297AA RID: 169898
		[Token(Token = "0x40297AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Coroutine m_coroutine;

		// Token: 0x040297AB RID: 169899
		[Token(Token = "0x40297AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x040297AC RID: 169900
		[Token(Token = "0x40297AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RoguelikeChoiceView.ChoiceAdapter m_adapter;

		// Token: 0x040297AD RID: 169901
		[Token(Token = "0x40297AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool m_isSwitching;

		// Token: 0x040297AE RID: 169902
		[Token(Token = "0x40297AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_totalAnimCount;

		// Token: 0x040297AF RID: 169903
		[Token(Token = "0x40297AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int m_completeAnimCount;

		// Token: 0x040297B0 RID: 169904
		[Token(Token = "0x40297B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<RoguelikeChoiceItemView> m_animItemList;

		// Token: 0x040297B1 RID: 169905
		[Token(Token = "0x40297B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RoguelikeChoiceScene m_choiceScene;

		// Token: 0x040297B2 RID: 169906
		[Token(Token = "0x40297B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string m_topicId;

		// Token: 0x040297B3 RID: 169907
		[Token(Token = "0x40297B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private UIPage m_page;

		// Token: 0x040297B6 RID: 169910
		[Token(Token = "0x40297B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onChoiceSelect;

		// Token: 0x040297B7 RID: 169911
		[Token(Token = "0x40297B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onChoiceSelect;

		// Token: 0x040297B8 RID: 169912
		[Token(Token = "0x40297B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onShowMenu;

		// Token: 0x040297B9 RID: 169913
		[Token(Token = "0x40297B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onShowMenu;

		// Token: 0x040297BA RID: 169914
		[Token(Token = "0x40297BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_choicePlugin;

		// Token: 0x040297BB RID: 169915
		[Token(Token = "0x40297BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_effectPrefab;

		// Token: 0x040297BC RID: 169916
		[Token(Token = "0x40297BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Cubic01;

		// Token: 0x040297BD RID: 169917
		[Token(Token = "0x40297BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040297BE RID: 169918
		[Token(Token = "0x40297BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HideMainView;

		// Token: 0x040297BF RID: 169919
		[Token(Token = "0x40297BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsSceneEmpty;

		// Token: 0x040297C0 RID: 169920
		[Token(Token = "0x40297C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040297C1 RID: 169921
		[Token(Token = "0x40297C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ChoiceActiveControl;

		// Token: 0x040297C2 RID: 169922
		[Token(Token = "0x40297C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040297C3 RID: 169923
		[Token(Token = "0x40297C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IncrementAnimCount;

		// Token: 0x040297C4 RID: 169924
		[Token(Token = "0x40297C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UnactiveAllChoice;

		// Token: 0x040297C5 RID: 169925
		[Token(Token = "0x40297C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__IsOnlyLeaveOption;

		// Token: 0x040297C6 RID: 169926
		[Token(Token = "0x40297C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x040297C7 RID: 169927
		[Token(Token = "0x40297C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IntroCoroutine;

		// Token: 0x040297C8 RID: 169928
		[Token(Token = "0x40297C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ChoiceActived;

		// Token: 0x040297C9 RID: 169929
		[Token(Token = "0x40297C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ChoiceSelected;

		// Token: 0x040297CA RID: 169930
		[Token(Token = "0x40297CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnLeaveButtonPressed;

		// Token: 0x040297CB RID: 169931
		[Token(Token = "0x40297CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x040297CC RID: 169932
		[Token(Token = "0x40297CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051C4 RID: 20932
		[Token(Token = "0x20051C4")]
		private enum IntroStep
		{
			// Token: 0x040297CE RID: 169934
			[Token(Token = "0x40297CE")]
			NONE,
			// Token: 0x040297CF RID: 169935
			[Token(Token = "0x40297CF")]
			TYPING,
			// Token: 0x040297D0 RID: 169936
			[Token(Token = "0x40297D0")]
			INTERACT_WAITING,
			// Token: 0x040297D1 RID: 169937
			[Token(Token = "0x40297D1")]
			UI_TWEEN
		}

		// Token: 0x020051C5 RID: 20933
		[Token(Token = "0x20051C5")]
		private class ChoiceAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601EEC0 RID: 126656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EEC0")]
			[Address(RVA = "0x18AD820", Offset = "0x18AC420", VA = "0x1818AD820")]
			public ChoiceAdapter(RoguelikeChoiceView closure)
			{
			}

			// Token: 0x17004830 RID: 18480
			// (get) Token: 0x0601EEC1 RID: 126657 RVA: 0x000B0250 File Offset: 0x000AE450
			[Token(Token = "0x17004830")]
			public override int count
			{
				[Token(Token = "0x601EEC1")]
				[Address(RVA = "0x18AD8A0", Offset = "0x18AC4A0", VA = "0x1818AD8A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601EEC2 RID: 126658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EEC2")]
			[Address(RVA = "0x18AD590", Offset = "0x18AC190", VA = "0x1818AD590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040297D2 RID: 169938
			[Token(Token = "0x40297D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private RoguelikeChoiceView m_closure;

			// Token: 0x040297D3 RID: 169939
			[Token(Token = "0x40297D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040297D4 RID: 169940
			[Token(Token = "0x40297D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040297D5 RID: 169941
			[Token(Token = "0x40297D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
