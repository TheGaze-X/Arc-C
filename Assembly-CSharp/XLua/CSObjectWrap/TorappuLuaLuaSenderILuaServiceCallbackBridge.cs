using System;
using Il2CppDummyDll;
using Torappu.Lua;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	public class TorappuLuaLuaSenderILuaServiceCallbackBridge : LuaBase, LuaSender.ILuaServiceCallback
	{
		// Token: 0x06004087 RID: 16519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004087")]
		[Address(RVA = "0xCF7330", Offset = "0xCF5F30", VA = "0x180CF7330")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuLuaLuaSenderILuaServiceCallbackBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004089")]
		[Address(RVA = "0xCF6C70", Offset = "0xCF5870", VA = "0x180CF6C70", Slot = "7")]
		private void ExportOnProceed(string requestId, LuaTable response)
		{
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00020B80 File Offset: 0x0001ED80
		[Token(Token = "0x600408A")]
		[Address(RVA = "0xCF6760", Offset = "0xCF5360", VA = "0x180CF6760", Slot = "8")]
		private bool ExportOnBlock(string requestId, LuaSender.LuaRespError error)
		{
			return default(bool);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408B")]
		[Address(RVA = "0xCF6A40", Offset = "0xCF5640", VA = "0x180CF6A40", Slot = "9")]
		private void ExportOnFinal(string requestId)
		{
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408C")]
		[Address(RVA = "0xCF6EF0", Offset = "0xCF5AF0", VA = "0x180CF6EF0", Slot = "10")]
		private void ExportRemoveRequest(string requestId)
		{
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408D")]
		[Address(RVA = "0xCF7120", Offset = "0xCF5D20", VA = "0x180CF7120", Slot = "11")]
		private void ExportResetNetwork()
		{
		}
	}
}
