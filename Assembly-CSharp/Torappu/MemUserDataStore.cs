using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	public class MemUserDataStore : Singleton<MemUserDataStore>
	{
		// Token: 0x06005B36 RID: 23350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B36")]
		public MemUserDataStore.Data<TData> RequestData<TData>(string localCacheKey) where TData : new()
		{
			return null;
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B37")]
		[Address(RVA = "0x1AF5C60", Offset = "0x1AF4860", VA = "0x181AF5C60")]
		private MemUserDataStore()
		{
		}

		// Token: 0x040020E5 RID: 8421
		[Token(Token = "0x40020E5")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, MemUserDataStore.IMemUserData> m_memUserDataMap;

		// Token: 0x040020E6 RID: 8422
		[Token(Token = "0x40020E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RequestData;

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		public class Data<ContentType> : IHotfixable, MemUserDataStore.IMemUserData where ContentType : new()
		{
			// Token: 0x06005B38 RID: 23352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B38")]
			private Data(string localCacheKey)
			{
			}

			// Token: 0x06005B39 RID: 23353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B39")]
			public static MemUserDataStore.Data<ContentType> StoreOnly_Create(string localCacheKey)
			{
				return null;
			}

			// Token: 0x06005B3A RID: 23354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B3A")]
			public ContentType EnsureData()
			{
				return null;
			}

			// Token: 0x06005B3B RID: 23355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B3B")]
			public void SaveData(ContentType data)
			{
			}

			// Token: 0x06005B3C RID: 23356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B3C")]
			public Type GetContentType()
			{
				return null;
			}

			// Token: 0x06005B3D RID: 23357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B3D")]
			private void _ClearInvalidCache()
			{
			}

			// Token: 0x06005B3E RID: 23358 RVA: 0x0002EC68 File Offset: 0x0002CE68
			[Token(Token = "0x6005B3E")]
			private bool _UpdateSessionIfDirty()
			{
				return default(bool);
			}

			// Token: 0x040020E8 RID: 8424
			[Token(Token = "0x40020E8")]
			[FieldOffset(Offset = "0x0")]
			private string m_localCacheKey;

			// Token: 0x040020E9 RID: 8425
			[Token(Token = "0x40020E9")]
			[FieldOffset(Offset = "0x0")]
			private ContentType m_cachedData;

			// Token: 0x040020EA RID: 8426
			[Token(Token = "0x40020EA")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isCacheEmpty;

			// Token: 0x040020EB RID: 8427
			[Token(Token = "0x40020EB")]
			[FieldOffset(Offset = "0x0")]
			private uint m_loginHash;

			// Token: 0x040020EC RID: 8428
			[Token(Token = "0x40020EC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040020ED RID: 8429
			[Token(Token = "0x40020ED")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_StoreOnly_Create;

			// Token: 0x040020EE RID: 8430
			[Token(Token = "0x40020EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_EnsureData;

			// Token: 0x040020EF RID: 8431
			[Token(Token = "0x40020EF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SaveData;

			// Token: 0x040020F0 RID: 8432
			[Token(Token = "0x40020F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetContentType;

			// Token: 0x040020F1 RID: 8433
			[Token(Token = "0x40020F1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__ClearInvalidCache;

			// Token: 0x040020F2 RID: 8434
			[Token(Token = "0x40020F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__UpdateSessionIfDirty;
		}

		// Token: 0x02000562 RID: 1378
		[Token(Token = "0x2000562")]
		public interface IMemUserData
		{
			// Token: 0x06005B3F RID: 23359
			[Token(Token = "0x6005B3F")]
			Type GetContentType();
		}
	}
}
