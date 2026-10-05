using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x02002038 RID: 8248
	[Token(Token = "0x2002038")]
	public class FxSpineHighlight : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600CB3E RID: 52030 RVA: 0x00049818 File Offset: 0x00047A18
		[Token(Token = "0x1700180F")]
		private bool m_isDirty
		{
			[Token(Token = "0x600CB3E")]
			[Address(RVA = "0x34C4160", Offset = "0x34C2D60", VA = "0x1834C4160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB3F")]
		[Address(RVA = "0x34C3B00", Offset = "0x34C2700", VA = "0x1834C3B00")]
		private void _InitParams()
		{
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB40")]
		[Address(RVA = "0x34C3B80", Offset = "0x34C2780", VA = "0x1834C3B80")]
		private void _ResetParams()
		{
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB41")]
		[Address(RVA = "0x34C3DB0", Offset = "0x34C29B0", VA = "0x1834C3DB0")]
		private void _SetParams()
		{
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB42")]
		[Address(RVA = "0x34C36F0", Offset = "0x34C22F0", VA = "0x1834C36F0")]
		private void Awake()
		{
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB43")]
		[Address(RVA = "0x34C3A10", Offset = "0x34C2610", VA = "0x1834C3A10")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB44")]
		[Address(RVA = "0x34C39A0", Offset = "0x34C25A0", VA = "0x1834C39A0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB45")]
		[Address(RVA = "0x34C3A80", Offset = "0x34C2680", VA = "0x1834C3A80")]
		private void Update()
		{
		}

		// Token: 0x0600CB46 RID: 52038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB46")]
		[Address(RVA = "0x34C40D0", Offset = "0x34C2CD0", VA = "0x1834C40D0")]
		public FxSpineHighlight()
		{
		}

		// Token: 0x0400D539 RID: 54585
		[Token(Token = "0x400D539")]
		private const string DEFAULT_SPINE_HIGHLIGHT_SHADER_NAME = "Torappu/Spine/L2D/Skeleton-Highlight-Add";

		// Token: 0x0400D53A RID: 54586
		[Token(Token = "0x400D53A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x0400D53B RID: 54587
		[Token(Token = "0x400D53B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _highlightTintColor;

		// Token: 0x0400D53C RID: 54588
		[Token(Token = "0x400D53C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Texture2D _highlightTex;

		// Token: 0x0400D53D RID: 54589
		[Token(Token = "0x400D53D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 5f)]
		private float _highlightAmount;

		// Token: 0x0400D53E RID: 54590
		[Token(Token = "0x400D53E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Shader _replaceShader;

		// Token: 0x0400D53F RID: 54591
		[Token(Token = "0x400D53F")]
		[FieldOffset(Offset = "0x50")]
		private Shader m_originShader;

		// Token: 0x0400D540 RID: 54592
		[Token(Token = "0x400D540")]
		[FieldOffset(Offset = "0x58")]
		private Shader m_replaceShader;

		// Token: 0x0400D541 RID: 54593
		[Token(Token = "0x400D541")]
		[FieldOffset(Offset = "0x60")]
		private Material[] m_spineMaterials;

		// Token: 0x0400D542 RID: 54594
		[Token(Token = "0x400D542")]
		[FieldOffset(Offset = "0x68")]
		private Color m_originHihglightColor;

		// Token: 0x0400D543 RID: 54595
		[Token(Token = "0x400D543")]
		[FieldOffset(Offset = "0x78")]
		private Color m_originHihglightTintColor;

		// Token: 0x0400D544 RID: 54596
		[Token(Token = "0x400D544")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D m_originHighlightTex;

		// Token: 0x0400D545 RID: 54597
		[Token(Token = "0x400D545")]
		[FieldOffset(Offset = "0x90")]
		private float m_originHighlightAmount;

		// Token: 0x0400D546 RID: 54598
		[Token(Token = "0x400D546")]
		[FieldOffset(Offset = "0x94")]
		private Color m_highlightColor;

		// Token: 0x0400D547 RID: 54599
		[Token(Token = "0x400D547")]
		[FieldOffset(Offset = "0xA4")]
		private Color m_highlightTintColor;

		// Token: 0x0400D548 RID: 54600
		[Token(Token = "0x400D548")]
		[FieldOffset(Offset = "0xB8")]
		private Texture2D m_highlightTex;

		// Token: 0x0400D549 RID: 54601
		[Token(Token = "0x400D549")]
		[FieldOffset(Offset = "0xC0")]
		private float m_highlightAmount;

		// Token: 0x0400D54A RID: 54602
		[Token(Token = "0x400D54A")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_initialized;

		// Token: 0x0400D54B RID: 54603
		[Token(Token = "0x400D54B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_isDirty;

		// Token: 0x0400D54C RID: 54604
		[Token(Token = "0x400D54C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitParams;

		// Token: 0x0400D54D RID: 54605
		[Token(Token = "0x400D54D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetParams;

		// Token: 0x0400D54E RID: 54606
		[Token(Token = "0x400D54E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetParams;

		// Token: 0x0400D54F RID: 54607
		[Token(Token = "0x400D54F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400D550 RID: 54608
		[Token(Token = "0x400D550")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400D551 RID: 54609
		[Token(Token = "0x400D551")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400D552 RID: 54610
		[Token(Token = "0x400D552")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D553 RID: 54611
		[Token(Token = "0x400D553")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
