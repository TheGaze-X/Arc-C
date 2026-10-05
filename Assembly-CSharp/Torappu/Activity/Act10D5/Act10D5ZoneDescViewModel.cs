using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B39 RID: 31545
	[Token(Token = "0x2007B39")]
	public class Act10D5ZoneDescViewModel : IHotfixable
	{
		// Token: 0x17006772 RID: 26482
		// (get) Token: 0x0602C294 RID: 180884 RVA: 0x000DE498 File Offset: 0x000DC698
		[Token(Token = "0x17006772")]
		public bool isLocked
		{
			[Token(Token = "0x602C294")]
			[Address(RVA = "0x280F420", Offset = "0x280E020", VA = "0x18280F420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006773 RID: 26483
		// (get) Token: 0x0602C295 RID: 180885 RVA: 0x000DE4B0 File Offset: 0x000DC6B0
		[Token(Token = "0x17006773")]
		public bool isAccessible
		{
			[Token(Token = "0x602C295")]
			[Address(RVA = "0x280F370", Offset = "0x280DF70", VA = "0x18280F370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C296 RID: 180886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C296")]
		[Address(RVA = "0x280F310", Offset = "0x280DF10", VA = "0x18280F310")]
		private Act10D5ZoneDescViewModel()
		{
		}

		// Token: 0x0602C297 RID: 180887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C297")]
		[Address(RVA = "0x280F0F0", Offset = "0x280DCF0", VA = "0x18280F0F0")]
		public static Act10D5ZoneDescViewModel Create(ActivityZoneViewModel zoneModel, ActivityMiniStoryData.ZoneDescInfo descInfo, ZoneValidInfo validInfo, long timeStampNow, long activityStartTime)
		{
			return null;
		}

		// Token: 0x0404004D RID: 262221
		[Token(Token = "0x404004D")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x0404004E RID: 262222
		[Token(Token = "0x404004E")]
		[FieldOffset(Offset = "0x18")]
		public string zoneName;

		// Token: 0x0404004F RID: 262223
		[Token(Token = "0x404004F")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04040050 RID: 262224
		[Token(Token = "0x4040050")]
		[FieldOffset(Offset = "0x28")]
		public string unlockText;

		// Token: 0x04040051 RID: 262225
		[Token(Token = "0x4040051")]
		[FieldOffset(Offset = "0x30")]
		public long startTime;

		// Token: 0x04040052 RID: 262226
		[Token(Token = "0x4040052")]
		[FieldOffset(Offset = "0x38")]
		public bool isStageLocked;

		// Token: 0x04040053 RID: 262227
		[Token(Token = "0x4040053")]
		[FieldOffset(Offset = "0x39")]
		public bool isTimeLocked;

		// Token: 0x04040054 RID: 262228
		[Token(Token = "0x4040054")]
		[FieldOffset(Offset = "0x3A")]
		public bool isTimeout;

		// Token: 0x04040055 RID: 262229
		[Token(Token = "0x4040055")]
		[FieldOffset(Offset = "0x3B")]
		public bool isNew;

		// Token: 0x04040056 RID: 262230
		[Token(Token = "0x4040056")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04040057 RID: 262231
		[Token(Token = "0x4040057")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAccessible;

		// Token: 0x04040058 RID: 262232
		[Token(Token = "0x4040058")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04040059 RID: 262233
		[Token(Token = "0x4040059")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;
	}
}
