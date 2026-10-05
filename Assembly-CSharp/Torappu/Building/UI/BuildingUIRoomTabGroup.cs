using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B3B RID: 6971
	[Token(Token = "0x2001B3B")]
	public abstract class BuildingUIRoomTabGroup<GroupModel, GroupProperty> : DataBinder<GroupProperty> where GroupModel : IBasicRoomGroupModel where GroupProperty : DynamicBindProperty<GroupProperty, GroupModel>
	{
		// Token: 0x0600AF6D RID: 44909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF6D")]
		public override void OnValueChanged(GroupProperty property)
		{
		}

		// Token: 0x0600AF6E RID: 44910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF6E")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AF6F RID: 44911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF6F")]
		protected BuildingUIRoomTabGroup()
		{
		}

		// Token: 0x0400A90C RID: 43276
		[Token(Token = "0x400A90C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SimpleLayoutContent _tabContainer;

		// Token: 0x0400A90D RID: 43277
		[Token(Token = "0x400A90D")]
		[FieldOffset(Offset = "0x0")]
		private GroupModel m_groupModel;

		// Token: 0x0400A90E RID: 43278
		[Token(Token = "0x400A90E")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isInited;

		// Token: 0x0400A90F RID: 43279
		[Token(Token = "0x400A90F")]
		[FieldOffset(Offset = "0x0")]
		private BuildingUIRoomTabGroup<GroupModel, GroupProperty>.TabAdapter m_adapter;

		// Token: 0x0400A910 RID: 43280
		[Token(Token = "0x400A910")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public Action<string> onRoomSelected;

		// Token: 0x0400A911 RID: 43281
		[Token(Token = "0x400A911")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A912 RID: 43282
		[Token(Token = "0x400A912")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400A913 RID: 43283
		[Token(Token = "0x400A913")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B3C RID: 6972
		[Token(Token = "0x2001B3C")]
		private class TabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AF70 RID: 44912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF70")]
			public TabAdapter(BuildingUIRoomTabGroup<GroupModel, GroupProperty> closure)
			{
			}

			// Token: 0x170014CF RID: 5327
			// (get) Token: 0x0600AF71 RID: 44913 RVA: 0x000434A0 File Offset: 0x000416A0
			[Token(Token = "0x170014CF")]
			public override int count
			{
				[Token(Token = "0x600AF71")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AF72 RID: 44914 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AF72")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A914 RID: 43284
			[Token(Token = "0x400A914")]
			[FieldOffset(Offset = "0x0")]
			private BuildingUIRoomTabGroup<GroupModel, GroupProperty> m_closure;

			// Token: 0x0400A915 RID: 43285
			[Token(Token = "0x400A915")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A916 RID: 43286
			[Token(Token = "0x400A916")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A917 RID: 43287
			[Token(Token = "0x400A917")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
