using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003702 RID: 14082
	[Token(Token = "0x2003702")]
	public abstract class UITweenSetter<ValueType> : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x060165AE RID: 91566 RVA: 0x00090B40 File Offset: 0x0008ED40
		[Token(Token = "0x60165AE")]
		public bool IsTweening()
		{
			return default(bool);
		}

		// Token: 0x060165AF RID: 91567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60165AF")]
		public ValueType GetValue()
		{
			return null;
		}

		// Token: 0x060165B0 RID: 91568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165B0")]
		public void SetValue(ValueType target, bool skipMode = false)
		{
		}

		// Token: 0x060165B1 RID: 91569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165B1")]
		private void _SetValueWithTween(ValueType target)
		{
		}

		// Token: 0x060165B2 RID: 91570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165B2")]
		private void _TweenSetter(float k)
		{
		}

		// Token: 0x060165B3 RID: 91571
		[Token(Token = "0x60165B3")]
		protected abstract void SetValueImpl(ValueType value);

		// Token: 0x060165B4 RID: 91572
		[Token(Token = "0x60165B4")]
		protected abstract ValueType Interpolate(ValueType from, ValueType to, float k);

		// Token: 0x060165B5 RID: 91573
		[Token(Token = "0x60165B5")]
		protected abstract bool IsEqual(ValueType lhs, ValueType rhs);

		// Token: 0x060165B6 RID: 91574
		[Token(Token = "0x60165B6")]
		protected abstract float GetDuration();

		// Token: 0x060165B7 RID: 91575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165B7")]
		protected virtual void BeforeTweenStart(ValueType from, ValueType to)
		{
		}

		// Token: 0x060165B8 RID: 91576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165B8")]
		protected virtual void OnTweenComplete()
		{
		}

		// Token: 0x060165B9 RID: 91577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165B9")]
		protected UITweenSetter()
		{
		}

		// Token: 0x0401AE47 RID: 110151
		[Token(Token = "0x401AE47")]
		[FieldOffset(Offset = "0x0")]
		private ValueType m_curVal;

		// Token: 0x0401AE48 RID: 110152
		[Token(Token = "0x401AE48")]
		[FieldOffset(Offset = "0x0")]
		private ValueType m_fromVal;

		// Token: 0x0401AE49 RID: 110153
		[Token(Token = "0x401AE49")]
		[FieldOffset(Offset = "0x0")]
		private ValueType m_toVal;

		// Token: 0x0401AE4A RID: 110154
		[Token(Token = "0x401AE4A")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isFirstSet;

		// Token: 0x0401AE4B RID: 110155
		[Token(Token = "0x401AE4B")]
		[FieldOffset(Offset = "0x0")]
		private Tween m_tween;

		// Token: 0x0401AE4C RID: 110156
		[Token(Token = "0x401AE4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsTweening;

		// Token: 0x0401AE4D RID: 110157
		[Token(Token = "0x401AE4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0401AE4E RID: 110158
		[Token(Token = "0x401AE4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetValue;

		// Token: 0x0401AE4F RID: 110159
		[Token(Token = "0x401AE4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetValueWithTween;

		// Token: 0x0401AE50 RID: 110160
		[Token(Token = "0x401AE50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TweenSetter;

		// Token: 0x0401AE51 RID: 110161
		[Token(Token = "0x401AE51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BeforeTweenStart;

		// Token: 0x0401AE52 RID: 110162
		[Token(Token = "0x401AE52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTweenComplete;

		// Token: 0x0401AE53 RID: 110163
		[Token(Token = "0x401AE53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
