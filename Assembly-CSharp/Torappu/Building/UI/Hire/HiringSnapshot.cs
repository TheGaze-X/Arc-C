using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Hire
{
	// Token: 0x02001DBB RID: 7611
	[Token(Token = "0x2001DBB")]
	public struct HiringSnapshot : IHotfixable
	{
		// Token: 0x0600BBA9 RID: 48041 RVA: 0x00045FC0 File Offset: 0x000441C0
		[Token(Token = "0x600BBA9")]
		[Address(RVA = "0x33966E0", Offset = "0x33952E0", VA = "0x1833966E0")]
		public float GetRemainSecs()
		{
			return 0f;
		}

		// Token: 0x0600BBAA RID: 48042 RVA: 0x00045FD8 File Offset: 0x000441D8
		[Token(Token = "0x600BBAA")]
		[Address(RVA = "0x3396630", Offset = "0x3395230", VA = "0x183396630")]
		public float GetRemainProgress()
		{
			return 0f;
		}

		// Token: 0x0600BBAB RID: 48043 RVA: 0x00045FF0 File Offset: 0x000441F0
		[Token(Token = "0x600BBAB")]
		[Address(RVA = "0x33962F0", Offset = "0x3394EF0", VA = "0x1833962F0")]
		public float GetProcessedProgress()
		{
			return 0f;
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x00046008 File Offset: 0x00044208
		[Token(Token = "0x600BBAC")]
		[Address(RVA = "0x3396520", Offset = "0x3395120", VA = "0x183396520")]
		public float GetRefreshCountProgress()
		{
			return 0f;
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x00046020 File Offset: 0x00044220
		[Token(Token = "0x600BBAD")]
		[Address(RVA = "0x3396000", Offset = "0x3394C00", VA = "0x183396000")]
		public static HiringSnapshot CreateSnapshot(string slotId, PlayerBuildingHire hireModel)
		{
			return default(HiringSnapshot);
		}

		// Token: 0x0400BB82 RID: 48002
		[Token(Token = "0x400BB82")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HiringSnapshot EMPTY;

		// Token: 0x0400BB83 RID: 48003
		[Token(Token = "0x400BB83")]
		[FieldOffset(Offset = "0x0")]
		public bool isHiring;

		// Token: 0x0400BB84 RID: 48004
		[Token(Token = "0x400BB84")]
		[FieldOffset(Offset = "0x4")]
		public float speed;

		// Token: 0x0400BB85 RID: 48005
		[Token(Token = "0x400BB85")]
		[FieldOffset(Offset = "0x8")]
		public DateTime lastUpdateTime;

		// Token: 0x0400BB86 RID: 48006
		[Token(Token = "0x400BB86")]
		[FieldOffset(Offset = "0x10")]
		public long totalRequirePoint;

		// Token: 0x0400BB87 RID: 48007
		[Token(Token = "0x400BB87")]
		[FieldOffset(Offset = "0x18")]
		public double processPoint;

		// Token: 0x0400BB88 RID: 48008
		[Token(Token = "0x400BB88")]
		[FieldOffset(Offset = "0x20")]
		public int refreshCount;

		// Token: 0x0400BB89 RID: 48009
		[Token(Token = "0x400BB89")]
		[FieldOffset(Offset = "0x24")]
		public int refreshCountLimit;

		// Token: 0x0400BB8A RID: 48010
		[Token(Token = "0x400BB8A")]
		[FieldOffset(Offset = "0x28")]
		public bool isBuffed;

		// Token: 0x0400BB8B RID: 48011
		[Token(Token = "0x400BB8B")]
		[FieldOffset(Offset = "0x29")]
		public bool isEmpty;

		// Token: 0x0400BB8C RID: 48012
		[Token(Token = "0x400BB8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetRemainSecs;

		// Token: 0x0400BB8D RID: 48013
		[Token(Token = "0x400BB8D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRemainProgress;

		// Token: 0x0400BB8E RID: 48014
		[Token(Token = "0x400BB8E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProcessedProgress;

		// Token: 0x0400BB8F RID: 48015
		[Token(Token = "0x400BB8F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetRefreshCountProgress;

		// Token: 0x0400BB90 RID: 48016
		[Token(Token = "0x400BB90")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateSnapshot;
	}
}
