using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200781F RID: 30751
	[Token(Token = "0x200781F")]
	public class Act1VHalfIdleZoneStageButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170064EA RID: 25834
		// (get) Token: 0x0602B22B RID: 176683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B22A RID: 176682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064EA")]
		public Action onClick
		{
			[Token(Token = "0x602B22B")]
			[Address(RVA = "0x27037B0", Offset = "0x27023B0", VA = "0x1827037B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B22A")]
			[Address(RVA = "0x2703810", Offset = "0x2702410", VA = "0x182703810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B22C RID: 176684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B22C")]
		[Address(RVA = "0x27035C0", Offset = "0x27021C0", VA = "0x1827035C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B22D RID: 176685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B22D")]
		[Address(RVA = "0x27031D0", Offset = "0x2701DD0", VA = "0x1827031D0")]
		public void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode)
		{
		}

		// Token: 0x0602B22E RID: 176686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B22E")]
		[Address(RVA = "0x2703690", Offset = "0x2702290", VA = "0x182703690")]
		private void _UpdateTrack(bool isUnlocked, string actId, string stageId)
		{
		}

		// Token: 0x0602B22F RID: 176687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B22F")]
		[Address(RVA = "0x2702FD0", Offset = "0x2701BD0", VA = "0x182702FD0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602B230 RID: 176688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B230")]
		[Address(RVA = "0x2703110", Offset = "0x2701D10", VA = "0x182703110")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602B231 RID: 176689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B231")]
		[Address(RVA = "0x2703750", Offset = "0x2702350", VA = "0x182703750")]
		public Act1VHalfIdleZoneStageButtonView()
		{
		}

		// Token: 0x0403E58D RID: 255373
		[Token(Token = "0x403E58D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _stageTexts;

		// Token: 0x0403E58E RID: 255374
		[Token(Token = "0x403E58E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _selecAnim;

		// Token: 0x0403E58F RID: 255375
		[Token(Token = "0x403E58F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403E590 RID: 255376
		[Token(Token = "0x403E590")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _bossAppearObj;

		// Token: 0x0403E591 RID: 255377
		[Token(Token = "0x403E591")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _bossKillObj;

		// Token: 0x0403E592 RID: 255378
		[Token(Token = "0x403E592")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _maxRateObj;

		// Token: 0x0403E593 RID: 255379
		[Token(Token = "0x403E593")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _trackPointObj;

		// Token: 0x0403E594 RID: 255380
		[Token(Token = "0x403E594")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _lockText;

		// Token: 0x0403E595 RID: 255381
		[Token(Token = "0x403E595")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnStage;

		// Token: 0x0403E596 RID: 255382
		[Token(Token = "0x403E596")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403E597 RID: 255383
		[Token(Token = "0x403E597")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x0403E598 RID: 255384
		[Token(Token = "0x403E598")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isUnlocked;

		// Token: 0x0403E599 RID: 255385
		[Token(Token = "0x403E599")]
		[FieldOffset(Offset = "0x80")]
		private string m_lockToast;

		// Token: 0x0403E59A RID: 255386
		[Token(Token = "0x403E59A")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedActId;

		// Token: 0x0403E59C RID: 255388
		[Token(Token = "0x403E59C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403E59D RID: 255389
		[Token(Token = "0x403E59D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0403E59E RID: 255390
		[Token(Token = "0x403E59E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E59F RID: 255391
		[Token(Token = "0x403E59F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E5A0 RID: 255392
		[Token(Token = "0x403E5A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateTrack;

		// Token: 0x0403E5A1 RID: 255393
		[Token(Token = "0x403E5A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403E5A2 RID: 255394
		[Token(Token = "0x403E5A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403E5A3 RID: 255395
		[Token(Token = "0x403E5A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
