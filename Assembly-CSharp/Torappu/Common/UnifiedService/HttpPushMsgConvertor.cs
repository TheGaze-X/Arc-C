using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016DF RID: 5855
	[Token(Token = "0x20016DF")]
	public class HttpPushMsgConvertor<TData, MsgType> where MsgType : struct
	{
		// Token: 0x06009452 RID: 37970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009452")]
		private HttpPushMsgConvertor()
		{
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009453")]
		public static HttpPushMsgConvertor<TData, MsgType> Gen(string pushMsgPath, MsgType toMsg, UnifiedServiceNetCoreHttp httpNet, Action<MsgType, ValueBundle> msgDispatcher)
		{
			return null;
		}

		// Token: 0x06009454 RID: 37972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009454")]
		private void _HandlePushMsg(List<TData> msgList)
		{
		}

		// Token: 0x04008A59 RID: 35417
		[Token(Token = "0x4008A59")]
		[FieldOffset(Offset = "0x0")]
		private MsgType m_msgType;

		// Token: 0x04008A5A RID: 35418
		[Token(Token = "0x4008A5A")]
		[FieldOffset(Offset = "0x0")]
		private Action<MsgType, ValueBundle> m_dispatcher;
	}
}
