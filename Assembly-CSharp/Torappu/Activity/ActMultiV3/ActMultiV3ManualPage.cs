using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F46 RID: 28486
	[Token(Token = "0x2006F46")]
	public class ActMultiV3ManualPage : StateEnginePage
	{
		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x06028748 RID: 165704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F6C")]
		public string activityId
		{
			[Token(Token = "0x6028748")]
			[Address(RVA = "0x23C0B10", Offset = "0x23BF710", VA = "0x1823C0B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x06028749 RID: 165705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F6D")]
		public Dictionary<string, string> friendStatus
		{
			[Token(Token = "0x6028749")]
			[Address(RVA = "0x23C0B70", Offset = "0x23BF770", VA = "0x1823C0B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x0602874A RID: 165706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F6E")]
		public Dictionary<string, long> searchTimeStamps
		{
			[Token(Token = "0x602874A")]
			[Address(RVA = "0x23C0BD0", Offset = "0x23BF7D0", VA = "0x1823C0BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602874B RID: 165707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602874B")]
		[Address(RVA = "0x23C07C0", Offset = "0x23BF3C0", VA = "0x1823C07C0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602874C RID: 165708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602874C")]
		[Address(RVA = "0x23C0870", Offset = "0x23BF470", VA = "0x1823C0870")]
		public void UpdateFriendStatus(string uid, FriendStatus friendStatus)
		{
		}

		// Token: 0x0602874D RID: 165709 RVA: 0x000D1D60 File Offset: 0x000CFF60
		[Token(Token = "0x602874D")]
		[Address(RVA = "0x23C06E0", Offset = "0x23BF2E0", VA = "0x1823C06E0")]
		public FriendStatus GetFriendStatus(string uid)
		{
			return FriendStatus.NORMAL;
		}

		// Token: 0x0602874E RID: 165710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602874E")]
		[Address(RVA = "0x23C0940", Offset = "0x23BF540", VA = "0x1823C0940")]
		public void UpdateTimeStamp(string templateId, long timeStamp)
		{
		}

		// Token: 0x0602874F RID: 165711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602874F")]
		[Address(RVA = "0x23C0A00", Offset = "0x23BF600", VA = "0x1823C0A00")]
		public ActMultiV3ManualPage()
		{
		}

		// Token: 0x06028750 RID: 165712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028750")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x040398B7 RID: 235703
		[Token(Token = "0x40398B7")]
		[FieldOffset(Offset = "0xF0")]
		private string m_actId;

		// Token: 0x040398B8 RID: 235704
		[Token(Token = "0x40398B8")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<string, string> m_cachedFriendStatus;

		// Token: 0x040398B9 RID: 235705
		[Token(Token = "0x40398B9")]
		[FieldOffset(Offset = "0x100")]
		private Dictionary<string, long> m_searchTimeStamps;

		// Token: 0x040398BA RID: 235706
		[Token(Token = "0x40398BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x040398BB RID: 235707
		[Token(Token = "0x40398BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_friendStatus;

		// Token: 0x040398BC RID: 235708
		[Token(Token = "0x40398BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_searchTimeStamps;

		// Token: 0x040398BD RID: 235709
		[Token(Token = "0x40398BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040398BE RID: 235710
		[Token(Token = "0x40398BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateFriendStatus;

		// Token: 0x040398BF RID: 235711
		[Token(Token = "0x40398BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFriendStatus;

		// Token: 0x040398C0 RID: 235712
		[Token(Token = "0x40398C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateTimeStamp;

		// Token: 0x040398C1 RID: 235713
		[Token(Token = "0x40398C1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F47 RID: 28487
		[Token(Token = "0x2006F47")]
		public class Params
		{
			// Token: 0x06028751 RID: 165713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028751")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x040398C2 RID: 235714
			[Token(Token = "0x40398C2")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
