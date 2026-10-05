using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x0200491B RID: 18715
	[Token(Token = "0x200491B")]
	public class StoryReviewUnlockItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C378 RID: 115576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C378")]
		[Address(RVA = "0x15B6CA0", Offset = "0x15B58A0", VA = "0x1815B6CA0")]
		public void ApplyData(StoryReviewViewModel storyModel, bool outOfTime, [Optional] GameObject customPrefab)
		{
		}

		// Token: 0x0601C379 RID: 115577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C379")]
		[Address(RVA = "0x15B7BE0", Offset = "0x15B67E0", VA = "0x1815B7BE0")]
		private void _TryRenderCustomPart(GameObject prefab)
		{
		}

		// Token: 0x0601C37A RID: 115578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C37A")]
		[Address(RVA = "0x15B7A10", Offset = "0x15B6610", VA = "0x1815B7A10")]
		private void _SetUnlockCoinCount(int count)
		{
		}

		// Token: 0x0601C37B RID: 115579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C37B")]
		[Address(RVA = "0x15B7820", Offset = "0x15B6420", VA = "0x1815B7820")]
		private void _RenderItem(ItemData item)
		{
		}

		// Token: 0x0601C37C RID: 115580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C37C")]
		[Address(RVA = "0x15B71C0", Offset = "0x15B5DC0", VA = "0x1815B71C0")]
		private UIItemCard _EnsureItemCard(UIItemViewModel itemModel)
		{
			return null;
		}

		// Token: 0x0601C37D RID: 115581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C37D")]
		[Address(RVA = "0x15B7290", Offset = "0x15B5E90", VA = "0x1815B7290")]
		private string _GetUnlockCondition(PlayerStageState stageState)
		{
			return null;
		}

		// Token: 0x0601C37E RID: 115582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C37E")]
		[Address(RVA = "0x15B7390", Offset = "0x15B5F90", VA = "0x1815B7390")]
		private StoryReviewLockedInfoView _PickLockInfoByCulture()
		{
			return null;
		}

		// Token: 0x0601C37F RID: 115583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C37F")]
		[Address(RVA = "0x15B7150", Offset = "0x15B5D50", VA = "0x1815B7150")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x0601C380 RID: 115584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C380")]
		[Address(RVA = "0x15B7CC0", Offset = "0x15B68C0", VA = "0x1815B7CC0")]
		public StoryReviewUnlockItemView()
		{
		}

		// Token: 0x04024E6A RID: 151146
		[Token(Token = "0x4024E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _unlockContent;

		// Token: 0x04024E6B RID: 151147
		[Token(Token = "0x4024E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _coinConditionPanel;

		// Token: 0x04024E6C RID: 151148
		[Token(Token = "0x4024E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _stageConditionPanel;

		// Token: 0x04024E6D RID: 151149
		[Token(Token = "0x4024E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _unlockBtn;

		// Token: 0x04024E6E RID: 151150
		[Token(Token = "0x4024E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _customContainer;

		// Token: 0x04024E6F RID: 151151
		[Token(Token = "0x4024E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _originBg;

		// Token: 0x04024E70 RID: 151152
		[Token(Token = "0x4024E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Nullable")]
		private StoryReviewLockedInfoView _lockInfoTypeInland;

		// Token: 0x04024E71 RID: 151153
		[Token(Token = "0x4024E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Nullable")]
		private StoryReviewLockedInfoView _lockInfoTypeJp;

		// Token: 0x04024E72 RID: 151154
		[Token(Token = "0x4024E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Nullable")]
		private StoryReviewLockedInfoView _lockInfoTypeKr;

		// Token: 0x04024E73 RID: 151155
		[Token(Token = "0x4024E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Nullable")]
		private StoryReviewLockedInfoView _lockInfoTypeEn;

		// Token: 0x04024E74 RID: 151156
		[Token(Token = "0x4024E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Nullable")]
		private StoryReviewLockedInfoView _lockInfoTypeTc;

		// Token: 0x04024E75 RID: 151157
		[Token(Token = "0x4024E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onClicked;

		// Token: 0x04024E76 RID: 151158
		[Token(Token = "0x4024E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string m_cachedStoryReviewId;

		// Token: 0x04024E77 RID: 151159
		[Token(Token = "0x4024E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_cacheItemViewModel;

		// Token: 0x04024E78 RID: 151160
		[Token(Token = "0x4024E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private StoryReviewLockedInfoView m_lockInfoInUse;

		// Token: 0x04024E79 RID: 151161
		[Token(Token = "0x4024E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isLockInfoInited;

		// Token: 0x04024E7A RID: 151162
		[Token(Token = "0x4024E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04024E7B RID: 151163
		[Token(Token = "0x4024E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRenderCustomPart;

		// Token: 0x04024E7C RID: 151164
		[Token(Token = "0x4024E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetUnlockCoinCount;

		// Token: 0x04024E7D RID: 151165
		[Token(Token = "0x4024E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderItem;

		// Token: 0x04024E7E RID: 151166
		[Token(Token = "0x4024E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x04024E7F RID: 151167
		[Token(Token = "0x4024E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetUnlockCondition;

		// Token: 0x04024E80 RID: 151168
		[Token(Token = "0x4024E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PickLockInfoByCulture;

		// Token: 0x04024E81 RID: 151169
		[Token(Token = "0x4024E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x04024E82 RID: 151170
		[Token(Token = "0x4024E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
