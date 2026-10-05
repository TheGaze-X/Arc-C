using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C39 RID: 3129
	[Token(Token = "0x2000C39")]
	[Serializable]
	public class ActArchiveLandmarkItemData
	{
		// Token: 0x06006919 RID: 26905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006919")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveLandmarkItemData()
		{
		}

		// Token: 0x04003FF6 RID: 16374
		[Token(Token = "0x4003FF6")]
		[FieldOffset(Offset = "0x10")]
		public string landmarkId;

		// Token: 0x04003FF7 RID: 16375
		[Token(Token = "0x4003FF7")]
		[FieldOffset(Offset = "0x18")]
		public int landmarkSortId;
	}
}
