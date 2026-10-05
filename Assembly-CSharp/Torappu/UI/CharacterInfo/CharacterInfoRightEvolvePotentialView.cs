using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F93 RID: 24467
	[Token(Token = "0x2005F93")]
	public class CharacterInfoRightEvolvePotentialView : CharacterInfoCommonObj, IHotfixable
	{
		// Token: 0x0602365A RID: 144986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602365A")]
		[Address(RVA = "0x1E03BF0", Offset = "0x1E027F0", VA = "0x181E03BF0", Slot = "6")]
		public override void AllHide()
		{
		}

		// Token: 0x0602365B RID: 144987 RVA: 0x000C0B70 File Offset: 0x000BED70
		[Token(Token = "0x602365B")]
		[Address(RVA = "0x1E03DB0", Offset = "0x1E029B0", VA = "0x181E03DB0", Slot = "4")]
		public override float GetHeight()
		{
			return 0f;
		}

		// Token: 0x0602365C RID: 144988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602365C")]
		[Address(RVA = "0x1E03C90", Offset = "0x1E02890", VA = "0x181E03C90", Slot = "5")]
		public override void ApplyViewModel(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x0602365D RID: 144989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602365D")]
		[Address(RVA = "0x1E04050", Offset = "0x1E02C50", VA = "0x181E04050")]
		private void _OnHide()
		{
		}

		// Token: 0x0602365E RID: 144990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602365E")]
		[Address(RVA = "0x1E040F0", Offset = "0x1E02CF0", VA = "0x181E040F0")]
		private void _OnShow()
		{
		}

		// Token: 0x0602365F RID: 144991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602365F")]
		[Address(RVA = "0x1E03FD0", Offset = "0x1E02BD0", VA = "0x181E03FD0")]
		public void OnStateClick()
		{
		}

		// Token: 0x06023660 RID: 144992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023660")]
		[Address(RVA = "0x1E03F10", Offset = "0x1E02B10", VA = "0x181E03F10")]
		public void OnClickHide()
		{
		}

		// Token: 0x06023661 RID: 144993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023661")]
		[Address(RVA = "0x1E03F70", Offset = "0x1E02B70", VA = "0x181E03F70")]
		public void OnClickShow()
		{
		}

		// Token: 0x06023662 RID: 144994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023662")]
		[Address(RVA = "0x1E04190", Offset = "0x1E02D90", VA = "0x181E04190")]
		public CharacterInfoRightEvolvePotentialView()
		{
		}

		// Token: 0x06023663 RID: 144995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023663")]
		[Address(RVA = "0x1DFEB20", Offset = "0x1DFD720", VA = "0x181DFEB20")]
		private void <>xLuaBaseProxy_AllHide()
		{
		}

		// Token: 0x04030E72 RID: 200306
		[Token(Token = "0x4030E72")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoHomeEvolveView _evolveView;

		// Token: 0x04030E73 RID: 200307
		[Token(Token = "0x4030E73")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterInfoHomePotentialView _potentialView;

		// Token: 0x04030E74 RID: 200308
		[Token(Token = "0x4030E74")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharacterInfoHomePotentialDetailView _detailView;

		// Token: 0x04030E75 RID: 200309
		[Token(Token = "0x4030E75")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _evolveButtonPanel;

		// Token: 0x04030E76 RID: 200310
		[Token(Token = "0x4030E76")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _transButtonPanel;

		// Token: 0x04030E77 RID: 200311
		[Token(Token = "0x4030E77")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x04030E78 RID: 200312
		[Token(Token = "0x4030E78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AllHide;

		// Token: 0x04030E79 RID: 200313
		[Token(Token = "0x4030E79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHeight;

		// Token: 0x04030E7A RID: 200314
		[Token(Token = "0x4030E7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyViewModel;

		// Token: 0x04030E7B RID: 200315
		[Token(Token = "0x4030E7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnHide;

		// Token: 0x04030E7C RID: 200316
		[Token(Token = "0x4030E7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnShow;

		// Token: 0x04030E7D RID: 200317
		[Token(Token = "0x4030E7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateClick;

		// Token: 0x04030E7E RID: 200318
		[Token(Token = "0x4030E7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickHide;

		// Token: 0x04030E7F RID: 200319
		[Token(Token = "0x4030E7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickShow;

		// Token: 0x04030E80 RID: 200320
		[Token(Token = "0x4030E80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
