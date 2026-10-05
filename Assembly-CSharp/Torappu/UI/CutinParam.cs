using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200369A RID: 13978
	[Token(Token = "0x200369A")]
	public class CutinParam : IHotfixable
	{
		// Token: 0x060163B4 RID: 91060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163B4")]
		[Address(RVA = "0xEB2220", Offset = "0xEB0E20", VA = "0x180EB2220")]
		public CutinParam()
		{
		}

		// Token: 0x0401AB7A RID: 109434
		[Token(Token = "0x401AB7A")]
		[FieldOffset(Offset = "0x10")]
		public int channel;

		// Token: 0x0401AB7B RID: 109435
		[Token(Token = "0x401AB7B")]
		[FieldOffset(Offset = "0x14")]
		public CutinParam.ParamType type;

		// Token: 0x0401AB7C RID: 109436
		[Token(Token = "0x401AB7C")]
		[FieldOffset(Offset = "0x18")]
		public string maskId;

		// Token: 0x0401AB7D RID: 109437
		[Token(Token = "0x401AB7D")]
		[FieldOffset(Offset = "0x20")]
		public string slot;

		// Token: 0x0401AB7E RID: 109438
		[Token(Token = "0x401AB7E")]
		[FieldOffset(Offset = "0x28")]
		public CutinShowStyle style;

		// Token: 0x0401AB7F RID: 109439
		[Token(Token = "0x401AB7F")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 size;

		// Token: 0x0401AB80 RID: 109440
		[Token(Token = "0x401AB80")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 offset;

		// Token: 0x0401AB81 RID: 109441
		[Token(Token = "0x401AB81")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x0401AB82 RID: 109442
		[Token(Token = "0x401AB82")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 posFrom;

		// Token: 0x0401AB83 RID: 109443
		[Token(Token = "0x401AB83")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 posTo;

		// Token: 0x0401AB84 RID: 109444
		[Token(Token = "0x401AB84")]
		[FieldOffset(Offset = "0x58")]
		public float duration;

		// Token: 0x0401AB85 RID: 109445
		[Token(Token = "0x401AB85")]
		[FieldOffset(Offset = "0x5C")]
		public float aFrom;

		// Token: 0x0401AB86 RID: 109446
		[Token(Token = "0x401AB86")]
		[FieldOffset(Offset = "0x60")]
		public float aTo;

		// Token: 0x0401AB87 RID: 109447
		[Token(Token = "0x401AB87")]
		[FieldOffset(Offset = "0x64")]
		public float aDuration;

		// Token: 0x0401AB88 RID: 109448
		[Token(Token = "0x401AB88")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 sFrom;

		// Token: 0x0401AB89 RID: 109449
		[Token(Token = "0x401AB89")]
		[FieldOffset(Offset = "0x70")]
		public Vector2 sTo;

		// Token: 0x0401AB8A RID: 109450
		[Token(Token = "0x401AB8A")]
		[FieldOffset(Offset = "0x78")]
		public float sDuration;

		// Token: 0x0401AB8B RID: 109451
		[Token(Token = "0x401AB8B")]
		[FieldOffset(Offset = "0x7C")]
		public bool clear;

		// Token: 0x0401AB8C RID: 109452
		[Token(Token = "0x401AB8C")]
		[FieldOffset(Offset = "0x7D")]
		public bool block;

		// Token: 0x0401AB8D RID: 109453
		[Token(Token = "0x401AB8D")]
		[FieldOffset(Offset = "0x7E")]
		public bool posSet;

		// Token: 0x0401AB8E RID: 109454
		[Token(Token = "0x401AB8E")]
		[FieldOffset(Offset = "0x7F")]
		public bool scaleSet;

		// Token: 0x0401AB8F RID: 109455
		[Token(Token = "0x401AB8F")]
		[FieldOffset(Offset = "0x80")]
		public Vector2 tsFrom;

		// Token: 0x0401AB90 RID: 109456
		[Token(Token = "0x401AB90")]
		[FieldOffset(Offset = "0x88")]
		public Vector2 tsTo;

		// Token: 0x0401AB91 RID: 109457
		[Token(Token = "0x401AB91")]
		[FieldOffset(Offset = "0x90")]
		public float tsDuration;

		// Token: 0x0401AB92 RID: 109458
		[Token(Token = "0x401AB92")]
		[FieldOffset(Offset = "0x98")]
		public string charName;

		// Token: 0x0401AB93 RID: 109459
		[Token(Token = "0x401AB93")]
		[FieldOffset(Offset = "0xA0")]
		public bool switchOn;

		// Token: 0x0401AB94 RID: 109460
		[Token(Token = "0x401AB94")]
		[FieldOffset(Offset = "0xA8")]
		public string animDirection;

		// Token: 0x0401AB95 RID: 109461
		[Token(Token = "0x401AB95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200369B RID: 13979
		[Token(Token = "0x200369B")]
		public enum ParamType
		{
			// Token: 0x0401AB97 RID: 109463
			[Token(Token = "0x401AB97")]
			NONE,
			// Token: 0x0401AB98 RID: 109464
			[Token(Token = "0x401AB98")]
			CHAR,
			// Token: 0x0401AB99 RID: 109465
			[Token(Token = "0x401AB99")]
			BACKGROUND,
			// Token: 0x0401AB9A RID: 109466
			[Token(Token = "0x401AB9A")]
			AVATAR
		}
	}
}
