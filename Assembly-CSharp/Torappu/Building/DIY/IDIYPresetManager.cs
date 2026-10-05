using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001851 RID: 6225
	[Token(Token = "0x2001851")]
	public interface IDIYPresetManager : IDIYPresetProvider
	{
		// Token: 0x06009D62 RID: 40290
		[Token(Token = "0x6009D62")]
		bool SetPreset(int index, IDIYPreset preset, string imageBase64, Action<ExaminResponse> resultHandler);

		// Token: 0x06009D63 RID: 40291
		[Token(Token = "0x6009D63")]
		void RenamePreset(int index, string newName, Action<ExaminResponse> resultHandler);
	}
}
