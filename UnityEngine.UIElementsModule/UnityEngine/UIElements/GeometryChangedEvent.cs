using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
	{
		// Token: 0x06000BC4 RID: 3012 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x5ADE2C0", Offset = "0x5ADCEC0", VA = "0x185ADE2C0")]
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
		{
			return null;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x5ADE350", Offset = "0x5ADCF50", VA = "0x185ADE350", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x5ADE3C0", Offset = "0x5ADCFC0", VA = "0x185ADE3C0")]
		private void LocalInit()
		{
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00006270 File Offset: 0x00004470
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000296")]
		public Rect oldRect
		{
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x2203A40", Offset = "0x2202640", VA = "0x182203A40")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x5ADE4D0", Offset = "0x5ADD0D0", VA = "0x185ADE4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00006288 File Offset: 0x00004488
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000297")]
		public Rect newRect
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x5ADE4B0", Offset = "0x5ADD0B0", VA = "0x185ADE4B0")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x5ADE4C0", Offset = "0x5ADD0C0", VA = "0x185ADE4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000062A0 File Offset: 0x000044A0
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000298")]
		internal int layoutPass
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x371A2F0", Offset = "0x3718EF0", VA = "0x18371A2F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0xD6EF30", Offset = "0xD6DB30", VA = "0x180D6EF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x5ADE410", Offset = "0x5ADD010", VA = "0x185ADE410")]
		public GeometryChangedEvent()
		{
		}
	}
}
