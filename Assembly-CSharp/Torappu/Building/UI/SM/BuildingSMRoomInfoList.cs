using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CBE RID: 7358
	[Token(Token = "0x2001CBE")]
	public class BuildingSMRoomInfoList : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B658 RID: 46680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B658")]
		[Address(RVA = "0x3305F10", Offset = "0x3304B10", VA = "0x183305F10")]
		public void Render(StationRoomStructModel roomModel)
		{
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B659")]
		[Address(RVA = "0x33061A0", Offset = "0x3304DA0", VA = "0x1833061A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B65A")]
		[Address(RVA = "0x3306320", Offset = "0x3304F20", VA = "0x183306320")]
		public BuildingSMRoomInfoList()
		{
		}

		// Token: 0x0400B342 RID: 45890
		[Token(Token = "0x400B342")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemContainer;

		// Token: 0x0400B343 RID: 45891
		[Token(Token = "0x400B343")]
		[FieldOffset(Offset = "0x20")]
		private BuildingSMRoomInfoList.Adapter m_adapter;

		// Token: 0x0400B344 RID: 45892
		[Token(Token = "0x400B344")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0400B345 RID: 45893
		[Token(Token = "0x400B345")]
		[FieldOffset(Offset = "0x30")]
		private StationCharStructModel[] m_chars;

		// Token: 0x0400B346 RID: 45894
		[Token(Token = "0x400B346")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B347 RID: 45895
		[Token(Token = "0x400B347")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B348 RID: 45896
		[Token(Token = "0x400B348")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CBF RID: 7359
		[Token(Token = "0x2001CBF")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B65B RID: 46683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B65B")]
			[Address(RVA = "0x3303950", Offset = "0x3302550", VA = "0x183303950")]
			public Adapter(BuildingSMRoomInfoList closure)
			{
			}

			// Token: 0x170015E2 RID: 5602
			// (get) Token: 0x0600B65C RID: 46684 RVA: 0x00044EE0 File Offset: 0x000430E0
			[Token(Token = "0x170015E2")]
			public override int count
			{
				[Token(Token = "0x600B65C")]
				[Address(RVA = "0x3303AB0", Offset = "0x33026B0", VA = "0x183303AB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B65D RID: 46685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B65D")]
			[Address(RVA = "0x33036C0", Offset = "0x33022C0", VA = "0x1833036C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0600B65E RID: 46686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B65E")]
			[Address(RVA = "0x33034A0", Offset = "0x33020A0", VA = "0x1833034A0", Slot = "6")]
			public override void DestoryView(int position, GameObject view)
			{
			}

			// Token: 0x0600B65F RID: 46687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B65F")]
			[Address(RVA = "0x3303940", Offset = "0x3302540", VA = "0x183303940")]
			private void <>xLuaBaseProxy_DestoryView(int P0, GameObject P1)
			{
			}

			// Token: 0x0400B349 RID: 45897
			[Token(Token = "0x400B349")]
			[FieldOffset(Offset = "0x20")]
			private BuildingSMRoomInfoList m_closure;

			// Token: 0x0400B34A RID: 45898
			[Token(Token = "0x400B34A")]
			[FieldOffset(Offset = "0x28")]
			public List<BuildingSMRoomInfoItem> activeItems;

			// Token: 0x0400B34B RID: 45899
			[Token(Token = "0x400B34B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B34C RID: 45900
			[Token(Token = "0x400B34C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B34D RID: 45901
			[Token(Token = "0x400B34D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0400B34E RID: 45902
			[Token(Token = "0x400B34E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DestoryView;
		}
	}
}
