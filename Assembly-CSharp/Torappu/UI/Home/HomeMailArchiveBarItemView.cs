using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C35 RID: 19509
	[Token(Token = "0x2004C35")]
	public class HomeMailArchiveBarItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D4B3 RID: 119987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B3")]
		[Address(RVA = "0x16CF160", Offset = "0x16CDD60", VA = "0x1816CF160")]
		public void Render(HomeMailArchiveItemViewModel model, bool isFocus)
		{
		}

		// Token: 0x0601D4B4 RID: 119988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B4")]
		[Address(RVA = "0x16CF260", Offset = "0x16CDE60", VA = "0x1816CF260")]
		public void ResetStatus()
		{
		}

		// Token: 0x0601D4B5 RID: 119989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B5")]
		[Address(RVA = "0x16CF080", Offset = "0x16CDC80", VA = "0x1816CF080")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x0601D4B6 RID: 119990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B6")]
		[Address(RVA = "0x16CF2E0", Offset = "0x16CDEE0", VA = "0x1816CF2E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D4B7 RID: 119991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B7")]
		[Address(RVA = "0x16CF3C0", Offset = "0x16CDFC0", VA = "0x1816CF3C0")]
		public HomeMailArchiveBarItemView()
		{
		}

		// Token: 0x0402688D RID: 157837
		[Token(Token = "0x402688D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textYear;

		// Token: 0x0402688E RID: 157838
		[Token(Token = "0x402688E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402688F RID: 157839
		[Token(Token = "0x402688F")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween m_switchTween;

		// Token: 0x04026890 RID: 157840
		[Token(Token = "0x4026890")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04026891 RID: 157841
		[Token(Token = "0x4026891")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedYear;

		// Token: 0x04026892 RID: 157842
		[Token(Token = "0x4026892")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026893 RID: 157843
		[Token(Token = "0x4026893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026894 RID: 157844
		[Token(Token = "0x4026894")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x04026895 RID: 157845
		[Token(Token = "0x4026895")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x04026896 RID: 157846
		[Token(Token = "0x4026896")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026897 RID: 157847
		[Token(Token = "0x4026897")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
