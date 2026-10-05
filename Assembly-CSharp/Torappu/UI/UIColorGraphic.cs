using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037E1 RID: 14305
	[Token(Token = "0x20037E1")]
	public class UIColorGraphic : NonDrawingGraphic, IHotfixable
	{
		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x06016ADC RID: 92892 RVA: 0x00092658 File Offset: 0x00090858
		// (set) Token: 0x06016ADD RID: 92893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700363F")]
		[Inspect]
		public override Color color
		{
			[Token(Token = "0x6016ADC")]
			[Address(RVA = "0xF11430", Offset = "0xF10030", VA = "0x180F11430", Slot = "22")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6016ADD")]
			[Address(RVA = "0xF114B0", Offset = "0xF100B0", VA = "0x180F114B0", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x06016ADE RID: 92894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ADE")]
		[Address(RVA = "0xF0FF30", Offset = "0xF0EB30", VA = "0x180F0FF30")]
		public void AttachGraphic(Graphic graphic, bool useStaticColor = true)
		{
		}

		// Token: 0x06016ADF RID: 92895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ADF")]
		[Address(RVA = "0xF10270", Offset = "0xF0EE70", VA = "0x180F10270")]
		public void AttachGraphicsWithGroup(List<Graphic> graphic, string groupId)
		{
		}

		// Token: 0x06016AE0 RID: 92896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE0")]
		[Address(RVA = "0xF106A0", Offset = "0xF0F2A0", VA = "0x180F106A0", Slot = "51")]
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		// Token: 0x06016AE1 RID: 92897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE1")]
		[Address(RVA = "0xF107D0", Offset = "0xF0F3D0", VA = "0x180F107D0", Slot = "50")]
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
		}

		// Token: 0x06016AE2 RID: 92898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE2")]
		[Address(RVA = "0xF10930", Offset = "0xF0F530", VA = "0x180F10930", Slot = "49")]
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06016AE3 RID: 92899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE3")]
		[Address(RVA = "0xF10B20", Offset = "0xF0F720", VA = "0x180F10B20")]
		private void _ApplyOptToGraphics(UIColorGraphic.GraphicOpt opt, UIColorGraphic.CommonParams param)
		{
		}

		// Token: 0x06016AE4 RID: 92900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE4")]
		[Address(RVA = "0xF10E70", Offset = "0xF0FA70", VA = "0x180F10E70")]
		private static void _CrossFadeAlpha(Graphic graphic, UIColorGraphic.CommonParams param)
		{
		}

		// Token: 0x06016AE5 RID: 92901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE5")]
		[Address(RVA = "0xF11110", Offset = "0xF0FD10", VA = "0x180F11110")]
		private static void _CrossFadeColorRGB(Graphic graphic, UIColorGraphic.CommonParams param)
		{
		}

		// Token: 0x06016AE6 RID: 92902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE6")]
		[Address(RVA = "0xF10FB0", Offset = "0xF0FBB0", VA = "0x180F10FB0")]
		private static void _CrossFadeColorAlpha(Graphic graphic, UIColorGraphic.CommonParams param)
		{
		}

		// Token: 0x06016AE7 RID: 92903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE7")]
		[Address(RVA = "0xF11290", Offset = "0xF0FE90", VA = "0x180F11290")]
		private static void _SetColor(Graphic graphic, UIColorGraphic.CommonParams param)
		{
		}

		// Token: 0x06016AE8 RID: 92904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AE8")]
		[Address(RVA = "0xF113C0", Offset = "0xF0FFC0", VA = "0x180F113C0")]
		public UIColorGraphic()
		{
		}

		// Token: 0x06016AE9 RID: 92905 RVA: 0x00092670 File Offset: 0x00090870
		[Token(Token = "0x6016AE9")]
		[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
		private Color <>xLuaBaseProxy_get_color()
		{
			return default(Color);
		}

		// Token: 0x06016AEA RID: 92906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AEA")]
		[Address(RVA = "0xF10B00", Offset = "0xF0F700", VA = "0x180F10B00")]
		private void <>xLuaBaseProxy_set_color(Color P0)
		{
		}

		// Token: 0x06016AEB RID: 92907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AEB")]
		[Address(RVA = "0xF10A70", Offset = "0xF0F670", VA = "0x180F10A70")]
		private void <>xLuaBaseProxy_CrossFadeAlpha(float P0, float P1, bool P2)
		{
		}

		// Token: 0x06016AEC RID: 92908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AEC")]
		[Address(RVA = "0xF10A80", Offset = "0xF0F680", VA = "0x180F10A80")]
		private void <>xLuaBaseProxy_CrossFadeColor(Color P0, float P1, bool P2, bool P3, bool P4)
		{
		}

		// Token: 0x06016AED RID: 92909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AED")]
		[Address(RVA = "0xF10AC0", Offset = "0xF0F6C0", VA = "0x180F10AC0")]
		private void <>xLuaBaseProxy_CrossFadeColor(Color P0, float P1, bool P2, bool P3)
		{
		}

		// Token: 0x0401B556 RID: 111958
		[Token(Token = "0x401B556")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Graphic[] _colorElements;

		// Token: 0x0401B557 RID: 111959
		[Token(Token = "0x401B557")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		private Color _color;

		// Token: 0x0401B558 RID: 111960
		[Token(Token = "0x401B558")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isOperating;

		// Token: 0x0401B559 RID: 111961
		[Token(Token = "0x401B559")]
		[FieldOffset(Offset = "0xD0")]
		private List<UIColorGraphic.DynEle> m_dynList;

		// Token: 0x0401B55A RID: 111962
		[Token(Token = "0x401B55A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0401B55B RID: 111963
		[Token(Token = "0x401B55B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0401B55C RID: 111964
		[Token(Token = "0x401B55C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AttachGraphic;

		// Token: 0x0401B55D RID: 111965
		[Token(Token = "0x401B55D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AttachGraphicsWithGroup;

		// Token: 0x0401B55E RID: 111966
		[Token(Token = "0x401B55E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CrossFadeAlpha;

		// Token: 0x0401B55F RID: 111967
		[Token(Token = "0x401B55F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CrossFadeColor;

		// Token: 0x0401B560 RID: 111968
		[Token(Token = "0x401B560")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_CrossFadeColor;

		// Token: 0x0401B561 RID: 111969
		[Token(Token = "0x401B561")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyOptToGraphics;

		// Token: 0x0401B562 RID: 111970
		[Token(Token = "0x401B562")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CrossFadeAlpha;

		// Token: 0x0401B563 RID: 111971
		[Token(Token = "0x401B563")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CrossFadeColorRGB;

		// Token: 0x0401B564 RID: 111972
		[Token(Token = "0x401B564")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CrossFadeColorAlpha;

		// Token: 0x0401B565 RID: 111973
		[Token(Token = "0x401B565")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetColor;

		// Token: 0x0401B566 RID: 111974
		[Token(Token = "0x401B566")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020037E2 RID: 14306
		[Token(Token = "0x20037E2")]
		private struct CommonParams
		{
			// Token: 0x0401B567 RID: 111975
			[Token(Token = "0x401B567")]
			[FieldOffset(Offset = "0x0")]
			public float alpha;

			// Token: 0x0401B568 RID: 111976
			[Token(Token = "0x401B568")]
			[FieldOffset(Offset = "0x4")]
			public float duration;

			// Token: 0x0401B569 RID: 111977
			[Token(Token = "0x401B569")]
			[FieldOffset(Offset = "0x8")]
			public bool ignoreTimeScale;

			// Token: 0x0401B56A RID: 111978
			[Token(Token = "0x401B56A")]
			[FieldOffset(Offset = "0xC")]
			public Color targetColor;

			// Token: 0x0401B56B RID: 111979
			[Token(Token = "0x401B56B")]
			[FieldOffset(Offset = "0x1C")]
			public bool useAlpha;

			// Token: 0x0401B56C RID: 111980
			[Token(Token = "0x401B56C")]
			[FieldOffset(Offset = "0x1D")]
			public bool useRGB;

			// Token: 0x0401B56D RID: 111981
			[Token(Token = "0x401B56D")]
			[FieldOffset(Offset = "0x1E")]
			public bool isStaticColorOpt;
		}

		// Token: 0x020037E3 RID: 14307
		// (Invoke) Token: 0x06016AEF RID: 92911
		[Token(Token = "0x20037E3")]
		private delegate void GraphicOpt(Graphic graphic, UIColorGraphic.CommonParams param);

		// Token: 0x020037E4 RID: 14308
		[Token(Token = "0x20037E4")]
		private struct DynEle
		{
			// Token: 0x0401B56E RID: 111982
			[Token(Token = "0x401B56E")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x0401B56F RID: 111983
			[Token(Token = "0x401B56F")]
			[FieldOffset(Offset = "0x8")]
			public Graphic graphic;

			// Token: 0x0401B570 RID: 111984
			[Token(Token = "0x401B570")]
			[FieldOffset(Offset = "0x10")]
			public bool useStaticColor;
		}
	}
}
