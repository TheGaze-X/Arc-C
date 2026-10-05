using System;
using System.Diagnostics;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x020015EB RID: 5611
	[Token(Token = "0x20015EB")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public class LuaAIRLSampleMgr : Singleton<LuaAIRLSampleMgr>
	{
		// Token: 0x06007F26 RID: 32550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F26")]
		[Address(RVA = "0x288A300", Offset = "0x2888F00", VA = "0x18288A300")]
		private LuaAIRLSampleMgr()
		{
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06007F27 RID: 32551 RVA: 0x00037FB0 File Offset: 0x000361B0
		[Token(Token = "0x17000F1B")]
		public bool isCallbackReady
		{
			[Token(Token = "0x6007F27")]
			[Address(RVA = "0x288A370", Offset = "0x2888F70", VA = "0x18288A370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F28")]
		[Address(RVA = "0x288A0D0", Offset = "0x2888CD0", VA = "0x18288A0D0")]
		[Conditional("TORAPPU_AIRL")]
		public static void LuaOnlyBindCallback(LuaAIRLSampleMgr.ILuaAIRLSampler callback)
		{
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x00037FC8 File Offset: 0x000361C8
		[Token(Token = "0x6007F29")]
		[Address(RVA = "0x2889FC0", Offset = "0x2888BC0", VA = "0x182889FC0")]
		public static long GetTimestamp()
		{
			return 0L;
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F2A")]
		[Address(RVA = "0x288A230", Offset = "0x2888E30", VA = "0x18288A230")]
		public string SampleGameData()
		{
			return null;
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2B")]
		[Address(RVA = "0x288A160", Offset = "0x2888D60", VA = "0x18288A160")]
		public void ResetAll()
		{
		}

		// Token: 0x040080D3 RID: 32979
		[Token(Token = "0x40080D3")]
		[FieldOffset(Offset = "0x10")]
		private LuaAIRLSampleMgr.ILuaAIRLSampler m_luaCallback;

		// Token: 0x040080D4 RID: 32980
		[Token(Token = "0x40080D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040080D5 RID: 32981
		[Token(Token = "0x40080D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isCallbackReady;

		// Token: 0x040080D6 RID: 32982
		[Token(Token = "0x40080D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LuaOnlyBindCallback;

		// Token: 0x040080D7 RID: 32983
		[Token(Token = "0x40080D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTimestamp;

		// Token: 0x040080D8 RID: 32984
		[Token(Token = "0x40080D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SampleGameData;

		// Token: 0x040080D9 RID: 32985
		[Token(Token = "0x40080D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetAll;

		// Token: 0x020015EC RID: 5612
		[Token(Token = "0x20015EC")]
		[CSharpCallLua]
		public interface ILuaAIRLSampler
		{
			// Token: 0x06007F2C RID: 32556
			[Token(Token = "0x6007F2C")]
			string ExportSampleGameData();

			// Token: 0x06007F2D RID: 32557
			[Token(Token = "0x6007F2D")]
			void ExportClearContext();
		}
	}
}
