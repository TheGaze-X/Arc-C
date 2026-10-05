using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	public class SceneManagerAPI
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A2")]
		internal static SceneManagerAPI ActiveAPI
		{
			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x596AF40", Offset = "0x5969B40", VA = "0x18596AF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A3")]
		public static SceneManagerAPI overrideAPI
		{
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x596AFF0", Offset = "0x5969BF0", VA = "0x18596AFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected internal SceneManagerAPI()
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x596ADF0", Offset = "0x59699F0", VA = "0x18596ADF0", Slot = "4")]
		protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x596AE50", Offset = "0x5969A50", VA = "0x18596AE50", Slot = "5")]
		protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			return null;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			return null;
		}

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x0")]
		private static SceneManagerAPI s_DefaultAPI;
	}
}
