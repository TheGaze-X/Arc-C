using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	public class GameFlowListener : SingletonMonoBehaviour<GameFlowListener>
	{
		// Token: 0x06004E9D RID: 20125 RVA: 0x0002E128 File Offset: 0x0002C328
		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x1886A60", Offset = "0x1885660", VA = "0x181886A60")]
		public static bool RegisterInitListener(IEnumerator listener)
		{
			return default(bool);
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x1886910", Offset = "0x1885510", VA = "0x181886910")]
		public static void RedirectScene(string sceneName, GameFlowController.Options options)
		{
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x1886880", Offset = "0x1885480", VA = "0x181886880")]
		public static void RedirectScene(string sceneName)
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000231")]
		public IEnumerator configCollectCoroutine
		{
			[Token(Token = "0x6004EA0")]
			[Address(RVA = "0x1886D40", Offset = "0x1885940", VA = "0x181886D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000232")]
		public IEnumerator initialCoroutine
		{
			[Token(Token = "0x6004EA1")]
			[Address(RVA = "0x1886DF0", Offset = "0x18859F0", VA = "0x181886DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x0002E140 File Offset: 0x0002C340
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x1886BA0", Offset = "0x18857A0", VA = "0x181886BA0")]
		private bool _RegisterInitListener(IEnumerator listener)
		{
			return default(bool);
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x0002E158 File Offset: 0x0002C358
		[Token(Token = "0x17000233")]
		public GameFlowListener.RedirectBundle redirectBundle
		{
			[Token(Token = "0x6004EA3")]
			[Address(RVA = "0x1886EA0", Offset = "0x1885AA0", VA = "0x181886EA0")]
			get
			{
				return default(GameFlowListener.RedirectBundle);
			}
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x1886C70", Offset = "0x1885870", VA = "0x181886C70")]
		public GameFlowListener()
		{
		}

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		private const int REGISTER_WAIT_CYCLES = 3;

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x18")]
		private bool m_listenersRegistered;

		// Token: 0x040012C6 RID: 4806
		[Token(Token = "0x40012C6")]
		[FieldOffset(Offset = "0x20")]
		private List<IEnumerator> m_initListeners;

		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		[FieldOffset(Offset = "0x28")]
		private GameFlowListener.RedirectBundle m_redirectBundle;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterInitListener;

		// Token: 0x040012C9 RID: 4809
		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RedirectScene;

		// Token: 0x040012CA RID: 4810
		[Token(Token = "0x40012CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_RedirectScene;

		// Token: 0x040012CB RID: 4811
		[Token(Token = "0x40012CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_configCollectCoroutine;

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_initialCoroutine;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterInitListener;

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_redirectBundle;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020004F7 RID: 1271
		[Token(Token = "0x20004F7")]
		public struct RedirectBundle
		{
			// Token: 0x06004EA5 RID: 20133 RVA: 0x0002E170 File Offset: 0x0002C370
			[Token(Token = "0x6004EA5")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040012D0 RID: 4816
			[Token(Token = "0x40012D0")]
			[FieldOffset(Offset = "0x0")]
			public string sceneName;

			// Token: 0x040012D1 RID: 4817
			[Token(Token = "0x40012D1")]
			[FieldOffset(Offset = "0x8")]
			public GameFlowController.Options options;
		}
	}
}
