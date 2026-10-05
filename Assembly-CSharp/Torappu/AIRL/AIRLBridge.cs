using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.AIRL
{
	// Token: 0x02002028 RID: 8232
	[Token(Token = "0x2002028")]
	public class AIRLBridge : Singleton<AIRLBridge>, IBattleModule
	{
		// Token: 0x0600CACA RID: 51914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CACA")]
		[Address(RVA = "0x34BC4F0", Offset = "0x34BB0F0", VA = "0x1834BC4F0")]
		private AIRLBridge()
		{
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600CACB RID: 51915 RVA: 0x000496F8 File Offset: 0x000478F8
		// (set) Token: 0x0600CACC RID: 51916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017FD")]
		public bool inited
		{
			[Token(Token = "0x600CACB")]
			[Address(RVA = "0x34BC670", Offset = "0x34BB270", VA = "0x1834BC670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CACC")]
			[Address(RVA = "0x34BC8E0", Offset = "0x34BB4E0", VA = "0x1834BC8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600CACD RID: 51917 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CACE RID: 51918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017FE")]
		private string externLuaFolderPath
		{
			[Token(Token = "0x600CACD")]
			[Address(RVA = "0x34BC5B0", Offset = "0x34BB1B0", VA = "0x1834BC5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CACE")]
			[Address(RVA = "0x34BC7F0", Offset = "0x34BB3F0", VA = "0x1834BC7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x00049710 File Offset: 0x00047910
		// (set) Token: 0x0600CAD0 RID: 51920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017FF")]
		private BattleController.GameResult gameResult
		{
			[Token(Token = "0x600CACF")]
			[Address(RVA = "0x34BC610", Offset = "0x34BB210", VA = "0x1834BC610")]
			[CompilerGenerated]
			get
			{
				return BattleController.GameResult.NOT_YET;
			}
			[Token(Token = "0x600CAD0")]
			[Address(RVA = "0x34BC870", Offset = "0x34BB470", VA = "0x1834BC870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600CAD1 RID: 51921 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CAD2 RID: 51922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001800")]
		private string logCompressed
		{
			[Token(Token = "0x600CAD1")]
			[Address(RVA = "0x34BC730", Offset = "0x34BB330", VA = "0x1834BC730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CAD2")]
			[Address(RVA = "0x34BC9D0", Offset = "0x34BB5D0", VA = "0x1834BC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CAD4 RID: 51924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001801")]
		private string levelCompressed
		{
			[Token(Token = "0x600CAD3")]
			[Address(RVA = "0x34BC6D0", Offset = "0x34BB2D0", VA = "0x1834BC6D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CAD4")]
			[Address(RVA = "0x34BC950", Offset = "0x34BB550", VA = "0x1834BC950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001802")]
		private string runeCompressed
		{
			[Token(Token = "0x600CAD5")]
			[Address(RVA = "0x34BC790", Offset = "0x34BB390", VA = "0x1834BC790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CAD6")]
			[Address(RVA = "0x34BCA50", Offset = "0x34BB650", VA = "0x1834BCA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAD7")]
		[Address(RVA = "0x34BBD60", Offset = "0x34BA960", VA = "0x1834BBD60")]
		public void Start(AIRLBridge.Options options)
		{
		}

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAD8")]
		[Address(RVA = "0x34BA9E0", Offset = "0x34B95E0", VA = "0x1834BA9E0")]
		public void DoLuaInit(string luaFilePath)
		{
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAD9")]
		[Address(RVA = "0x34BC340", Offset = "0x34BAF40", VA = "0x1834BC340")]
		[Conditional("AIRL_HOTFIX_ENABLE")]
		private void _DoLuaInit(string luaFilePath)
		{
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CADA")]
		[Address(RVA = "0x34BBE90", Offset = "0x34BAA90", VA = "0x1834BBE90")]
		public void Stop()
		{
		}

		// Token: 0x0600CADB RID: 51931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CADB")]
		[Address(RVA = "0x34BA8E0", Offset = "0x34B94E0", VA = "0x1834BA8E0")]
		[Conditional("TORAPPU_AIRL")]
		private void DoLuaDispose()
		{
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CADC")]
		[Address(RVA = "0x34BA7E0", Offset = "0x34B93E0", VA = "0x1834BA7E0")]
		public void DoFixedUpdate()
		{
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CADD")]
		[Address(RVA = "0x34BC150", Offset = "0x34BAD50", VA = "0x1834BC150")]
		private byte[] _CustomLoader(ref string filepath)
		{
			return null;
		}

		// Token: 0x0600CADE RID: 51934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CADE")]
		[Address(RVA = "0x34BC020", Offset = "0x34BAC20", VA = "0x1834BC020")]
		private string _ConvertToFullPath(string filepath)
		{
			return null;
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CADF")]
		[Address(RVA = "0x34BB720", Offset = "0x34BA320", VA = "0x1834BB720", Slot = "4")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE0")]
		[Address(RVA = "0x34BB1F0", Offset = "0x34B9DF0", VA = "0x1834BB1F0", Slot = "5")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE1")]
		[Address(RVA = "0x34BB620", Offset = "0x34BA220", VA = "0x1834BB620", Slot = "6")]
		public void OnGameReady()
		{
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE2")]
		[Address(RVA = "0x34BB840", Offset = "0x34BA440", VA = "0x1834BB840", Slot = "7")]
		public void OnGameStart()
		{
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE3")]
		[Address(RVA = "0x34BB310", Offset = "0x34B9F10", VA = "0x1834BB310", Slot = "8")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE4")]
		[Address(RVA = "0x34BB940", Offset = "0x34BA540", VA = "0x1834BB940")]
		public void RestartGame(string levelId, string levelJson, string squadJson, string runeJson, int gameModeType)
		{
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CAE5")]
		[Address(RVA = "0x34BAA40", Offset = "0x34B9640", VA = "0x1834BAA40")]
		public object GetGameDataSample()
		{
			return null;
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x00049728 File Offset: 0x00047928
		[Token(Token = "0x600CAE6")]
		[Address(RVA = "0x34BAAD0", Offset = "0x34B96D0", VA = "0x1834BAAD0")]
		public uint GetGameFixFrameCount()
		{
			return 0U;
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE7")]
		[Address(RVA = "0x34BB190", Offset = "0x34B9D90", VA = "0x1834BB190")]
		public void ManualFrameTick(object frame)
		{
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CAE8")]
		[Address(RVA = "0x34BAB50", Offset = "0x34B9750", VA = "0x1834BAB50")]
		public string GetLog()
		{
			return null;
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAE9")]
		[Address(RVA = "0x34BAE00", Offset = "0x34B9A00", VA = "0x1834BAE00")]
		[Conditional("TORAPPU_AIRL")]
		private void ManualFrameTickImp(List<FakeNetMessageOpt> frame)
		{
		}

		// Token: 0x0400D483 RID: 54403
		[Token(Token = "0x400D483")]
		[FieldOffset(Offset = "0x20")]
		private LuaEnv.CustomLoader _customLoader;

		// Token: 0x0400D488 RID: 54408
		[Token(Token = "0x400D488")]
		private const string DEFAULT_LUA_EXTENSION = ".lua.txt";

		// Token: 0x0400D489 RID: 54409
		[Token(Token = "0x400D489")]
		[FieldOffset(Offset = "0x48")]
		private string startLua;

		// Token: 0x0400D48A RID: 54410
		[Token(Token = "0x400D48A")]
		[FieldOffset(Offset = "0x50")]
		private string stopLua;

		// Token: 0x0400D48B RID: 54411
		[Token(Token = "0x400D48B")]
		[FieldOffset(Offset = "0x58")]
		public string levelJson;

		// Token: 0x0400D48C RID: 54412
		[Token(Token = "0x400D48C")]
		[FieldOffset(Offset = "0x60")]
		public string squadJson;

		// Token: 0x0400D48D RID: 54413
		[Token(Token = "0x400D48D")]
		[FieldOffset(Offset = "0x68")]
		public string runeJson;

		// Token: 0x0400D48E RID: 54414
		[Token(Token = "0x400D48E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D48F RID: 54415
		[Token(Token = "0x400D48F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x0400D490 RID: 54416
		[Token(Token = "0x400D490")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_inited;

		// Token: 0x0400D491 RID: 54417
		[Token(Token = "0x400D491")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_externLuaFolderPath;

		// Token: 0x0400D492 RID: 54418
		[Token(Token = "0x400D492")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_externLuaFolderPath;

		// Token: 0x0400D493 RID: 54419
		[Token(Token = "0x400D493")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_gameResult;

		// Token: 0x0400D494 RID: 54420
		[Token(Token = "0x400D494")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_gameResult;

		// Token: 0x0400D495 RID: 54421
		[Token(Token = "0x400D495")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_logCompressed;

		// Token: 0x0400D496 RID: 54422
		[Token(Token = "0x400D496")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_logCompressed;

		// Token: 0x0400D497 RID: 54423
		[Token(Token = "0x400D497")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_levelCompressed;

		// Token: 0x0400D498 RID: 54424
		[Token(Token = "0x400D498")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_levelCompressed;

		// Token: 0x0400D499 RID: 54425
		[Token(Token = "0x400D499")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_runeCompressed;

		// Token: 0x0400D49A RID: 54426
		[Token(Token = "0x400D49A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_runeCompressed;

		// Token: 0x0400D49B RID: 54427
		[Token(Token = "0x400D49B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400D49C RID: 54428
		[Token(Token = "0x400D49C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoLuaInit;

		// Token: 0x0400D49D RID: 54429
		[Token(Token = "0x400D49D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DoLuaInit;

		// Token: 0x0400D49E RID: 54430
		[Token(Token = "0x400D49E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D49F RID: 54431
		[Token(Token = "0x400D49F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoLuaDispose;

		// Token: 0x0400D4A0 RID: 54432
		[Token(Token = "0x400D4A0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DoFixedUpdate;

		// Token: 0x0400D4A1 RID: 54433
		[Token(Token = "0x400D4A1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CustomLoader;

		// Token: 0x0400D4A2 RID: 54434
		[Token(Token = "0x400D4A2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ConvertToFullPath;

		// Token: 0x0400D4A3 RID: 54435
		[Token(Token = "0x400D4A3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x0400D4A4 RID: 54436
		[Token(Token = "0x400D4A4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0400D4A5 RID: 54437
		[Token(Token = "0x400D4A5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0400D4A6 RID: 54438
		[Token(Token = "0x400D4A6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0400D4A7 RID: 54439
		[Token(Token = "0x400D4A7")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0400D4A8 RID: 54440
		[Token(Token = "0x400D4A8")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_RestartGame;

		// Token: 0x0400D4A9 RID: 54441
		[Token(Token = "0x400D4A9")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetGameDataSample;

		// Token: 0x0400D4AA RID: 54442
		[Token(Token = "0x400D4AA")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetGameFixFrameCount;

		// Token: 0x0400D4AB RID: 54443
		[Token(Token = "0x400D4AB")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ManualFrameTick;

		// Token: 0x0400D4AC RID: 54444
		[Token(Token = "0x400D4AC")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetLog;

		// Token: 0x0400D4AD RID: 54445
		[Token(Token = "0x400D4AD")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ManualFrameTickImp;

		// Token: 0x02002029 RID: 8233
		[Token(Token = "0x2002029")]
		public struct Options
		{
			// Token: 0x0400D4AE RID: 54446
			[Token(Token = "0x400D4AE")]
			[FieldOffset(Offset = "0x0")]
			public IPEndPoint endPoint;

			// Token: 0x0400D4AF RID: 54447
			[Token(Token = "0x400D4AF")]
			[FieldOffset(Offset = "0x8")]
			public string luaFilePath;

			// Token: 0x0400D4B0 RID: 54448
			[Token(Token = "0x400D4B0")]
			[FieldOffset(Offset = "0x10")]
			public bool readEncrypted;

			// Token: 0x0400D4B1 RID: 54449
			[Token(Token = "0x400D4B1")]
			[FieldOffset(Offset = "0x11")]
			public bool writeEncrypted;

			// Token: 0x0400D4B2 RID: 54450
			[Token(Token = "0x400D4B2")]
			[FieldOffset(Offset = "0x12")]
			public bool expandOpt;
		}
	}
}
