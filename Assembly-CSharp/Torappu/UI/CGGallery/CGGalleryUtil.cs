using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FE5 RID: 24549
	[Token(Token = "0x2005FE5")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CGGalleryUtil
	{
		// Token: 0x060237A3 RID: 145315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237A3")]
		[Address(RVA = "0x1E1A230", Offset = "0x1E18E30", VA = "0x181E1A230")]
		public static IReadOnlyList<string> GetDisplaysOfStorySet(string storySetId)
		{
			return null;
		}

		// Token: 0x060237A4 RID: 145316 RVA: 0x000C0FA8 File Offset: 0x000BF1A8
		[Token(Token = "0x60237A4")]
		[Address(RVA = "0x1E1A110", Offset = "0x1E18D10", VA = "0x181E1A110")]
		public static bool CheckDisplayListHasUnlocked(IEnumerable<string> displayIds, string relatedActId)
		{
			return default(bool);
		}

		// Token: 0x060237A5 RID: 145317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237A5")]
		[Address(RVA = "0x1E1A300", Offset = "0x1E18F00", VA = "0x181E1A300")]
		public static IEnumerator<CGGalleryDisplayData> GetUnlockedDisplayEnumerator(IEnumerable<string> displayIds, string relatedActId)
		{
			return null;
		}

		// Token: 0x060237A6 RID: 145318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237A6")]
		[Address(RVA = "0x1E1A5C0", Offset = "0x1E191C0", VA = "0x181E1A5C0")]
		public static Sprite LoadCGThumbnail(ILoadAsset loader, string cgId)
		{
			return null;
		}

		// Token: 0x060237A7 RID: 145319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237A7")]
		[Address(RVA = "0x1E1A3D0", Offset = "0x1E18FD0", VA = "0x181E1A3D0")]
		public static Sprite LoadCGInFullSize(ILoadAsset loader, string cgId, CGGalleryCGSource source)
		{
			return null;
		}

		// Token: 0x060237A8 RID: 145320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237A8")]
		[Address(RVA = "0x1E19F80", Offset = "0x1E18B80", VA = "0x181E19F80")]
		public static void CalculateContentSizeFromSprite(Sprite sprite, float containerWidth, float containerHeight, out float contentWidth, out float contentHeight)
		{
		}

		// Token: 0x060237A9 RID: 145321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237A9")]
		[Address(RVA = "0x1E1A710", Offset = "0x1E19310", VA = "0x181E1A710")]
		private static Sprite _LoadSpriteFromHub(ILoadAsset loader, string hubPath, string spriteId)
		{
			return null;
		}

		// Token: 0x04031143 RID: 201027
		[Token(Token = "0x4031143")]
		public const string ENTRY_TRACK_ID = "entry";

		// Token: 0x04031144 RID: 201028
		[Token(Token = "0x4031144")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDisplaysOfStorySet;

		// Token: 0x04031145 RID: 201029
		[Token(Token = "0x4031145")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckDisplayListHasUnlocked;

		// Token: 0x04031146 RID: 201030
		[Token(Token = "0x4031146")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetUnlockedDisplayEnumerator;

		// Token: 0x04031147 RID: 201031
		[Token(Token = "0x4031147")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadCGThumbnail;

		// Token: 0x04031148 RID: 201032
		[Token(Token = "0x4031148")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadCGInFullSize;

		// Token: 0x04031149 RID: 201033
		[Token(Token = "0x4031149")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalculateContentSizeFromSprite;

		// Token: 0x0403114A RID: 201034
		[Token(Token = "0x403114A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromHub;

		// Token: 0x02005FE6 RID: 24550
		[Token(Token = "0x2005FE6")]
		private struct DisplayUnlockTraverser : IHotfixable, IDisposable
		{
			// Token: 0x060237AA RID: 145322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60237AA")]
			[Address(RVA = "0x1E24D30", Offset = "0x1E23930", VA = "0x181E24D30")]
			public DisplayUnlockTraverser(IEnumerable<string> displayIds, string relatedActId)
			{
			}

			// Token: 0x060237AB RID: 145323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60237AB")]
			[Address(RVA = "0x1E247A0", Offset = "0x1E233A0", VA = "0x181E247A0")]
			public IEnumerator<CGGalleryDisplayData> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060237AC RID: 145324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60237AC")]
			[Address(RVA = "0x1E24670", Offset = "0x1E23270", VA = "0x181E24670", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060237AD RID: 145325 RVA: 0x000C0FC0 File Offset: 0x000BF1C0
			[Token(Token = "0x60237AD")]
			[Address(RVA = "0x1E24A70", Offset = "0x1E23670", VA = "0x181E24A70")]
			private bool _UnlockedByStoryFlag(PlayerDataModel playerData, string storyId)
			{
				return default(bool);
			}

			// Token: 0x060237AE RID: 145326 RVA: 0x000C0FD8 File Offset: 0x000BF1D8
			[Token(Token = "0x60237AE")]
			[Address(RVA = "0x1E248C0", Offset = "0x1E234C0", VA = "0x181E248C0")]
			private bool _UnlockedByStageState(PlayerDataModel playerData, string stageId)
			{
				return default(bool);
			}

			// Token: 0x0403114B RID: 201035
			[Token(Token = "0x403114B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Dictionary<CGGalleryDisplayData, string> UNLOCK_RELATED_STORY_OF_DISPLAYS;

			// Token: 0x0403114C RID: 201036
			[Token(Token = "0x403114C")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Dictionary<string, string> REVIEW_ID_OF_STORIES;

			// Token: 0x0403114D RID: 201037
			[Token(Token = "0x403114D")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Dictionary<string, bool> READ_FLAG_OF_STORIES;

			// Token: 0x0403114E RID: 201038
			[Token(Token = "0x403114E")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<string> m_displayIds;

			// Token: 0x0403114F RID: 201039
			[Token(Token = "0x403114F")]
			[FieldOffset(Offset = "0x8")]
			private string m_relatedActId;

			// Token: 0x04031150 RID: 201040
			[Token(Token = "0x4031150")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031151 RID: 201041
			[Token(Token = "0x4031151")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetEnumerator;

			// Token: 0x04031152 RID: 201042
			[Token(Token = "0x4031152")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x04031153 RID: 201043
			[Token(Token = "0x4031153")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__UnlockedByStoryFlag;

			// Token: 0x04031154 RID: 201044
			[Token(Token = "0x4031154")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__UnlockedByStageState;
		}
	}
}
