using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public interface IUpdatable
	{
		// Token: 0x060002E7 RID: 743
		[Token(Token = "0x60002E7")]
		void Update();

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002E8 RID: 744
		[Token(Token = "0x170000EA")]
		bool Active { [Token(Token = "0x60002E8")] get; }
	}
}
