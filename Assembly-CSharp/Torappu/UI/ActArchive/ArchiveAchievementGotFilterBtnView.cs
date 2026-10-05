using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AEF RID: 27375
	[Token(Token = "0x2006AEF")]
	public class ArchiveAchievementGotFilterBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602724B RID: 160331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602724B")]
		[Address(RVA = "0x224F5F0", Offset = "0x224E1F0", VA = "0x18224F5F0")]
		public void SetState(ArchiveAchievementListGotFilterViewModel.GotType type)
		{
		}

		// Token: 0x0602724C RID: 160332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602724C")]
		[Address(RVA = "0x224F680", Offset = "0x224E280", VA = "0x18224F680")]
		public ArchiveAchievementGotFilterBtnView()
		{
		}

		// Token: 0x040375FC RID: 226812
		[Token(Token = "0x40375FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateFadeSwitcher _toggle;

		// Token: 0x040375FD RID: 226813
		[Token(Token = "0x40375FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveAchievementListGotFilterViewModel.GotType _type;

		// Token: 0x040375FE RID: 226814
		[Token(Token = "0x40375FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetState;

		// Token: 0x040375FF RID: 226815
		[Token(Token = "0x40375FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
