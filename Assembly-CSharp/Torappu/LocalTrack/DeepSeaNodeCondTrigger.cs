using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002082 RID: 8322
	[Token(Token = "0x2002082")]
	public class DeepSeaNodeCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD3A RID: 52538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD3A")]
		[Address(RVA = "0x34FD5A0", Offset = "0x34FC1A0", VA = "0x1834FD5A0", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD3B RID: 52539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD3B")]
		[Address(RVA = "0x34FD600", Offset = "0x34FC200", VA = "0x1834FD600")]
		public DeepSeaNodeCondTrigger()
		{
		}

		// Token: 0x0400D883 RID: 55427
		[Token(Token = "0x400D883")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x0400D884 RID: 55428
		[Token(Token = "0x400D884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D885 RID: 55429
		[Token(Token = "0x400D885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
