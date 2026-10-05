using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007521 RID: 29985
	[Token(Token = "0x2007521")]
	public class RhineBattlePerformanceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700636A RID: 25450
		// (get) Token: 0x0602A40B RID: 173067 RVA: 0x000D7C40 File Offset: 0x000D5E40
		[Token(Token = "0x1700636A")]
		public Act25SideData.Act25sideTechType itemtype
		{
			[Token(Token = "0x602A40B")]
			[Address(RVA = "0x25EE8C0", Offset = "0x25ED4C0", VA = "0x1825EE8C0")]
			get
			{
				return Act25SideData.Act25sideTechType.TECH_1;
			}
		}

		// Token: 0x0602A40C RID: 173068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A40C")]
		[Address(RVA = "0x25EE490", Offset = "0x25ED090", VA = "0x1825EE490")]
		public void Render(RhineBattlePerformanceItemListModel itemList)
		{
		}

		// Token: 0x0602A40D RID: 173069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A40D")]
		[Address(RVA = "0x25EE7D0", Offset = "0x25ED3D0", VA = "0x1825EE7D0")]
		private Sprite _LoadItemIcon(string itemIconId)
		{
			return null;
		}

		// Token: 0x0602A40E RID: 173070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A40E")]
		[Address(RVA = "0x25EE860", Offset = "0x25ED460", VA = "0x1825EE860")]
		public RhineBattlePerformanceItemView()
		{
		}

		// Token: 0x0403CBE0 RID: 248800
		[Token(Token = "0x403CBE0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act25SideData.Act25sideTechType _itemType;

		// Token: 0x0403CBE1 RID: 248801
		[Token(Token = "0x403CBE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403CBE2 RID: 248802
		[Token(Token = "0x403CBE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemDesc;

		// Token: 0x0403CBE3 RID: 248803
		[Token(Token = "0x403CBE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("level1_item")]
		private Image _itemLevel1IconUnlock;

		// Token: 0x0403CBE4 RID: 248804
		[Token(Token = "0x403CBE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("level1_item")]
		private Image _itemLevel1IconLock;

		// Token: 0x0403CBE5 RID: 248805
		[Token(Token = "0x403CBE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("level1_item")]
		private GameObject _itemLevel1IconNew;

		// Token: 0x0403CBE6 RID: 248806
		[Token(Token = "0x403CBE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("level2_item")]
		private Image _itemLevel2IconUnlock;

		// Token: 0x0403CBE7 RID: 248807
		[Token(Token = "0x403CBE7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("level2_item")]
		private Image _itemLevel2IconLock;

		// Token: 0x0403CBE8 RID: 248808
		[Token(Token = "0x403CBE8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("level2_item")]
		private GameObject _itemLevel2IconNew;

		// Token: 0x0403CBE9 RID: 248809
		[Token(Token = "0x403CBE9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _itemUnlockObj;

		// Token: 0x0403CBEA RID: 248810
		[Token(Token = "0x403CBEA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemLockObj;

		// Token: 0x0403CBEB RID: 248811
		[Token(Token = "0x403CBEB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _itemRunning;

		// Token: 0x0403CBEC RID: 248812
		[Token(Token = "0x403CBEC")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403CBED RID: 248813
		[Token(Token = "0x403CBED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemtype;

		// Token: 0x0403CBEE RID: 248814
		[Token(Token = "0x403CBEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CBEF RID: 248815
		[Token(Token = "0x403CBEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadItemIcon;

		// Token: 0x0403CBF0 RID: 248816
		[Token(Token = "0x403CBF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
