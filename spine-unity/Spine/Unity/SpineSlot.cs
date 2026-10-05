using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	public class SpineSlot : SpineAttributeBase
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x4E9ECF0", Offset = "0x4E9D8F0", VA = "0x184E9ECF0")]
		public SpineSlot(string startsWith = "", string dataField = "", bool containsBoundingBoxes = false, bool includeNone = true, bool fallbackToTextField = false)
		{
		}

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x28")]
		public bool containsBoundingBoxes;
	}
}
