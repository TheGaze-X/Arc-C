using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002871 RID: 10353
	[Token(Token = "0x2002871")]
	public abstract class ParamParser<T> : IParamParser
	{
		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0601138D RID: 70541
		[Token(Token = "0x170025ED")]
		public abstract ParamRealType[] paramRealTypeMask { [Token(Token = "0x601138D")] get; }

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x0601138E RID: 70542
		[Token(Token = "0x170025EE")]
		public abstract ParamValueType[] paramValueTypeMask { [Token(Token = "0x601138E")] get; }

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0601138F RID: 70543
		[Token(Token = "0x170025EF")]
		public abstract ParamRealType[] paramListRealTypeMask { [Token(Token = "0x601138F")] get; }

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06011390 RID: 70544
		[Token(Token = "0x170025F0")]
		public abstract ParamValueType[] paramListValueTypeMask { [Token(Token = "0x6011390")] get; }

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06011391 RID: 70545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025F1")]
		public Type systemType
		{
			[Token(Token = "0x6011391")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06011392 RID: 70546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025F2")]
		public Type systemListType
		{
			[Token(Token = "0x6011392")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06011393 RID: 70547
		[Token(Token = "0x170025F3")]
		public abstract int lengthPerItem { [Token(Token = "0x6011393")] get; }

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06011394 RID: 70548 RVA: 0x0006A200 File Offset: 0x00068400
		[Token(Token = "0x170025F4")]
		public ParamRealType paramRealType
		{
			[Token(Token = "0x6011394")]
			get
			{
				return ParamRealType.Invalid;
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06011395 RID: 70549 RVA: 0x0006A218 File Offset: 0x00068418
		[Token(Token = "0x170025F5")]
		public ParamValueType paramValueType
		{
			[Token(Token = "0x6011395")]
			get
			{
				return ParamValueType.Invalid;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06011396 RID: 70550 RVA: 0x0006A230 File Offset: 0x00068430
		[Token(Token = "0x170025F6")]
		public ParamRealType paramListRealType
		{
			[Token(Token = "0x6011396")]
			get
			{
				return ParamRealType.Invalid;
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06011397 RID: 70551 RVA: 0x0006A248 File Offset: 0x00068448
		[Token(Token = "0x170025F7")]
		public ParamValueType paramListValueType
		{
			[Token(Token = "0x6011397")]
			get
			{
				return ParamValueType.Invalid;
			}
		}

		// Token: 0x06011398 RID: 70552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011398")]
		public Type GetSystemType(ParamRealType paramRealType)
		{
			return null;
		}

		// Token: 0x06011399 RID: 70553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011399")]
		public ParamVariable ToVariable(ParamValue paramValue)
		{
			return null;
		}

		// Token: 0x0601139A RID: 70554 RVA: 0x0006A260 File Offset: 0x00068460
		[Token(Token = "0x601139A")]
		protected bool CheckParamRealType(ParamRealType targetType, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x0601139B RID: 70555 RVA: 0x0006A278 File Offset: 0x00068478
		[Token(Token = "0x601139B")]
		protected bool CheckParamListRealType(ParamRealType targetType, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x0601139C RID: 70556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601139C")]
		protected virtual T ValueAtIndexGetter(ParamValue paramValue, int index)
		{
			return null;
		}

		// Token: 0x0601139D RID: 70557
		[Token(Token = "0x601139D")]
		protected abstract void ValueAtIndexSetter(ParamValue paramValue, T value, int index);

		// Token: 0x0601139E RID: 70558 RVA: 0x0006A290 File Offset: 0x00068490
		[Token(Token = "0x601139E")]
		public int GetListItemLength(ParamValue paramValue)
		{
			return 0;
		}

		// Token: 0x0601139F RID: 70559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601139F")]
		public ParamValue NewValue(T value)
		{
			return null;
		}

		// Token: 0x060113A0 RID: 70560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113A0")]
		public ParamValue NewListValue(List<T> value)
		{
			return null;
		}

		// Token: 0x060113A1 RID: 70561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113A1")]
		public void SetRaw(ParamValue paramValue, object value)
		{
		}

		// Token: 0x060113A2 RID: 70562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113A2")]
		public void Set(ParamValue paramValue, T value, bool force = false)
		{
		}

		// Token: 0x060113A3 RID: 70563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113A3")]
		public void Set(ParamValue paramValue, List<T> valueList, bool force = false)
		{
		}

		// Token: 0x060113A4 RID: 70564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113A4")]
		public void SetValueAtIndex(ParamValue paramValue, T value, int index)
		{
		}

		// Token: 0x060113A5 RID: 70565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113A5")]
		public T Get(ParamValue paramValue, T defaultValue)
		{
			return null;
		}

		// Token: 0x060113A6 RID: 70566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113A6")]
		public T GetOrNew(ParamValue paramValue, T defaultValue)
		{
			return null;
		}

		// Token: 0x060113A7 RID: 70567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113A7")]
		public List<T> Get(ParamValue paramValue)
		{
			return null;
		}

		// Token: 0x060113A8 RID: 70568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113A8")]
		public List<T> Get(ParamValue paramValue, ref List<T> refList)
		{
			return null;
		}

		// Token: 0x060113A9 RID: 70569 RVA: 0x0006A2A8 File Offset: 0x000684A8
		[Token(Token = "0x60113A9")]
		public bool TryGet(ParamValue paramValue, out T result, bool showWarning = false)
		{
			return default(bool);
		}

		// Token: 0x060113AA RID: 70570 RVA: 0x0006A2C0 File Offset: 0x000684C0
		[Token(Token = "0x60113AA")]
		public bool TryGet(ParamValue paramValue, ref List<T> refList, bool showWarning = false)
		{
			return default(bool);
		}

		// Token: 0x060113AB RID: 70571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113AB")]
		public T GetListItem(ParamValue paramValue, int index, T defaultValue, bool showWarning)
		{
			return null;
		}

		// Token: 0x060113AC RID: 70572 RVA: 0x0006A2D8 File Offset: 0x000684D8
		[Token(Token = "0x60113AC")]
		public bool TryGetListItem(ParamValue paramValue, int index, out T result, bool showWarning)
		{
			return default(bool);
		}

		// Token: 0x060113AD RID: 70573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113AD")]
		public object GetOrNewValueObject(ParamValue paramValue)
		{
			return null;
		}

		// Token: 0x060113AE RID: 70574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113AE")]
		public void ToStringSingle(ParamValue paramValue, out string result, bool force = false)
		{
		}

		// Token: 0x060113AF RID: 70575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113AF")]
		public void ToStringList(ParamValue paramValue, List<string> resultList)
		{
		}

		// Token: 0x060113B0 RID: 70576
		[Token(Token = "0x60113B0")]
		public abstract string ToStringPerItem(ParamValue paramValue, int itemIndex);

		// Token: 0x060113B1 RID: 70577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113B1")]
		protected ParamParser()
		{
		}
	}
}
