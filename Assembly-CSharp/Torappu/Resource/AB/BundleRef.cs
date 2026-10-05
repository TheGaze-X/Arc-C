using System;
using Il2CppDummyDll;

namespace Torappu.Resource.AB
{
	// Token: 0x02001777 RID: 6007
	[Token(Token = "0x2001777")]
	public abstract class BundleRef
	{
		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600979F RID: 38815 RVA: 0x0003AE60 File Offset: 0x00039060
		[Token(Token = "0x17001044")]
		public int refCounter
		{
			[Token(Token = "0x600979F")]
			[Address(RVA = "0x3122ED0", Offset = "0x3121AD0", VA = "0x183122ED0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060097A0 RID: 38816 RVA: 0x0003AE78 File Offset: 0x00039078
		[Token(Token = "0x17001045")]
		public int refCounterExceptInnerSCC
		{
			[Token(Token = "0x60097A0")]
			[Address(RVA = "0x3122EC0", Offset = "0x3121AC0", VA = "0x183122EC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A1")]
		[Address(RVA = "0x3122EA0", Offset = "0x3121AA0", VA = "0x183122EA0")]
		public BundleRef()
		{
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A2")]
		[Address(RVA = "0x3122D20", Offset = "0x3121920", VA = "0x183122D20")]
		public void AddBundleRef(bool sameSCC, int delta = 1)
		{
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A3")]
		[Address(RVA = "0x3122D10", Offset = "0x3121910", VA = "0x183122D10")]
		public void AddAssetRef(int delta = 1)
		{
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x0003AE90 File Offset: 0x00039090
		[Token(Token = "0x60097A4")]
		[Address(RVA = "0x3122DE0", Offset = "0x31219E0", VA = "0x183122DE0")]
		public bool DecBundleRef(bool sameSCC, int delta = 1, bool dontCheck = false)
		{
			return default(bool);
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x0003AEA8 File Offset: 0x000390A8
		[Token(Token = "0x60097A5")]
		[Address(RVA = "0x3122D80", Offset = "0x3121980", VA = "0x183122D80")]
		public bool DecAssetRef(int delta = 1, bool dontCheck = false)
		{
			return default(bool);
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x0003AEC0 File Offset: 0x000390C0
		[Token(Token = "0x60097A6")]
		[Address(RVA = "0x3122D30", Offset = "0x3121930", VA = "0x183122D30")]
		public bool CheckRefInvalid()
		{
			return default(bool);
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A7")]
		[Address(RVA = "0x3122E60", Offset = "0x3121A60", VA = "0x183122E60")]
		public void ForceDestroy()
		{
		}

		// Token: 0x060097A8 RID: 38824
		[Token(Token = "0x60097A8")]
		protected abstract void OnDestroy();

		// Token: 0x04008DC0 RID: 36288
		[Token(Token = "0x4008DC0")]
		[FieldOffset(Offset = "0x10")]
		private int m_outerSCCBundleRef;

		// Token: 0x04008DC1 RID: 36289
		[Token(Token = "0x4008DC1")]
		[FieldOffset(Offset = "0x14")]
		private int m_innerSCCBundleRef;

		// Token: 0x04008DC2 RID: 36290
		[Token(Token = "0x4008DC2")]
		[FieldOffset(Offset = "0x18")]
		private int m_assetRef;
	}
}
