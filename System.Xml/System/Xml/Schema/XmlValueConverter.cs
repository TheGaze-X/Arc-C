using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	internal abstract class XmlValueConverter
	{
		// Token: 0x06000B20 RID: 2848
		[Token(Token = "0x6000B20")]
		public abstract bool ToBoolean(long value);

		// Token: 0x06000B21 RID: 2849
		[Token(Token = "0x6000B21")]
		public abstract bool ToBoolean(int value);

		// Token: 0x06000B22 RID: 2850
		[Token(Token = "0x6000B22")]
		public abstract bool ToBoolean(double value);

		// Token: 0x06000B23 RID: 2851
		[Token(Token = "0x6000B23")]
		public abstract bool ToBoolean(DateTime value);

		// Token: 0x06000B24 RID: 2852
		[Token(Token = "0x6000B24")]
		public abstract bool ToBoolean(string value);

		// Token: 0x06000B25 RID: 2853
		[Token(Token = "0x6000B25")]
		public abstract bool ToBoolean(object value);

		// Token: 0x06000B26 RID: 2854
		[Token(Token = "0x6000B26")]
		public abstract int ToInt32(bool value);

		// Token: 0x06000B27 RID: 2855
		[Token(Token = "0x6000B27")]
		public abstract int ToInt32(long value);

		// Token: 0x06000B28 RID: 2856
		[Token(Token = "0x6000B28")]
		public abstract int ToInt32(double value);

		// Token: 0x06000B29 RID: 2857
		[Token(Token = "0x6000B29")]
		public abstract int ToInt32(DateTime value);

		// Token: 0x06000B2A RID: 2858
		[Token(Token = "0x6000B2A")]
		public abstract int ToInt32(string value);

		// Token: 0x06000B2B RID: 2859
		[Token(Token = "0x6000B2B")]
		public abstract int ToInt32(object value);

		// Token: 0x06000B2C RID: 2860
		[Token(Token = "0x6000B2C")]
		public abstract long ToInt64(bool value);

		// Token: 0x06000B2D RID: 2861
		[Token(Token = "0x6000B2D")]
		public abstract long ToInt64(int value);

		// Token: 0x06000B2E RID: 2862
		[Token(Token = "0x6000B2E")]
		public abstract long ToInt64(double value);

		// Token: 0x06000B2F RID: 2863
		[Token(Token = "0x6000B2F")]
		public abstract long ToInt64(DateTime value);

		// Token: 0x06000B30 RID: 2864
		[Token(Token = "0x6000B30")]
		public abstract long ToInt64(string value);

		// Token: 0x06000B31 RID: 2865
		[Token(Token = "0x6000B31")]
		public abstract long ToInt64(object value);

		// Token: 0x06000B32 RID: 2866
		[Token(Token = "0x6000B32")]
		public abstract decimal ToDecimal(string value);

		// Token: 0x06000B33 RID: 2867
		[Token(Token = "0x6000B33")]
		public abstract decimal ToDecimal(object value);

		// Token: 0x06000B34 RID: 2868
		[Token(Token = "0x6000B34")]
		public abstract double ToDouble(bool value);

		// Token: 0x06000B35 RID: 2869
		[Token(Token = "0x6000B35")]
		public abstract double ToDouble(int value);

		// Token: 0x06000B36 RID: 2870
		[Token(Token = "0x6000B36")]
		public abstract double ToDouble(long value);

		// Token: 0x06000B37 RID: 2871
		[Token(Token = "0x6000B37")]
		public abstract double ToDouble(DateTime value);

		// Token: 0x06000B38 RID: 2872
		[Token(Token = "0x6000B38")]
		public abstract double ToDouble(string value);

		// Token: 0x06000B39 RID: 2873
		[Token(Token = "0x6000B39")]
		public abstract double ToDouble(object value);

		// Token: 0x06000B3A RID: 2874
		[Token(Token = "0x6000B3A")]
		public abstract float ToSingle(double value);

		// Token: 0x06000B3B RID: 2875
		[Token(Token = "0x6000B3B")]
		public abstract float ToSingle(string value);

		// Token: 0x06000B3C RID: 2876
		[Token(Token = "0x6000B3C")]
		public abstract float ToSingle(object value);

		// Token: 0x06000B3D RID: 2877
		[Token(Token = "0x6000B3D")]
		public abstract DateTime ToDateTime(bool value);

		// Token: 0x06000B3E RID: 2878
		[Token(Token = "0x6000B3E")]
		public abstract DateTime ToDateTime(int value);

		// Token: 0x06000B3F RID: 2879
		[Token(Token = "0x6000B3F")]
		public abstract DateTime ToDateTime(long value);

		// Token: 0x06000B40 RID: 2880
		[Token(Token = "0x6000B40")]
		public abstract DateTime ToDateTime(double value);

		// Token: 0x06000B41 RID: 2881
		[Token(Token = "0x6000B41")]
		public abstract DateTime ToDateTime(DateTimeOffset value);

		// Token: 0x06000B42 RID: 2882
		[Token(Token = "0x6000B42")]
		public abstract DateTime ToDateTime(string value);

		// Token: 0x06000B43 RID: 2883
		[Token(Token = "0x6000B43")]
		public abstract DateTime ToDateTime(object value);

		// Token: 0x06000B44 RID: 2884
		[Token(Token = "0x6000B44")]
		public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

		// Token: 0x06000B45 RID: 2885
		[Token(Token = "0x6000B45")]
		public abstract DateTimeOffset ToDateTimeOffset(string value);

		// Token: 0x06000B46 RID: 2886
		[Token(Token = "0x6000B46")]
		public abstract DateTimeOffset ToDateTimeOffset(object value);

		// Token: 0x06000B47 RID: 2887
		[Token(Token = "0x6000B47")]
		public abstract string ToString(bool value);

		// Token: 0x06000B48 RID: 2888
		[Token(Token = "0x6000B48")]
		public abstract string ToString(int value);

		// Token: 0x06000B49 RID: 2889
		[Token(Token = "0x6000B49")]
		public abstract string ToString(long value);

		// Token: 0x06000B4A RID: 2890
		[Token(Token = "0x6000B4A")]
		public abstract string ToString(decimal value);

		// Token: 0x06000B4B RID: 2891
		[Token(Token = "0x6000B4B")]
		public abstract string ToString(float value);

		// Token: 0x06000B4C RID: 2892
		[Token(Token = "0x6000B4C")]
		public abstract string ToString(double value);

		// Token: 0x06000B4D RID: 2893
		[Token(Token = "0x6000B4D")]
		public abstract string ToString(DateTime value);

		// Token: 0x06000B4E RID: 2894
		[Token(Token = "0x6000B4E")]
		public abstract string ToString(DateTimeOffset value);

		// Token: 0x06000B4F RID: 2895
		[Token(Token = "0x6000B4F")]
		public abstract string ToString(object value);

		// Token: 0x06000B50 RID: 2896
		[Token(Token = "0x6000B50")]
		public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000B51 RID: 2897
		[Token(Token = "0x6000B51")]
		public abstract object ChangeType(bool value, Type destinationType);

		// Token: 0x06000B52 RID: 2898
		[Token(Token = "0x6000B52")]
		public abstract object ChangeType(int value, Type destinationType);

		// Token: 0x06000B53 RID: 2899
		[Token(Token = "0x6000B53")]
		public abstract object ChangeType(long value, Type destinationType);

		// Token: 0x06000B54 RID: 2900
		[Token(Token = "0x6000B54")]
		public abstract object ChangeType(decimal value, Type destinationType);

		// Token: 0x06000B55 RID: 2901
		[Token(Token = "0x6000B55")]
		public abstract object ChangeType(double value, Type destinationType);

		// Token: 0x06000B56 RID: 2902
		[Token(Token = "0x6000B56")]
		public abstract object ChangeType(DateTime value, Type destinationType);

		// Token: 0x06000B57 RID: 2903
		[Token(Token = "0x6000B57")]
		public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000B58 RID: 2904
		[Token(Token = "0x6000B58")]
		public abstract object ChangeType(object value, Type destinationType);

		// Token: 0x06000B59 RID: 2905
		[Token(Token = "0x6000B59")]
		public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlValueConverter()
		{
		}
	}
}
