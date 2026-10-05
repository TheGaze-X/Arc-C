using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001966 RID: 6502
	[Token(Token = "0x2001966")]
	public class DIYThemeGroupPanel : MonoBehaviour
	{
		// Token: 0x170012EE RID: 4846
		// (set) Token: 0x0600A357 RID: 41815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012EE")]
		public Action<IDIYItem> onFurnitureSelected
		{
			[Token(Token = "0x600A357")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x170012EF RID: 4847
		// (set) Token: 0x0600A358 RID: 41816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012EF")]
		public Action<DIYItemViewData> onFurnitureInfoPressed
		{
			[Token(Token = "0x600A358")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A359")]
		[Address(RVA = "0x31E52E0", Offset = "0x31E3EE0", VA = "0x1831E52E0")]
		private void _OnFurnitureSelected(IDIYItem item)
		{
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A35A")]
		[Address(RVA = "0x31E5300", Offset = "0x31E3F00", VA = "0x1831E5300")]
		private void _RemoveAllGroupView()
		{
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A35B")]
		[Address(RVA = "0x31E5BD0", Offset = "0x31E47D0", VA = "0x1831E5BD0")]
		private IEnumerator _SwitchFadeCoroutine(string themeId, [Optional] IFurnitureDataProvider furnitureDataProvider, [Optional] IDIYRoomModifierDataProvider modifierDataProvider, [Optional] IFurnitureProvider furnitureProvider, [Optional] IDIYRoomModifierProvider modifierProvider)
		{
			return null;
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A35C")]
		[Address(RVA = "0x31E5CC0", Offset = "0x31E48C0", VA = "0x1831E5CC0")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x0003F7E0 File Offset: 0x0003D9E0
		[Token(Token = "0x600A35D")]
		[Address(RVA = "0x31E52C0", Offset = "0x31E3EC0", VA = "0x1831E52C0")]
		private bool _OnFurnitureInfoPressed(DIYItemViewData data)
		{
			return default(bool);
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A35E")]
		[Address(RVA = "0x31E5650", Offset = "0x31E4250", VA = "0x1831E5650")]
		private void _SetupView(string themeId, [Optional] IFurnitureDataProvider furnitureDataProvider, [Optional] IDIYRoomModifierDataProvider modifierDataProvider, [Optional] IFurnitureProvider furnitureProvider, [Optional] IDIYRoomModifierProvider modifierProvider)
		{
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A35F")]
		[Address(RVA = "0x31E51A0", Offset = "0x31E3DA0", VA = "0x1831E51A0")]
		public void Setup(string themeId, [Optional] IFurnitureDataProvider furnitureDataProvider, [Optional] IDIYRoomModifierDataProvider modifierDataProvider, [Optional] IFurnitureProvider furnitureProvider, [Optional] IDIYRoomModifierProvider modifierProvider)
		{
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A360")]
		[Address(RVA = "0x31E6010", Offset = "0x31E4C10", VA = "0x1831E6010")]
		public DIYThemeGroupPanel()
		{
		}

		// Token: 0x040099C5 RID: 39365
		[Token(Token = "0x40099C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x040099C6 RID: 39366
		[Token(Token = "0x40099C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _positionHandler;

		// Token: 0x040099C7 RID: 39367
		[Token(Token = "0x40099C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _groupViewProto;

		// Token: 0x040099C8 RID: 39368
		[Token(Token = "0x40099C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040099C9 RID: 39369
		[Token(Token = "0x40099C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x040099CA RID: 39370
		[Token(Token = "0x40099CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IFurnitureGroupDataProvider m_groupDataProvider;

		// Token: 0x040099CB RID: 39371
		[Token(Token = "0x40099CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine m_fadeCoroutine;

		// Token: 0x040099CC RID: 39372
		[Token(Token = "0x40099CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<IDIYItem> m_onFurnitureSelected;

		// Token: 0x040099CD RID: 39373
		[Token(Token = "0x40099CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<DIYItemViewData> m_onFurnitureInfoPressed;
	}
}
