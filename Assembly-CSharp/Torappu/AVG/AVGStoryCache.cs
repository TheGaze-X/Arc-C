using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EB5 RID: 7861
	[Token(Token = "0x2001EB5")]
	public struct AVGStoryCache : IDisposable, IHotfixable
	{
		// Token: 0x0600C29B RID: 49819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C29B")]
		[Address(RVA = "0x33FD440", Offset = "0x33FC040", VA = "0x1833FD440")]
		public void Init(bool firstRead = true, bool theaterMode = false)
		{
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600C29C RID: 49820 RVA: 0x00047658 File Offset: 0x00045858
		// (set) Token: 0x0600C29D RID: 49821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001746")]
		public bool isVideoOnly
		{
			[Token(Token = "0x600C29C")]
			[Address(RVA = "0x33FE910", Offset = "0x33FD510", VA = "0x1833FE910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C29D")]
			[Address(RVA = "0x33FF820", Offset = "0x33FE420", VA = "0x1833FF820")]
			set
			{
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x0600C29E RID: 49822 RVA: 0x00047670 File Offset: 0x00045870
		[Token(Token = "0x17001747")]
		public bool shouldProcessEndtip
		{
			[Token(Token = "0x600C29E")]
			[Address(RVA = "0x33FEA50", Offset = "0x33FD650", VA = "0x1833FEA50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x0600C29F RID: 49823 RVA: 0x00047688 File Offset: 0x00045888
		// (set) Token: 0x0600C2A0 RID: 49824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001748")]
		public AVGStoryCache.AVGAutoMode autoPlayMode
		{
			[Token(Token = "0x600C29F")]
			[Address(RVA = "0x33FE680", Offset = "0x33FD280", VA = "0x1833FE680")]
			get
			{
				return AVGStoryCache.AVGAutoMode.DEFAULT;
			}
			[Token(Token = "0x600C2A0")]
			[Address(RVA = "0x33FF6A0", Offset = "0x33FE2A0", VA = "0x1833FF6A0")]
			set
			{
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x000476A0 File Offset: 0x000458A0
		// (set) Token: 0x0600C2A2 RID: 49826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001749")]
		public bool isWaitForInput
		{
			[Token(Token = "0x600C2A1")]
			[Address(RVA = "0x33FE9B0", Offset = "0x33FD5B0", VA = "0x1833FE9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C2A2")]
			[Address(RVA = "0x33FF8D0", Offset = "0x33FE4D0", VA = "0x1833FF8D0")]
			set
			{
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x0600C2A3 RID: 49827 RVA: 0x000476B8 File Offset: 0x000458B8
		// (set) Token: 0x0600C2A4 RID: 49828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700174A")]
		public int AVGBtnAutoMode
		{
			[Token(Token = "0x600C2A3")]
			[Address(RVA = "0x33FDA80", Offset = "0x33FC680", VA = "0x1833FDA80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2A4")]
			[Address(RVA = "0x33FEB30", Offset = "0x33FD730", VA = "0x1833FEB30")]
			set
			{
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x0600C2A5 RID: 49829 RVA: 0x000476D0 File Offset: 0x000458D0
		// (set) Token: 0x0600C2A6 RID: 49830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700174B")]
		public int AVGQuickAutoMode
		{
			[Token(Token = "0x600C2A5")]
			[Address(RVA = "0x33FDF80", Offset = "0x33FCB80", VA = "0x1833FDF80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2A6")]
			[Address(RVA = "0x33FF070", Offset = "0x33FDC70", VA = "0x1833FF070")]
			set
			{
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x000476E8 File Offset: 0x000458E8
		// (set) Token: 0x0600C2A8 RID: 49832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700174C")]
		public AVGExecuteMode AVGExecuteMode
		{
			[Token(Token = "0x600C2A7")]
			[Address(RVA = "0x33FDD80", Offset = "0x33FC980", VA = "0x1833FDD80")]
			get
			{
				return AVGExecuteMode.Normal;
			}
			[Token(Token = "0x600C2A8")]
			[Address(RVA = "0x33FEEB0", Offset = "0x33FDAB0", VA = "0x1833FEEB0")]
			set
			{
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600C2A9 RID: 49833 RVA: 0x00047700 File Offset: 0x00045900
		// (set) Token: 0x0600C2AA RID: 49834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700174D")]
		public bool AVGPureMode
		{
			[Token(Token = "0x600C2A9")]
			[Address(RVA = "0x33FDE80", Offset = "0x33FCA80", VA = "0x1833FDE80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C2AA")]
			[Address(RVA = "0x33FEF90", Offset = "0x33FDB90", VA = "0x1833FEF90")]
			set
			{
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x00047718 File Offset: 0x00045918
		// (set) Token: 0x0600C2AC RID: 49836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700174E")]
		public int AVGReaderFontSize
		{
			[Token(Token = "0x600C2AB")]
			[Address(RVA = "0x33FE290", Offset = "0x33FCE90", VA = "0x1833FE290")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2AC")]
			[Address(RVA = "0x33FF400", Offset = "0x33FE000", VA = "0x1833FF400")]
			set
			{
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x0600C2AD RID: 49837 RVA: 0x00047730 File Offset: 0x00045930
		// (set) Token: 0x0600C2AE RID: 49838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700174F")]
		public int AVGReaderLineSpace
		{
			[Token(Token = "0x600C2AD")]
			[Address(RVA = "0x33FE410", Offset = "0x33FD010", VA = "0x1833FE410")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2AE")]
			[Address(RVA = "0x33FF5C0", Offset = "0x33FE1C0", VA = "0x1833FF5C0")]
			set
			{
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600C2AF RID: 49839 RVA: 0x00047748 File Offset: 0x00045948
		// (set) Token: 0x0600C2B0 RID: 49840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001750")]
		public int AVGReaderFontSizeIndex
		{
			[Token(Token = "0x600C2AF")]
			[Address(RVA = "0x33FE1D0", Offset = "0x33FCDD0", VA = "0x1833FE1D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2B0")]
			[Address(RVA = "0x33FF320", Offset = "0x33FDF20", VA = "0x1833FF320")]
			set
			{
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x0600C2B1 RID: 49841 RVA: 0x00047760 File Offset: 0x00045960
		// (set) Token: 0x0600C2B2 RID: 49842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001751")]
		public int AVGReaderLineSpaceIndex
		{
			[Token(Token = "0x600C2B1")]
			[Address(RVA = "0x33FE350", Offset = "0x33FCF50", VA = "0x1833FE350")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2B2")]
			[Address(RVA = "0x33FF4E0", Offset = "0x33FE0E0", VA = "0x1833FF4E0")]
			set
			{
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x00047778 File Offset: 0x00045978
		// (set) Token: 0x0600C2B4 RID: 49844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001752")]
		public float AVGReaderBgAlpha
		{
			[Token(Token = "0x600C2B3")]
			[Address(RVA = "0x33FE100", Offset = "0x33FCD00", VA = "0x1833FE100")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600C2B4")]
			[Address(RVA = "0x33FF230", Offset = "0x33FDE30", VA = "0x1833FF230")]
			set
			{
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x00047790 File Offset: 0x00045990
		// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001753")]
		public int AVGReaderBgAlphaIndex
		{
			[Token(Token = "0x600C2B5")]
			[Address(RVA = "0x33FE040", Offset = "0x33FCC40", VA = "0x1833FE040")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2B6")]
			[Address(RVA = "0x33FF150", Offset = "0x33FDD50", VA = "0x1833FF150")]
			set
			{
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x000477A8 File Offset: 0x000459A8
		// (set) Token: 0x0600C2B8 RID: 49848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001754")]
		public int AVGDialogFontSize
		{
			[Token(Token = "0x600C2B7")]
			[Address(RVA = "0x33FDC00", Offset = "0x33FC800", VA = "0x1833FDC00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2B8")]
			[Address(RVA = "0x33FECF0", Offset = "0x33FD8F0", VA = "0x1833FECF0")]
			set
			{
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x000477C0 File Offset: 0x000459C0
		// (set) Token: 0x0600C2BA RID: 49850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001755")]
		public int AVGDialogFontSizeIndex
		{
			[Token(Token = "0x600C2B9")]
			[Address(RVA = "0x33FDB40", Offset = "0x33FC740", VA = "0x1833FDB40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2BA")]
			[Address(RVA = "0x33FEC10", Offset = "0x33FD810", VA = "0x1833FEC10")]
			set
			{
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x000477D8 File Offset: 0x000459D8
		// (set) Token: 0x0600C2BC RID: 49852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001756")]
		public int AVGDialogPresetId
		{
			[Token(Token = "0x600C2BB")]
			[Address(RVA = "0x33FDCC0", Offset = "0x33FC8C0", VA = "0x1833FDCC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C2BC")]
			[Address(RVA = "0x33FEDD0", Offset = "0x33FD9D0", VA = "0x1833FEDD0")]
			set
			{
			}
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x000477F0 File Offset: 0x000459F0
		[Token(Token = "0x600C2BD")]
		[Address(RVA = "0x33FD2B0", Offset = "0x33FBEB0", VA = "0x1833FD2B0")]
		public SkipNodeLabel GetNextSkipNode()
		{
			return default(SkipNodeLabel);
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BE")]
		[Address(RVA = "0x33FCD80", Offset = "0x33FB980", VA = "0x1833FCD80")]
		public void AddSkipNode(List<Command> commands)
		{
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600C2BF RID: 49855 RVA: 0x00047808 File Offset: 0x00045A08
		[Token(Token = "0x17001757")]
		public int SkipNodeNum
		{
			[Token(Token = "0x600C2BF")]
			[Address(RVA = "0x33FE4D0", Offset = "0x33FD0D0", VA = "0x1833FE4D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x0600C2C0 RID: 49856 RVA: 0x00047820 File Offset: 0x00045A20
		[Token(Token = "0x17001758")]
		public bool isFirstRead
		{
			[Token(Token = "0x600C2C0")]
			[Address(RVA = "0x33FE7C0", Offset = "0x33FD3C0", VA = "0x1833FE7C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x00047838 File Offset: 0x00045A38
		[Token(Token = "0x17001759")]
		public bool isShowBrief
		{
			[Token(Token = "0x600C2C1")]
			[Address(RVA = "0x33FE860", Offset = "0x33FD460", VA = "0x1833FE860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x00047850 File Offset: 0x00045A50
		[Token(Token = "0x600C2C2")]
		[Address(RVA = "0x33FD040", Offset = "0x33FBC40", VA = "0x1833FD040")]
		private AVGSkipMode CalSkipMode(string mode)
		{
			return AVGSkipMode.CAN_SKIP;
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x0600C2C3 RID: 49859 RVA: 0x00047868 File Offset: 0x00045A68
		// (set) Token: 0x0600C2C4 RID: 49860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700175A")]
		public AVGSkipMode curSkipMode
		{
			[Token(Token = "0x600C2C3")]
			[Address(RVA = "0x33FE720", Offset = "0x33FD320", VA = "0x1833FE720")]
			[CompilerGenerated]
			readonly get
			{
				return AVGSkipMode.CAN_SKIP;
			}
			[Token(Token = "0x600C2C4")]
			[Address(RVA = "0x33FF770", Offset = "0x33FE370", VA = "0x1833FF770")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x00047880 File Offset: 0x00045A80
		[Token(Token = "0x600C2C5")]
		[Address(RVA = "0x33FD110", Offset = "0x33FBD10", VA = "0x1833FD110")]
		public bool CheckIfSkippableInCurMode()
		{
			return default(bool);
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600C2C6 RID: 49862 RVA: 0x00047898 File Offset: 0x00045A98
		[Token(Token = "0x1700175B")]
		public bool abortRemainingCommands
		{
			[Token(Token = "0x600C2C6")]
			[Address(RVA = "0x33FE5E0", Offset = "0x33FD1E0", VA = "0x1833FE5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C7")]
		[Address(RVA = "0x33FD600", Offset = "0x33FC200", VA = "0x1833FD600")]
		public void ResetHasSkipNode()
		{
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C8")]
		[Address(RVA = "0x33FD6B0", Offset = "0x33FC2B0", VA = "0x1833FD6B0")]
		public void SetClickRecord(DateTime time, int times = 0)
		{
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C9")]
		[Address(RVA = "0x33FCCE0", Offset = "0x33FB8E0", VA = "0x1833FCCE0")]
		public void AbortCurrentStory()
		{
		}

		// Token: 0x0600C2CA RID: 49866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CA")]
		[Address(RVA = "0x33FD1F0", Offset = "0x33FBDF0", VA = "0x1833FD1F0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CB")]
		[Address(RVA = "0x33FD790", Offset = "0x33FC390", VA = "0x1833FD790")]
		private void _UpdateBlockStatus()
		{
		}

		// Token: 0x0400C481 RID: 50305
		[Token(Token = "0x400C481")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AVGStoryCache RESET;

		// Token: 0x0400C482 RID: 50306
		[Token(Token = "0x400C482")]
		[FieldOffset(Offset = "0x0")]
		private Queue<SkipNodeLabel> m_skipNodeLabel;

		// Token: 0x0400C483 RID: 50307
		[Token(Token = "0x400C483")]
		[FieldOffset(Offset = "0x8")]
		private bool m_isFirstRead;

		// Token: 0x0400C484 RID: 50308
		[Token(Token = "0x400C484")]
		[FieldOffset(Offset = "0x9")]
		private bool m_hasSkipNode;

		// Token: 0x0400C485 RID: 50309
		[Token(Token = "0x400C485")]
		[FieldOffset(Offset = "0x10")]
		private ScreenUtil.UISleepBlocker m_screenBlocker;

		// Token: 0x0400C486 RID: 50310
		[Token(Token = "0x400C486")]
		[FieldOffset(Offset = "0x18")]
		public DateTime firstClickTime;

		// Token: 0x0400C487 RID: 50311
		[Token(Token = "0x400C487")]
		[FieldOffset(Offset = "0x20")]
		public DateTime lastClickTime;

		// Token: 0x0400C488 RID: 50312
		[Token(Token = "0x400C488")]
		[FieldOffset(Offset = "0x28")]
		public int clickTimes;

		// Token: 0x0400C489 RID: 50313
		[Token(Token = "0x400C489")]
		[FieldOffset(Offset = "0x2C")]
		public bool isTheaterMode;

		// Token: 0x0400C48A RID: 50314
		[Token(Token = "0x400C48A")]
		[FieldOffset(Offset = "0x30")]
		private AVGStoryCache.AVGAutoMode m_autoPlayMode;

		// Token: 0x0400C48B RID: 50315
		[Token(Token = "0x400C48B")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isWaitForInput;

		// Token: 0x0400C48C RID: 50316
		[Token(Token = "0x400C48C")]
		[FieldOffset(Offset = "0x35")]
		private bool m_abortCurretStory;

		// Token: 0x0400C48D RID: 50317
		[Token(Token = "0x400C48D")]
		[FieldOffset(Offset = "0x36")]
		private bool m_isVideoOnly;

		// Token: 0x0400C48F RID: 50319
		[Token(Token = "0x400C48F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400C490 RID: 50320
		[Token(Token = "0x400C490")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isVideoOnly;

		// Token: 0x0400C491 RID: 50321
		[Token(Token = "0x400C491")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_isVideoOnly;

		// Token: 0x0400C492 RID: 50322
		[Token(Token = "0x400C492")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_shouldProcessEndtip;

		// Token: 0x0400C493 RID: 50323
		[Token(Token = "0x400C493")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_autoPlayMode;

		// Token: 0x0400C494 RID: 50324
		[Token(Token = "0x400C494")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_autoPlayMode;

		// Token: 0x0400C495 RID: 50325
		[Token(Token = "0x400C495")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isWaitForInput;

		// Token: 0x0400C496 RID: 50326
		[Token(Token = "0x400C496")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_isWaitForInput;

		// Token: 0x0400C497 RID: 50327
		[Token(Token = "0x400C497")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_AVGBtnAutoMode;

		// Token: 0x0400C498 RID: 50328
		[Token(Token = "0x400C498")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_AVGBtnAutoMode;

		// Token: 0x0400C499 RID: 50329
		[Token(Token = "0x400C499")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_AVGQuickAutoMode;

		// Token: 0x0400C49A RID: 50330
		[Token(Token = "0x400C49A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_AVGQuickAutoMode;

		// Token: 0x0400C49B RID: 50331
		[Token(Token = "0x400C49B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_AVGExecuteMode;

		// Token: 0x0400C49C RID: 50332
		[Token(Token = "0x400C49C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_AVGExecuteMode;

		// Token: 0x0400C49D RID: 50333
		[Token(Token = "0x400C49D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_AVGPureMode;

		// Token: 0x0400C49E RID: 50334
		[Token(Token = "0x400C49E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_AVGPureMode;

		// Token: 0x0400C49F RID: 50335
		[Token(Token = "0x400C49F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_AVGReaderFontSize;

		// Token: 0x0400C4A0 RID: 50336
		[Token(Token = "0x400C4A0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_AVGReaderFontSize;

		// Token: 0x0400C4A1 RID: 50337
		[Token(Token = "0x400C4A1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_AVGReaderLineSpace;

		// Token: 0x0400C4A2 RID: 50338
		[Token(Token = "0x400C4A2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_AVGReaderLineSpace;

		// Token: 0x0400C4A3 RID: 50339
		[Token(Token = "0x400C4A3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_AVGReaderFontSizeIndex;

		// Token: 0x0400C4A4 RID: 50340
		[Token(Token = "0x400C4A4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_AVGReaderFontSizeIndex;

		// Token: 0x0400C4A5 RID: 50341
		[Token(Token = "0x400C4A5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_AVGReaderLineSpaceIndex;

		// Token: 0x0400C4A6 RID: 50342
		[Token(Token = "0x400C4A6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_AVGReaderLineSpaceIndex;

		// Token: 0x0400C4A7 RID: 50343
		[Token(Token = "0x400C4A7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_AVGReaderBgAlpha;

		// Token: 0x0400C4A8 RID: 50344
		[Token(Token = "0x400C4A8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_AVGReaderBgAlpha;

		// Token: 0x0400C4A9 RID: 50345
		[Token(Token = "0x400C4A9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_AVGReaderBgAlphaIndex;

		// Token: 0x0400C4AA RID: 50346
		[Token(Token = "0x400C4AA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_AVGReaderBgAlphaIndex;

		// Token: 0x0400C4AB RID: 50347
		[Token(Token = "0x400C4AB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_AVGDialogFontSize;

		// Token: 0x0400C4AC RID: 50348
		[Token(Token = "0x400C4AC")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_AVGDialogFontSize;

		// Token: 0x0400C4AD RID: 50349
		[Token(Token = "0x400C4AD")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_AVGDialogFontSizeIndex;

		// Token: 0x0400C4AE RID: 50350
		[Token(Token = "0x400C4AE")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_set_AVGDialogFontSizeIndex;

		// Token: 0x0400C4AF RID: 50351
		[Token(Token = "0x400C4AF")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_AVGDialogPresetId;

		// Token: 0x0400C4B0 RID: 50352
		[Token(Token = "0x400C4B0")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_set_AVGDialogPresetId;

		// Token: 0x0400C4B1 RID: 50353
		[Token(Token = "0x400C4B1")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetNextSkipNode;

		// Token: 0x0400C4B2 RID: 50354
		[Token(Token = "0x400C4B2")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_AddSkipNode;

		// Token: 0x0400C4B3 RID: 50355
		[Token(Token = "0x400C4B3")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_SkipNodeNum;

		// Token: 0x0400C4B4 RID: 50356
		[Token(Token = "0x400C4B4")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_isFirstRead;

		// Token: 0x0400C4B5 RID: 50357
		[Token(Token = "0x400C4B5")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_isShowBrief;

		// Token: 0x0400C4B6 RID: 50358
		[Token(Token = "0x400C4B6")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CalSkipMode;

		// Token: 0x0400C4B7 RID: 50359
		[Token(Token = "0x400C4B7")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_curSkipMode;

		// Token: 0x0400C4B8 RID: 50360
		[Token(Token = "0x400C4B8")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_set_curSkipMode;

		// Token: 0x0400C4B9 RID: 50361
		[Token(Token = "0x400C4B9")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_CheckIfSkippableInCurMode;

		// Token: 0x0400C4BA RID: 50362
		[Token(Token = "0x400C4BA")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_abortRemainingCommands;

		// Token: 0x0400C4BB RID: 50363
		[Token(Token = "0x400C4BB")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_ResetHasSkipNode;

		// Token: 0x0400C4BC RID: 50364
		[Token(Token = "0x400C4BC")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SetClickRecord;

		// Token: 0x0400C4BD RID: 50365
		[Token(Token = "0x400C4BD")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_AbortCurrentStory;

		// Token: 0x0400C4BE RID: 50366
		[Token(Token = "0x400C4BE")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400C4BF RID: 50367
		[Token(Token = "0x400C4BF")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__UpdateBlockStatus;

		// Token: 0x02001EB6 RID: 7862
		[Token(Token = "0x2001EB6")]
		public enum AVGAutoMode
		{
			// Token: 0x0400C4C1 RID: 50369
			[Token(Token = "0x400C4C1")]
			DEFAULT,
			// Token: 0x0400C4C2 RID: 50370
			[Token(Token = "0x400C4C2")]
			BUTTON_AUTO,
			// Token: 0x0400C4C3 RID: 50371
			[Token(Token = "0x400C4C3")]
			QUICK_PLAY
		}
	}
}
