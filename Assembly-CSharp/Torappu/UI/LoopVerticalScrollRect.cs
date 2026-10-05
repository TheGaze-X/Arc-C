using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003987 RID: 14727
	[Token(Token = "0x2003987")]
	[AddComponentMenu("UI/Loop Vertical Scroll Rect", 51)]
	[DisallowMultipleComponent]
	public class LoopVerticalScrollRect : LoopScrollRect
	{
		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0601749C RID: 95388 RVA: 0x00095CA0 File Offset: 0x00093EA0
		[Token(Token = "0x170037BE")]
		protected override bool defaultHorizontal
		{
			[Token(Token = "0x601749C")]
			[Address(RVA = "0xFAB490", Offset = "0xFAA090", VA = "0x180FAB490", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0601749D RID: 95389 RVA: 0x00095CB8 File Offset: 0x00093EB8
		// (set) Token: 0x0601749E RID: 95390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037BF")]
		public override bool horizontal
		{
			[Token(Token = "0x601749D")]
			[Address(RVA = "0xFAB550", Offset = "0xFAA150", VA = "0x180FAB550", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601749E")]
			[Address(RVA = "0xFAB610", Offset = "0xFAA210", VA = "0x180FAB610", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0601749F RID: 95391 RVA: 0x00095CD0 File Offset: 0x00093ED0
		[Token(Token = "0x170037C0")]
		protected override bool defaultVertical
		{
			[Token(Token = "0x601749F")]
			[Address(RVA = "0xFAB4F0", Offset = "0xFAA0F0", VA = "0x180FAB4F0", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x060174A0 RID: 95392 RVA: 0x00095CE8 File Offset: 0x00093EE8
		// (set) Token: 0x060174A1 RID: 95393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037C1")]
		public override bool vertical
		{
			[Token(Token = "0x60174A0")]
			[Address(RVA = "0xFAB5B0", Offset = "0xFAA1B0", VA = "0x180FAB5B0", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60174A1")]
			[Address(RVA = "0xFAB680", Offset = "0xFAA280", VA = "0x180FAB680", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x060174A2 RID: 95394 RVA: 0x00095D00 File Offset: 0x00093F00
		[Token(Token = "0x60174A2")]
		[Address(RVA = "0xFAAD70", Offset = "0xFA9970", VA = "0x180FAAD70", Slot = "41")]
		protected override float GetSize(RectTransform item)
		{
			return 0f;
		}

		// Token: 0x060174A3 RID: 95395 RVA: 0x00095D18 File Offset: 0x00093F18
		[Token(Token = "0x60174A3")]
		[Address(RVA = "0xFAACF0", Offset = "0xFA98F0", VA = "0x180FAACF0", Slot = "42")]
		protected override float GetDimension(Vector2 vector)
		{
			return 0f;
		}

		// Token: 0x060174A4 RID: 95396 RVA: 0x00095D30 File Offset: 0x00093F30
		[Token(Token = "0x60174A4")]
		[Address(RVA = "0xFAAE70", Offset = "0xFA9A70", VA = "0x180FAAE70", Slot = "43")]
		protected override Vector2 GetVector(float value)
		{
			return default(Vector2);
		}

		// Token: 0x060174A5 RID: 95397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174A5")]
		[Address(RVA = "0xFAAC80", Offset = "0xFA9880", VA = "0x180FAAC80", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060174A6 RID: 95398 RVA: 0x00095D48 File Offset: 0x00093F48
		[Token(Token = "0x60174A6")]
		[Address(RVA = "0xFAAEF0", Offset = "0xFA9AF0", VA = "0x180FAAEF0", Slot = "44")]
		protected override bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
		{
			return default(bool);
		}

		// Token: 0x060174A7 RID: 95399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174A7")]
		[Address(RVA = "0xFAB420", Offset = "0xFAA020", VA = "0x180FAB420")]
		public LoopVerticalScrollRect()
		{
		}

		// Token: 0x060174A8 RID: 95400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174A8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060174A9 RID: 95401 RVA: 0x00095D60 File Offset: 0x00093F60
		[Token(Token = "0x60174A9")]
		[Address(RVA = "0xFA6550", Offset = "0xFA5150", VA = "0x180FA6550")]
		private bool <>xLuaBaseProxy_UpdateItems(Bounds P0, Bounds P1)
		{
			return default(bool);
		}

		// Token: 0x0401C1D6 RID: 115158
		[Token(Token = "0x401C1D6")]
		[FieldOffset(Offset = "0x1B0")]
		private bool m_horizontal;

		// Token: 0x0401C1D7 RID: 115159
		[Token(Token = "0x401C1D7")]
		[FieldOffset(Offset = "0x1B1")]
		private bool m_vertical;

		// Token: 0x0401C1D8 RID: 115160
		[Token(Token = "0x401C1D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_defaultHorizontal;

		// Token: 0x0401C1D9 RID: 115161
		[Token(Token = "0x401C1D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_horizontal;

		// Token: 0x0401C1DA RID: 115162
		[Token(Token = "0x401C1DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_horizontal;

		// Token: 0x0401C1DB RID: 115163
		[Token(Token = "0x401C1DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_defaultVertical;

		// Token: 0x0401C1DC RID: 115164
		[Token(Token = "0x401C1DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_vertical;

		// Token: 0x0401C1DD RID: 115165
		[Token(Token = "0x401C1DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_vertical;

		// Token: 0x0401C1DE RID: 115166
		[Token(Token = "0x401C1DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSize;

		// Token: 0x0401C1DF RID: 115167
		[Token(Token = "0x401C1DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDimension;

		// Token: 0x0401C1E0 RID: 115168
		[Token(Token = "0x401C1E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetVector;

		// Token: 0x0401C1E1 RID: 115169
		[Token(Token = "0x401C1E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C1E2 RID: 115170
		[Token(Token = "0x401C1E2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateItems;

		// Token: 0x0401C1E3 RID: 115171
		[Token(Token = "0x401C1E3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
