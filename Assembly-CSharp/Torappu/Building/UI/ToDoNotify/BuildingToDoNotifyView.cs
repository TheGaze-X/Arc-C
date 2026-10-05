using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.ToDoNotify
{
	// Token: 0x02001C4F RID: 7247
	[Token(Token = "0x2001C4F")]
	public class BuildingToDoNotifyView : MonoBehaviour
	{
		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x0600B45A RID: 46170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B45B RID: 46171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015AB")]
		public Action<BuildingToDoNotifyItemModel> onClicked
		{
			[Token(Token = "0x600B45A")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600B45B")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B45C")]
		[Address(RVA = "0x32F4F40", Offset = "0x32F3B40", VA = "0x1832F4F40")]
		public void Render(BuildingToDoNotifyModel viewModel, BuildingToDoCategory selectedCategory, BuildingData.BuildingToDoType selectedType)
		{
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B45D")]
		[Address(RVA = "0x32F57A0", Offset = "0x32F43A0", VA = "0x1832F57A0")]
		private void _UpdateSelectedList(BuildingToDoNotifyModel viewModel, BuildingToDoCategory selectedCategory)
		{
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B45E")]
		[Address(RVA = "0x32F5530", Offset = "0x32F4130", VA = "0x1832F5530")]
		private void _InitSelectedList(BuildingToDoNotifyModel viewModel, BuildingToDoCategory selectedCategory)
		{
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B45F")]
		[Address(RVA = "0x32F5400", Offset = "0x32F4000", VA = "0x1832F5400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x00044688 File Offset: 0x00042888
		[Token(Token = "0x600B460")]
		[Address(RVA = "0x32F5760", Offset = "0x32F4360", VA = "0x1832F5760")]
		private bool _IsNotifyItemSelected(BuildingToDoNotifyItemModel model)
		{
			return default(bool);
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B461")]
		[Address(RVA = "0x32F5260", Offset = "0x32F3E60", VA = "0x1832F5260")]
		private void _HilightRoomSlots(List<string> slotIds)
		{
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B462")]
		[Address(RVA = "0x32F5D60", Offset = "0x32F4960", VA = "0x1832F5D60")]
		public BuildingToDoNotifyView()
		{
		}

		// Token: 0x0400B00C RID: 45068
		[Token(Token = "0x400B00C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layout;

		// Token: 0x0400B00D RID: 45069
		[Token(Token = "0x400B00D")]
		[FieldOffset(Offset = "0x20")]
		private BuildingToDoCategory m_selectedCategory;

		// Token: 0x0400B00E RID: 45070
		[Token(Token = "0x400B00E")]
		[FieldOffset(Offset = "0x24")]
		private BuildingData.BuildingToDoType m_selectedType;

		// Token: 0x0400B00F RID: 45071
		[Token(Token = "0x400B00F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, BuildingToDoNotifyItemModel> m_prefSelectedDict;

		// Token: 0x0400B010 RID: 45072
		[Token(Token = "0x400B010")]
		[FieldOffset(Offset = "0x30")]
		private List<BuildingToDoNotifyItemModel> m_selectedList;

		// Token: 0x0400B011 RID: 45073
		[Token(Token = "0x400B011")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0400B012 RID: 45074
		[Token(Token = "0x400B012")]
		[FieldOffset(Offset = "0x40")]
		private BuildingToDoNotifyView.ItemAdapter m_adapter;

		// Token: 0x0400B013 RID: 45075
		[Token(Token = "0x400B013")]
		[FieldOffset(Offset = "0x48")]
		private BuildingToDoNotifyView.ItemClickStatusData m_itemClickStatusData;

		// Token: 0x0400B014 RID: 45076
		[Token(Token = "0x400B014")]
		[FieldOffset(Offset = "0x50")]
		private List<string> m_selectedSlotIds;

		// Token: 0x02001C50 RID: 7248
		[Token(Token = "0x2001C50")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B463 RID: 46179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B463")]
			[Address(RVA = "0x32FA7C0", Offset = "0x32F93C0", VA = "0x1832FA7C0")]
			public ItemAdapter(BuildingToDoNotifyView closure)
			{
			}

			// Token: 0x170015AC RID: 5548
			// (get) Token: 0x0600B464 RID: 46180 RVA: 0x000446A0 File Offset: 0x000428A0
			[Token(Token = "0x170015AC")]
			public override int count
			{
				[Token(Token = "0x600B464")]
				[Address(RVA = "0x32FA840", Offset = "0x32F9440", VA = "0x1832FA840", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B465 RID: 46181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B465")]
			[Address(RVA = "0x32FA580", Offset = "0x32F9180", VA = "0x1832FA580", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B016 RID: 45078
			[Token(Token = "0x400B016")]
			[FieldOffset(Offset = "0x20")]
			private BuildingToDoNotifyView m_closure;

			// Token: 0x0400B017 RID: 45079
			[Token(Token = "0x400B017")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B018 RID: 45080
			[Token(Token = "0x400B018")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B019 RID: 45081
			[Token(Token = "0x400B019")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02001C51 RID: 7249
		[Token(Token = "0x2001C51")]
		public class ItemClickStatusData
		{
			// Token: 0x170015AD RID: 5549
			// (get) Token: 0x0600B466 RID: 46182 RVA: 0x000446B8 File Offset: 0x000428B8
			[Token(Token = "0x170015AD")]
			public bool canClickItem
			{
				[Token(Token = "0x600B466")]
				[Address(RVA = "0x3102D30", Offset = "0x3101930", VA = "0x183102D30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600B467 RID: 46183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B467")]
			[Address(RVA = "0x2873F20", Offset = "0x2872B20", VA = "0x182873F20")]
			public void AddAnimCount()
			{
			}

			// Token: 0x0600B468 RID: 46184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B468")]
			[Address(RVA = "0x318BD50", Offset = "0x318A950", VA = "0x18318BD50")]
			public void ReduceAnimCount()
			{
			}

			// Token: 0x0600B469 RID: 46185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B469")]
			[Address(RVA = "0x1AF4C90", Offset = "0x1AF3890", VA = "0x181AF4C90")]
			public void ResetAnimCount()
			{
			}

			// Token: 0x0600B46A RID: 46186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B46A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemClickStatusData()
			{
			}

			// Token: 0x0400B01A RID: 45082
			[Token(Token = "0x400B01A")]
			[FieldOffset(Offset = "0x10")]
			private int m_animPlayingCount;
		}
	}
}
