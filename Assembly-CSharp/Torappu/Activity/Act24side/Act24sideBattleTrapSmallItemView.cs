using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007571 RID: 30065
	[Token(Token = "0x2007571")]
	public class Act24sideBattleTrapSmallItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A538 RID: 173368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A538")]
		[Address(RVA = "0x25F8390", Offset = "0x25F6F90", VA = "0x1825F8390")]
		public void Render(Act24sideBattleTrapItemViewModel model)
		{
		}

		// Token: 0x0602A539 RID: 173369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A539")]
		[Address(RVA = "0x25F8760", Offset = "0x25F7360", VA = "0x1825F8760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A53A RID: 173370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A53A")]
		[Address(RVA = "0x25F8870", Offset = "0x25F7470", VA = "0x1825F8870")]
		private void _PlaySelectAnim(bool isSelect, bool isFastMode)
		{
		}

		// Token: 0x0602A53B RID: 173371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A53B")]
		[Address(RVA = "0x25F8940", Offset = "0x25F7540", VA = "0x1825F8940")]
		public Act24sideBattleTrapSmallItemView()
		{
		}

		// Token: 0x0403CDEA RID: 249322
		[Token(Token = "0x403CDEA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgSelectIcon;

		// Token: 0x0403CDEB RID: 249323
		[Token(Token = "0x403CDEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgUnselectIcon;

		// Token: 0x0403CDEC RID: 249324
		[Token(Token = "0x403CDEC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objLock;

		// Token: 0x0403CDED RID: 249325
		[Token(Token = "0x403CDED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403CDEE RID: 249326
		[Token(Token = "0x403CDEE")]
		[FieldOffset(Offset = "0x40")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x0403CDEF RID: 249327
		[Token(Token = "0x403CDEF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403CDF0 RID: 249328
		[Token(Token = "0x403CDF0")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isSelectAnimFastMode;

		// Token: 0x0403CDF1 RID: 249329
		[Token(Token = "0x403CDF1")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedTrapId;

		// Token: 0x0403CDF2 RID: 249330
		[Token(Token = "0x403CDF2")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_finder;

		// Token: 0x0403CDF3 RID: 249331
		[Token(Token = "0x403CDF3")]
		[FieldOffset(Offset = "0x68")]
		private Act24sideBattleTrapItemViewModel.UnlockState m_cachedUnlockState;

		// Token: 0x0403CDF4 RID: 249332
		[Token(Token = "0x403CDF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CDF5 RID: 249333
		[Token(Token = "0x403CDF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CDF6 RID: 249334
		[Token(Token = "0x403CDF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlaySelectAnim;

		// Token: 0x0403CDF7 RID: 249335
		[Token(Token = "0x403CDF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
