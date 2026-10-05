using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BD5 RID: 31701
	[Token(Token = "0x2007BD5")]
	public interface IInspectedMemberFilter
	{
		// Token: 0x0602C5E5 RID: 181733
		[Token(Token = "0x602C5E5")]
		bool IsInterested(InspectedProperty property);

		// Token: 0x0602C5E6 RID: 181734
		[Token(Token = "0x602C5E6")]
		bool IsInterested(InspectedMethod method);
	}
}
