using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200742B RID: 29739
	[Token(Token = "0x200742B")]
	public class Act3D0CampGroupViewModel
	{
		// Token: 0x06029F98 RID: 171928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F98")]
		[Address(RVA = "0x2583BE0", Offset = "0x25827E0", VA = "0x182583BE0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029F99 RID: 171929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F99")]
		[Address(RVA = "0x2583E20", Offset = "0x2582A20", VA = "0x182583E20")]
		public Act3D0CampGroupViewModel()
		{
		}

		// Token: 0x0403C2E6 RID: 246502
		[Token(Token = "0x403C2E6")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403C2E7 RID: 246503
		[Token(Token = "0x403C2E7")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act3D0CampViewModel> camps;
	}
}
