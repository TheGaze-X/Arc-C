using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DB;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.CETest
{
	// Token: 0x02001797 RID: 6039
	[Token(Token = "0x2001797")]
	public class CETestBridge : SingletonMonoBehaviour<CETestBridge>, ISingletonNotAutoCreate, IBattleModule
	{
		// Token: 0x0600989A RID: 39066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600989A")]
		[Address(RVA = "0x313CCC0", Offset = "0x313B8C0", VA = "0x18313CCC0")]
		private CETestBridge()
		{
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x0600989B RID: 39067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001061")]
		public string levelJson
		{
			[Token(Token = "0x600989B")]
			[Address(RVA = "0x313CF40", Offset = "0x313BB40", VA = "0x18313CF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x0600989C RID: 39068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001062")]
		public string squadJson
		{
			[Token(Token = "0x600989C")]
			[Address(RVA = "0x313D1A0", Offset = "0x313BDA0", VA = "0x18313D1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600989D RID: 39069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001063")]
		public string runeJson
		{
			[Token(Token = "0x600989D")]
			[Address(RVA = "0x313D0C0", Offset = "0x313BCC0", VA = "0x18313D0C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x0600989E RID: 39070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001064")]
		public string levelId
		{
			[Token(Token = "0x600989E")]
			[Address(RVA = "0x313CED0", Offset = "0x313BAD0", VA = "0x18313CED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600989F RID: 39071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001065")]
		public TextAsset levelAsset
		{
			[Token(Token = "0x600989F")]
			[Address(RVA = "0x313CE60", Offset = "0x313BA60", VA = "0x18313CE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060098A0 RID: 39072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001066")]
		public TextAsset squadAsset
		{
			[Token(Token = "0x60098A0")]
			[Address(RVA = "0x313D130", Offset = "0x313BD30", VA = "0x18313D130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001067")]
		private static IConverter plainTextConverter
		{
			[Token(Token = "0x60098A1")]
			[Address(RVA = "0x313CFB0", Offset = "0x313BBB0", VA = "0x18313CFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060098A2 RID: 39074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001068")]
		private static IConverter decrypter
		{
			[Token(Token = "0x60098A2")]
			[Address(RVA = "0x313CD50", Offset = "0x313B950", VA = "0x18313CD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A3")]
		[Address(RVA = "0x313C4E0", Offset = "0x313B0E0", VA = "0x18313C4E0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A4")]
		[Address(RVA = "0x313BC40", Offset = "0x313A840", VA = "0x18313BC40")]
		public void Dispose()
		{
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098A5")]
		[Address(RVA = "0x313BEF0", Offset = "0x313AAF0", VA = "0x18313BEF0")]
		public object LoadData()
		{
			return null;
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A6")]
		[Address(RVA = "0x313BF60", Offset = "0x313AB60", VA = "0x18313BF60")]
		public void LoadLevel(string levelId, string squadId)
		{
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A7")]
		[Address(RVA = "0x313B940", Offset = "0x313A540", VA = "0x18313B940")]
		public void BackToLogin()
		{
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A8")]
		[Address(RVA = "0x313C3F0", Offset = "0x313AFF0", VA = "0x18313C3F0", Slot = "8")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A9")]
		[Address(RVA = "0x313C280", Offset = "0x313AE80", VA = "0x18313C280", Slot = "9")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AA")]
		[Address(RVA = "0x313C380", Offset = "0x313AF80", VA = "0x18313C380", Slot = "10")]
		public void OnGameReady()
		{
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AB")]
		[Address(RVA = "0x313C470", Offset = "0x313B070", VA = "0x18313C470", Slot = "11")]
		public void OnGameStart()
		{
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AC")]
		[Address(RVA = "0x313C300", Offset = "0x313AF00", VA = "0x18313C300", Slot = "12")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AD")]
		[Address(RVA = "0x313C0D0", Offset = "0x313ACD0", VA = "0x18313C0D0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AE")]
		[Address(RVA = "0x313C640", Offset = "0x313B240", VA = "0x18313C640")]
		[Conditional("TORAPPU_CE_TEST")]
		private void RegistLuaCETest()
		{
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AF")]
		[Address(RVA = "0x313BB50", Offset = "0x313A750", VA = "0x18313BB50")]
		[Conditional("TORAPPU_CE_TEST")]
		private void BlockOceanCatHead(ref bool checkMark)
		{
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B0")]
		[Address(RVA = "0x313BA60", Offset = "0x313A660", VA = "0x18313BA60")]
		[Conditional("UNITY_EDITOR")]
		private void BlockOceanCatHeadInEditor(ref bool checkMark)
		{
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098B1")]
		[Address(RVA = "0x313C8D0", Offset = "0x313B4D0", VA = "0x18313C8D0")]
		private byte[] _CETestLuaLoader(ref string filepath)
		{
			return null;
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098B2")]
		[Address(RVA = "0x313CAB0", Offset = "0x313B6B0", VA = "0x18313CAB0")]
		private string _ConvertToFullPath(string filepath)
		{
			return null;
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098B3")]
		[Address(RVA = "0x313C730", Offset = "0x313B330", VA = "0x18313C730")]
		public static byte[] _CETestLuaHotfixLoader(ref string filepath)
		{
			return null;
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B4")]
		[Address(RVA = "0x313B880", Offset = "0x313A480", VA = "0x18313B880")]
		public static void AddBlockPageConfig(string pageName)
		{
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x0003B730 File Offset: 0x00039930
		[Token(Token = "0x60098B5")]
		[Address(RVA = "0x313BE80", Offset = "0x313AA80", VA = "0x18313BE80")]
		public static bool IsValidUILockTarget(UILockTarget target)
		{
			return default(bool);
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x0003B748 File Offset: 0x00039948
		[Token(Token = "0x60098B6")]
		[Address(RVA = "0x313BD10", Offset = "0x313A910", VA = "0x18313BD10")]
		public static bool IsValidPage(string pageName)
		{
			return default(bool);
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B7")]
		[Address(RVA = "0x313CBB0", Offset = "0x313B7B0", VA = "0x18313CBB0")]
		private static void _InitUIEntryBlockMap()
		{
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B8")]
		[Address(RVA = "0x313C060", Offset = "0x313AC60", VA = "0x18313C060")]
		[Conditional("TORAPPU_CE_TEST")]
		public static void LoadLuaFeature()
		{
		}

		// Token: 0x04008E8A RID: 36490
		[Token(Token = "0x4008E8A")]
		[FieldOffset(Offset = "0x18")]
		private bool m_inited;

		// Token: 0x04008E8B RID: 36491
		[Token(Token = "0x4008E8B")]
		[FieldOffset(Offset = "0x19")]
		private bool m_luaRegistered;

		// Token: 0x04008E8C RID: 36492
		[Token(Token = "0x4008E8C")]
		public const string TEST_SCENE_NAME = "ce_test_entry";

		// Token: 0x04008E8D RID: 36493
		[Token(Token = "0x4008E8D")]
		public const string TEST_BATTLE_LOADER_NAME = "ce_battle_loader";

		// Token: 0x04008E8E RID: 36494
		[Token(Token = "0x4008E8E")]
		public const string TEST_BATTLE_SCENE_NAME = "ce_battle_scene";

		// Token: 0x04008E8F RID: 36495
		[Token(Token = "0x4008E8F")]
		public const string TEST_SCENE_PATH = "Assets/Torappu/Scenes/Battle/CETest/ce_test_entry.unity";

		// Token: 0x04008E90 RID: 36496
		[Token(Token = "0x4008E90")]
		public const string TEST_BATTLE_LOADER_PATH = "Assets/Torappu/Scenes/Battle/CETest/ce_battle_loader.unity";

		// Token: 0x04008E91 RID: 36497
		[Token(Token = "0x4008E91")]
		public const string TEST_BATTLE_SCENE_PATH = "Assets/Torappu/Scenes/Battle/CETest/ce_battle_scene.unity";

		// Token: 0x04008E92 RID: 36498
		[Token(Token = "0x4008E92")]
		public const string TEST_BATTLE_SCENE_AB_PATH = "scenes/cetest/ce_battle_scene.unity";

		// Token: 0x04008E93 RID: 36499
		[Token(Token = "0x4008E93")]
		public const string TEST_DEFAULT_LUA_PATH = "../ExternalTools/CETestLogicFile";

		// Token: 0x04008E94 RID: 36500
		[Token(Token = "0x4008E94")]
		public const string TEST_UI_BLOCK_CONFIG_PATH = "Assets/Torappu/StaticData/CETestConfigs/ce_ui_block_options.asset";

		// Token: 0x04008E95 RID: 36501
		[Token(Token = "0x4008E95")]
		public const string PREF_KEY = "Torappu.CETest.EnableOceanCatHead";

		// Token: 0x04008E96 RID: 36502
		[Token(Token = "0x4008E96")]
		[FieldOffset(Offset = "0x20")]
		private string m_levelJson;

		// Token: 0x04008E97 RID: 36503
		[Token(Token = "0x4008E97")]
		[FieldOffset(Offset = "0x28")]
		private TextAsset m_levelAsset;

		// Token: 0x04008E98 RID: 36504
		[Token(Token = "0x4008E98")]
		[FieldOffset(Offset = "0x30")]
		private string m_squadJson;

		// Token: 0x04008E99 RID: 36505
		[Token(Token = "0x4008E99")]
		[FieldOffset(Offset = "0x38")]
		private TextAsset m_squadAsset;

		// Token: 0x04008E9A RID: 36506
		[Token(Token = "0x4008E9A")]
		[FieldOffset(Offset = "0x40")]
		private string m_runeJson;

		// Token: 0x04008E9B RID: 36507
		[Token(Token = "0x4008E9B")]
		[FieldOffset(Offset = "0x48")]
		private string m_levelId;

		// Token: 0x04008E9C RID: 36508
		[Token(Token = "0x4008E9C")]
		[FieldOffset(Offset = "0x50")]
		private LuaEnv.CustomLoader m_customLoader;

		// Token: 0x04008E9D RID: 36509
		[Token(Token = "0x4008E9D")]
		[FieldOffset(Offset = "0x0")]
		public static LuaEnv.CustomLoader m_hotfixLoader;

		// Token: 0x04008E9E RID: 36510
		[Token(Token = "0x4008E9E")]
		[FieldOffset(Offset = "0x58")]
		private string m_luaRootPath;

		// Token: 0x04008E9F RID: 36511
		[Token(Token = "0x4008E9F")]
		[FieldOffset(Offset = "0x8")]
		public static string m_luaHotfixRootPath;

		// Token: 0x04008EA0 RID: 36512
		[Token(Token = "0x4008EA0")]
		[FieldOffset(Offset = "0x10")]
		private static IConverter m_plainTextConverter;

		// Token: 0x04008EA1 RID: 36513
		[Token(Token = "0x4008EA1")]
		[FieldOffset(Offset = "0x18")]
		private static IConverter m_decrypter;

		// Token: 0x04008EA2 RID: 36514
		[Token(Token = "0x4008EA2")]
		[FieldOffset(Offset = "0x20")]
		private static HashSet<string> _uiEntryBlockMap;

		// Token: 0x04008EA3 RID: 36515
		[Token(Token = "0x4008EA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008EA4 RID: 36516
		[Token(Token = "0x4008EA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_levelJson;

		// Token: 0x04008EA5 RID: 36517
		[Token(Token = "0x4008EA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_squadJson;

		// Token: 0x04008EA6 RID: 36518
		[Token(Token = "0x4008EA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_runeJson;

		// Token: 0x04008EA7 RID: 36519
		[Token(Token = "0x4008EA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_levelId;

		// Token: 0x04008EA8 RID: 36520
		[Token(Token = "0x4008EA8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_levelAsset;

		// Token: 0x04008EA9 RID: 36521
		[Token(Token = "0x4008EA9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_squadAsset;

		// Token: 0x04008EAA RID: 36522
		[Token(Token = "0x4008EAA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_plainTextConverter;

		// Token: 0x04008EAB RID: 36523
		[Token(Token = "0x4008EAB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_decrypter;

		// Token: 0x04008EAC RID: 36524
		[Token(Token = "0x4008EAC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04008EAD RID: 36525
		[Token(Token = "0x4008EAD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04008EAE RID: 36526
		[Token(Token = "0x4008EAE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04008EAF RID: 36527
		[Token(Token = "0x4008EAF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadLevel;

		// Token: 0x04008EB0 RID: 36528
		[Token(Token = "0x4008EB0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_BackToLogin;

		// Token: 0x04008EB1 RID: 36529
		[Token(Token = "0x4008EB1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x04008EB2 RID: 36530
		[Token(Token = "0x4008EB2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04008EB3 RID: 36531
		[Token(Token = "0x4008EB3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04008EB4 RID: 36532
		[Token(Token = "0x4008EB4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04008EB5 RID: 36533
		[Token(Token = "0x4008EB5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04008EB6 RID: 36534
		[Token(Token = "0x4008EB6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04008EB7 RID: 36535
		[Token(Token = "0x4008EB7")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RegistLuaCETest;

		// Token: 0x04008EB8 RID: 36536
		[Token(Token = "0x4008EB8")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_BlockOceanCatHead;

		// Token: 0x04008EB9 RID: 36537
		[Token(Token = "0x4008EB9")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_BlockOceanCatHeadInEditor;

		// Token: 0x04008EBA RID: 36538
		[Token(Token = "0x4008EBA")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CETestLuaLoader;

		// Token: 0x04008EBB RID: 36539
		[Token(Token = "0x4008EBB")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ConvertToFullPath;

		// Token: 0x04008EBC RID: 36540
		[Token(Token = "0x4008EBC")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CETestLuaHotfixLoader;

		// Token: 0x04008EBD RID: 36541
		[Token(Token = "0x4008EBD")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_AddBlockPageConfig;

		// Token: 0x04008EBE RID: 36542
		[Token(Token = "0x4008EBE")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_IsValidUILockTarget;

		// Token: 0x04008EBF RID: 36543
		[Token(Token = "0x4008EBF")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_IsValidPage;

		// Token: 0x04008EC0 RID: 36544
		[Token(Token = "0x4008EC0")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__InitUIEntryBlockMap;

		// Token: 0x04008EC1 RID: 36545
		[Token(Token = "0x4008EC1")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_LoadLuaFeature;
	}
}
