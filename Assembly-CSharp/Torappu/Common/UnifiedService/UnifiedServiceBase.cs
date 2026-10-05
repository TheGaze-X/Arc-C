using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016E8 RID: 5864
	[Token(Token = "0x20016E8")]
	public abstract class UnifiedServiceBase<ModuleDataType, MsgType, Config> where ModuleDataType : new() where MsgType : struct where Config : UnifiedServiceConfig
	{
		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x0600946C RID: 37996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600946D RID: 37997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE1")]
		private protected Config config
		{
			[Token(Token = "0x600946C")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600946D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600946E RID: 37998 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600946F RID: 37999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000038")]
		public event Action<UnifiedServiceSysEvent> onSysEvent
		{
			[Token(Token = "0x600946E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600946F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06009470 RID: 38000 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009471 RID: 38001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE2")]
		private protected UnifiedServiceNetCore netCore
		{
			[Token(Token = "0x6009470")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009471")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06009472 RID: 38002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009473 RID: 38003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE3")]
		public ModuleDataType moduleData
		{
			[Token(Token = "0x6009472")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009473")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06009474 RID: 38004 RVA: 0x00039DC8 File Offset: 0x00037FC8
		[Token(Token = "0x17000FE4")]
		public UnifiedServiceNetState netState
		{
			[Token(Token = "0x6009474")]
			get
			{
				return UnifiedServiceNetState.NONE;
			}
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009475")]
		public void Start(Config cfg)
		{
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009476")]
		public void Stop()
		{
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009477")]
		public void Update()
		{
		}

		// Token: 0x06009478 RID: 38008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009478")]
		public void SendRequestMsg(MsgType msg)
		{
		}

		// Token: 0x06009479 RID: 38009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009479")]
		public void SendRequestMsg(MsgType msg, ValueBundle data)
		{
		}

		// Token: 0x0600947A RID: 38010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947A")]
		public void Subscribe(UnifiedServiceBase<ModuleDataType, MsgType, Config>.IMsgListener listener)
		{
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947B")]
		public void Unsubscribe(UnifiedServiceBase<ModuleDataType, MsgType, Config>.IMsgListener listener)
		{
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947C")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947D")]
		private void _HandleNetStateChanged(UnifiedServiceNetState netState)
		{
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947E")]
		protected void DispatchMsg(MsgType msg, ValueBundle data)
		{
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00039DE0 File Offset: 0x00037FE0
		[Token(Token = "0x600947F")]
		protected bool DispatchError(MsgType msg, ValueBundle data)
		{
			return default(bool);
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009480")]
		protected void NotifyDataChanged()
		{
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00039DF8 File Offset: 0x00037FF8
		[Token(Token = "0x6009481")]
		protected static KeyValuePair<MsgType, UnifiedServiceBase<ModuleDataType, MsgType, Config>.RequestMsgSender> DefSender(MsgType msg, UnifiedServiceBase<ModuleDataType, MsgType, Config>.RequestMsgSender sender)
		{
			return default(KeyValuePair<MsgType, UnifiedServiceBase<ModuleDataType, MsgType, Config>.RequestMsgSender>);
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009482")]
		private void _DispatchSystemEvent(UnifiedServiceSysEvent evt)
		{
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06009483 RID: 38019
		[Token(Token = "0x17000FE5")]
		protected abstract KeyValuePair<MsgType, UnifiedServiceBase<ModuleDataType, MsgType, Config>.RequestMsgSender>[] senderList { [Token(Token = "0x6009483")] get; }

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06009484 RID: 38020
		[Token(Token = "0x17000FE6")]
		protected abstract UnifiedServiceNetType networkType { [Token(Token = "0x6009484")] get; }

		// Token: 0x06009485 RID: 38021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009485")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009486")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009487")]
		protected virtual void OnStop()
		{
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009488")]
		protected virtual void OnNetStateChanged()
		{
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009489")]
		private UnifiedServiceNetCore _CreateNetCore()
		{
			return null;
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x0600948A RID: 38026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FE7")]
		protected UnifiedServiceNetCoreHttp httpNet
		{
			[Token(Token = "0x600948A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FE8")]
		protected UnifiedServiceNetCoreTCP tcpNet
		{
			[Token(Token = "0x600948B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x0600948C RID: 38028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FE9")]
		protected UnifiedServiceNetCoreMock mockNet
		{
			[Token(Token = "0x600948C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948D")]
		protected void DefHttpPushMsgConvertor<TData>(string pushMsgPath, MsgType toMsgType)
		{
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948E")]
		protected UnifiedServiceBase()
		{
		}

		// Token: 0x04008A78 RID: 35448
		[Token(Token = "0x4008A78")]
		[FieldOffset(Offset = "0x0")]
		private EnumIntDictionary<MsgType, UnifiedServiceBase<ModuleDataType, MsgType, Config>.RequestMsgSender> m_senderMap;

		// Token: 0x04008A79 RID: 35449
		[Token(Token = "0x4008A79")]
		[FieldOffset(Offset = "0x0")]
		private EnumIntDictionary<MsgType, object> m_httpPushMsgMap;

		// Token: 0x04008A7A RID: 35450
		[Token(Token = "0x4008A7A")]
		[FieldOffset(Offset = "0x0")]
		private List<UnifiedServiceBase<ModuleDataType, MsgType, Config>.IMsgListener> m_listener;

		// Token: 0x020016E9 RID: 5865
		[Token(Token = "0x20016E9")]
		public interface IMsgListener
		{
			// Token: 0x0600948F RID: 38031
			[Token(Token = "0x600948F")]
			void OnMessage(MsgType msg, ValueBundle data);

			// Token: 0x06009490 RID: 38032
			[Token(Token = "0x6009490")]
			bool OnFail(MsgType msg, ValueBundle data);
		}

		// Token: 0x020016EA RID: 5866
		// (Invoke) Token: 0x06009492 RID: 38034
		[Token(Token = "0x20016EA")]
		protected delegate void RequestMsgSender(ValueBundle data);
	}
}
