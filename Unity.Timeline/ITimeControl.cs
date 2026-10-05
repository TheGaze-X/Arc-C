using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public interface ITimeControl
	{
		// Token: 0x060002D8 RID: 728
		[Token(Token = "0x60002D8")]
		void SetTime(double time);

		// Token: 0x060002D9 RID: 729
		[Token(Token = "0x60002D9")]
		void OnControlTimeStart();

		// Token: 0x060002DA RID: 730
		[Token(Token = "0x60002DA")]
		void OnControlTimeStop();
	}
}
