using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torappu.Network;
using Torappu.UI;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x020015F5 RID: 5621
	[Token(Token = "0x20015F5")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public class LuaSender : Singleton<LuaSender>
	{
		// Token: 0x06007F97 RID: 32663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F97")]
		[Address(RVA = "0x28903E0", Offset = "0x288EFE0", VA = "0x1828903E0")]
		private LuaSender()
		{
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F98")]
		[Address(RVA = "0x288E8C0", Offset = "0x288D4C0", VA = "0x18288E8C0")]
		public static void LuaOnlyBindCallback(LuaSender.ILuaServiceCallback callback)
		{
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F99")]
		[Address(RVA = "0x288E950", Offset = "0x288D550", VA = "0x18288E950")]
		public static void ResetNetwork()
		{
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9A")]
		[Address(RVA = "0x288E6F0", Offset = "0x288D2F0", VA = "0x18288E6F0")]
		public static void AchieveServiceMeta(string serviceCode, LuaTable body)
		{
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F9B")]
		[Address(RVA = "0x288EAD0", Offset = "0x288D6D0", VA = "0x18288EAD0")]
		public static string SendRequest(LuaSender.Options options)
		{
			return null;
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F9C")]
		[Address(RVA = "0x288FF90", Offset = "0x288EB90", VA = "0x18288FF90")]
		private string _SendRequest(LuaSender.Options options)
		{
			return null;
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F9D")]
		[Address(RVA = "0x288EA00", Offset = "0x288D600", VA = "0x18288EA00")]
		public static string SendGet(string url, string param, bool useLoadingMask)
		{
			return null;
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F9E")]
		[Address(RVA = "0x288FD10", Offset = "0x288E910", VA = "0x18288FD10")]
		private string _SendGet(string url, string param, bool useLoadingMask)
		{
			return null;
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F9F")]
		[Address(RVA = "0x288F260", Offset = "0x288DE60", VA = "0x18288F260")]
		private void _LuaRequestOnProceed(string id, PlayerRawJsonResponse response)
		{
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA0")]
		[Address(RVA = "0x288EB90", Offset = "0x288D790", VA = "0x18288EB90")]
		private void _LuaGetOnProceed(string id, UISender.MIMEObject response)
		{
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x000381C0 File Offset: 0x000363C0
		[Token(Token = "0x6007FA1")]
		[Address(RVA = "0x288ED90", Offset = "0x288D990", VA = "0x18288ED90")]
		private bool _LuaOnBlock(string id, ResponseError error)
		{
			return default(bool);
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA2")]
		[Address(RVA = "0x288F050", Offset = "0x288DC50", VA = "0x18288F050")]
		private void _LuaOnFinal(string id)
		{
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA3")]
		[Address(RVA = "0x288F170", Offset = "0x288DD70", VA = "0x18288F170")]
		private void _LuaOnSystemCancel(string id)
		{
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FA4")]
		[Address(RVA = "0x288F450", Offset = "0x288E050", VA = "0x18288F450")]
		private static string _ProcessRequestData(string rawRequest)
		{
			return null;
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA5")]
		[Address(RVA = "0x288F950", Offset = "0x288E550", VA = "0x18288F950")]
		private static void _ReplaceEmptyObj2Ary(JObject root)
		{
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FA6")]
		[Address(RVA = "0x288F5D0", Offset = "0x288E1D0", VA = "0x18288F5D0")]
		private static void _ReplaceEmptyObj2Ary(JArray array)
		{
		}

		// Token: 0x0400810C RID: 33036
		[Token(Token = "0x400810C")]
		[FieldOffset(Offset = "0x10")]
		private long m_requestCount;

		// Token: 0x0400810D RID: 33037
		[Token(Token = "0x400810D")]
		[FieldOffset(Offset = "0x18")]
		private LuaSender.ILuaServiceCallback m_luaCallback;

		// Token: 0x0400810E RID: 33038
		[Token(Token = "0x400810E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400810F RID: 33039
		[Token(Token = "0x400810F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LuaOnlyBindCallback;

		// Token: 0x04008110 RID: 33040
		[Token(Token = "0x4008110")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetNetwork;

		// Token: 0x04008111 RID: 33041
		[Token(Token = "0x4008111")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AchieveServiceMeta;

		// Token: 0x04008112 RID: 33042
		[Token(Token = "0x4008112")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04008113 RID: 33043
		[Token(Token = "0x4008113")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendRequest;

		// Token: 0x04008114 RID: 33044
		[Token(Token = "0x4008114")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendGet;

		// Token: 0x04008115 RID: 33045
		[Token(Token = "0x4008115")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendGet;

		// Token: 0x04008116 RID: 33046
		[Token(Token = "0x4008116")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LuaRequestOnProceed;

		// Token: 0x04008117 RID: 33047
		[Token(Token = "0x4008117")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LuaGetOnProceed;

		// Token: 0x04008118 RID: 33048
		[Token(Token = "0x4008118")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LuaOnBlock;

		// Token: 0x04008119 RID: 33049
		[Token(Token = "0x4008119")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LuaOnFinal;

		// Token: 0x0400811A RID: 33050
		[Token(Token = "0x400811A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LuaOnSystemCancel;

		// Token: 0x0400811B RID: 33051
		[Token(Token = "0x400811B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessRequestData;

		// Token: 0x0400811C RID: 33052
		[Token(Token = "0x400811C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ReplaceEmptyObj2Ary;

		// Token: 0x0400811D RID: 33053
		[Token(Token = "0x400811D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1__ReplaceEmptyObj2Ary;

		// Token: 0x020015F6 RID: 5622
		[Token(Token = "0x20015F6")]
		private class WrapHandler<ResType> : UISender.ResultHandler<ResType>
		{
			// Token: 0x17000F1E RID: 3870
			// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007FA8 RID: 32680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F1E")]
			public Action onSystemCancel
			{
				[Token(Token = "0x6007FA7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007FA8")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06007FA9 RID: 32681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FA9")]
			public override Action SystemCancelHandler()
			{
				return null;
			}

			// Token: 0x06007FAA RID: 32682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FAA")]
			public WrapHandler()
			{
			}
		}

		// Token: 0x020015F7 RID: 5623
		[Token(Token = "0x20015F7")]
		private struct RawMsgBundle : IMsgBundle
		{
			// Token: 0x06007FAB RID: 32683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FAB")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280", Slot = "5")]
			public void Deserialize(string data, JsonSerializerSettings setting)
			{
			}

			// Token: 0x06007FAC RID: 32684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FAC")]
			[Address(RVA = "0x289A1E0", Offset = "0x2898DE0", VA = "0x18289A1E0", Slot = "4")]
			public string Serialize(JsonSerializerSettings setting)
			{
				return null;
			}

			// Token: 0x0400811F RID: 33055
			[Token(Token = "0x400811F")]
			[FieldOffset(Offset = "0x0")]
			public string data;
		}

		// Token: 0x020015F8 RID: 5624
		[Token(Token = "0x20015F8")]
		[LuaCallCSharp(GenFlag.No)]
		public struct Options
		{
			// Token: 0x04008120 RID: 33056
			[Token(Token = "0x4008120")]
			[FieldOffset(Offset = "0x0")]
			public string serviceCode;

			// Token: 0x04008121 RID: 33057
			[Token(Token = "0x4008121")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, string> headers;

			// Token: 0x04008122 RID: 33058
			[Token(Token = "0x4008122")]
			[FieldOffset(Offset = "0x10")]
			public bool useInvisibleMask;

			// Token: 0x04008123 RID: 33059
			[Token(Token = "0x4008123")]
			[FieldOffset(Offset = "0x14")]
			public UISender.ConcurrentType concurrentType;

			// Token: 0x04008124 RID: 33060
			[Token(Token = "0x4008124")]
			[FieldOffset(Offset = "0x18")]
			public string body;

			// Token: 0x04008125 RID: 33061
			[Token(Token = "0x4008125")]
			[FieldOffset(Offset = "0x20")]
			public string overrideUrl;
		}

		// Token: 0x020015F9 RID: 5625
		[Token(Token = "0x20015F9")]
		[LuaCallCSharp(GenFlag.No)]
		public struct LuaRespError
		{
			// Token: 0x04008126 RID: 33062
			[Token(Token = "0x4008126")]
			[FieldOffset(Offset = "0x0")]
			public long code;

			// Token: 0x04008127 RID: 33063
			[Token(Token = "0x4008127")]
			[FieldOffset(Offset = "0x8")]
			public string error;

			// Token: 0x04008128 RID: 33064
			[Token(Token = "0x4008128")]
			[FieldOffset(Offset = "0x10")]
			public string message;

			// Token: 0x04008129 RID: 33065
			[Token(Token = "0x4008129")]
			[FieldOffset(Offset = "0x18")]
			public bool isTimeout;

			// Token: 0x0400812A RID: 33066
			[Token(Token = "0x400812A")]
			[FieldOffset(Offset = "0x19")]
			public bool isCanceled;
		}

		// Token: 0x020015FA RID: 5626
		[Token(Token = "0x20015FA")]
		[CSharpCallLua]
		public interface ILuaServiceCallback
		{
			// Token: 0x06007FAD RID: 32685
			[Token(Token = "0x6007FAD")]
			void ExportOnProceed(string requestId, LuaTable response);

			// Token: 0x06007FAE RID: 32686
			[Token(Token = "0x6007FAE")]
			bool ExportOnBlock(string requestId, LuaSender.LuaRespError error);

			// Token: 0x06007FAF RID: 32687
			[Token(Token = "0x6007FAF")]
			void ExportOnFinal(string requestId);

			// Token: 0x06007FB0 RID: 32688
			[Token(Token = "0x6007FB0")]
			void ExportRemoveRequest(string requestId);

			// Token: 0x06007FB1 RID: 32689
			[Token(Token = "0x6007FB1")]
			void ExportResetNetwork();
		}
	}
}
