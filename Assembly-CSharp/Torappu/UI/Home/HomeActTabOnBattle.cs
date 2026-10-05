using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BF4 RID: 19444
	[Token(Token = "0x2004BF4")]
	public class HomeActTabOnBattle : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D373 RID: 119667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D373")]
		[Address(RVA = "0x16BC2D0", Offset = "0x16BAED0", VA = "0x1816BC2D0")]
		public void Render(HomeActTabOnBattle.Options options)
		{
		}

		// Token: 0x0601D374 RID: 119668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D374")]
		[Address(RVA = "0x16BD5D0", Offset = "0x16BC1D0", VA = "0x1816BD5D0")]
		private void _UpdateEntryInfo()
		{
		}

		// Token: 0x0601D375 RID: 119669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D375")]
		[Address(RVA = "0x16BD7E0", Offset = "0x16BC3E0", VA = "0x1816BD7E0")]
		private void _UpdateUnlockStatus()
		{
		}

		// Token: 0x0601D376 RID: 119670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D376")]
		[Address(RVA = "0x16BCA10", Offset = "0x16BB610", VA = "0x1816BCA10")]
		private static Sprite _LoadEntryIcon(HomeActTabOnBattle.Options options, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601D377 RID: 119671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D377")]
		[Address(RVA = "0x16BC4B0", Offset = "0x16BB0B0", VA = "0x1816BC4B0")]
		private static Sprite _LoadActivityIcon(HomeActTabOnBattle.Options options, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601D378 RID: 119672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D378")]
		[Address(RVA = "0x16BC790", Offset = "0x16BB390", VA = "0x1816BC790")]
		private static Sprite _LoadCrisisV2Icon(HomeActTabOnBattle.Options options, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601D379 RID: 119673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D379")]
		[Address(RVA = "0x16BD0B0", Offset = "0x16BBCB0", VA = "0x1816BD0B0")]
		private static Sprite _LoadRoguelikeIcon(HomeActTabOnBattle.Options options, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601D37A RID: 119674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D37A")]
		[Address(RVA = "0x16BCE30", Offset = "0x16BBA30", VA = "0x1816BCE30")]
		private static Sprite _LoadMainlineIcon(HomeActTabOnBattle.Options options, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601D37B RID: 119675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D37B")]
		[Address(RVA = "0x16BD340", Offset = "0x16BBF40", VA = "0x1816BD340")]
		private static Sprite _LoadSandboxPermIcon(HomeActTabOnBattle.Options options, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601D37C RID: 119676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D37C")]
		[Address(RVA = "0x16BC1C0", Offset = "0x16BADC0", VA = "0x1816BC1C0")]
		public void EventOnActivtyClicked()
		{
		}

		// Token: 0x0601D37D RID: 119677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D37D")]
		[Address(RVA = "0x16BC230", Offset = "0x16BAE30", VA = "0x1816BC230")]
		public void EventOnLockViewClicked()
		{
		}

		// Token: 0x0601D37E RID: 119678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D37E")]
		[Address(RVA = "0x16BD890", Offset = "0x16BC490", VA = "0x1816BD890")]
		public HomeActTabOnBattle()
		{
		}

		// Token: 0x040265FF RID: 157183
		[Token(Token = "0x40265FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconActivity;

		// Token: 0x04026600 RID: 157184
		[Token(Token = "0x4026600")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement _layoutSize;

		// Token: 0x04026601 RID: 157185
		[Token(Token = "0x4026601")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _button;

		// Token: 0x04026602 RID: 157186
		[Token(Token = "0x4026602")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04026603 RID: 157187
		[Token(Token = "0x4026603")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<string> onClicked;

		// Token: 0x04026604 RID: 157188
		[Token(Token = "0x4026604")]
		[FieldOffset(Offset = "0x40")]
		private HomeActTabOnBattle.Options m_options;

		// Token: 0x04026605 RID: 157189
		[Token(Token = "0x4026605")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026606 RID: 157190
		[Token(Token = "0x4026606")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026607 RID: 157191
		[Token(Token = "0x4026607")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateEntryInfo;

		// Token: 0x04026608 RID: 157192
		[Token(Token = "0x4026608")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateUnlockStatus;

		// Token: 0x04026609 RID: 157193
		[Token(Token = "0x4026609")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadEntryIcon;

		// Token: 0x0402660A RID: 157194
		[Token(Token = "0x402660A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadActivityIcon;

		// Token: 0x0402660B RID: 157195
		[Token(Token = "0x402660B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadCrisisV2Icon;

		// Token: 0x0402660C RID: 157196
		[Token(Token = "0x402660C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadRoguelikeIcon;

		// Token: 0x0402660D RID: 157197
		[Token(Token = "0x402660D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadMainlineIcon;

		// Token: 0x0402660E RID: 157198
		[Token(Token = "0x402660E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadSandboxPermIcon;

		// Token: 0x0402660F RID: 157199
		[Token(Token = "0x402660F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnActivtyClicked;

		// Token: 0x04026610 RID: 157200
		[Token(Token = "0x4026610")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnLockViewClicked;

		// Token: 0x04026611 RID: 157201
		[Token(Token = "0x4026611")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BF5 RID: 19445
		[Token(Token = "0x2004BF5")]
		public enum EntryType
		{
			// Token: 0x04026613 RID: 157203
			[Token(Token = "0x4026613")]
			NONE,
			// Token: 0x04026614 RID: 157204
			[Token(Token = "0x4026614")]
			ACTIVITY,
			// Token: 0x04026615 RID: 157205
			[Token(Token = "0x4026615")]
			CRISIS,
			// Token: 0x04026616 RID: 157206
			[Token(Token = "0x4026616")]
			ROGUELIKE,
			// Token: 0x04026617 RID: 157207
			[Token(Token = "0x4026617")]
			MAINLINE,
			// Token: 0x04026618 RID: 157208
			[Token(Token = "0x4026618")]
			CRISISV2,
			// Token: 0x04026619 RID: 157209
			[Token(Token = "0x4026619")]
			SANDBOX_PERM
		}

		// Token: 0x02004BF6 RID: 19446
		[Token(Token = "0x2004BF6")]
		public struct Options
		{
			// Token: 0x0402661A RID: 157210
			[Token(Token = "0x402661A")]
			[FieldOffset(Offset = "0x0")]
			public string entryId;

			// Token: 0x0402661B RID: 157211
			[Token(Token = "0x402661B")]
			[FieldOffset(Offset = "0x8")]
			public HomeActTabOnBattle.EntryType type;

			// Token: 0x0402661C RID: 157212
			[Token(Token = "0x402661C")]
			[FieldOffset(Offset = "0xC")]
			public bool isUnlocked;

			// Token: 0x0402661D RID: 157213
			[Token(Token = "0x402661D")]
			[FieldOffset(Offset = "0xD")]
			public bool useMultiMode;

			// Token: 0x0402661E RID: 157214
			[Token(Token = "0x402661E")]
			[FieldOffset(Offset = "0x10")]
			public string actLockAlert;

			// Token: 0x0402661F RID: 157215
			[Token(Token = "0x402661F")]
			[FieldOffset(Offset = "0x18")]
			public string topicDisplayId;

			// Token: 0x04026620 RID: 157216
			[Token(Token = "0x4026620")]
			[FieldOffset(Offset = "0x20")]
			public long startTs;

			// Token: 0x04026621 RID: 157217
			[Token(Token = "0x4026621")]
			[FieldOffset(Offset = "0x28")]
			public bool isTrivial;

			// Token: 0x04026622 RID: 157218
			[Token(Token = "0x4026622")]
			[FieldOffset(Offset = "0x29")]
			public bool actUseGroup;
		}
	}
}
