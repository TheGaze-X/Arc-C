using System;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A74 RID: 31348
	[Token(Token = "0x2007A74")]
	public class Act12sideStageMapDecor : ActivityStageSingleComponent
	{
		// Token: 0x0602BE8A RID: 179850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE8A")]
		[Address(RVA = "0x27C8660", Offset = "0x27C7260", VA = "0x1827C8660", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BE8B RID: 179851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE8B")]
		[Address(RVA = "0x27C8BE0", Offset = "0x27C77E0", VA = "0x1827C8BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BE8C RID: 179852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE8C")]
		[Address(RVA = "0x27C8410", Offset = "0x27C7010", VA = "0x1827C8410")]
		public void EventOnCharmBtnClicked()
		{
		}

		// Token: 0x0602BE8D RID: 179853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE8D")]
		[Address(RVA = "0x27C8480", Offset = "0x27C7080", VA = "0x1827C8480")]
		public void EventOnResearchBtnClicked()
		{
		}

		// Token: 0x0602BE8E RID: 179854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE8E")]
		[Address(RVA = "0x27C84F0", Offset = "0x27C70F0", VA = "0x1827C84F0")]
		public void EventOnZoneBtnClicked(string zoneId)
		{
		}

		// Token: 0x0602BE8F RID: 179855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE8F")]
		private void _AddTopToActStateEngine<T>() where T : State
		{
		}

		// Token: 0x0602BE90 RID: 179856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE90")]
		[Address(RVA = "0x27C8C80", Offset = "0x27C7880", VA = "0x1827C8C80")]
		public Act12sideStageMapDecor()
		{
		}

		// Token: 0x0602BE91 RID: 179857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE91")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403F958 RID: 260440
		[Token(Token = "0x403F958")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act12sideMapZoneGroupView _zoneGroupView;

		// Token: 0x0403F959 RID: 260441
		[Token(Token = "0x403F959")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x0403F95A RID: 260442
		[Token(Token = "0x403F95A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _charmRecycleTrackPoint;

		// Token: 0x0403F95B RID: 260443
		[Token(Token = "0x403F95B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _charmFirstGotTrackPoint;

		// Token: 0x0403F95C RID: 260444
		[Token(Token = "0x403F95C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnCharmLockGo;

		// Token: 0x0403F95D RID: 260445
		[Token(Token = "0x403F95D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCharmLockHint;

		// Token: 0x0403F95E RID: 260446
		[Token(Token = "0x403F95E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnCharm;

		// Token: 0x0403F95F RID: 260447
		[Token(Token = "0x403F95F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403F960 RID: 260448
		[Token(Token = "0x403F960")]
		[FieldOffset(Offset = "0x60")]
		private AudioClickPlayer m_btnCharmAudio;

		// Token: 0x0403F961 RID: 260449
		[Token(Token = "0x403F961")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F962 RID: 260450
		[Token(Token = "0x403F962")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F963 RID: 260451
		[Token(Token = "0x403F963")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCharmBtnClicked;

		// Token: 0x0403F964 RID: 260452
		[Token(Token = "0x403F964")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnResearchBtnClicked;

		// Token: 0x0403F965 RID: 260453
		[Token(Token = "0x403F965")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnZoneBtnClicked;

		// Token: 0x0403F966 RID: 260454
		[Token(Token = "0x403F966")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddTopToActStateEngine;

		// Token: 0x0403F967 RID: 260455
		[Token(Token = "0x403F967")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
