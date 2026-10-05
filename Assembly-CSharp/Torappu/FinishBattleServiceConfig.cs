using System;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu
{
	// Token: 0x02001417 RID: 5143
	[Token(Token = "0x2001417")]
	public class FinishBattleServiceConfig<TRequest, TResponse> : IFinishBattleServiceConfig where TRequest : CommonFinishBattleRequest, new() where TResponse : CommonFinishBattleResponse, new()
	{
		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060076C7 RID: 30407 RVA: 0x00035148 File Offset: 0x00033348
		[Token(Token = "0x17000E53")]
		public virtual int overrideMaxRetryCount
		{
			[Token(Token = "0x60076C7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C8")]
		public virtual void OnParseRequest(TRequest request)
		{
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060076C9 RID: 30409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E54")]
		protected BattleController battleController
		{
			[Token(Token = "0x60076C9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CA")]
		public FinishBattleServiceConfig(string serviceCode)
		{
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CB")]
		public void SendFinishBattleService(IFinishBattleServiceSender sender, bool isRetry)
		{
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CC")]
		public object TouchReqService()
		{
			return null;
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CD")]
		public object TouchPostService()
		{
			return null;
		}

		// Token: 0x04007415 RID: 29717
		[Token(Token = "0x4007415")]
		[FieldOffset(Offset = "0x0")]
		private string m_serviceCode;
	}
}
