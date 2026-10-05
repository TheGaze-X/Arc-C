using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007189 RID: 29065
	[Token(Token = "0x2007189")]
	public class Act9D0ZoneDescViewModel : IHotfixable
	{
		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x06029410 RID: 168976 RVA: 0x000D4E38 File Offset: 0x000D3038
		[Token(Token = "0x170061A6")]
		public bool isLocked
		{
			[Token(Token = "0x6029410")]
			[Address(RVA = "0x24A6580", Offset = "0x24A5180", VA = "0x1824A6580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x06029411 RID: 168977 RVA: 0x000D4E50 File Offset: 0x000D3050
		[Token(Token = "0x170061A7")]
		public bool isAccessible
		{
			[Token(Token = "0x6029411")]
			[Address(RVA = "0x24A64D0", Offset = "0x24A50D0", VA = "0x1824A64D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029412 RID: 168978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029412")]
		[Address(RVA = "0x24A6470", Offset = "0x24A5070", VA = "0x1824A6470")]
		private Act9D0ZoneDescViewModel()
		{
		}

		// Token: 0x06029413 RID: 168979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029413")]
		[Address(RVA = "0x24A62B0", Offset = "0x24A4EB0", VA = "0x1824A62B0")]
		public static Act9D0ZoneDescViewModel Create(ActivityZoneViewModel zoneModel, Act9D0Data.ZoneDescInfo descInfo, ZoneValidInfo validInfo, long timeStampNow, long activityStartTime)
		{
			return null;
		}

		// Token: 0x0403AEBA RID: 241338
		[Token(Token = "0x403AEBA")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x0403AEBB RID: 241339
		[Token(Token = "0x403AEBB")]
		[FieldOffset(Offset = "0x18")]
		public string zoneName;

		// Token: 0x0403AEBC RID: 241340
		[Token(Token = "0x403AEBC")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0403AEBD RID: 241341
		[Token(Token = "0x403AEBD")]
		[FieldOffset(Offset = "0x28")]
		public string unlockText;

		// Token: 0x0403AEBE RID: 241342
		[Token(Token = "0x403AEBE")]
		[FieldOffset(Offset = "0x30")]
		public long startTime;

		// Token: 0x0403AEBF RID: 241343
		[Token(Token = "0x403AEBF")]
		[FieldOffset(Offset = "0x38")]
		public bool isStageLocked;

		// Token: 0x0403AEC0 RID: 241344
		[Token(Token = "0x403AEC0")]
		[FieldOffset(Offset = "0x39")]
		public bool isTimeLocked;

		// Token: 0x0403AEC1 RID: 241345
		[Token(Token = "0x403AEC1")]
		[FieldOffset(Offset = "0x3A")]
		public bool isTimeout;

		// Token: 0x0403AEC2 RID: 241346
		[Token(Token = "0x403AEC2")]
		[FieldOffset(Offset = "0x3B")]
		public bool isNew;

		// Token: 0x0403AEC3 RID: 241347
		[Token(Token = "0x403AEC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x0403AEC4 RID: 241348
		[Token(Token = "0x403AEC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAccessible;

		// Token: 0x0403AEC5 RID: 241349
		[Token(Token = "0x403AEC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403AEC6 RID: 241350
		[Token(Token = "0x403AEC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;
	}
}
