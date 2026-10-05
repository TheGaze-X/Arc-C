using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA1 RID: 31393
	[Token(Token = "0x2007AA1")]
	public class Act12sideZoneDescViewModel : IHotfixable
	{
		// Token: 0x17006713 RID: 26387
		// (get) Token: 0x0602BFA4 RID: 180132 RVA: 0x000DDCE8 File Offset: 0x000DBEE8
		[Token(Token = "0x17006713")]
		public bool isLocked
		{
			[Token(Token = "0x602BFA4")]
			[Address(RVA = "0x27E3C50", Offset = "0x27E2850", VA = "0x1827E3C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006714 RID: 26388
		// (get) Token: 0x0602BFA5 RID: 180133 RVA: 0x000DDD00 File Offset: 0x000DBF00
		[Token(Token = "0x17006714")]
		public bool isAccessible
		{
			[Token(Token = "0x602BFA5")]
			[Address(RVA = "0x27E3BA0", Offset = "0x27E27A0", VA = "0x1827E3BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006715 RID: 26389
		// (get) Token: 0x0602BFA6 RID: 180134 RVA: 0x000DDD18 File Offset: 0x000DBF18
		[Token(Token = "0x17006715")]
		public bool hasNewSign
		{
			[Token(Token = "0x602BFA6")]
			[Address(RVA = "0x27E3B30", Offset = "0x27E2730", VA = "0x1827E3B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BFA7 RID: 180135 RVA: 0x000DDD30 File Offset: 0x000DBF30
		[Token(Token = "0x602BFA7")]
		[Address(RVA = "0x27E38F0", Offset = "0x27E24F0", VA = "0x1827E38F0")]
		public bool IsFogUnlockable()
		{
			return default(bool);
		}

		// Token: 0x0602BFA8 RID: 180136 RVA: 0x000DDD48 File Offset: 0x000DBF48
		[Token(Token = "0x602BFA8")]
		[Address(RVA = "0x27E3A10", Offset = "0x27E2610", VA = "0x1827E3A10")]
		private bool _StageFogUnlockItemEnough(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0602BFA9 RID: 180137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFA9")]
		[Address(RVA = "0x27E3AD0", Offset = "0x27E26D0", VA = "0x1827E3AD0")]
		private Act12sideZoneDescViewModel()
		{
		}

		// Token: 0x0602BFAA RID: 180138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BFAA")]
		[Address(RVA = "0x27E34B0", Offset = "0x27E20B0", VA = "0x1827E34B0")]
		public static Act12sideZoneDescViewModel Create(string activityId, ActivityZoneViewModel zoneModel, Act12SideData.ZoneAdditionData descInfo, ZoneValidInfo validInfo, long timeStampNow, long activityStartTime)
		{
			return null;
		}

		// Token: 0x0403FB31 RID: 260913
		[Token(Token = "0x403FB31")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x0403FB32 RID: 260914
		[Token(Token = "0x403FB32")]
		[FieldOffset(Offset = "0x18")]
		public Act12SideData.ActZoneClass zoneClass;

		// Token: 0x0403FB33 RID: 260915
		[Token(Token = "0x403FB33")]
		[FieldOffset(Offset = "0x20")]
		public string zoneName;

		// Token: 0x0403FB34 RID: 260916
		[Token(Token = "0x403FB34")]
		[FieldOffset(Offset = "0x28")]
		public string unlockText;

		// Token: 0x0403FB35 RID: 260917
		[Token(Token = "0x403FB35")]
		[FieldOffset(Offset = "0x30")]
		public long startTime;

		// Token: 0x0403FB36 RID: 260918
		[Token(Token = "0x403FB36")]
		[FieldOffset(Offset = "0x38")]
		public bool isStageLocked;

		// Token: 0x0403FB37 RID: 260919
		[Token(Token = "0x403FB37")]
		[FieldOffset(Offset = "0x39")]
		public bool isTimeLocked;

		// Token: 0x0403FB38 RID: 260920
		[Token(Token = "0x403FB38")]
		[FieldOffset(Offset = "0x3A")]
		public bool isTimeOut;

		// Token: 0x0403FB39 RID: 260921
		[Token(Token = "0x403FB39")]
		[FieldOffset(Offset = "0x40")]
		public ListDict<string, StageViewModel> stages;

		// Token: 0x0403FB3A RID: 260922
		[Token(Token = "0x403FB3A")]
		[FieldOffset(Offset = "0x48")]
		public bool isNew;

		// Token: 0x0403FB3B RID: 260923
		[Token(Token = "0x403FB3B")]
		[FieldOffset(Offset = "0x49")]
		public bool hasNewStage;

		// Token: 0x0403FB3C RID: 260924
		[Token(Token = "0x403FB3C")]
		[FieldOffset(Offset = "0x50")]
		public List<StageFogInfo> stageFogList;

		// Token: 0x0403FB3D RID: 260925
		[Token(Token = "0x403FB3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x0403FB3E RID: 260926
		[Token(Token = "0x403FB3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAccessible;

		// Token: 0x0403FB3F RID: 260927
		[Token(Token = "0x403FB3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasNewSign;

		// Token: 0x0403FB40 RID: 260928
		[Token(Token = "0x403FB40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsFogUnlockable;

		// Token: 0x0403FB41 RID: 260929
		[Token(Token = "0x403FB41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StageFogUnlockItemEnough;

		// Token: 0x0403FB42 RID: 260930
		[Token(Token = "0x403FB42")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403FB43 RID: 260931
		[Token(Token = "0x403FB43")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Create;
	}
}
