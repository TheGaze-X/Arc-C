using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C63 RID: 27747
	[Token(Token = "0x2006C63")]
	public class WrathTypeModel : IHotfixable
	{
		// Token: 0x060279A8 RID: 162216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A8")]
		[Address(RVA = "0x22D3CF0", Offset = "0x22D28F0", VA = "0x1822D3CF0")]
		public void ConsumeNewMark()
		{
		}

		// Token: 0x060279A9 RID: 162217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A9")]
		[Address(RVA = "0x22D3DE0", Offset = "0x22D29E0", VA = "0x1822D3DE0")]
		public WrathTypeModel()
		{
		}

		// Token: 0x040382BA RID: 230074
		[Token(Token = "0x40382BA")]
		[FieldOffset(Offset = "0x10")]
		public List<WrathLevelModel> wrathLevels;

		// Token: 0x040382BB RID: 230075
		[Token(Token = "0x40382BB")]
		[FieldOffset(Offset = "0x18")]
		public int topUnlockLevel;

		// Token: 0x040382BC RID: 230076
		[Token(Token = "0x40382BC")]
		[FieldOffset(Offset = "0x20")]
		public string typeId;

		// Token: 0x040382BD RID: 230077
		[Token(Token = "0x40382BD")]
		[FieldOffset(Offset = "0x28")]
		public string archiveId;

		// Token: 0x040382BE RID: 230078
		[Token(Token = "0x40382BE")]
		[FieldOffset(Offset = "0x30")]
		public string titleId;

		// Token: 0x040382BF RID: 230079
		[Token(Token = "0x40382BF")]
		[FieldOffset(Offset = "0x38")]
		public string smallActiveIconId;

		// Token: 0x040382C0 RID: 230080
		[Token(Token = "0x40382C0")]
		[FieldOffset(Offset = "0x40")]
		public string smallInactiveIconId;

		// Token: 0x040382C1 RID: 230081
		[Token(Token = "0x40382C1")]
		[FieldOffset(Offset = "0x48")]
		public string bigActiveIconId;

		// Token: 0x040382C2 RID: 230082
		[Token(Token = "0x40382C2")]
		[FieldOffset(Offset = "0x50")]
		public string bigInactiveIconId;

		// Token: 0x040382C3 RID: 230083
		[Token(Token = "0x40382C3")]
		[FieldOffset(Offset = "0x58")]
		public string desc;

		// Token: 0x040382C4 RID: 230084
		[Token(Token = "0x40382C4")]
		[FieldOffset(Offset = "0x60")]
		public int sortId;

		// Token: 0x040382C5 RID: 230085
		[Token(Token = "0x40382C5")]
		[FieldOffset(Offset = "0x64")]
		public bool isAttained;

		// Token: 0x040382C6 RID: 230086
		[Token(Token = "0x40382C6")]
		[FieldOffset(Offset = "0x65")]
		public bool hasNewMark;

		// Token: 0x040382C7 RID: 230087
		[Token(Token = "0x40382C7")]
		[FieldOffset(Offset = "0x66")]
		public bool isSelected;

		// Token: 0x040382C8 RID: 230088
		[Token(Token = "0x40382C8")]
		[FieldOffset(Offset = "0x67")]
		public bool isSp;

		// Token: 0x040382C9 RID: 230089
		[Token(Token = "0x40382C9")]
		[FieldOffset(Offset = "0x68")]
		public bool isPositive;

		// Token: 0x040382CA RID: 230090
		[Token(Token = "0x40382CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConsumeNewMark;

		// Token: 0x040382CB RID: 230091
		[Token(Token = "0x40382CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
