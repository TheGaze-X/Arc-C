using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x020074A4 RID: 29860
	[Token(Token = "0x20074A4")]
	public class Act29signCheckinItemViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A1CC RID: 172492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1CC")]
		[Address(RVA = "0x25B1DC0", Offset = "0x25B09C0", VA = "0x1825B1DC0")]
		public void Render(Act29signSpecialCheckinItemViewModel data, UnityAction<int> onNormalItemClicked, UnityAction onSpecialItemClicked)
		{
		}

		// Token: 0x0602A1CD RID: 172493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1CD")]
		[Address(RVA = "0x25B2240", Offset = "0x25B0E40", VA = "0x1825B2240")]
		public Act29signCheckinItemViewHolder()
		{
		}

		// Token: 0x0403C77C RID: 247676
		[Token(Token = "0x403C77C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403C77D RID: 247677
		[Token(Token = "0x403C77D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityCommonCheckinV2Item _normalItemPrefab;

		// Token: 0x0403C77E RID: 247678
		[Token(Token = "0x403C77E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act29signSpecialCheckinItem _specialItemPrefab;

		// Token: 0x0403C77F RID: 247679
		[Token(Token = "0x403C77F")]
		[FieldOffset(Offset = "0x30")]
		private ActivityCommonCheckinV2Item m_normalItem;

		// Token: 0x0403C780 RID: 247680
		[Token(Token = "0x403C780")]
		[FieldOffset(Offset = "0x38")]
		private Act29signSpecialCheckinItem m_specialItem;

		// Token: 0x0403C781 RID: 247681
		[Token(Token = "0x403C781")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C782 RID: 247682
		[Token(Token = "0x403C782")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
