using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.SDK
{
	// Token: 0x020014FA RID: 5370
	[Token(Token = "0x20014FA")]
	[CreateAssetMenu(menuName = "Torappu/Options/SDKOptions")]
	public class SDKOptions : SingletonScriptableObject<SDKOptions>
	{
		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06007B9E RID: 31646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB5")]
		public SDKOptions.Configuration currentConfig
		{
			[Token(Token = "0x6007B9E")]
			[Address(RVA = "0x2745150", Offset = "0x2743D50", VA = "0x182745150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB6")]
		public static SDKOptions.Configuration configuration
		{
			[Token(Token = "0x6007B9F")]
			[Address(RVA = "0x27450D0", Offset = "0x2743CD0", VA = "0x1827450D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BA0")]
		[Address(RVA = "0x2744F10", Offset = "0x2743B10", VA = "0x182744F10")]
		private SDKOptions.Configuration _GetConfigurationByMode(SDKOptions.Mode mode)
		{
			return null;
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA1")]
		[Address(RVA = "0x2744F40", Offset = "0x2743B40", VA = "0x182744F40")]
		public SDKOptions()
		{
		}

		// Token: 0x04007A03 RID: 31235
		[Token(Token = "0x4007A03")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SDKOptions.Mode mode;

		// Token: 0x04007A04 RID: 31236
		[Token(Token = "0x4007A04")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public U8Options u8Options;

		// Token: 0x04007A05 RID: 31237
		[Token(Token = "0x4007A05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Configs")]
		public SDKOptions.Configuration dev;

		// Token: 0x04007A06 RID: 31238
		[Token(Token = "0x4007A06")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Configs")]
		public SDKOptions.Configuration staging;

		// Token: 0x04007A07 RID: 31239
		[Token(Token = "0x4007A07")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Configs")]
		public SDKOptions.Configuration production;

		// Token: 0x04007A08 RID: 31240
		[Token(Token = "0x4007A08")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Configs")]
		public SDKOptions.Configuration business;

		// Token: 0x020014FB RID: 5371
		[Token(Token = "0x20014FB")]
		public enum Mode
		{
			// Token: 0x04007A0A RID: 31242
			[Token(Token = "0x4007A0A")]
			DEV,
			// Token: 0x04007A0B RID: 31243
			[Token(Token = "0x4007A0B")]
			STAGING,
			// Token: 0x04007A0C RID: 31244
			[Token(Token = "0x4007A0C")]
			PRODUCTION,
			// Token: 0x04007A0D RID: 31245
			[Token(Token = "0x4007A0D")]
			BUSINESS
		}

		// Token: 0x020014FC RID: 5372
		[Token(Token = "0x20014FC")]
		[Serializable]
		public class Configuration
		{
			// Token: 0x06007BA2 RID: 31650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA2")]
			[Address(RVA = "0x2739480", Offset = "0x2738080", VA = "0x182739480")]
			public Configuration()
			{
			}

			// Token: 0x04007A0E RID: 31246
			[Token(Token = "0x4007A0E")]
			[FieldOffset(Offset = "0x10")]
			public AdjustOptions adjustOptions;

			// Token: 0x04007A0F RID: 31247
			[Token(Token = "0x4007A0F")]
			[FieldOffset(Offset = "0x18")]
			public TrackingioOptions trackingioOptions;

			// Token: 0x04007A10 RID: 31248
			[Token(Token = "0x4007A10")]
			[FieldOffset(Offset = "0x20")]
			public string talkingdataAppId;
		}
	}
}
