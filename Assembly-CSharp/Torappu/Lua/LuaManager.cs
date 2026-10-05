using System;
using Il2CppDummyDll;
using Torappu.DB;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x020015F0 RID: 5616
	[Token(Token = "0x20015F0")]
	public class LuaManager : Singleton<LuaManager>
	{
		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06007F37 RID: 32567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F1D")]
		public LuaEnv luaEnv
		{
			[Token(Token = "0x6007F37")]
			[Address(RVA = "0x288E650", Offset = "0x288D250", VA = "0x18288E650")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F38")]
		[Address(RVA = "0x288C620", Offset = "0x288B220", VA = "0x18288C620")]
		public static void InitIfNot()
		{
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F39")]
		[Address(RVA = "0x288C7B0", Offset = "0x288B3B0", VA = "0x18288C7B0")]
		public static void ReloadScripts()
		{
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3A")]
		[Address(RVA = "0x288C850", Offset = "0x288B450", VA = "0x18288C850")]
		public static void Update(float deltaTime)
		{
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3B")]
		[Address(RVA = "0x288C500", Offset = "0x288B100", VA = "0x18288C500")]
		public static void Dispose()
		{
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3C")]
		[Address(RVA = "0x288C580", Offset = "0x288B180", VA = "0x18288C580")]
		public static void FullGC()
		{
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3D")]
		[Address(RVA = "0x288DA40", Offset = "0x288C640", VA = "0x18288DA40")]
		private void _DoInitIfNot()
		{
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3E")]
		[Address(RVA = "0x288DB50", Offset = "0x288C750", VA = "0x18288DB50")]
		private void _DoLoadEntryScript(LuaOptions options)
		{
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3F")]
		[Address(RVA = "0x288E030", Offset = "0x288CC30", VA = "0x18288E030")]
		private void _DoReloadScripts()
		{
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F40")]
		[Address(RVA = "0x288E240", Offset = "0x288CE40", VA = "0x18288E240")]
		private void _DoUpdate(float deltaTime)
		{
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F41")]
		[Address(RVA = "0x288DF70", Offset = "0x288CB70", VA = "0x18288DF70")]
		private void _DoLoad(string filePath)
		{
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F42")]
		[Address(RVA = "0x288CD40", Offset = "0x288B940", VA = "0x18288CD40")]
		private byte[] _CustomLoader(ref string filePath)
		{
			return null;
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F43")]
		[Address(RVA = "0x288CC60", Offset = "0x288B860", VA = "0x18288CC60")]
		private string _ConvertToFullPath(string filePath)
		{
			return null;
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F44")]
		[Address(RVA = "0x288CB80", Offset = "0x288B780", VA = "0x18288CB80")]
		private void _ClearCachedLuaAsset()
		{
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F45")]
		[Address(RVA = "0x288D3E0", Offset = "0x288BFE0", VA = "0x18288D3E0")]
		private void _DoCreateLuaEnv()
		{
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00038010 File Offset: 0x00036210
		[Token(Token = "0x6007F46")]
		[Address(RVA = "0x288D690", Offset = "0x288C290", VA = "0x18288D690")]
		private bool _DoDisposeLuaEnv()
		{
			return default(bool);
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x00038028 File Offset: 0x00036228
		[Token(Token = "0x6007F47")]
		[Address(RVA = "0x288CA60", Offset = "0x288B660", VA = "0x18288CA60")]
		private bool _CallLuaDisposeInAnotherStackFrame()
		{
			return default(bool);
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F48")]
		[Address(RVA = "0x288E3E0", Offset = "0x288CFE0", VA = "0x18288E3E0")]
		private static void _InjectDefinesToLuaEnv(LuaEnv env)
		{
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F49")]
		[Address(RVA = "0x288C2F0", Offset = "0x288AEF0", VA = "0x18288C2F0")]
		public static LuaEnv CreateLuaEnv()
		{
			return null;
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F4A")]
		[Address(RVA = "0x288C240", Offset = "0x288AE40", VA = "0x18288C240")]
		public Func<string, byte[]> CreateDefaultLuaLoader()
		{
			return null;
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4B")]
		[Address(RVA = "0x288E510", Offset = "0x288D110", VA = "0x18288E510")]
		private LuaManager()
		{
		}

		// Token: 0x040080E5 RID: 32997
		[Token(Token = "0x40080E5")]
		private const float TICK_INTERVAL = 1f;

		// Token: 0x040080E6 RID: 32998
		[Token(Token = "0x40080E6")]
		private const string MOCK_EXTENSION = ".M";

		// Token: 0x040080E7 RID: 32999
		[Token(Token = "0x40080E7")]
		[FieldOffset(Offset = "0x10")]
		private bool m_inited;

		// Token: 0x040080E8 RID: 33000
		[Token(Token = "0x40080E8")]
		[FieldOffset(Offset = "0x18")]
		private LuaEnv m_env;

		// Token: 0x040080E9 RID: 33001
		[Token(Token = "0x40080E9")]
		[FieldOffset(Offset = "0x20")]
		private string m_folder;

		// Token: 0x040080EA RID: 33002
		[Token(Token = "0x40080EA")]
		[FieldOffset(Offset = "0x28")]
		private IConverter m_decrypter;

		// Token: 0x040080EB RID: 33003
		[Token(Token = "0x40080EB")]
		[FieldOffset(Offset = "0x30")]
		private PeriodicTimer m_tickTimer;

		// Token: 0x040080EC RID: 33004
		[Token(Token = "0x40080EC")]
		[FieldOffset(Offset = "0x38")]
		private ILoadAsset m_assetLoader;

		// Token: 0x040080ED RID: 33005
		[Token(Token = "0x40080ED")]
		[FieldOffset(Offset = "0x40")]
		private TextAsset m_holdLuaAsset;

		// Token: 0x040080EE RID: 33006
		[Token(Token = "0x40080EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_luaEnv;

		// Token: 0x040080EF RID: 33007
		[Token(Token = "0x40080EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x040080F0 RID: 33008
		[Token(Token = "0x40080F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReloadScripts;

		// Token: 0x040080F1 RID: 33009
		[Token(Token = "0x40080F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040080F2 RID: 33010
		[Token(Token = "0x40080F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x040080F3 RID: 33011
		[Token(Token = "0x40080F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FullGC;

		// Token: 0x040080F4 RID: 33012
		[Token(Token = "0x40080F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoInitIfNot;

		// Token: 0x040080F5 RID: 33013
		[Token(Token = "0x40080F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoLoadEntryScript;

		// Token: 0x040080F6 RID: 33014
		[Token(Token = "0x40080F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoReloadScripts;

		// Token: 0x040080F7 RID: 33015
		[Token(Token = "0x40080F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoUpdate;

		// Token: 0x040080F8 RID: 33016
		[Token(Token = "0x40080F8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoLoad;

		// Token: 0x040080F9 RID: 33017
		[Token(Token = "0x40080F9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CustomLoader;

		// Token: 0x040080FA RID: 33018
		[Token(Token = "0x40080FA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ConvertToFullPath;

		// Token: 0x040080FB RID: 33019
		[Token(Token = "0x40080FB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearCachedLuaAsset;

		// Token: 0x040080FC RID: 33020
		[Token(Token = "0x40080FC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoCreateLuaEnv;

		// Token: 0x040080FD RID: 33021
		[Token(Token = "0x40080FD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DoDisposeLuaEnv;

		// Token: 0x040080FE RID: 33022
		[Token(Token = "0x40080FE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CallLuaDisposeInAnotherStackFrame;

		// Token: 0x040080FF RID: 33023
		[Token(Token = "0x40080FF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InjectDefinesToLuaEnv;

		// Token: 0x04008100 RID: 33024
		[Token(Token = "0x4008100")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CreateLuaEnv;

		// Token: 0x04008101 RID: 33025
		[Token(Token = "0x4008101")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CreateDefaultLuaLoader;

		// Token: 0x04008102 RID: 33026
		[Token(Token = "0x4008102")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
