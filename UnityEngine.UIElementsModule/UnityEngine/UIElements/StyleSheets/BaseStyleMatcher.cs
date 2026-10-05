using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	internal abstract class BaseStyleMatcher
	{
		// Token: 0x060014C7 RID: 5319
		[Token(Token = "0x60014C7")]
		protected abstract bool MatchKeyword(string keyword);

		// Token: 0x060014C8 RID: 5320
		[Token(Token = "0x60014C8")]
		protected abstract bool MatchNumber();

		// Token: 0x060014C9 RID: 5321
		[Token(Token = "0x60014C9")]
		protected abstract bool MatchInteger();

		// Token: 0x060014CA RID: 5322
		[Token(Token = "0x60014CA")]
		protected abstract bool MatchLength();

		// Token: 0x060014CB RID: 5323
		[Token(Token = "0x60014CB")]
		protected abstract bool MatchPercentage();

		// Token: 0x060014CC RID: 5324
		[Token(Token = "0x60014CC")]
		protected abstract bool MatchColor();

		// Token: 0x060014CD RID: 5325
		[Token(Token = "0x60014CD")]
		protected abstract bool MatchResource();

		// Token: 0x060014CE RID: 5326
		[Token(Token = "0x60014CE")]
		protected abstract bool MatchUrl();

		// Token: 0x060014CF RID: 5327
		[Token(Token = "0x60014CF")]
		protected abstract bool MatchTime();

		// Token: 0x060014D0 RID: 5328
		[Token(Token = "0x60014D0")]
		protected abstract bool MatchAngle();

		// Token: 0x060014D1 RID: 5329
		[Token(Token = "0x60014D1")]
		protected abstract bool MatchCustomIdent();

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060014D2 RID: 5330
		[Token(Token = "0x1700051E")]
		public abstract int valueCount { [Token(Token = "0x60014D2")] get; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060014D3 RID: 5331
		[Token(Token = "0x1700051F")]
		public abstract bool isCurrentVariable { [Token(Token = "0x60014D3")] get; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060014D4 RID: 5332
		[Token(Token = "0x17000520")]
		public abstract bool isCurrentComma { [Token(Token = "0x60014D4")] get; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x17000521")]
		public bool hasCurrent
		{
			[Token(Token = "0x60014D5")]
			[Address(RVA = "0x5A7A8D0", Offset = "0x5A794D0", VA = "0x185A7A8D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0000B1D8 File Offset: 0x000093D8
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000522")]
		public int currentIndex
		{
			[Token(Token = "0x60014D6")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60014D7")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0000B1F0 File Offset: 0x000093F0
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000523")]
		public int matchedVariableCount
		{
			[Token(Token = "0x60014D8")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60014D9")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x5A796F0", Offset = "0x5A782F0", VA = "0x185A796F0")]
		protected void Initialize()
		{
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x5A7A6B0", Offset = "0x5A792B0", VA = "0x185A7A6B0")]
		public void MoveNext()
		{
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x5A7A750", Offset = "0x5A79350", VA = "0x185A7A750")]
		public void SaveContext()
		{
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x5A7A700", Offset = "0x5A79300", VA = "0x185A7A700")]
		public void RestoreContext()
		{
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x5A796A0", Offset = "0x5A782A0", VA = "0x185A796A0")]
		public void DropContext()
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x5A7A4D0", Offset = "0x5A790D0", VA = "0x185A7A4D0")]
		protected bool Match(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x5A79D20", Offset = "0x5A78920", VA = "0x185A79D20")]
		private bool MatchExpression(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x5A79BC0", Offset = "0x5A787C0", VA = "0x185A79BC0")]
		private bool MatchExpressionWithMultiplier(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x5A79F40", Offset = "0x5A78B40", VA = "0x185A79F40")]
		private bool MatchGroup(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x5A79780", Offset = "0x5A78380", VA = "0x185A79780")]
		private bool MatchCombinator(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x5A7A3A0", Offset = "0x5A78FA0", VA = "0x185A7A3A0")]
		private bool MatchOr(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x5A7A380", Offset = "0x5A78F80", VA = "0x185A7A380")]
		private bool MatchOrOr(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x5A79740", Offset = "0x5A78340", VA = "0x185A79740")]
		private bool MatchAndAnd(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x5A7A1D0", Offset = "0x5A78DD0", VA = "0x185A7A1D0")]
		private int MatchMany(Expression exp)
		{
			return 0;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x5A7A070", Offset = "0x5A78C70", VA = "0x185A7A070")]
		private unsafe int MatchManyByOrder(Expression exp, int* matchOrder)
		{
			return 0;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x5A79FF0", Offset = "0x5A78BF0", VA = "0x185A79FF0")]
		private bool MatchJuxtaposition(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x5A79AB0", Offset = "0x5A786B0", VA = "0x185A79AB0")]
		private bool MatchDataType(Expression exp)
		{
			return default(bool);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x5A7A840", Offset = "0x5A79440", VA = "0x185A7A840")]
		protected BaseStyleMatcher()
		{
		}

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly Regex s_CustomIdentRegex;

		// Token: 0x04000C70 RID: 3184
		[Token(Token = "0x4000C70")]
		[FieldOffset(Offset = "0x10")]
		private Stack<BaseStyleMatcher.MatchContext> m_ContextStack;

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		[FieldOffset(Offset = "0x18")]
		private BaseStyleMatcher.MatchContext m_CurrentContext;

		// Token: 0x020002FC RID: 764
		[Token(Token = "0x20002FC")]
		private struct MatchContext
		{
			// Token: 0x04000C72 RID: 3186
			[Token(Token = "0x4000C72")]
			[FieldOffset(Offset = "0x0")]
			public int valueIndex;

			// Token: 0x04000C73 RID: 3187
			[Token(Token = "0x4000C73")]
			[FieldOffset(Offset = "0x4")]
			public int matchedVariableCount;
		}
	}
}
