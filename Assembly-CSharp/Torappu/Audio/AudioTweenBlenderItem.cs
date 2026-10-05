using System;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FAC RID: 8108
	[Token(Token = "0x2001FAC")]
	public class AudioTweenBlenderItem : IHotfixable
	{
		// Token: 0x0600C961 RID: 51553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C961")]
		[Address(RVA = "0x34A4540", Offset = "0x34A3140", VA = "0x1834A4540")]
		public void Start()
		{
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C962")]
		[Address(RVA = "0x34A43B0", Offset = "0x34A2FB0", VA = "0x1834A43B0")]
		public void Remove(bool needReverseTween = true)
		{
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x00049260 File Offset: 0x00047460
		[Token(Token = "0x600C963")]
		[Address(RVA = "0x34A4210", Offset = "0x34A2E10", VA = "0x1834A4210")]
		public float GetValue()
		{
			return 0f;
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x00049278 File Offset: 0x00047478
		[Token(Token = "0x600C964")]
		[Address(RVA = "0x34A42D0", Offset = "0x34A2ED0", VA = "0x1834A42D0")]
		public bool IsItemActive()
		{
			return default(bool);
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C965")]
		[Address(RVA = "0x34A4650", Offset = "0x34A3250", VA = "0x1834A4650")]
		public AudioTweenBlenderItem()
		{
		}

		// Token: 0x0400D02B RID: 53291
		[Token(Token = "0x400D02B")]
		[FieldOffset(Offset = "0x10")]
		public float endValue;

		// Token: 0x0400D02C RID: 53292
		[Token(Token = "0x400D02C")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x0400D02D RID: 53293
		[Token(Token = "0x400D02D")]
		[FieldOffset(Offset = "0x18")]
		public float delay;

		// Token: 0x0400D02E RID: 53294
		[Token(Token = "0x400D02E")]
		[FieldOffset(Offset = "0x1C")]
		public int sequenceNum;

		// Token: 0x0400D02F RID: 53295
		[Token(Token = "0x400D02F")]
		[FieldOffset(Offset = "0x20")]
		public float startValue;

		// Token: 0x0400D030 RID: 53296
		[Token(Token = "0x400D030")]
		[FieldOffset(Offset = "0x24")]
		public float defaultValue;

		// Token: 0x0400D031 RID: 53297
		[Token(Token = "0x400D031")]
		[FieldOffset(Offset = "0x28")]
		public Interpolator.EaseType easeType;

		// Token: 0x0400D032 RID: 53298
		[Token(Token = "0x400D032")]
		[FieldOffset(Offset = "0x2C")]
		public Interpolator.EaseType reverseEaseType;

		// Token: 0x0400D033 RID: 53299
		[Token(Token = "0x400D033")]
		[FieldOffset(Offset = "0x30")]
		public bool ignoreTimeScale;

		// Token: 0x0400D034 RID: 53300
		[Token(Token = "0x400D034")]
		[FieldOffset(Offset = "0x31")]
		public bool stopAfterTween;

		// Token: 0x0400D035 RID: 53301
		[Token(Token = "0x400D035")]
		[FieldOffset(Offset = "0x38")]
		private TweenUtils.SmoothStep m_valueTween;

		// Token: 0x0400D036 RID: 53302
		[Token(Token = "0x400D036")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400D037 RID: 53303
		[Token(Token = "0x400D037")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Remove;

		// Token: 0x0400D038 RID: 53304
		[Token(Token = "0x400D038")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0400D039 RID: 53305
		[Token(Token = "0x400D039")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsItemActive;

		// Token: 0x0400D03A RID: 53306
		[Token(Token = "0x400D03A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
