using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/StoryDB")]
	[Serializable]
	public class StoryDB : SimpleKVTable<StoryData, StoryDB>
	{
		// Token: 0x060061B0 RID: 25008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B0")]
		[Address(RVA = "0x1DF9DD0", Offset = "0x1DF89D0", VA = "0x181DF9DD0", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B1")]
		[Address(RVA = "0x1DF9B00", Offset = "0x1DF8700", VA = "0x181DF9B00")]
		public StoryData GetFirstStoryToTrig(StoryData.Trigger.TriggerType trigType, [Optional] string key, bool forceRepeatableAndOmitCommitAndStageCond = false, bool fetchEvenIfAvgIsRunning = false)
		{
			return null;
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0x1DF98F0", Offset = "0x1DF84F0", VA = "0x181DF98F0")]
		public StoryData GetFirstStoryForResPreference(StoryData.Trigger.TriggerType trigType, [Optional] string key)
		{
			return null;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0x1DF9A10", Offset = "0x1DF8610", VA = "0x181DF9A10")]
		public StoryData GetFirstStoryOnPageLoaded(AVGPageKey avgPage, bool forceRepeatableAndOmitCommit = false)
		{
			return null;
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B4")]
		[Address(RVA = "0x1DF96A0", Offset = "0x1DF82A0", VA = "0x181DF96A0")]
		public StoryData[] GetAllStoryToTrig(StoryData.Trigger.TriggerType trigType, [Optional] string key)
		{
			return null;
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x0002FDF0 File Offset: 0x0002DFF0
		[Token(Token = "0x60061B5")]
		[Address(RVA = "0x1DF9520", Offset = "0x1DF8120", VA = "0x181DF9520")]
		public bool CheckStoryWithoutConsiderTrigger(string storyId, bool allowMissing = false)
		{
			return default(bool);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B6")]
		[Address(RVA = "0x1DFA340", Offset = "0x1DF8F40", VA = "0x181DFA340")]
		private void _AddTrigger(StoryData.Trigger trigger, StoryData story)
		{
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x0002FE08 File Offset: 0x0002E008
		[Token(Token = "0x60061B7")]
		[Address(RVA = "0x1DFA5C0", Offset = "0x1DF91C0", VA = "0x181DFA5C0")]
		private bool _TryGetCandidates(StoryData.Trigger.TriggerType trigType, string key, out List<StoryData> candidates)
		{
			return default(bool);
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B8")]
		[Address(RVA = "0x1DFA870", Offset = "0x1DF9470", VA = "0x181DFA870")]
		public StoryDB()
		{
		}

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		private const char KEY_SEPARATOR = '|';

		// Token: 0x04002B66 RID: 11110
		[Token(Token = "0x4002B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<StoryData.Trigger, List<StoryData>> m_triggerToStories;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private List<StoryData>[] m_regexStories;

		// Token: 0x04002B68 RID: 11112
		[Token(Token = "0x4002B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B69 RID: 11113
		[Token(Token = "0x4002B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetFirstStoryToTrig;

		// Token: 0x04002B6A RID: 11114
		[Token(Token = "0x4002B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFirstStoryForResPreference;

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFirstStoryOnPageLoaded;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAllStoryToTrig;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckStoryWithoutConsiderTrigger;

		// Token: 0x04002B6E RID: 11118
		[Token(Token = "0x4002B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddTrigger;

		// Token: 0x04002B6F RID: 11119
		[Token(Token = "0x4002B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryGetCandidates;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
