using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.ObjectPool;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.Battle.DevelopTools.Tester
{
	// Token: 0x020028A6 RID: 10406
	[Token(Token = "0x20028A6")]
	public class TestBattleLoader : AbstractBattleLoader
	{
		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x060114EE RID: 70894 RVA: 0x0006A950 File Offset: 0x00068B50
		[Token(Token = "0x17002642")]
		public bool useSpecificScene
		{
			[Token(Token = "0x60114EE")]
			[Address(RVA = "0x932B90", Offset = "0x931790", VA = "0x180932B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060114EF RID: 70895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114EF")]
		[Address(RVA = "0x932940", Offset = "0x931540", VA = "0x180932940")]
		private IEnumerator _DoLoad()
		{
			return null;
		}

		// Token: 0x060114F0 RID: 70896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114F0")]
		[Address(RVA = "0x931D50", Offset = "0x930950", VA = "0x180931D50")]
		private void OnGUI()
		{
		}

		// Token: 0x060114F1 RID: 70897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114F1")]
		[Address(RVA = "0x932870", Offset = "0x931470", VA = "0x180932870")]
		private void Start()
		{
		}

		// Token: 0x060114F2 RID: 70898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114F2")]
		[Address(RVA = "0x9329F0", Offset = "0x9315F0", VA = "0x1809329F0")]
		public TestBattleLoader()
		{
		}

		// Token: 0x04013552 RID: 79186
		[Token(Token = "0x4013552")]
		private const string TEST_BATTLE_LOADER_SCENE_PATH = "Assets/Torappu/Scenes/Battle/BattleTester/test_battle_loader.unity";

		// Token: 0x04013553 RID: 79187
		[Token(Token = "0x4013553")]
		private const float SEARCH_DELAY = 0.2f;

		// Token: 0x04013554 RID: 79188
		[Token(Token = "0x4013554")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _useSpecificScene;

		// Token: 0x04013555 RID: 79189
		[Token(Token = "0x4013555")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inspect("useSpecificScene")]
		private string _nextScene;

		// Token: 0x04013556 RID: 79190
		[Token(Token = "0x4013556")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_levelKey")]
		private string _levelId;

		// Token: 0x04013557 RID: 79191
		[Token(Token = "0x4013557")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _externalSquadConfig;

		// Token: 0x04013558 RID: 79192
		[Token(Token = "0x4013558")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ResourceCollector _collector;

		// Token: 0x04013559 RID: 79193
		[Token(Token = "0x4013559")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AdvancedCharacterInst[] _slots;

		// Token: 0x0401355A RID: 79194
		[Token(Token = "0x401355A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isHard;

		// Token: 0x0401355B RID: 79195
		[Token(Token = "0x401355B")]
		[FieldOffset(Offset = "0x49")]
		private bool m_loading;

		// Token: 0x0401355C RID: 79196
		[Token(Token = "0x401355C")]
		[FieldOffset(Offset = "0x4C")]
		private float m_startLoadingTime;

		// Token: 0x0401355D RID: 79197
		[Token(Token = "0x401355D")]
		[FieldOffset(Offset = "0x50")]
		private List<PoolManager.ObjectConfig> m_configs;

		// Token: 0x0401355E RID: 79198
		[Token(Token = "0x401355E")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<string> m_resourceSet;

		// Token: 0x0401355F RID: 79199
		[Token(Token = "0x401355F")]
		[FieldOffset(Offset = "0x60")]
		private string m_oldLevel;

		// Token: 0x04013560 RID: 79200
		[Token(Token = "0x4013560")]
		[FieldOffset(Offset = "0x68")]
		private List<string> m_displayedLevel;

		// Token: 0x04013561 RID: 79201
		[Token(Token = "0x4013561")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[ToolsGroup]
		private string[] _levelJsonsPaths;

		// Token: 0x04013562 RID: 79202
		[Token(Token = "0x4013562")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ToolsGroup]
		private string[] _squadJsonsPaths;

		// Token: 0x04013563 RID: 79203
		[Token(Token = "0x4013563")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[ToolsGroup]
		private TextAsset _packedLevelsAndSquadsJson;

		// Token: 0x04013564 RID: 79204
		[Token(Token = "0x4013564")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[ToolsGroup]
		private string _actId;

		// Token: 0x04013565 RID: 79205
		[Token(Token = "0x4013565")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[ToolsGroup]
		private GameModeMeta.GameModeType _gameModeType;

		// Token: 0x04013566 RID: 79206
		[Token(Token = "0x4013566")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[ToolsGroup("Sandbox")]
		private string _weatherId;

		// Token: 0x04013567 RID: 79207
		[Token(Token = "0x4013567")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[ToolsGroup("Sandbox")]
		private SandboxV2SeasonType _seasonType;

		// Token: 0x04013568 RID: 79208
		[Token(Token = "0x4013568")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[ToolsGroup("Cooperate")]
		private GameModeFactory.CooperateGameMode.SubGameModeType _subGameModeType;

		// Token: 0x04013569 RID: 79209
		[Token(Token = "0x4013569")]
		[FieldOffset(Offset = "0xA8")]
		private TestBattleLoader.LevelAndJsonPack m_packedLevelsAndSquads;

		// Token: 0x0401356A RID: 79210
		[Token(Token = "0x401356A")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 m_levelScrollPosition;

		// Token: 0x0401356B RID: 79211
		[Token(Token = "0x401356B")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_squadScrollPosition;

		// Token: 0x0401356C RID: 79212
		[Token(Token = "0x401356C")]
		[FieldOffset(Offset = "0xC0")]
		private string m_selectedSquadPath;

		// Token: 0x0401356D RID: 79213
		[Token(Token = "0x401356D")]
		[FieldOffset(Offset = "0xC8")]
		private float m_serachDelay;

		// Token: 0x0401356E RID: 79214
		[Token(Token = "0x401356E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useSpecificScene;

		// Token: 0x0401356F RID: 79215
		[Token(Token = "0x401356F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoLoad;

		// Token: 0x04013570 RID: 79216
		[Token(Token = "0x4013570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x04013571 RID: 79217
		[Token(Token = "0x4013571")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04013572 RID: 79218
		[Token(Token = "0x4013572")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020028A7 RID: 10407
		[Token(Token = "0x20028A7")]
		private class LevelAndJsonPack
		{
			// Token: 0x060114F3 RID: 70899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60114F3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelAndJsonPack()
			{
			}

			// Token: 0x04013573 RID: 79219
			[Token(Token = "0x4013573")]
			[FieldOffset(Offset = "0x10")]
			public string[] levelPaths;

			// Token: 0x04013574 RID: 79220
			[Token(Token = "0x4013574")]
			[FieldOffset(Offset = "0x18")]
			public string[] squadPaths;
		}
	}
}
