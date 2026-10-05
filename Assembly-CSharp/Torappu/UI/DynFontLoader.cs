using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036C2 RID: 14018
	[Token(Token = "0x20036C2")]
	[RequireComponent(typeof(Text))]
	[ExecuteInEditMode]
	public class DynFontLoader : MonoBehaviour, ILayoutElement, IHotfixable
	{
		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x06016466 RID: 91238 RVA: 0x00090480 File Offset: 0x0008E680
		[Token(Token = "0x17003584")]
		public float minWidth
		{
			[Token(Token = "0x6016466")]
			[Address(RVA = "0xEB4480", Offset = "0xEB3080", VA = "0x180EB4480", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x06016467 RID: 91239 RVA: 0x00090498 File Offset: 0x0008E698
		[Token(Token = "0x17003585")]
		public float preferredWidth
		{
			[Token(Token = "0x6016467")]
			[Address(RVA = "0xEB4690", Offset = "0xEB3290", VA = "0x180EB4690", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x06016468 RID: 91240 RVA: 0x000904B0 File Offset: 0x0008E6B0
		[Token(Token = "0x17003586")]
		public float flexibleWidth
		{
			[Token(Token = "0x6016468")]
			[Address(RVA = "0xEB4260", Offset = "0xEB2E60", VA = "0x180EB4260", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x06016469 RID: 91241 RVA: 0x000904C8 File Offset: 0x0008E6C8
		[Token(Token = "0x17003587")]
		public float minHeight
		{
			[Token(Token = "0x6016469")]
			[Address(RVA = "0xEB43A0", Offset = "0xEB2FA0", VA = "0x180EB43A0", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0601646A RID: 91242 RVA: 0x000904E0 File Offset: 0x0008E6E0
		[Token(Token = "0x17003588")]
		public float preferredHeight
		{
			[Token(Token = "0x601646A")]
			[Address(RVA = "0xEB4550", Offset = "0xEB3150", VA = "0x180EB4550", Slot = "10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0601646B RID: 91243 RVA: 0x000904F8 File Offset: 0x0008E6F8
		[Token(Token = "0x17003589")]
		public float flexibleHeight
		{
			[Token(Token = "0x601646B")]
			[Address(RVA = "0xEB4180", Offset = "0xEB2D80", VA = "0x180EB4180", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0601646C RID: 91244 RVA: 0x00090510 File Offset: 0x0008E710
		[Token(Token = "0x1700358A")]
		public int layoutPriority
		{
			[Token(Token = "0x601646C")]
			[Address(RVA = "0xEB4340", Offset = "0xEB2F40", VA = "0x180EB4340", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601646D RID: 91245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601646D")]
		[Address(RVA = "0xEB3B70", Offset = "0xEB2770", VA = "0x180EB3B70", Slot = "4")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0601646E RID: 91246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601646E")]
		[Address(RVA = "0xEB3C40", Offset = "0xEB2840", VA = "0x180EB3C40", Slot = "5")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x0601646F RID: 91247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601646F")]
		[Address(RVA = "0xEB3DD0", Offset = "0xEB29D0", VA = "0x180EB3DD0")]
		private void Start()
		{
		}

		// Token: 0x06016470 RID: 91248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016470")]
		[Address(RVA = "0xEB3D70", Offset = "0xEB2970", VA = "0x180EB3D70")]
		public void ManualSetupFont()
		{
		}

		// Token: 0x06016471 RID: 91249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016471")]
		[Address(RVA = "0xEB3E30", Offset = "0xEB2A30", VA = "0x180EB3E30")]
		private void _SetupFont()
		{
		}

		// Token: 0x06016472 RID: 91250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016472")]
		[Address(RVA = "0xEB3D10", Offset = "0xEB2910", VA = "0x180EB3D10")]
		public static Font GetFontInEditor(string fontName)
		{
			return null;
		}

		// Token: 0x06016473 RID: 91251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016473")]
		[Address(RVA = "0xEB4120", Offset = "0xEB2D20", VA = "0x180EB4120")]
		public DynFontLoader()
		{
		}

		// Token: 0x0401ACA7 RID: 109735
		[Token(Token = "0x401ACA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string _fontName;

		// Token: 0x0401ACA8 RID: 109736
		[Token(Token = "0x401ACA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private bool _autoResume;

		// Token: 0x0401ACA9 RID: 109737
		[Token(Token = "0x401ACA9")]
		[FieldOffset(Offset = "0x28")]
		private Text m_text;

		// Token: 0x0401ACAA RID: 109738
		[Token(Token = "0x401ACAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0401ACAB RID: 109739
		[Token(Token = "0x401ACAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401ACAC RID: 109740
		[Token(Token = "0x401ACAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0401ACAD RID: 109741
		[Token(Token = "0x401ACAD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0401ACAE RID: 109742
		[Token(Token = "0x401ACAE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401ACAF RID: 109743
		[Token(Token = "0x401ACAF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0401ACB0 RID: 109744
		[Token(Token = "0x401ACB0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x0401ACB1 RID: 109745
		[Token(Token = "0x401ACB1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0401ACB2 RID: 109746
		[Token(Token = "0x401ACB2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0401ACB3 RID: 109747
		[Token(Token = "0x401ACB3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401ACB4 RID: 109748
		[Token(Token = "0x401ACB4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ManualSetupFont;

		// Token: 0x0401ACB5 RID: 109749
		[Token(Token = "0x401ACB5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetupFont;

		// Token: 0x0401ACB6 RID: 109750
		[Token(Token = "0x401ACB6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetFontInEditor;

		// Token: 0x0401ACB7 RID: 109751
		[Token(Token = "0x401ACB7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
