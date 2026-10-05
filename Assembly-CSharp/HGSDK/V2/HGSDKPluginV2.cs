using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using U8.SDK;

namespace HGSDK.V2
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public abstract class HGSDKPluginV2 : IExternalPlugin
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1029B50", Offset = "0x1028750", VA = "0x181029B50")]
		protected HGSDKPluginV2(HGSDKV2 sdk)
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
		protected HGSDKV2 GetSDK()
		{
			return null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1029AF0", Offset = "0x10286F0", VA = "0x181029AF0", Slot = "10")]
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void Init()
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public void OnProductListChanged(List<U8ProductInfo> productList)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1029A30", Offset = "0x1028630", VA = "0x181029A30", Slot = "12")]
		public string GetPayAddition()
		{
			return null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1029A70", Offset = "0x1028670", VA = "0x181029A70", Slot = "8")]
		public string GetSDKToken()
		{
			return null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1029AB0", Offset = "0x10286B0", VA = "0x181029AB0", Slot = "9")]
		public string GetSDKUid()
		{
			return null;
		}

		// Token: 0x06000598 RID: 1432
		[Token(Token = "0x6000598")]
		public abstract void Login(ExternalPluginLoginParams args);

		// Token: 0x06000599 RID: 1433
		[Token(Token = "0x6000599")]
		public abstract void Logout(ExternalPluginLogoutParams args);

		// Token: 0x0600059A RID: 1434
		[Token(Token = "0x600059A")]
		public abstract void Pay(ExternalPluginPayParams args);

		// Token: 0x0600059B RID: 1435 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1029870", Offset = "0x1028470", VA = "0x181029870")]
		protected bool CheckIfLoginReadyOrFallback(ExternalPluginLoginParams args)
		{
			return default(bool);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1028880", Offset = "0x1027480", VA = "0x181028880")]
		protected bool CheckIfLogoutReadyOrFallback(ExternalPluginLogoutParams args)
		{
			return default(bool);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1029910", Offset = "0x1028510", VA = "0x181029910")]
		protected bool CheckIfPayReadyOrFallback(ExternalPluginPayParams args)
		{
			return default(bool);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1029980", Offset = "0x1028580", VA = "0x181029980")]
		public static HGSDKPluginV2 CreateInst(HGSDKV2 sdk)
		{
			return null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool _UseMockVersion()
		{
			return default(bool);
		}

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x10")]
		private HGSDKV2.SDKOptions m_options;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x38")]
		private HGSDKV2 m_sdk;
	}
}
