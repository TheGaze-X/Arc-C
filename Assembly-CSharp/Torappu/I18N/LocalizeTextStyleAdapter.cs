using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.I18N
{
	// Token: 0x02001626 RID: 5670
	[Token(Token = "0x2001626")]
	[RequireComponent(typeof(Text))]
	public class LocalizeTextStyleAdapter : MonoBehaviour
	{
		// Token: 0x060080B5 RID: 32949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B5")]
		[Address(RVA = "0x2889980", Offset = "0x2888580", VA = "0x182889980")]
		public void Refresh()
		{
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B6")]
		[Address(RVA = "0x2889960", Offset = "0x2888560", VA = "0x182889960")]
		private void OnEnable()
		{
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B7")]
		[Address(RVA = "0x2889990", Offset = "0x2888590", VA = "0x182889990")]
		private void _RefreshStyles()
		{
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B8")]
		[Address(RVA = "0x2889E60", Offset = "0x2888A60", VA = "0x182889E60")]
		private void _UpdateStyles(TextStyles styles)
		{
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B9")]
		[Address(RVA = "0x2889F60", Offset = "0x2888B60", VA = "0x182889F60")]
		public LocalizeTextStyleAdapter()
		{
		}

		// Token: 0x0400820A RID: 33290
		[Token(Token = "0x400820A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LocalizeTextStyleAdapter.SettingType _settingType;

		// Token: 0x0400820B RID: 33291
		[Token(Token = "0x400820B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextStyles _styleInLand;

		// Token: 0x0400820C RID: 33292
		[Token(Token = "0x400820C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextStyles _styleJp;

		// Token: 0x0400820D RID: 33293
		[Token(Token = "0x400820D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextStyles _styleEn;

		// Token: 0x0400820E RID: 33294
		[Token(Token = "0x400820E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextStyles _styleKr;

		// Token: 0x0400820F RID: 33295
		[Token(Token = "0x400820F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextStyles _styleTc;

		// Token: 0x04008210 RID: 33296
		[Token(Token = "0x4008210")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public bool m_overrideStyleInLand;

		// Token: 0x04008211 RID: 33297
		[Token(Token = "0x4008211")]
		[FieldOffset(Offset = "0x49")]
		[HideInInspector]
		public bool m_overrideStyleJp;

		// Token: 0x04008212 RID: 33298
		[Token(Token = "0x4008212")]
		[FieldOffset(Offset = "0x4A")]
		[HideInInspector]
		public bool m_overrideStyleEn;

		// Token: 0x04008213 RID: 33299
		[Token(Token = "0x4008213")]
		[FieldOffset(Offset = "0x4B")]
		[HideInInspector]
		public bool m_overrideStyleKr;

		// Token: 0x04008214 RID: 33300
		[Token(Token = "0x4008214")]
		[FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public bool m_overrideStyleTc;

		// Token: 0x04008215 RID: 33301
		[Token(Token = "0x4008215")]
		[FieldOffset(Offset = "0x50")]
		private Text m_text;

		// Token: 0x04008216 RID: 33302
		[Token(Token = "0x4008216")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isStyleInited;

		// Token: 0x04008217 RID: 33303
		[Token(Token = "0x4008217")]
		[FieldOffset(Offset = "0x60")]
		private TextStyles m_useStyle;

		// Token: 0x02001627 RID: 5671
		[Token(Token = "0x2001627")]
		private enum SettingType
		{
			// Token: 0x04008219 RID: 33305
			[Token(Token = "0x4008219")]
			ON_ENABLE,
			// Token: 0x0400821A RID: 33306
			[Token(Token = "0x400821A")]
			BY_MANUAL
		}
	}
}
