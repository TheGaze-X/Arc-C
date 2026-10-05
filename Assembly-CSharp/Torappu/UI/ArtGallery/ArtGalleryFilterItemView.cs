using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200660B RID: 26123
	[Token(Token = "0x200660B")]
	public class ArtGalleryFilterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025869 RID: 153705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025869")]
		[Address(RVA = "0x2082340", Offset = "0x2080F40", VA = "0x182082340")]
		public void SetToggle(ArtGalleryFilterType currSelectedType)
		{
		}

		// Token: 0x0602586A RID: 153706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602586A")]
		[Address(RVA = "0x20821B0", Offset = "0x2080DB0", VA = "0x1820821B0")]
		public void OnFilterItemClicked()
		{
		}

		// Token: 0x0602586B RID: 153707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602586B")]
		[Address(RVA = "0x20823C0", Offset = "0x2080FC0", VA = "0x1820823C0")]
		private static string _GetFilterBtnName(ArtGalleryFilterType type)
		{
			return null;
		}

		// Token: 0x0602586C RID: 153708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602586C")]
		[Address(RVA = "0x2082470", Offset = "0x2081070", VA = "0x182082470")]
		public ArtGalleryFilterItemView()
		{
		}

		// Token: 0x04034B5B RID: 215899
		[Token(Token = "0x4034B5B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtGalleryFilterType _type;

		// Token: 0x04034B5C RID: 215900
		[Token(Token = "0x4034B5C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04034B5D RID: 215901
		[Token(Token = "0x4034B5D")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034B5E RID: 215902
		[Token(Token = "0x4034B5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetToggle;

		// Token: 0x04034B5F RID: 215903
		[Token(Token = "0x4034B5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFilterItemClicked;

		// Token: 0x04034B60 RID: 215904
		[Token(Token = "0x4034B60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetFilterBtnName;

		// Token: 0x04034B61 RID: 215905
		[Token(Token = "0x4034B61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
