using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020014DF RID: 5343
	[Token(Token = "0x20014DF")]
	public class SDKExtraInfoHandler : Singleton<SDKExtraInfoHandler>
	{
		// Token: 0x06007B34 RID: 31540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B34")]
		[Address(RVA = "0x2741F50", Offset = "0x2740B50", VA = "0x182741F50")]
		private SDKExtraInfoHandler()
		{
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06007B35 RID: 31541 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B36 RID: 31542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002F")]
		public event Action<SDKExtraInfoHandler.GT3Message> eventGT3Message
		{
			[Token(Token = "0x6007B35")]
			[Address(RVA = "0x2742140", Offset = "0x2740D40", VA = "0x182742140")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B36")]
			[Address(RVA = "0x2742840", Offset = "0x2741440", VA = "0x182742840")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06007B37 RID: 31543 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B38 RID: 31544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000030")]
		public event Action<SDKExtraInfoHandler.CloudAuthMessage> eventCloudAuthMessage
		{
			[Token(Token = "0x6007B37")]
			[Address(RVA = "0x2742040", Offset = "0x2740C40", VA = "0x182742040")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B38")]
			[Address(RVA = "0x2742740", Offset = "0x2741340", VA = "0x182742740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06007B39 RID: 31545 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B3A RID: 31546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000031")]
		public event Action<SDKExtraInfoHandler.UnbindGrantMessage> eventUnbindGrantMessage
		{
			[Token(Token = "0x6007B39")]
			[Address(RVA = "0x2742540", Offset = "0x2741140", VA = "0x182742540")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B3A")]
			[Address(RVA = "0x2742C40", Offset = "0x2741840", VA = "0x182742C40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06007B3B RID: 31547 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B3C RID: 31548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000032")]
		public event Action<SDKExtraInfoHandler.SDKInitMessage> eventSDKInitMessage
		{
			[Token(Token = "0x6007B3B")]
			[Address(RVA = "0x2742340", Offset = "0x2740F40", VA = "0x182742340")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B3C")]
			[Address(RVA = "0x2742A40", Offset = "0x2741640", VA = "0x182742A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06007B3D RID: 31549 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B3E RID: 31550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000033")]
		public event Action<SDKExtraInfoHandler.NativeLicenseRet> eventLicenseRetMessage
		{
			[Token(Token = "0x6007B3D")]
			[Address(RVA = "0x2742240", Offset = "0x2740E40", VA = "0x182742240")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B3E")]
			[Address(RVA = "0x2742940", Offset = "0x2741540", VA = "0x182742940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06007B3F RID: 31551 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B40 RID: 31552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000034")]
		private event Action<SDKExtraInfoHandler.ShareCallBackMessage> m_eventShareCallBackMessage
		{
			[Token(Token = "0x6007B3F")]
			[Address(RVA = "0x2742640", Offset = "0x2741240", VA = "0x182742640")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B40")]
			[Address(RVA = "0x2742D40", Offset = "0x2741940", VA = "0x182742D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06007B41 RID: 31553 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007B42 RID: 31554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000035")]
		public event Action<SDKExtraData> eventSubscribeRetMessage
		{
			[Token(Token = "0x6007B41")]
			[Address(RVA = "0x2742440", Offset = "0x2741040", VA = "0x182742440")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007B42")]
			[Address(RVA = "0x2742B40", Offset = "0x2741740", VA = "0x182742B40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B43")]
		[Address(RVA = "0x27402E0", Offset = "0x273EEE0", VA = "0x1827402E0")]
		public void HandleExtraInfo(SDKExtraData extraData)
		{
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B44")]
		[Address(RVA = "0x2741720", Offset = "0x2740320", VA = "0x182741720")]
		private void _HandleMessageMTP(JObject msg)
		{
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B45")]
		[Address(RVA = "0x27413B0", Offset = "0x273FFB0", VA = "0x1827413B0")]
		private void _HandleMessageGT3(JObject msg)
		{
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B46")]
		[Address(RVA = "0x2741BD0", Offset = "0x27407D0", VA = "0x182741BD0")]
		private void _HandleMessageXDQuerry(JObject msg)
		{
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B47")]
		[Address(RVA = "0x2741170", Offset = "0x273FD70", VA = "0x182741170")]
		private void _HandleMessageCloudAuth(JObject msg)
		{
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B48")]
		[Address(RVA = "0x2741A50", Offset = "0x2740650", VA = "0x182741A50")]
		private void _HandleMessageUnbindGrant(JObject msg)
		{
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B49")]
		[Address(RVA = "0x2741470", Offset = "0x2740070", VA = "0x182741470")]
		private void _HandleMessageHGSDKInit(JObject msg)
		{
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4A")]
		[Address(RVA = "0x2741590", Offset = "0x2740190", VA = "0x182741590")]
		private void _HandleMessageLicenseRet(JObject msg)
		{
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4B")]
		[Address(RVA = "0x2741EB0", Offset = "0x2740AB0", VA = "0x182741EB0")]
		private void _HandleSubscription(SDKExtraData extraData)
		{
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4C")]
		[Address(RVA = "0x2741D90", Offset = "0x2740990", VA = "0x182741D90")]
		private void _HandleRequestLogout(JObject msg)
		{
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4D")]
		[Address(RVA = "0x2741E10", Offset = "0x2740A10", VA = "0x182741E10")]
		private void _HandleShareCallBackRet(JObject msg)
		{
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4E")]
		[Address(RVA = "0x2741C70", Offset = "0x2740870", VA = "0x182741C70")]
		private void _HandleMessageYostarSDKV2DeleteAccount(JObject msg)
		{
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4F")]
		[Address(RVA = "0x27410D0", Offset = "0x273FCD0", VA = "0x1827410D0")]
		private void _HandleMessageAccountCenterClosed(JObject msg)
		{
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B50")]
		[Address(RVA = "0x2741910", Offset = "0x2740510", VA = "0x182741910")]
		private void _HandleMessageScanLogin(JObject msg)
		{
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B51")]
		[Address(RVA = "0x273FE80", Offset = "0x273EA80", VA = "0x18273FE80")]
		public void BindShareCallBack(Action<SDKExtraInfoHandler.ShareCallBackMessage> handler)
		{
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B52")]
		[Address(RVA = "0x2740F80", Offset = "0x273FB80", VA = "0x182740F80")]
		public void _CleanShareCallBack()
		{
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B53")]
		[Address(RVA = "0x2740E40", Offset = "0x273FA40", VA = "0x182740E40")]
		private void _AddWarning(SDKExtraInfoHandler.TPMessage msg)
		{
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B54")]
		[Address(RVA = "0x2740150", Offset = "0x273ED50", VA = "0x182740150")]
		public string GetTPHeartBeat()
		{
			return null;
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B55")]
		[Address(RVA = "0x2740280", Offset = "0x273EE80", VA = "0x182740280")]
		public Dictionary<int, string> GetWarnings()
		{
			return null;
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B56")]
		[Address(RVA = "0x273FF50", Offset = "0x273EB50", VA = "0x18273FF50")]
		public Dictionary<int, string> GenExtraInfoToLog()
		{
			return null;
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B57")]
		[Address(RVA = "0x2740FF0", Offset = "0x273FBF0", VA = "0x182740FF0")]
		private static string _GenHeartBeat()
		{
			return null;
		}

		// Token: 0x0400796D RID: 31085
		[Token(Token = "0x400796D")]
		[FieldOffset(Offset = "0x10")]
		private string m_tpHeartBeat;

		// Token: 0x0400796E RID: 31086
		[Token(Token = "0x400796E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, string> m_warnings;

		// Token: 0x04007976 RID: 31094
		[Token(Token = "0x4007976")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007977 RID: 31095
		[Token(Token = "0x4007977")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_add_eventGT3Message;

		// Token: 0x04007978 RID: 31096
		[Token(Token = "0x4007978")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_remove_eventGT3Message;

		// Token: 0x04007979 RID: 31097
		[Token(Token = "0x4007979")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_add_eventCloudAuthMessage;

		// Token: 0x0400797A RID: 31098
		[Token(Token = "0x400797A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_remove_eventCloudAuthMessage;

		// Token: 0x0400797B RID: 31099
		[Token(Token = "0x400797B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_add_eventUnbindGrantMessage;

		// Token: 0x0400797C RID: 31100
		[Token(Token = "0x400797C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_remove_eventUnbindGrantMessage;

		// Token: 0x0400797D RID: 31101
		[Token(Token = "0x400797D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_add_eventSDKInitMessage;

		// Token: 0x0400797E RID: 31102
		[Token(Token = "0x400797E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_remove_eventSDKInitMessage;

		// Token: 0x0400797F RID: 31103
		[Token(Token = "0x400797F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_add_eventLicenseRetMessage;

		// Token: 0x04007980 RID: 31104
		[Token(Token = "0x4007980")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_remove_eventLicenseRetMessage;

		// Token: 0x04007981 RID: 31105
		[Token(Token = "0x4007981")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_add_m_eventShareCallBackMessage;

		// Token: 0x04007982 RID: 31106
		[Token(Token = "0x4007982")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_remove_m_eventShareCallBackMessage;

		// Token: 0x04007983 RID: 31107
		[Token(Token = "0x4007983")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_add_eventSubscribeRetMessage;

		// Token: 0x04007984 RID: 31108
		[Token(Token = "0x4007984")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_remove_eventSubscribeRetMessage;

		// Token: 0x04007985 RID: 31109
		[Token(Token = "0x4007985")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HandleExtraInfo;

		// Token: 0x04007986 RID: 31110
		[Token(Token = "0x4007986")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleMessageMTP;

		// Token: 0x04007987 RID: 31111
		[Token(Token = "0x4007987")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleMessageGT3;

		// Token: 0x04007988 RID: 31112
		[Token(Token = "0x4007988")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleMessageXDQuerry;

		// Token: 0x04007989 RID: 31113
		[Token(Token = "0x4007989")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleMessageCloudAuth;

		// Token: 0x0400798A RID: 31114
		[Token(Token = "0x400798A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleMessageUnbindGrant;

		// Token: 0x0400798B RID: 31115
		[Token(Token = "0x400798B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleMessageHGSDKInit;

		// Token: 0x0400798C RID: 31116
		[Token(Token = "0x400798C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__HandleMessageLicenseRet;

		// Token: 0x0400798D RID: 31117
		[Token(Token = "0x400798D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__HandleSubscription;

		// Token: 0x0400798E RID: 31118
		[Token(Token = "0x400798E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__HandleRequestLogout;

		// Token: 0x0400798F RID: 31119
		[Token(Token = "0x400798F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__HandleShareCallBackRet;

		// Token: 0x04007990 RID: 31120
		[Token(Token = "0x4007990")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleMessageYostarSDKV2DeleteAccount;

		// Token: 0x04007991 RID: 31121
		[Token(Token = "0x4007991")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__HandleMessageAccountCenterClosed;

		// Token: 0x04007992 RID: 31122
		[Token(Token = "0x4007992")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__HandleMessageScanLogin;

		// Token: 0x04007993 RID: 31123
		[Token(Token = "0x4007993")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_BindShareCallBack;

		// Token: 0x04007994 RID: 31124
		[Token(Token = "0x4007994")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CleanShareCallBack;

		// Token: 0x04007995 RID: 31125
		[Token(Token = "0x4007995")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__AddWarning;

		// Token: 0x04007996 RID: 31126
		[Token(Token = "0x4007996")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetTPHeartBeat;

		// Token: 0x04007997 RID: 31127
		[Token(Token = "0x4007997")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetWarnings;

		// Token: 0x04007998 RID: 31128
		[Token(Token = "0x4007998")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GenExtraInfoToLog;

		// Token: 0x04007999 RID: 31129
		[Token(Token = "0x4007999")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GenHeartBeat;

		// Token: 0x020014E0 RID: 5344
		[Token(Token = "0x20014E0")]
		private enum TPMsgType
		{
			// Token: 0x0400799B RID: 31131
			[Token(Token = "0x400799B")]
			NONE,
			// Token: 0x0400799C RID: 31132
			[Token(Token = "0x400799C")]
			DETECT_RESULT,
			// Token: 0x0400799D RID: 31133
			[Token(Token = "0x400799D")]
			HEARTBEAT
		}

		// Token: 0x020014E1 RID: 5345
		[Token(Token = "0x20014E1")]
		private struct TPMessage
		{
			// Token: 0x06007B58 RID: 31576 RVA: 0x00036FD8 File Offset: 0x000351D8
			[Token(Token = "0x6007B58")]
			[Address(RVA = "0x2747CE0", Offset = "0x27468E0", VA = "0x182747CE0")]
			public static SDKExtraInfoHandler.TPMessage FromJson(JObject content)
			{
				return default(SDKExtraInfoHandler.TPMessage);
			}

			// Token: 0x06007B59 RID: 31577 RVA: 0x00036FF0 File Offset: 0x000351F0
			[Token(Token = "0x6007B59")]
			[Address(RVA = "0x2747EA0", Offset = "0x2746AA0", VA = "0x182747EA0")]
			private static int _ExtractIdFromInfo(string info)
			{
				return 0;
			}

			// Token: 0x0400799E RID: 31134
			[Token(Token = "0x400799E")]
			[FieldOffset(Offset = "0x0")]
			public SDKExtraInfoHandler.TPMsgType type;

			// Token: 0x0400799F RID: 31135
			[Token(Token = "0x400799F")]
			[FieldOffset(Offset = "0x8")]
			public string info;

			// Token: 0x040079A0 RID: 31136
			[Token(Token = "0x40079A0")]
			[FieldOffset(Offset = "0x10")]
			public int id;
		}

		// Token: 0x020014E2 RID: 5346
		[Token(Token = "0x20014E2")]
		public struct GT3Message : IHotfixable
		{
			// Token: 0x06007B5A RID: 31578 RVA: 0x00037008 File Offset: 0x00035208
			[Token(Token = "0x6007B5A")]
			[Address(RVA = "0x273B160", Offset = "0x2739D60", VA = "0x18273B160")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06007B5B RID: 31579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B5B")]
			[Address(RVA = "0x273AE20", Offset = "0x2739A20", VA = "0x18273AE20")]
			public JObject DeserializeCaptchaObj()
			{
				return null;
			}

			// Token: 0x06007B5C RID: 31580 RVA: 0x00037020 File Offset: 0x00035220
			[Token(Token = "0x6007B5C")]
			[Address(RVA = "0x273AF40", Offset = "0x2739B40", VA = "0x18273AF40")]
			public static SDKExtraInfoHandler.GT3Message FromJson(JObject obj)
			{
				return default(SDKExtraInfoHandler.GT3Message);
			}

			// Token: 0x040079A1 RID: 31137
			[Token(Token = "0x40079A1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SDKExtraInfoHandler.GT3Message EMPTY;

			// Token: 0x040079A2 RID: 31138
			[Token(Token = "0x40079A2")]
			[FieldOffset(Offset = "0x0")]
			public int flag;

			// Token: 0x040079A3 RID: 31139
			[Token(Token = "0x40079A3")]
			[FieldOffset(Offset = "0x8")]
			public string desc;

			// Token: 0x040079A4 RID: 31140
			[Token(Token = "0x40079A4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x040079A5 RID: 31141
			[Token(Token = "0x40079A5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DeserializeCaptchaObj;

			// Token: 0x040079A6 RID: 31142
			[Token(Token = "0x40079A6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FromJson;
		}

		// Token: 0x020014E3 RID: 5347
		[Token(Token = "0x20014E3")]
		public struct CloudAuthMessage : IHotfixable
		{
			// Token: 0x06007B5E RID: 31582 RVA: 0x00037038 File Offset: 0x00035238
			[Token(Token = "0x6007B5E")]
			[Address(RVA = "0x2738E70", Offset = "0x2737A70", VA = "0x182738E70")]
			public bool CheckIfGoNextStep()
			{
				return default(bool);
			}

			// Token: 0x06007B5F RID: 31583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B5F")]
			[Address(RVA = "0x27390B0", Offset = "0x2737CB0", VA = "0x1827390B0")]
			public string GetErrorAlert()
			{
				return null;
			}

			// Token: 0x06007B60 RID: 31584 RVA: 0x00037050 File Offset: 0x00035250
			[Token(Token = "0x6007B60")]
			[Address(RVA = "0x2738F10", Offset = "0x2737B10", VA = "0x182738F10")]
			public static SDKExtraInfoHandler.CloudAuthMessage FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.CloudAuthMessage);
			}

			// Token: 0x040079A7 RID: 31143
			[Token(Token = "0x40079A7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SDKExtraInfoHandler.CloudAuthMessage EMPTY;

			// Token: 0x040079A8 RID: 31144
			[Token(Token = "0x40079A8")]
			[FieldOffset(Offset = "0x0")]
			public int flag;

			// Token: 0x040079A9 RID: 31145
			[Token(Token = "0x40079A9")]
			[FieldOffset(Offset = "0x8")]
			public string errCode;

			// Token: 0x040079AA RID: 31146
			[Token(Token = "0x40079AA")]
			[FieldOffset(Offset = "0x10")]
			public string errMsg;

			// Token: 0x040079AB RID: 31147
			[Token(Token = "0x40079AB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CheckIfGoNextStep;

			// Token: 0x040079AC RID: 31148
			[Token(Token = "0x40079AC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetErrorAlert;

			// Token: 0x040079AD RID: 31149
			[Token(Token = "0x40079AD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_FromJson;
		}

		// Token: 0x020014E4 RID: 5348
		[Token(Token = "0x20014E4")]
		public struct UnbindGrantMessage : IHotfixable
		{
			// Token: 0x06007B62 RID: 31586 RVA: 0x00037068 File Offset: 0x00035268
			[Token(Token = "0x6007B62")]
			[Address(RVA = "0x274F750", Offset = "0x274E350", VA = "0x18274F750")]
			public static SDKExtraInfoHandler.UnbindGrantMessage FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.UnbindGrantMessage);
			}

			// Token: 0x040079AE RID: 31150
			[Token(Token = "0x40079AE")]
			[FieldOffset(Offset = "0x0")]
			public int flag;

			// Token: 0x040079AF RID: 31151
			[Token(Token = "0x40079AF")]
			[FieldOffset(Offset = "0x8")]
			public string desc;

			// Token: 0x040079B0 RID: 31152
			[Token(Token = "0x40079B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_FromJson;
		}

		// Token: 0x020014E5 RID: 5349
		[Token(Token = "0x20014E5")]
		public struct NativeLicenseRet
		{
			// Token: 0x17000EAD RID: 3757
			// (get) Token: 0x06007B63 RID: 31587 RVA: 0x00037080 File Offset: 0x00035280
			// (set) Token: 0x06007B64 RID: 31588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EAD")]
			public int code
			{
				[Token(Token = "0x6007B63")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6007B64")]
				[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EAE RID: 3758
			// (get) Token: 0x06007B65 RID: 31589 RVA: 0x00037098 File Offset: 0x00035298
			// (set) Token: 0x06007B66 RID: 31590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EAE")]
			public int errorCode
			{
				[Token(Token = "0x6007B65")]
				[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6007B66")]
				[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007B67 RID: 31591 RVA: 0x000370B0 File Offset: 0x000352B0
			[Token(Token = "0x6007B67")]
			[Address(RVA = "0x273CD20", Offset = "0x273B920", VA = "0x18273CD20")]
			public bool IsLicenseAgreed()
			{
				return default(bool);
			}

			// Token: 0x06007B68 RID: 31592 RVA: 0x000370C8 File Offset: 0x000352C8
			[Token(Token = "0x6007B68")]
			[Address(RVA = "0x273CC20", Offset = "0x273B820", VA = "0x18273CC20")]
			public static SDKExtraInfoHandler.NativeLicenseRet FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.NativeLicenseRet);
			}

			// Token: 0x040079B1 RID: 31153
			[Token(Token = "0x40079B1")]
			[FieldOffset(Offset = "0x0")]
			public static SDKExtraInfoHandler.NativeLicenseRet AGREED_LICENSE;

			// Token: 0x040079B2 RID: 31154
			[Token(Token = "0x40079B2")]
			[FieldOffset(Offset = "0x8")]
			public static SDKExtraInfoHandler.NativeLicenseRet ERROR_LICENSE;
		}

		// Token: 0x020014E6 RID: 5350
		[Token(Token = "0x20014E6")]
		public struct SDKInitMessage : IHotfixable
		{
			// Token: 0x06007B6A RID: 31594 RVA: 0x000370E0 File Offset: 0x000352E0
			[Token(Token = "0x6007B6A")]
			[Address(RVA = "0x2743AC0", Offset = "0x27426C0", VA = "0x182743AC0")]
			public static SDKExtraInfoHandler.SDKInitMessage FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.SDKInitMessage);
			}

			// Token: 0x040079B5 RID: 31157
			[Token(Token = "0x40079B5")]
			[FieldOffset(Offset = "0x0")]
			public int flag;

			// Token: 0x040079B6 RID: 31158
			[Token(Token = "0x40079B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_FromJson;
		}

		// Token: 0x020014E7 RID: 5351
		[Token(Token = "0x20014E7")]
		public struct YostarSDKV2DeleteAccountMessage : IHotfixable
		{
			// Token: 0x06007B6B RID: 31595 RVA: 0x000370F8 File Offset: 0x000352F8
			[Token(Token = "0x6007B6B")]
			[Address(RVA = "0x274F880", Offset = "0x274E480", VA = "0x18274F880")]
			public static SDKExtraInfoHandler.YostarSDKV2DeleteAccountMessage FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.YostarSDKV2DeleteAccountMessage);
			}

			// Token: 0x040079B7 RID: 31159
			[Token(Token = "0x40079B7")]
			[FieldOffset(Offset = "0x0")]
			public int flag;

			// Token: 0x040079B8 RID: 31160
			[Token(Token = "0x40079B8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_FromJson;
		}

		// Token: 0x020014E8 RID: 5352
		[Token(Token = "0x20014E8")]
		public struct ShareCallBackMessage : IHotfixable
		{
			// Token: 0x17000EAF RID: 3759
			// (get) Token: 0x06007B6C RID: 31596 RVA: 0x00037110 File Offset: 0x00035310
			// (set) Token: 0x06007B6D RID: 31597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EAF")]
			public int code
			{
				[Token(Token = "0x6007B6C")]
				[Address(RVA = "0x2745B20", Offset = "0x2744720", VA = "0x182745B20")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6007B6D")]
				[Address(RVA = "0x2745C50", Offset = "0x2744850", VA = "0x182745C50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EB0 RID: 3760
			// (get) Token: 0x06007B6E RID: 31598 RVA: 0x00037128 File Offset: 0x00035328
			// (set) Token: 0x06007B6F RID: 31599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EB0")]
			public int errorCode
			{
				[Token(Token = "0x6007B6E")]
				[Address(RVA = "0x2745B80", Offset = "0x2744780", VA = "0x182745B80")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6007B6F")]
				[Address(RVA = "0x2745CD0", Offset = "0x27448D0", VA = "0x182745CD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EB1 RID: 3761
			// (get) Token: 0x06007B70 RID: 31600 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007B71 RID: 31601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EB1")]
			public string targetPath
			{
				[Token(Token = "0x6007B70")]
				[Address(RVA = "0x2745BE0", Offset = "0x27447E0", VA = "0x182745BE0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6007B71")]
				[Address(RVA = "0x2745D50", Offset = "0x2744950", VA = "0x182745D50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007B72 RID: 31602 RVA: 0x00037140 File Offset: 0x00035340
			[Token(Token = "0x6007B72")]
			[Address(RVA = "0x27458A0", Offset = "0x27444A0", VA = "0x1827458A0")]
			public static SDKExtraInfoHandler.ShareCallBackMessage FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.ShareCallBackMessage);
			}

			// Token: 0x040079BC RID: 31164
			[Token(Token = "0x40079BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_code;

			// Token: 0x040079BD RID: 31165
			[Token(Token = "0x40079BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_code;

			// Token: 0x040079BE RID: 31166
			[Token(Token = "0x40079BE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_errorCode;

			// Token: 0x040079BF RID: 31167
			[Token(Token = "0x40079BF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_errorCode;

			// Token: 0x040079C0 RID: 31168
			[Token(Token = "0x40079C0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_targetPath;

			// Token: 0x040079C1 RID: 31169
			[Token(Token = "0x40079C1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_targetPath;

			// Token: 0x040079C2 RID: 31170
			[Token(Token = "0x40079C2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_FromJson;
		}

		// Token: 0x020014E9 RID: 5353
		[Token(Token = "0x20014E9")]
		public struct ScanLoginMessage : IHotfixable
		{
			// Token: 0x06007B73 RID: 31603 RVA: 0x00037158 File Offset: 0x00035358
			[Token(Token = "0x6007B73")]
			[Address(RVA = "0x27456A0", Offset = "0x27442A0", VA = "0x1827456A0")]
			public static SDKExtraInfoHandler.ScanLoginMessage FromJson(JObject rawObj)
			{
				return default(SDKExtraInfoHandler.ScanLoginMessage);
			}

			// Token: 0x040079C3 RID: 31171
			[Token(Token = "0x40079C3")]
			[FieldOffset(Offset = "0x0")]
			public int flag;

			// Token: 0x040079C4 RID: 31172
			[Token(Token = "0x40079C4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_FromJson;
		}
	}
}
