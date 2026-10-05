using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torappu.Network;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000C18 RID: 3096
	[Token(Token = "0x2000C18")]
	public class PlayerDataRequestHandler : Singleton<PlayerDataRequestHandler>, Networker.IRequestHandler
	{
		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFA")]
		public JsonSerializerSettings serializeSettings
		{
			[Token(Token = "0x60068EA")]
			[Address(RVA = "0x200C5A0", Offset = "0x200B1A0", VA = "0x18200C5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EB")]
		[Address(RVA = "0x200BDD0", Offset = "0x200A9D0", VA = "0x18200BDD0", Slot = "5")]
		public void BeforeRequest(Request request)
		{
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x200BEA0", Offset = "0x200AAA0", VA = "0x18200BEA0", Slot = "7")]
		public void MarkRequestFinish(Request request)
		{
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0x200BF70", Offset = "0x200AB70", VA = "0x18200BF70", Slot = "6")]
		public string SerializeRequest(Request request)
		{
			return null;
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068EE")]
		public CustomYieldInstruction DeserializeResposne<ResType>(string responseText)
		{
			return null;
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00030B70 File Offset: 0x0002ED70
		[Token(Token = "0x60068EF")]
		public RespMsgBundle<ResType> HandleResponse<ResType>(CustomYieldInstruction deserializeTask)
		{
			return default(RespMsgBundle<ResType>);
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F0")]
		private static WaitForAsyncTask<PlayerDataRequestHandler.ResponseDeserializeResult<ResType>> _DeserializeResponse<ResType>(string respText, JObject rawPlayerData, PlayerDataModel prevPlayerData, bool useFastDelta, PlayerDataDelta.IncrementalDelta context)
		{
			return null;
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F1")]
		private static PlayerResponseMeta _CreateRespMeta<RespType>(RespType data, string respText, JsonSerializerSettings playerDataSetting)
		{
			return null;
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F2")]
		private static void _ProcessPlayerData<ResType>(PlayerDataRequestHandler.ResponseDeserializeResult<ResType> asyncResult)
		{
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0x200C490", Offset = "0x200B090", VA = "0x18200C490")]
		private PlayerDataRequestHandler()
		{
		}

		// Token: 0x04003F76 RID: 16246
		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x0")]
		public static readonly JsonSerializerSettings SERIALIZE_SETTINGS;

		// Token: 0x04003F77 RID: 16247
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x10")]
		private PlayerDataRequestHandler.PlayerDeltaContextStore m_playerDeltaContextStore;

		// Token: 0x04003F78 RID: 16248
		[Token(Token = "0x4003F78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serializeSettings;

		// Token: 0x04003F79 RID: 16249
		[Token(Token = "0x4003F79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BeforeRequest;

		// Token: 0x04003F7A RID: 16250
		[Token(Token = "0x4003F7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_MarkRequestFinish;

		// Token: 0x04003F7B RID: 16251
		[Token(Token = "0x4003F7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SerializeRequest;

		// Token: 0x04003F7C RID: 16252
		[Token(Token = "0x4003F7C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DeserializeResposne;

		// Token: 0x04003F7D RID: 16253
		[Token(Token = "0x4003F7D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HandleResponse;

		// Token: 0x04003F7E RID: 16254
		[Token(Token = "0x4003F7E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DeserializeResponse;

		// Token: 0x04003F7F RID: 16255
		[Token(Token = "0x4003F7F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateRespMeta;

		// Token: 0x04003F80 RID: 16256
		[Token(Token = "0x4003F80")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ProcessPlayerData;

		// Token: 0x04003F81 RID: 16257
		[Token(Token = "0x4003F81")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000C19 RID: 3097
		[Token(Token = "0x2000C19")]
		private enum PlayerDataOpt
		{
			// Token: 0x04003F83 RID: 16259
			[Token(Token = "0x4003F83")]
			NONE,
			// Token: 0x04003F84 RID: 16260
			[Token(Token = "0x4003F84")]
			INIT,
			// Token: 0x04003F85 RID: 16261
			[Token(Token = "0x4003F85")]
			MODIFY
		}

		// Token: 0x02000C1A RID: 3098
		[Token(Token = "0x2000C1A")]
		private struct ResponseDeserializeResult<ResType>
		{
			// Token: 0x04003F86 RID: 16262
			[Token(Token = "0x4003F86")]
			[FieldOffset(Offset = "0x0")]
			public PlayerDataRequestHandler.PlayerDataOpt playerDataOpt;

			// Token: 0x04003F87 RID: 16263
			[Token(Token = "0x4003F87")]
			[FieldOffset(Offset = "0x0")]
			public RespMsgBundle<ResType> body;

			// Token: 0x04003F88 RID: 16264
			[Token(Token = "0x4003F88")]
			[FieldOffset(Offset = "0x0")]
			public PlayerDataModel playerData;

			// Token: 0x04003F89 RID: 16265
			[Token(Token = "0x4003F89")]
			[FieldOffset(Offset = "0x0")]
			public JObject rawPlayerData;

			// Token: 0x04003F8A RID: 16266
			[Token(Token = "0x4003F8A")]
			[FieldOffset(Offset = "0x0")]
			public PlayerDataDelta playerDelta;
		}

		// Token: 0x02000C1B RID: 3099
		[Token(Token = "0x2000C1B")]
		private class ExtraPushMsgContainer : IHotfixable
		{
			// Token: 0x060068F5 RID: 26869 RVA: 0x00030B88 File Offset: 0x0002ED88
			[Token(Token = "0x60068F5")]
			[Address(RVA = "0x2009B60", Offset = "0x2008760", VA = "0x182009B60")]
			public static bool SuspectPushMessageField(string respText)
			{
				return default(bool);
			}

			// Token: 0x060068F6 RID: 26870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068F6")]
			[Address(RVA = "0x2009CA0", Offset = "0x20088A0", VA = "0x182009CA0")]
			public ExtraPushMsgContainer()
			{
			}

			// Token: 0x04003F8B RID: 16267
			[Token(Token = "0x4003F8B")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "pushMessage")]
			public List<PlayerPushMessage> pushMessages;

			// Token: 0x04003F8C RID: 16268
			[Token(Token = "0x4003F8C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly string JSON_FIELD_TEXT;

			// Token: 0x04003F8D RID: 16269
			[Token(Token = "0x4003F8D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SuspectPushMessageField;

			// Token: 0x04003F8E RID: 16270
			[Token(Token = "0x4003F8E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000C1C RID: 3100
		[Token(Token = "0x2000C1C")]
		private class PlayerDeltaContextStore : IHotfixable
		{
			// Token: 0x060068F8 RID: 26872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068F8")]
			[Address(RVA = "0x200C6C0", Offset = "0x200B2C0", VA = "0x18200C6C0")]
			public PlayerDataDelta.IncrementalDelta RequestContext()
			{
				return null;
			}

			// Token: 0x060068F9 RID: 26873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068F9")]
			[Address(RVA = "0x200C630", Offset = "0x200B230", VA = "0x18200C630")]
			public void ReleaseContext(PlayerDataDelta.IncrementalDelta context)
			{
			}

			// Token: 0x060068FA RID: 26874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068FA")]
			[Address(RVA = "0x200C7C0", Offset = "0x200B3C0", VA = "0x18200C7C0")]
			public PlayerDeltaContextStore()
			{
			}

			// Token: 0x04003F8F RID: 16271
			[Token(Token = "0x4003F8F")]
			[FieldOffset(Offset = "0x10")]
			private PlayerDataDelta.IncrementalDelta m_idle;

			// Token: 0x04003F90 RID: 16272
			[Token(Token = "0x4003F90")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RequestContext;

			// Token: 0x04003F91 RID: 16273
			[Token(Token = "0x4003F91")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ReleaseContext;

			// Token: 0x04003F92 RID: 16274
			[Token(Token = "0x4003F92")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
