using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Component
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public class SteamPayComponent : BaseComponent
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public static SteamPayComponent Instance
		{
			[Token(Token = "0x6000F8A")]
			[Address(RVA = "0x5CC1370", Offset = "0x5CBFF70", VA = "0x185CC1370")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x5CC0B60", Offset = "0x5CBF760", VA = "0x185CC0B60")]
		public void SteamPay(string strProductId, string eServerTag, string strExtraData)
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x5CC0C70", Offset = "0x5CBF870", VA = "0x185CC0C70")]
		public void SteamRealPay()
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x5CC00D0", Offset = "0x5CBECD0", VA = "0x185CC00D0")]
		public void GetProduct(string productId, string payNotifyUrl, string extraData, string steamId, string languageCode, Action<string> action)
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x5CC0210", Offset = "0x5CBEE10", VA = "0x185CC0210")]
		public void OrderCreate(string payNotifyUrl, string extraData, string payId, string steamId, string languageCode, Action<string> action)
		{
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x5CBFFB0", Offset = "0x5CBEBB0", VA = "0x185CBFFB0")]
		public void ConfirmOrder(string steamOrderId, string extraData, Dictionary<string, object> eventParams)
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x5CC0350", Offset = "0x5CBEF50", VA = "0x185CC0350")]
		public void OrderDetail(string steamOrderId, string extraData, Dictionary<string, object> eventParams)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x5CC0470", Offset = "0x5CBF070", VA = "0x185CC0470")]
		public bool PerformPrePaymentCheck(string productId, string payNotifyUrl, string extraData)
		{
			return default(bool);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x5CC06D0", Offset = "0x5CBF2D0", VA = "0x185CC06D0")]
		public bool ShowPayAreaDlg()
		{
			return default(bool);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SteamPayComponent()
		{
		}

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x10")]
		private string strProductId;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x18")]
		private string eServerTag;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x20")]
		private string strExtraData;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x0")]
		private static string strExtraDataTemp;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, object> eventParam;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Queue<Action> _executionQueue;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x18")]
		private static SteamPayComponent instance;
	}
}
