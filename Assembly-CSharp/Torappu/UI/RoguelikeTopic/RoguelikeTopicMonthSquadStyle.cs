using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044E4 RID: 17636
	[Token(Token = "0x20044E4")]
	public class RoguelikeTopicMonthSquadStyle : UIStyle
	{
		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0601AECF RID: 110287 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		[Token(Token = "0x17003FE3")]
		public SpriteRenderData teamIcon
		{
			[Token(Token = "0x601AECF")]
			[Address(RVA = "0x1412CA0", Offset = "0x14118A0", VA = "0x181412CA0")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x0601AED0 RID: 110288 RVA: 0x000A39C8 File Offset: 0x000A1BC8
		[Token(Token = "0x17003FE4")]
		public float iconTeamAlpha
		{
			[Token(Token = "0x601AED0")]
			[Address(RVA = "0x1412C40", Offset = "0x1411840", VA = "0x181412C40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x0601AED1 RID: 110289 RVA: 0x000A39E0 File Offset: 0x000A1BE0
		[Token(Token = "0x17003FE5")]
		public Color colorTheme
		{
			[Token(Token = "0x601AED1")]
			[Address(RVA = "0x1412BC0", Offset = "0x14117C0", VA = "0x181412BC0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601AED2 RID: 110290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AED2")]
		[Address(RVA = "0x1412B50", Offset = "0x1411750", VA = "0x181412B50")]
		public RoguelikeTopicMonthSquadStyle()
		{
		}

		// Token: 0x0402287E RID: 141438
		[Token(Token = "0x402287E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402287F RID: 141439
		[Token(Token = "0x402287F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _iconTeamName;

		// Token: 0x04022880 RID: 141440
		[Token(Token = "0x4022880")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _iconTeamAlpha;

		// Token: 0x04022881 RID: 141441
		[Token(Token = "0x4022881")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _colorTheme;

		// Token: 0x04022882 RID: 141442
		[Token(Token = "0x4022882")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_teamIcon;

		// Token: 0x04022883 RID: 141443
		[Token(Token = "0x4022883")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_iconTeamAlpha;

		// Token: 0x04022884 RID: 141444
		[Token(Token = "0x4022884")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_colorTheme;

		// Token: 0x04022885 RID: 141445
		[Token(Token = "0x4022885")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
