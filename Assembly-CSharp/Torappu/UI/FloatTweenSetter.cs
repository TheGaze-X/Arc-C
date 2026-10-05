using System;
using EaseFunctions;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003705 RID: 14085
	[Token(Token = "0x2003705")]
	public abstract class FloatTweenSetter : UITweenSetter<float>
	{
		// Token: 0x060165C2 RID: 91586 RVA: 0x00090BB8 File Offset: 0x0008EDB8
		[Token(Token = "0x60165C2")]
		[Address(RVA = "0xEC26B0", Offset = "0xEC12B0", VA = "0x180EC26B0", Slot = "6")]
		protected sealed override bool IsEqual(float lhs, float rhs)
		{
			return default(bool);
		}

		// Token: 0x060165C3 RID: 91587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165C3")]
		[Address(RVA = "0xEC24A0", Offset = "0xEC10A0", VA = "0x180EC24A0", Slot = "8")]
		protected sealed override void BeforeTweenStart(float from, float to)
		{
		}

		// Token: 0x060165C4 RID: 91588 RVA: 0x00090BD0 File Offset: 0x0008EDD0
		[Token(Token = "0x60165C4")]
		[Address(RVA = "0xEC2590", Offset = "0xEC1190", VA = "0x180EC2590", Slot = "10")]
		protected virtual Interpolator.EaseType GetEaseType()
		{
			return Interpolator.EaseType.unset;
		}

		// Token: 0x060165C5 RID: 91589 RVA: 0x00090BE8 File Offset: 0x0008EDE8
		[Token(Token = "0x60165C5")]
		[Address(RVA = "0xEC25F0", Offset = "0xEC11F0", VA = "0x180EC25F0", Slot = "5")]
		protected override float Interpolate(float from, float to, float k)
		{
			return 0f;
		}

		// Token: 0x060165C6 RID: 91590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165C6")]
		[Address(RVA = "0xEC2760", Offset = "0xEC1360", VA = "0x180EC2760")]
		protected FloatTweenSetter()
		{
		}

		// Token: 0x0401AE5C RID: 110172
		[Token(Token = "0x401AE5C")]
		[FieldOffset(Offset = "0x28")]
		private Interpolator.EasingFunction m_easeFunc;

		// Token: 0x0401AE5D RID: 110173
		[Token(Token = "0x401AE5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEqual;

		// Token: 0x0401AE5E RID: 110174
		[Token(Token = "0x401AE5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeTweenStart;

		// Token: 0x0401AE5F RID: 110175
		[Token(Token = "0x401AE5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEaseType;

		// Token: 0x0401AE60 RID: 110176
		[Token(Token = "0x401AE60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Interpolate;

		// Token: 0x0401AE61 RID: 110177
		[Token(Token = "0x401AE61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
