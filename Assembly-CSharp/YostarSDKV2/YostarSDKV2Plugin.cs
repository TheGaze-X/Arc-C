using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using U8.SDK;

namespace YostarSDKV2
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public abstract class YostarSDKV2Plugin : IExternalPlugin
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x51C980", Offset = "0x51B580", VA = "0x18051C980")]
		protected YostarSDKV2Plugin(YostarSDKV2 sdk)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
		protected YostarSDKV2 GetSDK()
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void Init()
		{
		}

		// Token: 0x06000244 RID: 580
		[Token(Token = "0x6000244")]
		public abstract void Login(ExternalPluginLoginParams args);

		// Token: 0x06000245 RID: 581
		[Token(Token = "0x6000245")]
		public abstract void Pay(ExternalPluginPayParams args);

		// Token: 0x06000246 RID: 582
		[Token(Token = "0x6000246")]
		public abstract void Logout(ExternalPluginLogoutParams args);

		// Token: 0x06000247 RID: 583 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "20")]
		public virtual bool UseU8SDK()
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x51C290", Offset = "0x51AE90", VA = "0x18051C290", Slot = "21")]
		public virtual bool IsSDKReady()
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x51C310", Offset = "0x51AF10", VA = "0x18051C310", Slot = "22")]
		public virtual void OpenAgreements(List<string> agreements)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x51BE90", Offset = "0x51AA90", VA = "0x18051BE90", Slot = "23")]
		public virtual bool CheckIfHasCachedUser()
		{
			return default(bool);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x51C7F0", Offset = "0x51B3F0", VA = "0x18051C7F0", Slot = "24")]
		public virtual void OpenUserCenter()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x51C870", Offset = "0x51B470", VA = "0x18051C870", Slot = "25")]
		public virtual void SwitchAccount()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x51C5F0", Offset = "0x51B1F0", VA = "0x18051C5F0", Slot = "26")]
		public virtual void OpenFeedback()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x51C200", Offset = "0x51AE00", VA = "0x18051C200", Slot = "8")]
		public string GetSDKToken()
		{
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x51C240", Offset = "0x51AE40", VA = "0x18051C240", Slot = "9")]
		public string GetSDKUid()
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x51C940", Offset = "0x51B540", VA = "0x18051C940", Slot = "10")]
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public void OnProductListChanged(List<U8ProductInfo> productList)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "27")]
		public virtual bool TrySubmitGameData(U8ExtraGameData data)
		{
			return default(bool);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "28")]
		public virtual bool TrySetData(int type, string paramJson)
		{
			return default(bool);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x51C8F0", Offset = "0x51B4F0", VA = "0x18051C8F0", Slot = "29")]
		public virtual bool TryGetData(int type, string paramJson, out string data)
		{
			return default(bool);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x51C1C0", Offset = "0x51ADC0", VA = "0x18051C1C0", Slot = "12")]
		public string GetPayAddition()
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x51BF30", Offset = "0x51AB30", VA = "0x18051BF30")]
		protected bool CheckIfLoginReadyOrFallback(ExternalPluginLoginParams args)
		{
			return default(bool);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x51B370", Offset = "0x519F70", VA = "0x18051B370")]
		protected bool CheckIfLogoutReadyOrFallback(ExternalPluginLogoutParams args)
		{
			return default(bool);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x51BFD0", Offset = "0x51ABD0", VA = "0x18051BFD0")]
		protected bool CheckIfPayReadyOrFallback(ExternalPluginPayParams args)
		{
			return default(bool);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x51C0F0", Offset = "0x51ACF0", VA = "0x18051C0F0")]
		public static YostarSDKV2Plugin CreateInst(YostarSDKV2 sdk)
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool _UseMockVersion()
		{
			return default(bool);
		}

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x10")]
		private YostarSDKV2.SDKOptions m_options;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x60")]
		protected YostarSDKV2 m_sdk;
	}
}
