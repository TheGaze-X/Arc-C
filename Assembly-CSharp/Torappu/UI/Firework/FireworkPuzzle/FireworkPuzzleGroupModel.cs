using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E5A RID: 20058
	[Token(Token = "0x2004E5A")]
	public class FireworkPuzzleGroupModel : IHotfixable
	{
		// Token: 0x0601DEF8 RID: 122616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEF8")]
		[Address(RVA = "0x17A85E0", Offset = "0x17A71E0", VA = "0x1817A85E0")]
		public FireworkPuzzleGroupModel()
		{
		}

		// Token: 0x04027BD2 RID: 162770
		[Token(Token = "0x4027BD2")]
		[FieldOffset(Offset = "0x10")]
		public string puzzleGroupId;

		// Token: 0x04027BD3 RID: 162771
		[Token(Token = "0x4027BD3")]
		[FieldOffset(Offset = "0x18")]
		public bool isAllCompleted;

		// Token: 0x04027BD4 RID: 162772
		[Token(Token = "0x4027BD4")]
		[FieldOffset(Offset = "0x1C")]
		public float focusXAxis;

		// Token: 0x04027BD5 RID: 162773
		[Token(Token = "0x4027BD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
