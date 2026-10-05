using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069E7 RID: 27111
	[Token(Token = "0x20069E7")]
	public class ZoneRecordRewardTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x06026C6A RID: 158826 RVA: 0x000CC510 File Offset: 0x000CA710
		// (set) Token: 0x06026C6B RID: 158827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B82")]
		public bool isShow
		{
			[Token(Token = "0x6026C6A")]
			[Address(RVA = "0x21E4310", Offset = "0x21E2F10", VA = "0x1821E4310", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026C6B")]
			[Address(RVA = "0x21E4370", Offset = "0x21E2F70", VA = "0x1821E4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026C6C RID: 158828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C6C")]
		[Address(RVA = "0x21E3E90", Offset = "0x21E2A90", VA = "0x1821E3E90", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06026C6D RID: 158829 RVA: 0x000CC528 File Offset: 0x000CA728
		[Token(Token = "0x6026C6D")]
		[Address(RVA = "0x21E3FA0", Offset = "0x21E2BA0", VA = "0x1821E3FA0")]
		private bool _UpdateZoneRecordReward(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026C6E RID: 158830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C6E")]
		[Address(RVA = "0x21E42B0", Offset = "0x21E2EB0", VA = "0x1821E42B0")]
		public ZoneRecordRewardTrackPointViewModel()
		{
		}

		// Token: 0x04036C77 RID: 224375
		[Token(Token = "0x4036C77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04036C78 RID: 224376
		[Token(Token = "0x4036C78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04036C79 RID: 224377
		[Token(Token = "0x4036C79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04036C7A RID: 224378
		[Token(Token = "0x4036C7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateZoneRecordReward;

		// Token: 0x04036C7B RID: 224379
		[Token(Token = "0x4036C7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
