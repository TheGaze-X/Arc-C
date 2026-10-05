using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Runes;
using Torappu.ObjectPool;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200283C RID: 10300
	[Token(Token = "0x200283C")]
	public class LevelScriptManager
	{
		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06011272 RID: 70258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025C9")]
		public ObjectPool<ActionContext> actionContextPool
		{
			[Token(Token = "0x6011272")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06011273 RID: 70259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025CA")]
		public ObjectPool<ActionExecutor> actionExecutorPool
		{
			[Token(Token = "0x6011273")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06011274 RID: 70260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025CB")]
		public ObjectPool<EventActionTrigger> eventActionTriggerPool
		{
			[Token(Token = "0x6011274")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06011275 RID: 70261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025CC")]
		public ObjectPool<LevelScriptRuntime> levelScriptRuntimePool
		{
			[Token(Token = "0x6011275")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x06011276 RID: 70262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025CD")]
		public ObjectPool<EventParams> eventParamsPool
		{
			[Token(Token = "0x6011276")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06011277 RID: 70263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025CE")]
		public ObjectPool<ActionExecutor.LevelActionExecutorTracer> actionExecutorTracerPool
		{
			[Token(Token = "0x6011277")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011278 RID: 70264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011278")]
		[Address(RVA = "0x914AA0", Offset = "0x9136A0", VA = "0x180914AA0")]
		public void OnInit()
		{
		}

		// Token: 0x06011279 RID: 70265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011279")]
		[Address(RVA = "0x915130", Offset = "0x913D30", VA = "0x180915130")]
		public void OnRelease()
		{
		}

		// Token: 0x0601127A RID: 70266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601127A")]
		[Address(RVA = "0x914650", Offset = "0x913250", VA = "0x180914650")]
		public void LoadAndInitLevelScript(List<BattlePlayerData> playerDataList, LevelData levelData, IGameMode gameMode, Rune.RuneLevelExtraOutput runeExtraData)
		{
		}

		// Token: 0x0601127B RID: 70267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601127B")]
		[Address(RVA = "0x915300", Offset = "0x913F00", VA = "0x180915300")]
		public void Setup(LevelScriptData data)
		{
		}

		// Token: 0x0601127C RID: 70268 RVA: 0x000699A8 File Offset: 0x00067BA8
		[Token(Token = "0x601127C")]
		[Address(RVA = "0x9154B0", Offset = "0x9140B0", VA = "0x1809154B0")]
		public bool TryGetLevelScript(string levelScriptKey, out LevelScriptRuntime result, bool showWarning = false)
		{
			return default(bool);
		}

		// Token: 0x0601127D RID: 70269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601127D")]
		[Address(RVA = "0x915580", Offset = "0x914180", VA = "0x180915580")]
		public LevelScriptManager()
		{
		}

		// Token: 0x04013348 RID: 78664
		[Token(Token = "0x4013348")]
		private const int INITIAL_PRELOAD_CNT = 16;

		// Token: 0x04013349 RID: 78665
		[Token(Token = "0x4013349")]
		[FieldOffset(Offset = "0x10")]
		private ObjectPool<ActionContext> m_actionContextPool;

		// Token: 0x0401334A RID: 78666
		[Token(Token = "0x401334A")]
		[FieldOffset(Offset = "0x18")]
		private ObjectPool<ActionExecutor> m_actionExecutorPool;

		// Token: 0x0401334B RID: 78667
		[Token(Token = "0x401334B")]
		[FieldOffset(Offset = "0x20")]
		private ObjectPool<EventActionTrigger> m_eventActionTriggerPool;

		// Token: 0x0401334C RID: 78668
		[Token(Token = "0x401334C")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPool<LevelScriptRuntime> m_levelScriptRuntimePool;

		// Token: 0x0401334D RID: 78669
		[Token(Token = "0x401334D")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPool<EventParams> m_eventParamsPool;

		// Token: 0x0401334E RID: 78670
		[Token(Token = "0x401334E")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPool<ActionExecutor.LevelActionExecutorTracer> m_actionExecutorTracerPool;

		// Token: 0x0401334F RID: 78671
		[Token(Token = "0x401334F")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, LevelScriptRuntime> levelScriptRuntimeMap;

		// Token: 0x04013350 RID: 78672
		[Token(Token = "0x4013350")]
		[FieldOffset(Offset = "0x48")]
		public List<string> gatheredLevelScriptKeys;

		// Token: 0x04013351 RID: 78673
		[Token(Token = "0x4013351")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, LevelScriptData> levelScriptDataMap;
	}
}
