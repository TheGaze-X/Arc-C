using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Bean;

namespace YoStar.SDK.Component
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public class PayComponent : BaseComponent
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C3")]
		public static PayComponent Instance
		{
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x5CBF170", Offset = "0x5CBDD70", VA = "0x185CBF170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x5CBEC40", Offset = "0x5CBD840", VA = "0x185CBEC40")]
		public void StartPay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode payMode, GMOPayMethod payType)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x5CBD760", Offset = "0x5CBC360", VA = "0x185CBD760")]
		public void GetPayList()
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x5CBDC90", Offset = "0x5CBC890", VA = "0x185CBDC90")]
		public void GetProductInfo(Dictionary<string, object> map)
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x5CBDD60", Offset = "0x5CBC960", VA = "0x185CBDD60")]
		public void GetProduct(PayType payType, string ccKey = "", string ccValue = "")
		{
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x5CBE510", Offset = "0x5CBD110", VA = "0x185CBE510")]
		public bool PerformPrePaymentCheck()
		{
			return default(bool);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x5CBE790", Offset = "0x5CBD390", VA = "0x185CBE790")]
		public bool ShowPayAreaDlg()
		{
			return default(bool);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x5CBCB20", Offset = "0x5CBB720", VA = "0x185CBCB20")]
		private List<Dictionary<string, object>> CreateData()
		{
			return null;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x5CBE2C0", Offset = "0x5CBCEC0", VA = "0x185CBE2C0")]
		public void GmoOrderCreate(PayType payType, string ccKey = "", string ccValue = "")
		{
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x5CBE470", Offset = "0x5CBD070", VA = "0x185CBE470")]
		public void OrderDetail()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x5CBE1E0", Offset = "0x5CBCDE0", VA = "0x185CBE1E0")]
		public Task<List<CreditCardData>> GmoGetCreditCardList()
		{
			return null;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x5CBE0E0", Offset = "0x5CBCCE0", VA = "0x185CBE0E0")]
		public Task<bool> GmoDeleteCreditCard(string cardSeq)
		{
			return null;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x5CBDE70", Offset = "0x5CBCA70", VA = "0x185CBDE70")]
		public string GmoCreateCreditCardToken(string cardNo, string pseudonym, DateTime date, string cvvcvc)
		{
			return null;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x5CBE3D0", Offset = "0x5CBCFD0", VA = "0x185CBE3D0")]
		public void GmoSetCreditCard(string token)
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x5CBCA00", Offset = "0x5CBB600", VA = "0x185CBCA00")]
		public void ClosePay(Dictionary<string, object> extraParam)
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x5CBF100", Offset = "0x5CBDD00", VA = "0x185CBF100")]
		public PayComponent()
		{
		}

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		public const string pay_request_type = "Type";

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		public const string pay_request_product_id = "ProductId";

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		public const string pay_request_product_name = "ProductName";

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		public const string pay_request_product_price = "Amount";

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		public const string pay_request_pay_notify_url = "NotifyURL";

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		public const string pay_request_extra_data = "ExtraData";

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		public const string pay_request_pay_type = "PayType";

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		public const string pay_request_card_token = "CardToken";

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		public const string pay_request_card_seq = "CardSeq";

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		public const string pay_request_gmo = "Gmo";

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		public const string pay_request_pc = "ExtraCreate";

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x0")]
		private static PayComponent instance;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x10")]
		private string type;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x18")]
		private string productId;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x20")]
		private string productName;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x28")]
		private string payNotifyUrl;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x30")]
		private string extraData;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x38")]
		private PaymentMode payMode;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x40")]
		private double productPrice;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x48")]
		private string payId;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x50")]
		private string orderId;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x10")]
		private static string strExtraDataTemp;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, object> eventParam;
	}
}
