using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act29side.Battle.UI
{
	// Token: 0x020074B1 RID: 29873
	[Token(Token = "0x20074B1")]
	public class Act29sideUIPlugin : UIController.Plugin
	{
		// Token: 0x0602A20A RID: 172554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A20A")]
		[Address(RVA = "0x25AEC10", Offset = "0x25AD810", VA = "0x1825AEC10", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x0602A20B RID: 172555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A20B")]
		[Address(RVA = "0x25AEDF0", Offset = "0x25AD9F0", VA = "0x1825AEDF0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x0602A20C RID: 172556 RVA: 0x000D7808 File Offset: 0x000D5A08
		[Token(Token = "0x602A20C")]
		[Address(RVA = "0x25AF850", Offset = "0x25AE450", VA = "0x1825AF850")]
		private bool _CheckAllResourcesValid()
		{
			return default(bool);
		}

		// Token: 0x0602A20D RID: 172557 RVA: 0x000D7820 File Offset: 0x000D5A20
		[Token(Token = "0x602A20D")]
		[Address(RVA = "0x25B0A60", Offset = "0x25AF660", VA = "0x1825B0A60")]
		private bool _InitAllMembers()
		{
			return default(bool);
		}

		// Token: 0x0602A20E RID: 172558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A20E")]
		[Address(RVA = "0x25B1120", Offset = "0x25AFD20", VA = "0x1825B1120")]
		private void _SetProgressBars()
		{
		}

		// Token: 0x0602A20F RID: 172559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A20F")]
		[Address(RVA = "0x25B0DD0", Offset = "0x25AF9D0", VA = "0x1825B0DD0")]
		private void _SetBackground()
		{
		}

		// Token: 0x0602A210 RID: 172560 RVA: 0x000D7838 File Offset: 0x000D5A38
		[Token(Token = "0x602A210")]
		[Address(RVA = "0x25AFC50", Offset = "0x25AE850", VA = "0x1825AFC50")]
		private float _ComputeProgress()
		{
			return 0f;
		}

		// Token: 0x0602A211 RID: 172561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A211")]
		[Address(RVA = "0x25AFFD0", Offset = "0x25AEBD0", VA = "0x1825AFFD0")]
		private void _ComputeStageList()
		{
		}

		// Token: 0x0602A212 RID: 172562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A212")]
		[Address(RVA = "0x25AFAD0", Offset = "0x25AE6D0", VA = "0x1825AFAD0")]
		private void _CloseNormalBars()
		{
		}

		// Token: 0x0602A213 RID: 172563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A213")]
		[Address(RVA = "0x25B07E0", Offset = "0x25AF3E0", VA = "0x1825B07E0")]
		private void _FadeEnthuMark(bool isFadeIn)
		{
		}

		// Token: 0x0602A214 RID: 172564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A214")]
		[Address(RVA = "0x25B0560", Offset = "0x25AF160", VA = "0x1825B0560")]
		private void _FadeDepressedMark(bool isFadeIn)
		{
		}

		// Token: 0x0602A215 RID: 172565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A215")]
		[Address(RVA = "0x25B06A0", Offset = "0x25AF2A0", VA = "0x1825B06A0")]
		private void _FadeEmptyMark(bool isFadeIn)
		{
		}

		// Token: 0x0602A216 RID: 172566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A216")]
		[Address(RVA = "0x25B0920", Offset = "0x25AF520", VA = "0x1825B0920")]
		private void _FadeProgressMark(bool isFadeIn)
		{
		}

		// Token: 0x0602A217 RID: 172567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A217")]
		[Address(RVA = "0x25B03C0", Offset = "0x25AEFC0", VA = "0x1825B03C0")]
		private void _DoFade(bool isFadeIn, ref UIAtlasImage atlasImage, ref Tween tween)
		{
		}

		// Token: 0x0602A218 RID: 172568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A218")]
		[Address(RVA = "0x25B1830", Offset = "0x25B0430", VA = "0x1825B1830")]
		public Act29sideUIPlugin()
		{
		}

		// Token: 0x0602A219 RID: 172569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A219")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x0602A21A RID: 172570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A21A")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0403C803 RID: 247811
		[Token(Token = "0x403C803")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _enthuBarColor;

		// Token: 0x0403C804 RID: 247812
		[Token(Token = "0x403C804")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _depressedBarColor;

		// Token: 0x0403C805 RID: 247813
		[Token(Token = "0x403C805")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _emptyBarColor;

		// Token: 0x0403C806 RID: 247814
		[Token(Token = "0x403C806")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _progressMark;

		// Token: 0x0403C807 RID: 247815
		[Token(Token = "0x403C807")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _progressMarkDepressed;

		// Token: 0x0403C808 RID: 247816
		[Token(Token = "0x403C808")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _progressMarkEnthu;

		// Token: 0x0403C809 RID: 247817
		[Token(Token = "0x403C809")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _progressMarkEmpty;

		// Token: 0x0403C80A RID: 247818
		[Token(Token = "0x403C80A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _backgroundLine;

		// Token: 0x0403C80B RID: 247819
		[Token(Token = "0x403C80B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _backgroundQuad1;

		// Token: 0x0403C80C RID: 247820
		[Token(Token = "0x403C80C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _backgroundQuad2;

		// Token: 0x0403C80D RID: 247821
		[Token(Token = "0x403C80D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _backgroundQuad3;

		// Token: 0x0403C80E RID: 247822
		[Token(Token = "0x403C80E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Act29sideUIProgressBar _progressBar;

		// Token: 0x0403C80F RID: 247823
		[Token(Token = "0x403C80F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _anchor;

		// Token: 0x0403C810 RID: 247824
		[Token(Token = "0x403C810")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _backgroundQuadsAnchor;

		// Token: 0x0403C811 RID: 247825
		[Token(Token = "0x403C811")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _backgroundLinesAnchor;

		// Token: 0x0403C812 RID: 247826
		[Token(Token = "0x403C812")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform _progressBarAnchor;

		// Token: 0x0403C813 RID: 247827
		[Token(Token = "0x403C813")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _evnSystemKey;

		// Token: 0x0403C814 RID: 247828
		[Token(Token = "0x403C814")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Act29sideUIProgressBarBoss _progressBarBoss;

		// Token: 0x0403C815 RID: 247829
		[Token(Token = "0x403C815")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403C816 RID: 247830
		[Token(Token = "0x403C816")]
		[FieldOffset(Offset = "0xD8")]
		private Act29SideManager m_evnManager;

		// Token: 0x0403C817 RID: 247831
		[Token(Token = "0x403C817")]
		[FieldOffset(Offset = "0xE0")]
		private float m_progress;

		// Token: 0x0403C818 RID: 247832
		[Token(Token = "0x403C818")]
		[FieldOffset(Offset = "0xE4")]
		private bool m_hasGameStarted;

		// Token: 0x0403C819 RID: 247833
		[Token(Token = "0x403C819")]
		[FieldOffset(Offset = "0xE5")]
		private bool m_isValid;

		// Token: 0x0403C81A RID: 247834
		[Token(Token = "0x403C81A")]
		[FieldOffset(Offset = "0xE6")]
		private bool m_isFadingIn;

		// Token: 0x0403C81B RID: 247835
		[Token(Token = "0x403C81B")]
		[FieldOffset(Offset = "0xE7")]
		private bool m_isFadingOut;

		// Token: 0x0403C81C RID: 247836
		[Token(Token = "0x403C81C")]
		[FieldOffset(Offset = "0xE8")]
		private float m_tweenTime;

		// Token: 0x0403C81D RID: 247837
		[Token(Token = "0x403C81D")]
		[FieldOffset(Offset = "0xEC")]
		private int m_currentStage;

		// Token: 0x0403C81E RID: 247838
		[Token(Token = "0x403C81E")]
		[FieldOffset(Offset = "0xF0")]
		private float m_totalStageLength;

		// Token: 0x0403C81F RID: 247839
		[Token(Token = "0x403C81F")]
		[FieldOffset(Offset = "0xF8")]
		private List<Act29sideUIPlugin.stageInfo> m_stageInfoList;

		// Token: 0x0403C820 RID: 247840
		[Token(Token = "0x403C820")]
		[FieldOffset(Offset = "0x100")]
		private List<float> m_preTimeList;

		// Token: 0x0403C821 RID: 247841
		[Token(Token = "0x403C821")]
		[FieldOffset(Offset = "0x108")]
		private float m_standardLength;

		// Token: 0x0403C822 RID: 247842
		[Token(Token = "0x403C822")]
		[FieldOffset(Offset = "0x110")]
		private List<Act29sideUIProgressBar> m_progressBars;

		// Token: 0x0403C823 RID: 247843
		[Token(Token = "0x403C823")]
		[FieldOffset(Offset = "0x118")]
		private bool m_hasBeenControlledByBoss;

		// Token: 0x0403C824 RID: 247844
		[Token(Token = "0x403C824")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_markEnthuTweenFO;

		// Token: 0x0403C825 RID: 247845
		[Token(Token = "0x403C825")]
		[FieldOffset(Offset = "0x128")]
		private Tween m_markEnthuTweenFI;

		// Token: 0x0403C826 RID: 247846
		[Token(Token = "0x403C826")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_markDepressedTweenFO;

		// Token: 0x0403C827 RID: 247847
		[Token(Token = "0x403C827")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_markDepressedTweenFI;

		// Token: 0x0403C828 RID: 247848
		[Token(Token = "0x403C828")]
		[FieldOffset(Offset = "0x140")]
		private Tween m_markEmptyTweenFO;

		// Token: 0x0403C829 RID: 247849
		[Token(Token = "0x403C829")]
		[FieldOffset(Offset = "0x148")]
		private Tween m_markEmptyTweenFI;

		// Token: 0x0403C82A RID: 247850
		[Token(Token = "0x403C82A")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_markProgressTweenFI;

		// Token: 0x0403C82B RID: 247851
		[Token(Token = "0x403C82B")]
		[FieldOffset(Offset = "0x158")]
		private Tween m_markProgressTweenFO;

		// Token: 0x0403C82C RID: 247852
		[Token(Token = "0x403C82C")]
		private const string START_ANIM = "act29side_battle_ui_normal_entry";

		// Token: 0x0403C82D RID: 247853
		[Token(Token = "0x403C82D")]
		private const string SWITCH_AUDIO_ANIM = "act29side_battle_ui_variation_highlight";

		// Token: 0x0403C82E RID: 247854
		[Token(Token = "0x403C82E")]
		private const string BOSS_APPEAR_ANIM = "act29side_battle_ui_boss_entry";

		// Token: 0x0403C82F RID: 247855
		[Token(Token = "0x403C82F")]
		private const float DECO_QUAD_LADDER_3 = 3f;

		// Token: 0x0403C830 RID: 247856
		[Token(Token = "0x403C830")]
		private const float DECO_QUAD_LADDER_2 = 2f;

		// Token: 0x0403C831 RID: 247857
		[Token(Token = "0x403C831")]
		private const float DECO_QUAD_LADDER_1 = 0.5f;

		// Token: 0x0403C832 RID: 247858
		[Token(Token = "0x403C832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403C833 RID: 247859
		[Token(Token = "0x403C833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403C834 RID: 247860
		[Token(Token = "0x403C834")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckAllResourcesValid;

		// Token: 0x0403C835 RID: 247861
		[Token(Token = "0x403C835")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitAllMembers;

		// Token: 0x0403C836 RID: 247862
		[Token(Token = "0x403C836")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetProgressBars;

		// Token: 0x0403C837 RID: 247863
		[Token(Token = "0x403C837")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetBackground;

		// Token: 0x0403C838 RID: 247864
		[Token(Token = "0x403C838")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ComputeProgress;

		// Token: 0x0403C839 RID: 247865
		[Token(Token = "0x403C839")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ComputeStageList;

		// Token: 0x0403C83A RID: 247866
		[Token(Token = "0x403C83A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CloseNormalBars;

		// Token: 0x0403C83B RID: 247867
		[Token(Token = "0x403C83B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FadeEnthuMark;

		// Token: 0x0403C83C RID: 247868
		[Token(Token = "0x403C83C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FadeDepressedMark;

		// Token: 0x0403C83D RID: 247869
		[Token(Token = "0x403C83D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FadeEmptyMark;

		// Token: 0x0403C83E RID: 247870
		[Token(Token = "0x403C83E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FadeProgressMark;

		// Token: 0x0403C83F RID: 247871
		[Token(Token = "0x403C83F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoFade;

		// Token: 0x0403C840 RID: 247872
		[Token(Token = "0x403C840")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074B2 RID: 29874
		[Token(Token = "0x20074B2")]
		private struct stageInfo
		{
			// Token: 0x0602A21B RID: 172571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A21B")]
			[Address(RVA = "0x25D9D20", Offset = "0x25D8920", VA = "0x1825D9D20")]
			public stageInfo(float pre, float duration, Act29SideManager.AudioType type)
			{
			}

			// Token: 0x0403C841 RID: 247873
			[Token(Token = "0x403C841")]
			[FieldOffset(Offset = "0x0")]
			public float postdelay;

			// Token: 0x0403C842 RID: 247874
			[Token(Token = "0x403C842")]
			[FieldOffset(Offset = "0x4")]
			public float audioBuffDuration;

			// Token: 0x0403C843 RID: 247875
			[Token(Token = "0x403C843")]
			[FieldOffset(Offset = "0x8")]
			public float totalTime;

			// Token: 0x0403C844 RID: 247876
			[Token(Token = "0x403C844")]
			[FieldOffset(Offset = "0xC")]
			public Act29SideManager.AudioType audiotype;
		}

		// Token: 0x020074B3 RID: 29875
		[Token(Token = "0x20074B3")]
		public struct ProgressBarInfo
		{
			// Token: 0x0602A21C RID: 172572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A21C")]
			[Address(RVA = "0x25D4F30", Offset = "0x25D3B30", VA = "0x1825D4F30")]
			public ProgressBarInfo(float pos, float wid, Act29SideManager.AudioType type, float sLength, float abLength, Act29SideManager mng, bool hideR)
			{
			}

			// Token: 0x0403C845 RID: 247877
			[Token(Token = "0x403C845")]
			[FieldOffset(Offset = "0x0")]
			public float position;

			// Token: 0x0403C846 RID: 247878
			[Token(Token = "0x403C846")]
			[FieldOffset(Offset = "0x4")]
			public float width;

			// Token: 0x0403C847 RID: 247879
			[Token(Token = "0x403C847")]
			[FieldOffset(Offset = "0x8")]
			public float standardLength;

			// Token: 0x0403C848 RID: 247880
			[Token(Token = "0x403C848")]
			[FieldOffset(Offset = "0xC")]
			public float audioBuffLength;

			// Token: 0x0403C849 RID: 247881
			[Token(Token = "0x403C849")]
			[FieldOffset(Offset = "0x10")]
			public bool hideRightMark;

			// Token: 0x0403C84A RID: 247882
			[Token(Token = "0x403C84A")]
			[FieldOffset(Offset = "0x14")]
			public Act29SideManager.AudioType audioType;

			// Token: 0x0403C84B RID: 247883
			[Token(Token = "0x403C84B")]
			[FieldOffset(Offset = "0x18")]
			public Act29SideManager manager;
		}
	}
}
