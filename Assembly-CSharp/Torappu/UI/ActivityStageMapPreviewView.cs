using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200346F RID: 13423
	[Token(Token = "0x200346F")]
	public class ActivityStageMapPreviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x060156AE RID: 87726 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060156AF RID: 87727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700329D")]
		public Action onBtnCloseClicked
		{
			[Token(Token = "0x60156AE")]
			[Address(RVA = "0xDE04B0", Offset = "0xDDF0B0", VA = "0x180DE04B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60156AF")]
			[Address(RVA = "0xDE0510", Offset = "0xDDF110", VA = "0x180DE0510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060156B0 RID: 87728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156B0")]
		[Address(RVA = "0xDE0140", Offset = "0xDDED40", VA = "0x180DE0140")]
		public void OnClickClose()
		{
		}

		// Token: 0x060156B1 RID: 87729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156B1")]
		[Address(RVA = "0xDE0260", Offset = "0xDDEE60", VA = "0x180DE0260")]
		public void Show(string stageId, bool forceReload = false)
		{
		}

		// Token: 0x060156B2 RID: 87730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156B2")]
		[Address(RVA = "0xDE0030", Offset = "0xDDEC30", VA = "0x180DE0030")]
		private void InitIfNot()
		{
		}

		// Token: 0x060156B3 RID: 87731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156B3")]
		[Address(RVA = "0xDE0450", Offset = "0xDDF050", VA = "0x180DE0450")]
		public ActivityStageMapPreviewView()
		{
		}

		// Token: 0x04019A49 RID: 105033
		[Token(Token = "0x4019A49")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _blurPanel;

		// Token: 0x04019A4A RID: 105034
		[Token(Token = "0x4019A4A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDynImage _imgPreview;

		// Token: 0x04019A4B RID: 105035
		[Token(Token = "0x4019A4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _backPressRect;

		// Token: 0x04019A4D RID: 105037
		[Token(Token = "0x4019A4D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_Inited;

		// Token: 0x04019A4E RID: 105038
		[Token(Token = "0x4019A4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnCloseClicked;

		// Token: 0x04019A4F RID: 105039
		[Token(Token = "0x4019A4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnCloseClicked;

		// Token: 0x04019A50 RID: 105040
		[Token(Token = "0x4019A50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickClose;

		// Token: 0x04019A51 RID: 105041
		[Token(Token = "0x4019A51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04019A52 RID: 105042
		[Token(Token = "0x4019A52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04019A53 RID: 105043
		[Token(Token = "0x4019A53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
