using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AsyncLoader
{
	// Token: 0x020016CD RID: 5837
	[Token(Token = "0x20016CD")]
	public class AsyncTicker : IHotfixable
	{
		// Token: 0x060093EC RID: 37868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093EC")]
		[Address(RVA = "0x2B27120", Offset = "0x2B25D20", VA = "0x182B27120")]
		private AsyncTicker(AsyncTicker.Builder builder)
		{
		}

		// Token: 0x060093ED RID: 37869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093ED")]
		[Address(RVA = "0x2B270B0", Offset = "0x2B25CB0", VA = "0x182B270B0")]
		public void Tick()
		{
		}

		// Token: 0x040089BB RID: 35259
		[Token(Token = "0x40089BB")]
		[FieldOffset(Offset = "0x10")]
		private Action m_callPerTick;

		// Token: 0x040089BC RID: 35260
		[Token(Token = "0x40089BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040089BD RID: 35261
		[Token(Token = "0x40089BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x020016CE RID: 5838
		[Token(Token = "0x20016CE")]
		public struct Builder
		{
			// Token: 0x060093EE RID: 37870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60093EE")]
			[Address(RVA = "0x2B28500", Offset = "0x2B27100", VA = "0x182B28500")]
			public AsyncTicker Build()
			{
				return null;
			}

			// Token: 0x040089BE RID: 35262
			[Token(Token = "0x40089BE")]
			[FieldOffset(Offset = "0x0")]
			public Action callPerTick;
		}
	}
}
