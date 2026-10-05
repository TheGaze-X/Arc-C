using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BDF RID: 7135
	[Token(Token = "0x2001BDF")]
	public class BuildingWorkshopBonusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B20B RID: 45579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B20B")]
		[Address(RVA = "0x32BBBF0", Offset = "0x32BA7F0", VA = "0x1832BBBF0")]
		public void UpdateStatus(IWorkshopSession curSession)
		{
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B20C")]
		[Address(RVA = "0x32BBD60", Offset = "0x32BA960", VA = "0x1832BBD60")]
		private void _UpdateBonusFromPlayerData(IWorkshopSession curSession)
		{
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B20D")]
		[Address(RVA = "0x32BC0C0", Offset = "0x32BACC0", VA = "0x1832BC0C0")]
		public BuildingWorkshopBonusView()
		{
		}

		// Token: 0x0400ACA4 RID: 44196
		[Token(Token = "0x400ACA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _listView;

		// Token: 0x0400ACA5 RID: 44197
		[Token(Token = "0x400ACA5")]
		[FieldOffset(Offset = "0x20")]
		private BuildingWorkshopBonusView.Adapter m_adapter;

		// Token: 0x0400ACA6 RID: 44198
		[Token(Token = "0x400ACA6")]
		[FieldOffset(Offset = "0x28")]
		private List<BonusItemModel> m_bonusList;

		// Token: 0x0400ACA7 RID: 44199
		[Token(Token = "0x400ACA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x0400ACA8 RID: 44200
		[Token(Token = "0x400ACA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateBonusFromPlayerData;

		// Token: 0x0400ACA9 RID: 44201
		[Token(Token = "0x400ACA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BE0 RID: 7136
		[Token(Token = "0x2001BE0")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B20E RID: 45582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B20E")]
			[Address(RVA = "0x32BAA00", Offset = "0x32B9600", VA = "0x1832BAA00")]
			public Adapter(BuildingWorkshopBonusView closure)
			{
			}

			// Token: 0x1700154A RID: 5450
			// (get) Token: 0x0600B20F RID: 45583 RVA: 0x00043F98 File Offset: 0x00042198
			[Token(Token = "0x1700154A")]
			public override int count
			{
				[Token(Token = "0x600B20F")]
				[Address(RVA = "0x32BAA80", Offset = "0x32B9680", VA = "0x1832BAA80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B210 RID: 45584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B210")]
			[Address(RVA = "0x32BA840", Offset = "0x32B9440", VA = "0x1832BA840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400ACAA RID: 44202
			[Token(Token = "0x400ACAA")]
			[FieldOffset(Offset = "0x20")]
			private BuildingWorkshopBonusView m_closure;

			// Token: 0x0400ACAB RID: 44203
			[Token(Token = "0x400ACAB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400ACAC RID: 44204
			[Token(Token = "0x400ACAC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400ACAD RID: 44205
			[Token(Token = "0x400ACAD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
