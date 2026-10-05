using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200397C RID: 14716
	[Token(Token = "0x200397C")]
	[AddComponentMenu("UI/Loop Horizontal Scroll Rect", 50)]
	[DisallowMultipleComponent]
	public class LoopHorizontalScrollRect : LoopScrollRect
	{
		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x060173B8 RID: 95160 RVA: 0x00095610 File Offset: 0x00093810
		[Token(Token = "0x17003781")]
		protected override bool defaultHorizontal
		{
			[Token(Token = "0x60173B8")]
			[Address(RVA = "0xF8B7F0", Offset = "0xF8A3F0", VA = "0x180F8B7F0", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x060173B9 RID: 95161 RVA: 0x00095628 File Offset: 0x00093828
		// (set) Token: 0x060173BA RID: 95162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003782")]
		public override bool horizontal
		{
			[Token(Token = "0x60173B9")]
			[Address(RVA = "0xF8B8B0", Offset = "0xF8A4B0", VA = "0x180F8B8B0", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60173BA")]
			[Address(RVA = "0xF8B970", Offset = "0xF8A570", VA = "0x180F8B970", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x060173BB RID: 95163 RVA: 0x00095640 File Offset: 0x00093840
		[Token(Token = "0x17003783")]
		protected override bool defaultVertical
		{
			[Token(Token = "0x60173BB")]
			[Address(RVA = "0xF8B850", Offset = "0xF8A450", VA = "0x180F8B850", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x060173BC RID: 95164 RVA: 0x00095658 File Offset: 0x00093858
		// (set) Token: 0x060173BD RID: 95165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003784")]
		public override bool vertical
		{
			[Token(Token = "0x60173BC")]
			[Address(RVA = "0xF8B910", Offset = "0xF8A510", VA = "0x180F8B910", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60173BD")]
			[Address(RVA = "0xF8B9E0", Offset = "0xF8A5E0", VA = "0x180F8B9E0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x060173BE RID: 95166 RVA: 0x00095670 File Offset: 0x00093870
		[Token(Token = "0x60173BE")]
		[Address(RVA = "0xF8AEF0", Offset = "0xF89AF0", VA = "0x180F8AEF0", Slot = "41")]
		protected override float GetSize(RectTransform item)
		{
			return 0f;
		}

		// Token: 0x060173BF RID: 95167 RVA: 0x00095688 File Offset: 0x00093888
		[Token(Token = "0x60173BF")]
		[Address(RVA = "0xF8AE70", Offset = "0xF89A70", VA = "0x180F8AE70", Slot = "42")]
		protected override float GetDimension(Vector2 vector)
		{
			return 0f;
		}

		// Token: 0x060173C0 RID: 95168 RVA: 0x000956A0 File Offset: 0x000938A0
		[Token(Token = "0x60173C0")]
		[Address(RVA = "0xF8AFF0", Offset = "0xF89BF0", VA = "0x180F8AFF0", Slot = "43")]
		protected override Vector2 GetVector(float value)
		{
			return default(Vector2);
		}

		// Token: 0x060173C1 RID: 95169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173C1")]
		[Address(RVA = "0xF8AE00", Offset = "0xF89A00", VA = "0x180F8AE00", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060173C2 RID: 95170 RVA: 0x000956B8 File Offset: 0x000938B8
		[Token(Token = "0x60173C2")]
		[Address(RVA = "0xF8B0C0", Offset = "0xF89CC0", VA = "0x180F8B0C0", Slot = "44")]
		protected override bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
		{
			return default(bool);
		}

		// Token: 0x060173C3 RID: 95171 RVA: 0x000956D0 File Offset: 0x000938D0
		[Token(Token = "0x60173C3")]
		[Address(RVA = "0xF8B6C0", Offset = "0xF8A2C0", VA = "0x180F8B6C0")]
		private float _WrapOptionWithPreload(Func<float> singleAction)
		{
			return 0f;
		}

		// Token: 0x060173C4 RID: 95172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173C4")]
		[Address(RVA = "0xF8B780", Offset = "0xF8A380", VA = "0x180F8B780")]
		public LoopHorizontalScrollRect()
		{
		}

		// Token: 0x060173C5 RID: 95173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173C5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060173C6 RID: 95174 RVA: 0x000956E8 File Offset: 0x000938E8
		[Token(Token = "0x60173C6")]
		[Address(RVA = "0xF8B070", Offset = "0xF89C70", VA = "0x180F8B070")]
		private bool <>xLuaBaseProxy_UpdateItems(Bounds P0, Bounds P1)
		{
			return default(bool);
		}

		// Token: 0x0401C0B9 RID: 114873
		[Token(Token = "0x401C0B9")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Range(1f, 5f)]
		[Tooltip("Multiplier on the count of dynamic element loading")]
		private int _preloadMultiplier;

		// Token: 0x0401C0BA RID: 114874
		[Token(Token = "0x401C0BA")]
		[FieldOffset(Offset = "0x1B8")]
		public RectTransform _viewBoundImage;

		// Token: 0x0401C0BB RID: 114875
		[Token(Token = "0x401C0BB")]
		[FieldOffset(Offset = "0x1C0")]
		public RectTransform _contentBoundImage;

		// Token: 0x0401C0BC RID: 114876
		[Token(Token = "0x401C0BC")]
		[FieldOffset(Offset = "0x1C8")]
		private bool m_horizontal;

		// Token: 0x0401C0BD RID: 114877
		[Token(Token = "0x401C0BD")]
		[FieldOffset(Offset = "0x1C9")]
		private bool m_vertical;

		// Token: 0x0401C0BE RID: 114878
		[Token(Token = "0x401C0BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_defaultHorizontal;

		// Token: 0x0401C0BF RID: 114879
		[Token(Token = "0x401C0BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_horizontal;

		// Token: 0x0401C0C0 RID: 114880
		[Token(Token = "0x401C0C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_horizontal;

		// Token: 0x0401C0C1 RID: 114881
		[Token(Token = "0x401C0C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_defaultVertical;

		// Token: 0x0401C0C2 RID: 114882
		[Token(Token = "0x401C0C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_vertical;

		// Token: 0x0401C0C3 RID: 114883
		[Token(Token = "0x401C0C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_vertical;

		// Token: 0x0401C0C4 RID: 114884
		[Token(Token = "0x401C0C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSize;

		// Token: 0x0401C0C5 RID: 114885
		[Token(Token = "0x401C0C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDimension;

		// Token: 0x0401C0C6 RID: 114886
		[Token(Token = "0x401C0C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetVector;

		// Token: 0x0401C0C7 RID: 114887
		[Token(Token = "0x401C0C7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C0C8 RID: 114888
		[Token(Token = "0x401C0C8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateItems;

		// Token: 0x0401C0C9 RID: 114889
		[Token(Token = "0x401C0C9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__WrapOptionWithPreload;

		// Token: 0x0401C0CA RID: 114890
		[Token(Token = "0x401C0CA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
