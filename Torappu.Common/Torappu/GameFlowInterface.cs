using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public static class GameFlowInterface
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x54E2FE0", Offset = "0x54E1BE0", VA = "0x1854E2FE0")]
		public static void GameFlowController_Init()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		public static string currentScene
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x54E35E0", Offset = "0x54E21E0", VA = "0x1854E35E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000100 RID: 256 RVA: 0x000020FA File Offset: 0x000002FA
		// (remove) Token: 0x06000101 RID: 257 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x14000001")]
		public static event Action<string, string> beforeSceneTransition
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x54E34D0", Offset = "0x54E20D0", VA = "0x1854E34D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x54E3640", Offset = "0x54E2240", VA = "0x1854E3640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x54E30E0", Offset = "0x54E1CE0", VA = "0x1854E30E0")]
		public static void InvokeBeforeSceneTransition(string from, string to)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x54E3290", Offset = "0x54E1E90", VA = "0x1854E3290")]
		public static GameInOutObserver ObserveInOutGame(GameInOutObserver.Callback callback)
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x54E31F0", Offset = "0x54E1DF0", VA = "0x1854E31F0")]
		public static bool IsInMainGameScene(string scene)
		{
			return default(bool);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1AFCB00", Offset = "0x1AFB700", VA = "0x181AFCB00")]
		public static void QuitGame()
		{
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x8")]
		private static readonly GameInOutObserver.Manager m_gameInOutMgr;
	}
}
