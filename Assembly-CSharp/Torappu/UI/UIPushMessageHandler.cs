using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200381A RID: 14362
	[Token(Token = "0x200381A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UIPushMessageHandler
	{
		// Token: 0x06016C6F RID: 93295 RVA: 0x00092EB0 File Offset: 0x000910B0
		[Token(Token = "0x6016C6F")]
		[Address(RVA = "0xF47020", Offset = "0xF45C20", VA = "0x180F47020")]
		public static bool UnRegisterLuaHandler(string msgPath)
		{
			return default(bool);
		}

		// Token: 0x06016C70 RID: 93296 RVA: 0x00092EC8 File Offset: 0x000910C8
		[Token(Token = "0x6016C70")]
		private static KeyValuePair<string, UIPushMessageHandler.IMsgHandler> _Handler<TData>(string path, UIPushMessageHandler.MsgHandlerCallback<TData> handler)
		{
			return default(KeyValuePair<string, UIPushMessageHandler.IMsgHandler>);
		}

		// Token: 0x06016C71 RID: 93297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C71")]
		[Address(RVA = "0xF47100", Offset = "0xF45D00", VA = "0x180F47100")]
		private static Dictionary<string, UIPushMessageHandler.IMsgHandler> _EnsureHandlers()
		{
			return null;
		}

		// Token: 0x06016C72 RID: 93298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C72")]
		[Address(RVA = "0xF46F80", Offset = "0xF45B80", VA = "0x180F46F80")]
		public static void UISender_Reset()
		{
		}

		// Token: 0x06016C73 RID: 93299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C73")]
		[Address(RVA = "0xF46EF0", Offset = "0xF45AF0", VA = "0x180F46EF0")]
		public static void UISender_NotifyPushMessages(List<PlayerPushMessage> msgList)
		{
		}

		// Token: 0x06016C74 RID: 93300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C74")]
		[Address(RVA = "0xF46E60", Offset = "0xF45A60", VA = "0x180F46E60")]
		public static void BattleFinish_NotifyPushMessage(List<PlayerPushMessage> msgList)
		{
		}

		// Token: 0x06016C75 RID: 93301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C75")]
		[Address(RVA = "0xF47700", Offset = "0xF46300", VA = "0x180F47700")]
		private static void _NotifyPushMessage(List<PlayerPushMessage> msgList)
		{
		}

		// Token: 0x06016C76 RID: 93302 RVA: 0x00092EE0 File Offset: 0x000910E0
		[Token(Token = "0x6016C76")]
		[Address(RVA = "0xF475F0", Offset = "0xF461F0", VA = "0x180F475F0")]
		private static bool _ExternalHandler(string path, List<PlayerPushMessage> msgList)
		{
			return default(bool);
		}

		// Token: 0x0401B7A0 RID: 112544
		[Token(Token = "0x401B7A0")]
		[FieldOffset(Offset = "0x0")]
		public static UIPushMessageHandler.LuaHandlerGenerator GetLuaHandlersToRegister;

		// Token: 0x0401B7A1 RID: 112545
		[Token(Token = "0x401B7A1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly KeyValuePair<string, UIPushMessageHandler.IMsgHandler>[] s_handlers;

		// Token: 0x0401B7A2 RID: 112546
		[Token(Token = "0x401B7A2")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, UIPushMessageHandler.IMsgHandler> s_handlerMap;

		// Token: 0x0401B7A3 RID: 112547
		[Token(Token = "0x401B7A3")]
		[FieldOffset(Offset = "0x18")]
		private static UIPushMessageHandler.PushMessageHandler[] s_extHandlers;

		// Token: 0x0401B7A4 RID: 112548
		[Token(Token = "0x401B7A4")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<string, List<PlayerPushMessage>> s_reduceMap;

		// Token: 0x0401B7A5 RID: 112549
		[Token(Token = "0x401B7A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UnRegisterLuaHandler;

		// Token: 0x0401B7A6 RID: 112550
		[Token(Token = "0x401B7A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Handler;

		// Token: 0x0401B7A7 RID: 112551
		[Token(Token = "0x401B7A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureHandlers;

		// Token: 0x0401B7A8 RID: 112552
		[Token(Token = "0x401B7A8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UISender_Reset;

		// Token: 0x0401B7A9 RID: 112553
		[Token(Token = "0x401B7A9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UISender_NotifyPushMessages;

		// Token: 0x0401B7AA RID: 112554
		[Token(Token = "0x401B7AA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_BattleFinish_NotifyPushMessage;

		// Token: 0x0401B7AB RID: 112555
		[Token(Token = "0x401B7AB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__NotifyPushMessage;

		// Token: 0x0401B7AC RID: 112556
		[Token(Token = "0x401B7AC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExternalHandler;

		// Token: 0x0200381B RID: 14363
		[Token(Token = "0x200381B")]
		private struct PushItem
		{
			// Token: 0x06016C78 RID: 93304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C78")]
			[Address(RVA = "0xF3AC10", Offset = "0xF39810", VA = "0x180F3AC10")]
			public PushItem(string path, Action<List<JObject>> handler)
			{
			}

			// Token: 0x0401B7AD RID: 112557
			[Token(Token = "0x401B7AD")]
			[FieldOffset(Offset = "0x0")]
			public string path;

			// Token: 0x0401B7AE RID: 112558
			[Token(Token = "0x401B7AE")]
			[FieldOffset(Offset = "0x8")]
			public List<JObject> payloads;

			// Token: 0x0401B7AF RID: 112559
			[Token(Token = "0x401B7AF")]
			[FieldOffset(Offset = "0x10")]
			public Action<List<JObject>> handler;
		}

		// Token: 0x0200381C RID: 14364
		[Token(Token = "0x200381C")]
		private interface IMsgHandler
		{
			// Token: 0x06016C79 RID: 93305
			[Token(Token = "0x6016C79")]
			void Handle(IList<PlayerPushMessage> msgList);
		}

		// Token: 0x0200381D RID: 14365
		// (Invoke) Token: 0x06016C7B RID: 93307
		[Token(Token = "0x200381D")]
		public delegate void MsgHandlerCallback<TData>(List<TData> msgList);

		// Token: 0x0200381E RID: 14366
		[Token(Token = "0x200381E")]
		private struct MsgHandler<TData> : UIPushMessageHandler.IMsgHandler, IHotfixable
		{
			// Token: 0x06016C7E RID: 93310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C7E")]
			public MsgHandler(UIPushMessageHandler.MsgHandlerCallback<TData> pHandler)
			{
			}

			// Token: 0x06016C7F RID: 93311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C7F")]
			public void Handle(IList<PlayerPushMessage> msgList)
			{
			}

			// Token: 0x0401B7B0 RID: 112560
			[Token(Token = "0x401B7B0")]
			[FieldOffset(Offset = "0x0")]
			public UIPushMessageHandler.MsgHandlerCallback<TData> handler;

			// Token: 0x0401B7B1 RID: 112561
			[Token(Token = "0x401B7B1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B7B2 RID: 112562
			[Token(Token = "0x401B7B2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;
		}

		// Token: 0x0200381F RID: 14367
		// (Invoke) Token: 0x06016C81 RID: 93313
		[Token(Token = "0x200381F")]
		[CSharpCallLua]
		public delegate UIPushMessageHandler.MsgLuaHandler[] LuaHandlerGenerator();

		// Token: 0x02003820 RID: 14368
		[Token(Token = "0x2003820")]
		public struct MsgLuaHandler : UIPushMessageHandler.IMsgHandler, IHotfixable
		{
			// Token: 0x17003679 RID: 13945
			// (get) Token: 0x06016C84 RID: 93316 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016C85 RID: 93317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003679")]
			public string msgPath
			{
				[Token(Token = "0x6016C84")]
				[Address(RVA = "0xF3AAF0", Offset = "0xF396F0", VA = "0x180F3AAF0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6016C85")]
				[Address(RVA = "0xF3AB50", Offset = "0xF39750", VA = "0x180F3AB50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016C86 RID: 93318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C86")]
			[Address(RVA = "0xF3AA50", Offset = "0xF39650", VA = "0x180F3AA50")]
			public MsgLuaHandler(string path, UIPushMessageHandler.MsgLuaHandler.LuaMsgHandlerCallback pHandler)
			{
			}

			// Token: 0x06016C87 RID: 93319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C87")]
			[Address(RVA = "0xF3A490", Offset = "0xF39090", VA = "0x180F3A490")]
			public void Clear()
			{
			}

			// Token: 0x06016C88 RID: 93320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C88")]
			[Address(RVA = "0xF3A590", Offset = "0xF39190", VA = "0x180F3A590", Slot = "4")]
			public void Handle(IList<PlayerPushMessage> msgList)
			{
			}

			// Token: 0x0401B7B3 RID: 112563
			[Token(Token = "0x401B7B3")]
			[FieldOffset(Offset = "0x0")]
			private UIPushMessageHandler.MsgLuaHandler.LuaMsgHandlerCallback m_handler;

			// Token: 0x0401B7B5 RID: 112565
			[Token(Token = "0x401B7B5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_msgPath;

			// Token: 0x0401B7B6 RID: 112566
			[Token(Token = "0x401B7B6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_msgPath;

			// Token: 0x0401B7B7 RID: 112567
			[Token(Token = "0x401B7B7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B7B8 RID: 112568
			[Token(Token = "0x401B7B8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x0401B7B9 RID: 112569
			[Token(Token = "0x401B7B9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x02003821 RID: 14369
			// (Invoke) Token: 0x06016C8A RID: 93322
			[Token(Token = "0x2003821")]
			[CSharpCallLua]
			public delegate void LuaMsgHandlerCallback(List<LuaTable> msgList);
		}

		// Token: 0x02003822 RID: 14370
		// (Invoke) Token: 0x06016C8E RID: 93326
		[Token(Token = "0x2003822")]
		private delegate bool PushMessageHandler(string path, List<PlayerPushMessage> msgList);

		// Token: 0x02003823 RID: 14371
		[Token(Token = "0x2003823")]
		public class DynPushMsgHandler
		{
			// Token: 0x06016C91 RID: 93329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C91")]
			public void SetPushMsgHandler<TData>(string path, UIPushMessageHandler.MsgHandlerCallback<TData> pHandler)
			{
			}

			// Token: 0x06016C92 RID: 93330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C92")]
			[Address(RVA = "0xF39C80", Offset = "0xF38880", VA = "0x180F39C80")]
			public void Clear()
			{
			}

			// Token: 0x06016C93 RID: 93331 RVA: 0x00092EF8 File Offset: 0x000910F8
			[Token(Token = "0x6016C93")]
			[Address(RVA = "0xF39E30", Offset = "0xF38A30", VA = "0x180F39E30")]
			public static bool sHandlePushMessage(string path, List<PlayerPushMessage> msgList)
			{
				return default(bool);
			}

			// Token: 0x06016C94 RID: 93332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C94")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynPushMsgHandler()
			{
			}

			// Token: 0x0401B7BA RID: 112570
			[Token(Token = "0x401B7BA")]
			[FieldOffset(Offset = "0x0")]
			private static Dictionary<string, UIPushMessageHandler.IMsgHandler> s_msgMap;

			// Token: 0x0401B7BB RID: 112571
			[Token(Token = "0x401B7BB")]
			[FieldOffset(Offset = "0x10")]
			private List<KeyValuePair<string, UIPushMessageHandler.IMsgHandler>> m_handlers;
		}
	}
}
