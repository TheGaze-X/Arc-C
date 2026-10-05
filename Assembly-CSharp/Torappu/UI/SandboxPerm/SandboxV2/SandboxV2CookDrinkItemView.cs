using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004086 RID: 16518
	[Token(Token = "0x2004086")]
	public class SandboxV2CookDrinkItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x060198CC RID: 104652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198CD RID: 104653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF2")]
		public Func<int, int, bool> itemSelectEvent
		{
			[Token(Token = "0x60198CC")]
			[Address(RVA = "0x124EB00", Offset = "0x124D700", VA = "0x18124EB00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198CD")]
			[Address(RVA = "0x124EB60", Offset = "0x124D760", VA = "0x18124EB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060198CE RID: 104654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198CE")]
		[Address(RVA = "0x124E320", Offset = "0x124CF20", VA = "0x18124E320")]
		public void Render(int index, SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel model)
		{
		}

		// Token: 0x060198CF RID: 104655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198CF")]
		[Address(RVA = "0x124E450", Offset = "0x124D050", VA = "0x18124E450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060198D0 RID: 104656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198D0")]
		[Address(RVA = "0x124E730", Offset = "0x124D330", VA = "0x18124E730")]
		private void _OnAddEvent(int _)
		{
		}

		// Token: 0x060198D1 RID: 104657 RVA: 0x0009EA00 File Offset: 0x0009CC00
		[Token(Token = "0x60198D1")]
		[Address(RVA = "0x124E850", Offset = "0x124D450", VA = "0x18124E850")]
		private bool _OnLongPressAddEvent(int _)
		{
			return default(bool);
		}

		// Token: 0x060198D2 RID: 104658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198D2")]
		[Address(RVA = "0x124E980", Offset = "0x124D580", VA = "0x18124E980")]
		private void _OnMinusEvent(int _)
		{
		}

		// Token: 0x060198D3 RID: 104659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60198D3")]
		[Address(RVA = "0x124E3D0", Offset = "0x124CFD0", VA = "0x18124E3D0")]
		public GameObject Tutorial_GetButtonGO()
		{
			return null;
		}

		// Token: 0x060198D4 RID: 104660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198D4")]
		[Address(RVA = "0x124EAA0", Offset = "0x124D6A0", VA = "0x18124EAA0")]
		public SandboxV2CookDrinkItemView()
		{
		}

		// Token: 0x0401FDEC RID: 130540
		[Token(Token = "0x401FDEC")]
		private const int LONG_PRESS_STEP = 1;

		// Token: 0x0401FDED RID: 130541
		[Token(Token = "0x401FDED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x0401FDEE RID: 130542
		[Token(Token = "0x401FDEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardHolder;

		// Token: 0x0401FDEF RID: 130543
		[Token(Token = "0x401FDEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0401FDF0 RID: 130544
		[Token(Token = "0x401FDF0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x0401FDF1 RID: 130545
		[Token(Token = "0x401FDF1")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x0401FDF2 RID: 130546
		[Token(Token = "0x401FDF2")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedIndex;

		// Token: 0x0401FDF4 RID: 130548
		[Token(Token = "0x401FDF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x0401FDF5 RID: 130549
		[Token(Token = "0x401FDF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x0401FDF6 RID: 130550
		[Token(Token = "0x401FDF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FDF7 RID: 130551
		[Token(Token = "0x401FDF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FDF8 RID: 130552
		[Token(Token = "0x401FDF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAddEvent;

		// Token: 0x0401FDF9 RID: 130553
		[Token(Token = "0x401FDF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnLongPressAddEvent;

		// Token: 0x0401FDFA RID: 130554
		[Token(Token = "0x401FDFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnMinusEvent;

		// Token: 0x0401FDFB RID: 130555
		[Token(Token = "0x401FDFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Tutorial_GetButtonGO;

		// Token: 0x0401FDFC RID: 130556
		[Token(Token = "0x401FDFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
