using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using U8.SDK;

namespace XDSDK
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public abstract class U8Plugin : IExternalPlugin
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		protected XDSDK sdk
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x514660", Offset = "0x513260", VA = "0x180514660", Slot = "8")]
		public string GetSDKToken()
		{
			return null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5146E0", Offset = "0x5132E0", VA = "0x1805146E0", Slot = "9")]
		public string GetSDKUid()
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x513DF0", Offset = "0x5129F0", VA = "0x180513DF0")]
		public U8Plugin(XDSDK sdk, XDSDK.SDKOptions options)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void Init()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x514760", Offset = "0x513360", VA = "0x180514760", Slot = "17")]
		public virtual void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x5143C0", Offset = "0x512FC0", VA = "0x1805143C0", Slot = "18")]
		protected virtual void BeforeLoginSuc(XDSDK.LoginResult result, Action<XDSDK.LoginResult> baseOnSuc, Action baseOnFail)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x514960", Offset = "0x513560", VA = "0x180514960", Slot = "19")]
		public virtual void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x514B60", Offset = "0x513760", VA = "0x180514B60", Slot = "20")]
		public virtual void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x514D20", Offset = "0x513920", VA = "0x180514D20", Slot = "10")]
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta)
		{
			return default(bool);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x514AF0", Offset = "0x5136F0", VA = "0x180514AF0")]
		public void PayProcess(Action<XDSDK.PayResult> callback)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
		protected void SetPayFailMsg(object payFailMsg)
		{
		}

		// Token: 0x060002F9 RID: 761
		[Token(Token = "0x60002F9")]
		protected abstract void PayImplement(ExternalPluginPayParams pluginParam, Action<XDSDK.PayResult> callback);

		// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public virtual void OnProductListChanged(List<U8ProductInfo> productList)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x514400", Offset = "0x513000", VA = "0x180514400", Slot = "12")]
		public string GetPayAddition()
		{
			return null;
		}

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x10")]
		private XDSDK m_sdk;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x18")]
		private XDSDK.SDKOptions m_options;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x38")]
		private ExternalPluginPayParams m_pluginPayParam;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x58")]
		private object m_payFailMsg;

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		private struct PayAddition
		{
			// Token: 0x0400035D RID: 861
			[Token(Token = "0x400035D")]
			[FieldOffset(Offset = "0x0")]
			public string asUrl;

			// Token: 0x0400035E RID: 862
			[Token(Token = "0x400035E")]
			[FieldOffset(Offset = "0x8")]
			public bool isMinor;
		}
	}
}
