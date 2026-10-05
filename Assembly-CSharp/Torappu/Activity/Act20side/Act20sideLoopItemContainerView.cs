using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200762E RID: 30254
	[Token(Token = "0x200762E")]
	public class Act20sideLoopItemContainerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A968 RID: 174440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A968")]
		[Address(RVA = "0x2658750", Offset = "0x2657350", VA = "0x182658750")]
		public void Init(Act20sideMilestoneStateBean stateBean)
		{
		}

		// Token: 0x0602A969 RID: 174441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A969")]
		[Address(RVA = "0x2658530", Offset = "0x2657130", VA = "0x182658530")]
		private Act20sideLoopItemGridView AddItem(RectTransform rect, int index = -1)
		{
			return null;
		}

		// Token: 0x0602A96A RID: 174442 RVA: 0x000D9230 File Offset: 0x000D7430
		[Token(Token = "0x602A96A")]
		[Address(RVA = "0x2658910", Offset = "0x2657510", VA = "0x182658910")]
		private int _GetElementNumPerRow()
		{
			return 0;
		}

		// Token: 0x0602A96B RID: 174443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A96B")]
		[Address(RVA = "0x2658A80", Offset = "0x2657680", VA = "0x182658A80")]
		private Sprite _GetItemSprite(int index)
		{
			return null;
		}

		// Token: 0x0602A96C RID: 174444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A96C")]
		[Address(RVA = "0x26588B0", Offset = "0x26574B0", VA = "0x1826588B0")]
		public void RefreshItem()
		{
		}

		// Token: 0x0602A96D RID: 174445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A96D")]
		[Address(RVA = "0x2658BE0", Offset = "0x26577E0", VA = "0x182658BE0")]
		public Act20sideLoopItemContainerView()
		{
		}

		// Token: 0x0403D504 RID: 251140
		[Token(Token = "0x403D504")]
		private const float LOOP_SPEED = 1f;

		// Token: 0x0403D505 RID: 251141
		[Token(Token = "0x403D505")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0403D506 RID: 251142
		[Token(Token = "0x403D506")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0403D507 RID: 251143
		[Token(Token = "0x403D507")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0403D508 RID: 251144
		[Token(Token = "0x403D508")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act20sideLoopItemGridView _item;

		// Token: 0x0403D509 RID: 251145
		[Token(Token = "0x403D509")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, List<string>> m_itemIdTable;

		// Token: 0x0403D50A RID: 251146
		[Token(Token = "0x403D50A")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_itemIdList;

		// Token: 0x0403D50B RID: 251147
		[Token(Token = "0x403D50B")]
		private const int ROW_NUM = 4;

		// Token: 0x0403D50C RID: 251148
		[Token(Token = "0x403D50C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403D50D RID: 251149
		[Token(Token = "0x403D50D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddItem;

		// Token: 0x0403D50E RID: 251150
		[Token(Token = "0x403D50E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetElementNumPerRow;

		// Token: 0x0403D50F RID: 251151
		[Token(Token = "0x403D50F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetItemSprite;

		// Token: 0x0403D510 RID: 251152
		[Token(Token = "0x403D510")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshItem;

		// Token: 0x0403D511 RID: 251153
		[Token(Token = "0x403D511")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
