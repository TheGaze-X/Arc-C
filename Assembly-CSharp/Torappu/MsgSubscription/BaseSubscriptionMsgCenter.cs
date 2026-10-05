using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.SDK;
using XLua;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015E0 RID: 5600
	[Token(Token = "0x20015E0")]
	public abstract class BaseSubscriptionMsgCenter : ISubMsgCenter, IHotfixable
	{
		// Token: 0x06007EF5 RID: 32501
		[Token(Token = "0x6007EF5")]
		public abstract void Start();

		// Token: 0x06007EF6 RID: 32502
		[Token(Token = "0x6007EF6")]
		public abstract void Stop();

		// Token: 0x06007EF7 RID: 32503
		[Token(Token = "0x6007EF7")]
		public abstract string GetMsgType();

		// Token: 0x06007EF8 RID: 32504
		[Token(Token = "0x6007EF8")]
		public abstract void HandleMsg(string msgConent);

		// Token: 0x06007EF9 RID: 32505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EF9")]
		[Address(RVA = "0x2886350", Offset = "0x2884F50", VA = "0x182886350")]
		public static void HandleFlushAlerts(List<SubscriptPushMsg> msgs)
		{
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFA")]
		[Address(RVA = "0x28865B0", Offset = "0x28851B0", VA = "0x1828865B0")]
		protected static void StartPushMsgCenter(ISubMsgCenter center)
		{
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFB")]
		[Address(RVA = "0x2886660", Offset = "0x2885260", VA = "0x182886660")]
		protected static void StopPushMsgCenter(ISubMsgCenter center)
		{
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFC")]
		[Address(RVA = "0x2886850", Offset = "0x2885450", VA = "0x182886850")]
		protected BaseSubscriptionMsgCenter()
		{
		}

		// Token: 0x040080A9 RID: 32937
		[Token(Token = "0x40080A9")]
		[FieldOffset(Offset = "0x0")]
		private static BaseSubscriptionMsgCenter.PushMsgCenter s_pushMsgCenter;

		// Token: 0x040080AA RID: 32938
		[Token(Token = "0x40080AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleFlushAlerts;

		// Token: 0x040080AB RID: 32939
		[Token(Token = "0x40080AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartPushMsgCenter;

		// Token: 0x040080AC RID: 32940
		[Token(Token = "0x40080AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StopPushMsgCenter;

		// Token: 0x040080AD RID: 32941
		[Token(Token = "0x40080AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020015E1 RID: 5601
		[Token(Token = "0x20015E1")]
		protected enum SubscribeStatus
		{
			// Token: 0x040080AF RID: 32943
			[Token(Token = "0x40080AF")]
			UN_SUB,
			// Token: 0x040080B0 RID: 32944
			[Token(Token = "0x40080B0")]
			IN_SUB_OPRT,
			// Token: 0x040080B1 RID: 32945
			[Token(Token = "0x40080B1")]
			ALREADY_SUB
		}

		// Token: 0x020015E2 RID: 5602
		[Token(Token = "0x20015E2")]
		protected class SDKCore
		{
			// Token: 0x17000F18 RID: 3864
			// (get) Token: 0x06007EFE RID: 32510 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007EFF RID: 32511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F18")]
			public string msgType
			{
				[Token(Token = "0x6007EFE")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007EFF")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000F19 RID: 3865
			// (get) Token: 0x06007F00 RID: 32512 RVA: 0x00037F38 File Offset: 0x00036138
			[Token(Token = "0x17000F19")]
			public BaseSubscriptionMsgCenter.SubscribeStatus status
			{
				[Token(Token = "0x6007F00")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return BaseSubscriptionMsgCenter.SubscribeStatus.UN_SUB;
				}
			}

			// Token: 0x06007F01 RID: 32513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F01")]
			[Address(RVA = "0x28A0520", Offset = "0x289F120", VA = "0x1828A0520")]
			public SDKCore(string msgt)
			{
			}

			// Token: 0x06007F02 RID: 32514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F02")]
			[Address(RVA = "0x289F720", Offset = "0x289E320", VA = "0x18289F720")]
			public void StartCenter(ISubMsgCenter center)
			{
			}

			// Token: 0x06007F03 RID: 32515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F03")]
			[Address(RVA = "0x289F8A0", Offset = "0x289E4A0", VA = "0x18289F8A0")]
			public void StopCenter(ISubMsgCenter center)
			{
			}

			// Token: 0x06007F04 RID: 32516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F04")]
			[Address(RVA = "0x289FF10", Offset = "0x289EB10", VA = "0x18289FF10")]
			private void _HandleSDKExtraInfo(SDKExtraData extraData)
			{
			}

			// Token: 0x06007F05 RID: 32517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F05")]
			[Address(RVA = "0x28A00C0", Offset = "0x289ECC0", VA = "0x1828A00C0")]
			private void _HandleSubRet(JObject msg)
			{
			}

			// Token: 0x06007F06 RID: 32518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F06")]
			[Address(RVA = "0x28A0180", Offset = "0x289ED80", VA = "0x1828A0180")]
			private void _HandleUnsubRet(JObject msg)
			{
			}

			// Token: 0x06007F07 RID: 32519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F07")]
			[Address(RVA = "0x28A0240", Offset = "0x289EE40", VA = "0x1828A0240")]
			private void _LogError(BaseSubscriptionMsgCenter.SDKCore.SubscribeMessage msg, string title)
			{
			}

			// Token: 0x06007F08 RID: 32520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F08")]
			[Address(RVA = "0x289FCA0", Offset = "0x289E8A0", VA = "0x18289FCA0")]
			private void _HandleMsgPush(JObject msg)
			{
			}

			// Token: 0x06007F09 RID: 32521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F09")]
			[Address(RVA = "0x28A0340", Offset = "0x289EF40", VA = "0x1828A0340")]
			private void _UpdateSubStatus()
			{
			}

			// Token: 0x06007F0A RID: 32522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F0A")]
			[Address(RVA = "0x289F900", Offset = "0x289E500", VA = "0x18289F900")]
			private void _DoSubToSDK()
			{
			}

			// Token: 0x06007F0B RID: 32523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F0B")]
			[Address(RVA = "0x289FB30", Offset = "0x289E730", VA = "0x18289FB30")]
			private void _DoUnsubToSDK()
			{
			}

			// Token: 0x040080B2 RID: 32946
			[Token(Token = "0x40080B2")]
			[FieldOffset(Offset = "0x10")]
			private readonly BaseSubscriptionMsgCenter.SDKCore.ErrorCode[] SILENT_ERRORS;

			// Token: 0x040080B3 RID: 32947
			[Token(Token = "0x40080B3")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<ISubMsgCenter> m_centers;

			// Token: 0x040080B4 RID: 32948
			[Token(Token = "0x40080B4")]
			[FieldOffset(Offset = "0x20")]
			private BaseSubscriptionMsgCenter.SubscribeStatus m_status;

			// Token: 0x020015E3 RID: 5603
			[Token(Token = "0x20015E3")]
			private struct SubscribeMessage
			{
				// Token: 0x06007F0C RID: 32524 RVA: 0x00037F50 File Offset: 0x00036150
				[Token(Token = "0x6007F0C")]
				[Address(RVA = "0x28A1400", Offset = "0x28A0000", VA = "0x1828A1400")]
				public static BaseSubscriptionMsgCenter.SDKCore.SubscribeMessage FromJson(JObject rawObj)
				{
					return default(BaseSubscriptionMsgCenter.SDKCore.SubscribeMessage);
				}

				// Token: 0x040080B6 RID: 32950
				[Token(Token = "0x40080B6")]
				[FieldOffset(Offset = "0x0")]
				public int code;

				// Token: 0x040080B7 RID: 32951
				[Token(Token = "0x40080B7")]
				[FieldOffset(Offset = "0x8")]
				public string type;

				// Token: 0x040080B8 RID: 32952
				[Token(Token = "0x40080B8")]
				[FieldOffset(Offset = "0x10")]
				public int errorCode;
			}

			// Token: 0x020015E4 RID: 5604
			[Token(Token = "0x20015E4")]
			private struct SubParam
			{
				// Token: 0x06007F0D RID: 32525 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007F0D")]
				[Address(RVA = "0x28A1380", Offset = "0x289FF80", VA = "0x1828A1380", Slot = "3")]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x040080B9 RID: 32953
				[Token(Token = "0x40080B9")]
				[FieldOffset(Offset = "0x0")]
				public string type;

				// Token: 0x040080BA RID: 32954
				[Token(Token = "0x40080BA")]
				[FieldOffset(Offset = "0x8")]
				public int authType;

				// Token: 0x040080BB RID: 32955
				[Token(Token = "0x40080BB")]
				[FieldOffset(Offset = "0x10")]
				public string token;
			}

			// Token: 0x020015E5 RID: 5605
			[Token(Token = "0x20015E5")]
			private struct UnsubParam
			{
				// Token: 0x06007F0E RID: 32526 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007F0E")]
				[Address(RVA = "0x28A2560", Offset = "0x28A1160", VA = "0x1828A2560", Slot = "3")]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x040080BC RID: 32956
				[Token(Token = "0x40080BC")]
				[FieldOffset(Offset = "0x0")]
				public string type;
			}

			// Token: 0x020015E6 RID: 5606
			[Token(Token = "0x20015E6")]
			private enum ErrorCode
			{
				// Token: 0x040080BE RID: 32958
				[Token(Token = "0x40080BE")]
				REPEAT_INIT = -201,
				// Token: 0x040080BF RID: 32959
				[Token(Token = "0x40080BF")]
				REPEAT_SUB = -202
			}
		}

		// Token: 0x020015E7 RID: 5607
		[Token(Token = "0x20015E7")]
		protected class PushMsgCenter
		{
			// Token: 0x06007F0F RID: 32527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F0F")]
			[Address(RVA = "0x2899F30", Offset = "0x2898B30", VA = "0x182899F30")]
			public void SubscriptPushMsg(ISubMsgCenter center, bool enable)
			{
			}

			// Token: 0x06007F10 RID: 32528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F10")]
			[Address(RVA = "0x2899E60", Offset = "0x2898A60", VA = "0x182899E60")]
			public void OnPushMessage(string msgType, string data)
			{
			}

			// Token: 0x06007F11 RID: 32529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F11")]
			[Address(RVA = "0x289A110", Offset = "0x2898D10", VA = "0x18289A110")]
			public PushMsgCenter()
			{
			}

			// Token: 0x040080C0 RID: 32960
			[Token(Token = "0x40080C0")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, ISubMsgCenter> m_centers;

			// Token: 0x040080C1 RID: 32961
			[Token(Token = "0x40080C1")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<string, string> m_pendings;
		}
	}
}
