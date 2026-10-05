using System;
using EaseFunctions;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003704 RID: 14084
	[Token(Token = "0x2003704")]
	public abstract class IntTweenSetter : UITweenSetter<int>
	{
		// Token: 0x060165BD RID: 91581 RVA: 0x00090B70 File Offset: 0x0008ED70
		[Token(Token = "0x60165BD")]
		[Address(RVA = "0xEC2D30", Offset = "0xEC1930", VA = "0x180EC2D30", Slot = "6")]
		protected sealed override bool IsEqual(int lhs, int rhs)
		{
			return default(bool);
		}

		// Token: 0x060165BE RID: 91582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165BE")]
		[Address(RVA = "0xEC2AD0", Offset = "0xEC16D0", VA = "0x180EC2AD0", Slot = "8")]
		protected sealed override void BeforeTweenStart(int from, int to)
		{
		}

		// Token: 0x060165BF RID: 91583 RVA: 0x00090B88 File Offset: 0x0008ED88
		[Token(Token = "0x60165BF")]
		[Address(RVA = "0xEC2BB0", Offset = "0xEC17B0", VA = "0x180EC2BB0", Slot = "10")]
		protected virtual Interpolator.EaseType GetEaseType()
		{
			return Interpolator.EaseType.unset;
		}

		// Token: 0x060165C0 RID: 91584 RVA: 0x00090BA0 File Offset: 0x0008EDA0
		[Token(Token = "0x60165C0")]
		[Address(RVA = "0xEC2C10", Offset = "0xEC1810", VA = "0x180EC2C10", Slot = "5")]
		protected override int Interpolate(int from, int to, float k)
		{
			return 0;
		}

		// Token: 0x060165C1 RID: 91585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165C1")]
		[Address(RVA = "0xEC2DC0", Offset = "0xEC19C0", VA = "0x180EC2DC0")]
		protected IntTweenSetter()
		{
		}

		// Token: 0x0401AE56 RID: 110166
		[Token(Token = "0x401AE56")]
		[FieldOffset(Offset = "0x28")]
		private Interpolator.EasingFunction m_easeFunc;

		// Token: 0x0401AE57 RID: 110167
		[Token(Token = "0x401AE57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEqual;

		// Token: 0x0401AE58 RID: 110168
		[Token(Token = "0x401AE58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeTweenStart;

		// Token: 0x0401AE59 RID: 110169
		[Token(Token = "0x401AE59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEaseType;

		// Token: 0x0401AE5A RID: 110170
		[Token(Token = "0x401AE5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Interpolate;

		// Token: 0x0401AE5B RID: 110171
		[Token(Token = "0x401AE5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
