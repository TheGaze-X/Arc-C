using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200480D RID: 18445
	[Token(Token = "0x200480D")]
	public class MonopolyMissionMaterialViewModel : IHotfixable
	{
		// Token: 0x0601BE41 RID: 114241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE41")]
		[Address(RVA = "0x1545FD0", Offset = "0x1544BD0", VA = "0x181545FD0")]
		public MonopolyMissionMaterialViewModel()
		{
		}

		// Token: 0x04024590 RID: 148880
		[Token(Token = "0x4024590")]
		[FieldOffset(Offset = "0x10")]
		public string resourceId;

		// Token: 0x04024591 RID: 148881
		[Token(Token = "0x4024591")]
		[FieldOffset(Offset = "0x18")]
		public int currResourceCount;

		// Token: 0x04024592 RID: 148882
		[Token(Token = "0x4024592")]
		[FieldOffset(Offset = "0x1C")]
		public int targetResourceCount;

		// Token: 0x04024593 RID: 148883
		[Token(Token = "0x4024593")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
