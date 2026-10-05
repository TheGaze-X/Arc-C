using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D7 RID: 22487
	[Token(Token = "0x20057D7")]
	public interface RoguelikeInitContextUser
	{
		// Token: 0x06020E3C RID: 134716
		[Token(Token = "0x6020E3C")]
		void Invalide();

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x06020E3D RID: 134717
		[Token(Token = "0x17004D29")]
		string topicId { [Token(Token = "0x6020E3D")] get; }

		// Token: 0x06020E3E RID: 134718
		[Token(Token = "0x6020E3E")]
		bool AddTop<T>() where T : State;

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x06020E3F RID: 134719
		[Token(Token = "0x17004D2A")]
		UIPage page { [Token(Token = "0x6020E3F")] get; }
	}
}
