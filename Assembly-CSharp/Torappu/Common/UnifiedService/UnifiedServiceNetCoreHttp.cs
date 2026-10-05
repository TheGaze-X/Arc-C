using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Network;
using Torappu.UI;
using XLua;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016DE RID: 5854
	[Token(Token = "0x20016DE")]
	public class UnifiedServiceNetCoreHttp : UnifiedServiceNetCore, IPlayerDataListener, IHotfixable
	{
		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06009448 RID: 37960 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06009449 RID: 37961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000037")]
		public event Action onPlayerDataChanged
		{
			[Token(Token = "0x6009448")]
			[Address(RVA = "0x2B40570", Offset = "0x2B3F170", VA = "0x182B40570")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6009449")]
			[Address(RVA = "0x2B40650", Offset = "0x2B3F250", VA = "0x182B40650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944A")]
		[Address(RVA = "0x2B40350", Offset = "0x2B3EF50", VA = "0x182B40350", Slot = "5")]
		protected override void OnConnectTo(string host, int port)
		{
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944B")]
		[Address(RVA = "0x2B403F0", Offset = "0x2B3EFF0", VA = "0x182B403F0", Slot = "6")]
		protected override void OnDisConnect()
		{
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x00039D50 File Offset: 0x00037F50
		[Token(Token = "0x600944C")]
		public Request CreateRequest<ReqType>(string scode, ReqType requestData) where ReqType : class
		{
			return default(Request);
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600944D")]
		public UISender.ResultHandler<RespTye> SendRequest<RespTye>(Request request) where RespTye : PlayerDeltaResponse
		{
			return null;
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944E")]
		[Address(RVA = "0x2B40470", Offset = "0x2B3F070", VA = "0x182B40470", Slot = "8")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00039D68 File Offset: 0x00037F68
		[Token(Token = "0x600944F")]
		[Address(RVA = "0x2B40290", Offset = "0x2B3EE90", VA = "0x182B40290", Slot = "7")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009450")]
		public void SetPushMsgHandler<TData>(string path, UIPushMessageHandler.MsgHandlerCallback<TData> pHandler)
		{
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009451")]
		[Address(RVA = "0x2B404D0", Offset = "0x2B3F0D0", VA = "0x182B404D0")]
		public UnifiedServiceNetCoreHttp()
		{
		}

		// Token: 0x04008A4C RID: 35404
		[Token(Token = "0x4008A4C")]
		[FieldOffset(Offset = "0x20")]
		private UIPushMessageHandler.DynPushMsgHandler m_pushMsg;

		// Token: 0x04008A4D RID: 35405
		[Token(Token = "0x4008A4D")]
		[FieldOffset(Offset = "0x28")]
		public string playerDataPath;

		// Token: 0x04008A4F RID: 35407
		[Token(Token = "0x4008A4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onPlayerDataChanged;

		// Token: 0x04008A50 RID: 35408
		[Token(Token = "0x4008A50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onPlayerDataChanged;

		// Token: 0x04008A51 RID: 35409
		[Token(Token = "0x4008A51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConnectTo;

		// Token: 0x04008A52 RID: 35410
		[Token(Token = "0x4008A52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisConnect;

		// Token: 0x04008A53 RID: 35411
		[Token(Token = "0x4008A53")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateRequest;

		// Token: 0x04008A54 RID: 35412
		[Token(Token = "0x4008A54")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04008A55 RID: 35413
		[Token(Token = "0x4008A55")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04008A56 RID: 35414
		[Token(Token = "0x4008A56")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x04008A57 RID: 35415
		[Token(Token = "0x4008A57")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetPushMsgHandler;

		// Token: 0x04008A58 RID: 35416
		[Token(Token = "0x4008A58")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
