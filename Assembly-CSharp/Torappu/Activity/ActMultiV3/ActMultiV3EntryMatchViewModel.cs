using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F2E RID: 28462
	[Token(Token = "0x2006F2E")]
	public class ActMultiV3EntryMatchViewModel : IHotfixable
	{
		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x060286DE RID: 165598 RVA: 0x000D1C70 File Offset: 0x000CFE70
		[Token(Token = "0x17005F60")]
		public bool hasTrackpoint
		{
			[Token(Token = "0x60286DE")]
			[Address(RVA = "0x23AC640", Offset = "0x23AB240", VA = "0x1823AC640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060286DF RID: 165599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286DF")]
		[Address(RVA = "0x23AC120", Offset = "0x23AAD20", VA = "0x1823AC120")]
		public void LoadData(string actId, PlayerActivity.PlayerMultiV3Activity playerActivity, ActMultiV3Data actData)
		{
		}

		// Token: 0x060286E0 RID: 165600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286E0")]
		[Address(RVA = "0x23AC590", Offset = "0x23AB190", VA = "0x1823AC590")]
		public ActMultiV3EntryMatchViewModel()
		{
		}

		// Token: 0x04039805 RID: 235525
		[Token(Token = "0x4039805")]
		[FieldOffset(Offset = "0x10")]
		public bool hasMentorUnlockTrackpoint;

		// Token: 0x04039806 RID: 235526
		[Token(Token = "0x4039806")]
		[FieldOffset(Offset = "0x11")]
		public bool hasInverseUnlockTrackpoint;

		// Token: 0x04039807 RID: 235527
		[Token(Token = "0x4039807")]
		[FieldOffset(Offset = "0x12")]
		public bool hasModeUnlockTrackpoint;

		// Token: 0x04039808 RID: 235528
		[Token(Token = "0x4039808")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> modeStarCount;

		// Token: 0x04039809 RID: 235529
		[Token(Token = "0x4039809")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasTrackpoint;

		// Token: 0x0403980A RID: 235530
		[Token(Token = "0x403980A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403980B RID: 235531
		[Token(Token = "0x403980B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
