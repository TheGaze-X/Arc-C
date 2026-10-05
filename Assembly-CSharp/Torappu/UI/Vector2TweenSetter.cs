using System;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003707 RID: 14087
	[Token(Token = "0x2003707")]
	public abstract class Vector2TweenSetter : UITweenSetter<Vector2>
	{
		// Token: 0x060165CC RID: 91596 RVA: 0x00090C48 File Offset: 0x0008EE48
		[Token(Token = "0x60165CC")]
		[Address(RVA = "0xED7360", Offset = "0xED5F60", VA = "0x180ED7360", Slot = "6")]
		protected sealed override bool IsEqual(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		// Token: 0x060165CD RID: 91597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165CD")]
		[Address(RVA = "0xED7100", Offset = "0xED5D00", VA = "0x180ED7100", Slot = "8")]
		protected sealed override void BeforeTweenStart(Vector2 from, Vector2 to)
		{
		}

		// Token: 0x060165CE RID: 91598 RVA: 0x00090C60 File Offset: 0x0008EE60
		[Token(Token = "0x60165CE")]
		[Address(RVA = "0xED71F0", Offset = "0xED5DF0", VA = "0x180ED71F0", Slot = "10")]
		protected virtual Interpolator.EaseType GetEaseType()
		{
			return Interpolator.EaseType.unset;
		}

		// Token: 0x060165CF RID: 91599 RVA: 0x00090C78 File Offset: 0x0008EE78
		[Token(Token = "0x60165CF")]
		[Address(RVA = "0xED7250", Offset = "0xED5E50", VA = "0x180ED7250", Slot = "5")]
		protected override Vector2 Interpolate(Vector2 from, Vector2 to, float k)
		{
			return default(Vector2);
		}

		// Token: 0x060165D0 RID: 91600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165D0")]
		[Address(RVA = "0xED7420", Offset = "0xED6020", VA = "0x180ED7420")]
		protected Vector2TweenSetter()
		{
		}

		// Token: 0x0401AE68 RID: 110184
		[Token(Token = "0x401AE68")]
		[FieldOffset(Offset = "0x38")]
		private Interpolator.EasingFunction m_easeFunc;

		// Token: 0x0401AE69 RID: 110185
		[Token(Token = "0x401AE69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEqual;

		// Token: 0x0401AE6A RID: 110186
		[Token(Token = "0x401AE6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeTweenStart;

		// Token: 0x0401AE6B RID: 110187
		[Token(Token = "0x401AE6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEaseType;

		// Token: 0x0401AE6C RID: 110188
		[Token(Token = "0x401AE6C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Interpolate;

		// Token: 0x0401AE6D RID: 110189
		[Token(Token = "0x401AE6D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
