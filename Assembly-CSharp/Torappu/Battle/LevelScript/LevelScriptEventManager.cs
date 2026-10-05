using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002838 RID: 10296
	[Token(Token = "0x2002838")]
	public class LevelScriptEventManager : IHotfixable
	{
		// Token: 0x0601125B RID: 70235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601125B")]
		[Address(RVA = "0x912900", Offset = "0x911500", VA = "0x180912900")]
		public void RegisterTriggerFromLevelScript(string scriptPtr, List<ObjectPtr<EventActionTrigger>> triggerList, ActionContext context)
		{
		}

		// Token: 0x0601125C RID: 70236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601125C")]
		[Address(RVA = "0x914070", Offset = "0x912C70", VA = "0x180914070")]
		private void _OnAfterLevelScriptTriggerRegistered(string scriptPtr, ActionContext context)
		{
		}

		// Token: 0x0601125D RID: 70237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601125D")]
		[Address(RVA = "0x912E80", Offset = "0x911A80", VA = "0x180912E80")]
		public void UnregisterTriggerFromLevelScript(string scriptPtr, List<ObjectPtr<EventActionTrigger>> triggerList, ActionContext context)
		{
		}

		// Token: 0x0601125E RID: 70238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601125E")]
		[Address(RVA = "0x913F00", Offset = "0x912B00", VA = "0x180913F00")]
		private LevelScriptEventManager.LevelScriptTriggerRefSet _GetLevelScriptTriggerRefSet(string key)
		{
			return null;
		}

		// Token: 0x0601125F RID: 70239 RVA: 0x00069990 File Offset: 0x00067B90
		[Token(Token = "0x601125F")]
		[Address(RVA = "0x911C90", Offset = "0x910890", VA = "0x180911C90")]
		public bool HasLevelEventTrigger(GameLevelEvent e)
		{
			return default(bool);
		}

		// Token: 0x06011260 RID: 70240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011260")]
		[Address(RVA = "0x912180", Offset = "0x910D80", VA = "0x180912180")]
		public void RaiseLevelEvent(GameLevelEvent e, EventParams eventParams)
		{
		}

		// Token: 0x06011261 RID: 70241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011261")]
		[Address(RVA = "0x912540", Offset = "0x911140", VA = "0x180912540")]
		public void RaiseScriptEvent(string e, EventParams eventParams)
		{
		}

		// Token: 0x06011262 RID: 70242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011262")]
		[Address(RVA = "0x9120C0", Offset = "0x910CC0", VA = "0x1809120C0")]
		public void RaiseLevelEvent(string e, EventParams eventParams)
		{
		}

		// Token: 0x06011263 RID: 70243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011263")]
		[Address(RVA = "0x912040", Offset = "0x910C40", VA = "0x180912040")]
		public void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011264 RID: 70244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011264")]
		[Address(RVA = "0x913D00", Offset = "0x912900", VA = "0x180913D00")]
		private void _EventActionSequenceThreadLogicTick(FP deltaTime)
		{
		}

		// Token: 0x06011265 RID: 70245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011265")]
		[Address(RVA = "0x913900", Offset = "0x912500", VA = "0x180913900")]
		private void _DoCheckEventActionTriggerList(string eventKey, EventParams eventParams, List<ObjectPtr<EventActionTrigger>> triggerList)
		{
		}

		// Token: 0x06011266 RID: 70246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011266")]
		[Address(RVA = "0x913B00", Offset = "0x912700", VA = "0x180913B00")]
		private void _DoCheckEventActionTriggerList(uint eventKeyEnum, EventParams eventParams, List<ObjectPtr<EventActionTrigger>> triggerList)
		{
		}

		// Token: 0x06011267 RID: 70247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011267")]
		[Address(RVA = "0x911FE0", Offset = "0x910BE0", VA = "0x180911FE0")]
		public void OnRelease()
		{
		}

		// Token: 0x06011268 RID: 70248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011268")]
		[Address(RVA = "0x913400", Offset = "0x912000", VA = "0x180913400")]
		private void _ClearAllTrigger()
		{
		}

		// Token: 0x06011269 RID: 70249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011269")]
		[Address(RVA = "0x914490", Offset = "0x913090", VA = "0x180914490")]
		public LevelScriptEventManager()
		{
		}

		// Token: 0x04013333 RID: 78643
		[Token(Token = "0x4013333")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, LevelScriptEventManager.LevelScriptTriggerRefSet> m_levelScriptEventTriggerDict;

		// Token: 0x04013334 RID: 78644
		[Token(Token = "0x4013334")]
		[FieldOffset(Offset = "0x18")]
		private readonly LevelScriptEventManager.LevelEventTriggerDict m_levelEventTriggerDict;

		// Token: 0x04013335 RID: 78645
		[Token(Token = "0x4013335")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<ObjectPtr<EventActionTrigger>> m_eventActionExecutingList;

		// Token: 0x04013336 RID: 78646
		[Token(Token = "0x4013336")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterTriggerFromLevelScript;

		// Token: 0x04013337 RID: 78647
		[Token(Token = "0x4013337")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnAfterLevelScriptTriggerRegistered;

		// Token: 0x04013338 RID: 78648
		[Token(Token = "0x4013338")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UnregisterTriggerFromLevelScript;

		// Token: 0x04013339 RID: 78649
		[Token(Token = "0x4013339")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetLevelScriptTriggerRefSet;

		// Token: 0x0401333A RID: 78650
		[Token(Token = "0x401333A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HasLevelEventTrigger;

		// Token: 0x0401333B RID: 78651
		[Token(Token = "0x401333B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RaiseLevelEvent;

		// Token: 0x0401333C RID: 78652
		[Token(Token = "0x401333C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RaiseScriptEvent;

		// Token: 0x0401333D RID: 78653
		[Token(Token = "0x401333D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_RaiseLevelEvent;

		// Token: 0x0401333E RID: 78654
		[Token(Token = "0x401333E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401333F RID: 78655
		[Token(Token = "0x401333F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventActionSequenceThreadLogicTick;

		// Token: 0x04013340 RID: 78656
		[Token(Token = "0x4013340")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoCheckEventActionTriggerList;

		// Token: 0x04013341 RID: 78657
		[Token(Token = "0x4013341")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1__DoCheckEventActionTriggerList;

		// Token: 0x04013342 RID: 78658
		[Token(Token = "0x4013342")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRelease;

		// Token: 0x04013343 RID: 78659
		[Token(Token = "0x4013343")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearAllTrigger;

		// Token: 0x04013344 RID: 78660
		[Token(Token = "0x4013344")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002839 RID: 10297
		[Token(Token = "0x2002839")]
		public class LevelScriptTriggerRefSet
		{
			// Token: 0x0601126A RID: 70250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601126A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelScriptTriggerRefSet()
			{
			}

			// Token: 0x04013345 RID: 78661
			[Token(Token = "0x4013345")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, List<ObjectPtr<EventActionTrigger>>> scriptEventTriggerDict;
		}

		// Token: 0x0200283A RID: 10298
		[Token(Token = "0x200283A")]
		public class LevelEventTriggerDict : Dictionary<GameLevelEvent, LevelScriptEventManager.LevelEventTriggerDict.Set>
		{
			// Token: 0x0601126B RID: 70251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601126B")]
			[Address(RVA = "0x910500", Offset = "0x90F100", VA = "0x180910500")]
			public void RegisterFromLevelScript(GameLevelEvent eventKey, string scriptPtr, EventActionTrigger trigger)
			{
			}

			// Token: 0x0601126C RID: 70252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601126C")]
			[Address(RVA = "0x910890", Offset = "0x90F490", VA = "0x180910890")]
			public void UnregisterFromLevelScriptAll(string levelScriptPtr)
			{
			}

			// Token: 0x0601126D RID: 70253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601126D")]
			[Address(RVA = "0x910260", Offset = "0x90EE60", VA = "0x180910260")]
			public void ClearAll()
			{
			}

			// Token: 0x0601126E RID: 70254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601126E")]
			[Address(RVA = "0x910A80", Offset = "0x90F680", VA = "0x180910A80")]
			public LevelEventTriggerDict()
			{
			}

			// Token: 0x04013346 RID: 78662
			[Token(Token = "0x4013346")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, HashSet<GameLevelEvent>> levelScript2LevelEventSet;

			// Token: 0x0200283B RID: 10299
			[Token(Token = "0x200283B")]
			public class Set
			{
				// Token: 0x0601126F RID: 70255 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601126F")]
				[Address(RVA = "0x91A6E0", Offset = "0x9192E0", VA = "0x18091A6E0")]
				public List<ObjectPtr<EventActionTrigger>> TryGetValueFromLevelScriptDict(string scriptPtr)
				{
					return null;
				}

				// Token: 0x06011270 RID: 70256 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6011270")]
				[Address(RVA = "0x91A610", Offset = "0x919210", VA = "0x18091A610")]
				public void RemoveFromLevelScriptDict(string levelScriptPtr)
				{
				}

				// Token: 0x06011271 RID: 70257 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6011271")]
				[Address(RVA = "0x91A7C0", Offset = "0x9193C0", VA = "0x18091A7C0")]
				public Set()
				{
				}

				// Token: 0x04013347 RID: 78663
				[Token(Token = "0x4013347")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, List<ObjectPtr<EventActionTrigger>>> fromLevelScriptDict;
			}
		}
	}
}
