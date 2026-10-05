using System;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003706 RID: 14086
	[Token(Token = "0x2003706")]
	public abstract class ColorTweenSetter : UITweenSetter<Color>
	{
		// Token: 0x060165C7 RID: 91591 RVA: 0x00090C00 File Offset: 0x0008EE00
		[Token(Token = "0x60165C7")]
		[Address(RVA = "0xEC1AC0", Offset = "0xEC06C0", VA = "0x180EC1AC0", Slot = "6")]
		protected sealed override bool IsEqual(Color lhs, Color rhs)
		{
			return default(bool);
		}

		// Token: 0x060165C8 RID: 91592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165C8")]
		[Address(RVA = "0xEC1760", Offset = "0xEC0360", VA = "0x180EC1760", Slot = "8")]
		protected sealed override void BeforeTweenStart(Color from, Color to)
		{
		}

		// Token: 0x060165C9 RID: 91593 RVA: 0x00090C18 File Offset: 0x0008EE18
		[Token(Token = "0x60165C9")]
		[Address(RVA = "0xEC1860", Offset = "0xEC0460", VA = "0x180EC1860", Slot = "10")]
		protected virtual Interpolator.EaseType GetEaseType()
		{
			return Interpolator.EaseType.unset;
		}

		// Token: 0x060165CA RID: 91594 RVA: 0x00090C30 File Offset: 0x0008EE30
		[Token(Token = "0x60165CA")]
		[Address(RVA = "0xEC18C0", Offset = "0xEC04C0", VA = "0x180EC18C0", Slot = "5")]
		protected override Color Interpolate(Color from, Color to, float k)
		{
			return default(Color);
		}

		// Token: 0x060165CB RID: 91595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165CB")]
		[Address(RVA = "0xEC1BE0", Offset = "0xEC07E0", VA = "0x180EC1BE0")]
		protected ColorTweenSetter()
		{
		}

		// Token: 0x0401AE62 RID: 110178
		[Token(Token = "0x401AE62")]
		[FieldOffset(Offset = "0x50")]
		private Interpolator.EasingFunction m_easeFunc;

		// Token: 0x0401AE63 RID: 110179
		[Token(Token = "0x401AE63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEqual;

		// Token: 0x0401AE64 RID: 110180
		[Token(Token = "0x401AE64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeTweenStart;

		// Token: 0x0401AE65 RID: 110181
		[Token(Token = "0x401AE65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEaseType;

		// Token: 0x0401AE66 RID: 110182
		[Token(Token = "0x401AE66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Interpolate;

		// Token: 0x0401AE67 RID: 110183
		[Token(Token = "0x401AE67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
