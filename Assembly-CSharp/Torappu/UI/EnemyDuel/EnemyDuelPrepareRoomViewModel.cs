using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200503D RID: 20541
	[Token(Token = "0x200503D")]
	public class EnemyDuelPrepareRoomViewModel : IHotfixable
	{
		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x0601E764 RID: 124772 RVA: 0x000AE828 File Offset: 0x000ACA28
		// (set) Token: 0x0601E765 RID: 124773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700471C")]
		public int checkingAvatarIdx
		{
			[Token(Token = "0x601E764")]
			[Address(RVA = "0x182AD50", Offset = "0x1829950", VA = "0x18182AD50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601E765")]
			[Address(RVA = "0x182AEC0", Offset = "0x1829AC0", VA = "0x18182AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x0601E766 RID: 124774 RVA: 0x000AE840 File Offset: 0x000ACA40
		[Token(Token = "0x1700471D")]
		public bool addNpcFlag
		{
			[Token(Token = "0x601E766")]
			[Address(RVA = "0x182ACE0", Offset = "0x18298E0", VA = "0x18182ACE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x0601E767 RID: 124775 RVA: 0x000AE858 File Offset: 0x000ACA58
		[Token(Token = "0x1700471E")]
		public int roomPlayerCntNeedToInvite
		{
			[Token(Token = "0x601E767")]
			[Address(RVA = "0x182AE30", Offset = "0x1829A30", VA = "0x18182AE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x0601E768 RID: 124776 RVA: 0x000AE870 File Offset: 0x000ACA70
		[Token(Token = "0x1700471F")]
		public bool isHostVision
		{
			[Token(Token = "0x601E768")]
			[Address(RVA = "0x182ADB0", Offset = "0x18299B0", VA = "0x18182ADB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E769 RID: 124777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E769")]
		[Address(RVA = "0x182A9C0", Offset = "0x18295C0", VA = "0x18182A9C0")]
		private void _AfterTeamSvrUpdate()
		{
		}

		// Token: 0x0601E76A RID: 124778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E76A")]
		[Address(RVA = "0x182A550", Offset = "0x1829150", VA = "0x18182A550")]
		public void LoadData(string actId, [Optional] EnemyDuelPrepareBannerView.Param bannerParam)
		{
		}

		// Token: 0x0601E76B RID: 124779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E76B")]
		[Address(RVA = "0x182A760", Offset = "0x1829360", VA = "0x18182A760")]
		public void OnStatusUpdate()
		{
		}

		// Token: 0x0601E76C RID: 124780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E76C")]
		[Address(RVA = "0x182A440", Offset = "0x1829040", VA = "0x18182A440")]
		public void CheckAvatar(int idx)
		{
		}

		// Token: 0x0601E76D RID: 124781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E76D")]
		[Address(RVA = "0x182A910", Offset = "0x1829510", VA = "0x18182A910")]
		public void UncheckAvatar()
		{
		}

		// Token: 0x0601E76E RID: 124782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E76E")]
		[Address(RVA = "0x182AB20", Offset = "0x1829720", VA = "0x18182AB20")]
		public EnemyDuelPrepareRoomViewModel()
		{
		}

		// Token: 0x04028C7A RID: 167034
		[Token(Token = "0x4028C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028C7B RID: 167035
		[Token(Token = "0x4028C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EnemyDuelPrepareBannerView.Param initBannerViewParam;

		// Token: 0x04028C7C RID: 167036
		[Token(Token = "0x4028C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float bannerRotateTime;

		// Token: 0x04028C7D RID: 167037
		[Token(Token = "0x4028C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int roomWaitPlayerTime;

		// Token: 0x04028C7E RID: 167038
		[Token(Token = "0x4028C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ActivityEnemyDuelConstData.PingCond> pingConds;

		// Token: 0x04028C7F RID: 167039
		[Token(Token = "0x4028C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EnemyDuelPrepareRoomStatusViewModel statusViewModel;

		// Token: 0x04028C80 RID: 167040
		[Token(Token = "0x4028C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_roomPlayerCntRequirement;

		// Token: 0x04028C81 RID: 167041
		[Token(Token = "0x4028C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_checkingAvatarUID;

		// Token: 0x04028C83 RID: 167043
		[Token(Token = "0x4028C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkingAvatarIdx;

		// Token: 0x04028C84 RID: 167044
		[Token(Token = "0x4028C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_checkingAvatarIdx;

		// Token: 0x04028C85 RID: 167045
		[Token(Token = "0x4028C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_addNpcFlag;

		// Token: 0x04028C86 RID: 167046
		[Token(Token = "0x4028C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_roomPlayerCntNeedToInvite;

		// Token: 0x04028C87 RID: 167047
		[Token(Token = "0x4028C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isHostVision;

		// Token: 0x04028C88 RID: 167048
		[Token(Token = "0x4028C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AfterTeamSvrUpdate;

		// Token: 0x04028C89 RID: 167049
		[Token(Token = "0x4028C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028C8A RID: 167050
		[Token(Token = "0x4028C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStatusUpdate;

		// Token: 0x04028C8B RID: 167051
		[Token(Token = "0x4028C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckAvatar;

		// Token: 0x04028C8C RID: 167052
		[Token(Token = "0x4028C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UncheckAvatar;

		// Token: 0x04028C8D RID: 167053
		[Token(Token = "0x4028C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
