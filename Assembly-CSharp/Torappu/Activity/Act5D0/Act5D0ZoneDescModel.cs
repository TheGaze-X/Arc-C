using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x02007201 RID: 29185
	[Token(Token = "0x2007201")]
	public struct Act5D0ZoneDescModel : IHotfixable
	{
		// Token: 0x06029634 RID: 169524 RVA: 0x000D5870 File Offset: 0x000D3A70
		[Token(Token = "0x6029634")]
		[Address(RVA = "0x24C3F20", Offset = "0x24C2B20", VA = "0x1824C3F20")]
		public static Act5D0ZoneDescModel Create(ActivityZoneViewModel targetModel, Act5D0Data.ZoneDescInfo zoneDescModel, ZoneValidInfo validInfo, long curTs)
		{
			return default(Act5D0ZoneDescModel);
		}

		// Token: 0x06029635 RID: 169525 RVA: 0x000D5888 File Offset: 0x000D3A88
		[Token(Token = "0x6029635")]
		[Address(RVA = "0x24C42C0", Offset = "0x24C2EC0", VA = "0x1824C42C0")]
		private static bool _HasNewStages(ActivityZoneViewModel targetModel)
		{
			return default(bool);
		}

		// Token: 0x06029636 RID: 169526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029636")]
		[Address(RVA = "0x24C44B0", Offset = "0x24C30B0", VA = "0x1824C44B0")]
		private static string _ParseTimeLockedInfo(long curTs, ITimeValidInfo validInfo)
		{
			return null;
		}

		// Token: 0x06029637 RID: 169527 RVA: 0x000D58A0 File Offset: 0x000D3AA0
		[Token(Token = "0x6029637")]
		[Address(RVA = "0x24C43F0", Offset = "0x24C2FF0", VA = "0x1824C43F0")]
		private static bool _IsActTimeOut(long curTs, ITimeValidInfo validInfo)
		{
			return default(bool);
		}

		// Token: 0x0403B1E5 RID: 242149
		[Token(Token = "0x403B1E5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act5D0ZoneDescModel EMPTY;

		// Token: 0x0403B1E6 RID: 242150
		[Token(Token = "0x403B1E6")]
		[FieldOffset(Offset = "0x0")]
		public string zoneId;

		// Token: 0x0403B1E7 RID: 242151
		[Token(Token = "0x403B1E7")]
		[FieldOffset(Offset = "0x8")]
		public bool isUnlocked;

		// Token: 0x0403B1E8 RID: 242152
		[Token(Token = "0x403B1E8")]
		[FieldOffset(Offset = "0x10")]
		public string lockedText;

		// Token: 0x0403B1E9 RID: 242153
		[Token(Token = "0x403B1E9")]
		[FieldOffset(Offset = "0x18")]
		public bool isTimeOut;

		// Token: 0x0403B1EA RID: 242154
		[Token(Token = "0x403B1EA")]
		[FieldOffset(Offset = "0x19")]
		public bool hasNewStages;

		// Token: 0x0403B1EB RID: 242155
		[Token(Token = "0x403B1EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0403B1EC RID: 242156
		[Token(Token = "0x403B1EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HasNewStages;

		// Token: 0x0403B1ED RID: 242157
		[Token(Token = "0x403B1ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ParseTimeLockedInfo;

		// Token: 0x0403B1EE RID: 242158
		[Token(Token = "0x403B1EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsActTimeOut;
	}
}
