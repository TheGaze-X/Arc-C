using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075DA RID: 30170
	[Token(Token = "0x20075DA")]
	public class Act24sideMissionRewardActItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A7A9 RID: 173993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A9")]
		[Address(RVA = "0x2628050", Offset = "0x2626C50", VA = "0x182628050")]
		public void Render(Act24sideMeldingItemViewModel actItemViewModel, string actId)
		{
		}

		// Token: 0x0602A7AA RID: 173994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7AA")]
		[Address(RVA = "0x2627E40", Offset = "0x2626A40", VA = "0x182627E40")]
		public void Render(Act24sideMissionActItemViewModel actItemViewModel, string actId)
		{
		}

		// Token: 0x0602A7AB RID: 173995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7AB")]
		[Address(RVA = "0x26282A0", Offset = "0x2626EA0", VA = "0x1826282A0")]
		public Act24sideMissionRewardActItemView()
		{
		}

		// Token: 0x0403D242 RID: 250434
		[Token(Token = "0x403D242")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act24sideMeldingItemView _prefabMeldingItem;

		// Token: 0x0403D243 RID: 250435
		[Token(Token = "0x403D243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _containerMelding;

		// Token: 0x0403D244 RID: 250436
		[Token(Token = "0x403D244")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelMelding;

		// Token: 0x0403D245 RID: 250437
		[Token(Token = "0x403D245")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelActItem;

		// Token: 0x0403D246 RID: 250438
		[Token(Token = "0x403D246")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x0403D247 RID: 250439
		[Token(Token = "0x403D247")]
		[FieldOffset(Offset = "0x40")]
		private Act24sideMeldingItemView m_meldingView;

		// Token: 0x0403D248 RID: 250440
		[Token(Token = "0x403D248")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_finder;

		// Token: 0x0403D249 RID: 250441
		[Token(Token = "0x403D249")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D24A RID: 250442
		[Token(Token = "0x403D24A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0403D24B RID: 250443
		[Token(Token = "0x403D24B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
