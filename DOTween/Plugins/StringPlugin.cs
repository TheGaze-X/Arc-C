using System;
using System.Collections.Generic;
using System.Text;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions>
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x3756290", Offset = "0x3754E90", VA = "0x183756290", Slot = "5")]
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x37561C0", Offset = "0x3754DC0", VA = "0x1837561C0", Slot = "6")]
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately, bool isRelative)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x3755DB0", Offset = "0x37549B0", VA = "0x183755DB0", Slot = "4")]
		public override void Reset(TweenerCore<string, string, StringOptions> t)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "7")]
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value)
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x3755F50", Offset = "0x3754B50", VA = "0x183755F50", Slot = "9")]
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3755D50", Offset = "0x3754950", VA = "0x183755D50", Slot = "10")]
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue)
		{
			return 0f;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x3755780", Offset = "0x3754380", VA = "0x183755780", Slot = "11")]
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x3755030", Offset = "0x3753C30", VA = "0x183755030")]
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled)
		{
			return null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x3755E30", Offset = "0x3754A30", VA = "0x183755E30")]
		private char[] ScrambledCharsToUse(StringOptions options)
		{
			return null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x3756420", Offset = "0x3755020", VA = "0x183756420")]
		public StringPlugin()
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x0")]
		private static readonly StringBuilder _Buffer;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<char> _OpenedTags;
	}
}
