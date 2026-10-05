using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075E1 RID: 30177
	[Token(Token = "0x20075E1")]
	public class Act24sideMissionRewardObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A7C4 RID: 174020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7C4")]
		[Address(RVA = "0x2629810", Offset = "0x2628410", VA = "0x182629810")]
		public void Render(UIItemViewModel itemViewModel, string actId, bool isComplete)
		{
		}

		// Token: 0x0602A7C5 RID: 174021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7C5")]
		[Address(RVA = "0x26296B0", Offset = "0x26282B0", VA = "0x1826296B0")]
		public void Render(Act24sideMeldingItemViewModel actItemViewModel, string actId, bool isComplete)
		{
		}

		// Token: 0x0602A7C6 RID: 174022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7C6")]
		[Address(RVA = "0x2629BB0", Offset = "0x26287B0", VA = "0x182629BB0")]
		public void Render(Act24sideMissionActItemViewModel actItemViewModel, string actId, bool isComplete)
		{
		}

		// Token: 0x0602A7C7 RID: 174023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7C7")]
		[Address(RVA = "0x2629DE0", Offset = "0x26289E0", VA = "0x182629DE0")]
		private void _RenderAct(bool isComplete)
		{
		}

		// Token: 0x0602A7C8 RID: 174024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7C8")]
		[Address(RVA = "0x2629EB0", Offset = "0x2628AB0", VA = "0x182629EB0")]
		public Act24sideMissionRewardObjView()
		{
		}

		// Token: 0x0403D27A RID: 250490
		[Token(Token = "0x403D27A")]
		private const float FULL_ALPHA = 1f;

		// Token: 0x0403D27B RID: 250491
		[Token(Token = "0x403D27B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act24sideMissionRewardActItemView _actItemView;

		// Token: 0x0403D27C RID: 250492
		[Token(Token = "0x403D27C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _normItemScale;

		// Token: 0x0403D27D RID: 250493
		[Token(Token = "0x403D27D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _containerAct;

		// Token: 0x0403D27E RID: 250494
		[Token(Token = "0x403D27E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _containerNorm;

		// Token: 0x0403D27F RID: 250495
		[Token(Token = "0x403D27F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normObj;

		// Token: 0x0403D280 RID: 250496
		[Token(Token = "0x403D280")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _completeFront;

		// Token: 0x0403D281 RID: 250497
		[Token(Token = "0x403D281")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _alpha;

		// Token: 0x0403D282 RID: 250498
		[Token(Token = "0x403D282")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _normGroup;

		// Token: 0x0403D283 RID: 250499
		[Token(Token = "0x403D283")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _actGroup;

		// Token: 0x0403D284 RID: 250500
		[Token(Token = "0x403D284")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _normItemNum;

		// Token: 0x0403D285 RID: 250501
		[Token(Token = "0x403D285")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_normCard;

		// Token: 0x0403D286 RID: 250502
		[Token(Token = "0x403D286")]
		[FieldOffset(Offset = "0x70")]
		private Act24sideMissionRewardActItemView m_actItemView;

		// Token: 0x0403D287 RID: 250503
		[Token(Token = "0x403D287")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D288 RID: 250504
		[Token(Token = "0x403D288")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0403D289 RID: 250505
		[Token(Token = "0x403D289")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix2_Render;

		// Token: 0x0403D28A RID: 250506
		[Token(Token = "0x403D28A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAct;

		// Token: 0x0403D28B RID: 250507
		[Token(Token = "0x403D28B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
