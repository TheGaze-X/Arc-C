using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002083 RID: 8323
	[Token(Token = "0x2002083")]
	public class DeepSeaNodeCondTriggerHolder : PlayerTrackTriggerHolder<DeepSeaNodeCondTrigger>
	{
		// Token: 0x0600CD3C RID: 52540 RVA: 0x00049F80 File Offset: 0x00048180
		[Token(Token = "0x600CD3C")]
		[Address(RVA = "0x34FD2B0", Offset = "0x34FBEB0", VA = "0x1834FD2B0", Slot = "10")]
		protected override bool CheckIfToTrigger(DeepSeaNodeCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD3D")]
		[Address(RVA = "0x34FD370", Offset = "0x34FBF70", VA = "0x1834FD370", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x00049F98 File Offset: 0x00048198
		[Token(Token = "0x600CD3E")]
		[Address(RVA = "0x34FD460", Offset = "0x34FC060", VA = "0x1834FD460")]
		private bool _CheckIfLogStatusSatisfied(string nodeId, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD3F")]
		[Address(RVA = "0x34FD530", Offset = "0x34FC130", VA = "0x1834FD530")]
		public DeepSeaNodeCondTriggerHolder()
		{
		}

		// Token: 0x0400D886 RID: 55430
		[Token(Token = "0x400D886")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D887 RID: 55431
		[Token(Token = "0x400D887")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D888 RID: 55432
		[Token(Token = "0x400D888")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfLogStatusSatisfied;

		// Token: 0x0400D889 RID: 55433
		[Token(Token = "0x400D889")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
