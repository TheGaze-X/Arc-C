using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BDD RID: 19421
	[Token(Token = "0x2004BDD")]
	public class HomeCharRotationListSkinItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x0601D2FF RID: 119551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D300 RID: 119552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044A8")]
		public Action<string> onClicked
		{
			[Token(Token = "0x601D2FF")]
			[Address(RVA = "0x16C03D0", Offset = "0x16BEFD0", VA = "0x1816C03D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D300")]
			[Address(RVA = "0x16C0430", Offset = "0x16BF030", VA = "0x1816C0430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D301 RID: 119553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D301")]
		[Address(RVA = "0x16C01F0", Offset = "0x16BEDF0", VA = "0x1816C01F0")]
		public void Render(HomeCharRotationPresetSkinItemViewModel model, bool isSelected, bool isAssist)
		{
		}

		// Token: 0x0601D302 RID: 119554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D302")]
		[Address(RVA = "0x16C00E0", Offset = "0x16BECE0", VA = "0x1816C00E0")]
		public void OnClicked()
		{
		}

		// Token: 0x0601D303 RID: 119555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D303")]
		[Address(RVA = "0x16C0370", Offset = "0x16BEF70", VA = "0x1816C0370")]
		public HomeCharRotationListSkinItem()
		{
		}

		// Token: 0x04026504 RID: 156932
		[Token(Token = "0x4026504")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _notSelectedBg;

		// Token: 0x04026505 RID: 156933
		[Token(Token = "0x4026505")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedBg;

		// Token: 0x04026506 RID: 156934
		[Token(Token = "0x4026506")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _charHeadIcon;

		// Token: 0x04026507 RID: 156935
		[Token(Token = "0x4026507")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _assistDecor;

		// Token: 0x04026508 RID: 156936
		[Token(Token = "0x4026508")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _selectedOutline;

		// Token: 0x04026509 RID: 156937
		[Token(Token = "0x4026509")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _spDynIllustObj;

		// Token: 0x0402650B RID: 156939
		[Token(Token = "0x402650B")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedSkinTag;

		// Token: 0x0402650C RID: 156940
		[Token(Token = "0x402650C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402650D RID: 156941
		[Token(Token = "0x402650D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402650E RID: 156942
		[Token(Token = "0x402650E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402650F RID: 156943
		[Token(Token = "0x402650F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04026510 RID: 156944
		[Token(Token = "0x4026510")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
