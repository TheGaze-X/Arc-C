using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CB5 RID: 31925
	[Token(Token = "0x2007CB5")]
	public interface fiIValueProxyAPI
	{
		// Token: 0x1700685F RID: 26719
		// (get) Token: 0x0602C974 RID: 182644
		// (set) Token: 0x0602C975 RID: 182645
		[Token(Token = "0x1700685F")]
		object Value { [Token(Token = "0x602C974")] get; [Token(Token = "0x602C975")] set; }

		// Token: 0x0602C976 RID: 182646
		[Token(Token = "0x602C976")]
		void SaveState();

		// Token: 0x0602C977 RID: 182647
		[Token(Token = "0x602C977")]
		void LoadState();
	}
}
