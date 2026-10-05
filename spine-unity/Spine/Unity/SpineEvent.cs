using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public class SpineEvent : SpineAttributeBase
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x4E9EB80", Offset = "0x4E9D780", VA = "0x184E9EB80")]
		public SpineEvent(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false, bool audioOnly = false)
		{
		}

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x28")]
		public bool audioOnly;
	}
}
