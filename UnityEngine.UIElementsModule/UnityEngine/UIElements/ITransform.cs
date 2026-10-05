using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public interface ITransform
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000142 RID: 322
		// (set) Token: 0x06000143 RID: 323
		[Token(Token = "0x1700003C")]
		Vector3 position { [Token(Token = "0x6000142")] get; [Token(Token = "0x6000143")] set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000144 RID: 324
		[Token(Token = "0x1700003D")]
		Vector3 scale { [Token(Token = "0x6000144")] get; }
	}
}
