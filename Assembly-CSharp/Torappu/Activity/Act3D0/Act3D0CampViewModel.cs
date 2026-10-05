using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200742C RID: 29740
	[Token(Token = "0x200742C")]
	public class Act3D0CampViewModel
	{
		// Token: 0x06029F9A RID: 171930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F9A")]
		[Address(RVA = "0x2586010", Offset = "0x2584C10", VA = "0x182586010")]
		public void LoadData(Act3D0Data.CampBasicInfo gameData)
		{
		}

		// Token: 0x06029F9B RID: 171931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F9B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0CampViewModel()
		{
		}

		// Token: 0x0403C2E8 RID: 246504
		[Token(Token = "0x403C2E8")]
		[FieldOffset(Offset = "0x10")]
		public string campId;

		// Token: 0x0403C2E9 RID: 246505
		[Token(Token = "0x403C2E9")]
		[FieldOffset(Offset = "0x18")]
		public string campName;

		// Token: 0x0403C2EA RID: 246506
		[Token(Token = "0x403C2EA")]
		[FieldOffset(Offset = "0x20")]
		public string campDesc;

		// Token: 0x0403C2EB RID: 246507
		[Token(Token = "0x403C2EB")]
		[FieldOffset(Offset = "0x28")]
		public string rewardDesc;
	}
}
