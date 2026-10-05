using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Not supported anymore.", true)]
	public interface IMask
	{
		// Token: 0x060001A3 RID: 419
		[Token(Token = "0x60001A3")]
		bool Enabled();

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A4 RID: 420
		[Token(Token = "0x17000073")]
		RectTransform rectTransform { [Token(Token = "0x60001A4")] get; }
	}
}
