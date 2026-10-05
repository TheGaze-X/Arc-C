using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class YoStarSDKEvent
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private YoStarSDKEvent()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public static YoStarSDKEvent Instance
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x5BFF980", Offset = "0x5BFE580", VA = "0x185BFF980")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000267 RID: 615 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000268 RID: 616 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000001")]
		public event InitDelegate InitEvent
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x5BFF020", Offset = "0x5BFDC20", VA = "0x185BFF020")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x5BFFC00", Offset = "0x5BFE800", VA = "0x185BFFC00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000269 RID: 617 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600026A RID: 618 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000002")]
		public event LoginDelegate LoginEvent
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x5BFF160", Offset = "0x5BFDD60", VA = "0x185BFF160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x5BFFD40", Offset = "0x5BFE940", VA = "0x185BFFD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600026B RID: 619 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600026C RID: 620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000003")]
		public event LogoutDelegate LogoutEvent
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5BFF200", Offset = "0x5BFDE00", VA = "0x185BFF200")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5BFFDE0", Offset = "0x5BFE9E0", VA = "0x185BFFDE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600026D RID: 621 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600026E RID: 622 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000004")]
		public event PayDelegate PayEvent
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x5BFF2A0", Offset = "0x5BFDEA0", VA = "0x185BFF2A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x5BFFE80", Offset = "0x5BFEA80", VA = "0x185BFFE80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600026F RID: 623 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000270 RID: 624 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000005")]
		public event SystemShareDelegate SystemShareEvent
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x5BFF660", Offset = "0x5BFE260", VA = "0x185BFF660")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x5C00240", Offset = "0x5BFEE40", VA = "0x185C00240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000271 RID: 625 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000272 RID: 626 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000006")]
		public event DeleteAccountDelegate DeleteAccountEvent
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x5BFEEE0", Offset = "0x5BFDAE0", VA = "0x185BFEEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x5BFFAC0", Offset = "0x5BFE6C0", VA = "0x185BFFAC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000273 RID: 627 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000274 RID: 628 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000007")]
		public event ClearSdkCacheDelegate ClearSDKCacheEvent
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x5BFEE40", Offset = "0x5BFDA40", VA = "0x185BFEE40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x5BFFA20", Offset = "0x5BFE620", VA = "0x185BFFA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000275 RID: 629 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000276 RID: 630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000008")]
		public event QuerySkuDetailsDelegate QuerySkuDetailsEvent
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x5BFF3E0", Offset = "0x5BFDFE0", VA = "0x185BFF3E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x5BFFFC0", Offset = "0x5BFEBC0", VA = "0x185BFFFC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000277 RID: 631 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000278 RID: 632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000009")]
		public event UserSurveyDelegate UserSurveyEvent
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5BFF8E0", Offset = "0x5BFE4E0", VA = "0x185BFF8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5C004C0", Offset = "0x5BFF0C0", VA = "0x185C004C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000279 RID: 633 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600027A RID: 634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1400000A")]
		public event SwitchServerDelegate SwitchServerEvent
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x5BFF5C0", Offset = "0x5BFE1C0", VA = "0x185BFF5C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x5C001A0", Offset = "0x5BFEDA0", VA = "0x185C001A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600027B RID: 635 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600027C RID: 636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1400000B")]
		public event QueryTextLegalityDelegate QueryTextLegalityEvent
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x5BFF480", Offset = "0x5BFE080", VA = "0x185BFF480")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x5C00060", Offset = "0x5BFEC60", VA = "0x185C00060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600027D RID: 637 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600027E RID: 638 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1400000C")]
		public event PushMsgReceiveDelegate PushMsgReceiveEvent
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x5BFF340", Offset = "0x5BFDF40", VA = "0x185BFF340")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x5BFFF20", Offset = "0x5BFEB20", VA = "0x185BFFF20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600027F RID: 639 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000280 RID: 640 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1400000D")]
		public event UniversalLinkDelegate UniversalLinkEvent
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x5BFF840", Offset = "0x5BFE440", VA = "0x185BFF840")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x5C00420", Offset = "0x5BFF020", VA = "0x185C00420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000281 RID: 641 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000282 RID: 642 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1400000E")]
		public event DeviceTrackingIDDelegate DeviceTrackingIDEvent
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x5BFEF80", Offset = "0x5BFDB80", VA = "0x185BFEF80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x5BFFB60", Offset = "0x5BFE760", VA = "0x185BFFB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000283 RID: 643 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000284 RID: 644 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1400000F")]
		public event BuildLocalNotificationDelegate LocalNotificationEvent
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x5BFF0C0", Offset = "0x5BFDCC0", VA = "0x185BFF0C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x5BFFCA0", Offset = "0x5BFE8A0", VA = "0x185BFFCA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000285 RID: 645 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000286 RID: 646 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000010")]
		public event SetBirthdayDelegate SetBirthdayEvent
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x5BFF520", Offset = "0x5BFE120", VA = "0x185BFF520")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x5C00100", Offset = "0x5BFED00", VA = "0x185C00100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000287 RID: 647 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000288 RID: 648 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000011")]
		public event UIAppearDelegate UIAppearEvent
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x5BFF700", Offset = "0x5BFE300", VA = "0x185BFF700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x5C002E0", Offset = "0x5BFEEE0", VA = "0x185C002E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000289 RID: 649 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600028A RID: 650 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000012")]
		public event UICloseDelegate UICloseEvent
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x5BFF7A0", Offset = "0x5BFE3A0", VA = "0x185BFF7A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x5C00380", Offset = "0x5BFEF80", VA = "0x185C00380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5BFE020", Offset = "0x5BFCC20", VA = "0x185BFE020")]
		public void HandleInitNotify(InitRet ret)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x5BFE160", Offset = "0x5BFCD60", VA = "0x185BFE160")]
		public void HandleLoginNotify(LoginRet ret)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x5BFE260", Offset = "0x5BFCE60", VA = "0x185BFE260")]
		public void HandleLogoutNotify(LogoutRet ret)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x5BFE560", Offset = "0x5BFD160", VA = "0x185BFE560")]
		public void HandleQuerySkuDetailsNotify(SkuDetailRet ret)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x5BFE360", Offset = "0x5BFCF60", VA = "0x185BFE360")]
		public void HandlePayNotify(PayRet ret)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x5BFE960", Offset = "0x5BFD560", VA = "0x185BFE960")]
		public void HandleSystemShareNotify(SystemShareRet ret)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x5BFDD20", Offset = "0x5BFC920", VA = "0x185BFDD20")]
		public void HandleClearSDKCacheNotify(ClearRet ret)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5BFDE20", Offset = "0x5BFCA20", VA = "0x185BFDE20")]
		public void HandleDeleteAccountNotify(DeleteAccountRet ret)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5BFED40", Offset = "0x5BFD940", VA = "0x185BFED40")]
		public void HandleUserSurveyNotify(SurveyRet ret)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5BFE860", Offset = "0x5BFD460", VA = "0x185BFE860")]
		public void HandleSwitchAreaServeryNotify(SwitchServerRet ret)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5BFE660", Offset = "0x5BFD260", VA = "0x185BFE660")]
		public void HandleQueryTextLegalityNotify(QueryTextLegalityRet ret)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5BFEC40", Offset = "0x5BFD840", VA = "0x185BFEC40")]
		public void HandleUniversalLinkNotify(UniversalLinkRet ret)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5BFDF20", Offset = "0x5BFCB20", VA = "0x185BFDF20")]
		public void HandleDeviceTrackingIDNotify(DeviceTrackingIDRet ret)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x5BFE460", Offset = "0x5BFD060", VA = "0x185BFE460")]
		public void HandlePushMsgReceiveNotify(PushMsgReceiveRet ret)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x5BFDC20", Offset = "0x5BFC820", VA = "0x185BFDC20")]
		public void HandleBuildLocalNotificationNotify(LocNotificationRet ret)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x5BFE760", Offset = "0x5BFD360", VA = "0x185BFE760")]
		public void HandleSetBirthNotify(SetBirthdayRet ret)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x5BFEA60", Offset = "0x5BFD660", VA = "0x185BFEA60")]
		public void HandleUIAppearNotify()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x5BFEB50", Offset = "0x5BFD750", VA = "0x185BFEB50")]
		public void HandleUICloseNotify()
		{
		}

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x0")]
		private static YoStarSDKEvent instance;
	}
}
