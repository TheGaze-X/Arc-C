using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001962 RID: 6498
	[Token(Token = "0x2001962")]
	public class DIYThemeGroupItemView : MonoBehaviour
	{
		// Token: 0x0600A345 RID: 41797 RVA: 0x0003F750 File Offset: 0x0003D950
		[Token(Token = "0x600A345")]
		[Address(RVA = "0x31E4F50", Offset = "0x31E3B50", VA = "0x1831E4F50")]
		private bool _OnFurnitureSelected(DIYItemViewData data)
		{
			return default(bool);
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A346")]
		[Address(RVA = "0x31E4EE0", Offset = "0x31E3AE0", VA = "0x1831E4EE0")]
		private void _OnFurnitureSelected(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A347")]
		[Address(RVA = "0x31E4FD0", Offset = "0x31E3BD0", VA = "0x1831E4FD0")]
		private void _OnInfoButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A348")]
		[Address(RVA = "0x31E41D0", Offset = "0x31E2DD0", VA = "0x1831E41D0")]
		public void Setup(IFurnitureDataProvider furnitureDataProvider, IDIYRoomModifierDataProvider modifierDataProvider, IFurnitureProvider furnitureProvider, IDIYRoomModifierProvider modifierProvider, DIYThemeGroupItemModel model, Action<DIYItemViewData> infoCallback)
		{
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A349")]
		[Address(RVA = "0x31E4FF0", Offset = "0x31E3BF0", VA = "0x1831E4FF0")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x0003F768 File Offset: 0x0003D968
		[Token(Token = "0x600A34A")]
		[Address(RVA = "0x31E4E70", Offset = "0x31E3A70", VA = "0x1831E4E70")]
		private static int _GetFurnitureTotalCount(string furnitureId, IFurnitureStorage storage)
		{
			return 0;
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A34B")]
		[Address(RVA = "0x31E5110", Offset = "0x31E3D10", VA = "0x1831E5110")]
		public DIYThemeGroupItemView()
		{
		}

		// Token: 0x040099B9 RID: 39353
		[Token(Token = "0x40099B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _groupNameLabel;

		// Token: 0x040099BA RID: 39354
		[Token(Token = "0x40099BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _furnitureViewProto;

		// Token: 0x040099BB RID: 39355
		[Token(Token = "0x40099BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _furnitureListContainer;

		// Token: 0x040099BC RID: 39356
		[Token(Token = "0x40099BC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _marginSize;

		// Token: 0x040099BD RID: 39357
		[Token(Token = "0x40099BD")]
		[FieldOffset(Offset = "0x38")]
		private DIYThemeGroupItemModel m_model;

		// Token: 0x040099BE RID: 39358
		[Token(Token = "0x40099BE")]
		[FieldOffset(Offset = "0x40")]
		private List<FurnitureItemView> m_furnitureViewList;

		// Token: 0x040099BF RID: 39359
		[Token(Token = "0x40099BF")]
		[FieldOffset(Offset = "0x48")]
		private Action<DIYItemViewData> m_infoCallback;
	}
}
