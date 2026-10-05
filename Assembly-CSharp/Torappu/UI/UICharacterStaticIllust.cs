using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003557 RID: 13655
	[Token(Token = "0x2003557")]
	public class UICharacterStaticIllust : UICharacterIllust
	{
		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x06015C1F RID: 89119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015C20 RID: 89120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033AE")]
		public override string illustId
		{
			[Token(Token = "0x6015C1F")]
			[Address(RVA = "0xE59940", Offset = "0xE58540", VA = "0x180E59940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015C20")]
			[Address(RVA = "0xE59FF0", Offset = "0xE58BF0", VA = "0x180E59FF0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x06015C21 RID: 89121 RVA: 0x0008DAC8 File Offset: 0x0008BCC8
		[Token(Token = "0x170033AF")]
		public override bool isDynamic
		{
			[Token(Token = "0x6015C21")]
			[Address(RVA = "0xE59A10", Offset = "0xE58610", VA = "0x180E59A10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x06015C22 RID: 89122 RVA: 0x0008DAE0 File Offset: 0x0008BCE0
		[Token(Token = "0x170033B0")]
		public override bool isActiveIllust
		{
			[Token(Token = "0x6015C22")]
			[Address(RVA = "0xE599A0", Offset = "0xE585A0", VA = "0x180E599A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x06015C23 RID: 89123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033B1")]
		public override RectTransform rectTransform
		{
			[Token(Token = "0x6015C23")]
			[Address(RVA = "0xE59D40", Offset = "0xE58940", VA = "0x180E59D40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x06015C24 RID: 89124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033B2")]
		protected override Graphic mainGraphic
		{
			[Token(Token = "0x6015C24")]
			[Address(RVA = "0xE59A70", Offset = "0xE58670", VA = "0x180E59A70", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x06015C25 RID: 89125 RVA: 0x0008DAF8 File Offset: 0x0008BCF8
		// (set) Token: 0x06015C26 RID: 89126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033B3")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6015C25")]
			[Address(RVA = "0xE59C90", Offset = "0xE58890", VA = "0x180E59C90", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015C26")]
			[Address(RVA = "0xE5A070", Offset = "0xE58C70", VA = "0x180E5A070", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x06015C27 RID: 89127 RVA: 0x0008DB10 File Offset: 0x0008BD10
		// (set) Token: 0x06015C28 RID: 89128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033B4")]
		public override Color color
		{
			[Token(Token = "0x6015C27")]
			[Address(RVA = "0xE596B0", Offset = "0xE582B0", VA = "0x180E596B0", Slot = "11")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6015C28")]
			[Address(RVA = "0xE59DB0", Offset = "0xE589B0", VA = "0x180E59DB0", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x06015C29 RID: 89129 RVA: 0x0008DB28 File Offset: 0x0008BD28
		[Token(Token = "0x170033B5")]
		public override float alpha
		{
			[Token(Token = "0x6015C29")]
			[Address(RVA = "0xE59620", Offset = "0xE58220", VA = "0x180E59620", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x06015C2A RID: 89130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033B6")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6015C2A")]
			[Address(RVA = "0xE59AD0", Offset = "0xE586D0", VA = "0x180E59AD0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x06015C2B RID: 89131 RVA: 0x0008DB40 File Offset: 0x0008BD40
		[Token(Token = "0x170033B7")]
		public override Vector2 rawSize
		{
			[Token(Token = "0x6015C2B")]
			[Address(RVA = "0xE59B60", Offset = "0xE58760", VA = "0x180E59B60", Slot = "15")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06015C2C RID: 89132 RVA: 0x0008DB58 File Offset: 0x0008BD58
		[Token(Token = "0x6015C2C")]
		[Address(RVA = "0xE58D90", Offset = "0xE57990", VA = "0x180E58D90", Slot = "28")]
		public override Vector2 GetHomeSizeAdjust()
		{
			return default(Vector2);
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x06015C2D RID: 89133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033B8")]
		public override IList<Graphic> graphics
		{
			[Token(Token = "0x6015C2D")]
			[Address(RVA = "0xE59760", Offset = "0xE58360", VA = "0x180E59760", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015C2E RID: 89134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C2E")]
		[Address(RVA = "0xE58FB0", Offset = "0xE57BB0", VA = "0x180E58FB0", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06015C2F RID: 89135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C2F")]
		[Address(RVA = "0xE58EA0", Offset = "0xE57AA0", VA = "0x180E58EA0")]
		public void Init(UICharacterIllustController.IllustHandler handler, string illustId, Image staticIllust)
		{
		}

		// Token: 0x06015C30 RID: 89136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C30")]
		[Address(RVA = "0xE58900", Offset = "0xE57500", VA = "0x180E58900", Slot = "24")]
		public override void Activate(bool fastMode = false)
		{
		}

		// Token: 0x06015C31 RID: 89137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C31")]
		[Address(RVA = "0xE59060", Offset = "0xE57C60", VA = "0x180E59060", Slot = "25")]
		public override void SetAlpha(float alpha)
		{
		}

		// Token: 0x06015C32 RID: 89138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015C32")]
		[Address(RVA = "0xE58AD0", Offset = "0xE576D0", VA = "0x180E58AD0", Slot = "26")]
		public override Tween DOFade(float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06015C33 RID: 89139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C33")]
		[Address(RVA = "0xE58990", Offset = "0xE57590", VA = "0x180E58990", Slot = "27")]
		public override void ApplySkinOffset()
		{
		}

		// Token: 0x06015C34 RID: 89140 RVA: 0x0008DB70 File Offset: 0x0008BD70
		[Token(Token = "0x6015C34")]
		[Address(RVA = "0xE58CE0", Offset = "0xE578E0", VA = "0x180E58CE0", Slot = "29")]
		public override float GetCharInfoSpreadPanelZoomMax()
		{
			return 0f;
		}

		// Token: 0x06015C35 RID: 89141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C35")]
		[Address(RVA = "0xE59180", Offset = "0xE57D80", VA = "0x180E59180", Slot = "32")]
		public override void SetConfig(UICharacterIllust.Config config)
		{
		}

		// Token: 0x06015C36 RID: 89142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015C36")]
		[Address(RVA = "0xE58E10", Offset = "0xE57A10", VA = "0x180E58E10", Slot = "30")]
		public override Material GetMainMaterial()
		{
			return null;
		}

		// Token: 0x06015C37 RID: 89143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C37")]
		[Address(RVA = "0xE593B0", Offset = "0xE57FB0", VA = "0x180E593B0", Slot = "31")]
		public override void SetMainMaterial(Material mat)
		{
		}

		// Token: 0x06015C38 RID: 89144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C38")]
		[Address(RVA = "0xE59510", Offset = "0xE58110", VA = "0x180E59510")]
		private void _EventOnClickEvent()
		{
		}

		// Token: 0x06015C39 RID: 89145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C39")]
		[Address(RVA = "0xE59580", Offset = "0xE58180", VA = "0x180E59580")]
		public UICharacterStaticIllust()
		{
		}

		// Token: 0x06015C3B RID: 89147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C3B")]
		[Address(RVA = "0xE4B2E0", Offset = "0xE49EE0", VA = "0x180E4B2E0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06015C3C RID: 89148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C3C")]
		[Address(RVA = "0xE4B580", Offset = "0xE4A180", VA = "0x180E4B580")]
		private void <>xLuaBaseProxy_SetConfig(UICharacterIllust.Config P0)
		{
		}

		// Token: 0x0401A2A0 RID: 107168
		[Token(Token = "0x401A2A0")]
		private const float CHAR_INFO_SPREAD_PANEL_ZOOM_MAX = 1.5f;

		// Token: 0x0401A2A1 RID: 107169
		[Token(Token = "0x401A2A1")]
		private const float CHAR_INFO_SPREAD_MAX_ZOOM_WITH_PLUGIN = 1.26f;

		// Token: 0x0401A2A2 RID: 107170
		[Token(Token = "0x401A2A2")]
		[FieldOffset(Offset = "0x28")]
		private UICharacterIllustController.IllustHandler m_handler;

		// Token: 0x0401A2A3 RID: 107171
		[Token(Token = "0x401A2A3")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_fadeTweener;

		// Token: 0x0401A2A4 RID: 107172
		[Token(Token = "0x401A2A4")]
		[FieldOffset(Offset = "0x38")]
		private Image m_image;

		// Token: 0x0401A2A5 RID: 107173
		[Token(Token = "0x401A2A5")]
		[FieldOffset(Offset = "0x40")]
		private EventTrigger m_onClickTrigger;

		// Token: 0x0401A2A6 RID: 107174
		[Token(Token = "0x401A2A6")]
		[FieldOffset(Offset = "0x48")]
		private Action m_onClick;

		// Token: 0x0401A2A7 RID: 107175
		[Token(Token = "0x401A2A7")]
		[FieldOffset(Offset = "0x50")]
		private List<Graphic> m_graphicList;

		// Token: 0x0401A2A8 RID: 107176
		[Token(Token = "0x401A2A8")]
		[FieldOffset(Offset = "0x58")]
		private UICharIllustPluginGraphics m_pluginGraphics;

		// Token: 0x0401A2AA RID: 107178
		[Token(Token = "0x401A2AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_illustId;

		// Token: 0x0401A2AB RID: 107179
		[Token(Token = "0x401A2AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_illustId;

		// Token: 0x0401A2AC RID: 107180
		[Token(Token = "0x401A2AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isDynamic;

		// Token: 0x0401A2AD RID: 107181
		[Token(Token = "0x401A2AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isActiveIllust;

		// Token: 0x0401A2AE RID: 107182
		[Token(Token = "0x401A2AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x0401A2AF RID: 107183
		[Token(Token = "0x401A2AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_mainGraphic;

		// Token: 0x0401A2B0 RID: 107184
		[Token(Token = "0x401A2B0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_raycastTarget;

		// Token: 0x0401A2B1 RID: 107185
		[Token(Token = "0x401A2B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_raycastTarget;

		// Token: 0x0401A2B2 RID: 107186
		[Token(Token = "0x401A2B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0401A2B3 RID: 107187
		[Token(Token = "0x401A2B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0401A2B4 RID: 107188
		[Token(Token = "0x401A2B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_alpha;

		// Token: 0x0401A2B5 RID: 107189
		[Token(Token = "0x401A2B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x0401A2B6 RID: 107190
		[Token(Token = "0x401A2B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_rawSize;

		// Token: 0x0401A2B7 RID: 107191
		[Token(Token = "0x401A2B7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetHomeSizeAdjust;

		// Token: 0x0401A2B8 RID: 107192
		[Token(Token = "0x401A2B8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_graphics;

		// Token: 0x0401A2B9 RID: 107193
		[Token(Token = "0x401A2B9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401A2BA RID: 107194
		[Token(Token = "0x401A2BA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401A2BB RID: 107195
		[Token(Token = "0x401A2BB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Activate;

		// Token: 0x0401A2BC RID: 107196
		[Token(Token = "0x401A2BC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetAlpha;

		// Token: 0x0401A2BD RID: 107197
		[Token(Token = "0x401A2BD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_DOFade;

		// Token: 0x0401A2BE RID: 107198
		[Token(Token = "0x401A2BE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ApplySkinOffset;

		// Token: 0x0401A2BF RID: 107199
		[Token(Token = "0x401A2BF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetCharInfoSpreadPanelZoomMax;

		// Token: 0x0401A2C0 RID: 107200
		[Token(Token = "0x401A2C0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x0401A2C1 RID: 107201
		[Token(Token = "0x401A2C1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetMainMaterial;

		// Token: 0x0401A2C2 RID: 107202
		[Token(Token = "0x401A2C2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetMainMaterial;

		// Token: 0x0401A2C3 RID: 107203
		[Token(Token = "0x401A2C3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EventOnClickEvent;

		// Token: 0x0401A2C4 RID: 107204
		[Token(Token = "0x401A2C4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
