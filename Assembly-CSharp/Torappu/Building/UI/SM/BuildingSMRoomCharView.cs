using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CB6 RID: 7350
	[Token(Token = "0x2001CB6")]
	public class BuildingSMRoomCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B636 RID: 46646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B636")]
		[Address(RVA = "0x3303E10", Offset = "0x3302A10", VA = "0x183303E10")]
		public void Render(StationRoomStructModel roomModel, StationCharStructModel charSlotModel, int position, bool isEditDormLock)
		{
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B637")]
		[Address(RVA = "0x33043F0", Offset = "0x3302FF0", VA = "0x1833043F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B638 RID: 46648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B638")]
		[Address(RVA = "0x33044D0", Offset = "0x33030D0", VA = "0x1833044D0")]
		private void _OnCharClicked(BuildingCharModel target, object param)
		{
		}

		// Token: 0x0600B639 RID: 46649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B639")]
		[Address(RVA = "0x3304660", Offset = "0x3303260", VA = "0x183304660")]
		public BuildingSMRoomCharView()
		{
		}

		// Token: 0x0400B306 RID: 45830
		[Token(Token = "0x400B306")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingCharAvatar _charAvatar;

		// Token: 0x0400B307 RID: 45831
		[Token(Token = "0x400B307")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dormLockBg;

		// Token: 0x0400B308 RID: 45832
		[Token(Token = "0x400B308")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _dormLockFrame;

		// Token: 0x0400B309 RID: 45833
		[Token(Token = "0x400B309")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _dormLockFrameActive;

		// Token: 0x0400B30A RID: 45834
		[Token(Token = "0x400B30A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _iconInPreQue;

		// Token: 0x0400B30B RID: 45835
		[Token(Token = "0x400B30B")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<BuildingCharModel, object> onCharClicked;

		// Token: 0x0400B30C RID: 45836
		[Token(Token = "0x400B30C")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0400B30D RID: 45837
		[Token(Token = "0x400B30D")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isEditMode;

		// Token: 0x0400B30E RID: 45838
		[Token(Token = "0x400B30E")]
		[FieldOffset(Offset = "0x4A")]
		private bool m_isDormLockInEditMode;

		// Token: 0x0400B30F RID: 45839
		[Token(Token = "0x400B30F")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_queIconFadeTween;

		// Token: 0x0400B310 RID: 45840
		[Token(Token = "0x400B310")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400B311 RID: 45841
		[Token(Token = "0x400B311")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B312 RID: 45842
		[Token(Token = "0x400B312")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B313 RID: 45843
		[Token(Token = "0x400B313")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnCharClicked;

		// Token: 0x0400B314 RID: 45844
		[Token(Token = "0x400B314")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
