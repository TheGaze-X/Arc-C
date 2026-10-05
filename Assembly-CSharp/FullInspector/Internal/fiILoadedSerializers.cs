using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CAD RID: 31917
	[Token(Token = "0x2007CAD")]
	public interface fiILoadedSerializers
	{
		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x0602C94D RID: 182605
		[Token(Token = "0x17006856")]
		Type DefaultSerializerProvider { [Token(Token = "0x602C94D")] get; }

		// Token: 0x17006857 RID: 26711
		// (get) Token: 0x0602C94E RID: 182606
		[Token(Token = "0x17006857")]
		Type[] AllLoadedSerializerProviders { [Token(Token = "0x602C94E")] get; }
	}
}
