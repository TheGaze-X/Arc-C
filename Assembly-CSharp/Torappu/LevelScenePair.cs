using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	[Serializable]
	public class LevelScenePair
	{
		// Token: 0x06004CE4 RID: 19684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LevelScenePair()
		{
		}

		// Token: 0x040010DB RID: 4315
		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x10")]
		public string levelId;

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x18")]
		public string sceneId;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x20")]
		public string hookedMapPreviewId;
	}
}
