using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200408C RID: 16524
	[Token(Token = "0x200408C")]
	public class SandboxV2CookDrinkWaterView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019901 RID: 104705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019901")]
		[Address(RVA = "0x1250C30", Offset = "0x124F830", VA = "0x181250C30")]
		public void Render(SandboxV2CookDrinkModel model)
		{
		}

		// Token: 0x06019902 RID: 104706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019902")]
		[Address(RVA = "0x1251110", Offset = "0x124FD10", VA = "0x181251110")]
		private void _SetTargetValue(float target)
		{
		}

		// Token: 0x06019903 RID: 104707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019903")]
		[Address(RVA = "0x1251280", Offset = "0x124FE80", VA = "0x181251280")]
		public SandboxV2CookDrinkWaterView()
		{
		}

		// Token: 0x0401FE5B RID: 130651
		[Token(Token = "0x401FE5B")]
		private const string STATUS_TEXT_FORMAT = "<color=#d5d450>{0}</color>/{1}";

		// Token: 0x0401FE5C RID: 130652
		[Token(Token = "0x401FE5C")]
		private const float POT_WATER_LIMIT = 1f;

		// Token: 0x0401FE5D RID: 130653
		[Token(Token = "0x401FE5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _animDuration;

		// Token: 0x0401FE5E RID: 130654
		[Token(Token = "0x401FE5E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Ease _ease;

		// Token: 0x0401FE5F RID: 130655
		[Token(Token = "0x401FE5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _sizeBegin;

		// Token: 0x0401FE60 RID: 130656
		[Token(Token = "0x401FE60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _sizeEnd;

		// Token: 0x0401FE61 RID: 130657
		[Token(Token = "0x401FE61")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rectWater;

		// Token: 0x0401FE62 RID: 130658
		[Token(Token = "0x401FE62")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _reflectionFill;

		// Token: 0x0401FE63 RID: 130659
		[Token(Token = "0x401FE63")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _floatingTagSlider;

		// Token: 0x0401FE64 RID: 130660
		[Token(Token = "0x401FE64")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _floatingTagText;

		// Token: 0x0401FE65 RID: 130661
		[Token(Token = "0x401FE65")]
		[FieldOffset(Offset = "0x50")]
		private float m_value;

		// Token: 0x0401FE66 RID: 130662
		[Token(Token = "0x401FE66")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x0401FE67 RID: 130663
		[Token(Token = "0x401FE67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FE68 RID: 130664
		[Token(Token = "0x401FE68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetTargetValue;

		// Token: 0x0401FE69 RID: 130665
		[Token(Token = "0x401FE69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
