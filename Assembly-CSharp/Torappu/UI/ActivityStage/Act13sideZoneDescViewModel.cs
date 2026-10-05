using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C73 RID: 27763
	[Token(Token = "0x2006C73")]
	public class Act13sideZoneDescViewModel : IHotfixable
	{
		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x06027A02 RID: 162306 RVA: 0x000CEE50 File Offset: 0x000CD050
		[Token(Token = "0x17005DA3")]
		public bool isLocked
		{
			[Token(Token = "0x6027A02")]
			[Address(RVA = "0x22BE090", Offset = "0x22BCC90", VA = "0x1822BE090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x06027A03 RID: 162307 RVA: 0x000CEE68 File Offset: 0x000CD068
		[Token(Token = "0x17005DA4")]
		public bool isAccessible
		{
			[Token(Token = "0x6027A03")]
			[Address(RVA = "0x22BDFE0", Offset = "0x22BCBE0", VA = "0x1822BDFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x06027A04 RID: 162308 RVA: 0x000CEE80 File Offset: 0x000CD080
		[Token(Token = "0x17005DA5")]
		public bool hasNewSign
		{
			[Token(Token = "0x6027A04")]
			[Address(RVA = "0x22BDF70", Offset = "0x22BCB70", VA = "0x1822BDF70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027A05 RID: 162309 RVA: 0x000CEE98 File Offset: 0x000CD098
		[Token(Token = "0x6027A05")]
		[Address(RVA = "0x22BDD30", Offset = "0x22BC930", VA = "0x1822BDD30")]
		public bool IsFogUnlockable()
		{
			return default(bool);
		}

		// Token: 0x06027A06 RID: 162310 RVA: 0x000CEEB0 File Offset: 0x000CD0B0
		[Token(Token = "0x6027A06")]
		[Address(RVA = "0x22BDE50", Offset = "0x22BCA50", VA = "0x1822BDE50")]
		private bool _StageFogUnlockItemEnough(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x06027A07 RID: 162311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A07")]
		[Address(RVA = "0x22BDF10", Offset = "0x22BCB10", VA = "0x1822BDF10")]
		private Act13sideZoneDescViewModel()
		{
		}

		// Token: 0x06027A08 RID: 162312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A08")]
		[Address(RVA = "0x22BD8C0", Offset = "0x22BC4C0", VA = "0x1822BD8C0")]
		public static Act13sideZoneDescViewModel Create(string activityId, ActivityZoneViewModel zoneModel, Act13SideData.ZoneAdditionData descInfo, ZoneValidInfo validInfo, long timeStampNow, long activityStartTime)
		{
			return null;
		}

		// Token: 0x04038329 RID: 230185
		[Token(Token = "0x4038329")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x0403832A RID: 230186
		[Token(Token = "0x403832A")]
		[FieldOffset(Offset = "0x18")]
		public Act13SideData.ActZoneClass zoneClass;

		// Token: 0x0403832B RID: 230187
		[Token(Token = "0x403832B")]
		[FieldOffset(Offset = "0x20")]
		public string unlockText;

		// Token: 0x0403832C RID: 230188
		[Token(Token = "0x403832C")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x0403832D RID: 230189
		[Token(Token = "0x403832D")]
		[FieldOffset(Offset = "0x30")]
		public bool isStageLocked;

		// Token: 0x0403832E RID: 230190
		[Token(Token = "0x403832E")]
		[FieldOffset(Offset = "0x31")]
		public bool isTimeLocked;

		// Token: 0x0403832F RID: 230191
		[Token(Token = "0x403832F")]
		[FieldOffset(Offset = "0x32")]
		public bool isTimeOut;

		// Token: 0x04038330 RID: 230192
		[Token(Token = "0x4038330")]
		[FieldOffset(Offset = "0x38")]
		public ListDict<string, StageViewModel> stages;

		// Token: 0x04038331 RID: 230193
		[Token(Token = "0x4038331")]
		[FieldOffset(Offset = "0x40")]
		public bool isNew;

		// Token: 0x04038332 RID: 230194
		[Token(Token = "0x4038332")]
		[FieldOffset(Offset = "0x41")]
		public bool hasNewStage;

		// Token: 0x04038333 RID: 230195
		[Token(Token = "0x4038333")]
		[FieldOffset(Offset = "0x48")]
		public List<StageFogInfo> stageFogList;

		// Token: 0x04038334 RID: 230196
		[Token(Token = "0x4038334")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04038335 RID: 230197
		[Token(Token = "0x4038335")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAccessible;

		// Token: 0x04038336 RID: 230198
		[Token(Token = "0x4038336")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasNewSign;

		// Token: 0x04038337 RID: 230199
		[Token(Token = "0x4038337")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsFogUnlockable;

		// Token: 0x04038338 RID: 230200
		[Token(Token = "0x4038338")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StageFogUnlockItemEnough;

		// Token: 0x04038339 RID: 230201
		[Token(Token = "0x4038339")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403833A RID: 230202
		[Token(Token = "0x403833A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Create;
	}
}
