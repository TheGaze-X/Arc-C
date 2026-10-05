using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FAA RID: 24490
	[Token(Token = "0x2005FAA")]
	public class CharacterInfoRightProfUniEquipItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060236DC RID: 145116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236DC")]
		[Address(RVA = "0x1E07F60", Offset = "0x1E06B60", VA = "0x181E07F60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060236DD RID: 145117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236DD")]
		[Address(RVA = "0x1E07C80", Offset = "0x1E06880", VA = "0x181E07C80")]
		public void Render(CharacterUniEquipViewModel equipViewModel, string selectEquip)
		{
		}

		// Token: 0x060236DE RID: 145118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236DE")]
		[Address(RVA = "0x1E07BB0", Offset = "0x1E067B0", VA = "0x181E07BB0")]
		public void OnClick()
		{
		}

		// Token: 0x060236DF RID: 145119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236DF")]
		[Address(RVA = "0x1E08070", Offset = "0x1E06C70", VA = "0x181E08070")]
		public CharacterInfoRightProfUniEquipItem()
		{
		}

		// Token: 0x04030F55 RID: 200533
		[Token(Token = "0x4030F55")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04030F56 RID: 200534
		[Token(Token = "0x4030F56")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipItem;

		// Token: 0x04030F57 RID: 200535
		[Token(Token = "0x4030F57")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _clickBtnColor;

		// Token: 0x04030F58 RID: 200536
		[Token(Token = "0x4030F58")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x04030F59 RID: 200537
		[Token(Token = "0x4030F59")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cacheSelectPart;

		// Token: 0x04030F5A RID: 200538
		[Token(Token = "0x4030F5A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _isLocked;

		// Token: 0x04030F5B RID: 200539
		[Token(Token = "0x4030F5B")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onEquipClick;

		// Token: 0x04030F5C RID: 200540
		[Token(Token = "0x4030F5C")]
		[FieldOffset(Offset = "0x50")]
		private UICommonEquipTypeIcon m_equipItem;

		// Token: 0x04030F5D RID: 200541
		[Token(Token = "0x4030F5D")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04030F5E RID: 200542
		[Token(Token = "0x4030F5E")]
		[FieldOffset(Offset = "0x60")]
		private CharacterUniEquipViewModel m_cacheViewModel;

		// Token: 0x04030F5F RID: 200543
		[Token(Token = "0x4030F5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030F60 RID: 200544
		[Token(Token = "0x4030F60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F61 RID: 200545
		[Token(Token = "0x4030F61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04030F62 RID: 200546
		[Token(Token = "0x4030F62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
