using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005286 RID: 21126
	[Token(Token = "0x2005286")]
	public class RoguelikeVerticalLine : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x0601F2BB RID: 127675 RVA: 0x000B1198 File Offset: 0x000AF398
		// (set) Token: 0x0601F2BC RID: 127676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700490F")]
		public Color arrowColor
		{
			[Token(Token = "0x601F2BB")]
			[Address(RVA = "0x18EE990", Offset = "0x18ED590", VA = "0x1818EE990")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x601F2BC")]
			[Address(RVA = "0x18EEBB0", Offset = "0x18ED7B0", VA = "0x1818EEBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x0601F2BD RID: 127677 RVA: 0x000B11B0 File Offset: 0x000AF3B0
		// (set) Token: 0x0601F2BE RID: 127678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004910")]
		public Color lineColor
		{
			[Token(Token = "0x601F2BD")]
			[Address(RVA = "0x18EEA70", Offset = "0x18ED670", VA = "0x1818EEA70")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x601F2BE")]
			[Address(RVA = "0x18EECB0", Offset = "0x18ED8B0", VA = "0x1818EECB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x0601F2BF RID: 127679 RVA: 0x000B11C8 File Offset: 0x000AF3C8
		// (set) Token: 0x0601F2C0 RID: 127680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004911")]
		public bool showArrowFlag
		{
			[Token(Token = "0x601F2BF")]
			[Address(RVA = "0x18EEAF0", Offset = "0x18ED6F0", VA = "0x1818EEAF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F2C0")]
			[Address(RVA = "0x18EED30", Offset = "0x18ED930", VA = "0x1818EED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x0601F2C1 RID: 127681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F2C2 RID: 127682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004912")]
		public RectTransform startNode
		{
			[Token(Token = "0x601F2C1")]
			[Address(RVA = "0x18EEB50", Offset = "0x18ED750", VA = "0x1818EEB50")]
			get
			{
				return null;
			}
			[Token(Token = "0x601F2C2")]
			[Address(RVA = "0x18EEDA0", Offset = "0x18ED9A0", VA = "0x1818EEDA0")]
			set
			{
			}
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x0601F2C3 RID: 127683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F2C4 RID: 127684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004913")]
		public RectTransform endNode
		{
			[Token(Token = "0x601F2C3")]
			[Address(RVA = "0x18EEA10", Offset = "0x18ED610", VA = "0x1818EEA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x601F2C4")]
			[Address(RVA = "0x18EEC30", Offset = "0x18ED830", VA = "0x1818EEC30")]
			set
			{
			}
		}

		// Token: 0x0601F2C5 RID: 127685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2C5")]
		[Address(RVA = "0x18EE740", Offset = "0x18ED340", VA = "0x1818EE740")]
		public void Render(RoguelikeVerticalLine.Config colorConfig, RoguelikeDungeonLine.VertType lineType)
		{
		}

		// Token: 0x0601F2C6 RID: 127686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2C6")]
		[Address(RVA = "0x18EE930", Offset = "0x18ED530", VA = "0x1818EE930")]
		public RoguelikeVerticalLine()
		{
		}

		// Token: 0x04029D48 RID: 171336
		[Token(Token = "0x4029D48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x04029D49 RID: 171337
		[Token(Token = "0x4029D49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _upArrowImg;

		// Token: 0x04029D4A RID: 171338
		[Token(Token = "0x4029D4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _downArrowImg;

		// Token: 0x04029D4B RID: 171339
		[Token(Token = "0x4029D4B")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform m_startNode;

		// Token: 0x04029D4C RID: 171340
		[Token(Token = "0x4029D4C")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_endNode;

		// Token: 0x04029D50 RID: 171344
		[Token(Token = "0x4029D50")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 m_startPos;

		// Token: 0x04029D51 RID: 171345
		[Token(Token = "0x4029D51")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 m_endPos;

		// Token: 0x04029D52 RID: 171346
		[Token(Token = "0x4029D52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_arrowColor;

		// Token: 0x04029D53 RID: 171347
		[Token(Token = "0x4029D53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_arrowColor;

		// Token: 0x04029D54 RID: 171348
		[Token(Token = "0x4029D54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lineColor;

		// Token: 0x04029D55 RID: 171349
		[Token(Token = "0x4029D55")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_lineColor;

		// Token: 0x04029D56 RID: 171350
		[Token(Token = "0x4029D56")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showArrowFlag;

		// Token: 0x04029D57 RID: 171351
		[Token(Token = "0x4029D57")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_showArrowFlag;

		// Token: 0x04029D58 RID: 171352
		[Token(Token = "0x4029D58")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_startNode;

		// Token: 0x04029D59 RID: 171353
		[Token(Token = "0x4029D59")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_startNode;

		// Token: 0x04029D5A RID: 171354
		[Token(Token = "0x4029D5A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_endNode;

		// Token: 0x04029D5B RID: 171355
		[Token(Token = "0x4029D5B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_endNode;

		// Token: 0x04029D5C RID: 171356
		[Token(Token = "0x4029D5C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029D5D RID: 171357
		[Token(Token = "0x4029D5D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005287 RID: 21127
		[Token(Token = "0x2005287")]
		public class Config
		{
			// Token: 0x0601F2C7 RID: 127687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F2C7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x04029D5E RID: 171358
			[Token(Token = "0x4029D5E")]
			[FieldOffset(Offset = "0x10")]
			public Color lineColor;

			// Token: 0x04029D5F RID: 171359
			[Token(Token = "0x4029D5F")]
			[FieldOffset(Offset = "0x20")]
			public Color arrowColor;
		}
	}
}
