using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006233 RID: 25139
	[Token(Token = "0x2006233")]
	public class AutoChessOuterTopMenu : PageSingleComponent
	{
		// Token: 0x0602444B RID: 148555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602444B")]
		[Address(RVA = "0x1F06B70", Offset = "0x1F05770", VA = "0x181F06B70")]
		public void RenderByShowType(AutoChessOuterTopMenu.ShowType showType)
		{
		}

		// Token: 0x0602444C RID: 148556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602444C")]
		[Address(RVA = "0x1F06C40", Offset = "0x1F05840", VA = "0x181F06C40")]
		public void UpdateTopMenuInfos()
		{
		}

		// Token: 0x0602444D RID: 148557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602444D")]
		[Address(RVA = "0x1F06EA0", Offset = "0x1F05AA0", VA = "0x181F06EA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602444E RID: 148558 RVA: 0x000C3A50 File Offset: 0x000C1C50
		[Token(Token = "0x602444E")]
		[Address(RVA = "0x1F07290", Offset = "0x1F05E90", VA = "0x181F07290")]
		private bool _NeedRefreshPingInfo()
		{
			return default(bool);
		}

		// Token: 0x0602444F RID: 148559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602444F")]
		[Address(RVA = "0x1F073C0", Offset = "0x1F05FC0", VA = "0x181F073C0")]
		private void _RefreshPingInfo()
		{
		}

		// Token: 0x06024450 RID: 148560 RVA: 0x000C3A68 File Offset: 0x000C1C68
		[Token(Token = "0x6024450")]
		[Address(RVA = "0x1F07300", Offset = "0x1F05F00", VA = "0x181F07300")]
		private bool _NeedRefreshRoomCloseInfo()
		{
			return default(bool);
		}

		// Token: 0x06024451 RID: 148561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024451")]
		[Address(RVA = "0x1F075A0", Offset = "0x1F061A0", VA = "0x181F075A0")]
		private void _RefreshRoomCloseInfo()
		{
		}

		// Token: 0x06024452 RID: 148562 RVA: 0x000C3A80 File Offset: 0x000C1C80
		[Token(Token = "0x6024452")]
		[Address(RVA = "0x1F07360", Offset = "0x1F05F60", VA = "0x181F07360")]
		private bool _NeedRefreshTeamCDInfo()
		{
			return default(bool);
		}

		// Token: 0x06024453 RID: 148563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024453")]
		[Address(RVA = "0x1F07A50", Offset = "0x1F06650", VA = "0x181F07A50")]
		private void _RefreshTeamCDInfo()
		{
		}

		// Token: 0x06024454 RID: 148564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024454")]
		[Address(RVA = "0x1F07810", Offset = "0x1F06410", VA = "0x181F07810")]
		private void _RefreshTeamCDInfoStepTs(AutoChessServiceTeamInfo teamInfo)
		{
		}

		// Token: 0x06024455 RID: 148565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024455")]
		[Address(RVA = "0x1F06AE0", Offset = "0x1F056E0", VA = "0x181F06AE0")]
		public void OnExitBtnClicked()
		{
		}

		// Token: 0x06024456 RID: 148566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024456")]
		[Address(RVA = "0x1F07B80", Offset = "0x1F06780", VA = "0x181F07B80")]
		public AutoChessOuterTopMenu()
		{
		}

		// Token: 0x040326E3 RID: 206563
		[Token(Token = "0x40326E3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasInfoRoom;

		// Token: 0x040326E4 RID: 206564
		[Token(Token = "0x40326E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasInfoTeamWithPing;

		// Token: 0x040326E5 RID: 206565
		[Token(Token = "0x40326E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRoomCloseInfo;

		// Token: 0x040326E6 RID: 206566
		[Token(Token = "0x40326E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRoomPing;

		// Token: 0x040326E7 RID: 206567
		[Token(Token = "0x40326E7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTeamPing;

		// Token: 0x040326E8 RID: 206568
		[Token(Token = "0x40326E8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasInfoCountDown;

		// Token: 0x040326E9 RID: 206569
		[Token(Token = "0x40326E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _countDownViewParent;

		// Token: 0x040326EA RID: 206570
		[Token(Token = "0x40326EA")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x040326EB RID: 206571
		[Token(Token = "0x40326EB")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040326EC RID: 206572
		[Token(Token = "0x40326EC")]
		[FieldOffset(Offset = "0x70")]
		private List<PingCond> m_cachedPingConds;

		// Token: 0x040326ED RID: 206573
		[Token(Token = "0x40326ED")]
		[FieldOffset(Offset = "0x78")]
		private AutoChessOuterTopMenu.ShowType m_curShowType;

		// Token: 0x040326EE RID: 206574
		[Token(Token = "0x40326EE")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_tweenInfoRoom;

		// Token: 0x040326EF RID: 206575
		[Token(Token = "0x40326EF")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_tweenInfoTeamWithPing;

		// Token: 0x040326F0 RID: 206576
		[Token(Token = "0x40326F0")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_tweenInfoCountDown;

		// Token: 0x040326F1 RID: 206577
		[Token(Token = "0x40326F1")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessCountDownView m_countDownView;

		// Token: 0x040326F2 RID: 206578
		[Token(Token = "0x40326F2")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedRoomCloseRemainSecs;

		// Token: 0x040326F3 RID: 206579
		[Token(Token = "0x40326F3")]
		[FieldOffset(Offset = "0xA4")]
		private AutoChessTeamState m_teamState;

		// Token: 0x040326F4 RID: 206580
		[Token(Token = "0x40326F4")]
		[FieldOffset(Offset = "0xA8")]
		private long m_teamRoomEndTs;

		// Token: 0x040326F5 RID: 206581
		[Token(Token = "0x40326F5")]
		[FieldOffset(Offset = "0xB0")]
		private long m_teamStateEndTs;

		// Token: 0x040326F6 RID: 206582
		[Token(Token = "0x40326F6")]
		[FieldOffset(Offset = "0xB8")]
		private int m_teamStepTotalSec;

		// Token: 0x040326F7 RID: 206583
		[Token(Token = "0x40326F7")]
		[FieldOffset(Offset = "0xBC")]
		private int m_teamStepEmergencySec;

		// Token: 0x040326F8 RID: 206584
		[Token(Token = "0x40326F8")]
		[FieldOffset(Offset = "0xC0")]
		private string m_teamCurChoseUid;

		// Token: 0x040326F9 RID: 206585
		[Token(Token = "0x40326F9")]
		[FieldOffset(Offset = "0xC8")]
		private DateTime m_teamStateEndDateTime;

		// Token: 0x040326FA RID: 206586
		[Token(Token = "0x40326FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderByShowType;

		// Token: 0x040326FB RID: 206587
		[Token(Token = "0x40326FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateTopMenuInfos;

		// Token: 0x040326FC RID: 206588
		[Token(Token = "0x40326FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040326FD RID: 206589
		[Token(Token = "0x40326FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__NeedRefreshPingInfo;

		// Token: 0x040326FE RID: 206590
		[Token(Token = "0x40326FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshPingInfo;

		// Token: 0x040326FF RID: 206591
		[Token(Token = "0x40326FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NeedRefreshRoomCloseInfo;

		// Token: 0x04032700 RID: 206592
		[Token(Token = "0x4032700")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshRoomCloseInfo;

		// Token: 0x04032701 RID: 206593
		[Token(Token = "0x4032701")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__NeedRefreshTeamCDInfo;

		// Token: 0x04032702 RID: 206594
		[Token(Token = "0x4032702")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshTeamCDInfo;

		// Token: 0x04032703 RID: 206595
		[Token(Token = "0x4032703")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshTeamCDInfoStepTs;

		// Token: 0x04032704 RID: 206596
		[Token(Token = "0x4032704")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnExitBtnClicked;

		// Token: 0x04032705 RID: 206597
		[Token(Token = "0x4032705")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006234 RID: 25140
		[Token(Token = "0x2006234")]
		public enum ShowType
		{
			// Token: 0x04032707 RID: 206599
			[Token(Token = "0x4032707")]
			NONE,
			// Token: 0x04032708 RID: 206600
			[Token(Token = "0x4032708")]
			IN_ROOM,
			// Token: 0x04032709 RID: 206601
			[Token(Token = "0x4032709")]
			IN_TEAM,
			// Token: 0x0403270A RID: 206602
			[Token(Token = "0x403270A")]
			IN_TEAM_WITHOUT_DELAY
		}
	}
}
