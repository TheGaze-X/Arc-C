using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.Connections;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014AF RID: 5295
	[Token(Token = "0x20014AF")]
	public abstract class ServerWithinJoin : Server
	{
		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06007A34 RID: 31284 RVA: 0x00036BB8 File Offset: 0x00034DB8
		[Token(Token = "0x17000E93")]
		public CommonJoinEntry activeEntry
		{
			[Token(Token = "0x6007A34")]
			[Address(RVA = "0x2649510", Offset = "0x2648110", VA = "0x182649510")]
			get
			{
				return default(CommonJoinEntry);
			}
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A35")]
		[Address(RVA = "0x2649340", Offset = "0x2647F40", VA = "0x182649340")]
		protected ServerWithinJoin(ServerProtocolSuite protocolSuite)
		{
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A36")]
		[Address(RVA = "0x2648C70", Offset = "0x2647870", VA = "0x182648C70", Slot = "4")]
		protected override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A37")]
		[Address(RVA = "0x2648B70", Offset = "0x2647770", VA = "0x182648B70", Slot = "7")]
		protected override void OnHandleFailedParseMsg(NetMsgID msgId)
		{
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00036BD0 File Offset: 0x00034DD0
		[Token(Token = "0x6007A38")]
		[Address(RVA = "0x26488F0", Offset = "0x26474F0", VA = "0x1826488F0")]
		protected bool Join(CommonJoinEntry entry)
		{
			return default(bool);
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A39")]
		[Address(RVA = "0x2648CF0", Offset = "0x26478F0", VA = "0x182648CF0")]
		protected void TryTriggerJoinResult(bool suc)
		{
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3A")]
		[Address(RVA = "0x2648BF0", Offset = "0x26477F0", VA = "0x182648BF0", Slot = "8")]
		public virtual void OnJoinResult(CommonProtocolRetCode retCode, string reason)
		{
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3B")]
		[Address(RVA = "0x2648E50", Offset = "0x2647A50", VA = "0x182648E50")]
		private void _DoJoin()
		{
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x00036BE8 File Offset: 0x00034DE8
		[Token(Token = "0x6007A3C")]
		[Address(RVA = "0x2649110", Offset = "0x2647D10", VA = "0x182649110")]
		private bool _HandleJoinResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3D")]
		[Address(RVA = "0x2648DF0", Offset = "0x26479F0", VA = "0x182648DF0")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3E")]
		[Address(RVA = "0x2648D90", Offset = "0x2647990", VA = "0x182648D90")]
		private void <>xLuaBaseProxy_OnHandleFailedParseMsg(NetMsgID P0)
		{
		}

		// Token: 0x0400784E RID: 30798
		[Token(Token = "0x400784E")]
		[FieldOffset(Offset = "0x68")]
		private ServerProtocolSuite m_protocolSuite;

		// Token: 0x0400784F RID: 30799
		[Token(Token = "0x400784F")]
		[FieldOffset(Offset = "0x70")]
		private CommonJoinEntry m_entry;

		// Token: 0x04007850 RID: 30800
		[Token(Token = "0x4007850")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activeEntry;

		// Token: 0x04007851 RID: 30801
		[Token(Token = "0x4007851")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007852 RID: 30802
		[Token(Token = "0x4007852")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04007853 RID: 30803
		[Token(Token = "0x4007853")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHandleFailedParseMsg;

		// Token: 0x04007854 RID: 30804
		[Token(Token = "0x4007854")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Join;

		// Token: 0x04007855 RID: 30805
		[Token(Token = "0x4007855")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryTriggerJoinResult;

		// Token: 0x04007856 RID: 30806
		[Token(Token = "0x4007856")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnJoinResult;

		// Token: 0x04007857 RID: 30807
		[Token(Token = "0x4007857")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoJoin;

		// Token: 0x04007858 RID: 30808
		[Token(Token = "0x4007858")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleJoinResult;
	}
}
