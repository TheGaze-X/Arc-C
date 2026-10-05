using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E1B RID: 7707
	[Token(Token = "0x2001E1B")]
	public class AVG : SingletonMonoBehaviour<AVG>
	{
		// Token: 0x0600BE7B RID: 48763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE7B")]
		[Address(RVA = "0x33C09C0", Offset = "0x33BF5C0", VA = "0x1833C09C0")]
		private AVG.PerformanceStoryMiddleware _GetOrCreatePerformanceStory()
		{
			return null;
		}

		// Token: 0x0600BE7C RID: 48764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7C")]
		[Address(RVA = "0x33C04D0", Offset = "0x33BF0D0", VA = "0x1833C04D0")]
		public void StartStory(string storyId, [Optional] Action<Story> onStoryEnd)
		{
		}

		// Token: 0x0600BE7D RID: 48765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7D")]
		[Address(RVA = "0x33C0590", Offset = "0x33BF190", VA = "0x1833C0590")]
		public void StartStory(string storyId, Action<Story> onStoryEnd, Story.StoryParam param)
		{
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7E")]
		[Address(RVA = "0x33C0350", Offset = "0x33BEF50", VA = "0x1833C0350")]
		public void StartStory(TextAsset storyTextAsset, Action<Story> onStoryEnd, Story.StoryParam param)
		{
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7F")]
		[Address(RVA = "0x33C0290", Offset = "0x33BEE90", VA = "0x1833C0290")]
		public void StartStoryByString(string storyContent, [Optional] Action<Story> onStoryEnd)
		{
		}

		// Token: 0x0600BE80 RID: 48768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE80")]
		[Address(RVA = "0x33C0920", Offset = "0x33BF520", VA = "0x1833C0920")]
		public void StopStory()
		{
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE81")]
		[Address(RVA = "0x33BFD50", Offset = "0x33BE950", VA = "0x1833BFD50")]
		public void InterruptStory()
		{
		}

		// Token: 0x0600BE82 RID: 48770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE82")]
		[Address(RVA = "0x33C01F0", Offset = "0x33BEDF0", VA = "0x1833C01F0")]
		public void ReloadCommonData()
		{
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE83")]
		[Address(RVA = "0x33BFCF0", Offset = "0x33BE8F0", VA = "0x1833BFCF0")]
		public AVGVariableConfig GetVariableConfig()
		{
			return null;
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE84")]
		[Address(RVA = "0x33C12C0", Offset = "0x33BFEC0", VA = "0x1833C12C0")]
		private void _StartStoryInternal(TextAsset storyTextAsset, Story.StoryParam param, Action<Story> onStoryEnd)
		{
		}

		// Token: 0x0600BE85 RID: 48773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE85")]
		[Address(RVA = "0x33C0F90", Offset = "0x33BFB90", VA = "0x1833C0F90")]
		private void _StartStoryInternalByString(string storyContent, Story.StoryParam param, Action<Story> onStoryEnd, [Optional] string hintName)
		{
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE86")]
		[Address(RVA = "0x33C0B20", Offset = "0x33BF720", VA = "0x1833C0B20")]
		private void _OnStoryEnd(object arg)
		{
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE87")]
		[Address(RVA = "0x33C0DD0", Offset = "0x33BF9D0", VA = "0x1833C0DD0")]
		private void _OnStoryFailed(object arg)
		{
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE88")]
		[Address(RVA = "0x33BFDF0", Offset = "0x33BE9F0", VA = "0x1833BFDF0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE89")]
		[Address(RVA = "0x33C13D0", Offset = "0x33BFFD0", VA = "0x1833C13D0")]
		public AVG()
		{
		}

		// Token: 0x0400BF55 RID: 48981
		[Token(Token = "0x400BF55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEngine.Object _prefab;

		// Token: 0x0400BF56 RID: 48982
		[Token(Token = "0x400BF56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<Story> _onStoryEndCB;

		// Token: 0x0400BF57 RID: 48983
		[Token(Token = "0x400BF57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DirectAssetLoader _assetLoader;

		// Token: 0x0400BF58 RID: 48984
		[Token(Token = "0x400BF58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AVGVariableConfig _variableConfig;

		// Token: 0x0400BF59 RID: 48985
		[Token(Token = "0x400BF59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AVG.PerformanceStoryMiddleware m_performanceStory;

		// Token: 0x0400BF5A RID: 48986
		[Token(Token = "0x400BF5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetOrCreatePerformanceStory;

		// Token: 0x0400BF5B RID: 48987
		[Token(Token = "0x400BF5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartStory;

		// Token: 0x0400BF5C RID: 48988
		[Token(Token = "0x400BF5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_StartStory;

		// Token: 0x0400BF5D RID: 48989
		[Token(Token = "0x400BF5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix2_StartStory;

		// Token: 0x0400BF5E RID: 48990
		[Token(Token = "0x400BF5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartStoryByString;

		// Token: 0x0400BF5F RID: 48991
		[Token(Token = "0x400BF5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StopStory;

		// Token: 0x0400BF60 RID: 48992
		[Token(Token = "0x400BF60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InterruptStory;

		// Token: 0x0400BF61 RID: 48993
		[Token(Token = "0x400BF61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReloadCommonData;

		// Token: 0x0400BF62 RID: 48994
		[Token(Token = "0x400BF62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetVariableConfig;

		// Token: 0x0400BF63 RID: 48995
		[Token(Token = "0x400BF63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StartStoryInternal;

		// Token: 0x0400BF64 RID: 48996
		[Token(Token = "0x400BF64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StartStoryInternalByString;

		// Token: 0x0400BF65 RID: 48997
		[Token(Token = "0x400BF65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStoryEnd;

		// Token: 0x0400BF66 RID: 48998
		[Token(Token = "0x400BF66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnStoryFailed;

		// Token: 0x0400BF67 RID: 48999
		[Token(Token = "0x400BF67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BF68 RID: 49000
		[Token(Token = "0x400BF68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E1C RID: 7708
		[Token(Token = "0x2001E1C")]
		private class PerformanceStoryMiddleware : IHotfixable
		{
			// Token: 0x0600BE8A RID: 48778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE8A")]
			[Address(RVA = "0x33C8770", Offset = "0x33C7370", VA = "0x1833C8770")]
			public PerformanceStoryMiddleware(AVG context)
			{
			}

			// Token: 0x0600BE8B RID: 48779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE8B")]
			[Address(RVA = "0x33C7A50", Offset = "0x33C6650", VA = "0x1833C7A50")]
			public void StartStoryById(string storyId, Story.StoryParam param, Action<Story> onStoryEnd)
			{
			}

			// Token: 0x0600BE8C RID: 48780 RVA: 0x00046668 File Offset: 0x00044868
			[Token(Token = "0x600BE8C")]
			[Address(RVA = "0x33C8150", Offset = "0x33C6D50", VA = "0x1833C8150")]
			private bool _ShouldSyncStoryVariant(string storyId)
			{
				return default(bool);
			}

			// Token: 0x0600BE8D RID: 48781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE8D")]
			[Address(RVA = "0x33C8370", Offset = "0x33C6F70", VA = "0x1833C8370")]
			private void _StartStoryByIdImpl(string storyId, Story.StoryParam param, Action<Story> onStoryEnd)
			{
			}

			// Token: 0x0600BE8E RID: 48782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE8E")]
			[Address(RVA = "0x33C84A0", Offset = "0x33C70A0", VA = "0x1833C84A0")]
			private void _SyncPerformanceStoryStatus(string storyId, Action nextStep)
			{
			}

			// Token: 0x0600BE8F RID: 48783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600BE8F")]
			[Address(RVA = "0x33C7C40", Offset = "0x33C6840", VA = "0x1833C7C40")]
			private TextAsset _LoadStoryText(string originStoryId, out string spStoryId)
			{
				return null;
			}

			// Token: 0x0600BE90 RID: 48784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600BE90")]
			[Address(RVA = "0x33C7EB0", Offset = "0x33C6AB0", VA = "0x1833C7EB0")]
			private static StoryVariantData _SelectUnlockedVariant(string storyId)
			{
				return null;
			}

			// Token: 0x0400BF69 RID: 49001
			[Token(Token = "0x400BF69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private AVG m_context;

			// Token: 0x0400BF6A RID: 49002
			[Token(Token = "0x400BF6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400BF6B RID: 49003
			[Token(Token = "0x400BF6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_StartStoryById;

			// Token: 0x0400BF6C RID: 49004
			[Token(Token = "0x400BF6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__ShouldSyncStoryVariant;

			// Token: 0x0400BF6D RID: 49005
			[Token(Token = "0x400BF6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__StartStoryByIdImpl;

			// Token: 0x0400BF6E RID: 49006
			[Token(Token = "0x400BF6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__SyncPerformanceStoryStatus;

			// Token: 0x0400BF6F RID: 49007
			[Token(Token = "0x400BF6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__LoadStoryText;

			// Token: 0x0400BF70 RID: 49008
			[Token(Token = "0x400BF70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__SelectUnlockedVariant;
		}
	}
}
