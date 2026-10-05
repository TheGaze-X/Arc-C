using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200591F RID: 22815
	[Token(Token = "0x200591F")]
	public struct CrisisV2DiagramInput : IHotfixable
	{
		// Token: 0x0402D47E RID: 185470
		[Token(Token = "0x402D47E")]
		[FieldOffset(Offset = "0x0")]
		public CrisisV2DiagramInput.ScoreInput scoreInput;

		// Token: 0x0402D47F RID: 185471
		[Token(Token = "0x402D47F")]
		[FieldOffset(Offset = "0x28")]
		public bool needTween;

		// Token: 0x0402D480 RID: 185472
		[Token(Token = "0x402D480")]
		[FieldOffset(Offset = "0x2C")]
		public CrisisV2DiagramInput.TweenInput tweenInput;

		// Token: 0x0402D481 RID: 185473
		[Token(Token = "0x402D481")]
		[FieldOffset(Offset = "0x38")]
		public CrisisV2DiagramInput.StyleConfig styleConfig;

		// Token: 0x0402D482 RID: 185474
		[Token(Token = "0x402D482")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CrisisV2DiagramInput EMPTY;

		// Token: 0x02005920 RID: 22816
		[Token(Token = "0x2005920")]
		public enum DisplayScoreType
		{
			// Token: 0x0402D484 RID: 185476
			[Token(Token = "0x402D484")]
			NONE,
			// Token: 0x0402D485 RID: 185477
			[Token(Token = "0x402D485")]
			CURRENT,
			// Token: 0x0402D486 RID: 185478
			[Token(Token = "0x402D486")]
			HIGHEST_TOTAL,
			// Token: 0x0402D487 RID: 185479
			[Token(Token = "0x402D487")]
			HIGHEST_SINGLE
		}

		// Token: 0x02005921 RID: 22817
		[Token(Token = "0x2005921")]
		public struct TweenInput
		{
			// Token: 0x0402D488 RID: 185480
			[Token(Token = "0x402D488")]
			[FieldOffset(Offset = "0x0")]
			public float duration;

			// Token: 0x0402D489 RID: 185481
			[Token(Token = "0x402D489")]
			[FieldOffset(Offset = "0x4")]
			public float delay;

			// Token: 0x0402D48A RID: 185482
			[Token(Token = "0x402D48A")]
			[FieldOffset(Offset = "0x8")]
			public Ease ease;
		}

		// Token: 0x02005922 RID: 22818
		[Token(Token = "0x2005922")]
		public struct ScoreInput
		{
			// Token: 0x0402D48B RID: 185483
			[Token(Token = "0x402D48B")]
			[FieldOffset(Offset = "0x0")]
			public List<int> current;

			// Token: 0x0402D48C RID: 185484
			[Token(Token = "0x402D48C")]
			[FieldOffset(Offset = "0x8")]
			public List<int> highestTotal;

			// Token: 0x0402D48D RID: 185485
			[Token(Token = "0x402D48D")]
			[FieldOffset(Offset = "0x10")]
			public List<int> highestSingle;

			// Token: 0x0402D48E RID: 185486
			[Token(Token = "0x402D48E")]
			[FieldOffset(Offset = "0x18")]
			public List<int> maxScore;

			// Token: 0x0402D48F RID: 185487
			[Token(Token = "0x402D48F")]
			[FieldOffset(Offset = "0x20")]
			public CrisisV2DiagramInput.DisplayScoreType displayScoreType;
		}

		// Token: 0x02005923 RID: 22819
		[Token(Token = "0x2005923")]
		public enum DescAndScoreStyle
		{
			// Token: 0x0402D491 RID: 185489
			[Token(Token = "0x402D491")]
			NONE,
			// Token: 0x0402D492 RID: 185490
			[Token(Token = "0x402D492")]
			ACHIEVE,
			// Token: 0x0402D493 RID: 185491
			[Token(Token = "0x402D493")]
			BATTLE_SETTLE
		}

		// Token: 0x02005924 RID: 22820
		[Token(Token = "0x2005924")]
		public enum BackgroundStyle
		{
			// Token: 0x0402D495 RID: 185493
			[Token(Token = "0x402D495")]
			ACHIEVE,
			// Token: 0x0402D496 RID: 185494
			[Token(Token = "0x402D496")]
			MAP,
			// Token: 0x0402D497 RID: 185495
			[Token(Token = "0x402D497")]
			ENTRY,
			// Token: 0x0402D498 RID: 185496
			[Token(Token = "0x402D498")]
			BATTLE_SETTLE_BIG,
			// Token: 0x0402D499 RID: 185497
			[Token(Token = "0x402D499")]
			BATTLE_SETTLE_SMALL
		}

		// Token: 0x02005925 RID: 22821
		[Token(Token = "0x2005925")]
		public struct StyleConfig
		{
			// Token: 0x0402D49A RID: 185498
			[Token(Token = "0x402D49A")]
			[FieldOffset(Offset = "0x0")]
			public float scale;

			// Token: 0x0402D49B RID: 185499
			[Token(Token = "0x402D49B")]
			[FieldOffset(Offset = "0x4")]
			public bool needShowCurrent;

			// Token: 0x0402D49C RID: 185500
			[Token(Token = "0x402D49C")]
			[FieldOffset(Offset = "0x5")]
			public bool needShowHighestSingle;

			// Token: 0x0402D49D RID: 185501
			[Token(Token = "0x402D49D")]
			[FieldOffset(Offset = "0x6")]
			public bool needShowHighestTotal;

			// Token: 0x0402D49E RID: 185502
			[Token(Token = "0x402D49E")]
			[FieldOffset(Offset = "0x8")]
			public Color currentColor;

			// Token: 0x0402D49F RID: 185503
			[Token(Token = "0x402D49F")]
			[FieldOffset(Offset = "0x18")]
			public Color totalColor;

			// Token: 0x0402D4A0 RID: 185504
			[Token(Token = "0x402D4A0")]
			[FieldOffset(Offset = "0x28")]
			public CrisisV2DiagramInput.DescAndScoreStyle descAndScoreStyle;

			// Token: 0x0402D4A1 RID: 185505
			[Token(Token = "0x402D4A1")]
			[FieldOffset(Offset = "0x2C")]
			public CrisisV2DiagramInput.BackgroundStyle backgroundStyle;

			// Token: 0x0402D4A2 RID: 185506
			[Token(Token = "0x402D4A2")]
			[FieldOffset(Offset = "0x30")]
			public List<string> descs;
		}
	}
}
