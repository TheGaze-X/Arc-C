using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using U8.SDK;

namespace HGSDK
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public abstract class U8Plugin : IExternalPlugin
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		protected HGSDK sdk
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x103E820", Offset = "0x103D420", VA = "0x18103E820", Slot = "8")]
		public string GetSDKToken()
		{
			return null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x103E890", Offset = "0x103D490", VA = "0x18103E890", Slot = "9")]
		public string GetSDKUid()
		{
			return null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x103E090", Offset = "0x103CC90", VA = "0x18103E090")]
		public U8Plugin(HGSDK sdk, HGSDK.SDKOptions options)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void Init()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x103E900", Offset = "0x103D500", VA = "0x18103E900", Slot = "17")]
		public virtual void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x5143C0", Offset = "0x512FC0", VA = "0x1805143C0", Slot = "18")]
		protected virtual void BeforeLoginSuc(HGSDK.LoginResult result, Action<HGSDK.LoginResult> baseOnSuc, Action baseOnFail)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x103EAA0", Offset = "0x103D6A0", VA = "0x18103EAA0", Slot = "19")]
		public virtual void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x103EC80", Offset = "0x103D880", VA = "0x18103EC80", Slot = "20")]
		public virtual void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x103EF30", Offset = "0x103DB30", VA = "0x18103EF30", Slot = "10")]
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta)
		{
			return default(bool);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x103EC10", Offset = "0x103D810", VA = "0x18103EC10")]
		public void PayProcess(Action<HGSDK.PayResult> callback)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
		protected void SetPayFailMsg(object payFailMsg)
		{
		}

		// Token: 0x060003CB RID: 971
		[Token(Token = "0x60003CB")]
		protected abstract void PayImplement(ExternalPluginPayParams pluginParam, Action<HGSDK.PayResult> callback);

		// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public virtual void OnProductListChanged(List<U8ProductInfo> productList)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x103E660", Offset = "0x103D260", VA = "0x18103E660", Slot = "12")]
		public string GetPayAddition()
		{
			return null;
		}

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x10")]
		private HGSDK m_sdk;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x18")]
		private HGSDK.SDKOptions m_options;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x40")]
		private ExternalPluginPayParams m_pluginPayParam;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x60")]
		private object m_payFailMsg;

		// Token: 0x020000ED RID: 237
		[Token(Token = "0x20000ED")]
		private struct PayAddition
		{
			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			[FieldOffset(Offset = "0x0")]
			public string asUrl;

			// Token: 0x040004A7 RID: 1191
			[Token(Token = "0x40004A7")]
			[FieldOffset(Offset = "0x8")]
			public bool isMinor;

			// Token: 0x040004A8 RID: 1192
			[Token(Token = "0x40004A8")]
			[FieldOffset(Offset = "0x9")]
			public bool usePollingConfirm;
		}
	}
}
