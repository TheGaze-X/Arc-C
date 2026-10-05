using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class GameInOutObserver : IDisposable
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700000C")]
		public bool isInGame
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2824A30", Offset = "0x2823630", VA = "0x182824A30")]
		public bool IsDisposed()
		{
			return default(bool);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x54E3750", Offset = "0x54E2350", VA = "0x1854E3750", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		private GameInOutObserver(GameInOutObserver.Manager mgr)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x54E37D0", Offset = "0x54E23D0", VA = "0x1854E37D0")]
		private void _SetIsInGame(bool pIsInGame)
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		private GameInOutObserver.Manager m_mgr;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		private GameInOutObserver.Callback m_callback;

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		public class Manager
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x54E4FF0", Offset = "0x54E3BF0", VA = "0x1854E4FF0")]
			public GameInOutObserver CreateObserver(GameInOutObserver.Callback callback)
			{
				return null;
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x54E5120", Offset = "0x54E3D20", VA = "0x1854E5120")]
			public void ReleaseObserver(GameInOutObserver observer)
			{
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x54E50B0", Offset = "0x54E3CB0", VA = "0x1854E50B0")]
			public void Init(string scene)
			{
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x54E4F80", Offset = "0x54E3B80", VA = "0x1854E4F80")]
			public void BeforeGameSceneTransition(string from, string to)
			{
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x54E5180", Offset = "0x54E3D80", VA = "0x1854E5180")]
			private void _NotifyInOutGame()
			{
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x54E5370", Offset = "0x54E3F70", VA = "0x1854E5370")]
			public Manager()
			{
			}

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x10")]
			private readonly HashSet<GameInOutObserver> m_observers;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x18")]
			private readonly List<GameInOutObserver> m_buffer;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x20")]
			private bool m_isInGame;
		}

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000FB RID: 251
		[Token(Token = "0x2000020")]
		public delegate void Callback(bool isInGame);
	}
}
