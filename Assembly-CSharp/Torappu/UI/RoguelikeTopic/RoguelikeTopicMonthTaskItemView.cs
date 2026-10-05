using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044E5 RID: 17637
	[Token(Token = "0x20044E5")]
	public class RoguelikeTopicMonthTaskItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x0601AED3 RID: 110291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AED4 RID: 110292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FE6")]
		public Action<RoguelikeTopicMonthTaskModel> onTaskRefreshAction
		{
			[Token(Token = "0x601AED3")]
			[Address(RVA = "0x1414030", Offset = "0x1412C30", VA = "0x181414030")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AED4")]
			[Address(RVA = "0x1414100", Offset = "0x1412D00", VA = "0x181414100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AED5 RID: 110293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AED5")]
		[Address(RVA = "0x1413150", Offset = "0x1411D50", VA = "0x181413150")]
		public void Render(RoguelikeTopicMonthTaskListModel taskListModel, RoguelikeTopicMonthTaskModel taskModel)
		{
		}

		// Token: 0x0601AED6 RID: 110294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AED6")]
		[Address(RVA = "0x14137D0", Offset = "0x14123D0", VA = "0x1814137D0")]
		public void TweenPrgTo(RoguelikeTopicMonthTaskListModel taskListModel, RoguelikeTopicMonthTaskModel taskModel, float dur)
		{
		}

		// Token: 0x0601AED7 RID: 110295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AED7")]
		[Address(RVA = "0x1413B30", Offset = "0x1412730", VA = "0x181413B30")]
		private void _DoneTween()
		{
		}

		// Token: 0x0601AED8 RID: 110296 RVA: 0x000A39F8 File Offset: 0x000A1BF8
		[Token(Token = "0x601AED8")]
		[Address(RVA = "0x1413BA0", Offset = "0x14127A0", VA = "0x181413BA0")]
		private float _GetPrg()
		{
			return 0f;
		}

		// Token: 0x0601AED9 RID: 110297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AED9")]
		[Address(RVA = "0x1413D10", Offset = "0x1412910", VA = "0x181413D10")]
		private void _SetPrg(float v)
		{
		}

		// Token: 0x0601AEDA RID: 110298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEDA")]
		[Address(RVA = "0x14130C0", Offset = "0x1411CC0", VA = "0x1814130C0")]
		public void PlayRefreshAnim()
		{
		}

		// Token: 0x0601AEDB RID: 110299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEDB")]
		[Address(RVA = "0x1413750", Offset = "0x1412350", VA = "0x181413750")]
		public void SetRefreshBtnVisible(bool v)
		{
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x0601AEDC RID: 110300 RVA: 0x000A3A10 File Offset: 0x000A1C10
		// (set) Token: 0x0601AEDD RID: 110301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FE7")]
		public RoguelikeTopicMonthTaskItemView.CompleteType completeType
		{
			[Token(Token = "0x601AEDC")]
			[Address(RVA = "0x1413FD0", Offset = "0x1412BD0", VA = "0x181413FD0")]
			[CompilerGenerated]
			get
			{
				return RoguelikeTopicMonthTaskItemView.CompleteType.DEFAULT;
			}
			[Token(Token = "0x601AEDD")]
			[Address(RVA = "0x1414090", Offset = "0x1412C90", VA = "0x181414090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AEDE RID: 110302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEDE")]
		[Address(RVA = "0x1413C30", Offset = "0x1412830", VA = "0x181413C30")]
		private void _RefreshTask()
		{
		}

		// Token: 0x0601AEDF RID: 110303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEDF")]
		[Address(RVA = "0x1412DD0", Offset = "0x14119D0", VA = "0x181412DD0")]
		public void OnBtnRefreshClick()
		{
		}

		// Token: 0x0601AEE0 RID: 110304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE0")]
		[Address(RVA = "0x1413F70", Offset = "0x1412B70", VA = "0x181413F70")]
		public RoguelikeTopicMonthTaskItemView()
		{
		}

		// Token: 0x04022886 RID: 141446
		[Token(Token = "0x4022886")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x04022887 RID: 141447
		[Token(Token = "0x4022887")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTaskName;

		// Token: 0x04022888 RID: 141448
		[Token(Token = "0x4022888")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTaskDesc;

		// Token: 0x04022889 RID: 141449
		[Token(Token = "0x4022889")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0402288A RID: 141450
		[Token(Token = "0x402288A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0402288B RID: 141451
		[Token(Token = "0x402288B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRewardCount;

		// Token: 0x0402288C RID: 141452
		[Token(Token = "0x402288C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textRewardName;

		// Token: 0x0402288D RID: 141453
		[Token(Token = "0x402288D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgRewardIcon;

		// Token: 0x0402288E RID: 141454
		[Token(Token = "0x402288E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _refreshAnim;

		// Token: 0x0402288F RID: 141455
		[Token(Token = "0x402288F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _activeContentGo;

		// Token: 0x04022890 RID: 141456
		[Token(Token = "0x4022890")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _btnRefresh;

		// Token: 0x04022891 RID: 141457
		[Token(Token = "0x4022891")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClickPlayer _btnAudioPlayer;

		// Token: 0x04022892 RID: 141458
		[Token(Token = "0x4022892")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Selectable _rewardColor;

		// Token: 0x04022893 RID: 141459
		[Token(Token = "0x4022893")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _completeNode;

		// Token: 0x04022894 RID: 141460
		[Token(Token = "0x4022894")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _refreshBtnNode;

		// Token: 0x04022895 RID: 141461
		[Token(Token = "0x4022895")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x04022896 RID: 141462
		[Token(Token = "0x4022896")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022897 RID: 141463
		[Token(Token = "0x4022897")]
		private const string TASK_BG_END = "task_bg_end";

		// Token: 0x04022898 RID: 141464
		[Token(Token = "0x4022898")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeTopicMonthTaskModel m_taskModel;

		// Token: 0x04022899 RID: 141465
		[Token(Token = "0x4022899")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeTopicMonthTaskListModel m_taskListModel;

		// Token: 0x0402289A RID: 141466
		[Token(Token = "0x402289A")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeTopicMonthTaskStyle m_taskStyle;

		// Token: 0x0402289B RID: 141467
		[Token(Token = "0x402289B")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_prgTween;

		// Token: 0x0402289E RID: 141470
		[Token(Token = "0x402289E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTaskRefreshAction;

		// Token: 0x0402289F RID: 141471
		[Token(Token = "0x402289F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTaskRefreshAction;

		// Token: 0x040228A0 RID: 141472
		[Token(Token = "0x40228A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040228A1 RID: 141473
		[Token(Token = "0x40228A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TweenPrgTo;

		// Token: 0x040228A2 RID: 141474
		[Token(Token = "0x40228A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoneTween;

		// Token: 0x040228A3 RID: 141475
		[Token(Token = "0x40228A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetPrg;

		// Token: 0x040228A4 RID: 141476
		[Token(Token = "0x40228A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetPrg;

		// Token: 0x040228A5 RID: 141477
		[Token(Token = "0x40228A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayRefreshAnim;

		// Token: 0x040228A6 RID: 141478
		[Token(Token = "0x40228A6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetRefreshBtnVisible;

		// Token: 0x040228A7 RID: 141479
		[Token(Token = "0x40228A7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_completeType;

		// Token: 0x040228A8 RID: 141480
		[Token(Token = "0x40228A8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_completeType;

		// Token: 0x040228A9 RID: 141481
		[Token(Token = "0x40228A9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshTask;

		// Token: 0x040228AA RID: 141482
		[Token(Token = "0x40228AA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnRefreshClick;

		// Token: 0x040228AB RID: 141483
		[Token(Token = "0x40228AB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044E6 RID: 17638
		[Token(Token = "0x20044E6")]
		public enum CompleteType
		{
			// Token: 0x040228AD RID: 141485
			[Token(Token = "0x40228AD")]
			DEFAULT,
			// Token: 0x040228AE RID: 141486
			[Token(Token = "0x40228AE")]
			FLAG
		}
	}
}
