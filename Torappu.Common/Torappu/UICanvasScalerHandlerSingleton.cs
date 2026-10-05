using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	public class UICanvasScalerHandlerSingleton : Singleton<UICanvasScalerHandlerSingleton>
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x552B650", Offset = "0x552A250", VA = "0x18552B650")]
		private UICanvasScalerHandlerSingleton()
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000065E4 File Offset: 0x000047E4
		[Token(Token = "0x17000089")]
		public float canvasScalerFactor
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x552B720", Offset = "0x552A320", VA = "0x18552B720")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000065FC File Offset: 0x000047FC
		[Token(Token = "0x1700008A")]
		public bool canvasScalerFactorActive
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x552B6C0", Offset = "0x552A2C0", VA = "0x18552B6C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x552B5C0", Offset = "0x552A1C0", VA = "0x18552B5C0")]
		public void SetCanvasScaler(bool active, float scaler)
		{
		}

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x10")]
		private float m_canvasScalerFactor;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x14")]
		private bool m_canvasScalerFactorActive;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		private const float DEFAULT_SCALE_FACTOR = 1f;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_canvasScalerFactor;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_canvasScalerFactorActive;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate127 __Hotfix0_SetCanvasScaler;
	}
}
