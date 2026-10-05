using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F1E RID: 7966
	[Token(Token = "0x2001F1E")]
	public class AVGReaderModeAutoPlayController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x0600C5E8 RID: 50664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001785")]
		public AutoSpeed[] speedConfigurations
		{
			[Token(Token = "0x600C5E8")]
			[Address(RVA = "0x3465E30", Offset = "0x3464A30", VA = "0x183465E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x00048618 File Offset: 0x00046818
		[Token(Token = "0x17001786")]
		public AutoSpeed defaultSpeed
		{
			[Token(Token = "0x600C5E9")]
			[Address(RVA = "0x3465DB0", Offset = "0x34649B0", VA = "0x183465DB0")]
			get
			{
				return default(AutoSpeed);
			}
		}

		// Token: 0x0600C5EA RID: 50666 RVA: 0x00048630 File Offset: 0x00046830
		[Token(Token = "0x600C5EA")]
		[Address(RVA = "0x3464D20", Offset = "0x3463920", VA = "0x183464D20")]
		public AutoSpeed GetCurrentSpeedConfig()
		{
			return default(AutoSpeed);
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x0600C5EB RID: 50667 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600C5EC RID: 50668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000066")]
		public event Action OnAutoModeChanged
		{
			[Token(Token = "0x600C5EB")]
			[Address(RVA = "0x34659D0", Offset = "0x34645D0", VA = "0x1834659D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600C5EC")]
			[Address(RVA = "0x3465FD0", Offset = "0x3464BD0", VA = "0x183465FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x0600C5ED RID: 50669 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600C5EE RID: 50670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000067")]
		public event Action OnSpeedChanged
		{
			[Token(Token = "0x600C5ED")]
			[Address(RVA = "0x3465AB0", Offset = "0x34646B0", VA = "0x183465AB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600C5EE")]
			[Address(RVA = "0x34660B0", Offset = "0x3464CB0", VA = "0x1834660B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x0600C5EF RID: 50671 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600C5F0 RID: 50672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000068")]
		public event Action OnAutoClickTriggered
		{
			[Token(Token = "0x600C5EF")]
			[Address(RVA = "0x34658F0", Offset = "0x34644F0", VA = "0x1834658F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600C5F0")]
			[Address(RVA = "0x3465EF0", Offset = "0x3464AF0", VA = "0x183465EF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x0600C5F1 RID: 50673 RVA: 0x00048648 File Offset: 0x00046848
		// (set) Token: 0x0600C5F2 RID: 50674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001787")]
		public AVGReaderModeAutoPlayCache.AutoMode autoMode
		{
			[Token(Token = "0x600C5F1")]
			[Address(RVA = "0x3465B90", Offset = "0x3464790", VA = "0x183465B90")]
			get
			{
				return AVGReaderModeAutoPlayCache.AutoMode.DEFAULT;
			}
			[Token(Token = "0x600C5F2")]
			[Address(RVA = "0x3466190", Offset = "0x3464D90", VA = "0x183466190")]
			set
			{
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00048660 File Offset: 0x00046860
		// (set) Token: 0x0600C5F4 RID: 50676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001788")]
		public int speedLevel
		{
			[Token(Token = "0x600C5F3")]
			[Address(RVA = "0x3465E90", Offset = "0x3464A90", VA = "0x183465E90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C5F4")]
			[Address(RVA = "0x3466240", Offset = "0x3464E40", VA = "0x183466240")]
			set
			{
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x00048678 File Offset: 0x00046878
		[Token(Token = "0x17001789")]
		public float autoWaitBaseTime
		{
			[Token(Token = "0x600C5F5")]
			[Address(RVA = "0x3465BF0", Offset = "0x34647F0", VA = "0x183465BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x0600C5F6 RID: 50678 RVA: 0x00048690 File Offset: 0x00046890
		[Token(Token = "0x1700178A")]
		public float autoWaitTimePerText
		{
			[Token(Token = "0x600C5F6")]
			[Address(RVA = "0x3465CD0", Offset = "0x34648D0", VA = "0x183465CD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F7")]
		[Address(RVA = "0x3465000", Offset = "0x3463C00", VA = "0x183465000")]
		public void RaiseAutoClick(int messageLength)
		{
		}

		// Token: 0x0600C5F8 RID: 50680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F8")]
		[Address(RVA = "0x3465180", Offset = "0x3463D80", VA = "0x183465180")]
		public void RaiseAutoClick(float delay)
		{
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5F9")]
		[Address(RVA = "0x3464C50", Offset = "0x3463850", VA = "0x183464C50")]
		private IEnumerator DoAutoClick(float delay)
		{
			return null;
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FA")]
		[Address(RVA = "0x3465570", Offset = "0x3464170", VA = "0x183465570")]
		public void StopAutoClick()
		{
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FB")]
		[Address(RVA = "0x3464F20", Offset = "0x3463B20", VA = "0x183464F20")]
		public void PauseAuto()
		{
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FC")]
		[Address(RVA = "0x3465380", Offset = "0x3463F80", VA = "0x183465380")]
		public void ResumeAuto()
		{
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FD")]
		[Address(RVA = "0x3465600", Offset = "0x3464200", VA = "0x183465600")]
		public void StopAutoMode()
		{
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x000486A8 File Offset: 0x000468A8
		[Token(Token = "0x600C5FE")]
		[Address(RVA = "0x34654A0", Offset = "0x34640A0", VA = "0x1834654A0")]
		public bool ShouldAutoPlay()
		{
			return default(bool);
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FF")]
		[Address(RVA = "0x3465420", Offset = "0x3464020", VA = "0x183465420")]
		public void SetWaitForInput(bool wait)
		{
		}

		// Token: 0x0600C600 RID: 50688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C600")]
		[Address(RVA = "0x34656F0", Offset = "0x34642F0", VA = "0x1834656F0")]
		private void _UpdateBlockStatus()
		{
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C601")]
		[Address(RVA = "0x3464E20", Offset = "0x3463A20", VA = "0x183464E20")]
		public void Init()
		{
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C602")]
		[Address(RVA = "0x3465300", Offset = "0x3463F00", VA = "0x183465300")]
		public void Reset()
		{
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C603")]
		[Address(RVA = "0x3464E90", Offset = "0x3463A90", VA = "0x183464E90")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C604 RID: 50692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C604")]
		[Address(RVA = "0x3465820", Offset = "0x3464420", VA = "0x183465820")]
		public AVGReaderModeAutoPlayController()
		{
		}

		// Token: 0x0400CAD7 RID: 51927
		[Token(Token = "0x400CAD7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("AutoSpeed")]
		private AutoSpeed _defaultSpeed;

		// Token: 0x0400CAD8 RID: 51928
		[Token(Token = "0x400CAD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("AutoSpeed")]
		private AutoSpeed[] _readerAutoSpeed;

		// Token: 0x0400CAD9 RID: 51929
		[Token(Token = "0x400CAD9")]
		[FieldOffset(Offset = "0x38")]
		private AVGReaderModeAutoPlayCache m_cache;

		// Token: 0x0400CADA RID: 51930
		[Token(Token = "0x400CADA")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_autoClickCoroutine;

		// Token: 0x0400CADB RID: 51931
		[Token(Token = "0x400CADB")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isWaitForInput;

		// Token: 0x0400CADC RID: 51932
		[Token(Token = "0x400CADC")]
		[FieldOffset(Offset = "0x50")]
		private ScreenUtil.UISleepBlocker m_screenBlocker;

		// Token: 0x0400CADD RID: 51933
		[Token(Token = "0x400CADD")]
		[FieldOffset(Offset = "0x58")]
		private bool m_needResumeAuto;

		// Token: 0x0400CADE RID: 51934
		[Token(Token = "0x400CADE")]
		[FieldOffset(Offset = "0x5C")]
		private AVGReaderModeAutoPlayCache.AutoMode autoPlayModeCache;

		// Token: 0x0400CAE2 RID: 51938
		[Token(Token = "0x400CAE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_speedConfigurations;

		// Token: 0x0400CAE3 RID: 51939
		[Token(Token = "0x400CAE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_defaultSpeed;

		// Token: 0x0400CAE4 RID: 51940
		[Token(Token = "0x400CAE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCurrentSpeedConfig;

		// Token: 0x0400CAE5 RID: 51941
		[Token(Token = "0x400CAE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_add_OnAutoModeChanged;

		// Token: 0x0400CAE6 RID: 51942
		[Token(Token = "0x400CAE6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_remove_OnAutoModeChanged;

		// Token: 0x0400CAE7 RID: 51943
		[Token(Token = "0x400CAE7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_add_OnSpeedChanged;

		// Token: 0x0400CAE8 RID: 51944
		[Token(Token = "0x400CAE8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_remove_OnSpeedChanged;

		// Token: 0x0400CAE9 RID: 51945
		[Token(Token = "0x400CAE9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_add_OnAutoClickTriggered;

		// Token: 0x0400CAEA RID: 51946
		[Token(Token = "0x400CAEA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_remove_OnAutoClickTriggered;

		// Token: 0x0400CAEB RID: 51947
		[Token(Token = "0x400CAEB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_autoMode;

		// Token: 0x0400CAEC RID: 51948
		[Token(Token = "0x400CAEC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_autoMode;

		// Token: 0x0400CAED RID: 51949
		[Token(Token = "0x400CAED")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_speedLevel;

		// Token: 0x0400CAEE RID: 51950
		[Token(Token = "0x400CAEE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_speedLevel;

		// Token: 0x0400CAEF RID: 51951
		[Token(Token = "0x400CAEF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_autoWaitBaseTime;

		// Token: 0x0400CAF0 RID: 51952
		[Token(Token = "0x400CAF0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_autoWaitTimePerText;

		// Token: 0x0400CAF1 RID: 51953
		[Token(Token = "0x400CAF1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RaiseAutoClick;

		// Token: 0x0400CAF2 RID: 51954
		[Token(Token = "0x400CAF2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_RaiseAutoClick;

		// Token: 0x0400CAF3 RID: 51955
		[Token(Token = "0x400CAF3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoAutoClick;

		// Token: 0x0400CAF4 RID: 51956
		[Token(Token = "0x400CAF4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_StopAutoClick;

		// Token: 0x0400CAF5 RID: 51957
		[Token(Token = "0x400CAF5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PauseAuto;

		// Token: 0x0400CAF6 RID: 51958
		[Token(Token = "0x400CAF6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ResumeAuto;

		// Token: 0x0400CAF7 RID: 51959
		[Token(Token = "0x400CAF7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_StopAutoMode;

		// Token: 0x0400CAF8 RID: 51960
		[Token(Token = "0x400CAF8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShouldAutoPlay;

		// Token: 0x0400CAF9 RID: 51961
		[Token(Token = "0x400CAF9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetWaitForInput;

		// Token: 0x0400CAFA RID: 51962
		[Token(Token = "0x400CAFA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateBlockStatus;

		// Token: 0x0400CAFB RID: 51963
		[Token(Token = "0x400CAFB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400CAFC RID: 51964
		[Token(Token = "0x400CAFC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400CAFD RID: 51965
		[Token(Token = "0x400CAFD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CAFE RID: 51966
		[Token(Token = "0x400CAFE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
