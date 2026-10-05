using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075E3 RID: 30179
	[Token(Token = "0x20075E3")]
	public class Act24sideMissionRewardPage : UIPage
	{
		// Token: 0x0602A7CB RID: 174027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7CB")]
		[Address(RVA = "0x262A000", Offset = "0x2628C00", VA = "0x18262A000", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0602A7CC RID: 174028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7CC")]
		[Address(RVA = "0x2629F20", Offset = "0x2628B20", VA = "0x182629F20", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x170063E9 RID: 25577
		// (get) Token: 0x0602A7CD RID: 174029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170063E9")]
		public Act24sideMissionRewardView view
		{
			[Token(Token = "0x602A7CD")]
			[Address(RVA = "0x262A180", Offset = "0x2628D80", VA = "0x18262A180")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A7CE RID: 174030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7CE")]
		[Address(RVA = "0x262A0C0", Offset = "0x2628CC0", VA = "0x18262A0C0")]
		private void _HideItemFloat()
		{
		}

		// Token: 0x0602A7CF RID: 174031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7CF")]
		[Address(RVA = "0x262A120", Offset = "0x2628D20", VA = "0x18262A120")]
		public Act24sideMissionRewardPage()
		{
		}

		// Token: 0x0602A7D0 RID: 174032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7D0")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x0602A7D1 RID: 174033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7D1")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0403D28E RID: 250510
		[Token(Token = "0x403D28E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Act24sideMissionRewardView _viewPrefab;

		// Token: 0x0403D28F RID: 250511
		[Token(Token = "0x403D28F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0403D290 RID: 250512
		[Token(Token = "0x403D290")]
		[FieldOffset(Offset = "0xE8")]
		private Act24sideMissionRewardView m_view;

		// Token: 0x0403D291 RID: 250513
		[Token(Token = "0x403D291")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403D292 RID: 250514
		[Token(Token = "0x403D292")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403D293 RID: 250515
		[Token(Token = "0x403D293")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_view;

		// Token: 0x0403D294 RID: 250516
		[Token(Token = "0x403D294")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideItemFloat;

		// Token: 0x0403D295 RID: 250517
		[Token(Token = "0x403D295")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075E4 RID: 30180
		[Token(Token = "0x20075E4")]
		public struct Params
		{
			// Token: 0x0403D296 RID: 250518
			[Token(Token = "0x403D296")]
			[FieldOffset(Offset = "0x0")]
			public List<UIItemViewModel> itemModels;

			// Token: 0x0403D297 RID: 250519
			[Token(Token = "0x403D297")]
			[FieldOffset(Offset = "0x8")]
			public string actId;
		}
	}
}
