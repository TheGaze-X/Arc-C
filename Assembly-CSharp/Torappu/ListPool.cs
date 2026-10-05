using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using XLua;

namespace Torappu
{
	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x200055C")]
	public class ListPool<T> : IHotfixable
	{
		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		[Token(Token = "0x17000C9D")]
		public int allLoadedCnt
		{
			[Token(Token = "0x6005B1F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06005B20 RID: 23328 RVA: 0x0002EC08 File Offset: 0x0002CE08
		[Token(Token = "0x17000C9E")]
		public int availableUnusedCnt
		{
			[Token(Token = "0x6005B20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B21")]
		public ListPool(ListPool<T>.Options options)
		{
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B22")]
		public ReusableList<T> Allocate()
		{
			return null;
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B23")]
		public void Recycle(ReusableList<T> list)
		{
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B24")]
		public void Reset()
		{
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B25")]
		public void ClearUsingLinksOnly()
		{
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B26")]
		private ReusableList<T> _NewList()
		{
			return null;
		}

		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x0")]
		private ListPool<T>.Options m_options;

		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x0")]
		private ObjectPool<ReusableList<T>> m_objectPool;

		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allLoadedCnt;

		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_availableUnusedCnt;

		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Allocate;

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClearUsingLinksOnly;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__NewList;

		// Token: 0x0200055D RID: 1373
		[Token(Token = "0x200055D")]
		public struct Options
		{
			// Token: 0x040020DF RID: 8415
			[Token(Token = "0x40020DF")]
			[FieldOffset(Offset = "0x0")]
			public int preloadSize;

			// Token: 0x040020E0 RID: 8416
			[Token(Token = "0x40020E0")]
			[FieldOffset(Offset = "0x0")]
			public int initListCapacity;
		}
	}
}
